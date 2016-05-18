/* This file was created with
Ilutzio's Questmaker. Enjoy! */
using System;using Server;namespace Server.Items
{
public class CrystalCrystal : Item
{
[Constructable]
public CrystalCrystal() : this( 1 )
{}
[Constructable]
public CrystalCrystal( int amountFrom, int amountTo ) : this( Utility.RandomMinMax( amountFrom, amountTo ) )
{}
[Constructable]

///////////The hexagon value ont he line below is the ItemID
public CrystalCrystal( int amount ) : base( 0x0F8E )
{


///////////Item name
Name = "Crystal's Crystal";

///////////Item hue
Hue = 0x65;

///////////Stackable
Stackable = false;

///////////Weight of one item
Weight = 0.01;
Amount = amount;

}
public CrystalCrystal( Serial serial ) : base( serial )
{}
public override void Serialize( GenericWriter writer )
{
base.Serialize( writer );
writer.Write( (int) 0 ); // version
}
public override void Deserialize( GenericReader reader )
{
base.Deserialize( reader ); int version = reader.ReadInt(); }}}
