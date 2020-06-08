using System;

namespace TPCourse.Source.Types
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

		public Result(bool success, TValue value)
		{
			Success = success;
			Value = value;
		}

		public static Result<TValue> False()
		{
			return new Result<TValue>(false, default);
		}

		public static Result<TValue> False(TValue value)
		{
			return new Result<TValue>(false, value);
		}

		public static Result<TValue> True()
		{
			return new Result<TValue>(true, default);
		}

		public static Result<TValue> True(TValue value)
		{
			return new Result<TValue>(true, value);
		}
	}
}
