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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.carsDropDown = new System.Windows.Forms.ComboBox();
            this.pointsDropDown = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.waysTabControl = new System.Windows.Forms.TabControl();
            this.Routes.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGrid)).BeginInit();
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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Routes
            // 
            this.Routes.Controls.Add(this.tabPage2);
            this.Routes.Controls.Add(this.tabPage1);
            this.Routes.Controls.Add(this.tabPage3);
            this.Routes.Location = new System.Drawing.Point(-1, 28);
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
            this.groupBox6.Location = new System.Drawing.Point(697, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(513, 166);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Filter";
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
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1216, 494);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Customers";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            // waysTabControl
            // 
            this.waysTabControl.Location = new System.Drawing.Point(8, 19);
            this.waysTabControl.Name = "waysTabControl";
            this.waysTabControl.SelectedIndex = 0;
            this.waysTabControl.Size = new System.Drawing.Size(459, 152);
            this.waysTabControl.TabIndex = 0;
            this.waysTabControl.TabIndexChanged += new System.EventHandler(this.waysTabControl_TabIndexChanged);
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
            this.Text = "Form1";
            this.Routes.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGrid)).EndInit();
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
    }
}

