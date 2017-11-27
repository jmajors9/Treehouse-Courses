namespace TreehouseDefense
{
	class RangerTower : Tower
	{
		protected override int Range { get; } = 3;

		public RangerTower(MapLocation location) : base(location)
		{
		}
	}
}
