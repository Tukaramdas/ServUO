/* Created by Hammerhand*/
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class HalloweenDecoBag : Bag
	{
		public override string DefaultName
		{
			get { return "a Halloween Decorating Kit"; }
		}

		[Constructable]
		public HalloweenDecoBag() : this( 1 )
		{
			Movable = true;
			Hue = 2114;
		}

		[Constructable]
		public HalloweenDecoBag( int amount )
		{
			DropItem(new GiantSpiderweb1AddonDeed());
            DropItem(new GiantSpiderweb2AddonDeed());
            DropItem(new SkeletonMeatEastAddonDeed());
            DropItem(new SkeletonMeatSouthAddonDeed());
            DropItem(new SkeletonBootsEastAddonDeed());
            DropItem(new SkeletonBootsSouthAddonDeed());
            DropItem(new SkeletonEastAddonDeed());
            DropItem(new SkeletonSouthAddonDeed());
            DropItem(new LayingSkeletonEastAddonDeed());
            DropItem(new LayingSkeletonSouthAddonDeed());
            DropItem(new Gravestone1EastAddonDeed());
            DropItem(new Gravestone1SouthAddonDeed());
            DropItem(new Gravestone2EastAddonDeed());
            DropItem(new Gravestone2SouthAddonDeed());
            DropItem(new Gravestone3EastAddonDeed());
            DropItem(new Gravestone3SouthAddonDeed());
            DropItem(new Gravestone4EastAddonDeed());
            DropItem(new Gravestone4SouthAddonDeed());
            DropItem(new GraveEastAddonDeed());
            DropItem(new GraveSouthAddonDeed());
            DropItem(new MaabusCoffinEastAddonDeed());
            DropItem(new MaabusCoffinSouthAddonDeed());
            DropItem(new BlockEastAddonDeed());
            DropItem(new BlockSouthAddonDeed());
            DropItem(new EggCaseWebAddonDeed());
            DropItem(new GuillotineEastAddonDeed());
            DropItem(new GuillotineSouthAddonDeed());
            DropItem(new PilloryEastAddonDeed());
            DropItem(new PillorySouthAddonDeed());
            DropItem(new RackEastAddonDeed());
            DropItem(new RackSouthAddonDeed());
            DropItem(new ShacklesAddonDeed());
            DropItem(new SmallWeb1AddonDeed());
            DropItem(new SmallWeb2AddonDeed());
            DropItem(new SmallWeb3AddonDeed());
            DropItem(new SmallWeb4AddonDeed());
            DropItem(new SmallWeb5AddonDeed());
            DropItem(new SmallWeb6AddonDeed());
            DropItem(new WebCocoonAddonDeed());
            DropItem(new WrappedBodyEastAddonDeed());
            DropItem(new WrappedBodySouthAddonDeed());
            DropItem(new BloodyTorsoSouthAddonDeed());
            DropItem(new BloodyTorsoEastAddonDeed());
            DropItem(new OgreCorpseAddonDeed());
            DropItem(new OrcCaptainCorpseAddonDeed());
		}

        public HalloweenDecoBag(Serial serial)
            : base(serial)
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