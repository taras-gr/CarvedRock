using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CarvedRock.Api.GraphQL
{
    public class CarvedRockSchema : Schema
    {
        public CarvedRockSchema(IServiceProvider provider)
        {
            Query = provider.GetRequiredService<CarvedRockQuery>();
        }
    }
}