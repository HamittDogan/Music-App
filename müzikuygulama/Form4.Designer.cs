
namespace müzikuygulama
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sanatciIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanatciAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanatciÜlkesiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableSanatciBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.prolab3DataSet3 = new müzikuygulama.prolab3DataSet3();
            this.prolab3DataSet2 = new müzikuygulama.prolab3DataSet2();
            this.tableSanatciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_SanatciTableAdapter = new müzikuygulama.prolab3DataSet2TableAdapters.Table_SanatciTableAdapter();
            this.table_SanatciTableAdapter1 = new müzikuygulama.prolab3DataSet3TableAdapters.Table_SanatciTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableSanatciBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prolab3DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prolab3DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableSanatciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Arial Black", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(47, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sanatçı Adı";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Arial Black", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(38, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sanatçı Ülkesi";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox1.Font = new System.Drawing.Font("Arial Black", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(261, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 33);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox2.Font = new System.Drawing.Font("Arial Black", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(261, 150);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(204, 33);
            this.textBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Arial Black", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(661, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 64);
            this.button1.TabIndex = 4;
            this.button1.Text = "EKLE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Arial Black", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(661, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 67);
            this.button2.TabIndex = 5;
            this.button2.Text = "SİL";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button3.Font = new System.Drawing.Font("Arial Black", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(661, 223);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 69);
            this.button3.TabIndex = 6;
            this.button3.Text = "GÜNCELLE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button4.Font = new System.Drawing.Font("Arial Black", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(661, 298);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(161, 68);
            this.button4.TabIndex = 7;
            this.button4.Text = "LİSTELE";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Jokerman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(126, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(592, 38);
            this.label3.TabIndex = 8;
            this.label3.Text = "SANATÇI İŞLEMLERİNE HOŞGELDİNİZ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Arial Black", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(581, 349);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SANATÇILAR";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sanatciIDDataGridViewTextBoxColumn,
            this.sanatciAdiDataGridViewTextBoxColumn,
            this.sanatciÜlkesiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableSanatciBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(575, 317);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // sanatciIDDataGridViewTextBoxColumn
            // 
            this.sanatciIDDataGridViewTextBoxColumn.DataPropertyName = "SanatciID";
            this.sanatciIDDataGridViewTextBoxColumn.HeaderText = "SanatciID";
            this.sanatciIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sanatciIDDataGridViewTextBoxColumn.Name = "sanatciIDDataGridViewTextBoxColumn";
            this.sanatciIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sanatciIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // sanatciAdiDataGridViewTextBoxColumn
            // 
            this.sanatciAdiDataGridViewTextBoxColumn.DataPropertyName = "SanatciAdi";
            this.sanatciAdiDataGridViewTextBoxColumn.HeaderText = "SanatciAdi";
            this.sanatciAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sanatciAdiDataGridViewTextBoxColumn.Name = "sanatciAdiDataGridViewTextBoxColumn";
            this.sanatciAdiDataGridViewTextBoxColumn.Width = 125;
            // 
            // sanatciÜlkesiDataGridViewTextBoxColumn
            // 
            this.sanatciÜlkesiDataGridViewTextBoxColumn.DataPropertyName = "SanatciÜlkesi";
            this.sanatciÜlkesiDataGridViewTextBoxColumn.HeaderText = "SanatciÜlkesi";
            this.sanatciÜlkesiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sanatciÜlkesiDataGridViewTextBoxColumn.Name = "sanatciÜlkesiDataGridViewTextBoxColumn";
            this.sanatciÜlkesiDataGridViewTextBoxColumn.Width = 125;
            // 
            // tableSanatciBindingSource1
            // 
            this.tableSanatciBindingSource1.DataMember = "Table_Sanatci";
            this.tableSanatciBindingSource1.DataSource = this.prolab3DataSet3;
            // 
            // prolab3DataSet3
            // 
            this.prolab3DataSet3.DataSetName = "prolab3DataSet3";
            this.prolab3DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prolab3DataSet2
            // 
            this.prolab3DataSet2.DataSetName = "prolab3DataSet2";
            this.prolab3DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableSanatciBindingSource
            // 
            this.tableSanatciBindingSource.DataMember = "Table_Sanatci";
            this.tableSanatciBindingSource.DataSource = this.prolab3DataSet2;
            // 
            // table_SanatciTableAdapter
            // 
            this.table_SanatciTableAdapter.ClearBeforeFill = true;
            // 
            // table_SanatciTableAdapter1
            // 
            this.table_SanatciTableAdapter1.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button5.Font = new System.Drawing.Font("Arial Black", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(661, 372);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(161, 68);
            this.button5.TabIndex = 10;
            this.button5.Text = "TEMİZLE";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(854, 550);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableSanatciBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prolab3DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prolab3DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableSanatciBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private prolab3DataSet2 prolab3DataSet2;
        private System.Windows.Forms.BindingSource tableSanatciBindingSource;
        private prolab3DataSet2TableAdapters.Table_SanatciTableAdapter table_SanatciTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private prolab3DataSet3 prolab3DataSet3;
        private System.Windows.Forms.BindingSource tableSanatciBindingSource1;
        private prolab3DataSet3TableAdapters.Table_SanatciTableAdapter table_SanatciTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sanatciIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sanatciAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sanatciÜlkesiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button5;
    }
}