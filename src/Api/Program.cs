using Api.DI;
using Api.Filters;
using Api.Infra;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer(); // necessário para Swagger funcionar
builder.Services.AddSwaggerGen();

builder.Services.AddControllers(options =>
{
    options.Filters.Add(typeof(ExceptionGlobalFilter));
});

builder.Services.AddDI(builder.Configuration);

var app = builder.Build();

app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Autenticador v1");
    c.RoutePrefix = string.Empty;
});

if (app.Environment.IsDevelopment() || app.Environment.IsEnvironment("Docker"))
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

if (!app.Environment.IsDevelopment() && !app.Environment.IsEnvironment("Docker"))
{
    app.UseHttpsRedirection();
}

app.UseAuthorization();

app.MapControllers();

Migrate();

app.Run();

void Migrate()
{
    var serviceScope = app.Services.GetRequiredService<IServiceScopeFactory>().CreateScope();
 
    DatabaseMigration.MigrateDatabase(serviceScope.ServiceProvider);
}