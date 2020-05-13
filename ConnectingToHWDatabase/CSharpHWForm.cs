using ConnectingToHWDatabase.Controller;
using ConnectingToHWDatabase.database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace ConnectingToHWDatabase
{
    public partial class CSharpHWForm : Form
    {

        private readonly HWController hwController;
        private HWContext hwContext;
        public CSharpHWForm()
        {
          
            InitializeComponent();
            hwController = new HWController(this);
            //this.hwController = hwController;
            //this.Owner = cSharpHWForm;

            HWListView.View = View.Details;
            HWListView.Columns.Add("Hardware ID", -2, HorizontalAlignment.Left);
            HWListView.Columns.Add("Hardware Name", -2, HorizontalAlignment.Left);
            HWListView.Columns.Add("Hardware Brand", -2, HorizontalAlignment.Left);
            HWListView.Columns.Add("Hardware Model", -2, HorizontalAlignment.Left);
            HWListView.Columns.Add("Hardware Type", -2, HorizontalAlignment.Left);
            HWListView.Columns.Add("Hardware Status", -2, HorizontalAlignment.Left);
            HWListView.Columns.Add("Hardware Price", -2, HorizontalAlignment.Left);
            // HWListView.Columns.Add("Hardware DOP", -2, HorizontalAlignment.Left);

            RefreshView();
        }
        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            //hwController.ShowCSharpHWForm();
            var hardwareInfo= new HWEntity();
            hardwareInfo.Hardware_Name = HWChangesTextBox.Text;
            hardwareInfo.Hardware_Brand = HWBrandTextBox.Text;
            hardwareInfo.Hardware_Brand = HWModelTextBox.Text;
            hwContext.HWEntities.Add(hardwareInfo);
            hwContext.SaveChanges();


            this.Validate();
            this.hardware_PurchasedBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.may2020EquipmentHWDatabaseDataSet);

            RefreshView(); 
              
              
        }
        private void RefreshView()
        {
            
            HWListView.Items.Clear();
            hwContext = hwController.GetDbContext();
             var hardwareInfos = hwContext.HWEntities.AsEnumerable();

             foreach (HWEntity hardwareInfo in hardwareInfos)
             {
                 ListViewItem listViewItem = new ListViewItem();
                 listViewItem.Text = hardwareInfo.HWID.ToString();
                 listViewItem.SubItems.Add(hardwareInfo.Hardware_Name);
                listViewItem.SubItems.Add(hardwareInfo.Hardware_Brand);
                listViewItem.SubItems.Add(hardwareInfo.Hardware_Model);
                HWListView.Items.Add(listViewItem);
             }

        }

        private void hardware_PurchasedBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hardware_PurchasedBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.may2020EquipmentHWDatabaseDataSet);

        }

        private void CSharpHWForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'may2020EquipmentHWDatabaseDataSet.Hardware_Purchased' table. You can move, or remove it, as needed.
            this.hardware_PurchasedTableAdapter.Fill(this.may2020EquipmentHWDatabaseDataSet.Hardware_Purchased);

        }

        private void hardware_PurchasedDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
