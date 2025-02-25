using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsDI.Services.MyService;

namespace WindowsFormsDI
{
    static class Program
    {
        private static IServiceProvider serviceProvider;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Config DI
            var services = new ServiceCollection();
            ConfigureServices(services);
            serviceProvider = services.BuildServiceProvider();

            // Get main form to run application.
            var mainForm = serviceProvider.GetRequiredService<MainForm>();
            Application.Run(mainForm);
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            // Regis form
            services.AddTransient<MainForm>();
            services.AddTransient<ChildForm>();
            services.AddTransient<TabContainerForm>();

            // Regis service
            services.AddScoped<IMyService, MyService>();
        }
    }
}