using System;
namespace libmapgen
{
	public class Tile
	{
		public int id;
		public string name;
		public float frequency;

		public Tile (int id, string name, float frequency)
		{
			this.id = id;
			this.name = name;
			this.frequency = frequency;
		}
	}
}