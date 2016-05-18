/* This file was created with
Ilutzio's Questmaker. Enjoy! */
using System;
using Server;
namespace Server.Items
{
public class BlueCrystal : Item
{
[Constructable]
public BlueCrystal() : this( 1 )
{}
[Constructable]
public BlueCrystal( int amountFrom, int amountTo ) : this( Utility.RandomMinMax( amountFrom, amountTo ) )
{}
[Constructable]

///////////The hexagon value ont he line below is the ItemID
public BlueCrystal( int amount ) : base( 0x0F8E )
{


///////////Item name
Name = "Blue Crystal";

///////////Item hue
Hue = 0x65;

///////////Stackable
Stackable = false;

///////////Weight of one item
Weight = 0.01;
Amount = amount;

}
public BlueCrystal( Serial serial ) : base( serial )
{}
public override void Serialize( GenericWriter writer )
{
base.Serialize( writer );
writer.Write( (int) 0 ); // version
}
public override void Deserialize( GenericReader reader )
{
base.Deserialize( reader ); int version = reader.ReadInt(); }}}
