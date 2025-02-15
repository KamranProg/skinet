using System;
using API.RequestHelpers;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BaseApiController: ControllerBase
{
    protected async Task<ActionResult> CreatePageResult<T>(IGenericRepository<T> repo, ISpecification<T> spec, int pageIndex, int PageSize) where T : BaseEntity
    {
        var items = await repo.ListAsync(spec);
        var count = await repo.CountAsync(spec);
        var pagination = new Pagination<T>(pageIndex, PageSize, count, items);
        return Ok(pagination);
    }
}

