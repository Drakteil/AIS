using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Курсач_БД
{
    
    public partial class Form1: Form
    {
        private string строкаСоединения = @"Data Source=C:\ДБ\v1.db;Version=3;";
        Dictionary<string, List<string>> tableFilters = new Dictionary<string, List<string>>();
        private Dictionary<int, object> rowidValues = new Dictionary<int, object>();
        private Dictionary<string, string[]> tableColumnMappings = new Dictionary<string, string[]>
        {
             { "Инструменты", new string[] { "IDИнструмента", "Наименование", "Год", "Фирма", "Модель", "Класс", "Страна", "Стоимость", "СерийныйНомер" } },
             { "Сотрудники", new string[] { "IDСотрудника", "Фамилия", "Имя", "Отчество", "ДатаРождения", "Телефон", "НомерБейджа" } },
             { "Клиенты", new string[] { "IDКлиента", "Фамилия", "Имя", "Отчество", "ДатаРождения", "Телефон", "ЛичныйКод" } },
             { "Заказы", new string[] { "IDЗаказа", "Количество", "IdИнструмента", "НомерЗаказа" } },
             { "ЗаказыПродажи", new string[] { "IDЗаписи", "НомерЗаписи", "IdПродажи", "IdЗаказа" } },
             { "Продажи", new string[] { "IDПродажи", "НомерПродажи", "IdСотрудника" , "IdКлиента", "Итого" } },
        };


        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(InitializeDataGridView);
            comboBox1.SelectedIndexChanged += new EventHandler(UpdateLabels);

        }

        private void UpdateLabels(object sender, EventArgs e)
        {
            string selectedTable = comboBox1.SelectedItem.ToString();
            if (tableColumnMappings.ContainsKey(selectedTable))
            {
                string[] columnNames = tableColumnMappings[selectedTable];
                Dictionary<string, Label> labelDictionary = new Dictionary<string, Label>
                {
                    { "СерийныйНомер", label8 },
                    { "НомерБейджа", label6 },
                    { "ЛичныйКод", label6 },
                    { "НомерЗаказа", label3 },
                    { "НомерЗаписи", label1 },
                    { "НомерПродажи", label1 }
                };

                foreach (var entry in labelDictionary)
                {
                    entry.Value.ForeColor = Color.Black; // Сначала устанавливаем для всех label черный цвет
                }

                foreach (var columnName in columnNames)
                {
                    if (labelDictionary.ContainsKey(columnName))
                    {
                        labelDictionary[columnName].ForeColor = Color.Red; // Устанавливаем красный цвет только для нужных label
                    }
                }
                label1.Text = columnNames.Length > 0 ?(columnNames[0].StartsWith("ID") ? " " : columnNames[0]) : " ";
                label1.Text = columnNames.Length > 1 ? columnNames[1] : " ";
                label2.Text = columnNames.Length > 2 ? columnNames[2] : " ";
                label3.Text = columnNames.Length > 3 ? columnNames[3] : " ";
                label4.Text = columnNames.Length > 4 ? columnNames[4] : " ";
                label15.Text = columnNames.Length > 5 ? columnNames[5] : " ";
                label6.Text = columnNames.Length > 6 ? columnNames[6] : " ";
                label7.Text = columnNames.Length > 7 ? columnNames[7] : " ";
                label8.Text = columnNames.Length > 8 ? columnNames[8] : " ";

                txtStolb1.Visible = columnNames.Length > 0 && !columnNames[0].StartsWith("ID");
                txtStolb1.Visible = columnNames.Length > 1;
                txtStolb2.Visible = columnNames.Length > 2;
                txtStolb3.Visible = columnNames.Length > 3;
                txtStolb4.Visible = columnNames.Length > 4;
                txtStolb5.Visible = columnNames.Length > 5;
                txtStolb6.Visible = columnNames.Length > 6;
                txtStolb7.Visible = columnNames.Length > 7;
                txtStolb8.Visible = columnNames.Length > 8;


            }
        }

        private void ВыполнитьЗапрос(string запрос)
        {
            try
            {
                using (SQLiteConnection соединение = new SQLiteConnection(строкаСоединения))
                {
                    соединение.Open();
                    using (SQLiteCommand команда = new SQLiteCommand(запрос, соединение))
                    {
                        команда.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
        
        private void btnДобавить_Click(object sender, EventArgs e)
        {
            string tableName = comboBox1.SelectedItem.ToString();
            string запрос = "";
            
            switch (tableName)
            {
                case "Инструменты":
                    string наименование = txtStolb1.Text;
                    int год = int.Parse(txtStolb2.Text);
                    string фирма = txtStolb3.Text;
                    string модель = txtStolb4.Text;
                    string класс = txtStolb5.Text;
                    string страна = txtStolb6.Text;
                    decimal стоимость = decimal.Parse(txtStolb7.Text);
                    float серийный_номер = float.Parse(txtStolb8.Text);
                    запрос = $"INSERT INTO Инструменты (Наименование, Год, Фирма, Модель, Класс, Страна, Стоимость, СерийныйНомер)" +
                             $"VALUES ('{наименование}', {год}, '{фирма}', '{модель}', '{класс}', '{страна}', {стоимость}, {серийный_номер})";
                    break;
                case "Сотрудники":
                    string фамилия_сотрудника = txtStolb1.Text;
                    string имя_сотрудника = txtStolb2.Text;
                    string отчество_сотрудника = txtStolb3.Text;
                    DateTime датаРождения_сотрудника = dateTimePicker1.Value;
                    string форматированнаяДата_сотрудника = датаРождения_сотрудника.ToString("yyyy-MM-dd"); // Форматируем дату для использования в SQL-запросе
                    string телефон_сотрудника = txtStolb5.Text;
                    int номер_бейджа = int.Parse(txtStolb6.Text);
                    запрос = $"INSERT INTO Сотрудники (Фамилия, Имя, Отчество, Телефон, ДатаРождения, НомерБейджа) " +
                             $"VALUES ('{фамилия_сотрудника}', '{имя_сотрудника}', '{отчество_сотрудника}', '{телефон_сотрудника}', '{форматированнаяДата_сотрудника}', {номер_бейджа})";
                    break;
                case "Клиенты":
                    string фамилия_клиента = txtStolb1.Text;
                    string имя_клиента = txtStolb2.Text;
                    string отчество_клиента = txtStolb3.Text;
                    DateTime датаРождения_клиента = dateTimePicker1.Value;
                    string форматированнаяДата_клиента = датаРождения_клиента.ToString("yyyy-MM-dd"); // Форматируем дату для использования в SQL-запросе
                    string телефон_клиента = txtStolb5.Text;
                    int личный_код = int.Parse(txtStolb6.Text);
                    запрос = $"INSERT INTO Клиенты (Фамилия, Имя, Отчество, Телефон, ДатаРождения, ЛичныйКод) " +
                             $"VALUES ('{фамилия_клиента}', '{имя_клиента}', '{отчество_клиента}', '{телефон_клиента}', '{форматированнаяДата_клиента}', {личный_код})";
                    break;
                case "Заказы":
                    int idИнструмента = int.Parse(txtStolb2.Text);
                    int количество = int.Parse(txtStolb1.Text);
                    int номер_заказа = int.Parse(txtStolb3.Text);
                    запрос = $"INSERT INTO Заказы (IdИнструмента, Количество, НомерЗаказа) " +
                             $"VALUES ({idИнструмента}, {количество}, {номер_заказа})";
                    break;
                case "ЗаказыПродажи":
                    int номер_записи = int.Parse(txtStolb1.Text);
                    int idПродажи = int.Parse(txtStolb2.Text);
                    int idЗаказа = int.Parse(txtStolb3.Text);
                    запрос = $"INSERT INTO ЗаказыПродажи (НомерЗаписи, IdПродажи, IdЗаказа) " +
                             $"VALUES ({номер_записи},{idПродажи}, {idЗаказа})";
                    break;
                case "Продажи":
                    int номер_продажи = int.Parse(txtStolb1.Text);
                    int idСотрудника = int.Parse(txtStolb2.Text);
                    int idКлиента = int.Parse(txtStolb3.Text);
                    decimal итого = decimal.Parse(txtStolb4.Text);
                    запрос = $"INSERT INTO Продажи (НомерПродажи, IdСотрудника, IdКлиента, Итого) " +
                             $"VALUES ({номер_продажи},{idСотрудника}, {idКлиента}, {итого})";
                    break;
                default:
                    break;
            }
            txtStolb1.Text = "";
            txtStolb2.Text = "";
            txtStolb3.Text = "";
            txtStolb4.Text = "";
            txtStolb5.Text = "";
            txtStolb6.Text = "";
            txtStolb7.Text = "";
            txtStolb8.Text = "";
            ВыполнитьЗапрос(запрос);
            LoadData(tableName);
        }

        private void btnУдалить_Click(object sender, EventArgs e)
        {
            string tableName = comboBox1.SelectedItem.ToString();

            if (dataGridView1.SelectedCells.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedCells[0].RowIndex;

                if (rowidValues.ContainsKey(rowIndex))
                {
                    int rowid = Convert.ToInt32(rowidValues[rowIndex]);

                    using (SQLiteConnection connection = new SQLiteConnection(строкаСоединения))
                    {
                        connection.Open();
                        string query = $"DELETE FROM {tableName} WHERE rowid = @rowid";

                        using (SQLiteCommand command = new SQLiteCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@rowid", rowid);
                            command.ExecuteNonQuery();
                        }
                    }

                    LoadData(tableName); // После удаления обновляем отображение данных
                }
                else
                {
                    MessageBox.Show("Ошибка: Не удалось получить значение rowid для выбранной строки");
                }
            }
            else
            {
                MessageBox.Show("Ошибка: Сначала выберите строку для удаления");
            }
        }

        private void btnОбновить_Click(object sender, EventArgs e)
        {
            string tableName = comboBox1.SelectedItem.ToString();
            string запрос = "";

            switch (tableName)
            {
                case "Инструменты":
                    string наименование = txtStolb1.Text;
                    float год = float.Parse(txtStolb2.Text);
                    string фирма = txtStolb3.Text;
                    string модель = txtStolb4.Text;
                    string класс = txtStolb5.Text;
                    string страна = txtStolb6.Text;
                    decimal стоимость = decimal.Parse(txtStolb7.Text);
                    int серийный_номер = int.Parse(txtStolb8.Text);
                    запрос = $"UPDATE Инструменты SET Наименование = '{наименование}', Год = {год}, Фирма = '{фирма}', Модель = '{модель}', " +
                             $"Класс = '{класс}', Страна = '{страна}', Стоимость = {стоимость} " +
                             $"WHERE СерийныйНомер = {серийный_номер}";
                    break;
                case "Сотрудники":
                    string фамилия_сотрудника = txtStolb1.Text;
                    string имя_сотрудника = txtStolb2.Text;
                    string отчество_сотрудника = txtStolb3.Text;
                    DateTime датаРождения_сотрудника = dateTimePicker1.Value;
                    string форматированнаяДата_сотрудника = датаРождения_сотрудника.ToString("yyyy-MM-dd"); // Форматируем дату для использования в SQL-запросе
                    string телефон_сотрудника = txtStolb5.Text;
                    int номер_бейджа = int.Parse(txtStolb6.Text);
                    запрос = $"UPDATE Сотрудники SET Фамилия = '{фамилия_сотрудника}', Имя = '{имя_сотрудника}', Отчество = '{отчество_сотрудника}'," +
                             $"Телефон = '{телефон_сотрудника}', ДатаРождения = '{форматированнаяДата_сотрудника}' " +
                             $"WHERE НомерБейджа = {номер_бейджа}";

                    break;
                case "Клиенты":
                    string фамилия_клиента = txtStolb1.Text;
                    string имя_клиента = txtStolb2.Text;
                    string отчество_клиента = txtStolb3.Text;
                    DateTime датаРождения_клиента = dateTimePicker1.Value;
                    string форматированнаяДата_клиента = датаРождения_клиента.ToString("yyyy-MM-dd"); // Форматируем дату для использования в SQL-запросе
                    string телефон_клиента = txtStolb5.Text;
                    int личный_код_клиента = int.Parse(txtStolb6.Text);
                    запрос = $"UPDATE Сотрудники SET Фамилия = '{фамилия_клиента}', Имя = '{имя_клиента}', Отчество = '{отчество_клиента}'," +
                             $"Телефон = '{телефон_клиента}', ДатаРождения = '{форматированнаяДата_клиента}' " +
                             $"WHERE ЛичныйКод = {личный_код_клиента}";

                    break;
                case "Заказы":
                    int idИнструмента = int.Parse(txtStolb1.Text);
                    int количество = int.Parse(txtStolb2.Text);
                    int номер_заказа = int.Parse(txtStolb3.Text);
                    запрос = $"UPDATE Заказы SET IdИнструмента = {idИнструмента}, Количество = {количество} " +
                             $"WHERE НомерЗаказа = {номер_заказа}";

                    break;
                case "ЗаказыПродажи":
                    int номер_записи = int.Parse(txtStolb1.Text);
                    int idПродажи = int.Parse(txtStolb2.Text);
                    int idЗаказа = int.Parse(txtStolb3.Text);
                    запрос = $"UPDATE ЗаказыПродажи SET IdПродажи = {idПродажи}, IdЗаказа = '{idЗаказа}' " +
                             $"WHERE НомерЗаписи = {номер_записи} ";

                    break;
                case "Продажи":
                    int номер_продажи = int.Parse(txtStolb1.Text);
                    int idСотрудника = int.Parse(txtStolb2.Text);
                    int idКлиента = int.Parse(txtStolb3.Text);
                    decimal итого = decimal.Parse(txtStolb4.Text);
                    запрос = $"UPDATE Продажи SET IdСотрудника = '{idСотрудника}', IdКлиента = '{idКлиента}', Итого = '{итого}' " +
                             $"WHERE НомерПродажи = {номер_продажи}";

                    break;
                default:
                    break;
            }
            txtStolb1.Text = "";
            txtStolb2.Text = "";
            txtStolb3.Text = "";
            txtStolb4.Text = "";
            txtStolb5.Text = "";
            txtStolb6.Text = "";
            txtStolb7.Text = "";
            txtStolb8.Text = "";
            ВыполнитьЗапрос(запрос);
            LoadData(tableName);
        }
        
        private void InitializeDataGridView(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            LoadData("Инструменты");
            LoadData("Сотрудники");
            LoadData("Клиенты");
            LoadData("Заказы");
            LoadData("ЗаказыПродажи");
            LoadData("Продажи");
            checkedListBoxFilters.ItemCheck += checkedListBoxFilters_ItemCheck;
        }
        
        private void LoadData(string tableName)
        {

            try
            {
                using (SQLiteConnection соединение = new SQLiteConnection(строкаСоединения))
                {
                    соединение.Open();
                    string запрос = $"SELECT * FROM {tableName}";
                    using (SQLiteDataAdapter адаптер = new SQLiteDataAdapter(запрос, соединение))
                    {
                        DataTable dataTable = new DataTable();
                        адаптер.Fill(dataTable);

                        // Удаляем столбец ID, если он существует
                        if (dataTable.Columns.Count > 0 && dataTable.Columns[0].ColumnName.StartsWith("ID"))
                        {
                            dataTable.Columns[0].ColumnMapping = MappingType.Hidden; // Скрываем первый столбец с ID
                        }

                        

                        // Отображаем данные в dataGridView1

                        dataGridView1.DataSource = dataTable;
                        dataGridView1.Visible = true; 

                    }
                }

            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Ошибка при выполнении запроса: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
        }

        private void LoadRowIdValues(string tableName)
        {
            rowidValues.Clear();
            using (SQLiteConnection соединение = new SQLiteConnection(строкаСоединения))
            {
                соединение.Open();
                string запрос = $"SELECT rowid FROM {tableName} ORDER BY rowid ASC";
                using (SQLiteCommand команда = new SQLiteCommand(запрос, соединение))
                {
                    using (SQLiteDataReader reader = команда.ExecuteReader())
                    {
                        int index = 0;
                        while (reader.Read())
                        {
                            rowidValues[index] = reader[0];
                            index++;
                        }
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                string selectedTableName = comboBox1.SelectedItem.ToString();
                if (!rowidValues.Any() || rowidValues.Count != dataGridView1.Rows.Count)
                {
                    LoadRowIdValues(selectedTableName);
                }

                if (rowidValues.ContainsKey(e.RowIndex))
                {
                    label10.Text = "ID Строки: " + rowidValues[e.RowIndex].ToString();
                }
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateTablesComboBox(); // Вызов метода PopulateTablesComboBox
        }

        private List<string> GetTableFields(string tableName)
        {
            List<string> fields = new List<string>();

            using (SQLiteConnection connection = new SQLiteConnection(строкаСоединения))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand($"PRAGMA table_info({tableName})", connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string fieldName = reader["name"].ToString();
                            if (!fieldName.StartsWith("ID"))
                            {
                                fields.Add(fieldName);
                            }
                        }
                    }
                }
            }
            return fields;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBoxFilters.Items.Clear(); // Очищаем предыдущие параметры
            string selectedTable = comboBox1.SelectedItem.ToString();
            if (selectedTable == "Сотрудники" || selectedTable == "Клиенты")
            {
                // Показать dateTimePicker1, если выбрана таблица Сотрудники или Клиенты
                dateTimePicker1.Visible = true;
            }
            else
            {
                // Скрыть dateTimePicker1 для других таблиц
                dateTimePicker1.Visible = false;
            }
            {
                if (selectedTable == "ЗаказыПродажи")
                {
                    // Загрузить данные в comboBox2 и comboBox3 на основе внешних ключей
                    LoadForeignKeyData(comboBox2, "IdПродажи", "Продажи", "IDПродажи", new[] { "НомерПродажи", "IdСотрудника", "IdКлиента", "Итого" });
                    LoadForeignKeyData(comboBox3, "IdЗаказа", "Заказы", "IDЗаказа", new[] { "Количество", "IdИнструмента", "НомерЗаказа" });

                    // Отображение или скрытие comboBox2 и comboBox3 в соответствии с вашими требованиями
                    comboBox2.Visible = true;
                    comboBox3.Visible = true;

                    comboBox2.DropDownWidth = 2000; // Замените 300 на нужное вам значение
                    comboBox3.DropDownWidth = 2000; // Замените 300 на нужное вам значение
                }
                else if (selectedTable == "Заказы")
                {
                    // Загрузить данные в comboBox2 на основе внешнего ключа
                    LoadForeignKeyData(comboBox2, "IdИнструмента", "Инструменты", "IDИнструмента", new[] { "Наименование", "Год", "Фирма", "Модель", "Класс", "Страна", "Стоимость", "СерийныйНомер" });

                    comboBox2.Visible = true;
                    comboBox3.Visible = false;

                    // Установка ширины выпадающего списка для comboBox2
                    comboBox2.DropDownWidth = 2000; // Замените 300 на нужное вам значение
                }
                else if (selectedTable == "Продажи")
                {
                    // Загрузить данные в comboBox2 и comboBox3 на основе внешних ключей
                    LoadForeignKeyData(comboBox2, "IdСотрудника", "Сотрудники", "IDСотрудника", new[] { "Фамилия", "Имя", "Отчество", "ДатаРождения", "Телефон", "НомерБейджа" });
                    LoadForeignKeyData(comboBox3, "IdКлиента", "Клиенты", "IDКлиента", new[] { "Фамилия", "Имя", "Отчество", "ДатаРождения", "Телефон", "ЛичныйКод"});

                    comboBox2.Visible = true;
                    comboBox3.Visible = true;

                    comboBox2.DropDownWidth = 2000; // Замените 300 на нужное вам значение
                    comboBox3.DropDownWidth = 2000; // Замените 300 на нужное вам значение

                }
                else
                {
                    // Скрыть comboBox2 и comboBox3 для остальных таблиц
                    comboBox2.Visible = false;
                    comboBox3.Visible = false;
                }
            }
        
            // Получаем список полей (параметров) выбранной таблицы из базы данных или другого источника
            List<string> tableFields = GetTableFields(selectedTable); // Метод для получения списка полей выбранной таблицы

            // Добавляем поля в список параметров фильтрации в элементе CheckedLisBox
            foreach (string field in tableFields)
            {
                checkedListBoxFilters.Items.Add(field);
            }

            txtStolb2.Text = "";
            txtStolb3.Text = "";

            LoadData(selectedTable);
        }

       
        private void PopulateTablesComboBox()
        {
            using (SQLiteConnection соединение = new SQLiteConnection(строкаСоединения))
            {
                try
                {
                    соединение.Open();
                    DataTable tables = соединение.GetSchema("Tables");
                    foreach (DataRow row in tables.Rows)
                    {
                        string tableName = row["TABLE_NAME"].ToString();
                        comboBox1.Items.Add(tableName);
                    }
                    // Удаление "sqlite_sequence" из ComboBox1, если он присутствует
                    if (comboBox1.Items.Contains("sqlite_sequence"))
                    {
                        comboBox1.Items.Remove("sqlite_sequence");
                    }
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Ошибка при загрузке таблиц: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Произошла ошибка: " + ex.Message);
                }
            }
        }

        private void ApplySortingToAllTables(Dictionary<string, List<string>> filters)
        {
            foreach (var table in filters)
            {
                string tableName = table.Key;
                List<string> columns = table.Value;
                string sortOrder = "ASC"; // Здесь можно установить желаемый порядок сортировки

                LoadFilteredData(tableName, columns, sortOrder);

            }

        }

        private void LoadFilteredData(string tableName, List<string> columns, string sortOrder)
        {
            string query = $"SELECT rowid, * FROM {tableName}"; // Добавляем выборку rowid

            // Добавление сортировки
            if (columns.Any() && !string.IsNullOrEmpty(sortOrder))
            {
                query += " ORDER BY " + string.Join(", ", columns) + " " + sortOrder;
            }

            // Применение фильтра к dataGridView1
            using (SQLiteConnection connection = new SQLiteConnection(строкаСоединения))
            {
                connection.Open();
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                {
                    DataTable filteredTable = new DataTable();
                    adapter.Fill(filteredTable);
                    // Очистка данных в DataGridView перед загрузкой новых данных
                    dataGridView1.DataSource = null;
                    dataGridView1.Columns.Clear();

                    // Загрузка новых данных в DataGridView
                    dataGridView1.DataSource = filteredTable;

                }

            }
        }

        private void checkedListBoxFilters_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string selectedTable = comboBox1.SelectedItem.ToString();
            var selectedFilters = checkedListBoxFilters.CheckedItems.Cast<string>().ToList();

            if (!tableFilters.ContainsKey(selectedTable))
            {
                tableFilters[selectedTable] = new List<string>();
            }

            // Снимаем галочки со всех элементов кроме выбранного
            for (int i = 0; i < checkedListBoxFilters.Items.Count; i++)
            {
                if (i != e.Index)
                {
                    checkedListBoxFilters.SetItemChecked(i, false);
                }
            }

            if (e.NewValue == CheckState.Checked)
            {
                tableFilters[selectedTable].Clear(); // Очищаем список фильтров
                tableFilters[selectedTable].Add(checkedListBoxFilters.Items[e.Index].ToString()); // Добавляем новый выбранный фильтр
            }
            else
            {
                tableFilters[selectedTable].Remove(checkedListBoxFilters.Items[e.Index].ToString());
            }

            // Применить сортировку к данным в таблице
            ApplySortingToAllTables(tableFilters);
            HideIdColumns(selectedTable); // Скрыть столбцы с ID
        }

        private void HideIdColumns(string tableName)
        {
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.Name.StartsWith("ID") && column.Visible)
                {
                    column.Visible = false;
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtStolb4.Text = dateTimePicker1.Value.ToString("dd.MM.yyyy");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedValue != null)
            {
                txtStolb2.Text = comboBox2.SelectedValue.ToString();
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedValue != null)
            {
                txtStolb3.Text = comboBox3.SelectedValue.ToString();
            }
        }

        // Метод для загрузки данных в comboBox на основе внешнего ключа
        private void LoadForeignKeyData(ComboBox comboBox, string childKey, string parentTable, string primaryKey, string[] columns)
        {
            // Получить данные из базы данных на основе внешнего ключа с описанием
            Dictionary<string, string> data = GetDataUsingForeignKeyWithDescription(childKey, parentTable, primaryKey, columns);

            // Привязать данные к comboBox
            comboBox.DataSource = new BindingSource(data, null);
            comboBox.DisplayMember = "Value";
            comboBox.ValueMember = "Key";
        }

        // Метод для получения данных из базы данных на основе внешнего ключа
        private Dictionary<string, string> GetDataUsingForeignKeyWithDescription(string childKey, string parentTable, string primaryKey, string[] columns)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(строкаСоединения))
                {
                    connection.Open();
                    string query = $"SELECT {primaryKey}, {string.Join(",", columns)} FROM {parentTable}";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string id = reader[primaryKey].ToString();
                                string description = string.Join(" | ", columns.Select((col, i) => $"{col}: {reader[i + 1]}")); // Формирование описания на основе названий столбцов
                                data.Add(id, description);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }

            return data;
        }

    }
}
