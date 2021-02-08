using GameProject.Entities.Concrete.Gamer;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract.IGamerService
{
    public interface IGamerService
    {
        void Add(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);
    }
}
