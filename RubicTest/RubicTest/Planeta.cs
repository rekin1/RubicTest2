using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubicTest
{
    class Planeta
    {
        private void Main()
        {
            CreateCat();
            CreateCat();
            CreateCat();
            CreateHuman();
            CreateHuman();
            CreateHuman();
        }
        
        private void CreateCat()
        {
            Cat cat1 = new Cat();
            cat1.name = "Рич";
            cat1.age = 1;
            cat1.h = 1.01f;
            cat1.isBoy = true;
        }

        private void CreateHuman() 
        {
            Human human1 = new Human();
            human1.name = "A4";
            human1.height = 1.8f;
            human1.age = 25;
            human1.isBoy = true;
            human1.Login = "A4production";
            human1.Password = "123456789";
            human1.isHungry = true;
        }

    }
}
