namespace ArduinoCarControl
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
            panel1 = new Panel();
            sportSpeed_button = new Button();
            comfortSpeed_button = new Button();
            stopButton_Click = new Button();
            forwardButton_Click = new Button();
            panel3 = new Panel();
            button3 = new Button();
            panel2 = new Panel();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(sportSpeed_button);
            panel1.Controls.Add(comfortSpeed_button);
            panel1.Controls.Add(stopButton_Click);
            panel1.Controls.Add(forwardButton_Click);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(688, 873);
            panel1.TabIndex = 0;
            // 
            // sportSpeed_button
            // 
            sportSpeed_button.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            sportSpeed_button.ForeColor = SystemColors.GrayText;
            sportSpeed_button.Location = new Point(398, 650);
            sportSpeed_button.Name = "sportSpeed_button";
            sportSpeed_button.Size = new Size(223, 122);
            sportSpeed_button.TabIndex = 9;
            sportSpeed_button.Text = "STORT+";
            sportSpeed_button.UseVisualStyleBackColor = true;
            sportSpeed_button.Click += sportSpeed_button_Click;
            // 
            // comfortSpeed_button
            // 
            comfortSpeed_button.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            comfortSpeed_button.ForeColor = SystemColors.GrayText;
            comfortSpeed_button.Location = new Point(32, 650);
            comfortSpeed_button.Name = "comfortSpeed_button";
            comfortSpeed_button.Size = new Size(223, 122);
            comfortSpeed_button.TabIndex = 8;
            comfortSpeed_button.Text = "SPORT";
            comfortSpeed_button.UseVisualStyleBackColor = true;
            comfortSpeed_button.Click += comfortSpeed_button_Click;
            // 
            // stopButton_Click
            // 
            stopButton_Click.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            stopButton_Click.ForeColor = SystemColors.GrayText;
            stopButton_Click.Location = new Point(348, 245);
            stopButton_Click.Name = "stopButton_Click";
            stopButton_Click.Size = new Size(273, 139);
            stopButton_Click.TabIndex = 6;
            stopButton_Click.Text = "STOP";
            stopButton_Click.UseVisualStyleBackColor = true;
            stopButton_Click.Click += stopButton_Click_Click;
            // 
            // forwardButton_Click
            // 
            forwardButton_Click.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            forwardButton_Click.ForeColor = SystemColors.GrayText;
            forwardButton_Click.Location = new Point(12, 245);
            forwardButton_Click.Name = "forwardButton_Click";
            forwardButton_Click.Size = new Size(273, 139);
            forwardButton_Click.TabIndex = 5;
            forwardButton_Click.Text = "START";
            forwardButton_Click.UseVisualStyleBackColor = true;
            forwardButton_Click.Click += forwardButton_Click_Click;
            // 
            // panel3
            // 
            panel3.Location = new Point(3, 572);
            panel3.Name = "panel3";
            panel3.Size = new Size(363, 3);
            panel3.TabIndex = 4;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("SuperFrench", 21.9999981F, FontStyle.Bold, GraphicsUnit.Point, 2);
            button3.ForeColor = Color.Transparent;
            button3.Location = new Point(0, 519);
            button3.Name = "button3";
            button3.Size = new Size(366, 53);
            button3.TabIndex = 3;
            button3.Text = "Speed";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 161);
            panel2.Name = "panel2";
            panel2.Size = new Size(508, 3);
            panel2.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("SuperFrench", 21.9999981F, FontStyle.Bold, GraphicsUnit.Point, 2);
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(0, 115);
            button2.Name = "button2";
            button2.Size = new Size(561, 53);
            button2.TabIndex = 1;
            button2.Text = "Turn the car on or off";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("MV Boli", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(501, 128);
            button1.TabIndex = 0;
            button1.Text = "Car Control";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 873);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button button2;
        private Panel panel2;
        private Panel panel3;
        private Button button3;
        private Button stopButton_Click;
        private Button forwardButton_Click;
        private Button sportSpeed_button;
        private Button comfortSpeed_button;
    }
}
