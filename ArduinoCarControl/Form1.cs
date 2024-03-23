using System.IO.Ports;

namespace ArduinoCarControl
{
    public partial class Form1 : Form
    {
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
        }

        private void stopButton_Click_Click(object sender, EventArgs e)
        {
            SendCommand('S');
        }

        private void sportSpeed_button_Click(object sender, EventArgs e)
        {
            SendCommand('+');
        }
        private void comfortSpeed_button_Click(object sender, EventArgs e)
        {
            SendCommand('-');
        }
    }
}
