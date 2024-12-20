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
    public partial class AddRequest : Form
    {
        string connectionString = DataBase.ConnectionString;
        int id_client;
        public AddRequest(int id_client)
        {
            InitializeComponent();
            this.id_client = id_client;
            СompletingComboBox();
        }

        public void СompletingComboBox()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("EXEC get_type", connection);
                DataTable listType = new DataTable();
                adapter.Fill(listType);
                string[] types = (from DataRow row in listType.Rows
                                  select row["name_type"].ToString()).ToArray();
                type_comboBox.Items.AddRange(types);
                type_comboBox.SelectedIndex = 0;
            }
        }
        private void back_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void type_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            model_comboBox.Items.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter($"EXEC get_model '{type_comboBox.SelectedItem.ToString()}'", connection);
                DataTable listModel = new DataTable();
                adapter.Fill(listModel);
                string[] models = (from DataRow row in listModel.Rows
                                   select row["name_model"].ToString()).ToArray();
                if (models.Length > 0)
                {
                    model_comboBox.Items.AddRange(models);
                    model_comboBox.SelectedIndex = 0;
                }
                else model_comboBox.Text = "нет моделей";
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if(problem_textBox.Text.Trim() != string.Empty)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand($"EXEC add_request {id_client}, '{model_comboBox.SelectedItem.ToString()}', '{problem_textBox.Text}';", connection);
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
