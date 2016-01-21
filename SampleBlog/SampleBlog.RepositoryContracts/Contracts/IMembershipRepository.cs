using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleBlog.RepositoryContracts.Models;

namespace SampleBlog.RepositoryContracts.Contracts
{
  public interface IMembershipRepository : IBaseRepository<UserDto, int>
  {
  }
}