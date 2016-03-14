namespace EstateAgency
{
    partial class Offers
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Offers));
			this.estateBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Шифр = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ТипНедвижимости = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ТипСделки = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Описание = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Район = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Адрес = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Контрагент = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Цена = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Коммисия = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Дата = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Актуально = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Риэлтор = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.checkBox8 = new System.Windows.Forms.CheckBox();
			this.dateTo = new System.Windows.Forms.DateTimePicker();
			this.checkBox7 = new System.Windows.Forms.CheckBox();
			this.dealsTypeBox = new System.Windows.Forms.ComboBox();
			this.checkBox6 = new System.Windows.Forms.CheckBox();
			this.checkBox5 = new System.Windows.Forms.CheckBox();
			this.districtBox = new System.Windows.Forms.ComboBox();
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.dateFrom = new System.Windows.Forms.DateTimePicker();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.rialtors = new System.Windows.Forms.ComboBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.estateTypes = new System.Windows.Forms.ComboBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.estateBindingSource)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.tableLayoutPanel2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
			this.bindingNavigator1.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// estateBindingSource
			// 
			this.estateBindingSource.DataMember = "Estate";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 161F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1019, 485);
			this.tableLayoutPanel1.TabIndex = 2;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Шифр,
            this.ID,
            this.ТипНедвижимости,
            this.ТипСделки,
            this.Описание,
            this.Район,
            this.Адрес,
            this.Контрагент,
            this.Цена,
            this.Коммисия,
            this.Дата,
            this.Актуально,
            this.Риэлтор});
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(3, 3);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 24;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridView1.Size = new System.Drawing.Size(1013, 318);
			this.dataGridView1.TabIndex = 1;
			// 
			// Шифр
			// 
			this.Шифр.DataPropertyName = "a.ID";
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle1.Format = "000000000";
			dataGridViewCellStyle1.NullValue = null;
			this.Шифр.DefaultCellStyle = dataGridViewCellStyle1;
			this.Шифр.FillWeight = 79.18781F;
			this.Шифр.HeaderText = "Шифр";
			this.Шифр.Name = "Шифр";
			// 
			// ID
			// 
			this.ID.DataPropertyName = "a.ID";
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Visible = false;
			// 
			// ТипНедвижимости
			// 
			this.ТипНедвижимости.DataPropertyName = "c.Тип";
			this.ТипНедвижимости.FillWeight = 154.498F;
			this.ТипНедвижимости.HeaderText = "Тип недвижимости";
			this.ТипНедвижимости.Name = "ТипНедвижимости";
			// 
			// ТипСделки
			// 
			this.ТипСделки.DataPropertyName = "e.Тип";
			this.ТипСделки.FillWeight = 96.63142F;
			this.ТипСделки.HeaderText = "Тип cделки";
			this.ТипСделки.Name = "ТипСделки";
			// 
			// Описание
			// 
			this.Описание.DataPropertyName = "Описание";
			this.Описание.FillWeight = 96.63142F;
			this.Описание.HeaderText = "Описание";
			this.Описание.Name = "Описание";
			// 
			// Район
			// 
			this.Район.DataPropertyName = "Район";
			this.Район.FillWeight = 96.63142F;
			this.Район.HeaderText = "Район";
			this.Район.Name = "Район";
			// 
			// Адрес
			// 
			this.Адрес.DataPropertyName = "a.Адрес";
			this.Адрес.FillWeight = 96.63142F;
			this.Адрес.HeaderText = "Адрес";
			this.Адрес.Name = "Адрес";
			// 
			// Контрагент
			// 
			this.Контрагент.DataPropertyName = "ФИО_Наименование";
			this.Контрагент.FillWeight = 96.63142F;
			this.Контрагент.HeaderText = "Контрагент";
			this.Контрагент.Name = "Контрагент";
			// 
			// Цена
			// 
			this.Цена.DataPropertyName = "Цена";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle2.Format = "C2";
			dataGridViewCellStyle2.NullValue = null;
			this.Цена.DefaultCellStyle = dataGridViewCellStyle2;
			this.Цена.FillWeight = 96.63142F;
			this.Цена.HeaderText = "Цена";
			this.Цена.Name = "Цена";
			// 
			// Коммисия
			// 
			this.Коммисия.DataPropertyName = "Комиссия";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle3.Format = "C2";
			dataGridViewCellStyle3.NullValue = null;
			this.Коммисия.DefaultCellStyle = dataGridViewCellStyle3;
			this.Коммисия.FillWeight = 96.63142F;
			this.Коммисия.HeaderText = "Комиcсия";
			this.Коммисия.Name = "Коммисия";
			// 
			// Дата
			// 
			this.Дата.DataPropertyName = "ДатаПредлож";
			this.Дата.FillWeight = 96.63142F;
			this.Дата.HeaderText = "Дата предложения";
			this.Дата.Name = "Дата";
			// 
			// Актуально
			// 
			this.Актуально.DataPropertyName = "Актуально";
			this.Актуально.FillWeight = 96.63142F;
			this.Актуально.HeaderText = "Актуально";
			this.Актуально.Name = "Актуально";
			this.Актуально.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Актуально.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// Риэлтор
			// 
			this.Риэлтор.DataPropertyName = "ФИО";
			this.Риэлтор.FillWeight = 96.63142F;
			this.Риэлтор.HeaderText = "Риэлтор";
			this.Риэлтор.Name = "Риэлтор";
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.51485F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.48515F));
			this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 327);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(1013, 155);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.checkBox8);
			this.groupBox1.Controls.Add(this.dateTo);
			this.groupBox1.Controls.Add(this.checkBox7);
			this.groupBox1.Controls.Add(this.dealsTypeBox);
			this.groupBox1.Controls.Add(this.checkBox6);
			this.groupBox1.Controls.Add(this.checkBox5);
			this.groupBox1.Controls.Add(this.districtBox);
			this.groupBox1.Controls.Add(this.checkBox4);
			this.groupBox1.Controls.Add(this.dateFrom);
			this.groupBox1.Controls.Add(this.checkBox3);
			this.groupBox1.Controls.Add(this.rialtors);
			this.groupBox1.Controls.Add(this.checkBox2);
			this.groupBox1.Controls.Add(this.estateTypes);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(789, 149);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Критерии отбора";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(469, 58);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(311, 20);
			this.textBox1.TabIndex = 15;
			this.textBox1.Text = "ул. Новоказанская, д.3, кв.15";
			// 
			// checkBox8
			// 
			this.checkBox8.AutoSize = true;
			this.checkBox8.Checked = true;
			this.checkBox8.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox8.Location = new System.Drawing.Point(383, 115);
			this.checkBox8.Name = "checkBox8";
			this.checkBox8.Size = new System.Drawing.Size(197, 17);
			this.checkBox8.TabIndex = 14;
			this.checkBox8.Text = "Только актуальные предложения";
			this.checkBox8.UseVisualStyleBackColor = true;
			this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
			// 
			// dateTo
			// 
			this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTo.Location = new System.Drawing.Point(148, 121);
			this.dateTo.Name = "dateTo";
			this.dateTo.Size = new System.Drawing.Size(94, 20);
			this.dateTo.TabIndex = 13;
			// 
			// checkBox7
			// 
			this.checkBox7.AutoSize = true;
			this.checkBox7.Location = new System.Drawing.Point(7, 126);
			this.checkBox7.Name = "checkBox7";
			this.checkBox7.Size = new System.Drawing.Size(41, 17);
			this.checkBox7.TabIndex = 12;
			this.checkBox7.Text = "по:";
			this.checkBox7.UseVisualStyleBackColor = true;
			// 
			// dealsTypeBox
			// 
			this.dealsTypeBox.DisplayMember = "Text";
			this.dealsTypeBox.FormattingEnabled = true;
			this.dealsTypeBox.Location = new System.Drawing.Point(469, 84);
			this.dealsTypeBox.Name = "dealsTypeBox";
			this.dealsTypeBox.Size = new System.Drawing.Size(311, 21);
			this.dealsTypeBox.TabIndex = 11;
			this.dealsTypeBox.ValueMember = "Value";
			this.dealsTypeBox.SelectedIndexChanged += new System.EventHandler(this.dealsTypeBox_SelectedIndexChanged);
			// 
			// checkBox6
			// 
			this.checkBox6.AutoSize = true;
			this.checkBox6.Location = new System.Drawing.Point(383, 86);
			this.checkBox6.Name = "checkBox6";
			this.checkBox6.Size = new System.Drawing.Size(87, 17);
			this.checkBox6.TabIndex = 10;
			this.checkBox6.Text = "Тип сделки:";
			this.checkBox6.UseVisualStyleBackColor = true;
			this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
			// 
			// checkBox5
			// 
			this.checkBox5.AutoSize = true;
			this.checkBox5.Location = new System.Drawing.Point(383, 59);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new System.Drawing.Size(60, 17);
			this.checkBox5.TabIndex = 8;
			this.checkBox5.Text = "Адрес:";
			this.checkBox5.UseVisualStyleBackColor = true;
			this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
			// 
			// districtBox
			// 
			this.districtBox.DisplayMember = "Text";
			this.districtBox.FormattingEnabled = true;
			this.districtBox.Location = new System.Drawing.Point(469, 30);
			this.districtBox.Name = "districtBox";
			this.districtBox.Size = new System.Drawing.Size(311, 21);
			this.districtBox.TabIndex = 7;
			this.districtBox.ValueMember = "Value";
			this.districtBox.SelectedIndexChanged += new System.EventHandler(this.districtBox_SelectedIndexChanged);
			// 
			// checkBox4
			// 
			this.checkBox4.AutoSize = true;
			this.checkBox4.Location = new System.Drawing.Point(383, 32);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(60, 17);
			this.checkBox4.TabIndex = 6;
			this.checkBox4.Text = "Район:";
			this.checkBox4.UseVisualStyleBackColor = true;
			this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
			// 
			// dateFrom
			// 
			this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateFrom.Location = new System.Drawing.Point(148, 97);
			this.dateFrom.Name = "dateFrom";
			this.dateFrom.Size = new System.Drawing.Size(94, 20);
			this.dateFrom.TabIndex = 5;
			// 
			// checkBox3
			// 
			this.checkBox3.AutoSize = true;
			this.checkBox3.Location = new System.Drawing.Point(7, 100);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(135, 17);
			this.checkBox3.TabIndex = 4;
			this.checkBox3.Text = "Дата предложения с:";
			this.checkBox3.UseVisualStyleBackColor = true;
			this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
			// 
			// rialtors
			// 
			this.rialtors.DisplayMember = "Text";
			this.rialtors.FormattingEnabled = true;
			this.rialtors.Location = new System.Drawing.Point(93, 68);
			this.rialtors.Name = "rialtors";
			this.rialtors.Size = new System.Drawing.Size(149, 21);
			this.rialtors.TabIndex = 3;
			this.rialtors.ValueMember = "Value";
			this.rialtors.SelectedIndexChanged += new System.EventHandler(this.rialtors_SelectedIndexChanged);
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Location = new System.Drawing.Point(7, 70);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(68, 17);
			this.checkBox2.TabIndex = 2;
			this.checkBox2.Text = "Риэлтор";
			this.checkBox2.UseVisualStyleBackColor = true;
			this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// estateTypes
			// 
			this.estateTypes.DisplayMember = "Text";
			this.estateTypes.FormattingEnabled = true;
			this.estateTypes.Location = new System.Drawing.Point(7, 38);
			this.estateTypes.Name = "estateTypes";
			this.estateTypes.Size = new System.Drawing.Size(235, 21);
			this.estateTypes.TabIndex = 1;
			this.estateTypes.ValueMember = "Value";
			this.estateTypes.SelectedIndexChanged += new System.EventHandler(this.estateTypes_SelectedIndexChanged);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(7, 19);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(126, 17);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Тип недвижимости:";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 1;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.Controls.Add(this.bindingNavigator1, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 2);
			this.tableLayoutPanel3.Controls.Add(this.button1, 0, 1);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(798, 3);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 3;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.84615F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.15385F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(212, 149);
			this.tableLayoutPanel3.TabIndex = 3;
			// 
			// bindingNavigator1
			// 
			this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
			this.bindingNavigator1.CountItem = null;
			this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
			this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
			this.bindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripSeparator1,
            this.toolStripButton2});
			this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
			this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.bindingNavigator1.Name = "bindingNavigator1";
			this.bindingNavigator1.Padding = new System.Windows.Forms.Padding(5, 0, 1, 0);
			this.bindingNavigator1.PositionItem = null;
			this.bindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.bindingNavigator1.Size = new System.Drawing.Size(187, 25);
			this.bindingNavigator1.TabIndex = 2;
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
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = global::EstateAgency.Properties.Resources.delete_cross;
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem.Text = "Delete";
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
			// toolStripButton2
			// 
			this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton2.Image = global::EstateAgency.Properties.Resources.Done;
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton2.Text = "toolStripButton2";
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.ColumnCount = 2;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.39024F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.60976F));
			this.tableLayoutPanel4.Controls.Add(this.button2, 1, 1);
			this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 68);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 2;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.25641F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.74359F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(205, 78);
			this.tableLayoutPanel4.TabIndex = 4;
			// 
			// button2
			// 
			this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button2.Image = global::EstateAgency.Properties.Resources.enter;
			this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.Location = new System.Drawing.Point(134, 49);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(68, 26);
			this.button2.TabIndex = 0;
			this.button2.Text = "Выход";
			this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Dock = System.Windows.Forms.DockStyle.Top;
			this.button1.Image = global::EstateAgency.Properties.Resources.business_card_of_a_man_with_contact_info;
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.Location = new System.Drawing.Point(3, 38);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(206, 24);
			this.button1.TabIndex = 5;
			this.button1.Text = "Карта объекта";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.ObjectCardViewClick);
			// 
			// Offers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1019, 485);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Offers";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Предложения объектов недвижимости";
			this.Load += new System.EventHandler(this.Offers_Load);
			((System.ComponentModel.ISupportInitialize)(this.estateBindingSource)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
			this.bindingNavigator1.ResumeLayout(false);
			this.bindingNavigator1.PerformLayout();
			this.tableLayoutPanel4.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource estateBindingSource;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox checkBox8;
		private System.Windows.Forms.DateTimePicker dateTo;
		private System.Windows.Forms.CheckBox checkBox7;
		private System.Windows.Forms.ComboBox dealsTypeBox;
		private System.Windows.Forms.CheckBox checkBox6;
		private System.Windows.Forms.CheckBox checkBox5;
		private System.Windows.Forms.ComboBox districtBox;
		private System.Windows.Forms.CheckBox checkBox4;
		private System.Windows.Forms.DateTimePicker dateFrom;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.ComboBox rialtors;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.ComboBox estateTypes;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.BindingNavigator bindingNavigator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Шифр;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn ТипНедвижимости;
		private System.Windows.Forms.DataGridViewTextBoxColumn ТипСделки;
		private System.Windows.Forms.DataGridViewTextBoxColumn Описание;
		private System.Windows.Forms.DataGridViewTextBoxColumn Район;
		private System.Windows.Forms.DataGridViewTextBoxColumn Адрес;
		private System.Windows.Forms.DataGridViewTextBoxColumn Контрагент;
		private System.Windows.Forms.DataGridViewTextBoxColumn Цена;
		private System.Windows.Forms.DataGridViewTextBoxColumn Коммисия;
		private System.Windows.Forms.DataGridViewTextBoxColumn Дата;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Актуально;
		private System.Windows.Forms.DataGridViewTextBoxColumn Риэлтор;
	}
}