//  MainForm.cs - main user interface form

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;

namespace BloodSugars
{
    public partial class frmMainForm : Form
    {

        //  private fields and collections

        private objSugarList sugarList;

        private string longTermName = "";
        private string shortTermName = "";


        //  constructor

        public frmMainForm()
        {
            InitializeComponent();
        }

        //  on load, set up form

        private void MainForm_Load(object sender, EventArgs e)
        {

            //  get the configuration data

            longTermName = ConfigurationManager.AppSettings["LongTerm"];
            shortTermName = ConfigurationManager.AppSettings["ShortTerm"];

            //  set up list view

            lvData.Columns.Clear();
            lvData.Columns.Add("Date", 150, HorizontalAlignment.Center);
            lvData.Columns.Add("Time", 150, HorizontalAlignment.Center);
            lvData.Columns.Add("Sugar", 100, HorizontalAlignment.Center);
            lvData.Columns.Add(longTermName, 100, HorizontalAlignment.Center);
            lvData.Columns.Add(shortTermName, 100, HorizontalAlignment.Center);

            //  create the context menu

            ContextMenu popup = new ContextMenu();
            popup.MenuItems.Add("Add", new EventHandler(PopupMenu_Add));
            popup.MenuItems.Add("Update", new EventHandler(PopupMenu_Update));
            popup.MenuItems.Add("Delete", new EventHandler(PopupMenu_Delete));
            lvData.ContextMenu = popup;

            //  load the data

            LoadAllData();
        }

        //  on layout, resize controls

        private void MainForm_Layout(object sender, LayoutEventArgs e)
        {
            int h, w, sx, sy, sw, sh, bx, by, bw, bh;

            //  get metrics

            w = ClientRectangle.Width;
            h = ClientRectangle.Height;

            //  calculate dimensions

            bx = w / 8;
            by = 1;
            bw = bx - 2;
            bh = btnClose.Height;

            sx = 1;
            sy = by + bh + 2;
            sw = w - sx - 1;
            sh = h - sy - 1;
                        
            //  resize controls

            SuspendLayout();

            btnImport.Location = new Point(1, by);
            btnImport.Size = new Size(bw, bh);

            btnExport.Location = new Point(bx + 1, by);
            btnExport.Size = new Size(bw, bh);

            btnAdd.Location = new Point(bx * 2 + 1, by);
            btnAdd.Size = new Size(bw, bh);

            btnUpdate.Location = new Point(bx * 3 + 1, by);
            btnUpdate.Size = new Size(bw, bh);

            btnDelete.Location = new Point(bx * 4 + 1, by);
            btnDelete.Size = new Size(bw, bh);

            btnStats.Location = new Point(bx * 5 + 1, by);
            btnStats.Size = new Size(bw, bh);

            btnSettings.Location = new Point(bx * 6 + 1, by);
            btnSettings.Size = new Size(bw, bh);

            btnClose.Location = new Point(bx * 7 + 1, by);
            btnClose.Size = new Size(bw, bh);

            Splitter1.Location = new Point(sx, sy);
            Splitter1.Size = new Size(sw, sh);

            ResumeLayout();

        }

        //  on tree view selection

