using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCourse.Source.Types
{
	public interface IResult<T>
	{
		Result<T> @Result { get; set; }
	}
}
