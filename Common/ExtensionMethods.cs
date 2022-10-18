namespace Common
{
    public static class ExtensionMethods
	{
		public static float getValue(this ECarClass carClass)
		{
			switch(carClass)
			{
				case ECarClass.Basic:
					return 1f;

				case ECarClass.Standard:
					return 1.3f;

				case ECarClass.Medium:
					return 1.6f;

				case ECarClass.Premium:
					return 2f;
			}
			return 0;
		}
	}
}