using System.Collections.Generic;
using haiku.Models;

namespace haiku.Providers
{
  interface IShowerProvider
  {
    IEnumerable<IShower> GetShowers();
  }
}