using System;
using System.Windows.Forms;

namespace BeSpoked_Bikes
{
    public partial class SalesPerson_Form : Form
    {
        public SalesPerson_Form()
        {
            InitializeComponent();
            LoadSalesPerson();
        }

        private void ClearFields()
        {

            Id_textBox.Text = "";
            First_Name_TextBox.Text = "";
            Last_Name_TextBox.Text = "";
            Address_TextBox.Text = "";
            Phone_TextBox.Text = "";
            Start_Date_TextBox.Text = "";
            Terminate_Date_textBox.Text =  "";
            Manager_TextBox.Text = "";
        }
        private void LoadSalesPerson()
        {

            using (var db = new BeSpokedModelContext())
            {
                var SalesPerson = db.GetSalesPersons();
                SalePersons_dataGridView.DataSource = SalesPerson;

                //autoresize each column

                SalePersons_dataGridView.AutoResizeColumn(0);
                SalePersons_dataGridView.AutoResizeColumn(1);
                SalePersons_dataGridView.AutoResizeColumn(2);
                SalePersons_dataGridView.AutoResizeColumn(3);
                SalePersons_dataGridView.AutoResizeColumn(4);
                SalePersons_dataGridView.AutoResizeColumn(5);
                SalePersons_dataGridView.AutoResizeColumn(6);
                SalePersons_dataGridView.AutoResizeColumn(7);

            }

        }
        private void SalesPerson_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Update_button_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(Id_textBox.Text))
            {
                MessageBox.Show("Please select sale person to update");
            }

            try
            {

                using (var db = new BeSpokedModelContext())
                {                  

                    long Id = Convert.ToInt64(Id_textBox.Text);
                    string First_Name = First_Name_TextBox.Text;
                    string Last_Name = Last_Name_TextBox.Text;
                    string Address = Address_TextBox.Text;
                    string Phone = Phone_TextBox.Text;
                    DateTime Start_Date = Convert.ToDateTime(Start_Date_TextBox.Text);
                    DateTime? Termination_Date = null;
                    if (!string.IsNullOrEmpty(Terminate_Date_textBox.Text))
                    {
                        Termination_Date = Convert.ToDateTime(Terminate_Date_textBox.Text);
                    }

                    string Manager = Manager_TextBox.Text;

                    var SalesPerson = db.GetSalesPersonsById(Convert.ToInt64(Id));


                    SalesPerson.First_Name = First_Name.TrimEnd();
                    SalesPerson.Last_Name = Last_Name.TrimEnd();
                    SalesPerson.Address = Address.TrimEnd();
                    SalesPerson.Phone = Phone.TrimEnd();
                    SalesPerson.Start_Date = Start_Date;
                    SalesPerson.Termination_Date = Termination_Date;
                    SalesPerson.Manager = Manager.TrimEnd();


                    db.SaveChanges();
                            
                }
                LoadSalesPerson();
                ClearFields();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
               

        private void Reload_button_Click(object sender, EventArgs e)
        {
            LoadSalesPerson();
            ClearFields();

        }

        private void SalePersons_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int nRowCount = SalePersons_dataGridView.RowCount;
            if (nRowCount > 0)
            {
                Id_textBox.Text = SalePersons_dataGridView.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                First_Name_TextBox.Text = SalePersons_dataGridView.Rows[e.RowIndex].Cells["First_Name"].Value as string;
                Last_Name_TextBox.Text = SalePersons_dataGridView.Rows[e.RowIndex].Cells["Last_Name"].Value as string;
                Address_TextBox.Text = SalePersons_dataGridView.Rows[e.RowIndex].Cells["Address"].Value as string;
                Phone_TextBox.Text = SalePersons_dataGridView.Rows[e.RowIndex].Cells["Phone"].Value as string;
                Start_Date_TextBox.Text = SalePersons_dataGridView.Rows[e.RowIndex].Cells["Start_Date"].Value.ToString();                
                if (SalePersons_dataGridView.Rows[e.RowIndex].Cells["Termination_Date"].Value !=null)
                    Terminate_Date_textBox.Text = SalePersons_dataGridView.Rows[e.RowIndex].Cells["Termination_Date"].Value.ToString();
                Manager_TextBox.Text = SalePersons_dataGridView.Rows[e.RowIndex].Cells["Manager"].Value as string;
            }
        }
    }
}
