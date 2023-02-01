using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("Register added successfully.");
            }
            else
            {
                Console.WriteLine("Validation failed. Registration failed.");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Register deleted successfully.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Register updated successfully.");
        }
    }
}
