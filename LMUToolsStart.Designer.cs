namespace LMUTools
{
    partial class LMUToolsStart
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
            menuStrip1 = new MenuStrip();
            replayToolStripMenuItem = new ToolStripMenuItem();
            replayToolStripMenuItem1 = new ToolStripMenuItem();
            vCRStreamToolStripMenuItem = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            restAPIRefreshRateToolStripMenuItem = new ToolStripMenuItem();
            tsmiCurrentRefreshRate = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            tsmiAdd1000ms = new ToolStripMenuItem();
            tsmiSubtract1000ms = new ToolStripMenuItem();
            tsmiDisableRefreshRate = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            tsslRestApi = new ToolStripStatusLabel();
            bwRestStatus = new System.ComponentModel.BackgroundWorker();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { replayToolStripMenuItem, optionsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1554, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // replayToolStripMenuItem
            // 
            replayToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { replayToolStripMenuItem1, vCRStreamToolStripMenuItem });
            replayToolStripMenuItem.Name = "replayToolStripMenuItem";
            replayToolStripMenuItem.Size = new Size(46, 20);
            replayToolStripMenuItem.Text = "Tools";
            // 
            // replayToolStripMenuItem1
            // 
            replayToolStripMenuItem1.Name = "replayToolStripMenuItem1";
            replayToolStripMenuItem1.Size = new Size(180, 22);
            replayToolStripMenuItem1.Text = "Replay";
            replayToolStripMenuItem1.Click += replayToolStripMenuItem1_Click;
            // 
            // vCRStreamToolStripMenuItem
            // 
            vCRStreamToolStripMenuItem.Name = "vCRStreamToolStripMenuItem";
            vCRStreamToolStripMenuItem.Size = new Size(180, 22);
            vCRStreamToolStripMenuItem.Text = "VCR Stream";
            vCRStreamToolStripMenuItem.Visible = false;
            vCRStreamToolStripMenuItem.Click += vCRStreamToolStripMenuItem_Click;
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { restAPIRefreshRateToolStripMenuItem });
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(61, 20);
            optionsToolStripMenuItem.Text = "Options";
            // 
            // restAPIRefreshRateToolStripMenuItem
            // 
            restAPIRefreshRateToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsmiCurrentRefreshRate, toolStripMenuItem1, tsmiAdd1000ms, tsmiSubtract1000ms, tsmiDisableRefreshRate });
            restAPIRefreshRateToolStripMenuItem.Name = "restAPIRefreshRateToolStripMenuItem";
            restAPIRefreshRateToolStripMenuItem.Size = new Size(182, 22);
            restAPIRefreshRateToolStripMenuItem.Text = "Rest API Refresh rate";
            // 
            // tsmiCurrentRefreshRate
            // 
            tsmiCurrentRefreshRate.Name = "tsmiCurrentRefreshRate";
            tsmiCurrentRefreshRate.Size = new Size(151, 22);
            tsmiCurrentRefreshRate.Text = "Current: ";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(148, 6);
            // 
            // tsmiAdd1000ms
            // 
            tsmiAdd1000ms.Name = "tsmiAdd1000ms";
            tsmiAdd1000ms.Size = new Size(151, 22);
            tsmiAdd1000ms.Text = "+1000 ms";
            tsmiAdd1000ms.Click += tsmiAdd1000ms_Click;
            // 
            // tsmiSubtract1000ms
            // 
            tsmiSubtract1000ms.Name = "tsmiSubtract1000ms";
            tsmiSubtract1000ms.Size = new Size(151, 22);
            tsmiSubtract1000ms.Text = "- 1000 ms";
            tsmiSubtract1000ms.Click += tsmiSubtract1000ms_Click;
            // 
            // tsmiDisableRefreshRate
            // 
            tsmiDisableRefreshRate.Name = "tsmiDisableRefreshRate";
            tsmiDisableRefreshRate.Size = new Size(151, 22);
            tsmiDisableRefreshRate.Text = "Disable refresh";
            tsmiDisableRefreshRate.Click += tsmiDisableRefreshRate_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { tsslRestApi });
            statusStrip1.Location = new Point(0, 604);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1554, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // tsslRestApi
            // 
            tsslRestApi.Name = "tsslRestApi";
            tsslRestApi.Size = new Size(110, 17);
            tsslRestApi.Text = "REST API not online";
            // 
            // bwRestStatus
            // 
            bwRestStatus.DoWork += bwRestStatus_DoWork;
            // 
            // LMUToolsStart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1554, 626);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "LMUToolsStart";
            Text = "LMU-Tools";
            Load += LMUToolsStart_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem replayToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tsslRestApi;
        private System.ComponentModel.BackgroundWorker bwRestStatus;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem restAPIRefreshRateToolStripMenuItem;
        private ToolStripMenuItem tsmiCurrentRefreshRate;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem tsmiAdd1000ms;
        private ToolStripMenuItem tsmiSubtract1000ms;
        private ToolStripMenuItem tsmiDisableRefreshRate;
        private ToolStripMenuItem replayToolStripMenuItem1;
        private ToolStripMenuItem vCRStreamToolStripMenuItem;
    }
}
