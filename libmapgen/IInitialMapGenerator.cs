using System;
namespace libmapgen
{
	public interface IInitialMapGenerator
	{
		MapArea generate();
		int width { get; set; }
		int height { get; set; }
	}
}

