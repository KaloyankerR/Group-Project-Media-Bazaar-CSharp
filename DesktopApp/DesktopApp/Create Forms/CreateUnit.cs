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

namespace DesktopApp.Create_Forms
{
    public partial class CreateUnit : Form
    {
        IUnitManager unitManager = new UnitManager(new UnitDAO());
        public CreateUnit()
        {
            InitializeComponent();
        }

        private void CreateUnitButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UnitNameTBX.Text))
            {
                MessageBox.Show("Please fill in all the fields correctly!");
                return;
            }
            else
            {
                string name = UnitNameTBX.Text;
                bool createUnit = unitManager.CreateUnit(new Unit(0, name));
                if (createUnit)
                {
                    MessageBox.Show("Unit created!");
                    Close();
                }
                else
                {
                    MessageBox.Show("Something went wrong!");
                }
            }

        }

        private void CreateUnitBackButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
