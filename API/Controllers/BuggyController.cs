using System;
using API.DTOs;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class BuggyController : BaseApiController
{
    [HttpGet("unauthorized")]
    public IActionResult GetUnauthorized()
    {
        return Unauthorized("You are not authorized");
    }

        [HttpGet("badrequest")]
    public IActionResult GetBadRequest()
    {
        return BadRequest("This is a bad request");
    }

        [HttpGet("usernotfound")]
    public IActionResult GetNotFound()
    {
        return NotFound("User not found");
    }

        [HttpGet("internalerror")]
    public IActionResult GetInternalError()
    {
        throw new Exception("This is a test exception");
    }

        [HttpPost("validationerror")]
    public IActionResult GetValidationError(CreateProductDto product)
    {
        return Ok();
    }
}
