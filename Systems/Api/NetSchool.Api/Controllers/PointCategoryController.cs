namespace NetSchool.Api.App;

using Asp.Versioning;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NetSchool.Common.Security;
using NetSchool.Services.PointCategories;
using NetSchool.Services.Logger;
using NetSchool.Services.Authors;

[ApiController]
[Authorize]
[ApiVersion("1.0")]
[ApiExplorerSettings(GroupName = "Product")]
[Route("v{version:apiVersion}/[controller]")]
public class PointCategoryController : Controller
{
    private readonly IAppLogger logger;
    private readonly IPointCategoryService pointCategoryService;

    public PointCategoryController(IAppLogger logger, IPointCategoryService pointCategoryService)
    {
        this.logger = logger;
        this.pointCategoryService = pointCategoryService;
    }

    [HttpGet("")]
    [Authorize(AppScopes.BooksRead)]
    public async Task<IEnumerable<PointCategoryModel>> GetAll()
    {
        var result = await pointCategoryService.GetAll();

        return result;
    }
}
