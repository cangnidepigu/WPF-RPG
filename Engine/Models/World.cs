using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class World
    {
        private List<Location> _location = new List<Location>();

        internal void AddLocation(int xCoordinate, int yCoordinate, string name,
            string description, string imageName)
        {
            _location.Add(new Location(xCoordinate, yCoordinate, name, description,
                $"pack://application:,,,/Engine;component/Images/Locations/{imageName}"));
        }

        public Location LocationAt(int xCoordinate, int yCoordinate)
        {
            foreach (Location loc in _location)
            {
                if(loc.XCoordinate == xCoordinate && loc.YCoordinate == yCoordinate)
                {
                    return loc;
                }
            }

            return null;
        }
    }
}
