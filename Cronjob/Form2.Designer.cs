namespace Cronjob
{
    partial class Form2
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
            this.getir_form_description = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.getir_form_timeout = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.getir_form_productposturl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.getir_form_orderposturl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.getir_form_appsecretkey = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.getir_form_restaurantsecretkey = new System.Windows.Forms.TextBox();
            this.getir_form_isactive = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.getir_form_supplierid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // getir_form_description
            // 
            this.getir_form_description.Location = new System.Drawing.Point(12, 47);
            this.getir_form_description.Margin = new System.Windows.Forms.Padding(12);
            this.getir_form_description.Name = "getir_form_description";
            this.getir_form_description.Size = new System.Drawing.Size(376, 27);
            this.getir_form_description.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Başlık";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sorgu Süresi";
            // 
            // getir_form_timeout
            // 
            this.getir_form_timeout.Location = new System.Drawing.Point(408, 47);
            this.getir_form_timeout.Margin = new System.Windows.Forms.Padding(12);
            this.getir_form_timeout.Name = "getir_form_timeout";
            this.getir_form_timeout.Size = new System.Drawing.Size(87, 27);
            this.getir_form_timeout.TabIndex = 3;
            this.getir_form_timeout.Text = "60";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ürün Post URL";
            // 
            // getir_form_productposturl
            // 
            this.getir_form_productposturl.Location = new System.Drawing.Point(12, 124);
            this.getir_form_productposturl.Margin = new System.Windows.Forms.Padding(12);
            this.getir_form_productposturl.Name = "getir_form_productposturl";
            this.getir_form_productposturl.Size = new System.Drawing.Size(776, 27);
            this.getir_form_productposturl.TabIndex = 5;
            this.getir_form_productposturl.Text = "https://";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sipariş Post URL";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(776, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SubmitForm);
            // 
            // getir_form_orderposturl
            // 
            this.getir_form_orderposturl.Location = new System.Drawing.Point(12, 201);
            this.getir_form_orderposturl.Margin = new System.Windows.Forms.Padding(12);
            this.getir_form_orderposturl.Name = "getir_form_orderposturl";
            this.getir_form_orderposturl.Size = new System.Drawing.Size(776, 27);
            this.getir_form_orderposturl.TabIndex = 8;
            this.getir_form_orderposturl.Text = "https://";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 243);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "appSecretKey";
            // 
            // getir_form_appsecretkey
            // 
            this.getir_form_appsecretkey.Location = new System.Drawing.Point(12, 278);
            this.getir_form_appsecretkey.Margin = new System.Windows.Forms.Padding(12);
            this.getir_form_appsecretkey.Name = "getir_form_appsecretkey";
            this.getir_form_appsecretkey.Size = new System.Drawing.Size(374, 27);
            this.getir_form_appsecretkey.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(408, 243);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "restaurantSecretKey";
            // 
            // getir_form_restaurantsecretkey
            // 
            this.getir_form_restaurantsecretkey.Location = new System.Drawing.Point(408, 278);
            this.getir_form_restaurantsecretkey.Margin = new System.Windows.Forms.Padding(12);
            this.getir_form_restaurantsecretkey.Name = "getir_form_restaurantsecretkey";
            this.getir_form_restaurantsecretkey.Size = new System.Drawing.Size(380, 27);
            this.getir_form_restaurantsecretkey.TabIndex = 12;
            // 
            // getir_form_isactive
            // 
            this.getir_form_isactive.AutoSize = true;
            this.getir_form_isactive.Location = new System.Drawing.Point(12, 320);
            this.getir_form_isactive.Name = "getir_form_isactive";
            this.getir_form_isactive.Size = new System.Drawing.Size(62, 24);
            this.getir_form_isactive.TabIndex = 13;
            this.getir_form_isactive.Text = "Aktif";
            this.getir_form_isactive.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(505, 50);
            this.label7.Margin = new System.Windows.Forms.Padding(12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Saniye";
            // 
            // getir_form_supplierid
            // 
            this.getir_form_supplierid.Enabled = false;
            this.getir_form_supplierid.Location = new System.Drawing.Point(581, 50);
            this.getir_form_supplierid.Margin = new System.Windows.Forms.Padding(12);
            this.getir_form_supplierid.Name = "getir_form_supplierid";
            this.getir_form_supplierid.Size = new System.Drawing.Size(87, 27);
            this.getir_form_supplierid.TabIndex = 15;
            this.getir_form_supplierid.Text = "---";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(581, 15);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Restoran Id";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 404);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.getir_form_supplierid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.getir_form_isactive);
            this.Controls.Add(this.getir_form_restaurantsecretkey);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.getir_form_appsecretkey);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.getir_form_orderposturl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.getir_form_productposturl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.getir_form_timeout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.getir_form_description);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Getir Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox getir_form_description;
        private Label label1;
        private Label label2;
        private TextBox getir_form_timeout;
        private Label label3;
        private TextBox getir_form_productposturl;
        private Label label4;
        private Button button1;
        private TextBox getir_form_orderposturl;
        private Label label5;
        private TextBox getir_form_appsecretkey;
        private Label label6;
        private TextBox getir_form_restaurantsecretkey;
        private CheckBox getir_form_isactive;
        private Label label7;
        private TextBox getir_form_supplierid;
        private Label label8;
    }
}