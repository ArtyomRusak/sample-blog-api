using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleBlog.RepositoryContracts.Models
{
  public class Entity<T> where T : struct 
  {
    public T Id { get; set; }
  }
}