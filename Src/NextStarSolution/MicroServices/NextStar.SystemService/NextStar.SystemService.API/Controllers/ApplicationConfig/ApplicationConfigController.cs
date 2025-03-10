﻿using Microsoft.AspNetCore.Mvc;
using NextStar.Library.MicroService.Exceptions;
using NextStar.Library.MicroService.Outputs;
using NextStar.SystemService.Core.Businesses.ApplicationConfig;
using NextStar.SystemService.Core.Entities.ApplicationConfig;
using NextStar.SystemService.Core.ManagementDbModels;

namespace NextStar.SystemService.API.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class ApplicationConfigController : ControllerBase
{
    private readonly ILogger<ApplicationConfigController> _logger;
    private readonly IApplicationConfigBusiness _business;

    public ApplicationConfigController(ILogger<ApplicationConfigController> logger,
        IApplicationConfigBusiness business)
    {
        _logger = logger;
        _business = business;
    }

    [HttpPost]
    public async Task<ICommonDto<PageCommonDto<ApplicationConfig>?>> GetList(ApplicationConfigSelectInput applicationConfigSelectInput)
    {
        var result = await _business.GetApplicationConfigListAsync(applicationConfigSelectInput);
        return CommonDto<PageCommonDto<ApplicationConfig>>.Ok(result);
    }

    [HttpPut]
    public async Task<ICommonDto<bool>> Update(ApplicationConfig config)
    {
        var result = await _business.UpdateApplicationConfigAsync(config);
        return CommonDto<bool>.Ok(result);
    }
}