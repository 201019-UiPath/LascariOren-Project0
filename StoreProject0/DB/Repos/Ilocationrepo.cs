using DB.Models;
using System.Collections.Generic;
namespace DB.Repos
{
    public interface Ilocationrepo
    {
        void AddLocation(Location location);
        List<Location> GetAllLocations();
    }
}

