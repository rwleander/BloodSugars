//  SettingsForm.cs - settings form

using System;
using System.Windows.Forms;
using System.Configuration;

namespace BloodSugars
{
    public partial class frmSettingsForm : Form
    {
        public frmSettingsForm()
        {
            InitializeComponent();
        }

        //  on load, fill in data

        private void SettingsForm_Load(object sender, EventArgs e)
        {

            //  fill in the combo box

            cbPort.Items.Clear();
            cbPort.Items.Add("");
            for (int i = 1; i < 9; i++)
            {
                cbPort.Items.Add("com" + i.ToString());
            }

            //  fill in values

            txtFolder.Text = ConfigurationManager.AppSettings["DataPath"];
            txtDatabase.Text = ConfigurationManager.AppSettings["Database"];
            cbPort.Text = ConfigurationManager.AppSettings["CommPort"];
            txtLongTerm.Text = ConfigurationManager.AppSettings["LongTerm"];
            txtShortTerm.Text = ConfigurationManager.AppSettings["ShortTerm"];
        }

        //  save button

        private void btnSave_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            config.AppSettings.Settings.Clear();
            config.AppSettings.Settings.Add("DataPath", txtFolder.Text);
            config.AppSettings.Settings.Add("Database", txtDatabase.Text);
            config.AppSettings.Settings.Add("CommPort", cbPort.Text);
            config.AppSettings.Settings.Add("LongTerm", txtLongTerm.Text);
            config.AppSettings.Settings.Add("ShortTerm", txtShortTerm.Text);
            config.Save(ConfigurationSaveMode.Modified);
            DialogResult = DialogResult.OK;
        }

        //  cancel button

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

    }
}
