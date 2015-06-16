﻿/* 
 * This file was automatically generated by MyGeneration! (from BinarySender.zeus)
 * Do not modify, changes will get lost when the file is regenerated!
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;

namespace Octgn.Server
{
	abstract class BaseBinaryStub : Octgn.Server.IClientCalls
	{
	    private Handler handler;
	    
	    public BaseBinaryStub(Handler handler)
	    { this.handler = handler; }
				
		protected abstract void Send(byte[] data);

    public void Binary()
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)0);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void Error(string msg)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)1);
			writer.Write(msg);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void Kick(string reason)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)3);
			writer.Write(reason);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void Welcome(byte id, Guid gameSessionId, bool waitForGameState)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)6);
			writer.Write(id);
			writer.Write(gameSessionId.ToByteArray());
			writer.Write(waitForGameState);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void Settings(bool twoSidedTable, bool allowSpectators, bool muteSpectators)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)7);
			writer.Write(twoSidedTable);
			writer.Write(allowSpectators);
			writer.Write(muteSpectators);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void PlayerSettings(byte playerId, bool invertedTable, bool spectator)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)8);
			writer.Write(playerId);
			writer.Write(invertedTable);
			writer.Write(spectator);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void NewPlayer(byte id, string nick, ulong pkey, bool tableSide, bool spectator)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)9);
			writer.Write(id);
			writer.Write(nick);
			writer.Write(pkey);
			writer.Write(tableSide);
			writer.Write(spectator);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void Leave(byte player)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)10);
			writer.Write(player);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void Nick(byte player, string nick)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)12);
			writer.Write(player);
			writer.Write(nick);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void Start()
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)13);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void Reset(byte player)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)15);
			writer.Write(player);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void NextTurn(byte nextPlayer)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)16);
			writer.Write(nextPlayer);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void StopTurn(byte player)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)18);
			writer.Write(player);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void Chat(byte player, string text)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)20);
			writer.Write(player);
			writer.Write(text);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void Print(byte player, string text)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)22);
			writer.Write(player);
			writer.Write(text);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void Random(int result)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)24);
			writer.Write(result);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void Counter(byte player, int counter, int value)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)26);
			writer.Write(player);
			writer.Write(counter);
			writer.Write(value);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void LoadDeck(int[] id, Guid[] type, int[] group, string[] size, string sleeve)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)27);
			writer.Write((short)id.Length);
			foreach (int p in id)
				writer.Write(p);
			writer.Write((short)type.Length);
			foreach (Guid g in type)
				writer.Write(g.ToByteArray());
			writer.Write((short)group.Length);
			foreach (int p in group)
				writer.Write(p);
			writer.Write((short)size.Length);
			foreach (string s in size)
				writer.Write(s);
			writer.Write(sleeve);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void CreateCard(int[] id, Guid[] type, string[] size, int group)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)28);
			writer.Write((short)id.Length);
			foreach (int p in id)
				writer.Write(p);
			writer.Write((short)type.Length);
			foreach (Guid g in type)
				writer.Write(g.ToByteArray());
			writer.Write((short)size.Length);
			foreach (string s in size)
				writer.Write(s);
			writer.Write(group);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void CreateCardAt(int[] id, Guid[] modelId, int[] x, int[] y, bool faceUp, bool persist)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)29);
			writer.Write((short)id.Length);
			foreach (int p in id)
				writer.Write(p);
			writer.Write((short)modelId.Length);
			foreach (Guid g in modelId)
				writer.Write(g.ToByteArray());
			writer.Write((short)x.Length);
			foreach (int p in x)
				writer.Write(p);
			writer.Write((short)y.Length);
			foreach (int p in y)
				writer.Write(p);
			writer.Write(faceUp);
			writer.Write(persist);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void CreateAliasDeprecated(int[] id, ulong[] type)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)30);
			writer.Write((short)id.Length);
			foreach (int p in id)
				writer.Write(p);
			writer.Write((short)type.Length);
						foreach (ulong p in type)
							writer.Write(p);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void MoveCard(byte player, int[] id, int group, int[] idx, bool[] faceUp, bool isScriptMove)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)32);
			writer.Write(player);
			writer.Write((short)id.Length);
			foreach (int p in id)
				writer.Write(p);
			writer.Write(group);
			writer.Write((short)idx.Length);
			foreach (int p in idx)
				writer.Write(p);
			writer.Write((short)faceUp.Length);
			foreach (bool p in faceUp)
				writer.Write(p);
			writer.Write(isScriptMove);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void MoveCardAt(byte player, int[] id, int[] x, int[] y, int[] idx, bool[] faceUp, bool isScriptMove)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)34);
			writer.Write(player);
			writer.Write((short)id.Length);
			foreach (int p in id)
				writer.Write(p);
			writer.Write((short)x.Length);
			foreach (int p in x)
				writer.Write(p);
			writer.Write((short)y.Length);
			foreach (int p in y)
				writer.Write(p);
			writer.Write((short)idx.Length);
			foreach (int p in idx)
				writer.Write(p);
			writer.Write((short)faceUp.Length);
			foreach (bool p in faceUp)
				writer.Write(p);
			writer.Write(isScriptMove);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void Peek(byte player, int card)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)36);
			writer.Write(player);
			writer.Write(card);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void Untarget(byte player, int card)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)38);
			writer.Write(player);
			writer.Write(card);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void Target(byte player, int card)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)40);
			writer.Write(player);
			writer.Write(card);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void TargetArrow(byte player, int card, int otherCard)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)42);
			writer.Write(player);
			writer.Write(card);
			writer.Write(otherCard);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void Highlight(int card, string color)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)43);
			writer.Write(card);
			writer.Write(color);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void Turn(byte player, int card, bool up)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)45);
			writer.Write(player);
			writer.Write(card);
			writer.Write(up);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void Rotate(byte player, int card, CardOrientation rot)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)47);
			writer.Write(player);
			writer.Write(card);
			writer.Write((byte)rot);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void ShuffleDeprecated(int group, int[] card)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)48);
			writer.Write(group);
			writer.Write((short)card.Length);
			foreach (int p in card)
				writer.Write(p);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void Shuffled(byte player, int group, int[] card, short[] pos)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)49);
			writer.Write(player);
			writer.Write(group);
			writer.Write((short)card.Length);
			foreach (int p in card)
				writer.Write(p);
			writer.Write((short)pos.Length);
			foreach (short p in pos)
				writer.Write(p);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void UnaliasGrpDeprecated(int group)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)50);
			writer.Write(group);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void UnaliasDeprecated(int[] card, ulong[] type)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)51);
			writer.Write((short)card.Length);
			foreach (int p in card)
				writer.Write(p);
			writer.Write((short)type.Length);
						foreach (ulong p in type)
							writer.Write(p);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void AddMarker(byte player, int card, Guid id, string name, ushort count, ushort origCount, bool isScriptChange)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)53);
			writer.Write(player);
			writer.Write(card);
			writer.Write(id.ToByteArray());
			writer.Write(name);
			writer.Write(count);
			writer.Write(origCount);
			writer.Write(isScriptChange);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void RemoveMarker(byte player, int card, Guid id, string name, ushort count, ushort origCount, bool isScriptChange)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)55);
			writer.Write(player);
			writer.Write(card);
			writer.Write(id.ToByteArray());
			writer.Write(name);
			writer.Write(count);
			writer.Write(origCount);
			writer.Write(isScriptChange);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void TransferMarker(byte player, int from, int to, Guid id, string name, ushort count, ushort origCount, bool isScriptChange)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)57);
			writer.Write(player);
			writer.Write(from);
			writer.Write(to);
			writer.Write(id.ToByteArray());
			writer.Write(name);
			writer.Write(count);
			writer.Write(origCount);
			writer.Write(isScriptChange);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void PassTo(byte player, int id, byte to, bool requested)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)59);
			writer.Write(player);
			writer.Write(id);
			writer.Write(to);
			writer.Write(requested);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void TakeFrom(int id, byte to)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)61);
			writer.Write(id);
			writer.Write(to);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void DontTake(int id)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)63);
			writer.Write(id);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void FreezeCardsVisibility(int group)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)64);
			writer.Write(group);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void GroupVis(byte player, int group, bool defined, bool visible)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)66);
			writer.Write(player);
			writer.Write(group);
			writer.Write(defined);
			writer.Write(visible);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void GroupVisAdd(byte player, int group, byte who)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)68);
			writer.Write(player);
			writer.Write(group);
			writer.Write(who);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void GroupVisRemove(byte player, int group, byte who)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)70);
			writer.Write(player);
			writer.Write(group);
			writer.Write(who);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void LookAt(byte player, int uid, int group, bool look)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)72);
			writer.Write(player);
			writer.Write(uid);
			writer.Write(group);
			writer.Write(look);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void LookAtTop(byte player, int uid, int group, int count, bool look)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)74);
			writer.Write(player);
			writer.Write(uid);
			writer.Write(group);
			writer.Write(count);
			writer.Write(look);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void LookAtBottom(byte player, int uid, int group, int count, bool look)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)76);
			writer.Write(player);
			writer.Write(uid);
			writer.Write(group);
			writer.Write(count);
			writer.Write(look);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void StartLimited(byte player, Guid[] packs)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)78);
			writer.Write(player);
			writer.Write((short)packs.Length);
			foreach (Guid g in packs)
				writer.Write(g.ToByteArray());
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void CancelLimited(byte player)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)80);
			writer.Write(player);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void CardSwitchTo(byte player, int card, string alternate)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)81);
			writer.Write(player);
			writer.Write(card);
			writer.Write(alternate);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void PlayerSetGlobalVariable(byte player, string name, string oldval, string val)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)82);
			writer.Write(player);
			writer.Write(name);
			writer.Write(oldval);
			writer.Write(val);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void SetGlobalVariable(string name, string oldval, string val)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)83);
			writer.Write(name);
			writer.Write(oldval);
			writer.Write(val);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void Ping()
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)85);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void IsTableBackgroundFlipped(bool isFlipped)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)86);
			writer.Write(isFlipped);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void PlaySound(byte player, string name)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)87);
			writer.Write(player);
			writer.Write(name);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void Ready(byte player)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)88);
			writer.Write(player);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void PlayerState(byte player, byte state)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)89);
			writer.Write(player);
			writer.Write(state);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void RemoteCall(byte player, string function, string args)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)90);
			writer.Write(player);
			writer.Write(function);
			writer.Write(args);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void GameStateReq(byte player)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)91);
			writer.Write(player);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void GameState(byte toPlayer, string state)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)92);
			writer.Write(toPlayer);
			writer.Write(state);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void DeleteCard(int card, byte player)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)93);
			writer.Write(card);
			writer.Write(player);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void PlayerDisconnect(byte player)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)94);
			writer.Write(player);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void AddPacks(byte player, Guid[] packs, bool selfOnly)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)96);
			writer.Write(player);
			writer.Write((short)packs.Length);
			foreach (Guid g in packs)
				writer.Write(g.ToByteArray());
			writer.Write(selfOnly);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void AnchorCard(int id, byte player, bool anchor)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)97);
			writer.Write(id);
			writer.Write(player);
			writer.Write(anchor);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void SetCardProperty(int id, byte player, string name, string val, string valtype)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)98);
			writer.Write(id);
			writer.Write(player);
			writer.Write(name);
			writer.Write(val);
			writer.Write(valtype);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

    public void ResetCardProperties(int id, byte player)
    {
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      writer.Write(handler.muted);
			writer.Write((byte)99);
			writer.Write(id);
			writer.Write(player);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}
	}
	
	class BinarySenderStub : BaseBinaryStub
	{
		private ServerSocket to;
		
		public BinarySenderStub(ServerSocket to, Handler handler) : base(handler)
		{ this.to = to; }
		
		protected override void Send(byte[] data)
		{
			try
			{
				to.Send(data);
			}
			catch 
			{ 
// TODO: Notify disconnection
//				if (Program.Server != null && Program.Server.Disconnected(to))
//					return;
//				Program.Client.Disconnected();
			}
		}
	}
}
