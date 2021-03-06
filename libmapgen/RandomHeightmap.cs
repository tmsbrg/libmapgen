using System;
namespace libmapgen
{
	[Serializable()]
	public class RandomHeightmap : IInitialMapGenerator
	{
		public int width { get; set; }
		public int height { get; set; }

		float min;
		float max;

		public RandomHeightmap (int width, int height, float min=0.0f, float max=1.0f)
		{
			this.width = width;
			this.height = height;
			this.min = min;
			this.max = max;
		}

		public MapArea generate ()
		{
			MapArea map = new MapArea (width, height);
			for (var y=0; y<height; y++) {
				for (var x=0; x<width; x++) {
					map.setHeightAt(x, y, RandomGenerator.generate(min, max));
				}
			}
			return map;
		}
	}
}

