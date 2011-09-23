using System;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows;

namespace Octgn
{
    public partial class OctgnApp : Application
    {
        internal const string ClientName = "OCTGN.NET";
        internal static readonly Version OctgnVersion = GetClientVersion();
        internal static readonly Version BackwardCompatibility = new Version(0, 2, 0, 0);

        private static Version GetClientVersion()
        {
            Assembly asm = typeof(OctgnApp).Assembly;
            AssemblyProductAttribute at = (AssemblyProductAttribute)asm.GetCustomAttributes(typeof(AssemblyProductAttribute), false)[0];
            return asm.GetName().Version;
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            Updates.UpgradeSettings();

            Updates.PerformHouskeeping();
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
            AppDomain.CurrentDomain.FirstChanceException += new EventHandler<System.Runtime.ExceptionServices.FirstChanceExceptionEventArgs>(CurrentDomain_FirstChanceException);

            Program.GamesRepository = new Octgn.Data.GamesRepository();

            if(Program.GamesRepository.MissingFiles.Any())
            {
                var sb = new StringBuilder("OCTGN cannot find the following files. The corresponding games have been disabled.\n\n");
                foreach(var file in Program.GamesRepository.MissingFiles)
                    sb.Append(file).Append("\n\n");
                sb.Append("You should restore those files, or re-install the corresponding games.");

                var oldShutdown = ShutdownMode;
                ShutdownMode = System.Windows.ShutdownMode.OnExplicitShutdown;
                new MessageWindow(sb.ToString()).ShowDialog();
                ShutdownMode = oldShutdown;
            }

            base.OnStartup(e);
        }

        private void CurrentDomain_FirstChanceException(object sender, System.Runtime.ExceptionServices.FirstChanceExceptionEventArgs e)
        {
#if(DEBUG)
            //if(System.Diagnostics.Debugger.IsAttached) System.Diagnostics.Debugger.Break();
#endif
        }

        private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            if(!System.Diagnostics.Debugger.IsAttached)
            {
                Exception ex = e.ExceptionObject as Exception;
                var wnd = new ErrorWindow(ex);
                wnd.ShowDialog();
            }
            else
            {
#if(DEBUG)
                System.Diagnostics.Debugger.Break();
#endif
            }
        }

        protected override void OnExit(ExitEventArgs e)
        {
            // Fix: this can happen when the user uses the system close button.
            // If a game is running (e.g. in StartGame.xaml) some threads don't
            // stop (i.e. the database thread and/or the networking threads)
            if(Program.IsGameRunning) Program.StopGame();
            base.OnExit(e);
        }
    }
}