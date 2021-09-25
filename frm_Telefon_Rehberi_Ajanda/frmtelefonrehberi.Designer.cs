
namespace frm_Telefon_Rehberi_Ajanda
{
    partial class frmtelefonrehberi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmtelefonrehberi));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.telefon_rehberi_ajandaDataSet = new frm_Telefon_Rehberi_Ajanda.telefon_rehberi_ajandaDataSet();
            this.telefonrehberiajandaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new frm_Telefon_Rehberi_Ajanda.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAJanda = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblZaman = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.rdbİsim = new System.Windows.Forms.RadioButton();
            this.rdbSoyad = new System.Windows.Forms.RadioButton();
            this.rdbDogum = new System.Windows.Forms.RadioButton();
            this.rdbCinsiyet = new System.Windows.Forms.RadioButton();
            this.rdbİs = new System.Windows.Forms.RadioButton();
            this.rdbtelefon = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefon_rehberi_ajandaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonrehberiajandaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 28;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 125);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(1303, 471);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // telefon_rehberi_ajandaDataSet
            // 
            this.telefon_rehberi_ajandaDataSet.DataSetName = "telefon_rehberi_ajandaDataSet";
            this.telefon_rehberi_ajandaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // telefonrehberiajandaDataSetBindingSource
            // 
            this.telefonrehberiajandaDataSetBindingSource.DataSource = this.telefon_rehberi_ajandaDataSet;
            this.telefonrehberiajandaDataSetBindingSource.Position = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // btnAJanda
            // 
            this.btnAJanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAJanda.Location = new System.Drawing.Point(1188, 5);
            this.btnAJanda.Name = "btnAJanda";
            this.btnAJanda.Size = new System.Drawing.Size(113, 43);
            this.btnAJanda.TabIndex = 1;
            this.btnAJanda.Text = "Ajandayı Aç";
            this.btnAJanda.UseVisualStyleBackColor = true;
            this.btnAJanda.Click += new System.EventHandler(this.btnAJanda_Click222);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(962, 64);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(210, 24);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // lblZaman
            // 
            this.lblZaman.AutoSize = true;
            this.lblZaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblZaman.Location = new System.Drawing.Point(1068, 23);
            this.lblZaman.Name = "lblZaman";
            this.lblZaman.Size = new System.Drawing.Size(0, 24);
            this.lblZaman.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(704, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "Hava Durumu Bilgisi Göster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 125);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1301, 576);
            this.listBox1.TabIndex = 6;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView2.Location = new System.Drawing.Point(646, 274);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 7;
            this.dataGridView2.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "İli";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Durum";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Maksimum Sıcaklık";
            this.Column3.Name = "Column3";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.Location = new System.Drawing.Point(704, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(247, 43);
            this.button2.TabIndex = 4;
            this.button2.Text = "Yinele";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Cli);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button3.Location = new System.Drawing.Point(535, 47);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 43);
            this.button3.TabIndex = 4;
            this.button3.Text = "Kişi Kaydı Ekle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button1_Click1);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button4.Location = new System.Drawing.Point(535, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(146, 43);
            this.button4.TabIndex = 4;
            this.button4.Text = "Kişiyi Sil";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button1_Clidsdasdas);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button5.Location = new System.Drawing.Point(330, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(199, 43);
            this.button5.TabIndex = 4;
            this.button5.Text = "Radyo Menüsünü Aç";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button1_Clidsdasdassdasd);
            // 
            // txtAra
            // 
            this.txtAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAra.Location = new System.Drawing.Point(0, 4);
            this.txtAra.Multiline = true;
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(324, 43);
            this.txtAra.TabIndex = 8;
            this.toolTip1.SetToolTip(this.txtAra, "Aramak isteğiniz kelimeyi  yazınız");
            // 
            // btnAra
            // 
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAra.Location = new System.Drawing.Point(0, 51);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(199, 43);
            this.btnAra.TabIndex = 4;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.button1_Clidsdasdassdasdsadas);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.Location = new System.Drawing.Point(1188, 53);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(113, 43);
            this.button7.TabIndex = 1;
            this.button7.Text = "Geri Dön";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.btnAJanda_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 7000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // timer2
            // 
            this.timer2.Interval = 5000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // rdbİsim
            // 
            this.rdbİsim.AutoSize = true;
            this.rdbİsim.Location = new System.Drawing.Point(216, 51);
            this.rdbİsim.Name = "rdbİsim";
            this.rdbİsim.Size = new System.Drawing.Size(118, 17);
            this.rdbİsim.TabIndex = 9;
            this.rdbİsim.TabStop = true;
            this.rdbİsim.Text = "İsme Göre Kayıt Ara";
            this.rdbİsim.UseVisualStyleBackColor = true;
            // 
            // rdbSoyad
            // 
            this.rdbSoyad.AutoSize = true;
            this.rdbSoyad.Location = new System.Drawing.Point(379, 53);
            this.rdbSoyad.Name = "rdbSoyad";
            this.rdbSoyad.Size = new System.Drawing.Size(128, 17);
            this.rdbSoyad.TabIndex = 9;
            this.rdbSoyad.TabStop = true;
            this.rdbSoyad.Text = "Soyada göre kayıt ara";
            this.rdbSoyad.UseVisualStyleBackColor = true;
            // 
            // rdbDogum
            // 
            this.rdbDogum.AutoSize = true;
            this.rdbDogum.Location = new System.Drawing.Point(216, 101);
            this.rdbDogum.Name = "rdbDogum";
            this.rdbDogum.Size = new System.Drawing.Size(139, 17);
            this.rdbDogum.TabIndex = 9;
            this.rdbDogum.TabStop = true;
            this.rdbDogum.Text = "Doğum tarihine kayıt ara";
            this.rdbDogum.UseVisualStyleBackColor = true;
            this.rdbDogum.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rdbCinsiyet
            // 
            this.rdbCinsiyet.AutoSize = true;
            this.rdbCinsiyet.Location = new System.Drawing.Point(379, 102);
            this.rdbCinsiyet.Name = "rdbCinsiyet";
            this.rdbCinsiyet.Size = new System.Drawing.Size(134, 17);
            this.rdbCinsiyet.TabIndex = 9;
            this.rdbCinsiyet.TabStop = true;
            this.rdbCinsiyet.Text = "Cinsiyete göre kayıt ara";
            this.rdbCinsiyet.UseVisualStyleBackColor = true;
            // 
            // rdbİs
            // 
            this.rdbİs.AutoSize = true;
            this.rdbİs.Location = new System.Drawing.Point(379, 76);
            this.rdbİs.Name = "rdbİs";
            this.rdbİs.Size = new System.Drawing.Size(129, 17);
            this.rdbİs.TabIndex = 9;
            this.rdbİs.TabStop = true;
            this.rdbİs.Text = "İş no ya göre kayıt ara";
            this.rdbİs.UseVisualStyleBackColor = true;
            // 
            // rdbtelefon
            // 
            this.rdbtelefon.AutoSize = true;
            this.rdbtelefon.Location = new System.Drawing.Point(216, 76);
            this.rdbtelefon.Name = "rdbtelefon";
            this.rdbtelefon.Size = new System.Drawing.Size(157, 17);
            this.rdbtelefon.TabIndex = 9;
            this.rdbtelefon.TabStop = true;
            this.rdbtelefon.Text = "Telefon no ya göre kayıt ara";
            this.rdbtelefon.UseVisualStyleBackColor = true;
            // 
            // frmtelefonrehberi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 596);
            this.Controls.Add(this.rdbtelefon);
            this.Controls.Add(this.rdbİs);
            this.Controls.Add(this.rdbCinsiyet);
            this.Controls.Add(this.rdbDogum);
            this.Controls.Add(this.rdbSoyad);
            this.Controls.Add(this.rdbİsim);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblZaman);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btnAJanda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmtelefonrehberi";
            this.Text = "frmtelefonrehberi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmtelefonrehberi_FormClosing);
            this.Load += new System.EventHandler(this.frmtelefonrehberi_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmtelefonrehberi_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefon_rehberi_ajandaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonrehberiajandaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private telefon_rehberi_ajandaDataSet telefon_rehberi_ajandaDataSet;
        private System.Windows.Forms.BindingSource telefonrehberiajandaDataSetBindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.Button btnAJanda;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblZaman;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.RadioButton rdbİsim;
        private System.Windows.Forms.RadioButton rdbSoyad;
        private System.Windows.Forms.RadioButton rdbDogum;
        private System.Windows.Forms.RadioButton rdbCinsiyet;
        private System.Windows.Forms.RadioButton rdbİs;
        private System.Windows.Forms.RadioButton rdbtelefon;
    }
}