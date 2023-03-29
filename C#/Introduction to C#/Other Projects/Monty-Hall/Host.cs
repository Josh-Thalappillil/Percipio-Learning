using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monty_Hall
{
    public class Host
    {
        public void hostOpensADoor(List<Door> doors)
        {
            doors.First(door => door.hasCar() != true && door.picked != true).opened = true;
        }

    }
}
