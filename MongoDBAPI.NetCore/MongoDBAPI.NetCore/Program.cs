using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDBAPI.NetCore.Model;
using MongoDBAPI.NetCore.Repositories.IRepository;
using MongoDBAPI.NetCore.Repositories.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Configure<EducationalStoreDatabaseSettings>(builder.Configuration.GetSection(nameof(EducationalStoreDatabaseSettings)));
builder.Services.AddSingleton<IEducationalStoreDatabaseSettings>(sp => sp.GetRequiredService<IOptions<EducationalStoreDatabaseSettings>>().Value);
builder.Services.AddSingleton<IMongoClient>(s => new MongoClient(builder.Configuration.GetValue<string>("EducationalStoreDatabaseSettings:ConnectionString")));
builder.Services.AddScoped<IInspectionsRepository, InspectionsRepository>();
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
