using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;
using Classes.Inventory_related;
using DAL;
using DAL.Inventory_related;

namespace LL.Inventory_related
{
    public class UnitManager : IUnitManager
    {
        IUnitDAO unitDAO;
        public UnitManager(IUnitDAO unitDAO) 
        {
            this.unitDAO = unitDAO;
        }
        public bool CreateUnit(Unit unit)
        {
            try
            {
                if (unitDAO.CreateUnit(unit))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex) 
            {
                return false;
            }

        }

        public bool DeleteUnit(Unit unit)
        {
            try
            {
                if (unitDAO.DeleteUnit(unit))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Unit> GetAllUnits()
        {
            List<Unit> list = new List<Unit>();
            foreach(Unit unit in unitDAO.GetAllUnits()) 
            {
                list.Add(unit);
            }
            return list;
        }

        public Unit GetUnitById(int id)
        {
            Unit unit=unitDAO.GetUnitById(id);
            return unit;
        }

        public bool UpdateUnit(Unit unit)
        {
            try
            {
                if (unitDAO.UpdateUnit(unit))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
