using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;
using  ASSESSMENT_2_GROCERRY
;

namespace PRICE_QUOTAION
{
    public class Program
    {
        public static object options { get; private set; }

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();

            builder.Services.AddDbContext<Pricetags>(options =>
            {
                options.UseSqlServer("Server=NDUSHI\\MSSQLSERVER01;Database=PricetagsDB;Trusted_Connection=True;");


            });


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}
