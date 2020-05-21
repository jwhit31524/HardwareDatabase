namespace ConnectingToHWDatabase
{
    partial class CSharpHWForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CSharpHWForm));
            this.HWListView = new System.Windows.Forms.ListView();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.HWChangesTextBox = new System.Windows.Forms.TextBox();
            this.hardware_PurchasedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.may2020EquipmentHWDatabaseDataSet = new ConnectingToHWDatabase.May2020EquipmentHWDatabaseDataSet();
            this.HWBrandTextBox = new System.Windows.Forms.TextBox();
            this.hardware_PurchasedTableAdapter = new ConnectingToHWDatabase.May2020EquipmentHWDatabaseDataSetTableAdapters.Hardware_PurchasedTableAdapter();
            this.tableAdapterManager = new ConnectingToHWDatabase.May2020EquipmentHWDatabaseDataSetTableAdapters.TableAdapterManager();
            this.hardware_PurchasedBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.hardware_PurchasedBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.HWTypeTextBox = new System.Windows.Forms.TextBox();
            this.HWStatusTextBox = new System.Windows.Forms.TextBox();
            this.HWPriceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HWModelTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ClearTextBoxesButton = new System.Windows.Forms.Button();
            this.HWIDLabel = new System.Windows.Forms.Label();
            this.HWIDTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.hardware_PurchasedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.may2020EquipmentHWDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardware_PurchasedBindingNavigator)).BeginInit();
            this.hardware_PurchasedBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // HWListView
            // 
            this.HWListView.FullRowSelect = true;
            this.HWListView.HideSelection = false;
            this.HWListView.Location = new System.Drawing.Point(249, 28);
            this.HWListView.Name = "HWListView";
            this.HWListView.Size = new System.Drawing.Size(548, 337);
            this.HWListView.TabIndex = 19;
            this.HWListView.UseCompatibleStateImageBehavior = false;
            this.HWListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.HWListView_ItemSelectionChanged);
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.Location = new System.Drawing.Point(0, 415);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(119, 23);
            this.SaveChangesButton.TabIndex = 20;
            this.SaveChangesButton.Text = "Save Changes";
            this.SaveChangesButton.UseVisualStyleBackColor = true;
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
            // 
            // HWChangesTextBox
            // 
            this.HWChangesTextBox.Location = new System.Drawing.Point(80, 87);
            this.HWChangesTextBox.Multiline = true;
            this.HWChangesTextBox.Name = "HWChangesTextBox";
            this.HWChangesTextBox.Size = new System.Drawing.Size(120, 16);
            this.HWChangesTextBox.TabIndex = 21;
            // 
            // hardware_PurchasedBindingSource
            // 
            this.hardware_PurchasedBindingSource.DataMember = "Hardware_Purchased";
            this.hardware_PurchasedBindingSource.DataSource = this.may2020EquipmentHWDatabaseDataSet;
            // 
            // may2020EquipmentHWDatabaseDataSet
            // 
            this.may2020EquipmentHWDatabaseDataSet.DataSetName = "May2020EquipmentHWDatabaseDataSet";
            this.may2020EquipmentHWDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // HWBrandTextBox
            // 
            this.HWBrandTextBox.Location = new System.Drawing.Point(80, 129);
            this.HWBrandTextBox.Multiline = true;
            this.HWBrandTextBox.Name = "HWBrandTextBox";
            this.HWBrandTextBox.Size = new System.Drawing.Size(120, 22);
            this.HWBrandTextBox.TabIndex = 22;
            // 
            // hardware_PurchasedTableAdapter
            // 
            this.hardware_PurchasedTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.@__MigrationHistoryTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Hardware_PurchasedTableAdapter = this.hardware_PurchasedTableAdapter;
            this.tableAdapterManager.UpdateOrder = ConnectingToHWDatabase.May2020EquipmentHWDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hardware_PurchasedBindingNavigator
            // 
            this.hardware_PurchasedBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.hardware_PurchasedBindingNavigator.BindingSource = this.hardware_PurchasedBindingSource;
            this.hardware_PurchasedBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.hardware_PurchasedBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.hardware_PurchasedBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.hardware_PurchasedBindingNavigatorSaveItem});
            this.hardware_PurchasedBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.hardware_PurchasedBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.hardware_PurchasedBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.hardware_PurchasedBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.hardware_PurchasedBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.hardware_PurchasedBindingNavigator.Name = "hardware_PurchasedBindingNavigator";
            this.hardware_PurchasedBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.hardware_PurchasedBindingNavigator.Size = new System.Drawing.Size(818, 25);
            this.hardware_PurchasedBindingNavigator.TabIndex = 23;
            this.hardware_PurchasedBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // hardware_PurchasedBindingNavigatorSaveItem
            // 
            this.hardware_PurchasedBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.hardware_PurchasedBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("hardware_PurchasedBindingNavigatorSaveItem.Image")));
            this.hardware_PurchasedBindingNavigatorSaveItem.Name = "hardware_PurchasedBindingNavigatorSaveItem";
            this.hardware_PurchasedBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.hardware_PurchasedBindingNavigatorSaveItem.Text = "Save Data";
            this.hardware_PurchasedBindingNavigatorSaveItem.Click += new System.EventHandler(this.hardware_PurchasedBindingNavigatorSaveItem_Click);
            // 
            // HWTypeTextBox
            // 
            this.HWTypeTextBox.Location = new System.Drawing.Point(80, 224);
            this.HWTypeTextBox.Name = "HWTypeTextBox";
            this.HWTypeTextBox.Size = new System.Drawing.Size(120, 20);
            this.HWTypeTextBox.TabIndex = 26;
            // 
            // HWStatusTextBox
            // 
            this.HWStatusTextBox.Location = new System.Drawing.Point(80, 271);
            this.HWStatusTextBox.Name = "HWStatusTextBox";
            this.HWStatusTextBox.Size = new System.Drawing.Size(120, 20);
            this.HWStatusTextBox.TabIndex = 27;
            // 
            // HWPriceTextBox
            // 
            this.HWPriceTextBox.Location = new System.Drawing.Point(80, 321);
            this.HWPriceTextBox.Name = "HWPriceTextBox";
            this.HWPriceTextBox.Size = new System.Drawing.Size(120, 20);
            this.HWPriceTextBox.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "HWName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "HWBrand";
            // 
            // HWModelTextBox
            // 
            this.HWModelTextBox.Location = new System.Drawing.Point(80, 183);
            this.HWModelTextBox.Name = "HWModelTextBox";
            this.HWModelTextBox.Size = new System.Drawing.Size(120, 20);
            this.HWModelTextBox.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "HWModel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "HWType";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "HWStatus";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "HWPrice";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(146, 415);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(99, 23);
            this.AddButton.TabIndex = 36;
            this.AddButton.Text = "Add New Entry";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(272, 415);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(96, 23);
            this.DeleteButton.TabIndex = 37;
            this.DeleteButton.Text = "Delete Item";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ClearTextBoxesButton
            // 
            this.ClearTextBoxesButton.Location = new System.Drawing.Point(409, 415);
            this.ClearTextBoxesButton.Name = "ClearTextBoxesButton";
            this.ClearTextBoxesButton.Size = new System.Drawing.Size(161, 23);
            this.ClearTextBoxesButton.TabIndex = 38;
            this.ClearTextBoxesButton.Text = "Clear Text Boxes";
            this.ClearTextBoxesButton.UseVisualStyleBackColor = true;
            this.ClearTextBoxesButton.Click += new System.EventHandler(this.ClearTextBoxesButton_Click);
            // 
            // HWIDLabel
            // 
            this.HWIDLabel.AutoSize = true;
            this.HWIDLabel.Location = new System.Drawing.Point(13, 48);
            this.HWIDLabel.Name = "HWIDLabel";
            this.HWIDLabel.Size = new System.Drawing.Size(43, 13);
            this.HWIDLabel.TabIndex = 39;
            this.HWIDLabel.Text = "HW_ID";
            // 
            // HWIDTextBox
            // 
            this.HWIDTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.HWIDTextBox.Location = new System.Drawing.Point(80, 45);
            this.HWIDTextBox.Name = "HWIDTextBox";
            this.HWIDTextBox.ReadOnly = true;
            this.HWIDTextBox.Size = new System.Drawing.Size(120, 20);
            this.HWIDTextBox.TabIndex = 40;
            // 
            // CSharpHWForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 458);
            this.Controls.Add(this.HWIDTextBox);
            this.Controls.Add(this.HWIDLabel);
            this.Controls.Add(this.ClearTextBoxesButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HWModelTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HWPriceTextBox);
            this.Controls.Add(this.HWStatusTextBox);
            this.Controls.Add(this.HWTypeTextBox);
            this.Controls.Add(this.hardware_PurchasedBindingNavigator);
            this.Controls.Add(this.HWBrandTextBox);
            this.Controls.Add(this.HWChangesTextBox);
            this.Controls.Add(this.SaveChangesButton);
            this.Controls.Add(this.HWListView);
            this.Name = "CSharpHWForm";
            this.Text = "Hardware Form";
            this.Load += new System.EventHandler(this.CSharpHWForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hardware_PurchasedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.may2020EquipmentHWDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardware_PurchasedBindingNavigator)).EndInit();
            this.hardware_PurchasedBindingNavigator.ResumeLayout(false);
            this.hardware_PurchasedBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView HWListView;
        private System.Windows.Forms.Button SaveChangesButton;
        private System.Windows.Forms.TextBox HWChangesTextBox;
        private System.Windows.Forms.TextBox HWBrandTextBox;
        private May2020EquipmentHWDatabaseDataSet may2020EquipmentHWDatabaseDataSet;
        private System.Windows.Forms.BindingSource hardware_PurchasedBindingSource;
        private May2020EquipmentHWDatabaseDataSetTableAdapters.Hardware_PurchasedTableAdapter hardware_PurchasedTableAdapter;
        private May2020EquipmentHWDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator hardware_PurchasedBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton hardware_PurchasedBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox HWTypeTextBox;
        private System.Windows.Forms.TextBox HWStatusTextBox;
        private System.Windows.Forms.TextBox HWPriceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox HWModelTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ClearTextBoxesButton;
        private System.Windows.Forms.Label HWIDLabel;
        private System.Windows.Forms.TextBox HWIDTextBox;
    }
}

