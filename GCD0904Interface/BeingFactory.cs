namespace GCD0904Interface
{
	public class BeingFactory
	{
		public static IBeing GetBeing(string type)
		{
			if (type.Equals("Human"))
			{
				return new Human();
			}
			else
			{
				return new Animal();
			}
		}
	}
}
