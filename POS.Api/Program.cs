using POS.Application.Extensions;
using POS.Application.Validations.Category;
using POS.Infraestructure.Extensions;
using POS.Api.Extensions;
using WatchDog;
using FluentValidation;
using POS.Utilities.AppSettings;

var builder = WebApplication.CreateBuilder(args);
var Configuration = builder.Configuration;
// Add services to the container.
var Cors = "Cors";


builder.Services.AddInjectionInfraestructure(Configuration);
builder.Services.AddInjectionApplication(Configuration);
builder.Services.AddControllers();
builder.Services.AddAuthentication(Configuration);
builder.Services.AddSwagger();

builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("GoogleSettings"));



builder.Services.AddValidatorsFromAssemblyContaining<CategoryValidator>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: Cors,
        builder =>
        {
            builder.WithOrigins("*");
            builder.AllowAnyMethod();
            builder.AllowAnyHeader();
        });
});



var app = builder.Build();

app.UseCors(Cors);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//usar el watchlog
app.UseWatchDogExceptionLogger();
app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();
app.UseWatchDog(configuration =>
{
    configuration.WatchPageUsername = Configuration.GetSection("WatchDog:UserName").Value;
    configuration.WatchPagePassword = Configuration.GetSection("WatchDog:Password").Value;
});
app.Run();


public partial class Program { }

