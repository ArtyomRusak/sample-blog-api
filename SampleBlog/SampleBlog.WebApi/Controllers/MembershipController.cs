﻿using System;
using System.Web.Http;
using System.Web.Http.Results;
using SampleBlog.BusinessContracts.Contracts;
using SampleBlog.BusinessContracts.Models;
using SampleBlog.Infrastructure.Mapping;
using SampleBlog.WebApi.Models;

namespace SampleBlog.WebApi.Controllers
{
  public class MembershipController : BaseController
  {
    private readonly IMembershipService _membershipService;
    private readonly IMapper<UserApiModel, User> _mapper;

    public MembershipController(IMembershipService membershipService, IMapper<UserApiModel, User> mapper)
    {
      _membershipService = membershipService;
      _mapper = mapper;
    }

    [Route("signup")]
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
    public IHttpActionResult SignOut(UserApiModel model)
    {
      if (this.ModelState.IsValid)
      {
        try
        {
          var logout = _membershipService.LogoutUser(model.Email);
          return this.Ok(logout);
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
  }
}