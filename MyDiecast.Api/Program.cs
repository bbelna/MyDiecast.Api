using Microsoft.AspNetCore.Diagnostics;
using MyDiecast.Api.Models;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment()) {
  app.UseSwagger();
  app.UseSwaggerUI();
}

app.UseExceptionHandler(errorApp => {
  errorApp.Run(async context => {
    context.Response.StatusCode = 500;
    context.Response.ContentType = "application/json";

    var error = context.Features.Get<IExceptionHandlerFeature>();
    if (error != null) {
      var ex = error.Error;
      await context.Response.WriteAsync(new ErrorDto() {
        Message = ex.Message,
      }.ToString() ?? "", Encoding.UTF8);
    }
  });
});

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
