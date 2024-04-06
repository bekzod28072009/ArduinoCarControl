using System.IO;
using System.IO.Ports;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ArduinoCarControl
{
    public partial class Form1 : Form
    {
        int speed = 200;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            speedTxt.Text = Convert.ToString(speed);
        }

        private void SendCommand(char command)
        {
            //try
            //{

            //    IPAddress serverIP = IPAddress.Parse("192.168.68.120");
            //    int port = 8080;

            //    Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);


            //    clientSocket.Connect(new IPEndPoint(serverIP, port));


            //    string data = "Hello, WiFi Client!"; 
            //    byte[] buffer = Encoding.ASCII.GetBytes(data);
            //    clientSocket.Send(buffer);


            //    clientSocket.Shutdown(SocketShutdown.Both);
            //    clientSocket.Close();

            //    MessageBox.Show("Data sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
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

        private void send_button_Click(object sender, EventArgs e)
        {
            try
            {

                IPAddress serverIP = IPAddress.Parse("192.168.68.120"); 
                int port = 8080; 

                Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                
                clientSocket.Connect(new IPEndPoint(serverIP, port));

                
                string data = "Hello, WiFi Client!";
                byte[] buffer = Encoding.ASCII.GetBytes(data);
                clientSocket.Send(buffer);

                
                clientSocket.Shutdown(SocketShutdown.Both);
                clientSocket.Close();

                MessageBox.Show("Data sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
