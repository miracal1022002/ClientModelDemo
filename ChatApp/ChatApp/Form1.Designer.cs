namespace ChatApp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Startbutton = new System.Windows.Forms.Button();
            this.ServerPorttextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ServerIPtextbox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Connectbutton = new System.Windows.Forms.Button();
            this.ClientPorttextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ClientIPtextbox = new System.Windows.Forms.TextBox();
            this.ChatScreentextbox = new System.Windows.Forms.TextBox();
            this.Messagetextbox = new System.Windows.Forms.TextBox();
            this.Sendbutton = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Startbutton);
            this.groupBox1.Controls.Add(this.ServerPorttextbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ServerIPtextbox);
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(739, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server";
            // 
            // Startbutton
            // 
            this.Startbutton.Location = new System.Drawing.Point(639, 25);
            this.Startbutton.Name = "Startbutton";
            this.Startbutton.Size = new System.Drawing.Size(94, 29);
            this.Startbutton.TabIndex = 4;
            this.Startbutton.Text = "Start";
            this.Startbutton.UseVisualStyleBackColor = true;
            this.Startbutton.Click += new System.EventHandler(this.Startbutton_Click);
            // 
            // ServerPorttextbox
            // 
            this.ServerPorttextbox.Location = new System.Drawing.Point(378, 26);
            this.ServerPorttextbox.Name = "ServerPorttextbox";
            this.ServerPorttextbox.Size = new System.Drawing.Size(255, 27);
            this.ServerPorttextbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP";
            // 
            // ServerIPtextbox
            // 
            this.ServerIPtextbox.Location = new System.Drawing.Point(46, 26);
            this.ServerIPtextbox.Name = "ServerIPtextbox";
            this.ServerIPtextbox.Size = new System.Drawing.Size(277, 27);
            this.ServerIPtextbox.TabIndex = 0;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Connectbutton);
            this.groupBox2.Controls.Add(this.ClientPorttextbox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.ClientIPtextbox);
            this.groupBox2.Location = new System.Drawing.Point(27, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(739, 60);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Client";
            // 
            // Connectbutton
            // 
            this.Connectbutton.Location = new System.Drawing.Point(639, 24);
            this.Connectbutton.Name = "Connectbutton";
            this.Connectbutton.Size = new System.Drawing.Size(94, 29);
            this.Connectbutton.TabIndex = 5;
            this.Connectbutton.Text = "Connect";
            this.Connectbutton.UseVisualStyleBackColor = true;
            this.Connectbutton.Click += new System.EventHandler(this.Connectbutton_Click);
            // 
            // ClientPorttextbox
            // 
            this.ClientPorttextbox.Location = new System.Drawing.Point(378, 26);
            this.ClientPorttextbox.Name = "ClientPorttextbox";
            this.ClientPorttextbox.Size = new System.Drawing.Size(255, 27);
            this.ClientPorttextbox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "IP";
            // 
            // ClientIPtextbox
            // 
            this.ClientIPtextbox.Location = new System.Drawing.Point(46, 26);
            this.ClientIPtextbox.Name = "ClientIPtextbox";
            this.ClientIPtextbox.Size = new System.Drawing.Size(277, 27);
            this.ClientIPtextbox.TabIndex = 0;
            // 
            // ChatScreentextbox
            // 
            this.ChatScreentextbox.Location = new System.Drawing.Point(27, 144);
            this.ChatScreentextbox.Multiline = true;
            this.ChatScreentextbox.Name = "ChatScreentextbox";
            this.ChatScreentextbox.Size = new System.Drawing.Size(739, 210);
            this.ChatScreentextbox.TabIndex = 5;
            // 
            // Messagetextbox
            // 
            this.Messagetextbox.Location = new System.Drawing.Point(27, 360);
            this.Messagetextbox.Multiline = true;
            this.Messagetextbox.Name = "Messagetextbox";
            this.Messagetextbox.Size = new System.Drawing.Size(602, 79);
            this.Messagetextbox.TabIndex = 6;
            // 
            // Sendbutton
            // 
            this.Sendbutton.Location = new System.Drawing.Point(635, 360);
            this.Sendbutton.Name = "Sendbutton";
            this.Sendbutton.Size = new System.Drawing.Size(131, 78);
            this.Sendbutton.TabIndex = 7;
            this.Sendbutton.Text = "Send";
            this.Sendbutton.UseVisualStyleBackColor = true;
            this.Sendbutton.Click += new System.EventHandler(this.Sendbutton_Click);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Sendbutton);
            this.Controls.Add(this.Messagetextbox);
            this.Controls.Add(this.ChatScreentextbox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox ServerIPtextbox;
        private Label label2;
        private Label label1;
        private TextBox ServerPorttextbox;
        private GroupBox groupBox2;
        private TextBox ClientPorttextbox;
        private Label label3;
        private Label label4;
        private TextBox ClientIPtextbox;
        private TextBox ChatScreentextbox;
        private Button Startbutton;
        private Button Connectbutton;
        private TextBox Messagetextbox;
        private Button Sendbutton;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}