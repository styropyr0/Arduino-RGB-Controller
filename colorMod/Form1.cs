using System;
using System.Drawing;
using System.IO.Ports;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace colorMod
{

    public partial class Form1 : Form
    {
        int blueVal = 512, redVal = 0, greenVal = 256, del = 1100;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            portC.Text = "None";
            baudC.Text = "9600";
            dataC.Text = "Use Default";
            parityC.Text = "Use Default";
            stopC.Text = "Use Default";
            button1.Enabled = false;
            groupBox3.Enabled = false;
            groupBox4.Hide();
            livel.Enabled = false;

        }

        private async void connectBtn_Click(object sender, EventArgs e)
        {
            Task<int> task = new Task<int>(Handshake);
            string pName = portC.Text;
            if (connectBtn.Text == "DISCONNECT")
            {
                connectBtn.Text = "CONNECT";
                progressBar.Value = 0;
                arduino.WriteLine("1024");
                textBox1.Text = "Disconnected from " + arduino.PortName;
                arduino.Close();
                groupBox2.Show();
                groupBox3.Show();
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                groupBox4.Hide();
                livel.Enabled = false;
                button1.Enabled = false;
                redTB.Text = "0";
                blueTB.Text = "0";
                greenTB.Text = "0";
                TBblue.Value = TBgreen.Value = TBred.Value = 0;
            }
            else
            {
                try
                {
                    if (portC.Text.ToUpper() == "NONE" || portC.Text == null)
                    {
                        textBox1.Text = "Port name can't be empty. Select or enter the serial port's name to which your device is connected.";
                    }
                    else
                    {
                        progressBar.Visible = true;
                        arduino.PortName = portC.Text;
                        arduino.BaudRate = Convert.ToInt32(baudC.Text);
                        if (dataC.Text.ToUpper() != "USE DEFAULT")
                            arduino.DataBits = Convert.ToInt32(dataC.Text);
                        if (stopC.Text.ToUpper() != "USE DEFAULT")
                            arduino.StopBits = (StopBits)Enum.Parse(typeof(StopBits), stopC.Text);
                        if (parityC.Text.ToUpper() != "USE DEFAULT")
                            arduino.Parity = (Parity)Enum.Parse(typeof(Parity), parityC.Text);
                        progressBar.Value = 20;
                        textBox1.Text = "Establishing secure connection with " + portC.Text;
                        progressBar.Value = 40;
                        arduino.DtrEnable = true;
                        arduino.RtsEnable = true;
                        arduino.Open();
                        if (arduino.IsOpen)
                            progressBar.Value = 60;


                        else
                        {
                            progressBar.Value = 0;
                            textBox1.Text = "Couldn't cnnect to " + pName;
                            progressBar.Visible = false;
                            arduino.Close();
                        }
                        textBox1.Text = "Waiting for handshaking signal.";
                        task.Start();
                        int ct = await task;
                        if (ct >= 10 && ct < 500)
                        {
                            textBox1.Text = "ERR_TIMEOUT No handshaking signal recieved. No sketch on the board or sketch incompatible.";
                            if (arduino.IsOpen)
                                arduino.Close();
                            progressBar.Value = 0;
                            connectBtn.Text = "CONNECT";
                        }

                        else
                        {
                            textBox1.Text = "Sending back response.";
                            arduino.WriteLine("9090");
                            Thread.Sleep(1000);
                            progressBar.Value = 100;
                            textBox1.Text = "Connected to " + pName;
                            connectBtn.Text = "DISCONNECT";
                            groupBox2.Enabled = true;
                            groupBox3.Enabled = true;
                            livel.Enabled = true;
                        }
                    }
                }
                catch (Exception)
                {
                    progressBar.Value = 0;
                    connectBtn.Text = "CONNECT";
                    textBox1.Text = "Exception on connect. Check your device name or connection.";
                }

            }
        }

        private int Handshake()
        {
            try
            {
                int ct = 0;
                string s = "FTERjhgdstkjlsa";
                arduino.ReadTimeout = 15000;
                while (ct < 100)
                {
                    if (arduino.ReadLine().Trim().Length == s.Length)
                        ct = 11000;
                    else ct = 100;
                }
                return ct;
            }

            catch (Exception)
            {
                return 20;
            }
        }

        private void portC_MouseClick(object sender, MouseEventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            portC.Items.Clear();
            portC.Items.Add("None");
            portC.Items.AddRange(ports);
        }

        private void TBred_Scroll(object sender, EventArgs e)
        {
            redVal = TBred.Value;
            arduino.WriteLine(redVal.ToString());
            redTB.Text = TBred.Value.ToString();
            button1.Enabled = true;
            button1.Text = "TURN OFF ALL COLORS";
            textBox2.Text = "#" + redVal + "#" + (greenVal - 256) + "#" + (blueVal - 512);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            arduino.WriteLine("1024");
            button1.Enabled = false;
            TBblue.Value = TBgreen.Value = TBred.Value = 0;
            greenTB.Text = redTB.Text = blueTB.Text = "0";
            textBox2.Text = "TURNED OFF";
            button1.Text = "TURNED OFF";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            arduino.WriteLine("1024");
            arduino.WriteLine("255");
            textBox2.Text = "RED";
            TBblue.Value = 0;
            TBgreen.Value = 0;
            TBred.Value = 255;
            blueTB.Text = "0";
            greenTB.Text = "0";
            redTB.Text = "255";
            button1.Text = "TURN OFF ALL COLORS";
            button1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            arduino.WriteLine("1024");
            arduino.WriteLine("767");
            textBox2.Text = "BLUE";
            TBblue.Value = 255;
            TBgreen.Value = 0;
            TBred.Value = 0;
            blueTB.Text = "255";
            greenTB.Text = "0";
            redTB.Text = "0";
            button1.Text = "TURN OFF ALL COLORS";
            button1.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            arduino.WriteLine("1024");
            arduino.WriteLine("511");
            textBox2.Text = "RED";
            TBblue.Value = 0;
            TBgreen.Value = 255;
            TBred.Value = 0;
            blueTB.Text = "0";
            greenTB.Text = "255";
            redTB.Text = "0";
            button1.Text = "TURN OFF ALL COLORS";
            button1.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            arduino.WriteLine("1024");
            arduino.WriteLine("220");
            arduino.WriteLine("511");
            arduino.WriteLine("513");
            textBox2.Text = "YELLOW";
            TBblue.Value = 1;
            TBgreen.Value = 255;
            TBred.Value = 220;
            blueTB.Text = "1";
            greenTB.Text = "255";
            redTB.Text = "220";
            button1.Text = "TURN OFF ALL COLORS";
            button1.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            arduino.WriteLine("1024");
            arduino.WriteLine("767");
            arduino.WriteLine("122");
            textBox2.Text = "PURPLE";
            TBblue.Value = 255;
            TBgreen.Value = 0;
            TBred.Value = 122;
            blueTB.Text = "255";
            greenTB.Text = "0";
            redTB.Text = "122";
            button1.Text = "TURN OFF ALL COLORS";
            button1.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            arduino.WriteLine("1024");
            arduino.WriteLine("511");
            arduino.WriteLine("642");
            textBox2.Text = "TURQOUISE";
            TBblue.Value = 130;
            TBgreen.Value = 255;
            TBred.Value = 0;
            blueTB.Text = "130";
            greenTB.Text = "255";
            redTB.Text = "0";
            button1.Text = "TURN OFF ALL COLORS";
            button1.Enabled = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            arduino.WriteLine("1024");
            arduino.WriteLine("380");
            arduino.WriteLine("767");
            textBox2.Text = "SKY BLUE";
            TBblue.Value = 255;
            TBgreen.Value = 125;
            TBred.Value = 132;
            blueTB.Text = "255";
            greenTB.Text = "125";
            redTB.Text = "132";
            button1.Text = "TURN OFF ALL COLORS";
            button1.Enabled = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            arduino.WriteLine("1024");
            arduino.WriteLine("255");
            arduino.WriteLine("315");
            textBox2.Text = "ORANGE";
            TBblue.Value = 0;
            TBgreen.Value = 60;
            TBred.Value = 255;
            blueTB.Text = "0";
            greenTB.Text = "60";
            redTB.Text = "255";
            button1.Text = "TURN OFF ALL COLORS";
            button1.Enabled = true;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (arduino.IsOpen)
            {
                arduino.WriteLine("1024");
                arduino.Close();
            }

        }

        private void livel_Click(object sender, EventArgs e)
        {
            if (livel.Text == "DYNAMIC LIGHTING")
            {
                Point p = new Point(306, 12);
                groupBox2.Hide();
                groupBox3.Hide();
                arduino.WriteLine("1024");
                livel.Text = "STATIC LIGHTING";
                groupBox4.Location = p;
                groupBox4.Show();
                groupBox4.Enabled = true;
                button1.Hide();
            }

            else
            {
                arduino.WriteLine("10");
                groupBox4.Hide();
                groupBox2.Show();
                groupBox3.Show();
                button1.Show();
                button10.Text = "START";
                livel.Text = "DYNAMIC LIGHTING";

            }
        }


        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label9.Text = ((trackBar1.Value * 2) + 10).ToString() + "ms";
            del = ((trackBar1.Value * 2) + 10) * 110;
            if (button10.Text == "STOP")
            {
                arduino.WriteLine("10");
                arduino.WriteLine(del.ToString());
            }
        }

        private void redTB_TextChanged(object sender, EventArgs e)
        {
            /*redVal = TBred.Value;
            arduino.WriteLine(redVal.ToString());
            redTB.Text = TBred.Value.ToString();
            button1.Enabled = true;
            button1.Text = "TURN OFF ALL COLORS";
            textBox2.Text = "#" + redVal + "#" + (greenVal - 256) + "#" + (blueVal - 512);*/
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.Text == "START")
            {
                button10.Text = "STOP";
                trackBar1.Enabled = false;
                arduino.WriteLine(del.ToString());

            }
            else
            {
                trackBar1.Enabled = true;
                button10.Text = "START";
                arduino.WriteLine("10");
            }
        }

        private void TBgreen_Scroll(object sender, EventArgs e)
        {
            greenVal = TBgreen.Value + 256;
            arduino.WriteLine(greenVal.ToString());
            greenTB.Text = TBgreen.Value.ToString();
            button1.Enabled = true;
            button1.Text = "TURN OFF ALL COLORS";
            textBox2.Text = "#" + redVal + "#" + (greenVal - 256) + "#" + (blueVal - 512);
        }

        private void TBblue_Scroll(object sender, EventArgs e)
        {
            blueVal = TBblue.Value + 512;
            arduino.WriteLine(blueVal.ToString());
            blueTB.Text = TBblue.Value.ToString();
            button1.Enabled = true;
            button1.Text = "TURN OFF ALL COLORS";
            textBox2.Text = "#" + redVal + "#" + (greenVal - 256) + "#" + (blueVal - 512);
        }


    }
}
