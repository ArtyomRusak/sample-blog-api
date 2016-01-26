using System;
using System.Web.Http;
using System.Web.Http.Results;
using SampleBlog.Infrastructure.Mapping;
using SampleBlog.ServiceContracts.Contracts;
using SampleBlog.ServiceContracts.Models;
using SampleBlog.WebApi.Models;

namespace SampleBlog.WebApi.Controllers
{
  public class MembershipController : BaseController
  {
    private const string SomethingWentWrong = "Something went wrong";
    private readonly IMembershipService _membershipService;
    private readonly IMapper<UserApiModel, User> _mapper;

    public MembershipController(IMembershipService membershipService, IMapper<UserApiModel, User> mapper)
    {
      _membershipService = membershipService;
      _mapper = mapper;
    }

    [Route("signup")]
    [HttpPost]
    public IHttpActionResult SignUp(UserApiModel user)
    {
      //validation: IValidatableObject, attribute validation
      if (this.ModelState.IsValid)
      {
        try
        {
          var mappedUser = _mapper.Map(user);
          var registeredUser = _membershipService.RegisterUser(mappedUser);
          return this.Ok(registeredUser);
        }
        catch (Exception e)
        {
          return this.BadRequest();
        }
      }
      else
      {
        return this.BadRequest(this.ModelState);
      }
    }

    [Route("signin")]
    [HttpPost]
    public IHttpActionResult SingIn(UserApiModel model)
    {
      if (this.ModelState.IsValid)
      {
        try
        {
          var login = _membershipService.LoginUser(model.Email, model.Password);
          return this.Ok(login);
        }
        catch (Exception e)
        {
          return this.BadRequest();
        }
      }
      else
      {
        return this.BadRequest(this.ModelState);
      }
    }

    [Route("signout")]
    [HttpPost]
    public IHttpActionResult SignOut(UserApiModel model)
    {
      if (!this.ModelState.IsValid)
      {
        return this.BadRequest(this.ModelState);
      }

      var logout = _membershipService.LogoutUser(model.Email);
      return this.Ok(logout);
    }

    [Route("user")]
    [HttpGet]
    public IHttpActionResult GetUser(int id)
    {
      if (this.ModelState.IsValid)
      {
        try
        {
          var user = _membershipService.GetUser(id);
          return this.Ok(user);
        }
        catch (Exception e)
        {
          return this.BadRequest(MembershipController.SomethingWentWrong);
        }
      }
      else
      {
        return this.BadRequest(this.ModelState);
      }
    }
  }
}