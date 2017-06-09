using System;
using haiku.Enumerations;
using Microsoft.Extensions.Logging;

namespace haiku.Models
{
  public class Monkey : IMonkey, IResident
  {
    private Temperature temperature;
    private ILogger Logger { get; }
    private Temperature Temperature
    {
      set
      {
        var gettingCold = value == Temperature.Cold;
        var iAmCold = temperature == Temperature.Cold;

        if (gettingCold && !iAmCold)
        {
          var coat = new Coat(Size.Little, Material.Straw);

          Want(coat);
        }

        temperature = value;
      }
    }

    public Monkey(ILoggerFactory loggerFactory)
    {
      Logger = loggerFactory.CreateLogger("Monkey");
    }

    private void Want(ICoat coat)
    {
      Logger.LogInformation($"I want a {coat.Size.ToString().ToLower()} coat of {coat.Material.ToString().ToLower()}.");
    }

    public void GetWet(Temperature temperature)
    {
      Temperature = temperature;
    }
  }
}