using System;
using Server;
using Server.Items;

namespace Server.Items
{
   [FlipableAttribute( 0x2683, 0x2684 )]
   public class RamaRobe : BaseOuterTorso
   {
      [Constructable]
      public RamaRobe() : base( 0x2683 )
      {
         Weight = 5.0;
         Name = "Robe of Rama";
         Layer = Layer.OuterTorso;
      }
        public override int BasePhysicalResistance { get { return 70; } }
        public override int BaseFireResistance { get { return 70; } }
        public override int BaseColdResistance { get { return 70; } }
        public override int BasePoisonResistance { get { return 70; } }
        public override int BaseEnergyResistance { get { return 70; } }



        public override void OnDoubleClick( Mobile m )
      {
         if( Parent != m )
         {
            m.SendMessage( "You must be wearing the robe to use it!" );
         }
         else
         {
            if ( ItemID == 0x2683 || ItemID == 0x2684 )
            {
               m.SendMessage( "You lower the hood." );
               m.PlaySound( 0x57 );
               ItemID = 0x1F03;
               m.NameMod = null;
               m.RemoveItem(this);
               m.EquipItem(this);

            }
            else if ( ItemID == 0x1F03 || ItemID == 0x1F04 )
            {
               m.SendMessage( "You pull the hood over your head." );
               m.PlaySound( 0x57 );
               ItemID = 0x2683;
               m.RemoveItem(this);
               m.EquipItem(this);

            }
         }
      }

      public RamaRobe( Serial serial ) : base( serial )
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
