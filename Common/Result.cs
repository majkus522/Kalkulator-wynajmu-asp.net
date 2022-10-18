namespace Common
{
    public class Result
	{
		public int code;
		public string content;

		public Result(int code, string content)
		{
			this.code = code;
			this.content = content;
		}
	}
}