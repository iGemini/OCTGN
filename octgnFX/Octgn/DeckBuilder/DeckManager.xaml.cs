﻿using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

using Octgn.Library;
using System.ComponentModel;
using Octgn.Annotations;

namespace Octgn.DeckBuilder
{
    using System.Threading;
    using System.Windows.Controls;
    using System.Windows.Input;

    using Octgn.Controls;
    using Octgn.Extentions;

    /// <summary>
    /// Interaction logic for DeckManager.xaml
    /// </summary>
    public partial class DeckManager : INotifyPropertyChanged
    {
        private DeckList _selectedList;
        private string _searchString;

        private MetaDeck selectedDeck;

        private bool isLoading;

        private bool canCreateFolder;

        private bool canDeleteFolder;

        private bool canRenameFolder;

        public string SearchString
        {
            get { return _searchString; }
            set
            {
                if (value == _searchString) return;
                _searchString = value;
                OnPropertyChanged("SearchString");
            }
        }

        public DeckList SelectedList
        {
            get { return _selectedList; }
            set
            {
                if (value == _selectedList) return;
                _selectedList = value;
                OnPropertyChanged("SelectedList");
                if (_selectedList == null)
                {
                    CanCreateFolder = false;
                    CanDeleteFolder = false;
                    CanRenameFolder = false;
                    return;
                }
                if (_selectedList.IsRootFolder)
                {
                    CanCreateFolder = false;
                    CanDeleteFolder = false;
                    CanRenameFolder = false;
                    return;
                }
                if (_selectedList.IsGameFolder)
                {
                    CanCreateFolder = true;
                    CanDeleteFolder = false;
                    CanRenameFolder = false;
                    return;
                }
                CanCreateFolder = true;
                CanDeleteFolder = true;
                CanRenameFolder = true;
            }
        }

        public MetaDeck SelectedDeck
        {
            get
            {
                return this.selectedDeck;
            }
            set
            {
                if (Equals(value, this.selectedDeck))
                {
                    return;
                }
                this.selectedDeck = value;
                this.OnPropertyChanged("SelectedDeck");
            }
        }

        public bool IsLoading
        {
            get
            {
                return this.isLoading;
            }
            set
            {
                if (value.Equals(this.isLoading))
                {
                    return;
                }
                this.isLoading = value;
                this.OnPropertyChanged("IsLoading");
            }
        }

        public bool CanCreateFolder
        {
            get
            {
                return this.canCreateFolder;
            }
            set
            {
                if (value.Equals(this.canCreateFolder))
                {
                    return;
                }
                this.canCreateFolder = value;
                this.OnPropertyChanged("CanCreateFolder");
            }
        }

        public bool CanDeleteFolder
        {
            get
            {
                return this.canDeleteFolder;
            }
            set
            {
                if (value.Equals(this.canDeleteFolder))
                {
                    return;
                }
                this.canDeleteFolder = value;
                this.OnPropertyChanged("CanDeleteFolder");
            }
        }

        public bool CanRenameFolder
        {
            get
            {
                return this.canRenameFolder;
            }
            set
            {
                if (value.Equals(this.canRenameFolder))
                {
                    return;
                }
                this.canRenameFolder = value;
                this.OnPropertyChanged("CanRenameFolder");
            }
        }

        public ObservableCollection<DeckList> DeckLists { get; set; }

        public ObservableCollection<MetaDeck> Decks { get; set; }

        public DeckManager()
        {
            Decks = new ObservableCollection<MetaDeck>();
            DeckLists = new ObservableCollection<DeckList>();
            if (!this.IsInDesignMode())
                IsLoading = true;
            InitializeComponent();
            this.Loaded += OnLoaded;
        }

