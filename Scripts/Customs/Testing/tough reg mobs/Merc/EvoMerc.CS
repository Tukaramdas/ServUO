//////////////////////////////////////////////////$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
////==========================================////$                                 $
////        Upgraded By: Triple               ////$   Will like to thank for all    $
////==========================================////$   who help me with this upgrade!$
//////////////////////////////////////////////////$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$

using System;
using System.Collections;
using Server;
using Server.Items;
using Server.Mobiles;
using Server.Network;
using Server.Gumps;
using Server.Targeting;

namespace Server.Mobiles
{
	public class EvoMerc : BaseCreature
	{
		private Timer m_BreatheTimer;
		private DateTime m_EndBreathe;
		private Item del;

		private Timer m_MercLoyaltyTimer;
		private DateTime m_EndMercLoyalty;

		public DateTime EndMercLoyalty{ get{ return m_EndMercLoyalty; } set{ m_EndMercLoyalty = value; } }

		public static readonly object From = new object();
		public static readonly object Vendor = new object();
		public static readonly object Price = new object();

		private static EvoMercBuyInfo[] m_SellList = new EvoMercBuyInfo[]
			{
				new EvoMercBuyInfo( 1018357, 0, Layer.Hair, typeof( ChangeHairstylGump ), new object[]
					{ From, Vendor, Price, Layer.Hair, ChangeHairstyleEnt.HairEntries } ),
				new EvoMercBuyInfo( 1018358, 0, Layer.FacialHair, typeof( ChangeHairstylGump ), new object[]
					{ From, Vendor, Price, Layer.FacialHair, ChangeHairstyleEnt.BeardEntries } ),
				new EvoMercBuyInfo( 1018359, 0, Layer.Hair, typeof( ChangeHairHuGump ), new object[]
					{ From, Vendor, Price, new Layer[]{ Layer.Hair, Layer.FacialHair }, ChangeHairHueEnt.RegularEntries } ),
				new EvoMercBuyInfo( 1018360, 0, Layer.Hair, typeof( ChangeHairHuGump ), new object[]
					{ From, Vendor, Price, new Layer[]{ Layer.Hair, Layer.FacialHair }, ChangeHairHueEnt.BrightEntries } ),
				new EvoMercBuyInfo( 1018361, 0, Layer.Hair, typeof( ChangeHairHuGump ), new object[]
					{ From, Vendor, Price, new Layer[]{ Layer.Hair }, ChangeHairHueEnt.RegularEntries } ),
				new EvoMercBuyInfo( 1018362, 0, Layer.FacialHair, typeof( ChangeHairHuGump ), new object[]
					{ From, Vendor, Price, new Layer[]{ Layer.FacialHair }, ChangeHairHueEnt.RegularEntries } ),
				new EvoMercBuyInfo( 1018363, 0, Layer.Hair, typeof( ChangeHairHuGump ), new object[]
					{ From, Vendor, Price, new Layer[]{ Layer.Hair }, ChangeHairHueEnt.BrightEntries } ),
				new EvoMercBuyInfo( 1018364, 0, Layer.FacialHair, typeof( ChangeHairHuGump ), new object[]
					{ From, Vendor, Price, new Layer[]{ Layer.FacialHair }, ChangeHairHueEnt.BrightEntries } )
			};

		public int m_Stage;
		public int m_KP;
		public bool m_S1;
		public bool m_S2;
		public bool m_S3;
		public bool m_S4;
		public bool m_S5;
		public bool m_S6;

		public bool S1
		{
			get{ return m_S1; }
			set{ m_S1 = value; }
		}
		public bool S2
		{
			get{ return m_S2; }
			set{ m_S2 = value; }
		}
		public bool S3
		{
			get{ return m_S3; }
			set{ m_S3 = value; }
		}
		public bool S4
		{
			get{ return m_S4; }
			set{ m_S4 = value; }
		}
		public bool S5
		{
			get{ return m_S5; }
			set{ m_S5 = value; }
		}
		public bool S6
		{
			get{ return m_S6; }
			set{ m_S6 = value; }
		}

		[CommandProperty( AccessLevel.GameMaster )]
		public int KP
		{
			get{ return m_KP; }
			set{ m_KP = value; }
		}

		[CommandProperty( AccessLevel.GameMaster )]
		public int Stage
		{
			get{ return m_Stage; }
			set{ m_Stage = value; }
		}

		[Constructable]
		public EvoMerc() : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			InitStats( 40, 30, 5 );
			Name = "A Mercenary";
			Title = "";

			SpeechHue = Utility.RandomDyedHue();

			Hue = Utility.RandomSkinHue();
			
			if ( Female = Utility.RandomBool() )
				Body = 401;
			else
				Body = 400;
			
			if ( Female == false )
			{
			Item hair = new Item( Utility.RandomList( 0x203B, 0x203C, 0x203D, 0x2044, 0x2045, 0x2047, 0x2049, 0x204A ) );
			hair.Hue = Utility.RandomHairHue();
			hair.Layer = Layer.Hair;
			hair.Movable = false;
			AddItem( hair );

			Item beard = new Item( Utility.RandomList( 0x203E, 0x203F, 0x2040, 0x2041, 0x204B, 0x204C, 0x204D ) );
			beard.Hue = hair.Hue;
			beard.Layer = Layer.FacialHair;
			beard.Movable = false;
			AddItem( beard );
			}
			else if ( Female == true )
			{
			Item hair = new Item( Utility.RandomList( 0x203B, 0x203C, 0x203D, 0x2044, 0x2045, 0x2047, 0x2049, 0x204A ) );
			hair.Hue = Utility.RandomHairHue();
			hair.Layer = Layer.Hair;
			hair.Movable = false;
			AddItem( hair );
			}

			AddItem( new Robe() );

			Item weapon;
			switch ( Utility.Random( 1 ) )
			{
				case 0: weapon = new MercenaryKatana(); break;
				default: weapon = new MercenaryKatana(); break;

			}
			weapon.Movable = false;
			AddItem( weapon );

			SetSkill( SkillName.Swords, 20.0 );
			SetSkill( SkillName.Macing, 20.0 );
			SetSkill( SkillName.Fencing, 20.0 );
			SetSkill( SkillName.Swords, 20.0 );

			SetStr( 80 );
			SetDex( 80 );
			SetInt( 80 );

			SetDamage( 11, 17 );

			S1 = true;
			S2 = true;
			S3 = true;
			S4 = true;
			S5 = true;
			S6 = true;
			Stage = 1;

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 15 );

			SetSkill( SkillName.Fencing, 120, 120 );
			SetSkill( SkillName.Swords, 120, 120 );
			SetSkill( SkillName.Anatomy, 120, 120 );
			SetSkill( SkillName.Archery, 120, 120 );
			SetSkill( SkillName.Tactics, 120, 120 );
			SetSkill( SkillName.Macing, 120, 120 );
			SetSkill( SkillName.MagicResist, 120, 120 );
			SetSkill( SkillName.Parry, 120, 120 );

			Fame = 300;
			Karma = -300;

			VirtualArmor = 20;

