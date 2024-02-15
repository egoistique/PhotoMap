namespace NetSchool.Services.PointCategories;

using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NetSchool.Context;
using System.Collections.Generic;
using System.Threading.Tasks;

public class PointCategoryService : IPointCategoryService
{
    private readonly IDbContextFactory<MainDbContext> dbContextFactory;
    private readonly IMapper mapper;

    public PointCategoryService(IDbContextFactory<MainDbContext> dbContextFactory,
        IMapper mapper
        )
    {
        this.dbContextFactory = dbContextFactory;
        this.mapper = mapper;
    }

    public async Task<IEnumerable<PointCategoryModel>> GetAll()
    {
        using var context = await dbContextFactory.CreateDbContextAsync();

        var pointCategory = await context.PointCategories            
            .ToListAsync();

        var result = mapper.Map<IEnumerable<PointCategoryModel>>(pointCategory);

        return result;
    }
}
