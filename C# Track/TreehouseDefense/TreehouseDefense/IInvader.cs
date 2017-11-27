namespace TreehouseDefense
{

	interface IMappable
	{
		MapLocation Location { get; }
	}

	interface IMovable
	{
		void Move();
	}

	interface IInvader : IMovable, IMappable
	{
		bool HasScored { get; }

		int Health { get; }

		bool IsNeutralized { get; }

		bool IsActive { get; }

		void DecreaseHealth(int factor);
	}
}
