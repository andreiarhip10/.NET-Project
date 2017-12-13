﻿using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public interface IDatabaseService
    {
        DbSet<Activity> Activities { get; set; }
        DbSet<Dashboard> Dashboards { get; set; }
        int SaveChanges();
    }
}
