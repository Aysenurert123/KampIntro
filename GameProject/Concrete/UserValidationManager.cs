using GameProject.Abstract.IUserValidationService;
using GameProject.Entities.Concrete.Gamer;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete.UserValidationManager
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if(gamer.BirthYear == 2000 && gamer.FirstName == "AYŞENUR" && gamer.Lastname=="ERTÜRK" && gamer.IdentityNumber==12345676)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