        private void OnLoaded(object sender, RoutedEventArgs routedEventArgs)
        {
            this.Loaded -= OnLoaded;
            Task.Factory.StartNew(() =>
            {
                var list = new DeckList(Paths.Get().DeckPath, this.Dispatcher, true)
                {
                    Name = "All"
                };
                Dispatcher.Invoke(new Action(() => DeckLists.Add(list)));
                Dispatcher.Invoke(new Action(() =>
                {
                    SelectedList = null;
                    SelectedList = list;
                    foreach (DeckList item in FolderTreeView.Items)
                    {
                        if (item.Name != "All") continue;
                        TreeViewItem tvi = FolderTreeView.ItemContainerGenerator.ContainerFromItem(item) as TreeViewItem;
                        if (tvi != null)
                        {
                            Task.Factory.StartNew(() =>
                            {
                                Thread.Sleep(10);
                                Dispatcher.Invoke(new Action(
                                    () =>
                                    {
                                        try
                                        {
                                            tvi.IsSelected = true;
                                        }
                                        catch
                                        {
                                            
                                        }
                                    }));
                            });
                            break;
                        }
                    }
                }));
                IsLoading = false;
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void OnSearchChanged(object sender, TextChangedEventArgs e)
        {
            foreach (var d in SelectedList.Decks)
            {
                d.UpdateFilter(SearchString);
            }
            DeckCardsViewer.FilterChanged(SearchString);
        }

        private void SelectedDeckListChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            foreach (var dl in DeckLists)
            {
                foreach (var d in dl.Decks)
                {
                    d.UpdateFilter(SearchString);
                }
            }
            SelectedList = e.NewValue as DeckList;
        }

        private void ListBoxDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //if (SelectedDeck == null) return;
            //if ( SelectedDeck.IsCorrupt) return;
            //var g = Octgn.DataNew.DbContext.Get().Games.First(x => x.Id == SelectedDeck.GameId);

            //var viewer = new DeckCardsViewer(SelectedDeck,g);
            //var window = new OctgnChrome();
            //window.HorizontalContentAlignment = HorizontalAlignment.Stretch;
            //window.VerticalContentAlignment = VerticalAlignment.Stretch;
            //window.Content = viewer;
            //window.ShowDialog();
        }

        private void EditDeckClick(object sender, RoutedEventArgs e)
        {
            var deck = (sender as Button).DataContext as MetaDeck;
            if (deck == null) return;
            if (deck.IsCorrupt) return;
            var de = new DeckBuilderWindow(deck);
            de.ShowDialog();
        }

        private void SearchDeck(object sender, RoutedEventArgs e)
        {
            var deck = (sender as Button).DataContext as MetaDeck;
            if (deck == null) return;
            if (deck.IsCorrupt) return;
            this.SelectedDeck = deck;
            //var g = Octgn.DataNew.DbContext.Get().Games.First(x => x.Id == deck.GameId);

            DeckCardsViewer.Visibility = Visibility.Visible;

            //var viewer = new DeckCardsViewer(deck, g);
            //var window = new OctgnChrome();
            //window.HorizontalContentAlignment = HorizontalAlignment.Stretch;
            //window.VerticalContentAlignment = VerticalAlignment.Stretch;
            //window.Content = viewer;
            //window.ShowDialog();
        }
    }

    public class DeckList
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public bool IsRootFolder { get; set; }
        public bool IsGameFolder { get; set; }
        public ObservableCollection<DeckList> DeckLists { get; set; }
        public ObservableCollection<MetaDeck> Decks { get; set; }

        public DeckList(string path, Dispatcher disp, bool isRoot = false)
        {
            Path = path;
            Name = new DirectoryInfo(path).Name;

            if (isRoot) IsRootFolder = true;

            DeckLists = new ObservableCollection<DeckList>();
            Decks = new ObservableCollection<MetaDeck>();

            foreach (var f in Directory.GetDirectories(path).Select(x => new DirectoryInfo(x)))
            {
                if (isRoot)
                {
                    if (DataNew
                        .DbContext.Get()
                        .Games
                        .Any(x => x.Name.Equals(f.Name, StringComparison.InvariantCultureIgnoreCase)))
                    {
                        var dl = new DeckList(f.FullName, disp);
                        dl.IsGameFolder = true;
                        disp.Invoke(new Action(() => DeckLists.Add(dl)));
                    }
                }
                else
                {
                    var dl = new DeckList(f.FullName, disp);
                    disp.Invoke(new Action(() => DeckLists.Add(dl)));
                }
            }

            foreach (var f in Directory.GetFiles(Path, "*.o8d"))
            {
                var deck = new MetaDeck(f);
                disp.Invoke(new Action(() => Decks.Add(deck)));
            }
            foreach (var d in DeckLists.SelectMany(x => x.Decks))
            {
                MetaDeck d1 = d;
                disp.Invoke(new Action(() => Decks.Add(d1)));
            }
        }
    }


}
