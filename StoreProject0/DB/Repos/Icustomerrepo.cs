using DB.Models;
using System.Collections.Generic;
namespace DB.Repos
{
    public interface Icustomerrepo
    {
         void AddUser(Customer user);
         Customer GetUserByUsername(string name);
    }
}

