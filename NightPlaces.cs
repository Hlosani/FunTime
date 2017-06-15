namespace FunTime
{
	public class NightPlaces
	{
		public string Name      { get; set; }
		public string ImageUrl  { get; set; }
		public string Location { get; set; }
		public string Biography { get; set; }

		public override string ToString()
		{
			return Name + " " + Location;
		}
	}
}