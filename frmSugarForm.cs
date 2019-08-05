//  frmSugarForm.cs - add/change sugar entries

using System;
using System.Windows.Forms;
using System.Configuration;

namespace BloodSugars
{
    public partial class frmSugarForm : Form
    {

        //  public fields

        public objSugar sugar;

        //  private fields

        private string tmpLongTermName = "";
        private string tmpShortTermName = "";
        private DateTime tmpTime = DateTime.MinValue;
        private int tmpSugar = 0;
        private int tmpLongTerm = 0;
        private int tmpShortTerm = 0;


        public frmSugarForm()
        {
            InitializeComponent();
        }

        //  on load, load the data

        private void frmSugarForm_Load(object sender, EventArgs e)
        {

            //  get configuration data

            tmpLongTermName = ConfigurationManager.AppSettings["LongTerm"];
            tmpShortTermName = ConfigurationManager.AppSettings["ShortTerm"];

            lblLongTerm.Text = tmpLongTermName + ":";
            txtLongTerm.AccessibleName = tmpLongTermName;
            lblShortTerm.Text = tmpShortTermName + ":";
            txtShortTerm.AccessibleName = tmpShortTermName;

            //  fill in the form data

            LoadData();
            txtDate.Focus();
        }

        //  validate then save the data

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

        //  cancel button

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        //---------------------
        //   private methods

        //  load the data to the form

        private void LoadData()
        {

            //  if on file, fill in the data

            if (sugar.isOnFile == true)
            {
                txtID.Text = sugar.ID.ToString();
                txtDate.Text = sugar.Time.ToShortDateString();
                txtTime.Text = sugar.Time.ToShortTimeString();
                txtSugar.Text = BlankIfZero(sugar.Sugar);
                txtLongTerm.Text = BlankIfZero(sugar.LongTerm);
                txtShortTerm.Text = BlankIfZero(sugar.ShortTerm);
                btnSave.Text = "Save";
            }

            //  if not on file, clrear fields

            else
            {
                txtID.Text = "New";
                txtDate.Text = DateTime.Now.ToShortDateString();
                txtTime.Text = DateTime.Now.ToShortTimeString();
                txtSugar.Text = "";
                txtLongTerm.Text = "";
                txtShortTerm.Text = "";
                btnSave.Text = "Add";
            }
        }

        //  validate the form data

        private bool CheckData()
        {

            //  date and time

            txtDate.Text = txtDate.Text.ToString();
            if (txtDate.Text == "")
            {
                MessageBox.Show("A date is required");
                txtDate.Focus();
                return false;
            }

            if (CheckTime(txtDate.Text) == DateTime.MinValue)
            {
                MessageBox.Show("The date is not valid (mm/dd/yyyy)");
                txtDate.Focus();
                return false;
            }

            // time

            txtTime.Text = txtTime.Text.Trim();
            if (txtTime.Text == "")
            {
                MessageBox.Show("A time is required");
                txtTime.Focus();
                return false;
            }

            tmpTime = CheckTime(txtDate.Text + " " + txtTime.Text);
            if (tmpTime == DateTime.MinValue)
            {
                MessageBox.Show("The time is not valid (hh:mm)");
                txtTime.Focus();
                return false;
            }

            //  sugar

            txtSugar.Text = txtSugar.Text.Trim();
            tmpSugar = CheckNumber(txtSugar.Text);
            if (tmpSugar < 0)
            {
                MessageBox.Show("The blood sugar number is not valid");
                txtSugar.Focus();
                return false;
            }

            //  long term insulin

            txtLongTerm.Text = txtLongTerm.Text.Trim();
            tmpLongTerm = CheckNumber(txtLongTerm.Text);
            if (tmpLongTerm < 0)
            {
                MessageBox.Show("The " + tmpLongTermName + " is not a valid number");
                txtLongTerm.Focus();
                return false;
            }

            //  short term

            txtShortTerm.Text = txtShortTerm.Text.Trim();
            tmpShortTerm = CheckNumber(txtShortTerm.Text);
            if (tmpShortTerm < 0)
            {
                MessageBox.Show("The " + tmpShortTermName + " is not a valid number");
                txtShortTerm.Focus();
                return false;
            }

            //  all valid data

            return true;
        }

        //  save the data

        private bool SaveData()
        {
            sugar.Time = tmpTime;
            sugar.Sugar = tmpSugar;
            sugar.ShortTerm = tmpShortTerm;
            sugar.LongTerm = tmpLongTerm;

            try
            {
                sugar.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot save data - " + ex.Message);
                return false;
            }

            return true;
        }


        //-------------------
        //   helper methods

        //  validate date / time

        private DateTime CheckTime(string tm)
        {
            try
            {
                return DateTime.Parse(tm);
            }
            catch
            {
                return DateTime.MinValue;
            }
        }

        //  validate numbers - return -1 if not valid

        private int CheckNumber(string txt)
        {

            //  if blank, return zero

            if (txt == "")
            {
                return 0;
            }

            //  parse the number

            try
            {
                return int.Parse(txt);
            }
            catch
            {
                return -1;
            }
        }

        //  return blank if zero

        private string BlankIfZero(int n)
        {
            if (n > 0)
            {
                return n.ToString();
            }
            else
            {
                return "";
            }
        }

    }
}
