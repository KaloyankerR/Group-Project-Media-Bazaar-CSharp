using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Inventory_related
{
    public class Unit
    {
        public int unitID;
        public string name;

        public Unit() { }
        public Unit(int unitID,string name)
        {
            this.unitID = unitID;
            this.name = name;   
        }
        public override string ToString()
        {
            return this.name;
        }
    }
}
