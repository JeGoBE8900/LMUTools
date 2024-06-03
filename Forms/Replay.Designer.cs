namespace LMUTools.Forms
{
    partial class Replay
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            cboReplayFiles = new ComboBox();
            label2 = new Label();
            btnLoad = new Button();
            txtReplayInfo = new TextBox();
            bwReplayInfo = new System.ComponentModel.BackgroundWorker();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            txtSessionInfo = new TextBox();
            tabPage2 = new TabPage();
            lvwStandings = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            tabPage3 = new TabPage();
            label6 = new Label();
            cboResultIncDriver = new ComboBox();
            lvwIncidents = new ListView();
            columnHeader10 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            tabPage4 = new TabPage();
            lblCar = new Label();
            label5 = new Label();
            cboResultLapDriver = new ComboBox();
            lvwDriverLaptimes = new ListView();
            columnHeader17 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader18 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            columnHeader15 = new ColumnHeader();
            columnHeader16 = new ColumnHeader();
            columnHeader19 = new ColumnHeader();
            columnHeader20 = new ColumnHeader();
            columnHeader21 = new ColumnHeader();
            columnHeader22 = new ColumnHeader();
            lblIsActive = new Label();
            cmStanding = new ContextMenuStrip(components);
            jumpToDriverToolStripMenuItem = new ToolStripMenuItem();
            label3 = new Label();
            txtReplayFile = new TextBox();
            button1 = new Button();
            ofdResultFile = new OpenFileDialog();
            cmIncident = new ContextMenuStrip(components);
            jumpToIncidentToolStripMenuItem = new ToolStripMenuItem();
            nudTimeSync = new NumericUpDown();
            label4 = new Label();
            cmLaptime = new ContextMenuStrip(components);
            jumpToLapToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            btnSpeed7 = new Button();
            btnSpeed2 = new Button();
            btnSpeed10 = new Button();
            btnSpeed6 = new Button();
            btnSpeed9 = new Button();
            btnSpeed8 = new Button();
            btnSpeed5 = new Button();
            btnSpeed4 = new Button();
            btnSpeed3 = new Button();
            label7 = new Label();
            txtCurrentDriver = new TextBox();
            groupBox2 = new GroupBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            btnOnboard0 = new Button();
            btnOnboard1 = new Button();
            btnTrackside0 = new Button();
            btnTrackside1 = new Button();
            btnDriving0 = new Button();
            btnDriving1 = new Button();
            btnReplayRefresh = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            cmStanding.SuspendLayout();
            cmIncident.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTimeSync).BeginInit();
            cmLaptime.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Replay File:";
            // 
            // cboReplayFiles
            // 
            cboReplayFiles.DropDownStyle = ComboBoxStyle.DropDownList;
            cboReplayFiles.FormattingEnabled = true;
            cboReplayFiles.Location = new Point(97, 35);
            cboReplayFiles.Name = "cboReplayFiles";
            cboReplayFiles.Size = new Size(428, 23);
            cboReplayFiles.TabIndex = 1;
            cboReplayFiles.SelectedIndexChanged += cboReplayFiles_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 2;
            label2.Text = "Last replay:";
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(563, 35);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(43, 23);
            btnLoad.TabIndex = 3;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += button1_Click;
            // 
            // txtReplayInfo
            // 
            txtReplayInfo.Enabled = false;
            txtReplayInfo.Location = new Point(97, 6);
            txtReplayInfo.Name = "txtReplayInfo";
            txtReplayInfo.ReadOnly = true;
            txtReplayInfo.Size = new Size(460, 23);
            txtReplayInfo.TabIndex = 4;
            // 
            // bwReplayInfo
            // 
            bwReplayInfo.DoWork += bwReplayInfo_DoWork;
            bwReplayInfo.RunWorkerCompleted += bwReplayInfo_RunWorkerCompleted;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(6, 125);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1595, 651);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtSessionInfo);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1587, 623);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Session Info";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtSessionInfo
            // 
            txtSessionInfo.Dock = DockStyle.Fill;
            txtSessionInfo.Location = new Point(3, 3);
            txtSessionInfo.Multiline = true;
            txtSessionInfo.Name = "txtSessionInfo";
            txtSessionInfo.ReadOnly = true;
            txtSessionInfo.Size = new Size(1581, 617);
            txtSessionInfo.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lvwStandings);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1587, 623);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Standings";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lvwStandings
            // 
            lvwStandings.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9 });
            lvwStandings.Dock = DockStyle.Fill;
            lvwStandings.FullRowSelect = true;
            lvwStandings.GridLines = true;
            lvwStandings.Location = new Point(3, 3);
            lvwStandings.MultiSelect = false;
            lvwStandings.Name = "lvwStandings";
            lvwStandings.Size = new Size(1581, 617);
            lvwStandings.TabIndex = 0;
            lvwStandings.UseCompatibleStateImageBehavior = false;
            lvwStandings.View = View.Details;
            lvwStandings.SelectedIndexChanged += lvwStandings_SelectedIndexChanged;
            lvwStandings.MouseClick += lvwStandings_MouseClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Pos.";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "SlotID";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Driver";
            columnHeader3.Width = 400;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Class";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Vehicle";
            columnHeader5.Width = 200;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(cboResultIncDriver);
            tabPage3.Controls.Add(lvwIncidents);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1587, 623);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Result | Incidents";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 7);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 10;
            label6.Text = "Driver:";
            // 
            // cboResultIncDriver
            // 
            cboResultIncDriver.DropDownStyle = ComboBoxStyle.DropDownList;
            cboResultIncDriver.FormattingEnabled = true;
            cboResultIncDriver.Location = new Point(57, 4);
            cboResultIncDriver.Name = "cboResultIncDriver";
            cboResultIncDriver.Size = new Size(408, 23);
            cboResultIncDriver.TabIndex = 9;
            cboResultIncDriver.SelectedIndexChanged += cboResultIncDriver_SelectedIndexChanged;
            // 
            // lvwIncidents
            // 
            lvwIncidents.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvwIncidents.Columns.AddRange(new ColumnHeader[] { columnHeader10, columnHeader12, columnHeader11 });
            lvwIncidents.FullRowSelect = true;
            lvwIncidents.GridLines = true;
            lvwIncidents.Location = new Point(0, 32);
            lvwIncidents.MultiSelect = false;
            lvwIncidents.Name = "lvwIncidents";
            lvwIncidents.Size = new Size(1587, 616);
            lvwIncidents.TabIndex = 0;
            lvwIncidents.UseCompatibleStateImageBehavior = false;
            lvwIncidents.View = View.Details;
            lvwIncidents.MouseClick += lvwIncidents_MouseClick;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Time";
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "SlotID";
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Incident";
            columnHeader11.Width = 600;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(lblCar);
            tabPage4.Controls.Add(label5);
            tabPage4.Controls.Add(cboResultLapDriver);
            tabPage4.Controls.Add(lvwDriverLaptimes);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1587, 623);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Result | Driver laptimes";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // lblCar
            // 
            lblCar.AutoSize = true;
            lblCar.Location = new Point(481, 8);
            lblCar.Name = "lblCar";
            lblCar.Size = new Size(52, 15);
            lblCar.TabIndex = 9;
            lblCar.Text = "               ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 8);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 8;
            label5.Text = "Driver:";
            // 
            // cboResultLapDriver
            // 
            cboResultLapDriver.DropDownStyle = ComboBoxStyle.DropDownList;
            cboResultLapDriver.FormattingEnabled = true;
            cboResultLapDriver.Location = new Point(56, 5);
            cboResultLapDriver.Name = "cboResultLapDriver";
            cboResultLapDriver.Size = new Size(409, 23);
            cboResultLapDriver.TabIndex = 2;
            cboResultLapDriver.SelectedIndexChanged += cboResultLapDriver_SelectedIndexChanged;
            // 
            // lvwDriverLaptimes
            // 
            lvwDriverLaptimes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvwDriverLaptimes.Columns.AddRange(new ColumnHeader[] { columnHeader17, columnHeader13, columnHeader18, columnHeader14, columnHeader15, columnHeader16, columnHeader19, columnHeader20, columnHeader21, columnHeader22 });
            lvwDriverLaptimes.FullRowSelect = true;
            lvwDriverLaptimes.GridLines = true;
            lvwDriverLaptimes.Location = new Point(0, 34);
            lvwDriverLaptimes.MultiSelect = false;
            lvwDriverLaptimes.Name = "lvwDriverLaptimes";
            lvwDriverLaptimes.Size = new Size(1587, 614);
            lvwDriverLaptimes.TabIndex = 1;
            lvwDriverLaptimes.UseCompatibleStateImageBehavior = false;
            lvwDriverLaptimes.View = View.Details;
            lvwDriverLaptimes.MouseClick += lvwDriverLaptimes_MouseClick;
            // 
            // columnHeader17
            // 
            columnHeader17.Text = "Time";
            columnHeader17.Width = 100;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Lap";
            columnHeader13.Width = 100;
            // 
            // columnHeader18
            // 
            columnHeader18.Text = "Position";
            columnHeader18.Width = 100;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "S1";
            columnHeader14.Width = 100;
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "S2";
            columnHeader15.Width = 100;
            // 
            // columnHeader16
            // 
            columnHeader16.Text = "S3";
            columnHeader16.Width = 100;
            // 
            // columnHeader19
            // 
            columnHeader19.Text = "Laptime";
            columnHeader19.Width = 100;
            // 
            // columnHeader20
            // 
            columnHeader20.Text = "Max speed";
            columnHeader20.Width = 100;
            // 
            // columnHeader21
            // 
            columnHeader21.Text = "Front tyre";
            columnHeader21.Width = 100;
            // 
            // columnHeader22
            // 
            columnHeader22.Text = "Rear tyre";
            columnHeader22.Width = 100;
            // 
            // lblIsActive
            // 
            lblIsActive.AutoSize = true;
            lblIsActive.Location = new Point(563, 9);
            lblIsActive.Name = "lblIsActive";
            lblIsActive.Size = new Size(0, 15);
            lblIsActive.TabIndex = 6;
            // 
            // cmStanding
            // 
            cmStanding.Items.AddRange(new ToolStripItem[] { jumpToDriverToolStripMenuItem });
            cmStanding.Name = "cmStanding";
            cmStanding.Size = new Size(151, 26);
            cmStanding.Opening += contextMenuStrip1_Opening;
            // 
            // jumpToDriverToolStripMenuItem
            // 
            jumpToDriverToolStripMenuItem.Name = "jumpToDriverToolStripMenuItem";
            jumpToDriverToolStripMenuItem.Size = new Size(150, 22);
            jumpToDriverToolStripMenuItem.Text = "Jump to driver";
            jumpToDriverToolStripMenuItem.Click += jumpToDriverToolStripMenuItem_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 65);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 7;
            label3.Text = "Result file:";
            // 
            // txtReplayFile
            // 
            txtReplayFile.Enabled = false;
            txtReplayFile.Location = new Point(97, 62);
            txtReplayFile.Name = "txtReplayFile";
            txtReplayFile.ReadOnly = true;
            txtReplayFile.Size = new Size(460, 23);
            txtReplayFile.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(563, 62);
            button1.Name = "button1";
            button1.Size = new Size(43, 23);
            button1.TabIndex = 9;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // ofdResultFile
            // 
            ofdResultFile.FileName = "openFileDialog1";
            // 
            // cmIncident
            // 
            cmIncident.Items.AddRange(new ToolStripItem[] { jumpToIncidentToolStripMenuItem });
            cmIncident.Name = "cmIncident";
            cmIncident.Size = new Size(164, 26);
            // 
            // jumpToIncidentToolStripMenuItem
            // 
            jumpToIncidentToolStripMenuItem.Name = "jumpToIncidentToolStripMenuItem";
            jumpToIncidentToolStripMenuItem.Size = new Size(163, 22);
            jumpToIncidentToolStripMenuItem.Text = "Jump to incident";
            jumpToIncidentToolStripMenuItem.Click += jumpToIncidentToolStripMenuItem_Click;
            // 
            // nudTimeSync
            // 
            nudTimeSync.Location = new Point(1065, 11);
            nudTimeSync.Maximum = new decimal(new int[] { 360, 0, 0, 0 });
            nudTimeSync.Minimum = new decimal(new int[] { 360, 0, 0, int.MinValue });
            nudTimeSync.Name = "nudTimeSync";
            nudTimeSync.Size = new Size(56, 23);
            nudTimeSync.TabIndex = 10;
            nudTimeSync.Value = new decimal(new int[] { 10, 0, 0, int.MinValue });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(916, 14);
            label4.Name = "label4";
            label4.Size = new Size(143, 15);
            label4.TabIndex = 11;
            label4.Text = "Add seconds to result file:";
            // 
            // cmLaptime
            // 
            cmLaptime.Items.AddRange(new ToolStripItem[] { jumpToLapToolStripMenuItem });
            cmLaptime.Name = "cmLaptime";
            cmLaptime.Size = new Size(137, 26);
            // 
            // jumpToLapToolStripMenuItem
            // 
            jumpToLapToolStripMenuItem.Name = "jumpToLapToolStripMenuItem";
            jumpToLapToolStripMenuItem.Size = new Size(136, 22);
            jumpToLapToolStripMenuItem.Text = "Jump to lap";
            jumpToLapToolStripMenuItem.Click += jumpToLapToolStripMenuItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSpeed7);
            groupBox1.Controls.Add(btnSpeed2);
            groupBox1.Controls.Add(btnSpeed10);
            groupBox1.Controls.Add(btnSpeed6);
            groupBox1.Controls.Add(btnSpeed9);
            groupBox1.Controls.Add(btnSpeed8);
            groupBox1.Controls.Add(btnSpeed5);
            groupBox1.Controls.Add(btnSpeed4);
            groupBox1.Controls.Add(btnSpeed3);
            groupBox1.Location = new Point(916, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(528, 50);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Speed Controller";
            // 
            // btnSpeed7
            // 
            btnSpeed7.Location = new Point(285, 21);
            btnSpeed7.Name = "btnSpeed7";
            btnSpeed7.Size = new Size(56, 23);
            btnSpeed7.TabIndex = 16;
            btnSpeed7.Text = ">";
            btnSpeed7.UseVisualStyleBackColor = true;
            btnSpeed7.Click += btnSpeed7_Click;
            // 
            // btnSpeed2
            // 
            btnSpeed2.Location = new Point(6, 21);
            btnSpeed2.Name = "btnSpeed2";
            btnSpeed2.Size = new Size(56, 23);
            btnSpeed2.TabIndex = 13;
            btnSpeed2.Text = "<<<<";
            btnSpeed2.UseVisualStyleBackColor = true;
            btnSpeed2.Click += btnSpeed2_Click;
            // 
            // btnSpeed10
            // 
            btnSpeed10.Location = new Point(453, 21);
            btnSpeed10.Name = "btnSpeed10";
            btnSpeed10.Size = new Size(56, 23);
            btnSpeed10.TabIndex = 18;
            btnSpeed10.Text = ">>>>";
            btnSpeed10.UseVisualStyleBackColor = true;
            btnSpeed10.Click += btnSpeed10_Click;
            // 
            // btnSpeed6
            // 
            btnSpeed6.Location = new Point(229, 21);
            btnSpeed6.Name = "btnSpeed6";
            btnSpeed6.Size = new Size(56, 23);
            btnSpeed6.TabIndex = 15;
            btnSpeed6.Text = "||";
            btnSpeed6.UseVisualStyleBackColor = true;
            btnSpeed6.Click += btnSpeed6_Click;
            // 
            // btnSpeed9
            // 
            btnSpeed9.Location = new Point(397, 21);
            btnSpeed9.Name = "btnSpeed9";
            btnSpeed9.Size = new Size(56, 23);
            btnSpeed9.TabIndex = 17;
            btnSpeed9.Text = ">>>";
            btnSpeed9.UseVisualStyleBackColor = true;
            btnSpeed9.Click += btnSpeed9_Click;
            // 
            // btnSpeed8
            // 
            btnSpeed8.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            btnSpeed8.Location = new Point(341, 21);
            btnSpeed8.Name = "btnSpeed8";
            btnSpeed8.Size = new Size(56, 23);
            btnSpeed8.TabIndex = 15;
            btnSpeed8.Text = ">>";
            btnSpeed8.UseVisualStyleBackColor = true;
            btnSpeed8.Click += btnSpeed8_Click;
            // 
            // btnSpeed5
            // 
            btnSpeed5.Location = new Point(173, 21);
            btnSpeed5.Name = "btnSpeed5";
            btnSpeed5.Size = new Size(56, 23);
            btnSpeed5.TabIndex = 14;
            btnSpeed5.Text = "<";
            btnSpeed5.UseVisualStyleBackColor = true;
            btnSpeed5.Click += btnSpeed5_Click;
            // 
            // btnSpeed4
            // 
            btnSpeed4.Location = new Point(118, 21);
            btnSpeed4.Name = "btnSpeed4";
            btnSpeed4.Size = new Size(56, 23);
            btnSpeed4.TabIndex = 13;
            btnSpeed4.Text = "<<";
            btnSpeed4.UseVisualStyleBackColor = true;
            btnSpeed4.Click += btnSpeed4_Click;
            // 
            // btnSpeed3
            // 
            btnSpeed3.Location = new Point(62, 21);
            btnSpeed3.Name = "btnSpeed3";
            btnSpeed3.Size = new Size(56, 23);
            btnSpeed3.TabIndex = 0;
            btnSpeed3.Text = "<<<";
            btnSpeed3.UseVisualStyleBackColor = true;
            btnSpeed3.Click += btnSpeed3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 95);
            label7.Name = "label7";
            label7.Size = new Size(83, 15);
            label7.TabIndex = 13;
            label7.Text = "Current driver:";
            // 
            // txtCurrentDriver
            // 
            txtCurrentDriver.Enabled = false;
            txtCurrentDriver.Location = new Point(97, 91);
            txtCurrentDriver.Name = "txtCurrentDriver";
            txtCurrentDriver.ReadOnly = true;
            txtCurrentDriver.Size = new Size(460, 23);
            txtCurrentDriver.TabIndex = 14;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(btnOnboard0);
            groupBox2.Controls.Add(btnOnboard1);
            groupBox2.Controls.Add(btnTrackside0);
            groupBox2.Controls.Add(btnTrackside1);
            groupBox2.Controls.Add(btnDriving0);
            groupBox2.Controls.Add(btnDriving1);
            groupBox2.Location = new Point(696, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(204, 113);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Camera";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(7, 77);
            label10.Name = "label10";
            label10.Size = new Size(57, 15);
            label10.TabIndex = 22;
            label10.Text = "Onboard:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 52);
            label9.Name = "label9";
            label9.Size = new Size(58, 15);
            label9.TabIndex = 21;
            label9.Text = "Trackside:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 27);
            label8.Name = "label8";
            label8.Size = new Size(48, 15);
            label8.TabIndex = 20;
            label8.Text = "Driving:";
            // 
            // btnOnboard0
            // 
            btnOnboard0.Location = new Point(73, 78);
            btnOnboard0.Name = "btnOnboard0";
            btnOnboard0.Size = new Size(56, 23);
            btnOnboard0.TabIndex = 19;
            btnOnboard0.Text = "<";
            btnOnboard0.UseVisualStyleBackColor = true;
            btnOnboard0.Click += btnOnboard0_Click;
            // 
            // btnOnboard1
            // 
            btnOnboard1.Location = new Point(129, 78);
            btnOnboard1.Name = "btnOnboard1";
            btnOnboard1.Size = new Size(56, 23);
            btnOnboard1.TabIndex = 18;
            btnOnboard1.Text = ">";
            btnOnboard1.UseVisualStyleBackColor = true;
            btnOnboard1.Click += btnOnboard1_Click;
            // 
            // btnTrackside0
            // 
            btnTrackside0.Location = new Point(73, 49);
            btnTrackside0.Name = "btnTrackside0";
            btnTrackside0.Size = new Size(56, 23);
            btnTrackside0.TabIndex = 17;
            btnTrackside0.Text = "<";
            btnTrackside0.UseVisualStyleBackColor = true;
            btnTrackside0.Click += btnTrackside0_Click;
            // 
            // btnTrackside1
            // 
            btnTrackside1.Location = new Point(129, 49);
            btnTrackside1.Name = "btnTrackside1";
            btnTrackside1.Size = new Size(56, 23);
            btnTrackside1.TabIndex = 16;
            btnTrackside1.Text = ">";
            btnTrackside1.UseVisualStyleBackColor = true;
            btnTrackside1.Click += btnTrackside1_Click;
            // 
            // btnDriving0
            // 
            btnDriving0.Location = new Point(73, 23);
            btnDriving0.Name = "btnDriving0";
            btnDriving0.Size = new Size(56, 23);
            btnDriving0.TabIndex = 15;
            btnDriving0.Text = "<";
            btnDriving0.UseVisualStyleBackColor = true;
            btnDriving0.Click += btnDriving0_Click;
            // 
            // btnDriving1
            // 
            btnDriving1.Location = new Point(129, 23);
            btnDriving1.Name = "btnDriving1";
            btnDriving1.Size = new Size(56, 23);
            btnDriving1.TabIndex = 14;
            btnDriving1.Text = ">";
            btnDriving1.UseVisualStyleBackColor = true;
            btnDriving1.Click += btnDriving1_Click;
            // 
            // btnReplayRefresh
            // 
            btnReplayRefresh.BackgroundImage = Properties.Resources.refresh_double_rounded_flat;
            btnReplayRefresh.BackgroundImageLayout = ImageLayout.Zoom;
            btnReplayRefresh.Location = new Point(531, 33);
            btnReplayRefresh.Name = "btnReplayRefresh";
            btnReplayRefresh.Size = new Size(26, 25);
            btnReplayRefresh.TabIndex = 16;
            btnReplayRefresh.UseVisualStyleBackColor = true;
            btnReplayRefresh.Click += btnReplayRefresh_Click;
            // 
            // Replay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1602, 779);
            Controls.Add(btnReplayRefresh);
            Controls.Add(groupBox2);
            Controls.Add(txtCurrentDriver);
            Controls.Add(label7);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(nudTimeSync);
            Controls.Add(button1);
            Controls.Add(txtReplayFile);
            Controls.Add(label3);
            Controls.Add(lblIsActive);
            Controls.Add(tabControl1);
            Controls.Add(txtReplayInfo);
            Controls.Add(btnLoad);
            Controls.Add(label2);
            Controls.Add(cboReplayFiles);
            Controls.Add(label1);
            Name = "Replay";
            Text = "Replay";
            FormClosing += Replay_FormClosing;
            Load += Replay_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            cmStanding.ResumeLayout(false);
            cmIncident.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudTimeSync).EndInit();
            cmLaptime.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboReplayFiles;
        private Label label2;
        private Button btnLoad;
        private TextBox txtReplayInfo;
        private System.ComponentModel.BackgroundWorker bwReplayInfo;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox txtSessionInfo;
        private Label lblIsActive;
        private ListView lvwStandings;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ContextMenuStrip cmStanding;
        private ToolStripMenuItem jumpToDriverToolStripMenuItem;
        private Label label3;
        private TextBox txtReplayFile;
        private Button button1;
        private TabPage tabPage3;
        private OpenFileDialog ofdResultFile;
        private ListView lvwIncidents;
        private TabPage tabPage4;
        private ListView lvwDriverLaptimes;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ContextMenuStrip cmIncident;
        private ToolStripMenuItem jumpToIncidentToolStripMenuItem;
        private NumericUpDown nudTimeSync;
        private Label label4;
        private ColumnHeader columnHeader17;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader18;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private ColumnHeader columnHeader16;
        private ColumnHeader columnHeader19;
        private ColumnHeader columnHeader20;
        private ContextMenuStrip cmLaptime;
        private Label label5;
        private ComboBox cboResultLapDriver;
        private Label label6;
        private ComboBox cboResultIncDriver;
        private ColumnHeader columnHeader21;
        private ColumnHeader columnHeader22;
        private Label lblCar;
        private ToolStripMenuItem jumpToLapToolStripMenuItem;
        private GroupBox groupBox1;
        private Button btnSpeed7;
        private Button btnSpeed2;
        private Button btnSpeed10;
        private Button btnSpeed6;
        private Button btnSpeed9;
        private Button btnSpeed8;
        private Button btnSpeed5;
        private Button btnSpeed4;
        private Button btnSpeed3;
        private Label label7;
        private TextBox txtCurrentDriver;
        private GroupBox groupBox2;
        private Label label9;
        private Label label8;
        private Button btnOnboard0;
        private Button btnOnboard1;
        private Button btnTrackside0;
        private Button btnTrackside1;
        private Button btnDriving0;
        private Button btnDriving1;
        private Label label10;
        private Button btnReplayRefresh;
    }
}