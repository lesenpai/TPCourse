namespace TPCourse
{
	public class Result<TValue>
	{
		public bool Success;
		public TValue Value;

		public Result(TValue value)
		{
			Success = false;
			Value = value;
		}

		public Result<TValue> Calceled()
		{
			Success = false;
			return this;
		}

		public Result<TValue> Successful(TValue value)
		{
			return new Result<TValue>(true, value);
		}

		public Result<TValue> Successful()
		{
			Success = true;
			return this;
		}

		private Result(bool success, TValue value)
		{
			Success = success;
			Value = value;
		}
	}
}
