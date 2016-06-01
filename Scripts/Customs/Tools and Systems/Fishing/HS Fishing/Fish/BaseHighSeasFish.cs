using System;

namespace Server.Items
{
	public enum FishType
    {
		Regular,
		AutumnDragonfish,
		BullFish,
		CrystalFish,
		FairySalmon,
		FireFish,
		GiantKoi,
		GreatBarracuda,
		HolyMackerel,
		LavaFish,
		ReaperFish,
		SummerDragonfish,
		UnicornFish,
		YellowtailBarracuda,
    }
	
	public class FishTypeInfo
    {
	    private static readonly FishTypeInfo[] m_Table = new FishTypeInfo[]
        {
	    	new FishTypeInfo( typeof( RawFishSteak ) ),
	    	new FishTypeInfo( typeof( AutumnDragonfishSteak ) ),
        	new FishTypeInfo( typeof( BullFishSteak ) ),
        	new FishTypeInfo( typeof( CrystalFishSteak ) ),
        	new FishTypeInfo( typeof( FairySalmonSteak ) ),
        	new FishTypeInfo( typeof( GiantKoiSteak ) ),
        	new FishTypeInfo( typeof( GreatBarracudaSteak ) ),
        	new FishTypeInfo( typeof( HolyMackerelSteak ) ),
        	new FishTypeInfo( typeof( LavaFishSteak ) ),
        	new FishTypeInfo( typeof( ReaperFishSteak ) ),
        	new FishTypeInfo( typeof( SummerDragonfishSteak ) ),
        	new FishTypeInfo( typeof( UnicornFishSteak ) ),
        	new FishTypeInfo( typeof( YellowtailBarracudaSteak ) )
        };
        
        private readonly Type m_Resource;

        public FishTypeInfo( Type resource )
        {
            this.m_Resource = resource;
        }
        
        public Type Resource
        {
            get
            {
                return this.m_Resource;
            }
        }

        public static FishTypeInfo GetInfo (FishType type )
        {
            int v = ( int )type;

            if ( v < 0 || v >= m_Table.Length )
                v = 0;

            return m_Table[v];
        }
	}
	
    public class BaseHighSeasFish : Item, ICarvable
    {   
    	private FishType m_FishType;
    	
    	[CommandProperty(AccessLevel.GameMaster)]
        public FishType FishType
        {
            get{ return m_FishType; }
            set{ m_FishType = value; }
        }
    	
    	public BaseHighSeasFish() : this( 1 )
        {
        }

        public BaseHighSeasFish( int amount ) : base( Utility.Random( 0x09CC, 4 ) )
        {
            this.Stackable = true;
            this.Weight = 1.0;
            this.Amount = amount;
        }
        
        public BaseHighSeasFish(Serial serial) : base(serial)
        {
        }

        public void Carve(Mobile from, Item item)
        {
        	Item steaks = Activator.CreateInstance( FishTypeInfo.GetInfo(this.m_FishType).Resource ) as Item;
            base.ScissorHelper(from, steaks, 4);
            //base.ScissorHelper(from, new RawFishSteak(), 4);
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
}