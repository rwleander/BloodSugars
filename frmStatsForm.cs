//  form to display statistics

using System;
using System.Windows.Forms;

namespace BloodSugars
{
    public partial class frmStatsForm : Form
    {

        //  public properties

        public objSugarList sugarList;

        public DateTime start;
        public DateTime end;

        //  constructor

        public frmStatsForm()
        {
            InitializeComponent();
        }

        //  set upp the form

        private void frmStats_Load(object sender, EventArgs e)
        {
            txtStart.Text = start.ToShortDateString();
            txtEnd.Text = end.ToShortDateString();

            lvData.Columns.Add("Time", 150, HorizontalAlignment.Left);
            lvData.Columns.Add("Count", 100, HorizontalAlignment.Center);
            lvData.Columns.Add("Average", 150, HorizontalAlignment.Right);
            lvData.Columns.Add("Lows", 100, HorizontalAlignment.Center);
            lvData.Columns.Add("Highs", 100, HorizontalAlignment.Center);

            txtStart.Focus();
        }

        //  fill in the data

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (checkData() == true)
            {
                loadData();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        //  check the dates

        private bool checkData()
        {

            //  start date

            txtStart.Text = txtStart.Text.Trim();
            if (txtStart.Text == "")
            {
                MessageBox.Show("A start date is required");
                txtStart.Focus();
                return false;
            }

            try
            {
                start = DateTime.Parse(txtStart.Text);
            }
            catch
            {
                MessageBox.Show("The start date is not a valuid date in mm/dd/yyyy format");
                txtStart.Focus();
                return false;
            }

            //  end date

            txtEnd.Text = txtEnd.Text.Trim();
            if (txtEnd.Text == "")
            {
                MessageBox.Show("An end date is required");
                txtEnd.Focus();
                return false;
            }

            try
            {
                end = DateTime.Parse(txtEnd.Text);
            }
            catch
            {
                MessageBox.Show("The end date is not a valid date in mm/dd/yyyy format");
                txtEnd.Focus();
                return false;
            }

            return true;
        }

        //  load the statistics

        private void loadData()
        {
            objStats stats = new objStats();
            ListViewItem lvItem;

            stats.calc(sugarList, start, end);

            lvData.Items.Clear();

            if (stats.nBreakfast > 0)
            {
                lvItem = new ListViewItem("Breakfast");
                lvItem.SubItems.Add(stats.nBreakfast.ToString());
                lvItem.SubItems.Add(stats.avgBreakfast.ToString());
                lvItem.SubItems.Add(stats.loBreakfast.ToString ());
                lvItem.SubItems.Add(stats.hiBreakfast.ToString ());
                lvData.Items.Add(lvItem);
            }

            if (stats.nLunch > 0)
            {
                lvItem = new ListViewItem("Lunch");
                lvItem.SubItems.Add(stats.nLunch.ToString());
                lvItem.SubItems.Add(stats.avgLunch.ToString());
                lvItem.SubItems.Add(stats.loLunch.ToString ());
                lvItem.SubItems.Add(stats.hiLunch.ToString ());
                lvData.Items.Add(lvItem);
            }

            if (stats.nSupper > 0)
            {
                lvItem = new ListViewItem("Supper");
                lvItem.SubItems.Add(stats.nSupper.ToString());
                lvItem.SubItems.Add(stats.avgSupper.ToString());
                lvItem.SubItems.Add(stats.loSupper.ToString ());
                lvItem.SubItems.Add(stats.hiSupper.ToString ());
                lvData.Items.Add(lvItem);
            }

            if (stats.nBedtime > 0)
            {
                lvItem = new ListViewItem("Bed time");
                lvItem.SubItems.Add(stats.nBedtime.ToString());
                lvItem.SubItems.Add(stats.avgBedtime.ToString());
                lvItem.SubItems.Add(stats.loBedtime.ToString ());
                lvItem.SubItems.Add(stats.hiBedtime.ToString ());
                lvData.Items.Add(lvItem);
            }

            if (stats.nNight > 0)
            {
                lvItem = new ListViewItem("Night");
                lvItem.SubItems.Add(stats.nNight.ToString());
                lvItem.SubItems.Add(stats.avgNight.ToString());
                lvItem.SubItems.Add(stats.loNight.ToString ());
                lvItem.SubItems.Add(stats.hiNight.ToString ());
                lvItem.SubItems.Add(stats.avgNight.ToString());
                lvData.Items.Add(lvItem);
            }

            if (stats.nNight > 0)
            {
                lvItem = new ListViewItem("Overall");
                lvItem.SubItems.Add(stats.nAll.ToString());
                lvItem.SubItems.Add(stats.avgAll.ToString());
                lvItem.SubItems.Add(stats.loAll.ToString());
                lvItem.SubItems.Add(stats.hiAll.ToString());
                lvItem.SubItems.Add(stats.avgNight.ToString());
                lvData.Items.Add(lvItem);
            }


            if (lvData.Items.Count == 0)
            {
                MessageBox.Show("No blood sugars on file for this range of dates");
            }

        }

    }
}
