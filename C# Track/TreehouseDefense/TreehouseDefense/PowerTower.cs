namespace TreehouseDefense
{
	class PowerTower : Tower
	{
		
		protected override int Power { get; } = 3;
		protected override double Accuracy { get; } = .5;

		public PowerTower(MapLocation location) : base(location)
		{
			
		}
	}
}
