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
using QRCoder;

namespace Office_equipment
{
    public partial class UpdateRequest : Form
    {
        string connectionString = DataBase.ConnectionString;
        int id_request;
        public UpdateRequest(int id_request)
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
                typeComboBox.Items.AddRange(types);

                adapter = new SqlDataAdapter($"EXEC get_request_by_id {id_request}", connection);
                DataTable request = new DataTable();
                adapter.Fill(request);
                string type = request.Rows[0][1].ToString();
                foreach (var item in typeComboBox.Items)
                {
                    if (type == item.ToString()) { typeComboBox.SelectedItem = item; }
                }

                adapter = new SqlDataAdapter($"EXEC get_model '{typeComboBox.SelectedItem.ToString()}'", connection);
                DataTable listModel = new DataTable();
                adapter.Fill(listModel);
                string[] models = (from DataRow row in listModel.Rows
                                   select row["name_model"].ToString()).ToArray();
                if (models.Length > 0)
                {
                    modelComboBox.Items.AddRange(models);
                }
                else modelComboBox.Text = "нет моделей";
                string model = request.Rows[0][2].ToString();
                foreach (var item in modelComboBox.Items)
                {
                    if (model == item.ToString()) { modelComboBox.SelectedItem = item; }
                }
                problemTextBox.Text = request.Rows[0][3].ToString();
                if (request.Rows[0][4].ToString() == "Готова к выдаче")
                {
                    updatePanel.Enabled = false;
                    this.Size = new System.Drawing.Size(378, 627);
                    string url = "https://vk.com/polyamiru?ysclid=m4v0gck8dr119663320";

                    QRCodeGenerator qrGenerator = new QRCodeGenerator();
                    QRCodeData qrCodeData = qrGenerator.CreateQrCode(url, QRCodeGenerator.ECCLevel.Q);
                    QRCode qrCode = new QRCode(qrCodeData);
                    Bitmap qrCodeImage = qrCode.GetGraphic(20);
                    QRPictureBox.Image = qrCodeImage;
                }
            }

        }
        private void back_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void type_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            modelComboBox.Items.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter($"EXEC get_model '{typeComboBox.SelectedItem.ToString()}'", connection);
                DataTable listModel = new DataTable();
                adapter.Fill(listModel);
                string[] models = (from DataRow row in listModel.Rows
                                   select row["name_model"].ToString()).ToArray();
                if (models.Length > 0)
                {
                    modelComboBox.Items.AddRange(models);
                    modelComboBox.SelectedIndex = 0;
                }
                else modelComboBox.Text = "нет моделей";
            }
        }


        private void update_button_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"EXEC update_request {id_request}, '{modelComboBox.SelectedItem.ToString()}', '{problemTextBox.Text}';", connection);
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
