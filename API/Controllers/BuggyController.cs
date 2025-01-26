using System;
using API.DTOs;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class BuggyController: BaseApiController
{
    [HttpGet("unautorized")]
    public ActionResult GetUnautorized()
    {
        return Unauthorized();
    }

    [HttpGet("badrequest")]
    public ActionResult GetBadRequest()
    {
        return BadRequest("Not a good request");
    }  
    
    [HttpGet("notfound")]
    public ActionResult GetNotFound()
    {
        return NotFound();
    }  

    [HttpGet("internalerror")]
    public ActionResult GetInternalError()
    {
        throw new Exception("This is a test Exception");
    }

    [HttpPost("validationerror")]
    public ActionResult GetValidationError(CreateProductDto product)
    {
       return Ok();
    }     
}
