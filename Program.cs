using BrasilApi.Mapping;
using BrasilApi.Rest;
using BrasilApi.Services;
using IntegraBrasilApi.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<ICep , CepService>();
//builder.Services.AddSingleton<IBanks , BanksService>();
builder.Services.AddSingleton<IBrasilApi , BrasilApiRest>();

builder.Services.AddAutoMapper(typeof(CepMapping));

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
