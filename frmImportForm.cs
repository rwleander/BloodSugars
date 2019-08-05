using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BloodSugars
{
    public partial class frmImportForm : Form
    {
        public frmImportForm()
        {
            InitializeComponent();
        }

        //  on load, do nothing

        private void ImportForm_Load(object sender, EventArgs e)
        {

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

        //-------------------------
        //   private methods

        private bool LoadData()
        {
            objMeter meter = new objMeter();
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
