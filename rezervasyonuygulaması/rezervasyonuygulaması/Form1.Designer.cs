namespace rezervasyonuygulaması
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnkullanicikayit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnkullanicigiris = new System.Windows.Forms.Button();
            this.txtkullaniciad = new System.Windows.Forms.TextBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaShell;
            this.button1.Location = new System.Drawing.Point(713, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Snow;
            this.groupBox2.Controls.Add(this.btnkullanicikayit);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnkullanicigiris);
            this.groupBox2.Controls.Add(this.txtkullaniciad);
            this.groupBox2.Controls.Add(this.txtsifre);
            this.groupBox2.Location = new System.Drawing.Point(195, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(424, 518);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kullanıcı Giriş";
            // 
            // btnkullanicikayit
            // 
            this.btnkullanicikayit.Location = new System.Drawing.Point(12, 305);
            this.btnkullanicikayit.Name = "btnkullanicikayit";
            this.btnkullanicikayit.Size = new System.Drawing.Size(261, 41);
            this.btnkullanicikayit.TabIndex = 8;
            this.btnkullanicikayit.Text = "Kayıt olmak için tıklayınız...";
            this.btnkullanicikayit.UseVisualStyleBackColor = true;
            this.btnkullanicikayit.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(12, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 28);
            this.label5.TabIndex = 12;
            this.label5.Text = "Kullanıcı Şifre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(12, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 28);
            this.label6.TabIndex = 11;
            this.label6.Text = "Kullanıcı Adı:";
            // 
            // btnkullanicigiris
            // 
            this.btnkullanicigiris.BackColor = System.Drawing.Color.DarkGray;
            this.btnkullanicigiris.Location = new System.Drawing.Point(261, 218);
            this.btnkullanicigiris.Name = "btnkullanicigiris";
            this.btnkullanicigiris.Size = new System.Drawing.Size(126, 41);
            this.btnkullanicigiris.TabIndex = 10;
            this.btnkullanicigiris.Text = "Giriş Yap";
            this.btnkullanicigiris.UseVisualStyleBackColor = false;
            this.btnkullanicigiris.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtkullaniciad
            // 
            this.txtkullaniciad.Location = new System.Drawing.Point(168, 94);
            this.txtkullaniciad.Name = "txtkullaniciad";
            this.txtkullaniciad.Size = new System.Drawing.Size(238, 34);
            this.txtkullaniciad.TabIndex = 8;
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(168, 140);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(238, 34);
            this.txtsifre.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(751, 726);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private GroupBox groupBox2;
        private Label label5;
        private Label label6;
        private Button btnkullanicigiris;
        private TextBox txtkullaniciad;
        private TextBox txtsifre;
        private Button btnkullanicikayit;
    }
}