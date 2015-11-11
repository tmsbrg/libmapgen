using System;
namespace libmapgen
{
	[Serializable()]
	public class FlatHeightmap : IInitialMapGenerator
	{
		public int width { get; set; }
		public int height { get; set; }

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

