using PharmacyManagementSystem.Controllers;
using PharmacyManagementSystem.DataAccess.DAO;
using PharmacyManagementSystem.DataAccess;
using PharmacyManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem.PharmacistUC
{
    public partial class UC_P_MedicineValidityCheck : UserControl
    {
        public UC_P_MedicineValidityCheck()
        {
            InitializeComponent();
        }

        private void UC_P_MedicineValidityCheck_Load(object sender, EventArgs e) {
            
            valid_comboBox.SelectedIndex = 2;
            setDatagridview();
        }

        private void  setDatagridview()
        {
            valid_grid.AutoGenerateColumns = false;
            valid_grid.Columns.Clear();

            
            // Add ID column
            var idColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "ID",
                DataPropertyName = "ID",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells,
                Visible = false
            };
            valid_grid.Columns.Add(idColumn);

            // Add Medicine Name column
            var medicineNameColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Medicine Name",
                DataPropertyName = "MedicineName",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            };
            valid_grid.Columns.Add(medicineNameColumn);

            // Add Chemical Name column
            valid_grid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Chemical Name",
                DataPropertyName = "ChemicalName",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            });

            // Add Quantity column
            valid_grid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Qty",
                DataPropertyName = "Qty",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            });

            // Add Price column
            valid_grid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Price",
                DataPropertyName = "Price",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            });

            // Add Manufacture Date column
            valid_grid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Manufacture Date",
                DataPropertyName = "ManufactureDate",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            });

            // Add Expiration Date column
            valid_grid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Expiration Date",
                DataPropertyName = "ExpirationDate",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            });

            // Add a blank fill column
            valid_grid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "",
                DataPropertyName = "null",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
        }





        private void valid_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (valid_comboBox.SelectedIndex == 0)
            {
                // View all valid medicine
                IMedicineDao medicineDao = new MedicineDaoImpl();
                MedicineController medicineController = new MedicineController(medicineDao);

                IEnumerable<Medicine> medname = medicineController.GetValidMedicines();
                valid_grid.AutoGenerateColumns = true;
                valid_grid.DataSource = medname.ToList();
                valid_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            }
            else if (valid_comboBox.SelectedIndex == 1)
            {
                // View all expired medicine
                IMedicineDao medicineDao = new MedicineDaoImpl();
                MedicineController medicineController = new MedicineController(medicineDao);

                IEnumerable<Medicine> medname = medicineController.GetExpiredMedicines();
                valid_grid.AutoGenerateColumns = true;
                valid_grid.DataSource = medname.ToList();
                valid_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            }
            else if (valid_comboBox.SelectedIndex == 2)
            {
                //view all medicine
                IMedicineDao medicineDao = new MedicineDaoImpl();
                MedicineController medicineController = new MedicineController(medicineDao);

                IEnumerable<Medicine> medname = medicineController.GetAllMedicines();
                valid_grid.AutoGenerateColumns = true;
                valid_grid.DataSource = medname.ToList();
                valid_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            }
            else {
                MessageBox.Show("Select item to show");
            }
        }
    }
}
