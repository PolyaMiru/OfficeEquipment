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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using LibraryForOfficeEqipement;

namespace Office_equipment
{
    public partial class UpdateRequestManager : Form
    {
        string connectionString = DataBase.ConnectionString;
        int id_request;
        DataTable listMasters;
        public UpdateRequestManager(int id_request)
        {
            InitializeComponent();
            this.id_request = id_request;
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

                adapter = new SqlDataAdapter($"EXEC get_request_by_id {id_request}", connection);
                DataTable request = new DataTable();
                adapter.Fill(request);
                string type = request.Rows[0][1].ToString();
                foreach (var item in type_comboBox.Items)
                {
                    if (type == item.ToString()) { type_comboBox.SelectedItem = item; }
                }

                adapter = new SqlDataAdapter("EXEC get_status", connection);
                DataTable listStatus = new DataTable();
                adapter.Fill(listStatus);
                string[] status = (from DataRow row in listStatus.Rows
                                   select row["name_status"].ToString()).ToArray();
                statusComboBox.Items.Add("-");
                statusComboBox.Items.AddRange(status);

                adapter = new SqlDataAdapter($"EXEC get_model '{type_comboBox.SelectedItem.ToString()}'", connection);
                DataTable listModel = new DataTable();
                adapter.Fill(listModel);
                string[] models = (from DataRow row in listModel.Rows
                                   select row["name_model"].ToString()).ToArray();
                if (models.Length > 0)
                {
                    model_comboBox.Items.AddRange(models);
                }
                else model_comboBox.Text = "нет моделей";
                string model = request.Rows[0][2].ToString();
                foreach (var item in model_comboBox.Items)
                {
                    if (model == item.ToString()) { model_comboBox.SelectedItem = item; }
                }
                problem_textBox.Text = request.Rows[0][3].ToString();
                string stat = request.Rows[0][4].ToString();
                foreach (var item in statusComboBox.Items)
                {
                    if (stat == item.ToString()) { statusComboBox.SelectedItem = item; }
                }
                string master = request.Rows[0][5].ToString();
                adapter = new SqlDataAdapter("EXEC get_master", connection);
                listMasters = new DataTable();
                adapter.Fill(listMasters);
                string[] masters = (from DataRow row in listMasters.Rows
                                  select row["fio"].ToString()).ToArray();
                masters_comboBox.Items.Add("-");
                masters_comboBox.Items.AddRange(masters);
                
                foreach (var item in masters_comboBox.Items)
                {
                    if (master == item.ToString()) { masters_comboBox.SelectedItem = item; }
                }
                if (masters_comboBox.SelectedItem == null) { masters_comboBox.SelectedIndex = 0;}

                startDatePicker.Value = DateTime.Parse(request.Rows[0][6].ToString());
                if (request.Rows[0][7].ToString() != string.Empty)
                {
                    endDatePicker.Value = DateTime.Parse(request.Rows[0][7].ToString());
                }
                

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

        private void update_button_Click(object sender, EventArgs e)
        {
            if (masters_comboBox.SelectedIndex == 0)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand($"EXEC update_request_manager {id_request},{null},'{model_comboBox.SelectedItem.ToString()}', '{problem_textBox.Text}', '{startDatePicker.Value.ToShortDateString()}', '{endDatePicker.Value.ToShortDateString()}', '{statusComboBox.SelectedItem.ToString()}';", connection);
                    try
                    {
                        command.ExecuteReader();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
            else 
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand($"EXEC update_request_manager {id_request},{listMasters.Rows[masters_comboBox.SelectedIndex - 1][0]},'{model_comboBox.SelectedItem.ToString()}', '{problem_textBox.Text}', '{startDatePicker.Value.ToShortDateString()}', '{endDatePicker.Value.ToShortDateString()}', '{statusComboBox.SelectedItem.ToString()}';", connection);
                    try
                    {
                        command.ExecuteReader();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }
    }
}
