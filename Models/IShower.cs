using System.Collections.Generic;
using haiku.Enumerations;

namespace haiku.Models
{
  public interface IShower
  {
    Temperature Temperature { get; }
    void Start(IEnumerable<IResident> residents);
  }
}