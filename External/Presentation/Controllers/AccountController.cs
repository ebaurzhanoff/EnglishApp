﻿using Application.Handlers.User;
using Application.Services;
using Application.Wrappers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace Presentation.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AccountController : ControllerBase
{
    private readonly IAccountService _accountService;

    public AccountController(IAccountService accountService)
    {
        _accountService = accountService;
    }

    [HttpGet("current-user")]
    [ProducesResponseType(typeof(UserDto), StatusCodes.Status200OK)]
    [Produces(MediaTypeNames.Application.Json)]
    public async Task<IResult> GetCurrentUser()
    {
        var user = await _accountService.GetCurrentUser();
        return TypedResults.Ok(user);
    }

    [HttpPost, AllowAnonymous]
    [Route("login")]
    [Produces(MediaTypeNames.Application.Json)]
    [ProducesResponseType(typeof(LoginResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(Result<string>), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IResult> Login(LoginRequest request)
    {
        var respone = await _accountService.LoginAsync(request);

        return respone.Succeeded ? TypedResults.Ok(respone) : TypedResults.BadRequest(respone);
    }

    [HttpPost, AllowAnonymous]
    [Route("register")]
    [Produces(MediaTypeNames.Application.Json)]
    [ProducesResponseType(typeof(LoginResponse), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(Result<string>), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IResult> Register(RegisterRequest request)
    {
        var respone = await _accountService.RegisterAsync(request);
        return respone.Succeeded ? TypedResults.Created("register", respone) : TypedResults.BadRequest(respone);
    }
}
