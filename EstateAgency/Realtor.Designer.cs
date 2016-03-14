namespace EstateAgency
{
    partial class Realtor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Realtor));
			this.realtorDataView = new System.Windows.Forms.DataGridView();
			this.ФИО = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Логин = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Пароль = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rialtorBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.agencyDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
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
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.applyChangeBtn = new System.Windows.Forms.ToolStripButton();
			this.exit = new System.Windows.Forms.ToolStripButton();
			((System.ComponentModel.ISupportInitialize)(this.realtorDataView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rialtorBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.agencyDataSet2BindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
			this.bindingNavigator1.SuspendLayout();
			this.SuspendLayout();
			// 
			// realtorDataView
			// 
			this.realtorDataView.AllowUserToAddRows = false;
			this.realtorDataView.AutoGenerateColumns = false;
			this.realtorDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.realtorDataView.BackgroundColor = System.Drawing.Color.White;
			this.realtorDataView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.realtorDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.realtorDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ФИО,
            this.ID,
            this.Логин,
            this.Пароль});
			this.realtorDataView.DataSource = this.rialtorBindingSource;
			this.realtorDataView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.realtorDataView.Location = new System.Drawing.Point(0, 0);
			this.realtorDataView.Name = "realtorDataView";
			this.realtorDataView.RowHeadersWidth = 25;
			this.realtorDataView.Size = new System.Drawing.Size(463, 427);
			this.realtorDataView.TabIndex = 0;
			this.realtorDataView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.RialtorDataViewCellBeginEdit);
			// 
			// ФИО
			// 
			this.ФИО.DataPropertyName = "ФИО";
			this.ФИО.HeaderText = "ФИО";
			this.ФИО.Name = "ФИО";
			// 
			// ID
			// 
			this.ID.DataPropertyName = "ID";
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.Visible = false;
			// 
			// Логин
			// 
			this.Логин.DataPropertyName = "Логин";
			this.Логин.HeaderText = "Логин";
			this.Логин.Name = "Логин";
			// 
			// Пароль
			// 
			this.Пароль.DataPropertyName = "Пароль";
			this.Пароль.HeaderText = "Пароль";
			this.Пароль.Name = "Пароль";
			// 
			// rialtorBindingSource
			// 
			this.rialtorBindingSource.DataMember = "Rialtor";
			// 
			// bindingNavigator1
			// 
			this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
			this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
			this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
			this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.bindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.toolStripSeparator1,
            this.applyChangeBtn,
            this.exit});
			this.bindingNavigator1.Location = new System.Drawing.Point(0, 402);
			this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.bindingNavigator1.Name = "bindingNavigator1";
			this.bindingNavigator1.Padding = new System.Windows.Forms.Padding(5, 0, 1, 0);
			this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
			this.bindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.bindingNavigator1.Size = new System.Drawing.Size(463, 25);
			this.bindingNavigator1.TabIndex = 1;
			this.bindingNavigator1.Text = "bindingNavigator1";
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = global::EstateAgency.Properties.Resources.plus_black_symbol;
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorAddNewItem.Text = "Add new";
			this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.BindingNavigatorAddNewItemClick);
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
			this.bindingNavigatorDeleteItem.Image = global::EstateAgency.Properties.Resources.delete_cross;
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem.Text = "Delete";
			this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.BindingNavigatorDeleteItemClick);
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = global::EstateAgency.Properties.Resources.previous_track_button;
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveFirstItem.Text = "Move first";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = global::EstateAgency.Properties.Resources.left_arrow;
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
			this.bindingNavigatorMoveNextItem.Image = global::EstateAgency.Properties.Resources.play_arrow;
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveNextItem.Text = "Move next";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = global::EstateAgency.Properties.Resources.next_track_button;
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
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// applyChangeBtn
			// 
			this.applyChangeBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.applyChangeBtn.Enabled = false;
			this.applyChangeBtn.Image = global::EstateAgency.Properties.Resources.Done;
			this.applyChangeBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.applyChangeBtn.Name = "applyChangeBtn";
			this.applyChangeBtn.Size = new System.Drawing.Size(23, 22);
			this.applyChangeBtn.Text = "Применить";
			this.applyChangeBtn.Click += new System.EventHandler(this.ApplyChangeBtnClick);
			// 
			// exit
			// 
			this.exit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.exit.Image = global::EstateAgency.Properties.Resources.enter;
			this.exit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.exit.Name = "exit";
			this.exit.Size = new System.Drawing.Size(23, 22);
			this.exit.Text = "Выход";
			this.exit.Click += new System.EventHandler(this.ExitClick);
			// 
			// Realtor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(463, 427);
			this.Controls.Add(this.bindingNavigator1);
			this.Controls.Add(this.realtorDataView);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Realtor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Риэлторы";
			this.Load += new System.EventHandler(this.RialtorLoad);
			((System.ComponentModel.ISupportInitialize)(this.realtorDataView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rialtorBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.agencyDataSet2BindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
			this.bindingNavigator1.ResumeLayout(false);
			this.bindingNavigator1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView realtorDataView;
        private System.Windows.Forms.BindingSource agencyDataSet2BindingSource;
        private System.Windows.Forms.BindingSource rialtorBindingSource;
		private System.Windows.Forms.BindingNavigator bindingNavigator1;
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
		private System.Windows.Forms.ToolStripButton applyChangeBtn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ФИО;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Логин;
		private System.Windows.Forms.DataGridViewTextBoxColumn Пароль;
		private System.Windows.Forms.ToolStripButton exit;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}