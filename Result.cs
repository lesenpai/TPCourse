namespace TPCourse
{
	public struct Result<TData>
	{
		public bool Success;
		public TData Value;

		private Result(bool success, TData data)
		{
			Success = success;
			Value = data;
		}

		public Result<TData> Calceled()
		{
			return new Result<TData>(false, default);
		}

		public Result<TData> Successful(TData data)
		{
			return new Result<TData>(true, data);
		}
	}
}