			ControlSlots = 4;
			PackItem( new Diamond() );
			m_MercLoyaltyTimer = new MercLoyaltyTimer( this, TimeSpan.FromSeconds( 5.0 ) );
			m_MercLoyaltyTimer.Start();
			m_EndMercLoyalty = DateTime.Now + TimeSpan.FromSeconds( 5.0 );

		}

		public EvoMerc( Serial serial ) : base( serial )
		{
		}
          	
		public override bool HandlesOnSpeech(Mobile from)
		{
			return true;
			//base.HandlesOnSpeech( from );
		}
 
	        public override void OnSpeech( SpeechEventArgs e ) 
        	{ 

		        bool isMatch = false;

		        Mobile from = e.Mobile;

                	string keyword = this.Name +" restyle";
                	string keyword2 = this.Name +" undress";
                	string keyword3 = this.Name +" dismount";
                	string keyword4 = this.Name +" mount";
                	string keyword5 = this.Name +" stats";
                	string keyword6 = this.Name +" help";

                	if ( keyword != null && e.Speech.ToLower().IndexOf( keyword.ToLower() ) >= 0 ) 
 			{
				isMatch = true; 
 
 	              		if ( !isMatch ) 
        	            		return; 
	
        	       		if ( ControlMaster != from )
                	   		return;
			
				from.SendGump( new EvoMercBuyGump( from, this, m_SellList ) );
				from.SendMessage("Your Mercenary will style it's hair for free for you!");
	               		e.Handled = true;
			}

                	if ( keyword2 != null && e.Speech.ToLower().IndexOf( keyword2.ToLower() ) >= 0 ) 
 			{
				isMatch = true; 
 
 	              		if ( !isMatch ) 
        	            		return; 
	
        	       		if ( ControlMaster != from )
                	   		return;

				if ( Stage < 3 )
				{
					from.SendMessage("Your Mercenary cannot do that yet.");
					return;
				}

				for ( int i = this.Items.Count - 1; i >= 0; --i )
				{
					if ( i >= Items.Count )
						continue;

					Item item = (Item)Items[i];
					
					if (!( item is Container ) && item.Layer != Layer.FacialHair && item.Layer != Layer.Hair && !( item is IMountItem ) )
					{
						item.Movable = true;
						from.AddToBackpack( item );
					}
				}
               			e.Handled = true;
			}

                	if ( keyword3 != null && e.Speech.ToLower().IndexOf( keyword3.ToLower() ) >= 0 ) 
 			{
				isMatch = true; 
 
 	              		if ( !isMatch ) 
        	            		return; 
	
        	       		if ( ControlMaster != from )
                	   		return;
			
				if ( this.Mount != null )
				{
					for ( int i = 0; i < this.Items.Count; ++i )
					{
						Item item = (Item)this.Items[i];

						if ( item is IMountItem )
						{
							IMount mount = ((IMountItem)item).Mount;

							if ( mount != null )
							{
								mount.Rider = null;
								if ( mount is EtherealMount )
								{
									EtherealMount ethy = (EtherealMount)mount;
										if ( from.Backpack != null )
											from.Backpack.DropItem( ethy );
								}
							}

							if ( this.Items.IndexOf( item ) == -1 )
								--i;
						}
					}

					for ( int i = 0; i < this.Items.Count; ++i )
					{
						Item item = (Item)this.Items[i];

						if ( item.Layer == Layer.Mount )
						{
							if ( from.Backpack != null )
								from.Backpack.DropItem( item );
							--i;
						}
					}
				}
				else
				{
					from.SendMessage( this.Name + " is not on a mount." );
				}
	               		e.Handled = true;
			}

                	if ( keyword4 != null && e.Speech.ToLower().IndexOf( keyword4.ToLower() ) >= 0 ) 
 			{
				isMatch = true; 
 
 	              		if ( !isMatch ) 
        	            		return; 
	
        	       		if ( ControlMaster != from )
                	   		return;
			
				from.SendMessage( "Target a mount or an ethereal mount you would like to place "+ this.Name +" on." );
				from.Target = new MountTarget( this );
	               		e.Handled = true;
			}

                	if ( keyword5 != null && e.Speech.ToLower().IndexOf( keyword5.ToLower() ) >= 0 ) 
 			{
				isMatch = true; 
 
 	              		if ( !isMatch ) 
        	            		return; 
	
        	       		if ( ControlMaster != from )
                	   		return;
			
				from.SendGump( new StatGump( this ) );
	               		e.Handled = true;
			}

                	if ( keyword6 != null && e.Speech.ToLower().IndexOf( keyword6.ToLower() ) >= 0 ) 
 			{
				isMatch = true; 
 
 	              		if ( !isMatch ) 
        	            		return; 
	
        	       		if ( ControlMaster != from )
                	   		return;
			
				this.Say("I will follow these commands: restyle, undress, mount, dismount, and stats.");
	               		e.Handled = true;
			}


			base.OnSpeech( e );
          	}
	
		private class MountTarget : Target
		{
			private EvoMerc m_Merc;
	
			public MountTarget( EvoMerc merc ) : base( 1, false, TargetFlags.None )
			{
				m_Merc = merc;
			}
	
			protected override void OnTarget( Mobile from, object o )
			{
				if ( m_Merc.Mount == null )
				{
					if ( o is EtherealMount )
					{
						EtherealMount mount = (EtherealMount)o;

						if ( mount.Rider == null )
						{
							if ( mount.IsChildOf( from.Backpack ) )
								mount.Rider = m_Merc;
							else
								from.SendMessage( "The ethereal mount must been in your pack for you to use it." );
						}
						else
							from.SendMessage( "This ethereal mount is already in use by something else." );
					}
					else if ( o is BaseMount )
					{
						BaseMount mount = (BaseMount)o;
	
						if ( mount.Rider == null )
						{
							if ( mount.ControlMaster == from )
								mount.Rider = m_Merc;
							else
								from.SendMessage( "You do not own this mount." );
						}
						else
							from.SendMessage( "This mount is already in use by something else." );
					}
					else
					{
						from.SendMessage( "That is an invalid target." );
					}
				}
				else
				{
					from.SendMessage( m_Merc.Name +" is already mounted." );
				}
			}
		}



		public override void OnGaveMeleeAttack( Mobile defender )
		{
			int kpgainmin, kpgainmax;

			if ( this.Stage == 1 )
			{
				if ( defender is BaseCreature )
				{
					BaseCreature bc = (BaseCreature)defender;

					if ( bc.Controlled != true )
					{
						kpgainmin = 6 + ( bc.HitsMax ) / 10;
						kpgainmax = 6 + ( bc.HitsMax ) / 10;

						this.KP += Utility.RandomList( kpgainmin, kpgainmax );
					}
				}

				if ( this.KP >= 50000 )
				{
					if ( this.S1 == true )
					{
						this.S1 = false;
						int hits, va, mindamage, maxdamage;

						hits = ( this.HitsMax + 200 );

						va = ( this.VirtualArmor + 10 );

						mindamage = this.DamageMin + ( 1 );
						maxdamage = this.DamageMax + ( 1 );

						this.Warmode = false;
						this.Say( "*"+ this.Name +" achieves a new level of combat*");
						this.SetDamage( mindamage, maxdamage );
						this.SetHits( hits );
						this.VirtualArmor = va;
						this.Stage = 2;
						this.Title = "the Shadow Knight";

						this.SetDamageType( ResistanceType.Physical, 20 );
						this.SetDamageType( ResistanceType.Fire, 20 );
						this.SetDamageType( ResistanceType.Cold, 20 );
						this.SetDamageType( ResistanceType.Poison, 20 );
						this.SetDamageType( ResistanceType.Energy, 20 );

						this.SetResistance( ResistanceType.Physical, 45 );
						this.SetResistance( ResistanceType.Fire, 45 );
						this.SetResistance( ResistanceType.Cold, 45 );
						this.SetResistance( ResistanceType.Poison, 45 );
						this.SetResistance( ResistanceType.Energy, 45 );

						this.RawStr += 20;
						this.RawInt += 10;
						this.RawDex += 10;

						Item del = this.FindItemOnLayer( Layer.OuterTorso ); // The Robe
						if ( del != null )
						{
							del.Delete();
						}

						del = this.FindItemOnLayer( Layer.InnerTorso );
						if ( del != null )
						{
							del.Delete();
						}
						BaseArmor chest = new LeatherChest();
						chest.Hue = 1175;
						chest.Movable = false;
						AddItem( chest );

						del = this.FindItemOnLayer( Layer.Pants );
						if ( del != null )
						{
							del.Delete();
						}
						BaseArmor legs = new LeatherLegs();
						legs.Hue = 1175;
						legs.Movable = false;	
						AddItem( legs );

						del = this.FindItemOnLayer( Layer.Neck );
						if ( del != null )
						{
							del.Delete();
						}
						BaseArmor gorget = new LeatherGorget();
						gorget.Hue = 1175;
						gorget.Movable = false;	
						AddItem( gorget );

						del = this.FindItemOnLayer( Layer.Gloves );
						if ( del != null )
						{
							del.Delete();
						}
						BaseArmor gloves = new LeatherGloves();
						gloves.Hue = 1175;
						gloves.Movable = false;	
						AddItem( gloves );

						del = this.FindItemOnLayer( Layer.Helm );
						if ( del != null )
						{
							del.Delete();
						}
						BaseArmor helm = new LeatherCap();
						helm.Hue = 1175;
						helm.Movable = false;	
						AddItem( helm );

						del = this.FindItemOnLayer( Layer.Arms );
						if ( del != null )
						{
							del.Delete();
						}
						BaseArmor arms = new LeatherArms();
						arms.Hue = 1175;
						arms.Movable = false;	
						AddItem( arms );

						del = this.FindItemOnLayer( Layer.Shoes );
						if ( del != null )
						{
							del.Delete();
						}
						Item sandals = new Sandals();
						sandals.Hue = 1153;
						sandals.Movable = false;	
						AddItem( sandals );
					}
				}
			}

			else if ( this.Stage == 2 )
			{
				if ( defender is BaseCreature )
				{
					BaseCreature bc = (BaseCreature)defender;

					if ( bc.Controlled != true )
					{
						kpgainmin = 5 + ( bc.HitsMax ) / 10;
						kpgainmax = 5 + ( bc.HitsMax ) / 10;

						this.KP += Utility.RandomList( kpgainmin, kpgainmax );
					}
				}

				if ( this.KP >= 100000 )
				{
					if ( this.S2 == true )
					{
						this.S2 = false;
						int hits, va, mindamage, maxdamage;

						hits = ( this.HitsMax + 100 );

						va = ( this.VirtualArmor + 5 );

						mindamage = this.DamageMin + ( 2 );
						maxdamage = this.DamageMax + ( 2 );

						this.Warmode = false;
						this.Say( "*"+ this.Name +" achieves a new level of combat*");
						this.SetDamage( mindamage, maxdamage );
						this.SetHits( hits );
						this.VirtualArmor = va;
						this.Stage = 3;
						this.Title = "the Golden Knight";

						this.SetDamageType( ResistanceType.Physical, 20 );
						this.SetDamageType( ResistanceType.Fire, 20 );
						this.SetDamageType( ResistanceType.Cold, 20 );
						this.SetDamageType( ResistanceType.Poison, 20 );
						this.SetDamageType( ResistanceType.Energy, 20 );

						this.SetResistance( ResistanceType.Physical, 55 );
						this.SetResistance( ResistanceType.Fire, 55 );
						this.SetResistance( ResistanceType.Cold, 55 );
						this.SetResistance( ResistanceType.Poison, 55 );
						this.SetResistance( ResistanceType.Energy, 55 );

						this.RawStr += 20;
						this.RawInt += 50;
						this.RawDex += 50;

						Item del = this.FindItemOnLayer( Layer.InnerTorso );
						if ( del != null )
						{
							del.Delete();
						}
						BaseArmor chest = new StuddedChest();
						chest.Hue = 1161;
						chest.Movable = false;
						AddItem( chest );

						del = this.FindItemOnLayer( Layer.Pants );
						if ( del != null )
						{
							del.Delete();
						}
						BaseArmor legs = new StuddedLegs();
						legs.Hue = 1161;
						legs.Movable = false;	
						AddItem( legs );

						del = this.FindItemOnLayer( Layer.Neck );
						if ( del != null )
						{
							del.Delete();
						}
						BaseArmor gorget = new StuddedGorget();
						gorget.Hue = 1161;
						gorget.Movable = false;	
						AddItem( gorget );

						del = this.FindItemOnLayer( Layer.Gloves );
						if ( del != null )
						{
							del.Delete();
						}
						BaseArmor gloves = new StuddedGloves();
						gloves.Hue = 1161;
						gloves.Movable = false;	
						AddItem( gloves );

						del = this.FindItemOnLayer( Layer.Helm );
						if ( del != null )
						{
							del.Delete();
						}
						BaseArmor helm = new LeatherCap();
						helm.Hue = 1161;
						helm.Movable = false;	
						AddItem( helm );

						del = this.FindItemOnLayer( Layer.Arms );
						if ( del != null )
						{
							del.Delete();
						}
						BaseArmor arms = new StuddedArms();
						arms.Hue = 1161;
						arms.Movable = false;	
						AddItem( arms );
					}
				}
			}

			else if ( this.Stage == 3 )
			{
				if ( defender is BaseCreature )
				{
					BaseCreature bc = (BaseCreature)defender;

					if ( bc.Controlled != true )
					{
						kpgainmin = 4 + ( bc.HitsMax ) / 20;
						kpgainmax = 4 + ( bc.HitsMax ) / 20;

						this.KP += Utility.RandomList( kpgainmin, kpgainmax );
					}
				}

				if ( this.KP >= 150000 )
				{
					if ( this.S3 == true )
					{
						this.S3 = false;
						int hits, va, mindamage, maxdamage;

						hits = ( this.HitsMax + 100 );

						va = ( this.VirtualArmor + 5 );

						mindamage = this.DamageMin + ( 1 );
						maxdamage = this.DamageMax + ( 1 );

						this.Warmode = false;
						this.Say( "*"+ this.Name +" achieves a new level of combat*");
						this.SetDamage( mindamage, maxdamage );
						this.SetHits( hits );
						this.VirtualArmor = va;
						this.Stage = 4;
						this.Title = "the Blood Knight";

						this.SetResistance( ResistanceType.Physical, 60 );
						this.SetResistance( ResistanceType.Fire, 60 );
						this.SetResistance( ResistanceType.Cold, 60 );
						this.SetResistance( ResistanceType.Poison, 60 );
						this.SetResistance( ResistanceType.Energy, 60 );

						this.RawStr += 20;
						this.RawInt += 30;
						this.RawDex += 30;


						Item del = this.FindItemOnLayer( Layer.InnerTorso );
						if ( del != null )
						{
							del.Delete();
						}
						BaseArmor chest = new PlateChest();
						chest.Hue = 1157;
						chest.Movable = false;
						AddItem( chest );

						del = this.FindItemOnLayer( Layer.Pants );
						if ( del != null )
						{
							del.Delete();
						}
						BaseArmor legs = new PlateLegs();
						legs.Hue = 1157;
						legs.Movable = false;	
						AddItem( legs );

						del = this.FindItemOnLayer( Layer.Neck );
						if ( del != null )
						{
							del.Delete();
						}
						BaseArmor gorget = new PlateGorget();
						gorget.Hue = 1157;
						gorget.Movable = false;	
						AddItem( gorget );

						del = this.FindItemOnLayer( Layer.Gloves );
						if ( del != null )
						{
							del.Delete();
						}
						BaseArmor gloves = new PlateGloves();
						gloves.Hue = 1157;
						gloves.Movable = false;	
						AddItem( gloves );

						del = this.FindItemOnLayer( Layer.Helm );
						if ( del != null )
						{
							del.Delete();
						}
						BaseArmor helm = new PlateHelm();
						helm.Hue = 1157;
						helm.Movable = false;	
						AddItem( helm );

						del = this.FindItemOnLayer( Layer.Arms );
						if ( del != null )
						{
							del.Delete();
						}
						BaseArmor arms = new PlateArms();
						arms.Hue = 1157;
						arms.Movable = false;	
						AddItem( arms );
						
						del = this.FindItemOnLayer( Layer.Shoes );
						if ( del != null )
						{
							del.Delete();
						}
					}
				}
			}

			else if ( this.Stage == 4 )
			{
				if ( defender is BaseCreature )
				{
					BaseCreature bc = (BaseCreature)defender;

					if ( bc.Controlled != true )
					{
						kpgainmin = 3 + ( bc.HitsMax ) / 25;
						kpgainmax = 3 + ( bc.HitsMax ) / 30;

						this.KP += Utility.RandomList( kpgainmin, kpgainmax );
					}
				}

				if ( this.KP >= 250000 )
				{
					if ( this.S4 == true )
					{
						this.S4 = false;
						int hits, va, mindamage, maxdamage;

						hits = ( this.HitsMax + 100 );

						va = ( this.VirtualArmor + 3 );

						mindamage = this.DamageMin + ( 1 );
						maxdamage = this.DamageMax + ( 1 );

						this.Warmode = false;
						this.Say( "*"+ this.Name +" achieves a new level of combat*");
						this.SetDamage( mindamage, maxdamage );
						this.SetHits( hits );
						this.VirtualArmor = va;
						this.Stage = 5;
						this.Title = "the Knight of Destiny";

						this.SetDamageType( ResistanceType.Physical, 20 );
						this.SetDamageType( ResistanceType.Fire, 20 );
						this.SetDamageType( ResistanceType.Cold, 20 );
						this.SetDamageType( ResistanceType.Poison, 20 );
						this.SetDamageType( ResistanceType.Energy, 20 );

						this.SetResistance( ResistanceType.Physical, 70 );
						this.SetResistance( ResistanceType.Fire, 70 );
						this.SetResistance( ResistanceType.Cold, 70 );
						this.SetResistance( ResistanceType.Poison, 70 );
						this.SetResistance( ResistanceType.Energy, 70 );

						this.RawStr += 20;
						this.RawInt += 10;
						this.RawDex += 10;

						Item del = this.FindItemOnLayer( Layer.InnerTorso );
						if ( del != null )
						{
							del.Delete();
						}
						BaseArmor chest = new BoneChest();
						chest.Hue = 1152;
						chest.Movable = false;
						AddItem( chest );

						del = this.FindItemOnLayer( Layer.Pants );
						if ( del != null )
						{
							del.Delete();
						}
						BaseArmor legs = new BoneLegs();
						legs.Hue = 1152;
						legs.Movable = false;	
						AddItem( legs );

						del = this.FindItemOnLayer( Layer.Neck );
						if ( del != null )
						{
							del.Delete();
						}

						del = this.FindItemOnLayer( Layer.Gloves );
						if ( del != null )
						{
							del.Delete();
						}
						BaseArmor gloves = new BoneGloves();
						gloves.Hue = 1152;
						gloves.Movable = false;	
						AddItem( gloves );

						del = this.FindItemOnLayer( Layer.Helm );
						if ( del != null )
						{
							del.Delete();
						}
						BaseArmor helm = new BoneHelm();
						helm.Hue = 1152;
						helm.Movable = false;	
						AddItem( helm );

						del = this.FindItemOnLayer( Layer.Arms );
						if ( del != null )
						{
							del.Delete();
						}
						BaseArmor arms = new BoneArms();
						arms.Hue = 1152;
						arms.Movable = false;	
						AddItem( arms );

						del = this.FindItemOnLayer( Layer.Shoes );
						if ( del != null )
						{
							del.Delete();
						}
						Item sandals = new Sandals();
						sandals.Hue = 1152;
						sandals.Movable = false;	
						AddItem( sandals );
					}
				}
			}

			else if ( this.Stage == 5 )
			{
				if ( defender is BaseCreature )
				{
					BaseCreature bc = (BaseCreature)defender;

					if ( bc.Controlled != true )
					{
						kpgainmin = 2 + ( bc.HitsMax ) / 35;
						kpgainmax = 2 + ( bc.HitsMax ) / 35;

						this.KP += Utility.RandomList( kpgainmin, kpgainmax );
					}
				}

				if ( this.KP >= 350000 )
				{
					if ( this.S5 == true )
					{
						this.S5 = false;
						int hits, va, mindamage, maxdamage;

						hits = ( this.HitsMax + 100 );

						va = ( this.VirtualArmor + 10 );

						mindamage = this.DamageMin + ( 3 );
						maxdamage = this.DamageMax + ( 3 );

						this.Warmode = false;
						this.Say( "*"+ this.Name +" is Reborn*");
						this.Say( "Master, please lend me some armor");
						this.SetDamage( mindamage, maxdamage );
						this.SetHits( hits );
						this.VirtualArmor = va;
						this.Stage = 6;
						this.Title = "the Champion";

						this.SetResistance( ResistanceType.Physical, 5 );
						this.SetResistance( ResistanceType.Fire, 5 );
						this.SetResistance( ResistanceType.Cold, 5 );
						this.SetResistance( ResistanceType.Poison, 5 );
						this.SetResistance( ResistanceType.Energy, 5 );

						this.RawStr += 40;
						this.RawInt += 30;
						this.RawDex += 30;

						Item del = this.FindItemOnLayer( Layer.InnerTorso );
						if ( del != null )
						{
							del.Delete();
						}


						del = this.FindItemOnLayer( Layer.Pants );
						if ( del != null )
						{
							del.Delete();
						}


						del = this.FindItemOnLayer( Layer.Neck );
						if ( del != null )
						{
							del.Delete();
						}


						del = this.FindItemOnLayer( Layer.Gloves );
						if ( del != null )
						{
							del.Delete();
						}


						del = this.FindItemOnLayer( Layer.Helm );
						if ( del != null )
						{
							del.Delete();
						}


						del = this.FindItemOnLayer( Layer.Arms );
						if ( del != null )
						{
							del.Delete();
						}


						del = this.FindItemOnLayer( Layer.Shoes );
						if ( del != null )
						{
							del.Delete();
						}

					}
				}
			}

			else if ( this.Stage == 6 )
			{
				if ( defender is BaseCreature )
				{
					BaseCreature bc = (BaseCreature)defender;

					if ( bc.Controlled != true )
					{
						kpgainmin = 1 + ( bc.HitsMax ) / 40;
						kpgainmax = 1 + ( bc.HitsMax ) / 40;

						this.KP += Utility.RandomList( kpgainmin, kpgainmax );
					}
				}

				if ( this.KP >= 400000 )
				{
					if ( this.S6 == true )
					{
						this.S6 = false;
						int hits, va, mindamage, maxdamage;

						hits = ( this.HitsMax + 200 );

						va = ( this.VirtualArmor + 10 );

						mindamage = this.DamageMin + ( 3 );
						maxdamage = this.DamageMax + ( 3 );

						this.Warmode = false;
						this.Say( "*"+ this.Name +" is now a great champion and loyal friend*");
						if ( this.ControlMaster != null )
						{
							this.Title = ", Loyal Subject of " + this.ControlMaster.Name + "";
						}
						this.SetDamage( mindamage, maxdamage );
						this.SetHits( hits );
						this.VirtualArmor = va;
						this.Stage = 7;

						this.SetDamageType( ResistanceType.Physical, 40 );
						this.SetDamageType( ResistanceType.Fire, 40 );
						this.SetDamageType( ResistanceType.Cold, 40 );
						this.SetDamageType( ResistanceType.Poison, 40 );
						this.SetDamageType( ResistanceType.Energy, 40 );

						this.RawStr += 40;
						this.RawInt += 40;
						this.RawDex += 40;
					}
				}
			}

			else if ( this.Stage == 7 )
			{
				if ( defender is BaseCreature )
				{
					BaseCreature bc = (BaseCreature)defender;

					if ( bc.Controlled != true )
					{
						kpgainmin = 1 + ( bc.Hits ) / 50;
						kpgainmax = 1 + ( bc.Hits ) / 50;

						this.KP += Utility.RandomList( kpgainmin, kpgainmax );
					}
				}
			}

			base.OnGaveMeleeAttack( defender );
		}


		public override bool OnDragDrop( Mobile from, Item dropped )
		{
			PlayerMobile player = from as PlayerMobile;
										
			if ( player != null )
			{
				if ( this.Stage > 5 )
				{
					if ( this.ControlMaster == from )
					{
						if ( dropped is BaseArmor || dropped is BaseClothing || dropped is BaseWeapon )
						{
								if ( dropped is BaseWeapon )
								{
									Item check4 = this.FindItemOnLayer( Layer.OneHanded );
									Item check2 = this.FindItemOnLayer( Layer.TwoHanded );
									Item check3 = this.FindItemOnLayer( Layer.FirstValid );

									if ( check4 != null )
									{
										check4.Movable = true;
										from.AddToBackpack( check4 );
									}
									else if ( check2 != null )
									{
										check2.Movable = true;
										from.AddToBackpack( check2 );
									}
									else if ( check3 != null )
									{
										check3.Movable = true;
										from.AddToBackpack( check3 );
									}
									else
									{
									}

									Container pack = this.Backpack; 
									if ( pack == null )
									{
										pack = new Backpack();
										pack.Movable = false;
		
										this.AddItem( pack );
									}
									pack.DropItem( dropped );
									this.AddItem( dropped );
									dropped.Movable = false;
									from.SendMessage("You give " + this.Name + " a new weapon.");
									return true;

								}
								else if ( dropped is BaseArmor )
								{
									BaseArmor ba = (BaseArmor)dropped;
									if ( !ba.AllowMaleWearer && from.Body.IsMale )
										from.SendMessage("Only Females can wear this.");
									else if ( !ba.AllowFemaleWearer && from.Body.IsFemale )
										from.SendMessage("Only Females can wear this.");
									else
									{
										Item check = this.FindItemOnLayer( dropped.Layer );
										if ( check != null )
										{
											check.Movable = true;								
											from.AddToBackpack( check );
	
											Container pack = this.Backpack; 
											if ( pack == null )
											{
												pack = new Backpack();
												pack.Movable = false;
			
												this.AddItem( pack );
											}
											pack.DropItem( dropped );
											this.AddItem( dropped );
											dropped.Movable = false;
		
											from.SendMessage("You give " + this.Name + " a piece of gear.");
											return true;
										
										}
										else
										{
											Container pack = this.Backpack; 
											if ( pack == null )
											{
												pack = new Backpack();
												pack.Movable = false;
				
												this.AddItem( pack );
											}	
											pack.DropItem( dropped );
											this.AddItem( dropped );
											dropped.Movable = true;
		
											from.SendMessage("You give " + this.Name + " a piece of gear.");
											return true;
										}
									}
								}
								else if ( dropped is BaseClothing )
								{
									Item check = this.FindItemOnLayer( dropped.Layer );
									if ( check != null )
									{
										check.Movable = true;								
										from.AddToBackpack( check );

										Container pack = this.Backpack; 
										if ( pack == null )
										{
											pack = new Backpack();
											pack.Movable = false;
			
											this.AddItem( pack );
										}
										pack.DropItem( dropped );
										this.AddItem( dropped );
										dropped.Movable = false;
	
										from.SendMessage("You give " + this.Name + " a piece of gear.");
										return true;
									
									}
									else
									{
										Container pack = this.Backpack; 
										if ( pack == null )
										{
											pack = new Backpack();
											pack.Movable = false;
			
											this.AddItem( pack );
										}
										pack.DropItem( dropped );
										this.AddItem( dropped );
										dropped.Movable = true;
	
										from.SendMessage("You give " + this.Name + " a piece of gear.");
										return true;
									}
								}
								else
								{
								}

						}
						else if ( dropped is Arrow || dropped is Bolt )	
						{
							Container pack = this.Backpack;
							if ( pack == null )
							{
								pack = new Backpack();
								pack.Movable = false;
								this.AddItem( pack );
							}
							pack.DropItem( dropped );
							from.SendMessage("You give " + this.Name + " some arrows.");

						}								
						else							
						{									
							from.SendMessage("This must be a weapon, or a piece of armor or clothing.");
							return false;
						}
					}
					else
					{
						from.SendMessage("You do not own this Mercenary.");
						return false;
					}										
				}											
				else
				{
					from.SendMessage( this.Name + " is not ready to use this.");
					return false;
				}
			}
			return base.OnDragDrop( from, dropped );
		}

		private DateTime m_NextBreathe;

		public override void OnActionCombat()
		{
			Mobile combatant = Combatant;

			if ( combatant == null || combatant.Deleted || combatant.Map != Map || !InRange( combatant, 12 ) || !CanBeHarmful( combatant ) || !InLOS( combatant ) )
				return;

			if ( DateTime.Now >= m_NextBreathe )
			{
				Breathe( combatant );

				m_NextBreathe = DateTime.Now + TimeSpan.FromSeconds( 12.0 + (3.0 * Utility.RandomDouble()) ); // 12-15 seconds
			}
		}

		public void Breathe( Mobile m )
		{
			DoHarmful( m );

			m_BreatheTimer = new BreatheTimer( m, this, this, TimeSpan.FromSeconds( 1.0 ) );
			m_BreatheTimer.Start();
			m_EndBreathe = DateTime.Now + TimeSpan.FromSeconds( 1.0 );

			this.Frozen = true;

			if ( this.Stage > 0 )
			{
				this.FixedEffect( 0x3728, 10, 15 );
				this.PlaySound( 0x2A1 );
			}
			else
			{
				this.PublicOverheadMessage( MessageType.Regular, this.SpeechHue, true, "Please call a GM if you are getting this message, they will fix the breathe, thank you :)", false );
			}
		}

		private class BreatheTimer : Timer
		{
			private EvoMerc ed;
			private Mobile m_Mobile, m_From;

			public BreatheTimer( Mobile m, EvoMerc owner, Mobile from, TimeSpan duration ) : base( duration ) 
			{
				ed = owner;
				m_Mobile = m;
				m_From = from;
				Priority = TimerPriority.TwoFiftyMS;
			}

			protected override void OnTick()
			{
				int damagemin = ed.Hits / 20;
				int damagemax = ed.Hits / 25;
				ed.Frozen = false;

				m_Mobile.PlaySound( 0x11D );
				AOS.Damage( m_Mobile, m_From, Utility.RandomMinMax( damagemin, damagemax ), 0, 100, 0, 0, 0 );
				Stop();
			}
		}


		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 1 ); // version

                        writer.Write( m_S1 ); 
                        writer.Write( m_S2 ); 
                        writer.Write( m_S3 ); 
                        writer.Write( m_S4 ); 
                        writer.Write( m_S5 ); 
                        writer.Write( m_S6 ); 
			writer.Write( (int) m_KP );
			writer.Write( (int) m_Stage );
			writer.WriteDeltaTime( m_EndBreathe );
			writer.WriteDeltaTime( m_EndMercLoyalty );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
			switch ( version )
			{
				case 1:
				{
                        		m_S1 = reader.ReadBool(); 
                        		m_S2 = reader.ReadBool(); 
                        		m_S3 = reader.ReadBool(); 
                        		m_S4 = reader.ReadBool(); 
                        		m_S5 = reader.ReadBool(); 
                        		m_S6 = reader.ReadBool(); 
					m_KP = reader.ReadInt();
					m_Stage = reader.ReadInt();


					m_EndBreathe = reader.ReadDeltaTime();
					m_BreatheTimer = new BreatheTimer( this, this, this, m_EndBreathe - DateTime.Now );
					m_BreatheTimer.Start();

					m_EndMercLoyalty = reader.ReadDeltaTime();
					m_MercLoyaltyTimer = new MercLoyaltyTimer( this, m_EndMercLoyalty - DateTime.Now );
					m_MercLoyaltyTimer.Start();

					break;
				}
				case 0:
				{
					TimeSpan durationbreathe = TimeSpan.FromSeconds( 1.0 );
					TimeSpan durationloyalty = TimeSpan.FromSeconds( 5.0 );

					m_BreatheTimer = new BreatheTimer( this, this, this, durationbreathe );
					m_BreatheTimer.Start();
					m_EndBreathe = DateTime.Now + durationbreathe;


					m_MercLoyaltyTimer = new MercLoyaltyTimer( this, durationloyalty );
					m_MercLoyaltyTimer.Start();
					m_EndMercLoyalty = DateTime.Now + durationloyalty;

					break;
				}
			}

		}

		public override bool OnBeforeDeath()
		{
			Mobile from = this.ControlMaster;

			if ( from != null )
			{
				if ( this.Mount != null )
				{
					for ( int i = 0; i < this.Items.Count; ++i )
					{
						Item item = (Item)this.Items[i];

						if ( item is IMountItem )
						{
							IMount mount = ((IMountItem)item).Mount;

							if ( mount != null )
							{
								mount.Rider = null;
								if ( mount is EtherealMount )
								{
									EtherealMount ethy = (EtherealMount)mount;
										if ( from.Backpack != null )
											from.Backpack.DropItem( ethy );
								}
							}

							if ( this.Items.IndexOf( item ) == -1 )
								--i;
						}
					}

					for ( int i = 0; i < this.Items.Count; ++i )
					{
						Item item = (Item)this.Items[i];

						if ( item.Layer == Layer.Mount )
						{
							if ( from.Backpack != null )
								from.Backpack.DropItem( item );
							--i;
						}
					}
				}
			}
			return base.OnBeforeDeath();
		}
	}

	public class StatGump : Gump
	{
		private static string FormatSkill( BaseCreature c, SkillName name )
		{
			Skill skill = c.Skills[name];

			if ( skill.Base < 10.0 )
				return "<div align=right>---</div>";

			return String.Format( "<div align=right>{0:F1}</div>", skill.Base );
		}

		private static string FormatAttributes( int cur, int max )
		{
			if ( max == 0 )
				return "<div align=right>---</div>";

			return String.Format( "<div align=right>{0}/{1}</div>", cur, max );
		}

		private static string FormatStat( int val )
		{
			if ( val == 0 )
				return "<div align=right>---</div>";

			return String.Format( "<div align=right>{0}</div>", val );
		}

		private static string FormatElement( int val )
		{
			if ( val <= 0 )
				return "<div align=right>---</div>";

			return String.Format( "<div align=right>{0}%</div>", val );
		}

		private const int LabelColor = 0x24E5;

		public StatGump( BaseCreature c ) : base( 250, 50 )
		{
			AddPage( 0 );

			AddImage( 100, 100, 2080 );
			AddImage( 118, 137, 2081 );
			AddImage( 118, 207, 2081 );
			AddImage( 118, 277, 2081 );
			AddImage( 118, 347, 2083 );

			AddHtml( 147, 108, 210, 18, String.Format( "<center><i>{0}</i></center>", c.Name ), false, false );

			AddButton( 240, 77, 2093, 2093, 2, GumpButtonType.Reply, 0 );

			AddImage( 140, 138, 2091 );
			AddImage( 140, 335, 2091 );

			int pages = ( Core.AOS ? 5 : 3 );
			int page = 0;


			#region Attributes
			AddPage( ++page );

			AddImage( 128, 152, 2086 );
			AddHtmlLocalized( 147, 150, 160, 18, 1049593, 200, false, false ); // Attributes

			AddHtmlLocalized( 153, 168, 160, 18, 1049578, LabelColor, false, false ); // Hits
			AddHtml( 280, 168, 75, 18, FormatAttributes( c.Hits, c.HitsMax ), false, false );

			AddHtmlLocalized( 153, 186, 160, 18, 1049579, LabelColor, false, false ); // Stamina
			AddHtml( 280, 186, 75, 18, FormatAttributes( c.Stam, c.StamMax ), false, false );

			AddHtmlLocalized( 153, 204, 160, 18, 1049580, LabelColor, false, false ); // Mana
			AddHtml( 280, 204, 75, 18, FormatAttributes( c.Mana, c.ManaMax ), false, false );

			AddHtmlLocalized( 153, 222, 160, 18, 1028335, LabelColor, false, false ); // Strength
			AddHtml( 320, 222, 35, 18, FormatStat( c.Str ), false, false );

			AddHtmlLocalized( 153, 240, 160, 18, 3000113, LabelColor, false, false ); // Dexterity
			AddHtml( 320, 240, 35, 18, FormatStat( c.Dex ), false, false );

			AddHtmlLocalized( 153, 258, 160, 18, 3000112, LabelColor, false, false ); // Intelligence
			AddHtml( 320, 258, 35, 18, FormatStat( c.Int ), false, false );

			if ( Core.AOS )
			{
				AddImage( 128, 278, 2086 );
				AddHtmlLocalized( 147, 276, 160, 18, 1049594, 200, false, false ); // Loyalty Rating

				//AddHtmlLocalized( 153, 294, 160, 18, (!c.Controlled || c.Loyalty == PetLoyalty.MaxLoyalty ) ? 1061643 : 1049594 + (int)c.Loyalty, LabelColor, false, false );
			}
			else
			{
				AddImage( 128, 278, 2086 );
				AddHtmlLocalized( 147, 276, 160, 18, 3001016, 200, false, false ); // Miscellaneous

				AddHtmlLocalized( 153, 294, 160, 18, 1049581, LabelColor, false, false ); // Armor Rating
				AddHtml( 320, 294, 35, 18, FormatStat( c.VirtualArmor ), false, false );
			}

			AddButton( 340, 358, 5601, 5605, 0, GumpButtonType.Page, page + 1 );
			AddButton( 317, 358, 5603, 5607, 0, GumpButtonType.Page, pages );
			#endregion

			#region Resistances
			if ( Core.AOS )
			{
				AddPage( ++page );

				AddImage( 128, 152, 2086 );
				AddHtmlLocalized( 147, 150, 160, 18, 1061645, 200, false, false ); // Resistances

				AddHtmlLocalized( 153, 168, 160, 18, 1061646, LabelColor, false, false ); // Physical
				AddHtml( 320, 168, 35, 18, FormatElement( c.PhysicalResistance ), false, false );

				AddHtmlLocalized( 153, 186, 160, 18, 1061647, LabelColor, false, false ); // Fire
				AddHtml( 320, 186, 35, 18, FormatElement( c.FireResistance ), false, false );

				AddHtmlLocalized( 153, 204, 160, 18, 1061648, LabelColor, false, false ); // Cold
				AddHtml( 320, 204, 35, 18, FormatElement( c.ColdResistance ), false, false );

				AddHtmlLocalized( 153, 222, 160, 18, 1061649, LabelColor, false, false ); // Poison
				AddHtml( 320, 222, 35, 18, FormatElement( c.PoisonResistance ), false, false );

				AddHtmlLocalized( 153, 240, 160, 18, 1061650, LabelColor, false, false ); // Energy
				AddHtml( 320, 240, 35, 18, FormatElement( c.EnergyResistance ), false, false );

				AddButton( 340, 358, 5601, 5605, 0, GumpButtonType.Page, page + 1 );
				AddButton( 317, 358, 5603, 5607, 0, GumpButtonType.Page, page - 1 );
			}
			#endregion

			#region Damage
			if ( Core.AOS )
			{
				AddPage( ++page );

				AddImage( 128, 152, 2086 );
				AddHtmlLocalized( 147, 150, 160, 18, 1017319, 200, false, false ); // Damage

				AddHtmlLocalized( 153, 168, 160, 18, 1061646, LabelColor, false, false ); // Physical
				AddHtml( 320, 168, 35, 18, FormatElement( c.PhysicalDamage ), false, false );

				AddHtmlLocalized( 153, 186, 160, 18, 1061647, LabelColor, false, false ); // Fire
				AddHtml( 320, 186, 35, 18, FormatElement( c.FireDamage ), false, false );

				AddHtmlLocalized( 153, 204, 160, 18, 1061648, LabelColor, false, false ); // Cold
				AddHtml( 320, 204, 35, 18, FormatElement( c.ColdDamage ), false, false );

				AddHtmlLocalized( 153, 222, 160, 18, 1061649, LabelColor, false, false ); // Poison
				AddHtml( 320, 222, 35, 18, FormatElement( c.PoisonDamage ), false, false );

				AddHtmlLocalized( 153, 240, 160, 18, 1061650, LabelColor, false, false ); // Energy
				AddHtml( 320, 240, 35, 18, FormatElement( c.EnergyDamage ), false, false );

				AddButton( 340, 358, 5601, 5605, 0, GumpButtonType.Page, page + 1 );
				AddButton( 317, 358, 5603, 5607, 0, GumpButtonType.Page, page - 1 );
			}
			#endregion

			#region Skills
			AddPage( ++page );

			AddImage( 128, 152, 2086 );
			AddHtmlLocalized( 147, 150, 160, 18, 3001030, 200, false, false ); // Combat Ratings

			AddHtmlLocalized( 153, 168, 160, 18, 1044103, LabelColor, false, false ); // Wrestling
			AddHtml( 320, 168, 35, 18, FormatSkill( c, SkillName.Wrestling ), false, false );

			AddHtmlLocalized( 153, 186, 160, 18, 1044087, LabelColor, false, false ); // Tactics
			AddHtml( 320, 186, 35, 18, FormatSkill( c, SkillName.Tactics ), false, false );

			AddHtmlLocalized( 153, 204, 160, 18, 1044086, LabelColor, false, false ); // Magic Resistance
			AddHtml( 320, 204, 35, 18, FormatSkill( c, SkillName.MagicResist ), false, false );

			AddHtmlLocalized( 153, 222, 160, 18, 1044061, LabelColor, false, false ); // Anatomy
			AddHtml( 320, 222, 35, 18, FormatSkill( c, SkillName.Anatomy ), false, false );

			AddHtmlLocalized( 153, 240, 160, 18, 1044090, LabelColor, false, false ); // Poisoning
			AddHtml( 320, 240, 35, 18, FormatSkill( c, SkillName.Poisoning ), false, false );

			AddImage( 128, 260, 2086 );
			AddHtmlLocalized( 147, 258, 160, 18, 3001032, 200, false, false ); // Lore & Knowledge

			AddHtmlLocalized( 153, 276, 160, 18, 1044085, LabelColor, false, false ); // Magery
			AddHtml( 320, 276, 35, 18, FormatSkill( c, SkillName.Magery ), false, false );

			AddHtmlLocalized( 153, 294, 160, 18, 1044076, LabelColor, false, false ); // Evaluating Intelligence
			AddHtml( 320, 294, 35, 18,FormatSkill( c, SkillName.EvalInt ), false, false );

			AddHtmlLocalized( 153, 312, 160, 18, 1044106, LabelColor, false, false ); // Meditation
			AddHtml( 320, 312, 35, 18, FormatSkill( c, SkillName.Meditation ), false, false );

			AddButton( 340, 358, 5601, 5605, 0, GumpButtonType.Page, page + 1 );
			AddButton( 317, 358, 5603, 5607, 0, GumpButtonType.Page, page - 1 );
			#endregion

			#region Misc
			AddPage( ++page );

			AddImage( 128, 152, 2086 );
			AddHtmlLocalized( 147, 150, 160, 18, 1049563, 200, false, false ); // Preferred Foods

			int foodPref = 3000340;

			if ( (c.FavoriteFood & FoodType.FruitsAndVegies) != 0 )
				foodPref = 1049565; // Fruits and Vegetables
			else if ( (c.FavoriteFood & FoodType.GrainsAndHay) != 0 )
				foodPref = 1049566; // Grains and Hay
			else if ( (c.FavoriteFood & FoodType.Fish) != 0 )
				foodPref = 1049568; // Fish
			else if ( (c.FavoriteFood & FoodType.Meat) != 0 )
				foodPref = 1049564; // Meat

			AddHtmlLocalized( 153, 168, 160, 18, foodPref, LabelColor, false, false );

			AddImage( 128, 188, 2086 );
			AddHtmlLocalized( 147, 186, 160, 18, 1049569, 200, false, false ); // Pack Instincts

			int packInstinct = 3000340;

			if ( (c.PackInstinct & PackInstinct.Canine) != 0 )
				packInstinct = 1049570; // Canine
			else if ( (c.PackInstinct & PackInstinct.Ostard) != 0 )
				packInstinct = 1049571; // Ostard
			else if ( (c.PackInstinct & PackInstinct.Feline) != 0 )
				packInstinct = 1049572; // Feline
			else if ( (c.PackInstinct & PackInstinct.Arachnid) != 0 )
				packInstinct = 1049573; // Arachnid
			else if ( (c.PackInstinct & PackInstinct.Daemon) != 0 )
				packInstinct = 1049574; // Daemon
			else if ( (c.PackInstinct & PackInstinct.Bear) != 0 )
				packInstinct = 1049575; // Bear
			else if ( (c.PackInstinct & PackInstinct.Equine) != 0 )
				packInstinct = 1049576; // Equine
			else if ( (c.PackInstinct & PackInstinct.Bull) != 0 )
				packInstinct = 1049577; // Bull

			AddHtmlLocalized( 153, 204, 160, 18, packInstinct, LabelColor, false, false );

			if ( !Core.AOS )
			{
				AddImage( 128, 224, 2086 );
				AddHtmlLocalized( 147, 222, 160, 18, 1049594, 200, false, false ); // Loyalty Rating

				//AddHtmlLocalized( 153, 240, 160, 18, (!c.Controlled || c.Loyalty == PetLoyalty.MaxLoyalty ) ? 1061643 : 1049594 + (int)c.Loyalty, LabelColor, false, false );
			}

			AddButton( 340, 358, 5601, 5605, 0, GumpButtonType.Page, 1 );
			AddButton( 317, 358, 5603, 5607, 0, GumpButtonType.Page, page - 1 );
			#endregion
		}
	}
	
	public class MercLoyaltyTimer : Timer
	{ 
		private EvoMerc ed;

		public MercLoyaltyTimer( EvoMerc owner, TimeSpan duration ) : base( duration ) 
		{ 
			Priority = TimerPriority.OneSecond;
			ed = owner;
		}

		protected override void OnTick() 
		{ 
                  	ed.Loyalty = 100;

			MercLoyaltyTimer lt = new MercLoyaltyTimer( ed, TimeSpan.FromSeconds( 5.0 ) );
			lt.Start();
			ed.EndMercLoyalty = DateTime.Now + TimeSpan.FromSeconds( 5.0 );

			Stop();
		}
	}
	public class EvoMercBuyInfo
	{
		private int m_Title;
		private string m_TitleString;
		private int m_Price;
		private Layer m_Layer;
		private Type m_GumpType;
		private object[] m_GumpArgs;

		public int Title{ get{ return m_Title; } }
		public string TitleString{ get{ return m_TitleString; } }
		public int Price{ get{ return m_Price; } }
		public Layer Layer{ get{ return m_Layer; } }
		public Type GumpType{ get{ return m_GumpType; } }
		public object[] GumpArgs{ get{ return m_GumpArgs; } }

		public EvoMercBuyInfo( int title, int price, Layer layer, Type gumpType, object[] args )
		{
			m_Title = title;
			m_Price = price;
			m_Layer = layer;
			m_GumpType = gumpType;
			m_GumpArgs = args;
		}

		public EvoMercBuyInfo( string title, int price, Layer layer, Type gumpType, object[] args )
		{
			m_TitleString = title;
			m_Price = price;
			m_Layer = layer;
			m_GumpType = gumpType;
			m_GumpArgs = args;
		}
	}

	public class EvoMercBuyGump : Gump
	{
		private Mobile m_From;
		private Mobile m_Vendor;
		private EvoMercBuyInfo[] m_SellList;

		public EvoMercBuyGump( Mobile from, BaseCreature vendor, EvoMercBuyInfo[] sellList ) : base( 50, 50 )
		{
			m_From = from;
			m_Vendor = vendor;
			m_SellList = sellList;

			from.CloseGump( typeof( EvoMercBuyGump ) );
			from.CloseGump( typeof( ChangeHairHuGump ) );
			from.CloseGump( typeof( ChangeHairstylGump ) );

			bool isFemale = ( m_Vendor.Body.IsFemale );

			int balance = Banker.GetBalance( from );
			int canAfford = 0;

			for ( int i = 0; i < sellList.Length; ++i )
			{
				if ( balance >= sellList[i].Price && (sellList[i].Layer != Layer.FacialHair || !isFemale) )
						++canAfford;
			}

			AddPage( 0 );

			AddBackground( 50, 10, 450, 100 + (canAfford * 25), 2600 );

			AddHtmlLocalized( 100, 40, 350, 20, 1018356, false, false ); // Choose your hairstyle change:

			int index = 0;

			for ( int i = 0; i < sellList.Length; ++i )
			{
				if ( balance >= sellList[i].Price && (sellList[i].Layer != Layer.FacialHair || !isFemale) )
				{
					if ( sellList[i].TitleString != null )
						AddHtml( 140, 75 + (index * 25), 300, 20, sellList[i].TitleString, false, false );
					else
						AddHtmlLocalized( 140, 75 + (index * 25), 300, 20, sellList[i].Title, false, false );

					AddButton( 100, 75 + (index++ * 25), 4005, 4007, 1 + i, GumpButtonType.Reply, 0 );
				}
			}
		}

		public override void OnResponse( NetState sender, RelayInfo info )
		{
			int index = info.ButtonID - 1;

			if ( index >= 0 && index < m_SellList.Length )
			{
				EvoMercBuyInfo buyInfo = m_SellList[index];

				int balance = Banker.GetBalance( m_From );

				bool isFemale = ( m_Vendor.Female || m_Vendor.Body.IsFemale );

				if ( buyInfo.Layer == Layer.FacialHair && isFemale )
				{
					// You cannot place facial hair on a woman!
					m_Vendor.PrivateOverheadMessage( MessageType.Regular, 0x3B2, 1010639, m_From.NetState );
				}
				else if ( balance >= buyInfo.Price )
				{
					try
					{
						object[] origArgs = buyInfo.GumpArgs;
						object[] args = new object[origArgs.Length];

						for ( int i = 0; i < args.Length; ++i )
						{
							if ( origArgs[i] == EvoMerc.Price )
								args[i] = m_SellList[index].Price;
							else if ( origArgs[i] == EvoMerc.From	)
								args[i] = m_From;
							else if ( origArgs[i] == EvoMerc.Vendor )
								args[i] = m_Vendor;
							else
								args[i] = origArgs[i];
						}

						Gump g = Activator.CreateInstance( buyInfo.GumpType, args ) as Gump;

						m_From.SendGump( g );
					}
					catch
					{
					}
				}
				else
				{
					// You cannot afford my services for that style.
					m_Vendor.PrivateOverheadMessage( MessageType.Regular, 0x3B2, 1042293, m_From.NetState );
				}
			}
		}
	}

	public class ChangeHairHueEnt
	{
		private string m_Name;
		private int[] m_Hues;

		public string Name{ get{ return m_Name; } }
		public int[] Hues{ get{ return m_Hues; } }

		public ChangeHairHueEnt( string name, int[] hues )
		{
			m_Name = name;
			m_Hues = hues;
		}

		public ChangeHairHueEnt( string name, int start, int count )
		{
			m_Name = name;

			m_Hues = new int[count];

			for ( int i = 0; i < count; ++i )
				m_Hues[i] = start + i;
		}

		public static readonly ChangeHairHueEnt[] BrightEntries = new ChangeHairHueEnt[]
			{
				new ChangeHairHueEnt( "*****", 12, 10 ),
				new ChangeHairHueEnt( "*****", 32, 5 ),
				new ChangeHairHueEnt( "*****", 38, 8 ),
				new ChangeHairHueEnt( "*****", 54, 3 ),
				new ChangeHairHueEnt( "*****", 62, 10 ),
				new ChangeHairHueEnt( "*****", 81, 2 ),
				new ChangeHairHueEnt( "*****", 89, 2 ),
				new ChangeHairHueEnt( "*****", 1153, 2 )
			};

		public static readonly ChangeHairHueEnt[] RegularEntries = new ChangeHairHueEnt[]
			{
				new ChangeHairHueEnt( "*****", 1602, 26 ),
				new ChangeHairHueEnt( "*****", 1628, 27 ),
				new ChangeHairHueEnt( "*****", 1502, 32 ),
				new ChangeHairHueEnt( "*****", 1302, 32 ),
				new ChangeHairHueEnt( "*****", 1402, 32 ),
				new ChangeHairHueEnt( "*****", 1202, 24 ),
				new ChangeHairHueEnt( "*****", 2402, 29 ),
				new ChangeHairHueEnt( "*****", 2213, 6 ),
				new ChangeHairHueEnt( "*****", 1102, 8 ),
				new ChangeHairHueEnt( "*****", 1110, 8 ),
				new ChangeHairHueEnt( "*****", 1118, 16 ),
				new ChangeHairHueEnt( "*****", 1134, 16 )
			};
	}

	public class ChangeHairHuGump : Gump
	{
		private Mobile m_From;
		private Mobile m_Vendor;
		private int m_Price;
		private Layer[] m_Layers;
		private ChangeHairHueEnt[] m_Entries;

		public ChangeHairHuGump( Mobile from, Mobile vendor, int price, Layer[] layers, ChangeHairHueEnt[] entries ) : base( 50, 50 )
		{
			m_From = from;
			m_Vendor = vendor;
			m_Price = price;
			m_Layers = layers;
			m_Entries = entries;

			from.CloseGump( typeof( EvoMercBuyGump ) );
			from.CloseGump( typeof( ChangeHairHuGump ) );
			from.CloseGump( typeof( ChangeHairstylGump ) );

			AddPage( 0 );

			AddBackground( 100, 10, 350, 370, 2600 );
			AddBackground( 120, 54, 110, 270, 5100 );

			AddHtmlLocalized( 155, 25, 240, 30, 1011013, false, false ); // <center>Hair Color Selection Menu</center>

			AddHtmlLocalized( 150, 330, 220, 35, 1011014, false, false ); // Dye my hair this color!
			AddButton( 380, 330, 4005, 4007, 1, GumpButtonType.Reply, 0 );

			for ( int i = 0; i < entries.Length; ++i )
			{
				ChangeHairHueEnt entry = entries[i];

				AddLabel( 130, 59 + (i * 22), entry.Hues[0] - 1, entry.Name );
				AddButton( 207, 60 + (i * 22), 5224, 5224, 0, GumpButtonType.Page, 1 + i );
			}

			for ( int i = 0; i < entries.Length; ++i )
			{
				ChangeHairHueEnt entry = entries[i];
				int[] hues = entry.Hues;
				string name = entry.Name;

				AddPage( 1 + i );

				for ( int j = 0; j < hues.Length; ++j )
				{
					AddLabel( 278 + ((j / 16) * 80), 52 + ((j % 16) * 17), hues[j] - 1, name );
					AddRadio( 260 + ((j / 16) * 80), 52 + ((j % 16) * 17), 210, 211, false, (j * entries.Length) + i );
				}
			}
		}

		public override void OnResponse( NetState sender, RelayInfo info )
		{
			if ( info.ButtonID == 1 )
			{
				int[] switches = info.Switches;

				if ( switches.Length > 0 )
				{
					int index = switches[0] % m_Entries.Length;
					int offset = switches[0] / m_Entries.Length;

					if ( index >= 0 && index < m_Entries.Length )
					{
						if ( offset >= 0 && offset < m_Entries[index].Hues.Length )
						{
							int hue = m_Entries[index].Hues[offset];

							bool hasConsumed = false;

							for ( int i = 0; i < m_Layers.Length; ++i )
							{
								Item item = m_Vendor.FindItemOnLayer( m_Layers[i] );

								if ( item == null )
									continue;

								if ( !hasConsumed )
								{
									if ( !Banker.Withdraw( m_From, m_Price ) )
									{
										m_Vendor.PrivateOverheadMessage( MessageType.Regular, 0x3B2, 1042293, m_From.NetState ); // You cannot afford my services for that style.
										return;
									}

									hasConsumed = true;
								}

								item.Hue = hue;
							}

							if ( !hasConsumed )
								m_Vendor.PrivateOverheadMessage( MessageType.Regular, 0x3B2, 502623, m_From.NetState ); // You have no hair to dye and you cannot use this.
						}
					}
				}
				else
				{
					// You decide not to change your hairstyle.
					m_Vendor.PrivateOverheadMessage( MessageType.Regular, 0x3B2, 1013009, m_From.NetState );
				}
			}
			else
			{
				// You decide not to change your hairstyle.
				m_Vendor.PrivateOverheadMessage( MessageType.Regular, 0x3B2, 1013009, m_From.NetState );
			}
		}
	}

	public class ChangeHairstyleEnt
	{
		private Type m_ItemType;
		private int m_GumpID;
		private int m_X, m_Y;

		public Type ItemType{ get{ return m_ItemType; } }
		public int GumpID{ get{ return m_GumpID; } }
		public int X{ get{ return m_X; } }
		public int Y{ get{ return m_Y; } }

		public ChangeHairstyleEnt( int gumpID, int x, int y, Type itemType )
		{
			m_GumpID = gumpID;
			m_X = x;
			m_Y = y;
			m_ItemType = itemType;
		}

		public static readonly ChangeHairstyleEnt[] HairEntries = new ChangeHairstyleEnt[]
			{
				new ChangeHairstyleEnt( 50700,  70 - 137,  20 -  60, typeof( ShortHair ) ),
				new ChangeHairstyleEnt( 60710, 193 - 260,  18 -  60, typeof( PageboyHair ) ),
				new ChangeHairstyleEnt( 50703, 316 - 383,  25 -  60, typeof( Mohawk ) ),
				new ChangeHairstyleEnt( 60708,  70 - 137,  75 - 125, typeof( LongHair ) ),
				new ChangeHairstyleEnt( 60900, 193 - 260,  85 - 125, typeof( Afro ) ),
				new ChangeHairstyleEnt( 60713, 320 - 383,  85 - 125, typeof( KrisnaHair ) ),
				new ChangeHairstyleEnt( 60702,  70 - 137, 140 - 190, typeof( PonyTail ) ),
				new ChangeHairstyleEnt( 60707, 193 - 260, 140 - 190, typeof( TwoPigTails ) ),
				new ChangeHairstyleEnt( 60901, 315 - 383, 150 - 190, typeof( ReceedingHair ) ),
				new ChangeHairstyleEnt( 0, 0, 0, null )
			};

		public static readonly ChangeHairstyleEnt[] BeardEntries = new ChangeHairstyleEnt[]
			{
				new ChangeHairstyleEnt( 50800, 120 - 187,  30 -  80, typeof( Goatee ) ),
				new ChangeHairstyleEnt( 50904, 243 - 310,  33 -  80, typeof( MediumShortBeard ) ),
				new ChangeHairstyleEnt( 50906, 120 - 187, 100 - 150, typeof( Vandyke ) ),
				new ChangeHairstyleEnt( 50801, 243 - 310,  95 - 150, typeof( LongBeard ) ),
				new ChangeHairstyleEnt( 50802, 120 - 187, 173 - 220, typeof( ShortBeard ) ),
				new ChangeHairstyleEnt( 50905, 243 - 310, 165 - 220, typeof( MediumLongBeard ) ),
				new ChangeHairstyleEnt( 50808, 120 - 187, 242 - 290, typeof( Mustache ) ),
				new ChangeHairstyleEnt( 0, 0, 0, null )
			};
	}

	public class ChangeHairstylGump : Gump
	{
		private Mobile m_From;
		private Mobile m_Vendor;
		private int m_Price;
		private Layer m_Layer;
		private ChangeHairstyleEnt[] m_Entries;

		public ChangeHairstylGump( Mobile from, Mobile vendor, int price, Layer layer, ChangeHairstyleEnt[] entries ) : base( 50, 50 )
		{
			m_From = from;
			m_Vendor = vendor;
			m_Price = price;
			m_Layer = layer;
			m_Entries = entries;

			from.CloseGump( typeof( EvoMercBuyGump ) );
			from.CloseGump( typeof( ChangeHairHuGump ) );
			from.CloseGump( typeof( ChangeHairstylGump ) );

			int tableWidth = ( layer == Layer.Hair ? 3 : 2 );
			int tableHeight = ( (entries.Length + tableWidth - ( layer == Layer.Hair ? 2 : 1 )) / tableWidth );
			int offsetWidth = 123;
			int offsetHeight = ( layer == Layer.Hair ? 65 : 70 );

			AddPage( 0 );

			AddBackground( 0, 0, 81 + (tableWidth * offsetWidth), 105 + (tableHeight * offsetHeight), 2600 );

			AddButton( 45, 45 + (tableHeight * offsetHeight), 4005, 4007, 1, GumpButtonType.Reply, 0 );
			AddHtmlLocalized( 77, 45 + (tableHeight * offsetHeight), 90, 35, 1006044, false, false ); // Ok

			AddButton( 81 + (tableWidth * offsetWidth) - 180, 45 + (tableHeight * offsetHeight), 4005, 4007, 0, GumpButtonType.Reply, 0 );
			AddHtmlLocalized( 81 + (tableWidth * offsetWidth) - 148, 45 + (tableHeight * offsetHeight), 90, 35, 1006045, false, false ); // Cancel

			if ( layer == Layer.Hair )
				AddHtmlLocalized( 50, 15, 350, 20, 1018353, false, false ); // <center>New Hairstyle</center>
			else
				AddHtmlLocalized( 55, 15, 200, 20, 1018354, false, false ); // <center>New Beard</center>

			for ( int i = 0; i < entries.Length; ++i )
			{
				int xTable = i % tableWidth;
				int yTable = i / tableWidth;

				if ( entries[i].GumpID != 0 )
				{
					AddRadio( 40 + (xTable * offsetWidth), 70 + (yTable * offsetHeight), 208, 209, false, i );
					AddBackground( 87 + (xTable * offsetWidth), 50 + (yTable * offsetHeight), 50, 50, 2620 );
					AddImage( 87 + (xTable * offsetWidth) + entries[i].X, 50 + (yTable * offsetHeight) + entries[i].Y, entries[i].GumpID );
				}
				else if ( layer == Layer.Hair )
				{
					AddRadio( 40 + ((xTable + 1) * offsetWidth), 240, 208, 209, false, i );
					AddHtmlLocalized( 60 + ((xTable + 1) * offsetWidth), 240, 85, 35, 1011064, false, false ); // Bald
				}
				else
				{
					AddRadio( 40 + (xTable * offsetWidth), 70 + (yTable * offsetHeight), 208, 209, false, i );
					AddHtmlLocalized( 60 + (xTable * offsetWidth), 70 + (yTable * offsetHeight), 85, 35, 1011064, false, false ); // Bald
				}
			}
		}

		public override void OnResponse( NetState sender, RelayInfo info )
		{
			if ( m_Layer == Layer.FacialHair && (m_From.Female || m_From.Body.IsFemale) )
				return;

			if ( info.ButtonID == 1 )
			{
				int[] switches = info.Switches;

				if ( switches.Length > 0 )
				{
					int index = switches[0];

					if ( index >= 0 && index < m_Entries.Length )
					{
						ChangeHairstyleEnt entry = m_Entries[index];

						if ( m_From is PlayerMobile )
							((PlayerMobile)m_From).SetHairMods( -1, -1 );

						Item hair = m_Vendor.FindItemOnLayer( m_Layer );

						if ( entry.ItemType == null )
						{
							if ( hair == null )
								return;

							if ( Banker.Withdraw( m_From, m_Price ) )
								hair.Delete();
							else
								m_Vendor.PrivateOverheadMessage( MessageType.Regular, 0x3B2, 1042293, m_From.NetState ); // You cannot afford my services for that style.
						}
						else
						{
							if ( hair != null && hair.GetType() == entry.ItemType )
								return;

							Item newHair = null;

							try{ newHair = Activator.CreateInstance( entry.ItemType, null ) as Item; }
							catch{}

							if ( newHair == null )
								return;

							if ( Banker.Withdraw( m_From, m_Price ) )
							{
								if ( hair != null )
								{
									newHair.Hue = hair.Hue;
									hair.Delete();
								}

								m_Vendor.AddItem( newHair );
							}
							else
							{
								newHair.Delete();
								m_Vendor.PrivateOverheadMessage( MessageType.Regular, 0x3B2, 1042293, m_From.NetState ); // You cannot afford my services for that style.
							}
						}
					}
				}
				else
				{
					// You decide not to change your hairstyle.
					m_Vendor.PrivateOverheadMessage( MessageType.Regular, 0x3B2, 1013009, m_From.NetState );
				}
			}
			else
			{
				// You decide not to change your hairstyle.
				m_Vendor.PrivateOverheadMessage( MessageType.Regular, 0x3B2, 1013009, m_From.NetState );
			}
		}
	}
}