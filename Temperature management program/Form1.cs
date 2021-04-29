using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports; // Add for UART communication
using MySql.Data.MySqlClient; // Add for MySQL
using System.Data.Common;

namespace Temperature_management_program
{
    public partial class Form1 : Form
    {
        String connStr = "Server=127.0.0.1;Uid=root;Pwd=1234;Database=tmp_db;Charset=UTF8";
        MySqlConnection conn;
        MySqlCommand cmd;
        String sql = "";
        MySqlDataReader reader;
        string datain = ""; // UART로 부터 들어온 data를 읽어 들이는 변수
        int[] inputSensorData; // UART로 부터 들어온 data Parsing Array
        int inputSensorDataIndex = 0;
        DateTime[] dateAry = new DateTime[30]; // for date draw chart
        int[] t_room1_arr = new int[30]; // for room1 draw chart
        int[] t_room2_arr = new int[30]; // for room2 draw chart
        int[] t_room3_arr = new int[30]; // for room2 draw chart
        DateTime from_day;
        DateTime to_day;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label12_r1_com_state.ForeColor = Color.Red;
            label13_r2_com_state.ForeColor = Color.Red;
            label15_r3_com_state.ForeColor = Color.Red;
            dateTimePicker1_from.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1_from.Format = DateTimePickerFormat.Custom;
            dateTimePicker2_to.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2_to.Format = DateTimePickerFormat.Custom;
            inputSensorData = new int[11];
            conn = new MySqlConnection(connStr);
            conn.Open();
            cmd = new MySqlCommand("", conn);
            try
            {
                    serialPort1.PortName = "COM3";
                    serialPort1.BaudRate = 115200;
                    serialPort1.Open(); // 예외 처리 집어 넣을것
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("UART Open Execption Error" + Environment.NewLine);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(datain == "")
            {
                return;
            }
            drawChart();
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //datain = serialPort1.ReadExisting(); // STM32로부터 들어온 data를 전부 reading
            // 주의할 점은 현재 115200bps로 설정 1char당 약 0.1ms 소요 시간 over에 유의
            datain = serialPort1.ReadLine();
            this.Invoke(new EventHandler(dataParse));
        }
        private void dataParse(object sender, EventArgs e)
        {
            string[] temp = datain.Split(' ');
            // 0, 1, 2 -> current tmp    3, 4, 5 -> air conditioner state    6, 7, 8 -> desire tmp
            switch (inputSensorDataIndex)
            {
                case 0:
                    if(temp.Length != 2 || temp[0] != "cur_room1")
                    {
                        inputSensorDataIndex++;
                        break;
                    }
                    inputSensorData[inputSensorDataIndex] = int.Parse(temp[1]);
                    textBox1_r1_cur_tmp.Text = inputSensorData[0].ToString();
                    break;
                case 1:
                    if (temp.Length != 2 || temp[0] != "cur_room2")
                    {
                        inputSensorDataIndex++;
                        break;
                    }
                    inputSensorData[inputSensorDataIndex] = int.Parse(temp[1]);
                    textBox4_r2_cur_tmp.Text = inputSensorData[1].ToString();
                    break;
                case 2:
                    if (temp.Length != 2 || temp[0] != "cur_room3")
                    {
                        inputSensorDataIndex++;
                        break;
                    }
                    inputSensorData[inputSensorDataIndex] = int.Parse(temp[1]);
                    textBox6_r3_cur_tmp.Text = inputSensorData[2].ToString();
                    saveDB();
                    break;
                case 3:
                    if (temp.Length != 2 || temp[0] != "stat_room1")
                    {
                        inputSensorDataIndex++;
                        break;
                    }
                    inputSensorData[inputSensorDataIndex] = int.Parse(temp[1]);
                    if (inputSensorData[3] == 0)
                    {
                        label12_r1_com_state.Text = "OFF";
                        label12_r1_com_state.ForeColor = Color.Red;
                    }
                    else
                    {
                        label12_r1_com_state.Text = "ON";
                        label12_r1_com_state.ForeColor = Color.Green;
                    }
                    break;
                case 4:
                    if (temp.Length != 2 || temp[0] != "stat_room2")
                    {
                        inputSensorDataIndex++;
                        break;
                    }
                    inputSensorData[inputSensorDataIndex] = int.Parse(temp[1]);
                    if (inputSensorData[4] == 0)
                    {
                        label13_r2_com_state.Text = "OFF";
                        label13_r2_com_state.ForeColor = Color.Red;
                    }
                    else
                    {
                        label13_r2_com_state.Text = "ON";
                        label13_r2_com_state.ForeColor = Color.Green;
                    }
                    break;
                case 5:
                    if (temp.Length != 2 || temp[0] != "stat_room3")
                    {
                        inputSensorDataIndex++;
                        break;
                    }
                    inputSensorData[inputSensorDataIndex] = int.Parse(temp[1]);
                    if (inputSensorData[5] == 0)
                    {
                        label15_r3_com_state.Text = "OFF";
                        label15_r3_com_state.ForeColor = Color.Red;
                    }
                    else
                    {
                        label15_r3_com_state.Text = "ON";
                        label15_r3_com_state.ForeColor = Color.Green;
                    }
                    break;
                case 6:
                    if (temp.Length != 2 || temp[0] != "dsr_room1")
                    {
                        inputSensorDataIndex++;
                        break;
                    }
                    inputSensorData[inputSensorDataIndex] = int.Parse(temp[1]);
                    textBox2_r1_des_tmp.Text = inputSensorData[inputSensorDataIndex].ToString();
                    break;
                case 7:
                    if (temp.Length != 2 || temp[0] != "dsr_room2")
                    {
                        
                        break;
                    }
                    inputSensorData[inputSensorDataIndex] = int.Parse(temp[1]);
                    textBox3_r2_des_tmp.Text = inputSensorData[inputSensorDataIndex].ToString();
                    break;
                case 8:
                    if (temp.Length != 2 || temp[0] != "dsr_room3")
                    {
                        inputSensorDataIndex++;
                        break;
                    }
                    inputSensorData[inputSensorDataIndex] = int.Parse(temp[1]);
                    textBox5_r3_des_tmp.Text = inputSensorData[inputSensorDataIndex].ToString();
                    break;
                case 9:
                    int mode = 0;
                    try
                    {
                        mode = int.Parse(datain);
                        inputSensorData[inputSensorDataIndex] = mode;
                        if (inputSensorData[inputSensorDataIndex] == 1)
                        {
                            label19_current_mode.Text = "NORMAL";
                            label19_current_mode.ForeColor = Color.Green;
                        }
                        if (inputSensorData[inputSensorDataIndex] == 2)
                        {
                            label19_current_mode.Text = "SETTING";
                            label19_current_mode.ForeColor = Color.BlueViolet;
                        }
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Mode Setting FormatException !!!");
                    }
                    break;
                case 10:
                    int cycle = 15;
                    try
                    {
                        cycle = int.Parse(datain);
                        inputSensorData[inputSensorDataIndex] = cycle;
                        label19_cycle.Refresh();
                        label19_cycle.Text = (cycle / 15) + "000ms";
                    }
                    catch (FormatException)
                    {
                        break;
                    }
                    break;
                default:
                    break;
            }
            
            if (++inputSensorDataIndex >= 11)
            {
                inputSensorDataIndex = 0;
            }
        }
        private void saveDB()
        {
            string t_date = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
            sql = "INSERT INTO tmp(t_date, t_room1, t_room2, t_room3) VALUES ('";
            sql += t_date + "'";
            for (int i = 0; i < 3; i++)
            {
                sql += ", " + inputSensorData[i];
            }
            sql += ")";
            try
            {
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException)
            {
                MessageBox.Show("DB INSERT FAIL!!!");
            }
        }
        private void drawChart()
        {
            sql = "SELECT t_date, t_room1, t_room2, t_room3 FROM tmp ORDER BY t_date DESC LIMIT 1";
            cmd.CommandText = sql;
            reader = cmd.ExecuteReader();
            reader.Read();
            DateTime date = new DateTime();
            date = (DateTime)reader["t_date"];
            int t_room1 = (int)reader["t_room1"];
            int t_room2 = (int)reader["t_room2"];
            int t_room3 = (int)reader["t_room3"];
            reader.Close();
            //한칸씩 당기기
            for (int i = 0; i < t_room1_arr.Length - 1; i++)
            {
                dateAry[i] = dateAry[i + 1];
                t_room1_arr[i] = t_room1_arr[i + 1];
                t_room2_arr[i] = t_room2_arr[i + 1];
                t_room3_arr[i] = t_room3_arr[i + 1];
            }
            //최신 데이터를 마지막에 넣기
            dateAry[dateAry.Length - 1] = date;
            t_room1_arr[t_room1_arr.Length - 1] = t_room1;
            t_room2_arr[t_room2_arr.Length - 1] = t_room2;
            t_room3_arr[t_room3_arr.Length - 1] = t_room3;
            //차트 그리기
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();
            int index = 0;
            chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Interval = 2;
            for (int i = 0; i < t_room1_arr.Length; i++)
            {
                chart1.Series[0].Points.AddXY(dateAry[i] + " " + index, t_room1_arr[i]);
                chart1.Series[1].Points.AddXY(dateAry[i] + " " + index, t_room2_arr[i]);
                chart1.Series[2].Points.AddXY(dateAry[i] + " " + index++, t_room3_arr[i]);
            }
        }
        private void button2_db_search_day_Click(object sender, EventArgs e)
        {
            label19_search_contents.Text = "";
            sql = "SELECT t_date, t_room1, t_room2, t_room3 FROM tmp WHERE t_date BETWEEN '";
            sql += from_day.Year + "-" + from_day.Month + "-" + from_day.Day + "-00-00-00' AND '";
            sql += to_day.Year + "-" + to_day.Month + "-" + to_day.Day + "-23-59-59'";
            dbSearchListViewInit();
            label19_search_contents.Text = from_day.Year + "-" + from_day.Month + "-" + from_day.Day + "-00-00-00 ~ " +
                to_day.Year + "-" + to_day.Month + "-" + to_day.Day + "-23-59-59";
        }
        private void button3_db_search_advanced_Click(object sender, EventArgs e)
        {
            label19_search_contents.Text = "";
            sql = "SELECT t_date, t_room1, t_room2, t_room3 FROM tmp WHERE t_date BETWEEN '";
            string advanced_str = textBox1_db_search_advanced.Text;
            advanced_str.Replace(" ", "");
            string[] temp = advanced_str.Split('~');
            sql += temp[0] + "' AND '";
            sql += temp[1] + "'";
            dbSearchListViewInit();
            label19_search_contents.Text = temp[0] + " ~ " + temp[1];
            textBox1_db_search_advanced.Text = "";
        }
        private void dbSearchListViewInit()
        {
            try
            {
                cmd.CommandText = sql;
                reader = cmd.ExecuteReader();
                // Search ListView 상단 설정
                listView1_db_search.Clear();
                listView1_db_search.View = View.Details;
                listView1_db_search.Columns.Add("시간");
                listView1_db_search.Columns.Add("Room#1");
                listView1_db_search.Columns.Add("Room#2");
                listView1_db_search.Columns.Add("Room#3");
                ListViewItem item;
                int room1 = 0;
                int room2 = 0;
                int room3 = 0;
                DateTime date = new DateTime();
                while (reader.Read())
                {
                    date = (DateTime)reader["t_date"];
                    room1 = (int)reader["t_room1"];
                    room2 = (int)reader["t_room2"];
                    room3 = (int)reader["t_room3"];
                    item = new ListViewItem(date.ToString());
                    item.SubItems.Add(room1.ToString());
                    item.SubItems.Add(room2.ToString());
                    item.SubItems.Add(room3.ToString());
                    listView1_db_search.Items.Add(item);
                }
                // 폭 조절하기 (열 사이즈에 맞춤)
                for (int i = 0; i < listView1_db_search.Columns.Count; i++)
                {
                    listView1_db_search.Columns[i].TextAlign = HorizontalAlignment.Center;
                    listView1_db_search.Columns[i].Width = -2;
                }
                reader.Close();
            }
            catch(MySqlException)
            {
                MessageBox.Show("DB Search FAIL !!!");
            }
        }

