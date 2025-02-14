using Microsoft.Extensions.DependencyInjection;
using Project.Config;
using Project.LogicManager;
using Project.Realisation.AnimalTypes;
using Project.Realisation.Buildings;

public class Program
{
    public static void Main()
    {
        var serviceProvider = DependencyInjectionConfig.ConfigureServices();

        Menu menu = serviceProvider.GetService<Menu>();
    
        menu.Start();
    }
}