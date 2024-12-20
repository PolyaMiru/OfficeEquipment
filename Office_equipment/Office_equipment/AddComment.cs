using LibraryForOfficeEqipement;
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

namespace Office_equipment
{
    public partial class AddComment : Form
    {
        string connectionString = DataBase.ConnectionString;
        int id_request;
        public AddComment(int id_request)
        {
            InitializeComponent();
            this.id_request = id_request;
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (commentTextBox.Text.Trim() != string.Empty)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand($"EXEC add_comment {id_request}, '{commentTextBox.Text}';", connection);
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
            else MessageBox.Show("Не все поля заполнены!");
        }
    }
}
