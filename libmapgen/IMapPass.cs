using System.Collections.Generic;
namespace libmapgen
{
	public interface IMapPass
	{
		Dictionary<string, System.Type> getSettings();
		void setSetting(string setting, object value);
		void call(MapArea map);
	}
}