using Microsoft.OpenApi.Models;
using Step.Lib;
using Step.Lib.Middlewares.Swagger;
using System.Reflection;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers()
    .AddJsonOptions(opt =>
    {
        // В JSON, и в Swagger будет string.
        opt.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    });

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "02 ПКП.КП service API",
        Version = "v1",
        Description = "ПКП.КП"
    });

    options.SupportNonNullableReferenceTypes();
    options.UseAllOfToExtendReferenceSchemas();
    options.SchemaFilter<RequireNonNullablePropertiesSchemaFilter>();

    // Подключаем XML-документацию
    var baseDirectory = AppContext.BaseDirectory;

    // XML текущей сборки
    var mainXmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(baseDirectory, mainXmlFile), includeControllerXmlComments: true);

    // XML из других сборок
    var externalAssembly = typeof(LibMarker).Assembly;
    var externalXmlFile = $"{externalAssembly.GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(baseDirectory, externalXmlFile), true);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.Run();
