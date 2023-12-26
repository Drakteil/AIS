namespace Курсач_БД
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnОбновить = new System.Windows.Forms.Button();
            this.btnУдалить = new System.Windows.Forms.Button();
            this.btnДобавить = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtStolb1 = new System.Windows.Forms.TextBox();
            this.txtStolb2 = new System.Windows.Forms.TextBox();
            this.txtStolb3 = new System.Windows.Forms.TextBox();
            this.txtStolb4 = new System.Windows.Forms.TextBox();
            this.txtStolb6 = new System.Windows.Forms.TextBox();
            this.txtStolb7 = new System.Windows.Forms.TextBox();
            this.txtStolb8 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.txtStolb5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.checkedListBoxFilters = new System.Windows.Forms.CheckedListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnОбновить
            // 
            this.btnОбновить.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnОбновить.Location = new System.Drawing.Point(195, 609);
            this.btnОбновить.Name = "btnОбновить";
            this.btnОбновить.Size = new System.Drawing.Size(128, 50);
            this.btnОбновить.TabIndex = 1;
            this.btnОбновить.Text = "Обновить";
            this.btnОбновить.UseVisualStyleBackColor = true;
            this.btnОбновить.Click += new System.EventHandler(this.btnОбновить_Click);
            // 
            // btnУдалить
            // 
            this.btnУдалить.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnУдалить.Location = new System.Drawing.Point(370, 609);
            this.btnУдалить.Name = "btnУдалить";
            this.btnУдалить.Size = new System.Drawing.Size(128, 50);
            this.btnУдалить.TabIndex = 2;
            this.btnУдалить.Text = "Удалить";
            this.btnУдалить.UseVisualStyleBackColor = true;
            this.btnУдалить.Click += new System.EventHandler(this.btnУдалить_Click);
            // 
            // btnДобавить
            // 
            this.btnДобавить.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnДобавить.Location = new System.Drawing.Point(25, 609);
            this.btnДобавить.Name = "btnДобавить";
            this.btnДобавить.Size = new System.Drawing.Size(128, 50);
            this.btnДобавить.TabIndex = 3;
            this.btnДобавить.Text = "Добавить";
            this.btnДобавить.UseVisualStyleBackColor = true;
            this.btnДобавить.Click += new System.EventHandler(this.btnДобавить_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(409, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(871, 569);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtStolb1
            // 
            this.txtStolb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtStolb1.Location = new System.Drawing.Point(12, 26);
            this.txtStolb1.Multiline = true;
            this.txtStolb1.Name = "txtStolb1";
            this.txtStolb1.Size = new System.Drawing.Size(204, 34);
            this.txtStolb1.TabIndex = 5;
            // 
            // txtStolb2
            // 
            this.txtStolb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtStolb2.Location = new System.Drawing.Point(12, 86);
            this.txtStolb2.Multiline = true;
            this.txtStolb2.Name = "txtStolb2";
            this.txtStolb2.Size = new System.Drawing.Size(204, 31);
            this.txtStolb2.TabIndex = 6;
            // 
            // txtStolb3
            // 
            this.txtStolb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtStolb3.Location = new System.Drawing.Point(12, 150);
            this.txtStolb3.Multiline = true;
            this.txtStolb3.Name = "txtStolb3";
            this.txtStolb3.Size = new System.Drawing.Size(204, 31);
            this.txtStolb3.TabIndex = 7;
            // 
            // txtStolb4
            // 
            this.txtStolb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtStolb4.Location = new System.Drawing.Point(12, 228);
            this.txtStolb4.Multiline = true;
            this.txtStolb4.Name = "txtStolb4";
            this.txtStolb4.Size = new System.Drawing.Size(204, 34);
            this.txtStolb4.TabIndex = 8;
            // 
            // txtStolb6
            // 
            this.txtStolb6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtStolb6.Location = new System.Drawing.Point(12, 349);
            this.txtStolb6.Multiline = true;
            this.txtStolb6.Name = "txtStolb6";
            this.txtStolb6.Size = new System.Drawing.Size(204, 34);
            this.txtStolb6.TabIndex = 9;
            // 
            // txtStolb7
            // 
            this.txtStolb7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtStolb7.Location = new System.Drawing.Point(12, 411);
            this.txtStolb7.Multiline = true;
            this.txtStolb7.Name = "txtStolb7";
            this.txtStolb7.Size = new System.Drawing.Size(204, 34);
            this.txtStolb7.TabIndex = 10;
            // 
            // txtStolb8
            // 
            this.txtStolb8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtStolb8.Location = new System.Drawing.Point(12, 471);
            this.txtStolb8.Multiline = true;
            this.txtStolb8.Name = "txtStolb8";
            this.txtStolb8.Size = new System.Drawing.Size(204, 34);
            this.txtStolb8.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(222, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Столбец 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(222, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "Столбец 4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(266, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 24);
            this.label5.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(222, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 23);
            this.label6.TabIndex = 17;
            this.label6.Text = "Столбец 6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(222, 422);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 23);
            this.label7.TabIndex = 18;
            this.label7.Text = "Столбец 7";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(222, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Столбец 2";
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = null;
            // 
            // txtStolb5
            // 
            this.txtStolb5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtStolb5.Location = new System.Drawing.Point(12, 289);
            this.txtStolb5.Multiline = true;
            this.txtStolb5.Name = "txtStolb5";
            this.txtStolb5.Size = new System.Drawing.Size(204, 34);
            this.txtStolb5.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(222, 482);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 23);
            this.label8.TabIndex = 21;
            this.label8.Text = "Столбец 8";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(222, 300);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 23);
            this.label15.TabIndex = 22;
            this.label15.Text = "Столбец 5";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1298, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 29);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(420, 546);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 24);
            this.label10.TabIndex = 25;
            this.label10.Text = "\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(222, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "Столбец 1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(1336, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 23);
            this.label9.TabIndex = 28;
            this.label9.Text = "Сортировка ";
            // 
            // checkedListBoxFilters
            // 
            this.checkedListBoxFilters.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkedListBoxFilters.FormattingEnabled = true;
            this.checkedListBoxFilters.Location = new System.Drawing.Point(1298, 167);
            this.checkedListBoxFilters.Name = "checkedListBoxFilters";
            this.checkedListBoxFilters.Size = new System.Drawing.Size(196, 244);
            this.checkedListBoxFilters.TabIndex = 29;
            this.checkedListBoxFilters.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxFilters_ItemCheck);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 212);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(204, 20);
            this.dateTimePicker1.TabIndex = 30;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(170, 86);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(46, 31);
            this.comboBox2.TabIndex = 31;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(170, 150);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(46, 31);
            this.comboBox3.TabIndex = 32;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(1308, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(173, 23);
            this.label11.TabIndex = 33;
            this.label11.Text = "Выберите Таблицу";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 688);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.checkedListBoxFilters);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtStolb5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStolb8);
            this.Controls.Add(this.txtStolb7);
            this.Controls.Add(this.txtStolb6);
            this.Controls.Add(this.txtStolb4);
            this.Controls.Add(this.txtStolb3);
            this.Controls.Add(this.txtStolb2);
            this.Controls.Add(this.txtStolb1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnДобавить);
            this.Controls.Add(this.btnУдалить);
            this.Controls.Add(this.btnОбновить);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnОбновить;
        private System.Windows.Forms.Button btnУдалить;
        private System.Windows.Forms.Button btnДобавить;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtStolb1;
        private System.Windows.Forms.TextBox txtStolb2;
        private System.Windows.Forms.TextBox txtStolb3;
        private System.Windows.Forms.TextBox txtStolb4;
        private System.Windows.Forms.TextBox txtStolb6;
        private System.Windows.Forms.TextBox txtStolb7;
        private System.Windows.Forms.TextBox txtStolb8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
        private System.Windows.Forms.TextBox txtStolb5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckedListBox checkedListBoxFilters;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label11;
    }
}

