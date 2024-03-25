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
                sportSpeed_button.Enabled = true;
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
        }

        private void sportSpeed_button_Click(object sender, EventArgs e)
        {
            SendCommand('+');
            sportSpeed_button.Enabled = false;
            if (comfortSpeed_button.Enabled == false)
            {
                comfortSpeed_button.Enabled = true;
            }
        }
        private void comfortSpeed_button_Click(object sender, EventArgs e)
        {
            SendCommand('-');
            comfortSpeed_button.Enabled = false;
            if (sportSpeed_button.Enabled == false)
            {
                sportSpeed_button.Enabled = true;
            }
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void score_button_Click(object sender, EventArgs e)
        {

        }
    }
}
