using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleBlog.RepositoryContracts.Contracts;

namespace SampleBlog.RepositoryContracts
{
  public interface IRepositoryFactory
  {
    IMembershipRepository GetMembershipRepository();
  }
}
