using System.Data;
using System.Data.SqlClient;
using LibraryForOfficeEqipement;

namespace Office_equipment
{
    public partial class ShowRequestMaster : Form
    {
        string connectionString = DataBase.ConnectionString;
        int id_master;
        DataTable request;
        DataTable sort = new DataTable();
        public ShowRequestMaster(int id_master)
        {
            InitializeComponent();
            this.id_master = id_master;
            UpdateForm();
            СompletingComboBox();
        }
        public void UpdateForm()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter($"EXEC get_request_by_master {id_master}", connection);
                request = new DataTable();
                adapter.Fill(request);
                adapter.Fill(sort);
                request.Columns[1].ColumnName = "Тип техники";
                request.Columns[2].ColumnName = "Модель";
                request.Columns[3].ColumnName = "Проблема";
                request.Columns[4].ColumnName = "Статус заявки";
                sort.Columns[1].ColumnName = "Тип техники";
                sort.Columns[2].ColumnName = "Модель";
                sort.Columns[3].ColumnName = "Проблема";
                sort.Columns[4].ColumnName = "Статус заявки";
                requestGrid.DataSource = request;
                requestGrid.Columns[0].Visible = false;
                countLabel.Text = request.Rows.Count.ToString();
                fullCountLable.Text = request.Rows.Count.ToString();
            }
        }
        public void СompletingComboBox()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("EXEC get_status", connection);
                DataTable listStatus = new DataTable();
                adapter.Fill(listStatus);
                string[] status = (from DataRow row in listStatus.Rows
                                   select row["name_status"].ToString()).ToArray();
                statusComboBox.Items.Add("-");
                statusComboBox.Items.AddRange(status);
                statusComboBox.SelectedIndex = 0;
            }
        }

        private void request_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = e.RowIndex;
            if (numrow >= 0 && e.ColumnIndex >= 0 && requestGrid.Rows[numrow].Cells[e.ColumnIndex].Value != null)
            {
                if (requestGrid.Rows[numrow].Cells[4].Value.ToString() != "Готова к выдаче")
                {
                    Hide();
                    UpdateRequestMaster updateRequest = new UpdateRequestMaster(Convert.ToUInt16(requestGrid.Rows[numrow].Cells[0].Value.ToString()));
                    updateRequest.ShowDialog();
                    Show();
                    UpdateForm();
                }
            }
        }

        private void status_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (statusComboBox.SelectedIndex != 0)
            {
                sort.Rows.Clear();

                for (int i = 0; i < request.Rows.Count; i++)
                {
                    if (request.Rows[i][4].ToString() == statusComboBox.SelectedItem.ToString())
                    {
                        sort.Rows.Add(request.Rows[i].ItemArray);
                    }
                }
                requestGrid.DataSource = sort;
                requestGrid.Columns[0].Visible = false;
                countLabel.Text = sort.Rows.Count.ToString();
                fullCountLable.Text = request.Rows.Count.ToString();
            }
            else
            {
                requestGrid.DataSource = request;
                requestGrid.Columns[0].Visible = false;
                countLabel.Text = request.Rows.Count.ToString();
                fullCountLable.Text = request.Rows.Count.ToString();
            }
        }
    }
}
