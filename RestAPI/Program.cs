using Business;
using DAL.EF;
using DAL.Repositories;

namespace CharacterGenaration
{
    /** 
     * Класс, с которого всё началось
     */
    public class Program
    {
        /** 
         * Точка входа в программу
         */
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            // Add services to DI
            AddDependency(builder);

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            UpdateDatabase(); 

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
        private static void UpdateDatabase()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();

                db.SaveChanges();
            }
        }

        private static void AddDependency(WebApplicationBuilder builder)
        {
            builder.Services.AddDbContext<ApplicationContext>();
            builder.Services.AddTransient<RaceRepository>();
            builder.Services.AddTransient<BackgroundRepository>();
            builder.Services.AddTransient<AbilityRepository>();
            builder.Services.AddTransient<CharacterRepository>();
            builder.Services.AddTransient<StatsRepository>();
            builder.Services.AddTransient<SkillsRepository>();
            builder.Services.AddTransient<SavingThrowsRepository>();
            builder.Services.AddTransient<MoralPositionRepository>();
            builder.Services.AddTransient<CharacterClassRepository>();

            builder.Services.AddTransient<RaceManager>();
        }
    }

}
