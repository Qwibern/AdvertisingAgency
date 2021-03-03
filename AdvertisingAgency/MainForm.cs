
using MaterialSkin;
using MaterialSkin.Controls;

using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace AdvertisingAgency
{
    public partial class MainForm : MaterialForm
    {

        public string columnForSearch, logicOperator, valueForSearch, sql;

        public MainForm()
        {
            InitializeComponent();

            // Инициализация темы
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void cbDarkTheme_CheckedChanged(object sender, EventArgs e)
        {
            // Изменение темы по переключению галочкой
            if (cbDarkTheme.Checked) 
            {
                // Переключение на темную тему
                var materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.AddFormToManage(this);
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            } 
            else
            {
                // Переключение на светлую тему
                var materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.AddFormToManage(this);
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey500, Primary.BlueGrey600, Primary.BlueGrey500, Accent.LightBlue200, TextShade.BLACK);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // Открытие окна Написать скрипт
            WriteScriptsForm writeScriptsForm = new WriteScriptsForm();
            writeScriptsForm.Show();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            // Сохранение изменений в базе данных
            this.employeeTableAdapter.Update(this.aADataSet.Employee);
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=QWIBERN-NB;Initial Catalog=AA;Integrated Security=True;Pooling=False";
            sql = "SELECT * FROM Employee";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                // Создаем объект Dataset
                DataSet ds = new DataSet();
                // Заполняем Dataset
                adapter.Fill(ds);
                // Отображаем данные
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            // Сохранение изменений в базе данных
            this.customerTableAdapter.Update(this.aADataSet1.Customer);
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            // Сбор данных для поиска
            columnForSearch = toolStripComboBox1.Text;
            logicOperator = toolStripComboBox2.Text;
            valueForSearch = toolStripTextBox2.Text;

            string connectionString = @"Data Source=QWIBERN-NB;Initial Catalog=AA;Integrated Security=True;Pooling=False";
            sql = "SELECT * FROM Customer WHERE " + columnForSearch + " " + logicOperator + " '" + valueForSearch + "';";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                // Создаем объект Dataset
                DataSet ds = new DataSet();
                // Заполняем Dataset
                adapter.Fill(ds);
                // Отображаем данные
                dataGridView2.DataSource = ds.Tables[0];
            }
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=QWIBERN-NB;Initial Catalog=AA;Integrated Security=True;Pooling=False";
            sql = "SELECT * FROM Customer";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                // Создаем объект Dataset
                DataSet ds = new DataSet();
                // Заполняем Dataset
                adapter.Fill(ds);
                // Отображаем данные
                dataGridView2.DataSource = ds.Tables[0];
            }
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            // Открытие окна Написать скрипт
            WriteScriptsForm writeScriptsForm = new WriteScriptsForm();
            writeScriptsForm.Show();
        }

        private void toolStripButton18_Click(object sender, EventArgs e)
        {
            this.serviceDBTableAdapter.Update(this.aADataSet2.ServiceDB);
        }

        private void toolStripButton19_Click(object sender, EventArgs e)
        {
            // Сбор данных для поиска
            columnForSearch = toolStripComboBox3.Text;
            logicOperator = toolStripComboBox4.Text;
            valueForSearch = toolStripTextBox4.Text;

            string connectionString = @"Data Source=QWIBERN-NB;Initial Catalog=AA;Integrated Security=True;Pooling=False";
            sql = "SELECT * FROM ServiceDB WHERE " + columnForSearch + " " + logicOperator + " '" + valueForSearch + "';";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                // Создаем объект Dataset
                DataSet ds = new DataSet();
                // Заполняем Dataset
                adapter.Fill(ds);
                // Отображаем данные
                dataGridView3.DataSource = ds.Tables[0];
            }
        }

        private void tsbSearch_Click(object sender, EventArgs e)
        {
            // Сбор данных для поиска
            columnForSearch = tscbColumn1.Text;
            logicOperator = tscbLogicOperator1.Text;
            valueForSearch = tscbValue1.Text;

            string connectionString = @"Data Source=QWIBERN-NB;Initial Catalog=AA;Integrated Security=True;Pooling=False";
            sql = "SELECT * FROM Employee WHERE " + columnForSearch + " " + logicOperator + " '" + valueForSearch + "';";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                // Создаем объект Dataset
                DataSet ds = new DataSet();
                // Заполняем Dataset
                adapter.Fill(ds);
                // Отображаем данные
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void toolStripButton1_Click_2(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=QWIBERN-NB;Initial Catalog=AA;Integrated Security=True;Pooling=False";
            sql = "SELECT * FROM Employee";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                // Создаем объект Dataset
                DataSet ds = new DataSet();
                // Заполняем Dataset
                adapter.Fill(ds);
                // Отображаем данные
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void tsbWriteScrtipt_Click(object sender, EventArgs e)
        {
            WriteScriptsForm writeScriptsForm = new WriteScriptsForm();
            writeScriptsForm.Show();
        }

        private void toolStripButton19_Click_1(object sender, EventArgs e)
        {
            // Сбор данных для поиска
            columnForSearch = toolStripComboBox3.Text;
            logicOperator = toolStripComboBox4.Text;
            valueForSearch = toolStripTextBox4.Text;

            string connectionString = @"Data Source=QWIBERN-NB;Initial Catalog=AA;Integrated Security=True;Pooling=False";
            sql = "SELECT * FROM ServiceDB WHERE " + columnForSearch + " " + logicOperator + " '" + valueForSearch + "';";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                // Создаем объект Dataset
                DataSet ds = new DataSet();
                // Заполняем Dataset
                adapter.Fill(ds);
                // Отображаем данные
                dataGridView3.DataSource = ds.Tables[0];
            }
        }

        private void toolStripButton20_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=QWIBERN-NB;Initial Catalog=AA;Integrated Security=True;Pooling=False";
            sql = "SELECT * FROM ServiceDB";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                // Создаем объект Dataset
                DataSet ds = new DataSet();
                // Заполняем Dataset
                adapter.Fill(ds);
                // Отображаем данные
                dataGridView3.DataSource = ds.Tables[0];
            }
        }

        private void toolStripButton21_Click(object sender, EventArgs e)
        {
            WriteScriptsForm writeScriptsForm = new WriteScriptsForm();
            writeScriptsForm.Show();
        }

        private void toolStripButton28_Click(object sender, EventArgs e)
        {
            this.ordersTableAdapter.Update(this.aADataSet6.Orders);
        }

        private void toolStripButton29_Click(object sender, EventArgs e)
        {
            // Сбор данных для поиска
            columnForSearch = toolStripComboBox5.Text;
            logicOperator = toolStripComboBox6.Text;
            valueForSearch = toolStripTextBox6.Text;

            string connectionString = @"Data Source=QWIBERN-NB;Initial Catalog=AA;Integrated Security=True;Pooling=False";
            sql = "SELECT * FROM Orders WHERE " + columnForSearch + " " + logicOperator + " '" + valueForSearch + "';";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                // Создаем объект Dataset
                DataSet ds = new DataSet();
                // Заполняем Dataset
                adapter.Fill(ds);
                // Отображаем данные
                dataGridView4.DataSource = ds.Tables[0];
            }
        }

        private void toolStripButton30_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=QWIBERN-NB;Initial Catalog=AA;Integrated Security=True;Pooling=False";
            sql = "SELECT * FROM Orders";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                // Создаем объект Dataset
                DataSet ds = new DataSet();
                // Заполняем Dataset
                adapter.Fill(ds);
                // Отображаем данные
                dataGridView4.DataSource = ds.Tables[0];
            }
        }

        private void toolStripButton31_Click(object sender, EventArgs e)
        {
            WriteScriptsForm writeScriptsForm = new WriteScriptsForm();
            writeScriptsForm.Show();
        }

        private void bRestore_Click(object sender, EventArgs e)
        {
            string i = MessageBox.Show("Восстановить?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
            if (i == "Yes")
            {
                string connectionString = @"Data Source=QWIBERN-NB;Initial Catalog=AA;Integrated Security=True;Pooling=False";
                sql = "use master; RESTORE DATABASE [AA] FROM DISK = N'AA.bak' WITH  FILE = 1,  NOUNLOAD,  REPLACE,  STATS = 10";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    // Создаем объект DataAdapter
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                    // Создаем объект Dataset
                    DataSet ds = new DataSet();
                    // Заполняем Dataset
                    adapter.Fill(ds);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int a1, a2, a3, b1, b2, b3;
            string a4, a5;
            string[] a6 = new string[] { "Разработка", "Отправка", "Обработка", "Завершено", "В процессе" };

            string connectionString = @"Data Source=QWIBERN-NB;Initial Catalog=AA;Integrated Security=True;Pooling=False";

            for (int i = 0; i < 200; i++)
            {

                a1 = rnd.Next(1, 19);
                a2 = rnd.Next(1, 10);
                a3 = rnd.Next(1, 10);
                b1 = rnd.Next(1, 31);
                b2 = rnd.Next(1, 13);
                b3 = rnd.Next(2018, 2021);
                a4 = b1 + "." + b2 + "." + b3;
                a5 = a6[rnd.Next(0, 5)];

                
                sql = "use AA; insert into Orders(IdЗаказчик, idУслуги, IdСотрудник, ДатаЗаказа, Процесс) values (" + a1 +", " + a2 + ", " + a3 + ", '" + a4 +"', '" + a5 + "');";
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        // Создаем объект DataAdapter
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                        // Создаем объект Dataset
                        DataSet ds = new DataSet();
                        // Заполняем Dataset
                        adapter.Fill(ds);
                        // Отображаем данные
                        dataGridView4.DataSource = ds.Tables[0];
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string connectionString = @"Data Source=QWIBERN-NB;Initial Catalog=AA;Integrated Security=True;Pooling=False";

            string[,] a0 = new string[,] { 
                { "Султаматов", "Витамбиева", "Давлетгереев", "Масхадов", "Хункаров", "Селиханова", "Айбертаев", "Нуцалов", "Батаев", "Пашаев" },
                { "Хамзат", "Марха", "Рахим", "Курбан", "Мовсар", "Седа", "Акрам", "Шамиль", "Адлан", "Керим" },
                { "Давлетгереевич", "Султановна", "Асхабович", "Лечиевич", "Русланович", "Арслановна", "Магомедович", "Идрисович", "Ахмадович", "Русланович"},
                { "улица Тотурбиева, 100, Хасавюрт", "улица А.И. Исмаилова, 43", "Первомайская улица, 21", "улица А.И. Исмаилова, 17", "улица Чкалова, 34", "улица Хачилаева, 14", "улица Казбекова, 6", "Спортивный переулок, 10", "Инженерный переулок, 1А", "Заречная улица, 9В"}
            };
            string a1, a2, a3, a5, a6;
            int a4, a7;
            int num;

            for (int i = 0; i < 40; i++)
            {
                a1 = a0[0, rnd.Next(0, 10)];
                a2 = a0[1, rnd.Next(0, 10)];
                a3 = a0[2, rnd.Next(0, 10)];
                a5 = a0[3, rnd.Next(0, 10)];
                a4 = rnd.Next(18, 40);
                num = rnd.Next(3546367, 9893315);
                a6 = "8928" + num;
                a7 = rnd.Next(12354, 325235);

                try
                {
                    sql = "use AA; insert into Customer(Фамилия, Имя, Отчество, Возраст, Адрес, НомерТел, ЭлПочта) values ('" + a1 + "', '" + a2 + "', '" + a3 + "', '" + a4 + "', '" + a5 + "', '" + a6 + "', '" + a7 + "');";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        // Создаем объект DataAdapter
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                        // Создаем объект Dataset
                        DataSet ds = new DataSet();
                        // Заполняем Dataset
                        adapter.Fill(ds);
                        // Отображаем данные
                        dataGridView2.DataSource = ds.Tables[0];
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void tsbSave_Click_1(object sender, EventArgs e)
        {
            this.employeeTableAdapter.Update(this.aADataSet.Employee);

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string connectionString = @"Data Source=QWIBERN-NB;Initial Catalog=AA;Integrated Security=True;Pooling=False";

            string[,] a0 = new string[,] {
                { "Султаматов", "Витамбиева", "Давлетгереев", "Масхадов", "Хункаров", "Селиханова", "Айбертаев", "Нуцалов", "Батаев", "Пашаев" },
                { "Хамзат", "Марха", "Рахим", "Курбан", "Мовсар", "Седа", "Акрам", "Шамиль", "Адлан", "Керим" },
                { "Indoor маркетинг", "Организация Event мероприятий", "Безадресная рассылка по почтовым ящикам", "Звездный гость", "Трейд-маркетинг", "Мерчандайзинг", "Ростовая кукла", "Изготовление и размещение наружной рекламы", "Изготовление и размещение радиороликов", "Реклама в интернете"},
                { "В процессе", "В разработке", "Завершено", "Обработка", "В ожидании", "Планировка", "Установка", "Изготовление", "Активный", "Приостановлен"},
                { "500000", "345000", "10000", "800000", "100000", "128000", "30000", "200000", "150000", "360000"}
            };
            string a1, a2, a3, a5, a6, a7;
            int a4, b1, b2, b3, c1, c2, c3;

            for (int i = 0; i < 135; i++)
            {
                a1 = a0[0, rnd.Next(0, 10)];
                a2 = a0[1, rnd.Next(0, 10)];
                a3 = a0[2, rnd.Next(0, 10)];
                a4 = Convert.ToInt32(a0[4, rnd.Next(0, 10)]);
                b1 = rnd.Next(1, 31);
                b2 = rnd.Next(1, 13);
                b3 = rnd.Next(2018, 2020);
                a5 = b1 + "." + b2 + "." + b3;
                c1 = rnd.Next(1, 31);
                c2 = rnd.Next(1, 13);
                c3 = rnd.Next(2018, 2021);
                a6 = c1 + "." + c2 + "." + c3;
                a7 = a0[3, rnd.Next(0, 10)];

                try
                {
                    sql = "use AA; insert into Orders(ФамилияЗаказчика, ИмяЗаказчика, НаименованиеЗаказа, Цена, ДатаЗаказа, ДатаОкончания, Процесс) values ('" + a1 + "', '" + a2 + "', '" + a3 + "', '" + a4 + "', '" + a5 + "', '" + a6 + "', '" + a7 + "');";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        // Создаем объект DataAdapter
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                        // Создаем объект Dataset
                        DataSet ds = new DataSet();
                        // Заполняем Dataset
                        adapter.Fill(ds);
                        // Отображаем данные
                        dataGridView4.DataSource = ds.Tables[0];
                    }
                }
                catch (Exception ex)
                {
                    //string o = MessageBox.Show(ex.ToString(), "dgdg", MessageBoxButtons.YesNo).ToString();
                    //if (o == "Yes")
                    //    Application.Exit();
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aADataSet6.Orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.aADataSet6.Orders);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aADataSet5.Orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.aADataSet6.Orders);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aADataSet3.ServiceDB". При необходимости она может быть перемещена или удалена.
            this.serviceDBTableAdapter1.Fill(this.aADataSet3.ServiceDB);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aADataSet2.ServiceDB". При необходимости она может быть перемещена или удалена.
            this.serviceDBTableAdapter.Fill(this.aADataSet2.ServiceDB);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aADataSet1.Customer". При необходимости она может быть перемещена или удалена.
            this.customerTableAdapter.Fill(this.aADataSet1.Customer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aADataSet.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.aADataSet.Employee);

            for (int i = 0; dataGridView1.Columns.Count > i; i++)
            {
                tscbColumn1.Items.Add(dataGridView1.Columns[i].HeaderCell.Value);
            }

            for (int i = 0; dataGridView2.Columns.Count > i; i++)
            {
                toolStripComboBox1.Items.Add(dataGridView2.Columns[i].HeaderCell.Value);
            }

            for (int i = 0; dataGridView3.Columns.Count > i; i++)
            {
                toolStripComboBox3.Items.Add(dataGridView3.Columns[i].HeaderCell.Value);
            }

            for (int i = 0; dataGridView4.Columns.Count > i; i++)
            {
                toolStripComboBox5.Items.Add(dataGridView4.Columns[i].HeaderCell.Value);
            }

            // Значения по умолчанию для combobox
            tscbColumn1.SelectedIndex = 0;
            tscbLogicOperator1.SelectedIndex = 0;
            toolStripComboBox1.SelectedIndex = 0;
            toolStripComboBox2.SelectedIndex = 0;
            toolStripComboBox3.SelectedIndex = 0;
            toolStripComboBox4.SelectedIndex = 0;
            toolStripComboBox5.SelectedIndex = 0;
            toolStripComboBox6.SelectedIndex = 0;

            File.Delete(@"D:\Programs\Microsoft\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\Backup\AA.bak");

            string connectionString = @"Data Source=QWIBERN-NB;Initial Catalog=AA;Integrated Security=True;Pooling=False";
            sql = "BACKUP DATABASE AA TO DISK = 'AA.bak'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                // Создаем объект Dataset
                DataSet ds = new DataSet();
                // Заполняем Dataset
                adapter.Fill(ds);
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            // Открытие окна о программе
            About about = new About();
            about.ShowDialog();
        }

        private void toolStripBSearch_Click(object sender, EventArgs e)
        {
            // Сбор данных для поиска
            columnForSearch = tscbColumn1.Text;
            logicOperator = tscbLogicOperator1.Text;
            valueForSearch = tscbValue1.Text;

            string connectionString = @"Data Source=QWIBERN-NB;Initial Catalog=AA;Integrated Security=True;Pooling=False";
            sql = "SELECT * FROM Employee WHERE " + columnForSearch + " " + logicOperator + " '" + valueForSearch + "';";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                // Создаем объект Dataset
                DataSet ds = new DataSet();
                // Заполняем Dataset
                adapter.Fill(ds);
                // Отображаем данные
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
    }
}
