using System;
using Server;

namespace Server.Items
{
	[FlipableAttribute( 0x1244, 0x1243 )]
	public class CarvedMyrmydexGlyph : Artifact
	{
		public override int ArtifactRarity{ get{ return 5; } }
		[Constructable]
		public CarvedMyrmydexGlyph() : base( 4676 )
		{
			Name ="Carved Myrmydex Glyph";
			Weight = 10.00;
			Hue = 770;
		}

		public CarvedMyrmydexGlyph(Serial serial):base(serial){}
		public override void Serialize(GenericWriter writer)
		{base.Serialize(writer);writer.Write((int)0);}
		public override void Deserialize(GenericReader reader)
		{base.Deserialize(reader);int version=reader.ReadInt();}

	}
	[FlipableAttribute( 0xDF6, 0xDF7 )]
	public class DragonTurtleHatchlingNet : Artifact
	{
		public override int ArtifactRarity{ get{ return 5; } }
		[Constructable]
		public DragonTurtleHatchlingNet() : base( 3574 )
		{
			Name ="Dragon Turtle Hatchling Net";
			Weight = 10.00;
		}

		public DragonTurtleHatchlingNet(Serial serial):base(serial){}
		public override void Serialize(GenericWriter writer)
		{base.Serialize(writer);writer.Write((int)0);}
		public override void Deserialize(GenericReader reader)
		{base.Deserialize(reader);int version=reader.ReadInt();}

	}
	public class HandCarvedWhiteTigerFigurine : Artifact
	{
		public override int ArtifactRarity{ get{ return 5; } }
		[Constructable]
		public HandCarvedWhiteTigerFigurine() : base( 38980 )
		{
			Name ="Hand Carved White Tiger Figurine";
			Weight = 10.00;
			Hue = 1153;
		}

		public HandCarvedWhiteTigerFigurine(Serial serial):base(serial){}
		public override void Serialize(GenericWriter writer)
		{base.Serialize(writer);writer.Write((int)0);}
		public override void Deserialize(GenericReader reader)
		{base.Deserialize(reader);int version=reader.ReadInt();}

	}
	public class SacredLavaRock : Artifact
	{
		public override int ArtifactRarity{ get{ return 5; } }
		[Constructable]
		public SacredLavaRock() : base( 4962 )
		{
			Name ="Sacred Lava Rock";
			Weight = 10.00;
			Hue = 1194;
		}

		public SacredLavaRock(Serial serial):base(serial){}
		public override void Serialize(GenericWriter writer)
		{base.Serialize(writer);writer.Write((int)0);}
		public override void Deserialize(GenericReader reader)
		{base.Deserialize(reader);int version=reader.ReadInt();}

	}
	[FlipableAttribute( 0x106A, 0x107B )]
	public class StretchedDinosaurHide : Artifact
	{
		public override int ArtifactRarity{ get{ return 5; } }
		[Constructable]
		public StretchedDinosaurHide() : base( 4202 )
		{
			Name ="Stretched Dinosaur Hide";
			Weight = 10.00;
			Hue = 1031;
		}

		public StretchedDinosaurHide(Serial serial):base(serial){}
		public override void Serialize(GenericWriter writer)
		{base.Serialize(writer);writer.Write((int)0);}
		public override void Deserialize(GenericReader reader)
		{base.Deserialize(reader);int version=reader.ReadInt();}

	}
	[FlipableAttribute( 0x1E98, 0x1E95 )]
	public class WakuonaSpit : Artifact
	{
		public override int ArtifactRarity{ get{ return 5; } }
		[Constructable]
		public WakuonaSpit() : base( 7832 )
		{
			Name ="Waku on a Spit";
			Weight = 10.00;
		}

		public WakuonaSpit(Serial serial):base(serial){}
		public override void Serialize(GenericWriter writer)
		{base.Serialize(writer);writer.Write((int)0);}
		public override void Deserialize(GenericReader reader)
		{base.Deserialize(reader);int version=reader.ReadInt();}

	}	
}
