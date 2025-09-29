using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Step.Lib.Middlewares.Swagger;

/// <summary>
/// Фильтр, предназначен чтобы автоматически пометить в Swagger все не-nullable свойства моделей как required, 
/// без необходимости вручную добавлять [Required].
/// </summary>
public class RequireNonNullablePropertiesSchemaFilter : ISchemaFilter
{
    public void Apply(OpenApiSchema schema, SchemaFilterContext context)
    {
        if (schema.Properties is null) return;

        var nonNullableProperties = schema.Properties
            .Where(x => !x.Value.Nullable)
            .Select(x => x.Key);

        // If property isn't explicitly declared as nullable, it is assumed to be required.
        foreach (var property in nonNullableProperties)
        {
            schema.Required.Add(property);
        }
    }
}