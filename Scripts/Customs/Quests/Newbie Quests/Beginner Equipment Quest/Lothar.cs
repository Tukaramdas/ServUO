using System;
using System.Collections;
using Server.Items;
using Server.Targeting;
using Server.ContextMenus;
using Server.Gumps;
using Server.Misc;
using Server.Network;
using Server.Spells;
using Server.Accounting;
using System.Collections.Generic;

namespace Server.Mobiles
{
	[CorpseName( "Lothar's corpse" )]
	public class Lothar : Mobile
	{
		public virtual bool IsInvulnerable{ get{ return true; } }
		[Constructable]
		public Lothar()
		{
			Name = "Lothar";
			Title = "the Youth Trainer";
			Body = 400;
			Direction = Direction.South;
			CantWalk = true;
            Blessed = true;

			AddItem( new Server.Items.Boots() );
			AddItem( new Server.Items.Cloak(113) );
			AddItem( new Server.Items.CloseHelm() );
			AddItem( new Server.Items.PlateGorget() );
			AddItem( new Server.Items.PlateGloves() );
			AddItem( new Server.Items.PlateArms() );
			AddItem( new Server.Items.PlateLegs() );
			AddItem( new Server.Items.PlateChest() );
			AddItem( new Server.Items.OrderShield() );
			AddItem( new Server.Items.PaladinSword() );
			
			
			AddItem( new ShortHair(56));
			
		}
		
		public Lothar( Serial serial ) : base( serial )
		{
		}

