using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

public class AddDescriptionForGreetingByName : IOperationFilter
{
    public void Apply(OpenApiOperation operation, OperationFilterContext context)
    {
        if (context.ApiDescription.HttpMethod.Equals("GET")
        && context.ApiDescription.RelativePath.Equals("api/Hello/hello/{name}")
        )
        {
            operation.Summary = "Приветствие с именем";
            operation.Description = "Этот метод содержит приветствие пользователя с указанием имени";
            operation.Parameters.Clear();

            operation.Parameters.Add(new OpenApiParameter
            {
                Name = "name",
                In = ParameterLocation.Path,
                Required = true,
                Description = "Имя важного человека"
            });
        }
    }
}