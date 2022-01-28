using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class Unit
    {
        private int BaseNumber = 5;
        public int Model1() 
        {
            return BaseNumber + 2 ;
        }

        private bool afvo = false;

        public bool afvoModel() 
        {
            if (2>3)
            {
                afvo = true;
            }
            return afvo;
        }

    }
}
