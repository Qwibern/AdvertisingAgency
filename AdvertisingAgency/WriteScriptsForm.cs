using MaterialSkin.Controls;

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

namespace AdvertisingAgency
{
    public partial class WriteScriptsForm : MaterialForm
    {

        public string sqlWrite;

        public WriteScriptsForm()
        {
            InitializeComponent();
        }

        private void rbRun_Click(object sender, EventArgs e)
        {

            MainForm mainForm = new MainForm();

            try
            {
                string connectionString = @"Data Source=QWIBERN-NB;Initial Catalog=AA;Integrated Security=True;Pooling=False";
                sqlWrite = tbWriteScripts.Text;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    // Создаем объект DataAdapter
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlWrite, connection);
                    // Создаем объект Dataset
                    DataSet ds = new DataSet();
                    // Заполняем Dataset
                    adapter.Fill(ds);
                    // Отображаем данные
                    mainForm.dataGridView1.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
