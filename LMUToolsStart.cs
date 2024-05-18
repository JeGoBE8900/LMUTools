using System.Net;
using System.Net.Http;
using System.Text;

namespace LMUTools
{
    public partial class LMUToolsStart : Form
    {

        private Classes.LMURESTAPI.LMUAPIRestService _LMUAPI;
        private Boolean _APIStatusCode;
        private int _APIRefreshRate;


        public LMUToolsStart()
        {
            InitializeComponent();



        }

        private async void LMUToolsStart_Load(object sender, EventArgs e)
        {
            tsslRestApi.Text = "REST API Not available";
            tsslRestApi.BackColor = Color.Red;
            _APIStatusCode = false;

            HttpClient httpClient = new HttpClient();
            _LMUAPI = new Classes.LMURESTAPI.LMUAPIRestService(httpClient);


            bwRestStatus.RunWorkerAsync();

            _APIRefreshRate = 5000;
            tsmiCurrentRefreshRate.Text = "Current: " + _APIRefreshRate + "ms";


        }

        private async void bwRestStatus_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            do
            {
                Action actionRestApiInfo = null;

                if (_APIRefreshRate > 0)
                {
                    bool statusCode = (await _LMUAPI.GetLMUApiStatusAsync());
                    _APIStatusCode = statusCode;
                    //MessageBox.Show(statusCode.ToString());



                    if (statusCode)
                    {

                        actionRestApiInfo = () => tsslRestApi.Text = "REST API Available";
                        statusStrip1.Invoke(actionRestApiInfo);

                        actionRestApiInfo = () => tsslRestApi.BackColor = Color.Green;
                        statusStrip1.Invoke(actionRestApiInfo);

                        //tsslRestApi.Text = "REST API Available";
                        //tsslRestApi.BackColor = Color.Green;
                    }
                    else
                    {
                        actionRestApiInfo = () => tsslRestApi.Text = "REST API not Available";
                        statusStrip1.Invoke(actionRestApiInfo);

                        actionRestApiInfo = () => tsslRestApi.BackColor = Color.Red;
                        statusStrip1.Invoke(actionRestApiInfo);


                    }

                    Thread.Sleep(_APIRefreshRate);
                }
                else
                {
                    Thread.Sleep(2000);

                    actionRestApiInfo = () => tsslRestApi.Text = "REST API check disabled";
                    statusStrip1.Invoke(actionRestApiInfo);

                    actionRestApiInfo = () => tsslRestApi.BackColor = Color.Orange;
                    statusStrip1.Invoke(actionRestApiInfo);
                }




            } while (true);
        }





        private void tsmiAdd1000ms_Click(object sender, EventArgs e)
        {
            _APIRefreshRate = _APIRefreshRate + 1000;
            tsmiCurrentRefreshRate.Text = "Current: " + _APIRefreshRate + "ms";
        }

        private void tsmiDisableRefreshRate_Click(object sender, EventArgs e)
        {
            _APIRefreshRate = 0;
            tsmiCurrentRefreshRate.Text = "Disabled";
        }

        private void tsmiSubtract1000ms_Click(object sender, EventArgs e)
        {
            _APIRefreshRate -= 1000;
            if (_APIRefreshRate <= 0)
            {
                _APIRefreshRate = 0;
                tsmiCurrentRefreshRate.Text = "Disabled";
            }
            else
            {
                tsmiCurrentRefreshRate.Text = "Current: " + _APIRefreshRate + "ms";
            }
        }

        private void replayToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (_APIStatusCode) //
            {
                foreach (Form frm in MdiChildren)
                {
                    if (frm is Forms.Replay)
                    {
                        if (frm.WindowState == FormWindowState.Minimized)
                            frm.WindowState = FormWindowState.Maximized;
                        frm.Focus();
                        return;
                    }
                }

                Forms.Replay newMDIChild = new Forms.Replay { oLMUAPIRestService = _LMUAPI };
                // Set the Parent Form of the Child window.
                newMDIChild.MdiParent = this;
                newMDIChild.WindowState = FormWindowState.Maximized;
                // Display the new form.
                newMDIChild.Show();

            }
        }

        private void vCRStreamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in MdiChildren)
            {
                if (frm is Forms.VCRStream)
                {
                    if (frm.WindowState == FormWindowState.Minimized)
                        frm.WindowState = FormWindowState.Maximized;
                    frm.Focus();
                    return;
                }
            }

            Forms.VCRStream newMDIChild = new Forms.VCRStream { };
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            newMDIChild.WindowState = FormWindowState.Maximized;
            // Display the new form.
            newMDIChild.Show();
        }
    }
}
