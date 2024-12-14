//###############################################################//
//**********************ProgrammedByMustafaSalah*****************//
//###############################################################//

using E_Commerce.API.Extensions;

namespace E_Commerce.API
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

           

            
            builder.Services.AddCoreServices(builder.Configuration);
            builder.Services.AddInfrastructureServices(builder.Configuration);
            builder.Services.AddPresentationServices();
            



            var app = builder.Build();


             


            await app.SeedDbAsync();

            app.UseCustomExceptionMiddleware();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseStaticFiles();
            app.UseCors("CORSPolicy");
            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
            




        }
    }
}