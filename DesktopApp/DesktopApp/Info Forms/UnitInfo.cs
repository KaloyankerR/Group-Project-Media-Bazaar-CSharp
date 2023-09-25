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
using DesktopApp.Create_Forms;
using DesktopApp.Edit_Forms;
using LL.Inventory_related;

namespace DesktopApp.Info_Forms
{
	public partial class UnitInfo : UserControl
	{
		IUnitManager unitManager = new UnitManager(new UnitDAO());
		IUnitDAO unitDAO;
		public UnitInfo()
		{

			InitializeComponent();
			Load();
			dgvUnit.AllowUserToAddRows = false;
			dgvUnit.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		}
		public void Load()
		{
			dgvUnit.DataSource = null;
			List<Unit> list = unitManager.GetAllUnits();
			DataTable dt = new DataTable();
			dt.Columns.Add("ID", typeof(int));
			dt.Columns.Add("Name", typeof(string));
			foreach (var item in list)
			{
				DataRow row = dt.NewRow();
				row["ID"] = item.unitID;
				row["Name"] = item.name;
				dt.Rows.Add(row);
			}
			if (list.Count > 0)
			{
				dgvUnit.DataSource = dt;
			}
		}
		private void CreateButton_Click(object sender, EventArgs e)
		{
			CreateUnit createUnit = new CreateUnit();
			createUnit.ShowDialog();
			Load();
		}

		private void EditUnitButton_Click(object sender, EventArgs e)
		{
			if (dgvUnit.SelectedRows.Count > 0)
			{
				int unitId = Convert.ToInt32(dgvUnit.SelectedRows[0].Cells["ID"].Value);
				Unit unit = unitManager.GetUnitById(unitId);
				EditUnit editUnit = new EditUnit(unit);
				editUnit.ShowDialog();
				Load();
			}
		}

		private void DeleteUnitButton_Click(object sender, EventArgs e)
		{
			if (dgvUnit.SelectedRows.Count > 0)
			{
				DialogResult deletePrompt = MessageBox.Show("Are you sure you want to delete this Unit?", "Delete Unit", MessageBoxButtons.YesNo);
				if (deletePrompt == DialogResult.Yes)
				{
					int unitId = Convert.ToInt32(dgvUnit.SelectedRows[0].Cells["ID"].Value);
					Unit unit = unitManager.GetUnitById(unitId);
					bool resultUnit = unitManager.DeleteUnit(unit);
					if (resultUnit)
					{

						MessageBox.Show("Unit deleted");
						Load();
					}
					else
					{
						MessageBox.Show("Unit not deleted");
					}
				}
			}
			Load();
		}

		private void ShowAllUnitButton_Click(object sender, EventArgs e)
		{
			Load();
		}
	}
}
