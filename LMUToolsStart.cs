using System.Net;
using System.Net.Http;
using System.Text;

namespace LMUTools
{
    public partial class LMUToolsStart : Form
    {

        private Classes.LMURESTAPI.LMUAPIRestService _LMUAPI;
        private Boolean _APIStatusCode;


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

        }

        private async void bwRestStatus_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            do
            {
                bool statusCode = (await _LMUAPI.GetLMUApiStatusAsync());
                _APIStatusCode = statusCode;
                //MessageBox.Show(statusCode.ToString());

                Action actionRestApiInfo = null;

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


                    //tsslRestApi.Text = "REST API Not available";
                    //tsslRestApi.BackColor = Color.Red;
                }

                Thread.Sleep(5000);

            } while (true);
        }



        private void replayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (true) //_APIStatusCode
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

                Forms.Replay newMDIChild = new Forms.Replay {oLMUAPIRestService = _LMUAPI };
                // Set the Parent Form of the Child window.
                newMDIChild.MdiParent = this;
                newMDIChild.WindowState = FormWindowState.Maximized;
                // Display the new form.
                newMDIChild.Show();

            }
        }
    }
}
