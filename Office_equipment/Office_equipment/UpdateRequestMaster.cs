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
    public partial class UpdateRequestMaster : Form
    {
        string connectionString = DataBase.ConnectionString;
        int id_request;
        public UpdateRequestMaster(int id_request)
        {
            InitializeComponent();
            this.id_request = id_request;
            UpdateForm();
        }

        private void UpdateForm()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter($"EXEC get_request_by_id {id_request}", connection);
                DataTable request = new DataTable();
                adapter.Fill(request);
                typeTextBox.Text = request.Rows[0][1].ToString();
                modelTextBox.Text = request.Rows[0][2].ToString();
                problemTextBox.Text = request.Rows[0][3].ToString();

                if (request.Rows[0][4].ToString() == "Зарегистрированна")
                {
                    startButton.Enabled = true;
                    commentButton.Enabled = false;   
                    addPartButton.Enabled = false;
                }
                if (request.Rows[0][4].ToString() == "В процеесе ремонта")
                {
                    endButton.Enabled = true;
                }

                adapter = new SqlDataAdapter($"EXEC get_parts_by_id {id_request}", connection);
                DataTable parts = new DataTable();
                adapter.Fill(parts);
                parts.Columns[0].ColumnName = "Название детали";
                parts.Columns[1].ColumnName = "Количество";
                partGrid.DataSource = parts;

            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void commentButton_Click(object sender, EventArgs e)
        {
            AddComment addComment = new AddComment(id_request);
            Hide();
            addComment.ShowDialog();
            Show();
            UpdateForm();
        }

        private void addPartButton_Click(object sender, EventArgs e)
        {
            AddParts addParts = new AddParts(id_request);
            Hide();
            addParts.ShowDialog();
            Show();
            UpdateForm();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"EXEC start_work {id_request}, '{DateTime.Today.ToString("dd.MM.yyyy")}';", connection);
                try
                {
                    command.ExecuteReader();
                    commentButton.Enabled = true;
                    addPartButton.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"EXEC end_work {id_request}, '{DateTime.Today.ToString("dd.MM.yyyy")}';", connection);
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
    }
}
