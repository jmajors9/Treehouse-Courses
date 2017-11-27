using System;
namespace TreehouseDefense
{
	class Game
	{
		public static void Main()
		{
			Map map = new Map(8, 5);

			try
			{
				Path path = new Path(
					new [] {
						new MapLocation(0, 2, map),
						new MapLocation(1, 2, map),
						new MapLocation(2, 2, map),
						new MapLocation(3, 2, map),
						new MapLocation(4, 2, map),
						new MapLocation(5, 2, map),
						new MapLocation(6, 2, map),
						new MapLocation(7, 2, map)
					}
				);

				IInvader[] invaders =
				{
					new ResurrectingInvader(path),
					new FastInvader(path),
					new ShieldedInvader(path),
					new BasicInvader(path),
					new FastInvader(path),
					new ShieldedInvader(path),
					new StrongInvader(path),
					new BasicInvader(path),
					new ShieldedInvader(path),
					new StrongInvader(path)
				};

				// could use the console to let the user assign towers. for now we'll make permanent stuff.
				Tower[] towers = {
					new SniperTower(new MapLocation(6, 4, map)),
					new PowerTower(new MapLocation(2,3, map)),
					new SuperTower (new MapLocation(4,4, map)),
					new Tower(new MapLocation(3, 3, map)),
					new Tower(new MapLocation(3, 3, map)),
					new RangerTower(new MapLocation(7, 4, map))
				};


				Level level = new Level(invaders)
				{
					// property intialization list.
					Towers = towers
				};

				bool playerWon = level.Play();

				Console.WriteLine("Player " + (playerWon? "won" : "lost"));

			}
			catch(OutOfBoundsException ex)
			{
				Console.WriteLine(ex.Message);
			}
			catch(TreehouseDefenseException)
			{
				Console.WriteLine("Unhandled TreehouseDefense Exception");
			}
			catch(Exception ex)
			{
				Console.WriteLine("Unhandled Exception." + ex);
			}
		}
	}
}
