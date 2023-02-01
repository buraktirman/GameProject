using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthDate.Year == 1985 && gamer.FirstName == "Engin" 
                && gamer.LastName == "Demiroğ" && gamer.IdentityNumber == "28861499108")
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
