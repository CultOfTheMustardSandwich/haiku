using System.Collections.Generic;
using haiku.Enumerations;
using Microsoft.Extensions.Logging;

namespace haiku.Models
{
  public class Shower : IShower
  {
    private ILogger Logger { get; }
    public Temperature Temperature { get; set; }

    public Shower(ILoggerFactory loggerFactory)
    {
      Logger = loggerFactory.CreateLogger("Shower");
    }

    public void Start(IEnumerable<IResident> residents)
    {
      Logger.LogInformation($"A {Temperature.ToString().ToLower()} shower has begun.");

      foreach (var resident in residents)
      {
          resident.GetWet(Temperature);
      }
    }
  }
}