        private void tvData_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tvData.SelectedNode != null)
            {
                DateTime dt = (DateTime)tvData.SelectedNode.Tag;
                FillListView(dt);
            }
        }

        //  on click of list item, update

        private void lvData_ItemActivate(object sender, EventArgs e)
        {
            if (lvData.SelectedItems.Count > 0)
            {
                UpdateData();
            }
        }

        //  on context menu add click

        private void PopupMenu_Add(object sender, EventArgs args)
        {
            AddData();
        }

        //  popup menu update

        private void PopupMenu_Update(object sender, EventArgs args)
        {
            UpdateData();
        }

        //  popup menu delete

        private void PopupMenu_Delete(object sender, EventArgs args)
        {
            DeleteData();
        }

        //   open import form

        private void btnImport_Click(object sender, EventArgs e)
        {
            frmImportForm frm = new frmImportForm();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadAllData();
            }

            frm.Close();
        }

        //  export data to text file

        private void btnExport_Click(object sender, EventArgs e)
        {
            frmExportForm frm = new frmExportForm();
            frm.sugarList = sugarList;
            frm.selectedMonth = (DateTime)tvData.SelectedNode.Tag;
            frm.longTermName = longTermName;
            frm.shortTermName = shortTermName;
            frm.ShowDialog();
            frm.Close();
        }

        //  add a new entry

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddData();
        }

        //  update an entry

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lvData.SelectedItems.Count > 0)
            {
                UpdateData();
            }
        }

        //  delete an entry

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvData.SelectedItems.Count > 0)
            {
                DeleteData();
            }
        }

        //  show statistics

        private void btnStats_Click(object sender, EventArgs e)
        {
            frmStats frm = new frmStats() ;
            frm.sugarList = sugarList;
            frm.start = DateTime.Today.AddMonths(-1);
            frm.end = DateTime.Today;
            frm.ShowDialog();
        }

        //  open settings form

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmSettingsForm frm = new frmSettingsForm();
            frm.ShowDialog();
            frm.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        //----------------------------
        //  private methods

        //  load the tree views

        private void LoadAllData()
        {
            TreeNode rootNode, firstNode, node;
            DateTime lastMonth = DateTime.MinValue;

            //  setup

            rootNode = new TreeNode("Months");
            rootNode.Tag = lastMonth;

            firstNode = new TreeNode("All");
            firstNode.Tag = lastMonth;
            rootNode.Nodes.Add(firstNode);

            tvData.Nodes.Clear();
            tvData.Nodes.Add(rootNode);

            //  load the data

            try
            {
                sugarList = new objSugarList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot load the data from the database - " + ex.Message);
                return;
            }

            //  add a tree node for each month

            foreach (objSugar sugar in sugarList.sugarList)
            {
                if ((sugar.Time.Year != lastMonth.Year) || (sugar.Time.Month != lastMonth.Month))
                {
                    node = new TreeNode(sugar.Time.ToString("MMMMM, yy"));
                    node.Tag = sugar.Time;
                    rootNode.Nodes.Add(node);
                }

                lastMonth = sugar.Time;
            }

            tvData.SelectedNode = firstNode;
        }

        //  on change of selection, fill the list view

        private void FillListView(DateTime dt)
        {
            ListViewItem lvItem;

            //  clear the list

            lvData.Items.Clear();

            //  fill the list

            foreach (objSugar sugar in sugarList.sugarList)
            {
                if ((dt == DateTime.MinValue) || ((sugar.Time.Month == dt.Month) && (sugar.Time.Year == dt.Year)))
                {
                    lvItem = new ListViewItem(sugar.Time.ToShortDateString());
                    lvItem.SubItems.Add(sugar.Time.ToShortTimeString());
                    lvItem.SubItems.Add(BlankIfZero(sugar.Sugar));
                    lvItem.SubItems.Add(BlankIfZero(sugar.LongTerm));
                    lvItem.SubItems.Add(BlankIfZero(sugar.ShortTerm));
                    lvItem.Tag = sugar;
                    lvData.Items.Add(lvItem);
                }
            }
        }

        //  open the add form

        private void AddData()
        {
            frmSugarForm frm = new frmSugarForm();
            frm.sugar = new objSugar();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadAllData();
            }
            frm.Close();
        }

        //  update item

        private void UpdateData()
        {
            frmSugarForm frm = new frmSugarForm();
            frm.sugar = (objSugar)lvData.SelectedItems[0].Tag;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadAllData();
            }
            frm.Close();
        }

        //  delete an item

        private void DeleteData()
        {
            objSugar sugar;

            //  prompt

            if (MessageBox.Show("Do you really want to delete this item?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sugar = (objSugar)lvData.SelectedItems[0].Tag;
                sugar.Delete();
                LoadAllData();
            }
        }

        //---------------------------
        //  helper methods

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
