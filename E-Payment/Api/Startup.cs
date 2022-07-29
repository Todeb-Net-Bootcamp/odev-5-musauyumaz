using Business.Abstract;
using Business.Concrete;
using Business.Configurations.Mapper;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.EntityFramework.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //Data Access
            services.AddDbContext<PaymentDbContext>(ServiceLifetime.Transient);
            services.AddAutoMapper(config =>
            {
                config.AddProfile(new MapperProfile());
            });

            services.AddScoped<IAddressDal, EfAddressDal>();
            services.AddScoped<ICityDal, EfCityDal>();
            services.AddScoped<ICountryDal, EfCountryDal>();
            services.AddScoped<IDistrictDal, EfDistrictDal>();
            services.AddScoped<IPersonalAccountDal, EfPersonalAccountDal>();
            services.AddScoped<IUserDal, EfUserDal>();

            //Business
            services.AddScoped<IAddressService,AddressManager>();
            services.AddScoped<ICityService,CityManager>();
            services.AddScoped<ICountryService,CountryManager>();
            services.AddScoped<IDistrictService,DistrictManager>();
            services.AddScoped<IPersonalAccountService,PersonalAccountManager>();
            services.AddScoped<IUserService,UserManager>();

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Api", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
