namespace Cronjob
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.data_platform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_isactive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_last_seen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_timeout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Platform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Başlık = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Durum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Getir Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(112, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Yemek Sepeti Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(264, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 29);
            this.button3.TabIndex = 2;
            this.button3.Text = "Trendyol Yemek Ekle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.data_platform,
            this.data_description,
            this.data_isactive,
            this.data_last_seen,
            this.data_timeout});
            this.dataGridView1.Location = new System.Drawing.Point(12, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(927, 421);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.UpdateApiKey);
            // 
            // data_platform
            // 
            this.data_platform.HeaderText = "data_platform";
            this.data_platform.MinimumWidth = 6;
            this.data_platform.Name = "data_platform";
            this.data_platform.Width = 125;
            // 
            // data_description
            // 
            this.data_description.HeaderText = "data_description";
            this.data_description.MinimumWidth = 6;
            this.data_description.Name = "data_description";
            this.data_description.Width = 300;
            // 
            // data_isactive
            // 
            this.data_isactive.HeaderText = "data_isactive";
            this.data_isactive.MinimumWidth = 6;
            this.data_isactive.Name = "data_isactive";
            this.data_isactive.Width = 125;
            // 
            // data_last_seen
            // 
            this.data_last_seen.HeaderText = "data_last_seen";
            this.data_last_seen.MinimumWidth = 6;
            this.data_last_seen.Name = "data_last_seen";
            this.data_last_seen.Width = 200;
            // 
            // data_timeout
            // 
            this.data_timeout.HeaderText = "data_timeout";
            this.data_timeout.MinimumWidth = 6;
            this.data_timeout.Name = "data_timeout";
            this.data_timeout.Width = 125;
            // 
            // Platform
            // 
            this.Platform.HeaderText = "Column1";
            this.Platform.MinimumWidth = 6;
            this.Platform.Name = "Platform";
            this.Platform.Width = 125;
            // 
            // Başlık
            // 
            this.Başlık.HeaderText = "Column2";
            this.Başlık.MinimumWidth = 6;
            this.Başlık.Name = "Başlık";
            this.Başlık.Width = 125;
            // 
            // Durum
            // 
            this.Durum.HeaderText = "Column3";
            this.Durum.MinimumWidth = 6;
            this.Durum.Name = "Durum";
            this.Durum.Width = 125;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(845, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 29);
            this.button4.TabIndex = 4;
            this.button4.Text = "Yenile";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 480);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sipariş Kontrol Sistemi (v1.0)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Platform;
        private DataGridViewTextBoxColumn Başlık;
        private DataGridViewTextBoxColumn Durum;
        private Button button4;
        private DataGridViewTextBoxColumn data_platform;
        private DataGridViewTextBoxColumn data_description;
        private DataGridViewTextBoxColumn data_isactive;
        private DataGridViewTextBoxColumn data_last_seen;
        private DataGridViewTextBoxColumn data_timeout;
    }
}