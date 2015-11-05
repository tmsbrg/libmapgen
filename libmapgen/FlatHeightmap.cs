using System;
namespace libmapgen
{
	public class FlatHeightmap : IInitialMapGenerator
	{
		int width;
		int height;

		public FlatHeightmap (int width, int height)
		{
			this.width = width;
			this.height = height;
		}

		public MapArea generate ()
		{
			return new MapArea (width, height);
		}
	}
}

