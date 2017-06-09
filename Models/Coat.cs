using haiku.Enumerations;

namespace haiku.Models
{
  public class Coat : ICoat
  {
    public Size Size { get; }
    public Material Material { get; }

    public Coat(Size size, Material material)
    {
      Size = size;
      Material = material;
    }
  }
}