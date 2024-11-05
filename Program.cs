// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);
    builder.Services.AddControllers();    
    builder.Services.AddEndpointsApiExplorer();    
    builder.Services.AddSwaggerGen();
    builder.Services.AddSwaggerGen(c => {c.SwaggerDoc("v1", new OpenApiInfo { Title = "Gestão De Livraria", Version = "v1" });});

var app = builder.Build();
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }
    app.UseHttpsRedirection();
    app.UseAuthorization();
    app.MapControllers();
    app.Run();
