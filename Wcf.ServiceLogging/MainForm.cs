using System;
using System.Linq;
using System.Management;
using System.Windows.Forms;

namespace Wcf.ServiceLogging
{
    public partial class MainForm : Form
    {
        private const string _wcfNamespce = @"\\{0}\Root\ServiceModel";
        private ManagementScope _scope = null;

        public MainForm()
        {
            InitializeComponent();
        }

        #region EventHandlers
        private void ListviewItemChanged(object sender, EventArgs e)
        {
            if (lstServices.SelectedItems.Count > 0)
            {
                cmbMalformed.Text = lstServices.SelectedItems[0].SubItems[2].Text;
                cmbService.Text = lstServices.SelectedItems[0].SubItems[3].Text;
                cmbTransport.Text = lstServices.SelectedItems[0].SubItems[4].Text;

                string[] trace = lstServices.SelectedItems[0].SubItems[5].Text.Split(',');

                if (trace.Count() > 1)
                {
                    cmbTrace.Text = trace[0];
                    chkActivity.Checked = true;
                    chkActivity.Enabled = true;
                }
                else
                {
                    chkActivity.Checked = false;
                    cmbTrace.Text = lstServices.SelectedItems[0].SubItems[5].Text;
                    if (cmbTrace.Text == "Off")
                        chkActivity.Enabled = false;
                    else
                        chkActivity.Enabled = true;
                }
            }
        }

        private void ButtonPublishClick(object sender, EventArgs e)
        {
            if (_scope == null || !_scope.IsConnected)
                throw new ApplicationException("You must authenticate before trying to publish logging changes.");

            ObjectQuery query = new ObjectQuery("SELECT * FROM AppDomainInfo WHERE Name = '" + lstServices.SelectedItems[0].SubItems[1].Text + "'");

            ManagementObjectSearcher searcher = new ManagementObjectSearcher(_scope, query);
            ManagementObjectCollection mo = searcher.Get();

            if (mo != null && mo.Count > 0)
            {
                foreach (ManagementObject m in mo)
                {
                    m["logMalformedMessages"] = cmbMalformed.Text;
                    m["logMessagesAtServiceLevel"] = cmbService.Text;
                    m["logMessagesAtTransportLevel"] = cmbTransport.Text;
                    m["TraceLevel"] = cmbTrace.Text + (chkActivity.Checked ? ",ActivityTracing" : "");

                    try
                    {
                        m.Put();
                        this.LoadServicesIntoList();
                        MessageBox.Show("Log settings saved successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error while trying to set the logging properties. \r\n" + ex.Message);
                    }

                }
            }
        }

        private void TraceLevelChanged(object sender, EventArgs e)
        {
            if (cmbTrace.Text == "Off")
            {
                chkActivity.Checked = false;
                chkActivity.Enabled = false;
            }
            else
                chkActivity.Enabled = true;
        }

        private void ButtonAuthenticateClick(object sender, EventArgs e)
        {
            try
            {
                this.LoadServicesIntoList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while trying to load WCF services into list. \r\n" + ex.Message);
            }

        }

        private void Local_CheckChanged(object sender, EventArgs e)
        {
            if (rdoLocal.Checked)
            {
                txtDomain.Enabled = false;
                txtDomain.Text = "";
                txtPassword.Enabled = false;
                txtPassword.Text = "";
                txtSvrName.Enabled = false;
                txtSvrName.Text = "";
                txtUserName.Enabled = false;
                txtUserName.Text = "";
            }
            else
            {
                txtDomain.Enabled = true;
                txtPassword.Enabled = true;
                txtSvrName.Enabled = true;
                txtUserName.Enabled = true;
            }
        }
        #endregion

        #region private methods
        private void LoadServicesIntoList()
        {
            _scope = MakeConnection();
            ObjectQuery query = new ObjectQuery("SELECT * FROM AppDomainInfo");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(_scope, query);

            try
            {
                lstServices.Items.Clear();
                lstServices.BeginUpdate();
                foreach (ManagementObject mo in searcher.Get())
                {
                    ListViewItem lvItem = new ListViewItem(mo["ProcessId"].ToString());
                    lvItem.SubItems.Add(mo["Name"].ToString());
                    lvItem.SubItems.Add(mo["logMalformedMessages"].ToString());
                    lvItem.SubItems.Add(mo["logMessagesAtServiceLevel"].ToString());
                    lvItem.SubItems.Add(mo["logMessagesAtTransportLevel"].ToString());
                    lvItem.SubItems.Add(mo["TraceLevel"].ToString());
                    lstServices.Items.Add(lvItem);
                }

                if (lstServices.Items.Count > 0)
                {
                    lstServices.Items[0].Selected = true;
                }
            }
            catch (ManagementException ex)
            {
                MessageBox.Show("Error while trying to load WCF services into list. \r\n" + ex.Message);
            }
            finally
            {
                lstServices.EndUpdate();
            }
        }
                
        private ManagementScope MakeConnection()
        {
            string serverName;
            ConnectionOptions connection = new ConnectionOptions();
            connection.Authentication = AuthenticationLevel.PacketPrivacy;

            if (rdoRemote.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtSvrName.Text))
                    throw new ApplicationException("Server Name must be populated to use remote authentication.");

                if (string.IsNullOrWhiteSpace(txtDomain.Text))
                    throw new ApplicationException("Domain Name must be populated to use remote authentication.");

                connection.Authority = "ntlmdomain:" + txtDomain.Text;

                if (!string.IsNullOrWhiteSpace(txtUserName.Text))
                    connection.Username = txtUserName.Text.Trim();

                if (!string.IsNullOrWhiteSpace(txtPassword.Text))
                    connection.Password = txtPassword.Text.Trim();

                serverName = txtSvrName.Text.Trim();
            }
            else
                serverName = "localhost";

            ManagementScope scope = new ManagementScope(string.Format(_wcfNamespce, serverName), connection);
            scope.Connect();

            return scope;

        }
        #endregion
    }
}
