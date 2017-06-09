using System;
using haiku.Models;
using haiku.Providers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace haiku
{
  public class Startup
  {
    public static IServiceProvider ConfigureServices()
    {
      var serviceProvider = new ServiceCollection()
         .AddLogging()
         .AddTransient<IShowerProvider, ShowerProvider>()
         .AddTransient<IShower, Shower>()
         .AddSingleton<IMonkey, Monkey>()
         .BuildServiceProvider();

      serviceProvider
          .GetService<ILoggerFactory>()
          .AddConsole();

      return serviceProvider;
    }
  }
}