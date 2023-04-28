using MagicFactory.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicFactory.Helicopter
{
    public  abstract class Propeller
    {
        public int rotationSpeed;
        public int lengthBlade;
        public string material;
        public int heightInSpase = 1;
    }
    public class MainPropeller : Propeller // Пропеллер отвечающий в основном за высоту
    {
        public int risePower; // Сила подьёма 

        public int GainHeight(int degree)
        {
            return heightInSpase = degree * heightInSpase * 5;
        }

    }

    public class TailPropeller : Propeller
    {
        public int tailPower; // Боковая сила



    }

}
