using Stu_reg_API.Models;
using Newtonsoft.Json.Serialization;

namespace DemoApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            builder.Services.AddEndpointsApiExplorer();
            /*            builder.Services.AddSwaggerGen();*/
            builder.Services.AddSwaggerGen();


            builder.Services.AddDbContext<StudentRegistaionContext>(options =>
            {

            });

            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(builder =>
                {
                    builder
                        .AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader();
                });

            });



            builder.Services.AddControllersWithViews()
             .AddNewtonsoftJson(options =>
             options.SerializerSettings.ReferenceLoopHandling = Newtonsoft
             .Json.ReferenceLoopHandling.Ignore)
             .AddNewtonsoftJson(options => options.SerializerSettings.ContractResolver
             = new DefaultContractResolver());

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseCors();


            app.MapControllers();

            app.Run();
        }
    }
}
