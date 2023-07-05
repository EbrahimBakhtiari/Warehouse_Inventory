using System.Globalization;                  
using Microsoft.Extensions.DependencyInjection;
using Application.IServices;
using Infrastructure.Services;
using Persistence.Repositories;
using Persistence;
using Infrastructure.IServices;
using Application.Services;
using FluentValidation;
using Application.ViewModels.UserViewModels;
using MyApp.Ui;
using Persistence.IServices;
using Persistence.Services;

namespace MyApplication
{
    internal static class Program
    {
        public static bool CheckLogin = false;

        public static string usernameid { get; set; } = string.Empty;

        public static ServiceProvider ServiceProvider { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            #region For One Language

            //CultureInfo.CurrentCulture = new CultureInfo("fa-IR", false);

            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("fa-IR");

            //Application.CurrentInputLanguage = InputLanguage
            //    .FromCulture(CultureInfo.CreateSpecificCulture("fa-IR"));

            #endregion /For One Language


            #region For Multi Language

            int CurrentCulture = MyApp.Properties.Settings.Default.CurrentCulture;

            switch ((ApplicationSettings.Languages)CurrentCulture)
            {
                case ApplicationSettings.Languages.English:
                    {
                        ApplicationSettings.CurrentCulture =
                            ApplicationSettings.Languages.English;

                        Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

                        System.Windows.Forms.Application.CurrentInputLanguage = InputLanguage
                            .FromCulture(CultureInfo.CreateSpecificCulture("en-US"));

                        break;
                    }
                case ApplicationSettings.Languages.Farsi:
                    {
                        ApplicationSettings.CurrentCulture =
                            ApplicationSettings.Languages.Farsi;

                        Thread.CurrentThread.CurrentUICulture = new CultureInfo("fa-IR");

                        System.Windows.Forms.Application.CurrentInputLanguage = InputLanguage
                            .FromCulture(CultureInfo.CreateSpecificCulture("fa-IR"));

                        break;
                    }
            }

            #endregion / For Multi Language


            // Set up DI container
            var services = new ServiceCollection();
            ConfigureServices(services);
            ServiceProvider = services.BuildServiceProvider();

            ApplicationConfiguration.Initialize();

            using (var scope = ServiceProvider.CreateScope())
            {
                var loginForm = scope.ServiceProvider.GetRequiredService<LoginForm>();
                System.Windows.Forms.Application.Run(loginForm);

                if (CheckLogin)
                {
                    var mainForm = scope.ServiceProvider.GetRequiredService<MainForm>();
                    System.Windows.Forms.Application.Run(mainForm);
                }
            }

        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddDbContext<DatabaseContext>();
            services.AddScoped<IUserCommandService, UserCommandService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IPasswordHasher, PasswordHasher>();
            services.AddTransient<IValidator<UserVMCU>, UserVMValidator>();
            services.AddTransient<IUserVMValidator, UserVMValidator>();


            // Build service provider
            ServiceProvider = services.BuildServiceProvider();

            // adding forms
            services.AddTransient<UsersForm>();
            services.AddTransient<UsersAddOrEditForm>();
            services.AddTransient<LoginForm>();
            services.AddTransient<MainForm>();
        }
    }
}