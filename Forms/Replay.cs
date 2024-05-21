using LMUTools.Classes.LMURESTAPI;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace LMUTools.Forms
{
    public partial class Replay : Form
    {
        public required Classes.LMURESTAPI.LMUAPIRestService oLMUAPIRestService
        { get; set; }

        private XDocument _ResultXMLContent;
        private bool closePending;
        private int _timeBetweenCalls;


        public Replay()
        {
            InitializeComponent();
        }

        private async void Replay_Load(object sender, EventArgs e)
        {
            bwReplayInfo.RunWorkerAsync();

            var replays = (await oLMUAPIRestService.GetLMUReplaysAsync());
            cboReplayFiles.Items.Clear();

            foreach (Classes.LMURESTAPI.LMUReplay o in replays)
            {

                cboReplayFiles.Items.Add(o);


            }

            _timeBetweenCalls = 250;



        }

        private async void bwReplayInfo_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            do
            {

                //Replay info, get last played or current playing replayfle
                Classes.LMURESTAPI.LMUReplay replayInfo = (await oLMUAPIRestService.GetLMUReplayInfoAsync());
                string sReplayInfo = "";

                if (replayInfo != null)
                {
                    sReplayInfo = replayInfo.ToString();
                }

                Action actionReplayInfo = () => txtReplayInfo.Text = sReplayInfo;
                txtReplayInfo.Invoke(actionReplayInfo);


                Thread.Sleep(_timeBetweenCalls);
                if (closePending) { break; }


                //session information

                string sessionInfo = (await oLMUAPIRestService.GetLMUSessionInfo());

                Action actionSessionInfo = () => txtSessionInfo.Text = sessionInfo;
                txtSessionInfo.Invoke(actionSessionInfo);


                Thread.Sleep(_timeBetweenCalls);
                if (closePending) { break; }


                //replay is active

                Boolean isReplayActive = (await oLMUAPIRestService.GetLMUReplayIsActive());

                string sReplayActive = "Not active";
                if (isReplayActive)
                {
                    sReplayActive = "Active";
                }

                Action actionReplayIsActive = () => lblIsActive.Text = sReplayActive;
                lblIsActive.Invoke(actionReplayIsActive);


                Thread.Sleep(_timeBetweenCalls);
                if (closePending) { break; }


                //standings & focus

                var standings = (await oLMUAPIRestService.GetLMUStandingAsync());

                //eerst zien hoeveel listview items we nodig hebben
                int slots2add = standings.Count - lvwStandings.Items.Count;
                if (slots2add > 0)
                {
                    for (int i = 0; i < slots2add; i++)
                    {
                        ListViewItem li = new ListViewItem();
                        li.SubItems.Add("");
                        li.SubItems.Add("");
                        li.SubItems.Add("");
                        li.SubItems.Add("");

                        Action actionUpdateStanding1 = () => lvwStandings.Items.Add(li);
                        lvwStandings.Invoke(actionUpdateStanding1);

                    }
                }
                else if (slots2add < 0)
                {
                    slots2add = slots2add * -1;

                    for (int i = 0; i < slots2add; i++)
                    {
                        Action actionUpdateStanding2 = () => lvwStandings.Items.RemoveAt(lvwStandings.Items.Count - 1);
                        lvwStandings.Invoke(actionUpdateStanding2);

                    }

                }

                if (closePending) { break; }

                foreach (Classes.LMURESTAPI.LMUStanding o in standings)
                {
                    if (o.position > 0)
                    {
                        Action actionUpdateStanding3 = () => UpdateListviewItem(o);
                        lvwStandings.Invoke(actionUpdateStanding3);
                    }
                }

                if(standings.Count == 0)
                {
                    Action updateCurrentDriverTextBox = () => txtCurrentDriver.Text = "";
                    txtCurrentDriver.Invoke(updateCurrentDriverTextBox);
                }

                Thread.Sleep(_timeBetweenCalls);
                if (closePending){break;}

            } while (true) ;

        }

        private void UpdateListviewItem(LMUStanding o)
        {
            if(lvwStandings.Items.Count >= o.position)
            {
                ListViewItem li = lvwStandings.Items[o.position - 1];
                li.Tag = o;
                if (li.SubItems[0].Text != o.position.ToString()) { li.SubItems[0].Text = o.position.ToString(); }
                if (li.SubItems[1].Text != o.slotID.ToString()) { li.SubItems[1].Text = o.slotID.ToString(); }
                if (li.SubItems[2].Text != o.driverName.ToString()) { li.SubItems[2].Text = o.driverName.ToString(); };
                if (li.SubItems[3].Text != o.carClass.ToString()) { li.SubItems[3].Text = o.carClass.ToString(); };
                if (li.SubItems[4].Text != o.vehicleName.ToString()) { li.SubItems[4].Text = o.vehicleName.ToString(); };

                if (o.hasFocus && li.BackColor != Color.Yellow)
                {
                    li.BackColor = Color.Yellow;
                }
                else if (!o.hasFocus && li.BackColor != Color.White)
                {
                    li.BackColor = Color.White;
                }

                if (o.hasFocus)
                {
                    txtCurrentDriver.Text = 'p' + o.position + " - " + o.driverName;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cboReplayFiles.SelectedIndex > -1)
            {
                Classes.LMURESTAPI.LMUReplay oReplay = (Classes.LMURESTAPI.LMUReplay)cboReplayFiles.SelectedItem;

                oLMUAPIRestService.GetLMUReplayPlayID(oReplay.id);

            }
        }

        private void Replay_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bwReplayInfo.IsBusy)
            {
                closePending = true;
                bwReplayInfo.CancelAsync();
                e.Cancel = true;
                this.Enabled = false;   // or this.Hide()
                return;
            }
            //base.OnFormClosing(e);
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void lvwStandings_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var focusedItem = lvwStandings.FocusedItem;


                if (focusedItem != null && focusedItem.Bounds.Contains(e.Location) && lblIsActive.Text == "Active")
                {

                    if (focusedItem.Tag != null)
                    {
                        cmStanding.Show(Cursor.Position);
                    }

                }
            }
        }

        private void jumpToDriverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var focusedItem = lvwStandings.FocusedItem;


            if (focusedItem != null)
            {

                if (focusedItem.Tag != null)
                {
                    LMUStanding lmust = focusedItem.Tag as LMUStanding;

                    oLMUAPIRestService.PutLMUReplayCameraSlotIdAsync(lmust.slotID);
                }

            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            var sInitialDir = "";

            if (Directory.Exists("F:\\SteamLibrary\\steamapps\\common\\Le Mans Ultimate\\UserData\\Log\\Results")) { sInitialDir = "F:\\SteamLibrary\\steamapps\\common\\Le Mans Ultimate\\UserData\\Log\\Results"; }
            else if (Directory.Exists("C:\\SteamLibrary\\steamapps\\common\\Le Mans Ultimate\\UserData\\Log\\Results")) { sInitialDir = "C:\\SteamLibrary\\steamapps\\common\\Le Mans Ultimate\\UserData\\Log\\Results"; }
            else if (Directory.Exists("D:\\SteamLibrary\\steamapps\\common\\Le Mans Ultimate\\UserData\\Log\\Results")) { sInitialDir = "D:\\SteamLibrary\\steamapps\\common\\Le Mans Ultimate\\UserData\\Log\\Results"; }
            else if (Directory.Exists("E:\\SteamLibrary\\steamapps\\common\\Le Mans Ultimate\\UserData\\Log\\Results")) { sInitialDir = "E:\\SteamLibrary\\steamapps\\common\\Le Mans Ultimate\\UserData\\Log\\Results"; }
            else if (Directory.Exists("C:\\Program Files(x86)\\Steam\\steamapps\\common\\Le Mans Ultimate\\UserData\\Log\\Results")) { sInitialDir = "C:\\Program Files(x86)\\Steam\\steamapps\\common\\Le Mans Ultimate\\UserData\\Log\\Results"; }
            else if (Directory.Exists("D:\\Program Files(x86)\\Steam\\steamapps\\common\\Le Mans Ultimate\\UserData\\Log\\Results")) { sInitialDir = "D:\\Program Files(x86)\\Steam\\steamapps\\common\\Le Mans Ultimate\\UserData\\Log\\Results"; }
            else if (Directory.Exists("E:\\Program Files(x86)\\Steam\\steamapps\\common\\Le Mans Ultimate\\UserData\\Log\\Results")) { sInitialDir = "E:\\Program Files(x86)\\Steam\\steamapps\\common\\Le Mans Ultimate\\UserData\\Log\\Results"; }
            else if (Directory.Exists("F:\\Program Files(x86)\\Steam\\steamapps\\common\\Le Mans Ultimate\\UserData\\Log\\Results")) { sInitialDir = "F:\\Program Files(x86)\\Steam\\steamapps\\common\\Le Mans Ultimate\\UserData\\Log\\Results"; }
            else if (Directory.Exists("C:\\Le Mans Ultimate\\UserData\\Log\\Results")) { sInitialDir = "C:\\Le Mans Ultimate\\UserData\\Log\\Results"; }
            else if (Directory.Exists("D:\\Le Mans Ultimate\\UserData\\Log\\Results")) { sInitialDir = "D:\\Le Mans Ultimate\\UserData\\Log\\Results"; }
            else if (Directory.Exists("E:\\Le Mans Ultimate\\UserData\\Log\\Results")) { sInitialDir = "E:\\Le Mans Ultimate\\UserData\\Log\\Results"; }
            else if (Directory.Exists("F:\\Le Mans Ultimate\\UserData\\Log\\Results")) { sInitialDir = "F:\\Le Mans Ultimate\\UserData\\Log\\Results"; }

            if (sInitialDir.Length > 0) { ofdResultFile.InitialDirectory = sInitialDir; }
            ofdResultFile.Title = "Select result xml file";
            ofdResultFile.Multiselect = false;
            ofdResultFile.CheckFileExists = true;
            ofdResultFile.Filter = "Xml|*.xml";

            if (ofdResultFile.ShowDialog() == DialogResult.OK && txtReplayFile.Text != ofdResultFile.SafeFileName)
            {
                txtReplayFile.Text = ofdResultFile.SafeFileName;


                _ResultXMLContent = XDocument.Load(ofdResultFile.FileName);

                cboResultIncDriver.Items.Clear();
                cboResultLapDriver.Items.Clear();
                cboResultIncDriver.Items.Add("All drivers");

                List<XElement> listDrivers = (from row in _ResultXMLContent.Descendants("Driver") select row).ToList();
                foreach (XElement row in listDrivers)
                {
                    string sName = row.Element("Name").Value;
                    cboResultLapDriver.Items.Add(sName);
                    cboResultIncDriver.Items.Add(sName);

                }

                cboResultIncDriver.SelectedIndex = 0;
                cboResultLapDriver.SelectedIndex = 0;

                RefreshListviewIncident();
                RefreshListviewLaptimes();

            }

        }




        private void cboReplayFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboReplayFiles.SelectedIndex == -1) { btnLoad.Enabled = false; }
            else { btnLoad.Enabled = true; }
        }

        private void lvwIncidents_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var focusedItem = lvwIncidents.FocusedItem;


                if (focusedItem != null && focusedItem.Bounds.Contains(e.Location) && lblIsActive.Text == "Active")
                {

                    if (focusedItem.Tag != null)
                    {
                        cmIncident.Show(Cursor.Position);
                    }

                }
            }
        }

        private void jumpToIncidentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var focusedItem = lvwIncidents.FocusedItem;


            if (focusedItem != null)
            {

                if (focusedItem.Tag != null)
                {
                    int slotid = int.Parse(focusedItem.SubItems[1].Text);
                    string s = focusedItem.SubItems[0].Text;

                    int sec = Convert.ToInt32(s) + Convert.ToInt32(nudTimeSync.Value);

                    if (sec < 0) { sec = 0; }

                    oLMUAPIRestService.PutLMUReplayCameraSlotIdAsync(slotid);
                    oLMUAPIRestService.PutLMUReplayTimeAsync(sec);
                }

            }
        }

        private void lvwStandings_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboResultIncDriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshListviewIncident();
        }

        private void RefreshListviewIncident()
        {

            if (cboResultIncDriver.SelectedIndex != -1 && _ResultXMLContent != null)
            {

                List<XElement> list = (from row in _ResultXMLContent.Descendants("Incident") select row).ToList();
                lvwIncidents.Items.Clear();


                foreach (XElement row in list)
                {
                    string slotId = row.Value.Substring(row.Value.IndexOf("(") + 1, row.Value.IndexOf(")") - row.Value.IndexOf("(") - 1);
                    string time = row.Attribute("et")?.Value;
                    time = time.Substring(0, time.IndexOf("."));
                    string incident = row.Value;

                    if (cboResultIncDriver.SelectedIndex == 0 || cboResultIncDriver.SelectedIndex > 0 && incident.IndexOf(cboResultIncDriver.Text) > -1)
                    {
                        ListViewItem o = new ListViewItem(time);
                        o.Tag = row;
                        o.SubItems.Add(slotId);
                        o.SubItems.Add(incident);

                        lvwIncidents.Items.Add(o);
                    }

                }


            }
        }

        private void RefreshListviewLaptimes()
        {

            if (cboResultLapDriver.SelectedIndex != -1 && _ResultXMLContent != null)
            {

                List<XElement> list = (from row in _ResultXMLContent.Descendants("Driver") select row).ToList();
                lvwDriverLaptimes.Items.Clear();


                foreach (XElement row in list)
                {
                    string sName = row.Element("Name").Value;

                    if (cboResultLapDriver.SelectedIndex > -1 && sName.ToLower().Trim() == cboResultLapDriver.Text.ToLower().Trim())
                    {
                        string sCarType = row.Element("CarType").Value;
                        string sCarCat = row.Element("Category").Value;

                        lblCar.Text = sCarCat + " - " + sCarType;

                        List<XElement> laps = (from row2 in row.Descendants("Lap") select row2).ToList();

                        foreach (XElement lap in laps)
                        {
                            string time = lap.Attribute("et")?.Value;
                            time = time.Substring(0, time.IndexOf("."));

                            string lapnr = lap.Attribute("num")?.Value;
                            string pos = lap.Attribute("p")?.Value;
                            string s1 = lap.Attribute("s1")?.Value;
                            string s2 = lap.Attribute("s2")?.Value;
                            string s3 = lap.Attribute("s3")?.Value;
                            string s0 = lap.Value;
                            string speed = lap.Attribute("topspeed")?.Value;
                            string fcompound = lap.Attribute("fcompound")?.Value;
                            string rcompound = lap.Attribute("rcompound")?.Value;

                            ListViewItem o = new ListViewItem(time);
                            o.Tag = lap;
                            o.SubItems.Add(lapnr);
                            o.SubItems.Add(pos);
                            o.SubItems.Add(s1);
                            o.SubItems.Add(s2);
                            o.SubItems.Add(s3);
                            o.SubItems.Add(s0);
                            o.SubItems.Add(speed);
                            o.SubItems.Add(fcompound);
                            o.SubItems.Add(rcompound);

                            lvwDriverLaptimes.Items.Add(o);

                        }


                    }

                }


            }

        }

        private void cboResultLapDriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshListviewLaptimes();
        }

        private void lvwDriverLaptimes_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var focusedItem = lvwDriverLaptimes.FocusedItem;


                if (focusedItem != null && focusedItem.Bounds.Contains(e.Location) && lblIsActive.Text == "Active")
                {

                    if (focusedItem.Tag != null)
                    {
                        cmLaptime.Show(Cursor.Position);
                    }

                }
            }
        }

        private void jumpToLapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var focusedItem = lvwDriverLaptimes.FocusedItem;


            if (focusedItem != null)
            {

                if (focusedItem.Tag != null)
                {
                    int slotid = -1;

                    foreach (ListViewItem li in lvwStandings.Items)
                    {
                        if (li.Tag != null)
                        {
                            LMUStanding stand = li.Tag as LMUStanding;

                            if (stand.driverName.ToLower().Trim() == cboResultLapDriver.Text.ToLower().Trim())
                            {
                                slotid = stand.slotID;
                                break;
                            }

                        }
                    }

                    if (slotid > -1)
                    {
                        string s = focusedItem.SubItems[0].Text;
                        int sec = Convert.ToInt32(s) + Convert.ToInt32(nudTimeSync.Value);

                        if (sec < 0) { sec = 0; }

                        oLMUAPIRestService.PutLMUReplayCameraSlotIdAsync(slotid);
                        oLMUAPIRestService.PutLMUReplayTimeAsync(sec);

                    }
                }

            }
        }

        private void bwReplayInfo_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (closePending) this.Close();
            closePending = false;
        }

        private void btnSpeed2_Click(object sender, EventArgs e)
        {
            oLMUAPIRestService.PostLMUReplayPlaybackCommand(2);
        }

        private void btnSpeed3_Click(object sender, EventArgs e)
        {
            oLMUAPIRestService.PostLMUReplayPlaybackCommand(3);
        }

        private void btnSpeed4_Click(object sender, EventArgs e)
        {
            oLMUAPIRestService.PostLMUReplayPlaybackCommand(4);
        }

        private void btnSpeed5_Click(object sender, EventArgs e)
        {
            oLMUAPIRestService.PostLMUReplayPlaybackCommand(5);
        }

        private void btnSpeed6_Click(object sender, EventArgs e)
        {
            oLMUAPIRestService.PostLMUReplayPlaybackCommand(6);
        }

        private void btnSpeed7_Click(object sender, EventArgs e)
        {
            oLMUAPIRestService.PostLMUReplayPlaybackCommand(7);
        }

        private void btnSpeed8_Click(object sender, EventArgs e)
        {
            oLMUAPIRestService.PostLMUReplayPlaybackCommand(8);
        }

        private void btnSpeed9_Click(object sender, EventArgs e)
        {
            oLMUAPIRestService.PostLMUReplayPlaybackCommand(9);
        }

        private void btnSpeed10_Click(object sender, EventArgs e)
        {
            oLMUAPIRestService.PostLMUReplayPlaybackCommand(10);
        }
    }
}
