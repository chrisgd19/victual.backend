using Serilog;
using Victual.Backend.Api.Services;
using Victual.Backend.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
IConfiguration configuration = builder.Configuration;

builder.Logging.ClearProviders();
builder.Host.UseSerilog((_, loggerConfiguration) => loggerConfiguration.WriteTo.Console());

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddServices();
builder.Services.AddInfrastructure(configuration.Get<InfrastructureConfiguration>());

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors(config => config.AllowAnyOrigin());
app.UseSwagger();
app.UseSwaggerUI();
app.UseAuthorization();
app.MapControllers();

app.Run();