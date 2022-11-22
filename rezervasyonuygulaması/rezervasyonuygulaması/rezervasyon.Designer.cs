namespace rezervasyonuygulaması
{
    partial class rezervasyon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rezervasyon));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbnereden = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbnereye = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbkonaklama = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pickergidis = new System.Windows.Forms.DateTimePicker();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cmbulasim = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.pickerdonus = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.IndianRed;
            this.groupBox1.Controls.Add(this.cmbnereden);
            this.groupBox1.Location = new System.Drawing.Point(40, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 160);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NEREDEN";
            // 
            // cmbnereden
            // 
            this.cmbnereden.FormattingEnabled = true;
            this.cmbnereden.Items.AddRange(new object[] {
            "İzmir",
            "Manisa",
            "Uşak",
            "Ankara",
            "İstanbul",
            "Rize",
            "Diyarbakır",
            "Mardin",
            "Şanlıurfa"});
            this.cmbnereden.Location = new System.Drawing.Point(28, 59);
            this.cmbnereden.Name = "cmbnereden";
            this.cmbnereden.Size = new System.Drawing.Size(345, 36);
            this.cmbnereden.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.IndianRed;
            this.groupBox2.Controls.Add(this.cmbnereye);
            this.groupBox2.Location = new System.Drawing.Point(569, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(487, 160);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "NEREYE";
            // 
            // cmbnereye
            // 
            this.cmbnereye.FormattingEnabled = true;
            this.cmbnereye.Items.AddRange(new object[] {
            "Fethiye",
            "Datça",
            "Alaçatı",
            "Çeşme"});
            this.cmbnereye.Location = new System.Drawing.Point(16, 59);
            this.cmbnereye.Name = "cmbnereye";
            this.cmbnereye.Size = new System.Drawing.Size(340, 36);
            this.cmbnereye.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.IndianRed;
            this.groupBox3.Controls.Add(this.cmbkonaklama);
            this.groupBox3.Location = new System.Drawing.Point(40, 267);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(487, 165);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "KONAKLAMA";
            // 
            // cmbkonaklama
            // 
            this.cmbkonaklama.FormattingEnabled = true;
            this.cmbkonaklama.Items.AddRange(new object[] {
            "Otel",
            "Çadır"});
            this.cmbkonaklama.Location = new System.Drawing.Point(36, 62);
            this.cmbkonaklama.Name = "cmbkonaklama";
            this.cmbkonaklama.Size = new System.Drawing.Size(337, 36);
            this.cmbkonaklama.TabIndex = 1;
            this.cmbkonaklama.SelectedIndexChanged += new System.EventHandler(this.cmbkonaklama_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.IndianRed;
            this.groupBox4.Controls.Add(this.pickergidis);
            this.groupBox4.Location = new System.Drawing.Point(40, 487);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(487, 165);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "GİDİŞ TARİHİ";
            // 
            // pickergidis
            // 
            this.pickergidis.Location = new System.Drawing.Point(16, 60);
            this.pickergidis.Name = "pickergidis";
            this.pickergidis.Size = new System.Drawing.Size(340, 34);
            this.pickergidis.TabIndex = 0;
            // 
            // btnkaydet
            // 
            this.btnkaydet.BackColor = System.Drawing.Color.IndianRed;
            this.btnkaydet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnkaydet.Location = new System.Drawing.Point(721, 658);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(204, 41);
            this.btnkaydet.TabIndex = 1;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.UseVisualStyleBackColor = false;
            this.btnkaydet.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1069, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 41);
            this.button2.TabIndex = 2;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.IndianRed;
            this.groupBox5.Controls.Add(this.cmbulasim);
            this.groupBox5.Location = new System.Drawing.Point(569, 267);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(487, 158);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "ULAŞIM";
            // 
            // cmbulasim
            // 
            this.cmbulasim.FormattingEnabled = true;
            this.cmbulasim.Items.AddRange(new object[] {
            "Uçak",
            "Otobüs"});
            this.cmbulasim.Location = new System.Drawing.Point(36, 50);
            this.cmbulasim.Name = "cmbulasim";
            this.cmbulasim.Size = new System.Drawing.Size(337, 36);
            this.cmbulasim.TabIndex = 4;
            this.cmbulasim.SelectedIndexChanged += new System.EventHandler(this.cmbulasim_SelectedIndexChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.IndianRed;
            this.groupBox6.Controls.Add(this.pickerdonus);
            this.groupBox6.Location = new System.Drawing.Point(569, 487);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(487, 165);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "DÖNÜŞ TARİHİ";
            // 
            // pickerdonus
            // 
            this.pickerdonus.Location = new System.Drawing.Point(16, 60);
            this.pickerdonus.Name = "pickerdonus";
            this.pickerdonus.Size = new System.Drawing.Size(340, 34);
            this.pickerdonus.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(40, 682);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(355, 49);
            this.button1.TabIndex = 5;
            this.button1.Text = "Rezervasyon İptali";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // rezervasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1129, 743);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "rezervasyon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "rezervasyon";
            this.Load += new System.EventHandler(this.rezervasyon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private ComboBox cmbnereden;
        private ComboBox cmbnereye;
        private ComboBox cmbkonaklama;
        private DateTimePicker pickergidis;
        private Button btnkaydet;
        private Button button2;
        private GroupBox groupBox5;
        private ComboBox cmbulasim;
        private GroupBox groupBox6;
        private DateTimePicker pickerdonus;
        private Button button1;
    }
}