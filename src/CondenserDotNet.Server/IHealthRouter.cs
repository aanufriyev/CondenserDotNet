﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace CondenserDotNet.Server
{
    public interface IHealthRouter
    {
        string Route { get; }
        Task CheckHealth(HttpContext context);
    }
}