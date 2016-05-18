 using System; 
using Server; 
using Server.Targeting; 
using Server.Items; 

namespace Server.Items 
{ 

public class FrozenSwordOfTerrorTarget : Target 
    { 
          private Item m_Item; 

        public FrozenSwordOfTerrorTarget( Item item ) : base( 12, false, TargetFlags.None ) 
        { 
        m_Item = item; 
        } 

        protected override void OnTarget( Mobile from, object targeted ) 
        { 
            if ( targeted is Mobile ) 
            { 
                Mobile targ = (Mobile)targeted; 
            if ( !from.CanSee( targ ) ) 
            { 
           from.SendMessage( "You Cannot See This Target" ); 
            } 
            else 
            { 
            targ.Emote( "* Ohh-Rah! Get Vanqusihed by the Hands of The Ice-God *" ); 
            targ.BoltEffect( 0 ); 
            targ.Damage( Utility.Random( 5, 65 ) ); 
            from.Emote( "* In Rememberance of Old Man Ice-God!*" ); 
            } 
           } 
          
        } 
    } 
    

   [FlipableAttribute( 0xF5E, 0xF5F )] 
   public class FrozenSwordOfTerror : BaseSword 
   {
       public override int ArtifactRarity { get { return 15; } }

       public override int InitMinHits { get { return 255; } }
       public override int InitMaxHits { get { return 255; } }

      public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.CrushingBlow; } } 
      public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.ParalyzingBlow; } } 
      public override WeaponAnimation DefAnimation{ get{ return WeaponAnimation.Wrestle; } } 

      public override int AosStrengthReq{ get{ return 100; } } 
      public override int AosMinDamage{ get{ return 20; } } 
      public override int AosMaxDamage{ get{ return 40; } } 
      public override int AosSpeed{ get{ return 35; } } 

      public override int OldStrengthReq{ get{ return 100; } } 
      public override int OldMinDamage{ get{ return 20; } } 
      public override int OldMaxDamage{ get{ return 40; } } 
      public override int OldSpeed{ get{ return 35; } } 

      public override int DefHitSound{ get{ return 0x48; } } 
      public override int DefMissSound{ get{ return 0x48; } } 
       
      private int DefSerUss = 0; 
      private DateTime DefSerTimeLimit = DateTime.Now; 

      [Constructable] 
      public FrozenSwordOfTerror() : base( 0x13B9 ) 
      { 
         Weight = 6.0; 
         Hue = 1152; 
         Name = "Ice-God's Frozen Sword"; 
         DefSerUss = 0;
         WeaponAttributes.HitColdArea = 30;
         WeaponAttributes.UseBestSkill = 1;
			Attributes.LowerRegCost = 25;
			Attributes.SpellChanneling = 1;
			Attributes.NightSight = 1;
			Attributes.LowerManaCost = 30;
			Attributes.CastSpeed = 2;
			Attributes.CastRecovery =1 ;
			Attributes.Luck = 600;
            Attributes.WeaponSpeed = 30;
      } 

      public FrozenSwordOfTerror( Serial serial ) : base( serial ) 
      { 
      } 

    /*  public override void OnHit( Mobile attacker, Mobile defender ) 
      { 
      
      int randomchanvar1=Utility.Random( 1, 3 ); 
      if(randomchanvar1 == 2) 
      { 
            defender.PlaySound( 0x1F4 ); 
            Effects.SendTargetEffect( defender, 0x3709, 32 ); 
            defender.Damage( Utility.Random( 20, 20 ) ); 
            defender.Say( "* Damned By the Mists of The IcE *" ); 
              

         base.OnHit( attacker, defender ); 
      } 
      } 
*/
      public override void OnDoubleClick( Mobile from ) 
      { 
      
      if ( Parent != from ) 
      { 
            from.SendMessage( "The sword must be in your hands in order to use it!" ); 
      } 
      else 
      { 
      if ( DateTime.Now > DefSerTimeLimit + new TimeSpan( 0, 0, 15 ) ) 
      { 
            from.Target = new FrozenSwordOfTerrorTarget( this ); 
            DefSerTimeLimit = DateTime.Now; 
            from.SendMessage( "Who do you wish to cast this on?" ); 
} 
else { 
            from.SendMessage( "Wait Before using this Power again!" ); 
            } 

      } 
      
      } 
      
      
      
      
            public override bool OnEquip( Mobile from ) 
      { 
      if(DefSerUss == 0) 
      { 
      DefSerUss = from.Serial; 
      from.Emote( "* " + from.Name + " feels as if he is no longer Mortal *" ); 
      

   base.OnEquip( from ); 
    
   return true; 
    

      } 
            else if(DefSerUss == from.Serial) 
      { 
      from.Emote( "* " + from.Name + " draws uppon the Frozen Sword of the Gods *" ); 
      

   base.OnEquip( from ); 
    
   return true; 
    

      } 
      else 
      { 
      from.Emote( "* You are Disallowed to Equipt MY swords! *" ); 
      
return false; 
} 
} 
      public override void Serialize( GenericWriter writer ) 
      { 
         base.Serialize( writer ); 
         writer.Write( (int) 0 ); // version 
         writer.Write( (int) DefSerUss ); 
         writer.Write( (DateTime) DefSerTimeLimit ); 
        


      } 

      public override void Deserialize( GenericReader reader ) 
      { 
         base.Deserialize( reader ); 
         int version = reader.ReadInt(); 
         DefSerUss = reader.ReadInt(); 
         DefSerTimeLimit = reader.ReadDateTime(); 
      } 
   } 
} 