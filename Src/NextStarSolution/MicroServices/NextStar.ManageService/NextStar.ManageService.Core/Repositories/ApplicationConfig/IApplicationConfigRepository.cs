﻿using System.Collections.Generic;
using System.Threading.Tasks;
using NextStar.ManageService.Core.NextStarAccountDbModels;

namespace NextStar.ManageService.Core.Repositories
{
    public interface IApplicationConfigRepository
    {
        Task<List<ApplicationConfig>> GetAllListAsync();
    }
}