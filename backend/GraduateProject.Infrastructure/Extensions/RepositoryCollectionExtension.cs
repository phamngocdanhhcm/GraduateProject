﻿using Microsoft.Extensions.DependencyInjection;

namespace GraduateProject.Infrastructure.Extensions;

public static class RepositoryCollectionExtension
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        return services;
    }
}