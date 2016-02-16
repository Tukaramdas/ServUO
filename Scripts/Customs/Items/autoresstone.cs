using System;
using Server;
using Server.Items;
using Server.Mobiles;
 
namespace Server.Items
{
  public class AutoResStone : Item
  {
  public static void Initialize()
  {
  EventSink.PlayerDeath += new PlayerDeathEventHandler(EventSink_Death);
  }
 
  private static void EventSink_Death(PlayerDeathEventArgs e)
  {
  PlayerMobile owner = e.Mobile as PlayerMobile;
 
  if (owner != null && !owner.Deleted)
  {
  if (owner.Alive)
  return;
 
  if (owner.Backpack == null || owner.Backpack.Deleted)
  return;
 
  AutoResStone stone = owner.Backpack.FindItemByType(typeof(AutoResStone)) as AutoResStone;
 
  if (stone != null && !stone.Deleted)
  {
  owner.SendMessage("Your stone of rebirth has saved you from the farplane.");
  owner.Resurrect();
  }
  }
  }
 
  [Constructable]
  public AutoResStone()
  : base(0x1870)
  {
  Name = "Stone Of Rebirth";
  LootType = LootType.Blessed;
  }
 
  public AutoResStone(Serial serial)
  : base(serial)
  {
 
  }
 
  public override void Serialize(GenericWriter writer)
  {
  base.Serialize(writer);
 
  writer.Write((int)0); // version
  }
 
  public override void Deserialize(GenericReader reader)
  {
  base.Deserialize(reader);
 
  int version = reader.ReadInt();
 
  switch (version)
  {
  case 0: { } break;
  }
  }
 
  }
}