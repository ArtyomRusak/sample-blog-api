using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleBlog.Infrastructure.Mapping
{
  public interface IMapper<TFrom, TTo>
  {
    TTo Map(TFrom model);
    TFrom Map(TTo model);
  }
}