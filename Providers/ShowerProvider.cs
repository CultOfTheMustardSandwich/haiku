using System.Collections.Generic;
using System.Linq;
using haiku.Enumerations;
using haiku.Models;
using Microsoft.Extensions.Logging;

namespace haiku.Providers
{
  public class ShowerProvider : IShowerProvider
  {
    private ILoggerFactory LoggerFactory { get; }
    public ShowerProvider(ILoggerFactory loggerFactory)
    {
      LoggerFactory = loggerFactory;
    }

    public IEnumerable<IShower> GetShowers() => new[] {
      new Shower(LoggerFactory){Temperature = Temperature.Warm},
      new Shower(LoggerFactory){Temperature = Temperature.Warm},
      new Shower(LoggerFactory){Temperature = Temperature.Cold},
      new Shower(LoggerFactory){Temperature = Temperature.Cold}
    };
  }
}