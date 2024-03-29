﻿using CarvedRock.Api.Data.Entities;
using GraphQL.Types;

namespace CarvedRock.Api.GraphQL.Types
{
    public class ProductType : ObjectGraphType<Product>
    {
        public ProductType()
        {
            Field(t => t.Id);
            Field(t => t.Name);
            Field(t => t.Description);
        }
    }
}
