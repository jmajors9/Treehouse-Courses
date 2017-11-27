namespace TreehouseDefense
{
	class SuperTower : Tower
	{
		protected override int Range { get; } = 2;
		protected override int Power { get; } = 2;
		protected override double Accuracy { get; } = .85;

		public SuperTower(MapLocation location) : base(location)
		{
		}
	}
}
