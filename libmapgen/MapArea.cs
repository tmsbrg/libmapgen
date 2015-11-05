using System;
namespace libmapgen
{
	public class MapArea
	{
        float[][] _heightmap;
		int[][] _tilemap;
		Tile[] _tileTypes;

		public int width
		{
			get
			{
				if (height > 0) {
					return _heightmap[0].Length;
				} else {
					return 0;
				}
			}
		}

		public int height
		{
			get
			{
				return _heightmap.Length;
			}
		}

		public MapArea (int width, int height)
		{
            _heightmap = new float[height][];
			_tilemap= new int[height][];
            for (var y = 0; y < height; y++) {
                _heightmap[y] = new float[width];
				_tilemap[y] = new int[width];
            }
		}

		// gives an error if x < 0 || x >= width || y < 0 || y >= height
		public float getHeightAt(int x, int y)
		{
			return _heightmap[y][x];
		}

		// gives an error if x < 0 || x >= width || y < 0 || y >= height
		public int getTileAt(int x, int y)
		{
			return _tilemap[y][x];
		}

		// gives an error if x < 0 || x >= width || y < 0 || y >= height
		public void setHeightAt(int x, int y, float value)
		{
			_heightmap[y][x] = value;
		}
		
		// gives an error if x < 0 || x >= width || y < 0 || y >= height
		public void setTileAt(int x, int y, int value)
		{
			_tilemap[y][x] = value;
		}

		public Tile getTileType(int id)
		{
			return _tileTypes[id];
		}

		public void setTileTypes(Tile[] tileTypes)
		{
			_tileTypes = tileTypes;
		}

		public float tileFrequencySum()
		{
			float sum = 0;
			foreach (var tile in _tileTypes)
			{
				sum += tile.frequency;
			}
			return sum;
		}
	}
}