namespace Common
{
    public static class ExtensionMethods
	{
		public static float getValue(this CarClassE carClass)
		{
			switch(carClass)
			{
				case CarClassE.Basic:
					return 1f;

				case CarClassE.Standard:
					return 1.3f;

				case CarClassE.Medium:
					return 1.6f;

				case CarClassE.Premium:
					return 2f;
			}
			return 0;
		}
	}
}