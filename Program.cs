using Esercizio2.DataAccess;
using Esercizio2.Model;
using Esercizio2.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Configure<MagazzinoDatabaseSettings>(
builder.Configuration.GetSection("MagazzinoDatabaseSettings"));


builder.Services.AddScoped<ICategoriaServices, CategoriaService>();
builder.Services.AddScoped<MagazzinoDatabaseSettings, MagazzinoDatabaseSettings>();
builder.Services.AddScoped<IMagazzinoContext, MagazzinoContext>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
