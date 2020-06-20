namespace EnergyMonitor
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.humidity_lbl = new System.Windows.Forms.Label();
            this.windSpeed_lbl = new System.Windows.Forms.Label();
            this.temperature_lbl = new System.Windows.Forms.Label();
            this.currentWeather_lbl = new System.Windows.Forms.Label();
            this.weather_pictureBox = new System.Windows.Forms.PictureBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.gr_use_btn = new System.Windows.Forms.Button();
            this.wm_use_btn = new System.Windows.Forms.Button();
            this.sp_use_btn = new System.Windows.Forms.Button();
            this.gr_tbx = new System.Windows.Forms.TextBox();
            this.wm_tbx = new System.Windows.Forms.TextBox();
            this.sp_tbx = new System.Windows.Forms.TextBox();
            this.gr_lbl = new System.Windows.Forms.Label();
            this.gr_prb = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gr_chb = new System.Windows.Forms.CheckBox();
            this.wm_chb = new System.Windows.Forms.CheckBox();
            this.sp_chb = new System.Windows.Forms.CheckBox();
            this.wm_lbl = new System.Windows.Forms.Label();
            this.sp_lbl = new System.Windows.Forms.Label();
            this.wm_prb = new System.Windows.Forms.ProgressBar();
            this.sp_prb = new System.Windows.Forms.ProgressBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.weatherInformation_tbx = new System.Windows.Forms.RichTextBox();
            this.currentCity_lbl = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.energyProduced_lbl = new System.Windows.Forms.Label();
            this.energyConsumed_lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weather_pictureBox)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(76, 22);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(835, 464);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(120)))));
            this.tabPage3.Controls.Add(this.humidity_lbl);
            this.tabPage3.Controls.Add(this.windSpeed_lbl);
            this.tabPage3.Controls.Add(this.temperature_lbl);
            this.tabPage3.Controls.Add(this.currentWeather_lbl);
            this.tabPage3.Controls.Add(this.weather_pictureBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Size = new System.Drawing.Size(827, 438);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Main Page";
            // 
            // humidity_lbl
            // 
            this.humidity_lbl.AutoSize = true;
            this.humidity_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.humidity_lbl.ForeColor = System.Drawing.Color.White;
            this.humidity_lbl.Location = new System.Drawing.Point(387, 181);
            this.humidity_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.humidity_lbl.Name = "humidity_lbl";
            this.humidity_lbl.Size = new System.Drawing.Size(88, 24);
            this.humidity_lbl.TabIndex = 4;
            this.humidity_lbl.Text = "Humidity:";
            // 
            // windSpeed_lbl
            // 
            this.windSpeed_lbl.AutoSize = true;
            this.windSpeed_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.windSpeed_lbl.ForeColor = System.Drawing.Color.White;
            this.windSpeed_lbl.Location = new System.Drawing.Point(387, 141);
            this.windSpeed_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.windSpeed_lbl.Name = "windSpeed_lbl";
            this.windSpeed_lbl.Size = new System.Drawing.Size(120, 24);
            this.windSpeed_lbl.TabIndex = 3;
            this.windSpeed_lbl.Text = "Wind Speed:";
            // 
            // temperature_lbl
            // 
            this.temperature_lbl.AutoSize = true;
            this.temperature_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.temperature_lbl.ForeColor = System.Drawing.Color.White;
            this.temperature_lbl.Location = new System.Drawing.Point(387, 98);
            this.temperature_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.temperature_lbl.Name = "temperature_lbl";
            this.temperature_lbl.Size = new System.Drawing.Size(124, 24);
            this.temperature_lbl.TabIndex = 2;
            this.temperature_lbl.Text = "Temperature:";
            // 
            // currentWeather_lbl
            // 
            this.currentWeather_lbl.AutoSize = true;
            this.currentWeather_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentWeather_lbl.ForeColor = System.Drawing.Color.White;
            this.currentWeather_lbl.Location = new System.Drawing.Point(387, 58);
            this.currentWeather_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentWeather_lbl.Name = "currentWeather_lbl";
            this.currentWeather_lbl.Size = new System.Drawing.Size(153, 24);
            this.currentWeather_lbl.TabIndex = 1;
            this.currentWeather_lbl.Text = "Current Weather:";
            // 
            // weather_pictureBox
            // 
            this.weather_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("weather_pictureBox.Image")));
            this.weather_pictureBox.Location = new System.Drawing.Point(23, 37);
            this.weather_pictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.weather_pictureBox.Name = "weather_pictureBox";
            this.weather_pictureBox.Size = new System.Drawing.Size(345, 188);
            this.weather_pictureBox.TabIndex = 0;
            this.weather_pictureBox.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(120)))));
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.energyConsumed_lbl);
            this.tabPage1.Controls.Add(this.energyProduced_lbl);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.gr_use_btn);
            this.tabPage1.Controls.Add(this.wm_use_btn);
            this.tabPage1.Controls.Add(this.sp_use_btn);
            this.tabPage1.Controls.Add(this.gr_tbx);
            this.tabPage1.Controls.Add(this.wm_tbx);
            this.tabPage1.Controls.Add(this.sp_tbx);
            this.tabPage1.Controls.Add(this.gr_lbl);
            this.tabPage1.Controls.Add(this.gr_prb);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.wm_lbl);
            this.tabPage1.Controls.Add(this.sp_lbl);
            this.tabPage1.Controls.Add(this.wm_prb);
            this.tabPage1.Controls.Add(this.sp_prb);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(827, 438);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Control Panel";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 5);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 45);
            this.button1.TabIndex = 19;
            this.button1.Text = "AutomaticControl";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gr_use_btn
            // 
            this.gr_use_btn.Location = new System.Drawing.Point(702, 294);
            this.gr_use_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gr_use_btn.Name = "gr_use_btn";
            this.gr_use_btn.Size = new System.Drawing.Size(105, 45);
            this.gr_use_btn.TabIndex = 18;
            this.gr_use_btn.Text = "Use";
            this.gr_use_btn.UseVisualStyleBackColor = true;
            this.gr_use_btn.Click += new System.EventHandler(this.use_btn_Click);
            // 
            // wm_use_btn
            // 
            this.wm_use_btn.Location = new System.Drawing.Point(702, 242);
            this.wm_use_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.wm_use_btn.Name = "wm_use_btn";
            this.wm_use_btn.Size = new System.Drawing.Size(105, 45);
            this.wm_use_btn.TabIndex = 17;
            this.wm_use_btn.Text = "Use";
            this.wm_use_btn.UseVisualStyleBackColor = true;
            this.wm_use_btn.Click += new System.EventHandler(this.use_btn_Click);
            // 
            // sp_use_btn
            // 
            this.sp_use_btn.Location = new System.Drawing.Point(702, 193);
            this.sp_use_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sp_use_btn.Name = "sp_use_btn";
            this.sp_use_btn.Size = new System.Drawing.Size(105, 45);
            this.sp_use_btn.TabIndex = 16;
            this.sp_use_btn.Text = "Use";
            this.sp_use_btn.UseVisualStyleBackColor = true;
            this.sp_use_btn.Click += new System.EventHandler(this.use_btn_Click);
            // 
            // gr_tbx
            // 
            this.gr_tbx.Enabled = false;
            this.gr_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gr_tbx.Location = new System.Drawing.Point(460, 293);
            this.gr_tbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gr_tbx.Name = "gr_tbx";
            this.gr_tbx.Size = new System.Drawing.Size(51, 46);
            this.gr_tbx.TabIndex = 12;
            this.gr_tbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // wm_tbx
            // 
            this.wm_tbx.Enabled = false;
            this.wm_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wm_tbx.Location = new System.Drawing.Point(460, 243);
            this.wm_tbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.wm_tbx.Name = "wm_tbx";
            this.wm_tbx.Size = new System.Drawing.Size(51, 46);
            this.wm_tbx.TabIndex = 11;
            this.wm_tbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sp_tbx
            // 
            this.sp_tbx.Enabled = false;
            this.sp_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sp_tbx.Location = new System.Drawing.Point(460, 193);
            this.sp_tbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sp_tbx.Name = "sp_tbx";
            this.sp_tbx.Size = new System.Drawing.Size(51, 46);
            this.sp_tbx.TabIndex = 10;
            this.sp_tbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gr_lbl
            // 
            this.gr_lbl.AutoSize = true;
            this.gr_lbl.Font = new System.Drawing.Font("Segoe MDL2 Assets", 16.2F);
            this.gr_lbl.Location = new System.Drawing.Point(38, 306);
            this.gr_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gr_lbl.Name = "gr_lbl";
            this.gr_lbl.Size = new System.Drawing.Size(48, 22);
            this.gr_lbl.TabIndex = 9;
            this.gr_lbl.Text = "Grids";
            // 
            // gr_prb
            // 
            this.gr_prb.Location = new System.Drawing.Point(189, 294);
            this.gr_prb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gr_prb.Name = "gr_prb";
            this.gr_prb.Size = new System.Drawing.Size(266, 45);
            this.gr_prb.TabIndex = 8;
            this.gr_prb.Value = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gr_chb);
            this.groupBox1.Controls.Add(this.wm_chb);
            this.groupBox1.Controls.Add(this.sp_chb);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(514, 166);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(174, 201);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // gr_chb
            // 
            this.gr_chb.AutoSize = true;
            this.gr_chb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gr_chb.Location = new System.Drawing.Point(25, 143);
            this.gr_chb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gr_chb.Name = "gr_chb";
            this.gr_chb.Size = new System.Drawing.Size(94, 22);
            this.gr_chb.TabIndex = 2;
            this.gr_chb.Text = "Turned off";
            this.gr_chb.UseVisualStyleBackColor = true;
            this.gr_chb.Click += new System.EventHandler(this.checkBox_Checked);
            // 
            // wm_chb
            // 
            this.wm_chb.AutoSize = true;
            this.wm_chb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wm_chb.Location = new System.Drawing.Point(25, 89);
            this.wm_chb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.wm_chb.Name = "wm_chb";
            this.wm_chb.Size = new System.Drawing.Size(94, 22);
            this.wm_chb.TabIndex = 1;
            this.wm_chb.Text = "Turned off";
            this.wm_chb.UseVisualStyleBackColor = true;
            this.wm_chb.Click += new System.EventHandler(this.checkBox_Checked);
            // 
            // sp_chb
            // 
            this.sp_chb.AutoSize = true;
            this.sp_chb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sp_chb.Location = new System.Drawing.Point(25, 34);
            this.sp_chb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sp_chb.Name = "sp_chb";
            this.sp_chb.Size = new System.Drawing.Size(94, 22);
            this.sp_chb.TabIndex = 0;
            this.sp_chb.Text = "Turned off";
            this.sp_chb.UseVisualStyleBackColor = true;
            this.sp_chb.Click += new System.EventHandler(this.checkBox_Checked);
            // 
            // wm_lbl
            // 
            this.wm_lbl.AutoSize = true;
            this.wm_lbl.Font = new System.Drawing.Font("Segoe MDL2 Assets", 16.2F);
            this.wm_lbl.Location = new System.Drawing.Point(38, 254);
            this.wm_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.wm_lbl.Name = "wm_lbl";
            this.wm_lbl.Size = new System.Drawing.Size(76, 22);
            this.wm_lbl.TabIndex = 3;
            this.wm_lbl.Text = "Windmills";
            // 
            // sp_lbl
            // 
            this.sp_lbl.AutoSize = true;
            this.sp_lbl.Font = new System.Drawing.Font("Segoe MDL2 Assets", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sp_lbl.Location = new System.Drawing.Point(38, 200);
            this.sp_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sp_lbl.Name = "sp_lbl";
            this.sp_lbl.Size = new System.Drawing.Size(100, 22);
            this.sp_lbl.TabIndex = 2;
            this.sp_lbl.Text = "Solar panels";
            // 
            // wm_prb
            // 
            this.wm_prb.Location = new System.Drawing.Point(189, 242);
            this.wm_prb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.wm_prb.Name = "wm_prb";
            this.wm_prb.Size = new System.Drawing.Size(266, 45);
            this.wm_prb.TabIndex = 1;
            this.wm_prb.Value = 1;
            // 
            // sp_prb
            // 
            this.sp_prb.Location = new System.Drawing.Point(189, 193);
            this.sp_prb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sp_prb.Name = "sp_prb";
            this.sp_prb.Size = new System.Drawing.Size(266, 45);
            this.sp_prb.TabIndex = 0;
            this.sp_prb.Value = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(194)))), ((int)(((byte)(120)))));
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.weatherInformation_tbx);
            this.tabPage2.Controls.Add(this.currentCity_lbl);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(827, 438);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Weather";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(476, 44);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(214, 377);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recommendations";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Grids: Recommended";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Windmills: Not recommended";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Solar panels: Recommended";
            // 
            // weatherInformation_tbx
            // 
            this.weatherInformation_tbx.Location = new System.Drawing.Point(4, 44);
            this.weatherInformation_tbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.weatherInformation_tbx.Name = "weatherInformation_tbx";
            this.weatherInformation_tbx.ReadOnly = true;
            this.weatherInformation_tbx.Size = new System.Drawing.Size(449, 378);
            this.weatherInformation_tbx.TabIndex = 16;
            this.weatherInformation_tbx.Text = "";
            // 
            // currentCity_lbl
            // 
            this.currentCity_lbl.AutoSize = true;
            this.currentCity_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentCity_lbl.Location = new System.Drawing.Point(4, 10);
            this.currentCity_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentCity_lbl.Name = "currentCity_lbl";
            this.currentCity_lbl.Size = new System.Drawing.Size(109, 24);
            this.currentCity_lbl.TabIndex = 0;
            this.currentCity_lbl.Text = "Current city:";
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(9, 10);
            this.logo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(58, 58);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 2;
            this.logo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(204, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(630, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 93);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // energyProduced_lbl
            // 
            this.energyProduced_lbl.AutoSize = true;
            this.energyProduced_lbl.Location = new System.Drawing.Point(97, 18);
            this.energyProduced_lbl.Name = "energyProduced_lbl";
            this.energyProduced_lbl.Size = new System.Drawing.Size(92, 13);
            this.energyProduced_lbl.TabIndex = 22;
            this.energyProduced_lbl.Text = "Energy Produced:";
            // 
            // energyConsumed_lbl
            // 
            this.energyConsumed_lbl.AutoSize = true;
            this.energyConsumed_lbl.Location = new System.Drawing.Point(511, 18);
            this.energyConsumed_lbl.Name = "energyConsumed_lbl";
            this.energyConsumed_lbl.Size = new System.Drawing.Size(96, 13);
            this.energyConsumed_lbl.TabIndex = 23;
            this.energyConsumed_lbl.Text = "Energy Consumed:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.refresh_btn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 384);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 54);
            this.panel1.TabIndex = 24;
            // 
            // refresh_btn
            // 
            this.refresh_btn.Location = new System.Drawing.Point(140, 5);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(116, 41);
            this.refresh_btn.TabIndex = 20;
            this.refresh_btn.Text = "Refresh";
            this.refresh_btn.UseVisualStyleBackColor = true;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(912, 486);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "EnergyHome";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weather_pictureBox)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label wm_lbl;
        private System.Windows.Forms.Label sp_lbl;
        private System.Windows.Forms.ProgressBar wm_prb;
        private System.Windows.Forms.ProgressBar sp_prb;
        private System.Windows.Forms.Label gr_lbl;
        private System.Windows.Forms.ProgressBar gr_prb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox gr_chb;
        private System.Windows.Forms.CheckBox wm_chb;
        private System.Windows.Forms.CheckBox sp_chb;
        private System.Windows.Forms.TextBox gr_tbx;
        private System.Windows.Forms.TextBox wm_tbx;
        private System.Windows.Forms.TextBox sp_tbx;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button sp_use_btn;
        private System.Windows.Forms.Button gr_use_btn;
        private System.Windows.Forms.Button wm_use_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label currentCity_lbl;
        private System.Windows.Forms.RichTextBox weatherInformation_tbx;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox weather_pictureBox;
        private System.Windows.Forms.Label currentWeather_lbl;
        private System.Windows.Forms.Label humidity_lbl;
        private System.Windows.Forms.Label windSpeed_lbl;
        private System.Windows.Forms.Label temperature_lbl;
        private System.Windows.Forms.Label energyConsumed_lbl;
        private System.Windows.Forms.Label energyProduced_lbl;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button refresh_btn;
    }
}

