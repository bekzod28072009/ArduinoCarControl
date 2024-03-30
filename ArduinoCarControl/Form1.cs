using System.IO.Ports;

namespace ArduinoCarControl
{
    public partial class Form1 : Form
    {
        int speed = 200;
        SerialPort serialPort = new SerialPort("COM3", 9600);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                serialPort.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening serial port: " + ex.Message);
            }

            speedTxt.Text = Convert.ToString(speed);
        }

        private void SendCommand(char command)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write(command.ToString());
            }
            else
            {
                MessageBox.Show("Serial port is not open.");
            }
        }

        private void forwardButton_Click_Click(object sender, EventArgs e)
        {
            SendCommand('F');
            forwardButton_Click.Enabled = false;
            if (stopButton_Click.Enabled == false)
            {
                stopButton_Click.Enabled = true;
            }
        }

        private void stopButton_Click_Click(object sender, EventArgs e)
        {
            SendCommand('S');
            stopButton_Click.Enabled = false;
            if (forwardButton_Click.Enabled == false)
            {
                forwardButton_Click.Enabled = true;
            }
            speed = 0;
            speedTxt.Text = Convert.ToString(speed);
        }

        private void sportSpeed_button_Click(object sender, EventArgs e)
        {
            IncreaseSpeed(false);
        }
        private void comfortSpeed_button_Click(object sender, EventArgs e)
        {
            IncreaseSpeed(true);
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void IncreaseSpeed(bool isInc)
        {
            if (isInc)
            {
                speed -= 10;
                if (speed < 0)
                {
                    speed = 0;

                    comfortSpeed_button.Enabled = false;
                    sportSpeed_button.Enabled = true;
                }
            }
            else
            {
                speed += 10;
                if (speed > 200)
                {
                    speed = 200;

                    sportSpeed_button.Enabled = false;
                    comfortSpeed_button.Enabled = true;

                }
            }


            speedTxt.Text = Convert.ToString(speed);
            char spd = Convert.ToChar(speed / 10 + 33);
            SendCommand(spd);
        }
    }
}
