//  import glucometer data
//
//   program change history
//
//  10/13/2021 - increase range of com ports to 14
//

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;

namespace BloodSugars
{
    public partial class frmImportForm : Form
    {
        public frmImportForm()
        {
            InitializeComponent();
        }

        //  on load, set up comm port list

        private void ImportForm_Load(object sender, EventArgs e)
        {
            int n;

            cbCommPort.Items.Clear();
            for (n = 1; n < 15; n++)
            {
                cbCommPort.Items.Add("com" + n.ToString());
            }

            cbCommPort.Text = ConfigurationManager.AppSettings["CommPort"];
        }

        //  import data

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (LoadData() == true)
            {
                DialogResult = DialogResult.OK;
            }
        }

        //  cancel

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void frmImportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConfigurationManager.AppSettings["CommPort"] = cbCommPort.Text;
            config.Save();
        }

        //-------------------------
        //   private methods

        private bool LoadData()
        {
            objMeter meter = new objMeter(cbCommPort.Text);
            objSugar sugar;
            int readCount, writeCount;

            try
            {
                readCount = meter.Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot import data - " + ex.Message);
                return false;
            }

            //  if no readings, say so

            if (readCount == 0)
            {
                MessageBox.Show("Nothing read");
                return true;
            }

            //  copy the data

            sugar = new objSugar();
            writeCount = 0;

            try
            {
                foreach (objSugar newSugar in meter.sugarList)
                {
                    if (sugar.LoadByTime(newSugar.Time) == false)
                    {
                        newSugar.Add();
                        writeCount++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot copy data - " + ex.Message);
                return false;
            }

            MessageBox.Show("Read " + readCount.ToString() + ", added " + writeCount.ToString());
            return true;
        }

    }
}