        public override void GetContextMenuEntries(Mobile from, List<ContextMenuEntry> list)
		{
			base.GetContextMenuEntries( from, list );
			list.Add( new LotharEntry( from, this ) );
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
		
		public class LotharEntry : ContextMenuEntry
		{
			private Mobile m_Mobile;
			private Mobile m_Giver;
			
			public LotharEntry( Mobile from, Mobile giver ) : base( 6146, 3 )
			{
				m_Mobile = from;
				m_Giver = giver;
			}
			
			public override void OnClick()
			{
				
				
				if( !( m_Mobile is PlayerMobile ) )
					return;
				
				PlayerMobile mobile = (PlayerMobile) m_Mobile;
				
				{
					if ( ! mobile.HasGump( typeof( LotharGump ) ) )
					{
						mobile.SendGump( new LotharGump( mobile ));
						
					}
				}
			}
		}
		
		public override bool OnDragDrop( Mobile from, Item dropped )
		{
			Mobile m = from;
			PlayerMobile mobile = m as PlayerMobile;
			
			
			
			if( mobile != null )
			{
				if( dropped is LetterofApprenticeship )
				{
					dropped.Delete();
					mobile.AddToBackpack( new Level1Recommendation() );
					mobile.SendGump( new LotharStartGump( mobile ));
					return true;
				}
				else if( dropped is DiseasedRatMeat )
				{
                    dropped.Delete();
                    mobile.SendGump(new Lothar1Gump(mobile));
                    if (m.Race != Race.Gargoyle)
                    {
                        mobile.AddToBackpack(new ApprenticeRing());
                        mobile.AddToBackpack(new Level2Recommendation());
                    }
                    else
                    {
                        mobile.AddToBackpack(new ApprenticeGargoyleRing());
                        mobile.AddToBackpack(new Level2GargoyleRecommendation());
                    }
                    return true;
                }
				else if( dropped is BloodyBatWing )
				{
					dropped.Delete();	
					mobile.SendGump( new Lothar2Gump( mobile ));
                    if (m.Race != Race.Gargoyle)
                    {
                        mobile.AddToBackpack(new ApprenticeBracelet());
                        mobile.AddToBackpack( new Level3Recommendation() );
                    }
                    else
                    {
                        mobile.AddToBackpack(new ApprenticeGargoyleBracelet());
                        mobile.AddToBackpack(new Level3GargoyleRecommendation());
                    }
                    return true;
				}
				else if( dropped is ToadEye )
				{
					dropped.Delete();
					mobile.SendGump( new Lothar3Gump( mobile ));
                    if (m.Race != Race.Gargoyle)
                    {
                        mobile.AddToBackpack(new ApprenticeEarrings());
                        mobile.AddToBackpack(new Level4Recommendation());
                    }
                    else
                    {

                        mobile.AddToBackpack(new ApprenticeGargoyleEarrings());
                        mobile.AddToBackpack(new Level4GargoyleRecommendation());
                    }
                        return true;
				}
				else if( dropped is WhiteSnakeEgg )
				{
					dropped.Delete();
					mobile.SendGump( new Lothar4Gump( mobile ));

                    if (m.Race != Race.Gargoyle)
                    {
                        mobile.AddToBackpack(new ApprenticeGorget());
                        mobile.AddToBackpack(new Level5Recommendation());
                    }
                    else
                    {
                        mobile.AddToBackpack(new ApprenticeGargoyleApron());
                        mobile.AddToBackpack(new Level5GargoyleRecommendation());
                    }
                    return true;
                }
				else if( dropped is BearFur )
				{
					dropped.Delete();
					mobile.SendGump( new Lothar5Gump( mobile ));

                    if (m.Race != Race.Gargoyle)
                    {

                        mobile.AddToBackpack(new ApprenticeGloves());
                        mobile.AddToBackpack(new Level6Recommendation());
                    }
                    else
                    {

                        mobile.AddToBackpack(new ApprenticeGargoyleWingArmor());
                        mobile.AddToBackpack(new Level6GargoyleRecommendation());
                    }
                    return true;
                }
				else if( dropped is DarkFeather )
				{
					dropped.Delete();
                    mobile.SendGump( new Lothar6Gump( mobile ));

                    if (m.Race != Race.Gargoyle)
                    {
                        mobile.AddToBackpack(new ApprenticeCap());
                        mobile.AddToBackpack(new Level7Recommendation());
                    }
                    else
                    {
                        mobile.AddToBackpack(new Level7GargoyleRecommendation());
                        if (mobile.Female)
                            from.AddToBackpack(new ApprenticeFemaleGargoyleKilt());

                        else

                            from.AddToBackpack(new ApprenticeMaleGargoyleKilt());
                    }
                    return true;
                }
				else if( dropped is RodentBlood )
				{
					dropped.Delete();
                    mobile.SendGump( new Lothar7Gump( mobile ));
                    if (m.Race != Race.Gargoyle)
                    {
                        mobile.AddToBackpack(new ApprenticeSleeves());
                        mobile.AddToBackpack(new Level8Recommendation());
                    }
                    else
                    {
                        mobile.AddToBackpack(new Level8GargoyleRecommendation());
                        if (mobile.Female)
                            from.AddToBackpack(new ApprenticeFemaleGargoyleSleeves());
                        else
                            from.AddToBackpack(new ApprenticeMaleGargoyleSleeves());
                    }
                    return true;
                }
				else if( dropped is ScaledLeather )
				{
					dropped.Delete();
                    mobile.SendGump( new Lothar8Gump( mobile ));
                    if (m.Race != Race.Gargoyle)
                    {
                        mobile.AddToBackpack(new ApprenticeLegs());
                        mobile.AddToBackpack(new Level9Recommendation());
                    }
                    else
                    {
                        mobile.AddToBackpack(new Level9GargoyleRecommendation());
                        if (mobile.Female)
                            from.AddToBackpack(new ApprenticeFemaleGargoyleLegs());
                        else
                            from.AddToBackpack(new ApprenticeMaleGargoyleLegs());
                    }
                    return true;
				}
				else if( dropped is GlowingSkull )
				{
					dropped.Delete();
                    mobile.SendGump( new Lothar9Gump( mobile ));

                    if (m.Race != Race.Gargoyle)
                    {
                        mobile.AddToBackpack(new ApprenticeTunic());
                        mobile.AddToBackpack(new Level10Recommendation());
                    }
                    else
                    {
                        mobile.AddToBackpack(new Level10GargoyleRecommendation());
                        if (mobile.Female)
                            from.AddToBackpack(new ApprenticeFemaleGargoyleChest());
                        else
                            from.AddToBackpack(new ApprenticeMaleGargoyleChest());
                    }
                    return true;
				}
				else if( dropped is MagicOrcHelm )
				{
					dropped.Delete();
                    mobile.AddToBackpack( new BankCheck( 5000 ) );
					mobile.SendGump( new Lothar10Gump( mobile ));

                    if (m.Race != Race.Gargoyle)
                    {
                        mobile.AddToBackpack(new ApprenticeShield());
                        mobile.AddToBackpack(new MasterRecommendation());
                    }
                    else
                    {
                        mobile.AddToBackpack(new ApprenticeGargoyleShield());
                        mobile.AddToBackpack(new MasterGargoyleRecommendation());
                    }
                        return true;
				}
				else if( dropped is SavageHead )
				{
					dropped.Delete();
                    mobile.AddToBackpack( new BankCheck( 10000 ) );
					mobile.SendGump( new LotharFinishGump( mobile ));

                    if (m.Race != Race.Gargoyle)
                    {
                        mobile.AddToBackpack(new ApprenticeSword());
                    }
                    else
                    {
                        mobile.AddToBackpack(new ApprenticeGargoyleSword());
                    }

                    return true;
				}
					else
					{
						mobile.SendMessage("I have no need for this item.");
					}
				}
			else
				{
					this.PrivateOverheadMessage( MessageType.Regular, 1153, false, "I have no need for this item.", mobile.NetState );
				}
		return false;
		}
	}
}