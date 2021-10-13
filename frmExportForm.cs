//  export data to text file
//
//-------------------
//   change history
//
//  3/12/2020 - print list in ascending order
//

using System;
using System.Windows.Forms;
using System.IO;

namespace BloodSugars
{
    public partial class frmExportForm : Form
    {

        //  public fields and collections

        public objSugarList sugarList;
        public DateTime selectedMonth = DateTime.MinValue;
        public string longTermName = "";
        public string shortTermName = "";

        //  private fields

        private DateTime tmpStartDate = DateTime.MinValue;
        private DateTime tmpEndDate = DateTime.MaxValue;


        //  constructor

        public frmExportForm()
        {
            InitializeComponent();
        }

        //  on load, set up the form

        private void frmExportForm_Load(object sender, EventArgs e)
        {
            DateTime start, end;

            //  fill in the dates

            if (selectedMonth > DateTime.MinValue)
            {
                start = DateTime.Parse(selectedMonth.Month.ToString() + "/1/" + selectedMonth.Year.ToString());
                end = start.AddMonths(1).AddDays(-1);
            }
            else
            {
                start = sugarList.Start;
                end = sugarList.End;
            }

            txtStartDate.Text = start.ToShortDateString();
            txtEndDate.Text = end.ToShortDateString();
        }

        //  browse for file

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            dlgFileSave.FileName = txtFileName.Text;
            if (dlgFileSave.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = dlgFileSave.FileName;
            }
        }

        //  save - export data

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckData() == true)
            {
                if (SaveData() == true)
                {
                    DialogResult = DialogResult.OK;
                }
            }
        }


        //  cancel 

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }


        //--------------------------
        //  private methods

        //  validate form data

        private bool CheckData()
        {

            //  start date

            txtStartDate.Text = txtStartDate.Text.Trim();
            if (txtStartDate.Text == "")
            {
                tmpStartDate = DateTime.MinValue;
            }
            else
            {
                try
                {
                    tmpStartDate = DateTime.Parse(txtStartDate.Text);
                }
                catch
                {
                    MessageBox.Show("The start date is not a valid date in mm/dd/yyyy format");
                    txtStartDate.Focus();
                    return false;
                }
            }

            //  end date

            txtEndDate.Text = txtEndDate.Text.Trim();
            if (txtEndDate.Text == "")
            {
                tmpEndDate = DateTime.MaxValue;
            }
            else
            {
                try
                {
                    tmpEndDate = DateTime.Parse(txtEndDate.Text);
                    tmpEndDate = tmpEndDate.AddDays(1).AddMinutes(-1);
                }
                catch
                {
                    MessageBox.Show("The end date is not a valid date in mm/dd/yyyy format");
                    txtEndDate.Focus();
                    return false;
                }
            }

            //  file name

            txtFileName.Text = txtFileName.Text.Trim();
            if (txtFileName.Text == "")
            {
                MessageBox.Show("A file name is required");
                txtFileName.Focus();
                return false;
            }

            //  ready to export

            return true;
        }

        //  export the data

        private bool SaveData()
        {
            StreamWriter wrtr;
            DateTime lastDate = DateTime.MinValue;
            objSugar sugar;
            int n = 0;
            int i;

            //  if file exists, delete

            if (File.Exists(txtFileName.Text) == true)
            {
                File.Delete(txtFileName.Text);
            }

            //  create a new file

            try
            {
                wrtr = File.CreateText(txtFileName.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot create the text file - " + ex.Message);
                return false;
            }

            //  title

            wrtr.WriteLine("Blood Sugars");

            //  write the report

            i = sugarList.Count - 1;
            while (i >= 0)
            {
                sugar = sugarList.sugarList[i];
                if ((sugar.Time >= tmpStartDate) && (sugar.Time <= tmpEndDate))
                {

                    //  add titles

                    if (sugar.Time.Date != lastDate.Date)
                    {
                        wrtr.WriteLine();
                        wrtr.WriteLine(sugar.Time.ToLongDateString());
                    }

                    //  write the data

                    wrtr.Write(sugar.Time.ToShortTimeString());
                    wrtr.Write(formatNumber(sugar.Sugar) + " ");

                    if (sugar.LongTerm > 0)
                    {
                        wrtr.Write(" " + longTermName[0] + ":" + formatNumber(sugar.LongTerm));
                    }

                    if (sugar.ShortTerm > 0)
                    {
                        wrtr.Write(" " + shortTermName[0] + ":" + formatNumber(sugar.ShortTerm));
                    }

                    wrtr.WriteLine();

                    n++;
                }

                lastDate = sugar.Time;
                i--;
            }

            //  close the file

            wrtr.Close();

            MessageBox.Show("Wrote " + n.ToString() + " blood sugar readings");
            return true;
        }

        //---------------------
        //   helper methods

        //  format number

        private string formatNumber(int n)
        {
            if (n > 0)
            {
                return string.Format("{0,4}", n);
            }
            else
            {
                return "    ";
            }
        }

    }
}
