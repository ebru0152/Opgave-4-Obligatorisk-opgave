using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Opgave4ModelLib.model;

namespace Opgave4.Managers
{
    interface IManageFootballer
    {
        IEnumerable<FootballPlayer> Get();
        FootballPlayer Get(int id);
        bool Create(FootballPlayer value);
        bool Update(int id, FootballPlayer value);
        FootballPlayer Delete(int id);
    }
}
