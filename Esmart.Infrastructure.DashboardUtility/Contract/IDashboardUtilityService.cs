﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Infrastructure.DashboardUtility.Contract
{
    public interface IDashboardUtilityService
    {
        Task<string> GetTableauDashboardURL(string dashboardURL);        
    }
}
