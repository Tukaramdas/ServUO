using System;
using Server;

namespace Server.Items
{
public class TheHolyGrailSword : Longsword 
	{
public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.ArmorIgnore; } }
public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.ConcussionBlow; } }
		
public override int InitMinHits{ get{ return 255; } } 
public override int InitMaxHits{ get{ return 255; } } 

[Constructable]
public TheHolyGrailSword()
{
Weight = 1.0; 
Name = "The Holy Grail Sword";
Hue = 1153;
            	
WeaponAttributes.LowerStatReq = 100;
WeaponAttributes.SelfRepair = 10;
WeaponAttributes.UseBestSkill = 1;

Attributes.SpellChanneling = 1;
Attributes.WeaponDamage = 40;
Attributes.WeaponSpeed = 30;
			
Slayer = SlayerName.DaemonDismissal;
Slayer = SlayerName.Silver;

LootType = LootType.Blessed; 
}

public TheHolyGrailSword( Serial serial ) : base( serial ) 
{
}

public override void Serialize( GenericWriter writer )
{
base.Serialize( writer );

writer.Write( (int) 0 );
}
		
public override void Deserialize(GenericReader reader)
{
base.Deserialize( reader );

int version = reader.ReadInt();
}
}
}