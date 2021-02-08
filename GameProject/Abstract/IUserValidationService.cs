using GameProject.Entities.Concrete.Gamer;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract.IUserValidationService
{
    public interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
