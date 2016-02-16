/////////// Scripted By TALON NYTE ///////////

using System;
using Server;
using Server.Items;
				
namespace Server.Mobiles
{
	[CorpseName( "Corpse Of SonOfAbyss" )]
	public class SonOfAbyss : BaseCreature
	{
		public override bool ShowFameTitle{ get{ return false; } }

		[Constructable]
		public SonOfAbyss() : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "Son Of Abyss";
			Title = "[Death]";
			Body = 400;
			Hue = 1172;
                        BaseSoundID = 1072;
				 
			SetStr( 700, 700 );
			SetDex( 500, 500 );
			SetInt( 200, 250 );
				 
			SetHits( 1000, 1000 );
				 
			SetDamage( 10, 20 );
				 
			SetDamageType( ResistanceType.Physical, 70 );
			SetDamageType( ResistanceType.Cold, 70 );
			SetDamageType( ResistanceType.Fire, 70 );
				 
			SetResistance( ResistanceType.Physical, 50, 100 );
			SetResistance( ResistanceType.Energy, 50, 100 );
			SetResistance( ResistanceType.Poison, 50, 100 );
			SetResistance( ResistanceType.Cold, 50, 100 );
			SetResistance( ResistanceType.Fire, 50, 100 );
				 
			SetSkill( SkillName.Wrestling, 95.1, 100.0 );
			SetSkill( SkillName.Anatomy, 95.1, 100.0 );
			SetSkill( SkillName.MagicResist, 95.1, 100.0 );
			SetSkill( SkillName.Swords, 95.1, 100.0 );
			SetSkill( SkillName.Tactics, 95.1, 100.0 );
			SetSkill( SkillName.Parry, 95.1, 100.0 );
			SetSkill( SkillName.Focus, 95.1, 100.0 );
				 
			Fame = 25000;
			Karma = -25000;
				 
			VirtualArmor = 40;
                  
                        AddItem( new PlateChest() ); 
			AddItem( new PlateArms() ); 
			AddItem( new PlateGloves() ); 
			AddItem( new PlateLegs() );
			AddItem( new PlateGorget() );
			AddItem( new HoodedShroudOfShadows() );
                        AddItem( new QuickBlade() );

                  PackGold( 3000, 6000 );

			HairItemID = 8265;
			HairHue = 1153;

		        PackItem( new RegenerationCrystal() );
			
		}
			
		public override bool AlwaysAttackable{ get{ return true; } }
 
		public override void GenerateLoot()
		{
			 AddLoot( LootPack.Rich, 2 );
		}
			
		public SonOfAbyss( Serial serial ) : base( serial )
		{
		}
			
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}
			
		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
      
		}
	}
}	
