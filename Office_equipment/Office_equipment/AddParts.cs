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
using LibraryForOfficeEqipement;

namespace Office_equipment
{
    public partial class AddParts : Form
    {
        string connectionString = DataBase.ConnectionString;
        int id_request;
        public AddParts(int id_request)
        {
            InitializeComponent();
            this.id_request = id_request;
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Trim() != string.Empty)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand($"EXEC add_part {id_request}, '{nameTextBox.Text}', {countNumericUpDown.Value};", connection);
                    try
                    {
                        command.ExecuteReader();
                        Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
            else
                MessageBox.Show("Не все поля заполнены!");
        }
    }
}