        private void dateTimePicker1_from_ValueChanged(object sender, EventArgs e)
        {
            from_day = dateTimePicker1_from.Value;
        }

        private void dateTimePicker2_to_ValueChanged(object sender, EventArgs e)
        {
            to_day = dateTimePicker2_to.Value;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if(trackBar1.Value >= -9 && trackBar1.Value <= 9)
            {
                serialPort1.WriteLine("room1 0" + trackBar1.Value.ToString() + Environment.NewLine);
            }
            else
            {
                serialPort1.WriteLine("room1 " + trackBar1.Value.ToString() + Environment.NewLine);
            }
            textBox2_r1_des_tmp.Text = trackBar1.Value.ToString();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value >= -9 && trackBar1.Value <= 9)
            {
                serialPort1.WriteLine("room2 0" + trackBar2.Value.ToString() + Environment.NewLine);
            }
            else
            {
                serialPort1.WriteLine("room2 " + trackBar2.Value.ToString() + Environment.NewLine);
            }
            textBox3_r2_des_tmp.Text = trackBar2.Value.ToString();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value >= -9 && trackBar1.Value <= 9)
            {
                serialPort1.WriteLine("room3 0" + trackBar3.Value.ToString() + Environment.NewLine);
            }
            else
            {
                serialPort1.WriteLine("room3 " + trackBar3.Value.ToString() + Environment.NewLine);
            }
            textBox5_r3_des_tmp.Text = trackBar3.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cycle = 15;
            try
            {
                cycle = int.Parse(textBox7_interval.Text.ToString());
                serialPort1.WriteLine("interval " + cycle.ToString() + Environment.NewLine);
                textBox7_interval.Text = "";
            }
            catch(FormatException)
            {
                MessageBox.Show("Press Button : FormatException !!!");
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            serialPort1.Close();
        }
    }
}
