using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classes.Inventory_related;
using DAL.Inventory_related;
using LL.Inventory_related;

namespace DesktopApp.Edit_Forms
{
    public partial class EditUnit : Form
    {
        IUnitManager unitManager = new UnitManager(new UnitDAO());
        private Unit unit;
        public EditUnit(Unit unitToEdit)
        {
            this.unit = unitToEdit;
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            EditUnitNameTBX.Text = unit.name;
        }
        private void UpdateData()
        {
            unit.name = EditUnitNameTBX.Text;
        }
        private void SaveEditUnitButton_Click(object sender, EventArgs e)
        {
            UpdateData();
            unitManager.UpdateUnit(unit);
            Close();
        }

        private void EditUnitBackButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
