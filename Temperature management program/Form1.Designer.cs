
namespace Temperature_management_program
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_main = new System.Windows.Forms.TabPage();
            this.label19_cycle = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19_current_mode = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox7_interval = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label15_r3_com_state = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13_r2_com_state = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12_r1_com_state = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.textBox5_r3_des_tmp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox6_r3_cur_tmp = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox3_r2_des_tmp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4_r2_cur_tmp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2_r1_des_tmp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1_r1_cur_tmp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tp_monitoring = new System.Windows.Forms.TabPage();
            this.label19_search_contents = new System.Windows.Forms.Label();
            this.button3_db_search_advanced = new System.Windows.Forms.Button();
            this.button2_db_search_day = new System.Windows.Forms.Button();
            this.listView1_db_search = new System.Windows.Forms.ListView();
            this.textBox1_db_search_advanced = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dateTimePicker2_to = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePicker1_from = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.tp_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.tp_monitoring.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_main);
            this.tabControl1.Controls.Add(this.tp_monitoring);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1200, 651);
            this.tabControl1.TabIndex = 0;
            // 
            // tp_main
            // 
            this.tp_main.BackColor = System.Drawing.Color.Gainsboro;
            this.tp_main.Controls.Add(this.label19_cycle);
            this.tp_main.Controls.Add(this.label20);
            this.tp_main.Controls.Add(this.label19_current_mode);
            this.tp_main.Controls.Add(this.button1);
            this.tp_main.Controls.Add(this.textBox7_interval);
            this.tp_main.Controls.Add(this.label17);
            this.tp_main.Controls.Add(this.label15_r3_com_state);
            this.tp_main.Controls.Add(this.label16);
            this.tp_main.Controls.Add(this.label13_r2_com_state);
            this.tp_main.Controls.Add(this.label14);
            this.tp_main.Controls.Add(this.label12_r1_com_state);
            this.tp_main.Controls.Add(this.label11);
            this.tp_main.Controls.Add(this.trackBar3);
            this.tp_main.Controls.Add(this.trackBar2);
            this.tp_main.Controls.Add(this.trackBar1);
            this.tp_main.Controls.Add(this.textBox5_r3_des_tmp);
            this.tp_main.Controls.Add(this.label9);
            this.tp_main.Controls.Add(this.textBox6_r3_cur_tmp);
            this.tp_main.Controls.Add(this.label10);
            this.tp_main.Controls.Add(this.textBox3_r2_des_tmp);
            this.tp_main.Controls.Add(this.label7);
            this.tp_main.Controls.Add(this.textBox4_r2_cur_tmp);
            this.tp_main.Controls.Add(this.label8);
            this.tp_main.Controls.Add(this.textBox2_r1_des_tmp);
            this.tp_main.Controls.Add(this.label6);
            this.tp_main.Controls.Add(this.textBox1_r1_cur_tmp);
            this.tp_main.Controls.Add(this.label5);
            this.tp_main.Controls.Add(this.label4);
            this.tp_main.Controls.Add(this.label3);
            this.tp_main.Controls.Add(this.label2);
            this.tp_main.Controls.Add(this.label1);
            this.tp_main.Location = new System.Drawing.Point(4, 25);
            this.tp_main.Name = "tp_main";
            this.tp_main.Padding = new System.Windows.Forms.Padding(3);
            this.tp_main.Size = new System.Drawing.Size(1192, 622);
            this.tp_main.TabIndex = 0;
            this.tp_main.Text = "Main";
            // 
            // label19_cycle
            // 
            this.label19_cycle.AutoSize = true;
            this.label19_cycle.Font = new System.Drawing.Font("굴림", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19_cycle.Location = new System.Drawing.Point(891, 544);
            this.label19_cycle.Name = "label19_cycle";
            this.label19_cycle.Size = new System.Drawing.Size(129, 30);
            this.label19_cycle.TabIndex = 34;
            this.label19_cycle.Text = "1000ms";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("굴림", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label20.Location = new System.Drawing.Point(695, 544);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(148, 30);
            this.label20.TabIndex = 33;
            this.label20.Text = "현재 주기";
            // 
            // label19_current_mode
            // 
            this.label19_current_mode.AutoSize = true;
            this.label19_current_mode.Font = new System.Drawing.Font("굴림", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19_current_mode.ForeColor = System.Drawing.Color.Green;
            this.label19_current_mode.Location = new System.Drawing.Point(571, 43);
            this.label19_current_mode.Name = "label19_current_mode";
            this.label19_current_mode.Size = new System.Drawing.Size(203, 43);
            this.label19_current_mode.TabIndex = 32;
            this.label19_current_mode.Text = "NORMAL";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(490, 533);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 53);
            this.button1.TabIndex = 31;
            this.button1.Text = "입력";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox7_interval
            // 
            this.textBox7_interval.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox7_interval.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox7_interval.Location = new System.Drawing.Point(316, 533);
            this.textBox7_interval.Name = "textBox7_interval";
            this.textBox7_interval.Size = new System.Drawing.Size(141, 53);
            this.textBox7_interval.TabIndex = 30;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("굴림", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.Location = new System.Drawing.Point(43, 544);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(273, 30);
            this.label17.TabIndex = 29;
            this.label17.Text = "Interval (1s~ 9s) ";
            // 
            // label15_r3_com_state
            // 
            this.label15_r3_com_state.AutoSize = true;
            this.label15_r3_com_state.Font = new System.Drawing.Font("굴림", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15_r3_com_state.Location = new System.Drawing.Point(1029, 462);
            this.label15_r3_com_state.Name = "label15_r3_com_state";
            this.label15_r3_com_state.Size = new System.Drawing.Size(75, 30);
            this.label15_r3_com_state.TabIndex = 28;
            this.label15_r3_com_state.Text = "OFF";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("굴림", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.Location = new System.Drawing.Point(807, 462);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(179, 30);
            this.label16.TabIndex = 27;
            this.label16.Text = "실외기 상태";
            // 
            // label13_r2_com_state
            // 
            this.label13_r2_com_state.AutoSize = true;
            this.label13_r2_com_state.Font = new System.Drawing.Font("굴림", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13_r2_com_state.Location = new System.Drawing.Point(665, 462);
            this.label13_r2_com_state.Name = "label13_r2_com_state";
            this.label13_r2_com_state.Size = new System.Drawing.Size(75, 30);
            this.label13_r2_com_state.TabIndex = 26;
            this.label13_r2_com_state.Text = "OFF";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("굴림", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(443, 462);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(179, 30);
            this.label14.TabIndex = 25;
            this.label14.Text = "실외기 상태";
            // 
            // label12_r1_com_state
            // 
            this.label12_r1_com_state.AutoSize = true;
            this.label12_r1_com_state.Font = new System.Drawing.Font("굴림", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12_r1_com_state.Location = new System.Drawing.Point(293, 462);
            this.label12_r1_com_state.Name = "label12_r1_com_state";
            this.label12_r1_com_state.Size = new System.Drawing.Size(75, 30);
            this.label12_r1_com_state.TabIndex = 24;
            this.label12_r1_com_state.Text = "OFF";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(71, 462);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 30);
            this.label11.TabIndex = 23;
            this.label11.Text = "실외기 상태";
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(812, 391);
            this.trackBar3.Maximum = 20;
            this.trackBar3.Minimum = -20;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(292, 56);
            this.trackBar3.TabIndex = 22;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(448, 391);
            this.trackBar2.Maximum = 20;
            this.trackBar2.Minimum = -20;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(292, 56);
            this.trackBar2.TabIndex = 21;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(76, 391);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Minimum = -20;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(292, 56);
            this.trackBar1.TabIndex = 20;
            this.trackBar1.Value = 20;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // textBox5_r3_des_tmp
            // 
            this.textBox5_r3_des_tmp.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox5_r3_des_tmp.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox5_r3_des_tmp.Location = new System.Drawing.Point(963, 293);
            this.textBox5_r3_des_tmp.Name = "textBox5_r3_des_tmp";
            this.textBox5_r3_des_tmp.Size = new System.Drawing.Size(141, 53);
            this.textBox5_r3_des_tmp.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(807, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 30);
            this.label9.TabIndex = 18;
            this.label9.Text = "희망온도";
            // 
            // textBox6_r3_cur_tmp
            // 
            this.textBox6_r3_cur_tmp.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox6_r3_cur_tmp.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox6_r3_cur_tmp.Location = new System.Drawing.Point(963, 209);
            this.textBox6_r3_cur_tmp.Name = "textBox6_r3_cur_tmp";
            this.textBox6_r3_cur_tmp.Size = new System.Drawing.Size(141, 53);
            this.textBox6_r3_cur_tmp.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(807, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 30);
            this.label10.TabIndex = 16;
            this.label10.Text = "현재온도";
            // 
            // textBox3_r2_des_tmp
            // 
            this.textBox3_r2_des_tmp.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox3_r2_des_tmp.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox3_r2_des_tmp.Location = new System.Drawing.Point(599, 293);
            this.textBox3_r2_des_tmp.Name = "textBox3_r2_des_tmp";
            this.textBox3_r2_des_tmp.Size = new System.Drawing.Size(141, 53);
            this.textBox3_r2_des_tmp.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(443, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 30);
            this.label7.TabIndex = 14;
            this.label7.Text = "희망온도";
            // 
            // textBox4_r2_cur_tmp
            // 
            this.textBox4_r2_cur_tmp.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox4_r2_cur_tmp.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox4_r2_cur_tmp.Location = new System.Drawing.Point(599, 209);
            this.textBox4_r2_cur_tmp.Name = "textBox4_r2_cur_tmp";
            this.textBox4_r2_cur_tmp.Size = new System.Drawing.Size(141, 53);
            this.textBox4_r2_cur_tmp.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(443, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 30);
            this.label8.TabIndex = 12;
            this.label8.Text = "현재온도";
            // 
            // textBox2_r1_des_tmp
            // 
            this.textBox2_r1_des_tmp.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox2_r1_des_tmp.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox2_r1_des_tmp.Location = new System.Drawing.Point(227, 293);
            this.textBox2_r1_des_tmp.Name = "textBox2_r1_des_tmp";
            this.textBox2_r1_des_tmp.Size = new System.Drawing.Size(141, 53);
            this.textBox2_r1_des_tmp.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(71, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 30);
            this.label6.TabIndex = 10;
            this.label6.Text = "희망온도";
            // 
            // textBox1_r1_cur_tmp
            // 
            this.textBox1_r1_cur_tmp.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1_r1_cur_tmp.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1_r1_cur_tmp.Location = new System.Drawing.Point(227, 209);
            this.textBox1_r1_cur_tmp.Name = "textBox1_r1_cur_tmp";
            this.textBox1_r1_cur_tmp.Size = new System.Drawing.Size(141, 53);
            this.textBox1_r1_cur_tmp.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(71, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "현재온도";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(344, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 40);
            this.label4.TabIndex = 7;
            this.label4.Text = "현재 모드";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("굴림", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(804, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 48);
            this.label3.TabIndex = 6;
            this.label3.Text = "<Room #3>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("굴림", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(440, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 48);
            this.label2.TabIndex = 5;
            this.label2.Text = "<Room #2>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("굴림", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 48);
            this.label1.TabIndex = 4;
            this.label1.Text = "<Room #1>";
            // 
            // tp_monitoring
            // 
            this.tp_monitoring.BackColor = System.Drawing.Color.MistyRose;
            this.tp_monitoring.Controls.Add(this.label19_search_contents);
            this.tp_monitoring.Controls.Add(this.button3_db_search_advanced);
            this.tp_monitoring.Controls.Add(this.button2_db_search_day);
            this.tp_monitoring.Controls.Add(this.listView1_db_search);
            this.tp_monitoring.Controls.Add(this.textBox1_db_search_advanced);
            this.tp_monitoring.Controls.Add(this.label18);
            this.tp_monitoring.Controls.Add(this.label15);
            this.tp_monitoring.Controls.Add(this.dateTimePicker2_to);
            this.tp_monitoring.Controls.Add(this.label13);
            this.tp_monitoring.Controls.Add(this.dateTimePicker1_from);
            this.tp_monitoring.Controls.Add(this.label12);
            this.tp_monitoring.Controls.Add(this.chart1);
            this.tp_monitoring.Location = new System.Drawing.Point(4, 25);
            this.tp_monitoring.Name = "tp_monitoring";
            this.tp_monitoring.Padding = new System.Windows.Forms.Padding(3);
            this.tp_monitoring.Size = new System.Drawing.Size(1192, 622);
            this.tp_monitoring.TabIndex = 1;
            this.tp_monitoring.Text = "Monitoring";
            // 
            // label19_search_contents
            // 
            this.label19_search_contents.AutoSize = true;
            this.label19_search_contents.Font = new System.Drawing.Font("굴림", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19_search_contents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label19_search_contents.Location = new System.Drawing.Point(3, 231);
            this.label19_search_contents.Name = "label19_search_contents";
            this.label19_search_contents.Size = new System.Drawing.Size(0, 17);
            this.label19_search_contents.TabIndex = 34;
            // 
            // button3_db_search_advanced
            // 
            this.button3_db_search_advanced.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button3_db_search_advanced.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3_db_search_advanced.Location = new System.Drawing.Point(466, 183);
            this.button3_db_search_advanced.Name = "button3_db_search_advanced";
            this.button3_db_search_advanced.Size = new System.Drawing.Size(75, 36);
            this.button3_db_search_advanced.TabIndex = 33;
            this.button3_db_search_advanced.Text = "검색";
            this.button3_db_search_advanced.UseVisualStyleBackColor = false;
            this.button3_db_search_advanced.Click += new System.EventHandler(this.button3_db_search_advanced_Click);
            // 
            // button2_db_search_day
            // 
            this.button2_db_search_day.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button2_db_search_day.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2_db_search_day.Location = new System.Drawing.Point(466, 63);
            this.button2_db_search_day.Name = "button2_db_search_day";
            this.button2_db_search_day.Size = new System.Drawing.Size(75, 36);
            this.button2_db_search_day.TabIndex = 32;
            this.button2_db_search_day.Text = "검색";
            this.button2_db_search_day.UseVisualStyleBackColor = false;
            this.button2_db_search_day.Click += new System.EventHandler(this.button2_db_search_day_Click);
            // 
            // listView1_db_search
            // 
            this.listView1_db_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listView1_db_search.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listView1_db_search.HideSelection = false;
            this.listView1_db_search.Location = new System.Drawing.Point(4, 259);
            this.listView1_db_search.Name = "listView1_db_search";
            this.listView1_db_search.Size = new System.Drawing.Size(537, 340);
            this.listView1_db_search.TabIndex = 31;
            this.listView1_db_search.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1_db_search_advanced
            // 
            this.textBox1_db_search_advanced.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox1_db_search_advanced.Font = new System.Drawing.Font("굴림", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1_db_search_advanced.Location = new System.Drawing.Point(2, 186);
            this.textBox1_db_search_advanced.Name = "textBox1_db_search_advanced";
            this.textBox1_db_search_advanced.Size = new System.Drawing.Size(458, 30);
            this.textBox1_db_search_advanced.TabIndex = 30;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("굴림", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label18.Location = new System.Drawing.Point(1, 153);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(546, 17);
            this.label18.TabIndex = 29;
            this.label18.Text = "입력 예) 2021-04-28-15-30-35 ~ 2021-04-28-15-30-38 ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("굴림", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(192, 112);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(138, 28);
            this.label15.TabIndex = 28;
            this.label15.Text = "상세 검색";
            // 
            // dateTimePicker2_to
            // 
            this.dateTimePicker2_to.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimePicker2_to.Location = new System.Drawing.Point(251, 69);
            this.dateTimePicker2_to.Name = "dateTimePicker2_to";
            this.dateTimePicker2_to.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker2_to.TabIndex = 27;
            this.dateTimePicker2_to.ValueChanged += new System.EventHandler(this.dateTimePicker2_to_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("굴림", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(210, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 28);
            this.label13.TabIndex = 26;
            this.label13.Text = "~";
            // 
            // dateTimePicker1_from
            // 
            this.dateTimePicker1_from.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimePicker1_from.Location = new System.Drawing.Point(4, 69);
            this.dateTimePicker1_from.Name = "dateTimePicker1_from";
            this.dateTimePicker1_from.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker1_from.TabIndex = 25;
            this.dateTimePicker1_from.ValueChanged += new System.EventHandler(this.dateTimePicker1_from_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("굴림", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(136, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(245, 28);
            this.label12.TabIndex = 24;
            this.label12.Text = "일 단위 기록 검색";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.LightCoral;
            this.chart1.BorderlineColor = System.Drawing.Color.MistyRose;
            chartArea1.AxisY.Maximum = 25D;
            chartArea1.AxisY.Minimum = -25D;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(567, 29);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Room#1";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Room#2";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Room#3";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(595, 570);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 651);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temperature Management Program";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tp_main.ResumeLayout(false);
            this.tp_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.tp_monitoring.ResumeLayout(false);
            this.tp_monitoring.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_main;
        private System.Windows.Forms.TabPage tp_monitoring;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox7_interval;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15_r3_com_state;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13_r2_com_state;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12_r1_com_state;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox textBox5_r3_des_tmp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox6_r3_cur_tmp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox3_r2_des_tmp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4_r2_cur_tmp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2_r1_des_tmp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1_r1_cur_tmp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_from;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePicker2_to;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox1_db_search_advanced;
        private System.Windows.Forms.ListView listView1_db_search;
        private System.Windows.Forms.Button button3_db_search_advanced;
        private System.Windows.Forms.Button button2_db_search_day;
        private System.Windows.Forms.Label label19_search_contents;
        private System.Windows.Forms.Label label19_current_mode;
        private System.Windows.Forms.Label label19_cycle;
        private System.Windows.Forms.Label label20;
    }
}

