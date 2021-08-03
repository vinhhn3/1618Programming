using System;

namespace GCD0904ClassesAndObjects
{
	class Monster
	{
		public string Name;
		public int HealthPoints;

		public Monster()
		{
			Name = "Default Monster Name";
			HealthPoints = 10;
		}

		public void PrintInfo()
		{
			Console.WriteLine(Name + "Health Points: " + HealthPoints);
		}
	}
}
