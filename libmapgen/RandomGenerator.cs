using System;
namespace libmapgen
{
	public sealed class RandomGenerator
	{
		static Random random = null;

		public static float generate(float min, float max)
		{
			if (random != null) {
				float n = (float)random.NextDouble();
				return min + n * (max - min);
			} else {
				random = new Random();
				return generate (min, max);
			}

		}
	}
}

