using Domain.Common;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Infrastructure.Extensions;

public static class EntitySeeder
{
    public static ModelBuilder SeedEntity<T>(this ModelBuilder builder)
        where T : class
    {
        var entities = typeof(T).GetFields(BindingFlags.Public | BindingFlags.Static)
            .Select(field => (T)field.GetValue(null)!)
            .ToArray();

        builder.Entity<T>().HasData(entities);
        return builder;
    }

    public static ModelBuilder SeedEntity<T>(this ModelBuilder builder, Type type)
        where T : class
    {
        var entities = type.GetFields(BindingFlags.Public | BindingFlags.Static)
            .Select(field => (T)field.GetValue(null)!)
            .ToArray();

        builder.Entity<T>().HasData(entities);
        return builder;
    }
}
