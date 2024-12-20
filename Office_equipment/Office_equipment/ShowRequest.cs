using System.Data;
using System.Data.SqlClient;
using LibraryForOfficeEqipement;

namespace Office_equipment
{
    public partial class ShowRequest : Form
    {
        string connectionString = DataBase.ConnectionString;
        int id_client;
        DataTable request;
        DataTable sort;
        public ShowRequest(int id_client)
        {
            InitializeComponent();
            this.id_client = id_client;

            UpdateForm();
            СompletingComboBox();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            Hide();
            AddRequest addRequest = new AddRequest(id_client);
            addRequest.ShowDialog();
            Show();
            UpdateForm();
        }


        public void UpdateForm()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter($"EXEC get_request_by_client {id_client}", connection);
                request = new DataTable();
                sort = new DataTable();
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

                request.Columns.Add("Комментарии");
                sort.Columns.Add("Комментарии");
                adapter = new SqlDataAdapter($"EXEC get_comments", connection);
                DataTable comm = new DataTable();
                adapter.Fill(comm);
                for (int i = 0; i < request.Rows.Count; i++)
                {
                    for (int j = 0; j < comm.Rows.Count; j++)
                    {
                        if (comm.Rows[j][0].ToString() == request.Rows[i][0].ToString())
                        {
                            request.Rows[i][5] += $"{comm.Rows[j][1].ToString()}\n";
                            sort.Rows[i][5] += $"{comm.Rows[j][1].ToString()}\n";
                        }
                    }
                }
                requestGrid.DataSource = request;
                requestGrid.Columns[0].Visible = false;
            }
            countLabel.Text = request.Rows.Count.ToString();
            fullCountLable.Text = request.Rows.Count.ToString();
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
                if (requestGrid.Rows[numrow].Cells[4].Value.ToString() == "Новая заявка" || requestGrid.Rows[numrow].Cells[4].Value.ToString() == "Готова к выдаче")
                {
                    Hide();
                    UpdateRequest updateRequest = new UpdateRequest(Convert.ToUInt16(requestGrid.Rows[numrow].Cells[0].Value.ToString()));
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

        private void request_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void countLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
