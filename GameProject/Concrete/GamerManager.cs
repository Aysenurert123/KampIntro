using GameProject.Abstract.IGamerService;
using GameProject.Abstract.IUserValidationService;
using GameProject.Entities.Concrete.Gamer;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete.GamerManager
{
    public class GamerManager : IGamerService
    {
        // -- MicroService
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("Kayıt oldu");
            }
            else
            {
                Console.WriteLine("Doğrulama yapılamadı, kayıt yapılamadı");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi");
        }
    }
}
