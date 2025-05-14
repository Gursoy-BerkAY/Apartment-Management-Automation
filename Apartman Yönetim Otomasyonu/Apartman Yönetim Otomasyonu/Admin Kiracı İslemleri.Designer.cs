namespace Apartman_Yönetim_Otomasyonu
{
    partial class Admin_Kiracı_İslemleri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kiracıIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kiracıAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kiracıSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kiracıTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kiracıTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daireNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odenenKiraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kiracıSifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kiraciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apartman_YonetimDataSet1 = new Apartman_Yönetim_Otomasyonu.Apartman_YonetimDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.apartman_YonetimDataSet = new Apartman_Yönetim_Otomasyonu.Apartman_YonetimDataSet();
            this.kiraciTableAdapter = new Apartman_Yönetim_Otomasyonu.Apartman_YonetimDataSetTableAdapters.KiraciTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiraciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartman_YonetimDataSet1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartman_YonetimDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 186);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlem";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Maaş Düzenle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(7, 96);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(186, 33);
            this.button5.TabIndex = 2;
            this.button5.Text = "Kiracıyı Düzenle";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 57);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(186, 33);
            this.button4.TabIndex = 1;
            this.button4.Text = "Kiracı Çıkar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(7, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(186, 33);
            this.button3.TabIndex = 0;
            this.button3.Text = "Kiracı Ekle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kiracıIDDataGridViewTextBoxColumn,
            this.kiracıAdDataGridViewTextBoxColumn,
            this.kiracıSoyadDataGridViewTextBoxColumn,
            this.kiracıTCDataGridViewTextBoxColumn,
            this.kiracıTelDataGridViewTextBoxColumn,
            this.daireNoDataGridViewTextBoxColumn,
            this.odenenKiraDataGridViewTextBoxColumn,
            this.kiracıSifreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kiraciBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(836, 240);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // kiracıIDDataGridViewTextBoxColumn
            // 
            this.kiracıIDDataGridViewTextBoxColumn.DataPropertyName = "Kiracı_ID";
            this.kiracıIDDataGridViewTextBoxColumn.HeaderText = "Kiracı_ID";
            this.kiracıIDDataGridViewTextBoxColumn.Name = "kiracıIDDataGridViewTextBoxColumn";
            this.kiracıIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kiracıAdDataGridViewTextBoxColumn
            // 
            this.kiracıAdDataGridViewTextBoxColumn.DataPropertyName = "Kiracı_Ad";
            this.kiracıAdDataGridViewTextBoxColumn.HeaderText = "Kiracı_Ad";
            this.kiracıAdDataGridViewTextBoxColumn.Name = "kiracıAdDataGridViewTextBoxColumn";
            // 
            // kiracıSoyadDataGridViewTextBoxColumn
            // 
            this.kiracıSoyadDataGridViewTextBoxColumn.DataPropertyName = "Kiracı_Soyad";
            this.kiracıSoyadDataGridViewTextBoxColumn.HeaderText = "Kiracı_Soyad";
            this.kiracıSoyadDataGridViewTextBoxColumn.Name = "kiracıSoyadDataGridViewTextBoxColumn";
            // 
            // kiracıTCDataGridViewTextBoxColumn
            // 
            this.kiracıTCDataGridViewTextBoxColumn.DataPropertyName = "Kiracı_TC";
            this.kiracıTCDataGridViewTextBoxColumn.HeaderText = "Kiracı_TC";
            this.kiracıTCDataGridViewTextBoxColumn.Name = "kiracıTCDataGridViewTextBoxColumn";
            // 
            // kiracıTelDataGridViewTextBoxColumn
            // 
            this.kiracıTelDataGridViewTextBoxColumn.DataPropertyName = "Kiracı_Tel";
            this.kiracıTelDataGridViewTextBoxColumn.HeaderText = "Kiracı_Tel";
            this.kiracıTelDataGridViewTextBoxColumn.Name = "kiracıTelDataGridViewTextBoxColumn";
            // 
            // daireNoDataGridViewTextBoxColumn
            // 
            this.daireNoDataGridViewTextBoxColumn.DataPropertyName = "Daire_No";
            this.daireNoDataGridViewTextBoxColumn.HeaderText = "Daire_No";
            this.daireNoDataGridViewTextBoxColumn.Name = "daireNoDataGridViewTextBoxColumn";
            // 
            // odenenKiraDataGridViewTextBoxColumn
            // 
            this.odenenKiraDataGridViewTextBoxColumn.DataPropertyName = "Odenen_Kira";
            this.odenenKiraDataGridViewTextBoxColumn.HeaderText = "Odenen_Kira";
            this.odenenKiraDataGridViewTextBoxColumn.Name = "odenenKiraDataGridViewTextBoxColumn";
            // 
            // kiracıSifreDataGridViewTextBoxColumn
            // 
            this.kiracıSifreDataGridViewTextBoxColumn.DataPropertyName = "Kiracı_Sifre";
            this.kiracıSifreDataGridViewTextBoxColumn.HeaderText = "Kiracı_Sifre";
            this.kiracıSifreDataGridViewTextBoxColumn.Name = "kiracıSifreDataGridViewTextBoxColumn";
            // 
            // kiraciBindingSource
            // 
            this.kiraciBindingSource.DataMember = "Kiraci";
            this.kiraciBindingSource.DataSource = this.apartman_YonetimDataSet1;
            // 
            // apartman_YonetimDataSet1
            // 
            this.apartman_YonetimDataSet1.DataSetName = "Apartman_YonetimDataSet";
            this.apartman_YonetimDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(230, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(618, 180);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bilgiler";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(280, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Kiraci Sifre";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(401, 72);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(113, 22);
            this.textBox7.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Odenen Kira";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(401, 15);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(113, 22);
            this.textBox5.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Daire No";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(401, 44);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(113, 22);
            this.textBox6.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(152, 77);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(113, 22);
            this.textBox3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kiraci Tel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kiraci Tc";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(152, 104);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(113, 22);
            this.textBox4.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kiraci Soyadi";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(152, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(113, 22);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kiraci Adi";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(152, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 22);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox8);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textBox9);
            this.groupBox3.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(854, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(347, 162);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kira";
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(188, 84);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(113, 22);
            this.textBox8.TabIndex = 19;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(67, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Temizlikçi";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(67, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Kapıcı";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(188, 56);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(113, 22);
            this.textBox9.TabIndex = 16;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(854, 198);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(347, 240);
            this.dataGridView2.TabIndex = 9;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // apartman_YonetimDataSet
            // 
            this.apartman_YonetimDataSet.DataSetName = "Apartman_YonetimDataSet";
            this.apartman_YonetimDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kiraciTableAdapter
            // 
            this.kiraciTableAdapter.ClearBeforeFill = true;
            // 
            // Admin_Kiracı_İslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Admin_Kiracı_İslemleri";
            this.Text = "Admin_Kiracı_İslemleri";
            this.Load += new System.EventHandler(this.Admin_Kiracı_İslemleri_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiraciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartman_YonetimDataSet1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartman_YonetimDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.DataGridView dataGridView2;
        private Apartman_YonetimDataSet apartman_YonetimDataSet;
        private Apartman_YonetimDataSet apartman_YonetimDataSet1;
        private System.Windows.Forms.BindingSource kiraciBindingSource;
        private Apartman_YonetimDataSetTableAdapters.KiraciTableAdapter kiraciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kiracıIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kiracıAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kiracıSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kiracıTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kiracıTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn daireNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odenenKiraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kiracıSifreDataGridViewTextBoxColumn;
    }
}