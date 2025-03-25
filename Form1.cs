using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGBDlab1
{
    public partial class Form1: Form
    {
        //conectarea la BD
        SqlConnection cs = new SqlConnection("Data Source=TUDOR\\SQLEXPRESS;Initial Catalog=Hermes;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        public Form1()
        {
            InitializeComponent();

        }



        private void LoadVolunteers(int id_departament)
        {
            SqlDataAdapter localDa = new SqlDataAdapter();
            DataSet localDs = new DataSet();
            localDa.SelectCommand = new SqlCommand("SELECT * FROM Voluntari WHERE id_departament = @id_departament", cs);
            localDa.SelectCommand.Parameters.AddWithValue("@id_departament", id_departament);

            localDa.Fill(localDs);
            dataGridViewVoluntarii.DataSource = localDs.Tables[0];
        }


        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewDepartamente.Rows.Count - 1) // Skip new row
            {
                // Get the entire row
                DataGridViewRow selectedRow = dataGridViewDepartamente.SelectedRows[0];

                // Try to get the 'id_departament' column safely
                var cellValue = selectedRow.Cells["id_departament"].Value;

                //id_departament textbox
                textBoxId.Text = selectedRow.Cells["id_departament"].Value.ToString();

                if (cellValue != null && int.TryParse(cellValue.ToString(), out int departamentID))
                {

                    LoadVolunteers(departamentID);
                }
                else
                {
                    MessageBox.Show("Could not get department ID. Make sure it's a valid column.");
                }
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            //selectarea departamentelor din BD
            da.SelectCommand = new SqlCommand("select * from Departamente", cs);
            ds.Clear();
            da.Fill(ds);
            dataGridViewDepartamente.DataSource = ds.Tables[0];
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
