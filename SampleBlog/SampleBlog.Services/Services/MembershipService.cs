using System;
using SampleBlog.BusinessContracts.Contracts;
using SampleBlog.BusinessContracts.Mappers;
using SampleBlog.BusinessContracts.Models;
using SampleBlog.RepositoryContracts;
using SampleBlog.RepositoryContracts.Exceptions;
using SampleBlog.RepositoryContracts.Models;

namespace SampleBlog.Services.Services
{
  public class MembershipService : BaseService, IMembershipService
  {
    public MembershipService(IRepositoryFactory repositoryFactory)
      : base(repositoryFactory)
    {
    }

    public bool VerifyUser(int userId)
    {
      throw new System.NotImplementedException();
    }

    public User RegisterUser(User user)
    {
      try
      {
        var check = this.VerifyUser(user.Id);
        if (check == false)
        {
          var membershipRepository = this.RepositoryFactory.GetMembershipRepository();
          var userMapper = new UserMapper();

          var userDto = userMapper.Map(user);
          var registeredUser = membershipRepository.CreateEntity(userDto);

          if (registeredUser != null)
          {
            var result = userMapper.Map(registeredUser);
            return result;
          }
          else
          {
            return null;
          }
        }
      }
      catch (Exception e)
      {
        throw new UserException(string.Empty, e);
      }

      return null;
    }

    public User RegisterUser(string email, string password)
    {
      throw new System.NotImplementedException();
    }

    public bool LoginUser(string email, string password)
    {
      throw new System.NotImplementedException();
    }

    public bool LogoutUser(string email)
    {
      throw new NotImplementedException();
    }

    public User GetUser(int userId)
    {
      throw new System.NotImplementedException();
    }
  }
}