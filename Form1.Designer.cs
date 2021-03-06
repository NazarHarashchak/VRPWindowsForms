namespace VRPWindowsForms
{
    partial class Form1
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
            this.Routes = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.carsDataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.customerNameFiltertxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.toDateFiltertxt = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fromDateFiltertxt = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusFilterBox = new System.Windows.Forms.ComboBox();
            this.storeFilterBox = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.createStoreButton = new System.Windows.Forms.Button();
            this.storesDataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.addOrderButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ordersDataGrid = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addedRouteGrid = new System.Windows.Forms.DataGridView();
            this.WaysGroupBox = new System.Windows.Forms.GroupBox();
            this.waysTabControl = new System.Windows.Forms.TabControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.carsDropDown = new System.Windows.Forms.ComboBox();
            this.pointsDropDown = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.phoneNumberFiltertxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.emailFiltertxt = new System.Windows.Forms.TextBox();
            this.secondNameFiltertxt = new System.Windows.Forms.TextBox();
            this.nameFiltertxt = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.customersDataGrid = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.dateCheckbox = new System.Windows.Forms.CheckBox();
            this.Routes.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGrid)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storesDataGrid)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGrid)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addedRouteGrid)).BeginInit();
            this.WaysGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Routes
            // 
            this.Routes.Controls.Add(this.tabPage2);
            this.Routes.Controls.Add(this.tabPage1);
            this.Routes.Controls.Add(this.tabPage3);
            this.Routes.Location = new System.Drawing.Point(-1, 27);
            this.Routes.Name = "Routes";
            this.Routes.SelectedIndex = 0;
            this.Routes.Size = new System.Drawing.Size(1224, 520);
            this.Routes.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.Routes.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox7);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1216, 494);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Orders";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button4);
            this.groupBox7.Controls.Add(this.carsDataGrid);
            this.groupBox7.Location = new System.Drawing.Point(697, 383);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(513, 95);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Cars";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(354, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 26);
            this.button4.TabIndex = 3;
            this.button4.Text = "Add new car";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // carsDataGrid
            // 
            this.carsDataGrid.AllowUserToAddRows = false;
            this.carsDataGrid.AllowUserToDeleteRows = false;
            this.carsDataGrid.AllowUserToOrderColumns = true;
            this.carsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carsDataGrid.Location = new System.Drawing.Point(6, 19);
            this.carsDataGrid.Name = "carsDataGrid";
            this.carsDataGrid.RowHeadersVisible = false;
            this.carsDataGrid.Size = new System.Drawing.Size(317, 69);
            this.carsDataGrid.TabIndex = 2;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dateCheckbox);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.customerNameFiltertxt);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.toDateFiltertxt);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.fromDateFiltertxt);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.statusFilterBox);
            this.groupBox6.Controls.Add(this.storeFilterBox);
            this.groupBox6.Location = new System.Drawing.Point(697, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(513, 166);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Filter";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(373, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Customer name";
            // 
            // customerNameFiltertxt
            // 
            this.customerNameFiltertxt.Location = new System.Drawing.Point(337, 45);
            this.customerNameFiltertxt.Name = "customerNameFiltertxt";
            this.customerNameFiltertxt.Size = new System.Drawing.Size(140, 20);
            this.customerNameFiltertxt.TabIndex = 9;
            this.customerNameFiltertxt.TextChanged += new System.EventHandler(this.storeFilterBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "To";
            // 
            // toDateFiltertxt
            // 
            this.toDateFiltertxt.Location = new System.Drawing.Point(223, 127);
            this.toDateFiltertxt.Name = "toDateFiltertxt";
            this.toDateFiltertxt.Size = new System.Drawing.Size(200, 20);
            this.toDateFiltertxt.TabIndex = 7;
            this.toDateFiltertxt.ValueChanged += new System.EventHandler(this.storeFilterBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date range";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "From";
            // 
            // fromDateFiltertxt
            // 
            this.fromDateFiltertxt.Location = new System.Drawing.Point(6, 127);
            this.fromDateFiltertxt.Name = "fromDateFiltertxt";
            this.fromDateFiltertxt.Size = new System.Drawing.Size(200, 20);
            this.fromDateFiltertxt.TabIndex = 4;
            this.fromDateFiltertxt.ValueChanged += new System.EventHandler(this.storeFilterBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Store";
            // 
            // statusFilterBox
            // 
            this.statusFilterBox.FormattingEnabled = true;
            this.statusFilterBox.Location = new System.Drawing.Point(170, 44);
            this.statusFilterBox.Name = "statusFilterBox";
            this.statusFilterBox.Size = new System.Drawing.Size(121, 21);
            this.statusFilterBox.TabIndex = 1;
            this.statusFilterBox.Text = "Select status";
            this.statusFilterBox.SelectedIndexChanged += new System.EventHandler(this.storeFilterBox_SelectedIndexChanged);
            // 
            // storeFilterBox
            // 
            this.storeFilterBox.FormattingEnabled = true;
            this.storeFilterBox.Location = new System.Drawing.Point(6, 44);
            this.storeFilterBox.Name = "storeFilterBox";
            this.storeFilterBox.Size = new System.Drawing.Size(121, 21);
            this.storeFilterBox.TabIndex = 0;
            this.storeFilterBox.Text = "Select store";
            this.storeFilterBox.SelectedIndexChanged += new System.EventHandler(this.storeFilterBox_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.createStoreButton);
            this.groupBox5.Controls.Add(this.storesDataGrid);
            this.groupBox5.Location = new System.Drawing.Point(697, 246);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(513, 137);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Stores";
            // 
            // createStoreButton
            // 
            this.createStoreButton.Location = new System.Drawing.Point(354, 19);
            this.createStoreButton.Name = "createStoreButton";
            this.createStoreButton.Size = new System.Drawing.Size(123, 26);
            this.createStoreButton.TabIndex = 1;
            this.createStoreButton.Text = "Create new store";
            this.createStoreButton.UseVisualStyleBackColor = true;
            this.createStoreButton.Click += new System.EventHandler(this.createStoreButton_Click);
            // 
            // storesDataGrid
            // 
            this.storesDataGrid.AllowUserToAddRows = false;
            this.storesDataGrid.AllowUserToDeleteRows = false;
            this.storesDataGrid.AllowUserToOrderColumns = true;
            this.storesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storesDataGrid.Location = new System.Drawing.Point(6, 19);
            this.storesDataGrid.Name = "storesDataGrid";
            this.storesDataGrid.RowHeadersVisible = false;
            this.storesDataGrid.Size = new System.Drawing.Size(317, 112);
            this.storesDataGrid.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.addOrderButton);
            this.groupBox4.Location = new System.Drawing.Point(697, 178);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(513, 62);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Create new Order";
            // 
            // addOrderButton
            // 
            this.addOrderButton.Location = new System.Drawing.Point(190, 19);
            this.addOrderButton.Name = "addOrderButton";
            this.addOrderButton.Size = new System.Drawing.Size(123, 26);
            this.addOrderButton.TabIndex = 2;
            this.addOrderButton.Text = "Add new order";
            this.addOrderButton.UseVisualStyleBackColor = true;
            this.addOrderButton.Click += new System.EventHandler(this.addOrderButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ordersDataGrid);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(685, 472);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Orders";
            // 
            // ordersDataGrid
            // 
            this.ordersDataGrid.AllowUserToAddRows = false;
            this.ordersDataGrid.AllowUserToDeleteRows = false;
            this.ordersDataGrid.AllowUserToOrderColumns = true;
            this.ordersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGrid.Location = new System.Drawing.Point(3, 19);
            this.ordersDataGrid.Name = "ordersDataGrid";
            this.ordersDataGrid.RowHeadersVisible = false;
            this.ordersDataGrid.Size = new System.Drawing.Size(676, 447);
            this.ordersDataGrid.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1216, 494);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Routes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gmap);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.comboBox1);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.WaysGroupBox);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(1210, 488);
            this.splitContainer1.SplitterDistance = 727;
            this.splitContainer1.SplitterIncrement = 2;
            this.splitContainer1.TabIndex = 0;
            // 
            // gmap
            // 
            this.gmap.AutoSize = true;
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemory = 5;
            this.gmap.Location = new System.Drawing.Point(3, 3);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 15;
            this.gmap.MinZoom = 2;
            this.gmap.MouseWheelZoomEnabled = true;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(721, 472);
            this.gmap.TabIndex = 1;
            this.gmap.Zoom = 13D;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(142, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(298, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "Select store";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addedRouteGrid);
            this.groupBox2.Location = new System.Drawing.Point(5, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(473, 169);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Added orders";
            // 
            // addedRouteGrid
            // 
            this.addedRouteGrid.AllowUserToAddRows = false;
            this.addedRouteGrid.AllowUserToDeleteRows = false;
            this.addedRouteGrid.AllowUserToOrderColumns = true;
            this.addedRouteGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addedRouteGrid.Location = new System.Drawing.Point(6, 19);
            this.addedRouteGrid.Name = "addedRouteGrid";
            this.addedRouteGrid.RowHeadersVisible = false;
            this.addedRouteGrid.Size = new System.Drawing.Size(461, 144);
            this.addedRouteGrid.TabIndex = 1;
            // 
            // WaysGroupBox
            // 
            this.WaysGroupBox.Controls.Add(this.waysTabControl);
            this.WaysGroupBox.Location = new System.Drawing.Point(3, 298);
            this.WaysGroupBox.Name = "WaysGroupBox";
            this.WaysGroupBox.Size = new System.Drawing.Size(473, 177);
            this.WaysGroupBox.TabIndex = 1;
            this.WaysGroupBox.TabStop = false;
            this.WaysGroupBox.Text = "Ways";
            // 
            // waysTabControl
            // 
            this.waysTabControl.Location = new System.Drawing.Point(8, 19);
            this.waysTabControl.Name = "waysTabControl";
            this.waysTabControl.SelectedIndex = 0;
            this.waysTabControl.Size = new System.Drawing.Size(459, 152);
            this.waysTabControl.TabIndex = 0;
            this.waysTabControl.TabIndexChanged += new System.EventHandler(this.waysTabControl_TabIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.carsDropDown);
            this.groupBox1.Controls.Add(this.pointsDropDown);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(5, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Active orders";
            // 
            // carsDropDown
            // 
            this.carsDropDown.FormattingEnabled = true;
            this.carsDropDown.Location = new System.Drawing.Point(15, 47);
            this.carsDropDown.Name = "carsDropDown";
            this.carsDropDown.Size = new System.Drawing.Size(290, 21);
            this.carsDropDown.TabIndex = 4;
            this.carsDropDown.Text = "Select car";
            // 
            // pointsDropDown
            // 
            this.pointsDropDown.FormattingEnabled = true;
            this.pointsDropDown.Location = new System.Drawing.Point(15, 20);
            this.pointsDropDown.Name = "pointsDropDown";
            this.pointsDropDown.Size = new System.Drawing.Size(290, 21);
            this.pointsDropDown.TabIndex = 3;
            this.pointsDropDown.Text = "Select order";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(369, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Calculate ways";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(369, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add on map";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox10);
            this.tabPage3.Controls.Add(this.groupBox9);
            this.tabPage3.Controls.Add(this.groupBox8);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1216, 494);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Customers";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.button5);
            this.groupBox10.Location = new System.Drawing.Point(694, 220);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(518, 100);
            this.groupBox10.TabIndex = 2;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Add new customer";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(207, 47);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 36);
            this.button5.TabIndex = 0;
            this.button5.Text = "Add";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label10);
            this.groupBox9.Controls.Add(this.phoneNumberFiltertxt);
            this.groupBox9.Controls.Add(this.label9);
            this.groupBox9.Controls.Add(this.label8);
            this.groupBox9.Controls.Add(this.label7);
            this.groupBox9.Controls.Add(this.emailFiltertxt);
            this.groupBox9.Controls.Add(this.secondNameFiltertxt);
            this.groupBox9.Controls.Add(this.nameFiltertxt);
            this.groupBox9.Location = new System.Drawing.Point(694, 3);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(518, 211);
            this.groupBox9.TabIndex = 1;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Filter";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(322, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Phone number";
            // 
            // phoneNumberFiltertxt
            // 
            this.phoneNumberFiltertxt.Location = new System.Drawing.Point(295, 103);
            this.phoneNumberFiltertxt.Name = "phoneNumberFiltertxt";
            this.phoneNumberFiltertxt.Size = new System.Drawing.Size(140, 20);
            this.phoneNumberFiltertxt.TabIndex = 6;
            this.phoneNumberFiltertxt.TextChanged += new System.EventHandler(this.emailFiltertxt_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(336, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(95, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Second name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(107, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Name";
            // 
            // emailFiltertxt
            // 
            this.emailFiltertxt.Location = new System.Drawing.Point(295, 45);
            this.emailFiltertxt.Name = "emailFiltertxt";
            this.emailFiltertxt.Size = new System.Drawing.Size(140, 20);
            this.emailFiltertxt.TabIndex = 2;
            this.emailFiltertxt.TextChanged += new System.EventHandler(this.emailFiltertxt_TextChanged);
            // 
            // secondNameFiltertxt
            // 
            this.secondNameFiltertxt.Location = new System.Drawing.Point(69, 103);
            this.secondNameFiltertxt.Name = "secondNameFiltertxt";
            this.secondNameFiltertxt.Size = new System.Drawing.Size(140, 20);
            this.secondNameFiltertxt.TabIndex = 1;
            this.secondNameFiltertxt.TextChanged += new System.EventHandler(this.emailFiltertxt_TextChanged);
            // 
            // nameFiltertxt
            // 
            this.nameFiltertxt.Location = new System.Drawing.Point(69, 45);
            this.nameFiltertxt.Name = "nameFiltertxt";
            this.nameFiltertxt.Size = new System.Drawing.Size(140, 20);
            this.nameFiltertxt.TabIndex = 0;
            this.nameFiltertxt.TextChanged += new System.EventHandler(this.emailFiltertxt_TextChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.customersDataGrid);
            this.groupBox8.Location = new System.Drawing.Point(3, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(685, 488);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Customers";
            // 
            // customersDataGrid
            // 
            this.customersDataGrid.AllowUserToAddRows = false;
            this.customersDataGrid.AllowUserToDeleteRows = false;
            this.customersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDataGrid.Location = new System.Drawing.Point(6, 19);
            this.customersDataGrid.Name = "customersDataGrid";
            this.customersDataGrid.RowHeadersVisible = false;
            this.customersDataGrid.Size = new System.Drawing.Size(673, 461);
            this.customersDataGrid.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1227, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1148, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Reload";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dateCheckbox
            // 
            this.dateCheckbox.AutoSize = true;
            this.dateCheckbox.Location = new System.Drawing.Point(101, 93);
            this.dateCheckbox.Name = "dateCheckbox";
            this.dateCheckbox.Size = new System.Drawing.Size(86, 17);
            this.dateCheckbox.TabIndex = 11;
            this.dateCheckbox.Text = "Filter by date";
            this.dateCheckbox.UseVisualStyleBackColor = true;
            this.dateCheckbox.CheckedChanged += new System.EventHandler(this.storeFilterBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 545);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Routes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "VRP";
            this.Routes.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGrid)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.storesDataGrid)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGrid)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addedRouteGrid)).EndInit();
            this.WaysGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Routes;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.GroupBox WaysGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView addedRouteGrid;
        private System.Windows.Forms.ComboBox pointsDropDown;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button createStoreButton;
        private System.Windows.Forms.DataGridView storesDataGrid;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button addOrderButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView ordersDataGrid;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox carsDropDown;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView carsDataGrid;
        private System.Windows.Forms.TabControl waysTabControl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox statusFilterBox;
        private System.Windows.Forms.ComboBox storeFilterBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox customerNameFiltertxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker toDateFiltertxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker fromDateFiltertxt;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.DataGridView customersDataGrid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox phoneNumberFiltertxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox emailFiltertxt;
        private System.Windows.Forms.TextBox secondNameFiltertxt;
        private System.Windows.Forms.TextBox nameFiltertxt;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckBox dateCheckbox;
    }
}

