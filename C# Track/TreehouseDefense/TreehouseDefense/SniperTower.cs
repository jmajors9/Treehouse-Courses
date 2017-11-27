namespace TreehouseDefense
{
	class SniperTower : Tower
	{
		protected override int Range { get; } = 6;
		protected override int Power { get; } = 1;
		protected override double Accuracy { get; } = .95;
		
		public SniperTower(MapLocation location) : base(location)
		{
		}
	}
}
