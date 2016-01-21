using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleBlog.BusinessContracts.Models;
using SampleBlog.Infrastructure.Mapping;
using SampleBlog.RepositoryContracts.Models;

namespace SampleBlog.BusinessContracts.Mappers
{
  public class UserMapper : IMapper<User, UserDto>
  {
    public UserDto Map(User model)
    {
      return new UserDto();
    }

    public User Map(UserDto model)
    {
      return new User();
    }
  }
}