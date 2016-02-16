//Created By Milva

using System;
using Server;
using Server.Items;
using System.Collections; 
using Server.ContextMenus; 
using Server.Misc; 
using Server.Network; 

namespace Server.Mobiles 
{ 
	public class CursedExecutioner : BaseCreature 
	{ 
		[Constructable] 
		public CursedExecutioner() : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 ) 
		{ 
			Name = "Cursed Executioner";
            
			Hue = 33805; 
			Body = 400;
            Female = false;

			SetStr( 95 );
			SetDex( 90 );
			SetInt( 100 );

			SetHits( 1000 );
			SetDamage( 20, 25 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 70 );
			SetResistance( ResistanceType.Fire, 81 );
			SetResistance( ResistanceType.Cold, 91 );
			SetResistance( ResistanceType.Poison, 80 );
			SetResistance( ResistanceType.Energy, 70 );

			SetSkill( SkillName.Anatomy, 100.0 );
			SetSkill( SkillName.Fencing, 120.0 );
			SetSkill( SkillName.Wrestling, 130.0 );
			SetSkill( SkillName.MagicResist, 110.0 );
			SetSkill( SkillName.Tactics, 150.0 );

			
			VirtualArmor = 20;


			 Item goatee = new Item( 8256 );
             goatee.Layer = Layer.FacialHair;
             goatee.Movable = false;  
             AddItem(goatee);
			
            Item LongPants = new Item( 5433 ); 
			LongPants.Hue = 966; 
			LongPants.Layer = Layer.Pants;
            LongPants.LootType = LootType.Blessed;
			AddItem( LongPants );

            Item Shirt = new Item( 5399 ); 
			Shirt.Layer = Layer.Shirt;
            Shirt.LootType = LootType.Blessed;
			AddItem(Shirt );

            Item LeatherGloves = new Item( 5062 );
            LeatherGloves.Hue = 966; 
			LeatherGloves.Layer = Layer.Gloves;
            LeatherGloves.LootType = LootType.Blessed;
			AddItem(LeatherGloves );

            Item SkullCap = new Item( 5444 ); 
			SkullCap.Hue = 966; 
			SkullCap.Layer = Layer.Helm;
            SkullCap.LootType = LootType.Blessed;
			AddItem( SkullCap );

                                                 
                                               Item Boots = new Item( 5899 ); 
			Boots.Hue = 966; 
			Boots.Layer = Layer.Shoes;
			Boots.LootType = LootType.Blessed;
			AddItem( Boots );

                                                Item HalfApron = new Item( 5435 ); 
			HalfApron.Hue = 32; 
			HalfApron.Layer = Layer.Waist;
			HalfApron.LootType = LootType.Blessed;
			AddItem( HalfApron );
                                                
                                               
                                                
                        Item ExecutionersAxe = new   ExecutionersAxe();
                         ExecutionersAxe.LootType = LootType.Blessed;
                         ExecutionersAxe.Hue = 1157;
                        AddItem(ExecutionersAxe);

                        Container pack = new Backpack();
                        PackGold( 700, 800  );
                         PackItem( new DeathsScythe() );
                                                

			} 

		public override bool AlwaysMurderer{ get{ return true; } }

		public CursedExecutioner( Serial serial ) : base( serial ) 
		{ 
		} 

		public override void Serialize( GenericWriter writer ) 
		{ 
			base.Serialize( writer ); 

			writer.Write( (int) 0 ); // version 
		} 

		public override void Deserialize( GenericReader reader ) 
		{ 
			base.Deserialize( reader ); 

			int version = reader.ReadInt(); 
		} 
	}
}
