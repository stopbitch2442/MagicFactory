using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MagicFactory.Car.Suspention;

namespace MagicFactory.Helicopter
{
    public abstract class Suspention
    {
        public int Speed;
        public Wheels[] wheels;

        public class Wheels
        {
            public int Speed;
            public int Size;
        }
        
        public class BoeingSuspention : Suspention 
        {
            
            
        }



    }
}
