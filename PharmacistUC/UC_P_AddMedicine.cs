using PharmacyManagementSystem.Controllers;
using PharmacyManagementSystem.DataAccess;
using PharmacyManagementSystem.DataAccess.DAO;
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
    public partial class UC_P_AddMedicine : UserControl
    {
        public UC_P_AddMedicine()
        {
            InitializeComponent();
        }

        private void UC_P_AddMedicine_Load(object sender, EventArgs e)
        {
            medManufact_dateBox.Value = DateTime.Today;
            medExpire_dateBox.Value = DateTime.Today;
            medName_txtBox.Text = "";
            medChem_txtBox.Text = "";
            medQuantity_txtBox.Text = "";
            medPrice_txtBox.Text = "";
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            IMedicineDao medicineDao = new MedicineDaoImpl();
            MedicineController medicineController = new MedicineController(medicineDao);

            Medicine med = new Medicine {
                M_ChemicalName = medChem_txtBox.Text,
                M_Date = DateTime.Parse(medManufact_dateBox.Text),
                Expiry_Date = DateTime.Parse(medExpire_dateBox.Text),
                M_Name = medName_txtBox.Text,
                M_PricePerUnit = Decimal.Parse(medPrice_txtBox.Text),
                M_Quantity = Int32.Parse(medQuantity_txtBox.Text)
            };

            bool confirmMed = medicineController.InsertMedicine(med);

            if (confirmMed)
            {
                MessageBox.Show("Succesfull");
                medName_txtBox.Text = "";
                medChem_txtBox.Text = "";
                medQuantity_txtBox.Text = "";
                medPrice_txtBox.Text = "";
                medManufact_dateBox.Value = DateTime.Today;
                medExpire_dateBox.Value = DateTime.Today;

              
                UC_P_ViewMedicines viewMedicines = new UC_P_ViewMedicines();
                viewMedicines.RefreshMedicineTable();

            }
            else {
                MessageBox.Show("Faild");
            }

        }

        private void MedReset_btn_Click(object sender, EventArgs e)
        {
            medName_txtBox.Text = "";
            medChem_txtBox.Text = "";
            medQuantity_txtBox.Text = "";
            medPrice_txtBox.Text = "";
        }
    }
}
