using System.Reflection;
using EventPlus.Context;
using EventPlus.Interfaces;
using EventPlus.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Configura��o de servi�os
builder.Services
    .AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;
        options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
    });

// Configura��o do banco de dados
builder.Services.AddDbContext<EventContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Inje��o de depend�ncia dos reposit�rios

builder.Services.AddScoped<ITiposEventosRepository, TipoEventoRepository>();
//builder.Services.AddScoped<ITipoUsuarioRepository, TipoUsuarioRepository>();


//Adiciona o servi�o de Controllers
builder.Services.AddControllers();


var app = builder.Build();

app.MapControllers();

app.Run();