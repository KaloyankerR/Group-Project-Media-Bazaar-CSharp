using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.Inventory_related;

namespace DAL.Inventory_related
{
    public interface IUnitDAO
    {
        bool CreateUnit(Unit unit);
        bool DeleteUnit(Unit unit);
        bool UpdateUnit(Unit unit);
        Unit GetUnitById(int id);
        List<Unit> GetAllUnits();
    }
}
