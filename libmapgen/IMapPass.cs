using System;
namespace libmapgen
{
	public interface IMapPass
	{
		void call(MapArea map);
		string name();
	}
}

