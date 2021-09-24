using System.Collections.Generic;

namespace PaintingCalculator.Domain.Entities
{
    public class Wall
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public ICollection<Door> Doors { get; set; }
        public ICollection<Window> Windows { get; set; }

    }
}
