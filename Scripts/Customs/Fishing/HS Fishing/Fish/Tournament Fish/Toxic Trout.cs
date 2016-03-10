using System;

namespace Server.Items
{
    public class ToxicTrout : BaseHighSeasFish
    {		
    	private DateTime m_Created;
		private static readonly TimeSpan expire = TimeSpan.FromHours( 12.0 );
		private Timer m_ExpireTimer;
		
		[CommandProperty( AccessLevel.GameMaster )]
		public DateTime Created
		{
			get{ return m_Created; }
			set{ m_Created = value; }
		}
		
        [Constructable]
        public ToxicTrout() 
        {
        	ItemID = 0x4306;
        	Name = "toxic trout";
        	Hue = 2072;
        	LootType = LootType.Blessed;
        	
        	Created = DateTime.Now;
        	Timer.DelayCall( TimeSpan.FromHours( 12.0 ), new TimerCallback( Expire ) );
        }
        
        private void Expire()
		{
			if ( Deleted )
				return;

			Delete();
		}
        
        public override void GetProperties(ObjectPropertyList list)
        {
			base.AddNameProperty( list );

			TimeSpan remaining = ( ( this.Created + Server.Items.ToxicTrout.expire ) - DateTime.Now );
			string display;

			if ( remaining.Hours > 0 )
			{
				int hour = remaining.Hours;
				display = String.Format( "{0} hours.", hour.ToString() );
			}
			else if ( remaining.Minutes > 0 )
			{
				int min = remaining.Minutes;
				display = String.Format( "{0} minutes.", min.ToString() );
			}
			else if ( remaining.Seconds > 0 )
			{
				int sec = remaining.Seconds;
				display = String.Format( "{0} seconds.", sec.ToString() );
			}
			else
			{
				display = ( "<BASEFONT COLOR=#00FF00>Expired<BASEFONT COLOR=#FFFFFF>" ); //FFFFFF
			}

			list.Add( "<BASEFONT COLOR=#00FF00>Expires in: {0}<BASEFONT COLOR=#FFFFFF>", display ); //FFFFFF

			Timer.DelayCall( TimeSpan.FromSeconds( 1.0 ), new TimerCallback( InvalidateProperties ) );
        }

        public ToxicTrout(Serial serial) : base(serial)
        {
        	Timer.DelayCall( TimeSpan.FromHours( 12.0 ), new TimerCallback( Expire ) );
        }
        
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
            
            this.Delete();
        }
    }
}