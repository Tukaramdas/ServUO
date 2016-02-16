using System;
using Server;
using Server.Items;
using Server.Mobiles;
using Server.Network; 
using System.Collections;

namespace Server.Items
{
	public class MaginciaInvasionStone : Item
	{
		[Constructable]
		public MaginciaInvasionStone() : base( 0xED4 )
		{
			Movable = false;
			Hue = 33;
			Name = "a magincia invasion stone";
		}
		public virtual void CleanUpSpawns( string spawnername )
		{
			if ( spawnername == "Spawner" )
			{
				Console.WriteLine( "Warning: Army Spawner did not clean up spawns due to name to delete was Spawner." );
				return;
			}

			ArrayList spawns = new ArrayList( World.Items.Values );
			foreach( Item item in spawns )
			{
				if( (item is Spawner ) && (((Spawner )item).Name == spawnername) )
				{
					item.Delete();
				}
			}
		}
		public virtual void CleanUpWayPoints( string waypointname )
		{
			if ( waypointname == "WayPoint" )
			{
				Console.WriteLine( "Warning: Army Spawner did not clean up waypoints due to name to delete was WayPoint." );
				return;
			}

			ArrayList waypoints = new ArrayList( World.Items.Values );
			foreach( Item item in waypoints )
			{
				if( (item is WayPoint ) && (((WayPoint )item).Name == waypointname) )
				{
					item.Delete();
				}
			}
		}
		public virtual void CleanUpMaginciaFelucca()
		{
			CleanUpSpawns( "MaginciaInvasionFelucca" );
			CleanUpWayPoints( "MaginciaInvasionFelucca" );

		}
		public virtual void StopMaginciaFelucca()
		{
			ArrayList maginciafel = new ArrayList( World.Items.Values );
			foreach( Item item in maginciafel )

			{
				if( item is MaginciaInvasionStone )
				{
					((MaginciaInvasionStone)item).CleanUpMaginciaFelucca();
				}
			}
		}
		public virtual void CleanUpMaginciaTrammel()
		{
			CleanUpSpawns( "MaginciaInvasionTrammel" );
			CleanUpWayPoints( "MaginciaInvasionTrammel" );

		}
		public virtual void StopMaginciaTrammel()
		{
			ArrayList maginciatram = new ArrayList( World.Items.Values );
			foreach( Item item in maginciatram )

			{
				if( item is MaginciaInvasionStone )
				{
					((MaginciaInvasionStone)item).CleanUpMaginciaTrammel();
				}
			}
		}
		public MaginciaInvasionStone( Serial serial ) : base( serial )
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

		public override void OnDoubleClick( Mobile from )
		{
                                         from.SendMessage( "Magincia is being invaded" );
		}
	}
}