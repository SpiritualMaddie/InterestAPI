global using System.ComponentModel.DataAnnotations;
global using InterestAPI.Models.ConnectionTables;
global using InterestAPI.Models;
global using Microsoft.EntityFrameworkCore;
global using InterestAPI.Services.IServices;
global using Microsoft.AspNetCore.Mvc;
global using InterestAPI.Data;
global using InterestAPI.Models.DTO;
global using InterestAPI.Services;

namespace InterestAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<IServices<Person>, PersonService>();
            builder.Services.AddScoped<IServices<InterestList>, InterestListService>();
            builder.Services.AddScoped<IInterestListService, InterestListService>();
            builder.Services.AddScoped<IInterestLinkService, InterestLinkService>();
            builder.Services.AddDbContext<ApplicationDbContext>();

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
        }
    }
}