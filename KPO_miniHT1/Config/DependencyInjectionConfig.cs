using Project.Abstractions.Interfaces;
using Project.Realisation.AnimalTypes;
using Project.Realisation.Buildings;
using Project.Realisation.Inventory;
using Project.Realisation.Storages;
using Microsoft.Extensions.DependencyInjection;
using System;
using Project.Realisation.Factories;
using Project.LogicManager;
namespace Project.Config
{
    public static class DependencyInjectionConfig
    {
        public static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            var clinic = new Clinic();

            var zoo = new Zoo(clinic);

            // Register Animals (Transient - new instance each time)
            services.AddTransient<Monkey>();
            services.AddTransient<Tiger>();
            services.AddTransient<Rabbit>();
            services.AddTransient<Wolf>();

            //Register Storages
            services.AddTransient<IAnimalStorage, AnimalStorage>();
            services.AddTransient<IInventoryStorage, InventoryStorage>();

            //Register Factory
            services.AddTransient<RabbitFactory>();
            services.AddTransient<WolfFactory>();
            services.AddTransient<TigerFactory>();
            services.AddTransient<MonkeyFactory>();

            // Register Zoo and Clinic
            services.AddSingleton<Zoo>(zoo);
            services.AddTransient<IClinic, Clinic>();

            //Inventory - Register Inventory Types
            services.AddTransient<IInventory, Computer>();
            services.AddTransient<IInventory, Table>();

            // Register Menu and Writer
            services.AddSingleton<Menu>();
            services.AddSingleton<Writer>();
            services.AddSingleton<Reader>();

            return services.BuildServiceProvider();
        }
    }
}