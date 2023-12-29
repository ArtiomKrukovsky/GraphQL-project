using backend_.net6.GraphQL.Queries;
using backend_.net6.GraphQL.Schemas;
using backend_.net6.GraphQL.Types;
using backend_.net6.Providers;
using backend_.net6.Providers.Interfaces;
using GraphQL.Server;
using GraphQL.Types;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(c =>
{
    c.AddPolicy("Policy", policy =>
    {
        policy.AllowAnyOrigin()
         .AllowAnyHeader()
         .AllowAnyMethod();
    });
});

builder.Services.AddScoped<IProductProvider, ProductProvider>();

builder.Services.AddScoped<ISchema, ProductSchema>();
builder.Services.AddScoped<ProductType>();
builder.Services.AddScoped<ProductQuery>();
builder.Services.AddGraphQL(option => option.EnableMetrics = false).AddSystemTextJson();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("Policy");
app.UseHttpsRedirection();

app.UseAuthorization();
app.MapControllers();

app.UseGraphQLAltair();
app.UseGraphQL<ISchema>();

app.Run();
