namespace LMUTools.Forms
{
    partial class VCRStream
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtFile = new TextBox();
            button1 = new Button();
            label1 = new Label();
            ofdResultFile = new OpenFileDialog();
            txtConsole = new TextBox();
            label2 = new Label();
            btnStart = new Button();
            btnStop = new Button();
            SuspendLayout();
            // 
            // txtFile
            // 
            txtFile.Enabled = false;
            txtFile.Location = new Point(43, 11);
            txtFile.Name = "txtFile";
            txtFile.ReadOnly = true;
            txtFile.Size = new Size(476, 23);
            txtFile.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(525, 10);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Browse";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 2;
            label1.Text = "File";
            // 
            // ofdResultFile
            // 
            ofdResultFile.FileName = "openFileDialog1";
            // 
            // txtConsole
            // 
            txtConsole.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtConsole.Enabled = false;
            txtConsole.Location = new Point(4, 286);
            txtConsole.Multiline = true;
            txtConsole.Name = "txtConsole";
            txtConsole.ReadOnly = true;
            txtConsole.Size = new Size(1019, 158);
            txtConsole.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 268);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 4;
            label2.Text = "Console:";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(751, 10);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 5;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(832, 11);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(75, 23);
            btnStop.TabIndex = 6;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            // 
            // VCRStream
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 447);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(label2);
            Controls.Add(txtConsole);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(txtFile);
            Name = "VCRStream";
            Text = "VCRStream";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFile;
        private Button button1;
        private Label label1;
        private OpenFileDialog ofdResultFile;
        private TextBox txtConsole;
        private Label label2;
        private Button btnStart;
        private Button btnStop;
    }
}