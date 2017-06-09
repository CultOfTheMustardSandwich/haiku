using System.Linq;
using haiku.Enumerations;
using haiku.Providers;
using haiku.Models;
using Microsoft.Extensions.DependencyInjection;

namespace haiku
{
  class Program
  {
    static void Main(string[] args)
    {
      var services = Startup.ConfigureServices();

      var showerProveder = services.GetService<IShowerProvider>();
      var monkey = services.GetService<IMonkey>();
      var showers = showerProveder.GetShowers();

      foreach (var shower in showers)
      {
        var residents = new[] { (IResident)monkey };

        shower.Start(residents);
      }
    }
  }
}