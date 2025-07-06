using TransferRoomAssignment.Server.Repositories;
using TransferRoomAssignment.Server.Services;

namespace TransferRoomAssignment.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddHttpClient<ISquadService, SquadService>(
                client =>
                {
                    client.BaseAddress = new Uri(builder.Configuration.GetValue<string>("ApiSports:Url"));
                    client.DefaultRequestHeaders.Add(builder.Configuration.GetValue<string>("ApiSports:KeyHeaderName"), builder.Configuration.GetValue<string>("ApiSports:Key"));
                });
            builder.Services.AddTransient<ITeamRepository, TeamRepository>();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            app.UseDefaultFiles();
            app.UseStaticFiles();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();


            app.MapControllers();

            app.MapFallbackToFile("/index.html");

            app.Run();
        }
    }
}
