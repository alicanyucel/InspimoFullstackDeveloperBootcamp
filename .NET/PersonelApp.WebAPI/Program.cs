using PersonelApp.WebAPI.Utilities;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddUI();

builder.Services.AddDependencyInjection();

builder.Host.AddLog(builder.Configuration);


var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseCors(x => x.AllowAnyOrigin());

app.MapControllers();

app.UseExceptionHandler();

app.Run();
