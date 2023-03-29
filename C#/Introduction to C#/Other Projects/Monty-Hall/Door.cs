using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monty_Hall
{
    public class Door
    {
        private bool _hasCar;
        public bool opened;
        public bool picked;

        public void injectCarToDoor()
        {
            _hasCar = true;
        }

        public bool hasCar()
        {
            return _hasCar;
        }
    }
}
