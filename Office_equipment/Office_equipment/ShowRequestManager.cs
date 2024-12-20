using System.Data.SqlClient;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Windows.Forms;
using LibraryForOfficeEqipement;

namespace Office_equipment
{
    public partial class ShowRequestManager : Form
    {
        string connectionString = DataBase.ConnectionString;
        DataTable request;
        DataTable sort = new DataTable();
        public ShowRequestManager()
        {
            InitializeComponent();
            UpdateForm();
            �ompletingComboBox();
        }
        public void UpdateForm()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter($"EXEC get_request", connection);
                request = new DataTable();
                adapter.Fill(request);
                adapter.Fill(sort);
                request.Columns[1].ColumnName = "��� �������";
                request.Columns[2].ColumnName = "������";
                request.Columns[3].ColumnName = "��������";
                request.Columns[4].ColumnName = "������ ������";
                request.Columns[5].ColumnName = "������";
                request.Columns[6].ColumnName = "���� ������";
                request.Columns[7].ColumnName = "���� �����";
                sort.Columns[1].ColumnName = "��� �������";
                sort.Columns[2].ColumnName = "������";
                sort.Columns[3].ColumnName = "��������";
                sort.Columns[4].ColumnName = "������ ������";
                sort.Columns[5].ColumnName = "������";
                sort.Columns[6].ColumnName = "���� ������";
                sort.Columns[7].ColumnName = "���� �����";
                requestGrid.DataSource = request;
                requestGrid.Columns[0].Visible = false;
                countLabel.Text = request.Rows.Count.ToString();
                fullCountLable.Text = request.Rows.Count.ToString();
            }
            avgLabel.Text = DataBase.GetAvgTime(request);
        }
        public void �ompletingComboBox()
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

        private void request_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = e.RowIndex;
            if (numrow >= 0 && e.ColumnIndex >= 0 && requestGrid.Rows[numrow].Cells[e.ColumnIndex].Value != null)
            {
                    Hide();
                    UpdateRequestManager updateRequest = new UpdateRequestManager(Convert.ToUInt16(requestGrid.Rows[numrow].Cells[0].Value.ToString()));
                    updateRequest.ShowDialog();
                    Show();
                   UpdateForm();
                
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = requestGrid.DataSource;
            bs.Filter = "��������" + " like '%" + searchTextBox.Text + "%'";
            requestGrid.DataSource = bs;
            countLabel.Text = requestGrid.Rows.Count.ToString();
        }
    }
}
