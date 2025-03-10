﻿using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using NextStar.SystemService.Core.DbContexts;

namespace NextStar.SystemService.Core.Repositories.ApplicationConfig;

public class ApplicationConfigRepository:IApplicationConfigRepository
{
    private readonly ManagementDbContext _managementDbContext;
    public ApplicationConfigRepository(ManagementDbContext managementDbContext)
    {
        _managementDbContext = managementDbContext;
    }

    public IQueryable<ManagementDbModels.ApplicationConfig> GetAllQuery(string searchText,Expression<Func<ManagementDbModels.ApplicationConfig,bool>> predicate)
    {
        if (!string.IsNullOrWhiteSpace(searchText))
        {
            return _managementDbContext.ApplicationConfigs.Where(predicate).AsNoTracking();
        }
        return _managementDbContext.ApplicationConfigs.AsNoTracking();
    }

    public async Task UpdateAsync(string name, string value)
    {
        var config = await _managementDbContext.ApplicationConfigs.FirstOrDefaultAsync(x => x.Name == name);
        if(config == null)
            return;
        config.Value = value;
        _managementDbContext.ApplicationConfigs.Update(config);
        await _managementDbContext.SaveChangesAsync();
    }
}