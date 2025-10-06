using Microsoft.OpenApi.Models;
using Step.Lib;
using Step.Lib.Middlewares.Swagger;
using System.Reflection;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
    .AddJsonOptions(opt =>
    {
        // � JSON, � � Swagger ����� string.
        opt.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    });
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "GIR service API",
        Version = "v1",
        Description = "������ �������-����������������� ����� (���)."
    });

    options.SupportNonNullableReferenceTypes();
    options.UseAllOfToExtendReferenceSchemas();
    options.SchemaFilter<RequireNonNullablePropertiesSchemaFilter>();

    // ���������� XML-������������
    var baseDirectory = AppContext.BaseDirectory;

    // XML ������� ������
    var mainXmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(baseDirectory, mainXmlFile), includeControllerXmlComments: true);

    // XML �� ������ ������
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
