using ApiTemplate.Api.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddServices();

var app = builder.Build();

app.UseDeveloperExceptionPage();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();