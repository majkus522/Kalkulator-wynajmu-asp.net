namespace Common
{
	public static class ExtensionMethods
	{
		public static float GetValue(this CarClassE carClass) =>
			carClass switch
			{
				CarClassE.Basic => 1f,
				CarClassE.Standard => 1.3f,
				CarClassE.Medium => 1.6f,
				CarClassE.Premium => 2f,
				_ => throw new ArgumentException(message: "invalid enum value", paramName: nameof(carClass)),
			};
	}
}