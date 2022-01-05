﻿using Microsoft.EntityFrameworkCore;

namespace GraduateProject.Infrastructure;

public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

}