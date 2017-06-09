using haiku.Enumerations;

namespace haiku.Models
{
  public interface ICoat
  {
    Size Size { get; }
    Material Material { get; }
  }
}