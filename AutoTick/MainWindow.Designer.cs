namespace AutoTick
{
    partial class MainWindow
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Home");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Users");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Location");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Settings");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("About");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menuTree = new System.Windows.Forms.TreeView();
            this.uiTabs = new System.Windows.Forms.TabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.avgPts = new System.Windows.Forms.Label();
            this.totPts = new System.Windows.Forms.Label();
            this.nMeetup = new System.Windows.Forms.Label();
            this.disBt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tickView = new System.Windows.Forms.ListView();
            this.Persons = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Points = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.enableBt = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lMeetup = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.statLB = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Users = new System.Windows.Forms.TabPage();
            this.edPan = new System.Windows.Forms.Panel();
            this.edBt = new System.Windows.Forms.Button();
            this.clPan = new System.Windows.Forms.Button();
            this.saveUsr = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tokeBx = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nameBx = new System.Windows.Forms.TextBox();
            this.delUsr = new System.Windows.Forms.Button();
            this.editUsr = new System.Windows.Forms.Button();
            this.addUsr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.userView = new System.Windows.Forms.ListView();
            this.Member = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Token = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Location = new System.Windows.Forms.TabPage();
            this.updLoc = new System.Windows.Forms.Button();
            this.longBox = new System.Windows.Forms.TextBox();
            this.latBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Settings = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.updSet = new System.Windows.Forms.Button();
            this.tickSnooze = new System.Windows.Forms.TextBox();
            this.gmBox = new System.Windows.Forms.TextBox();
            this.tzId = new System.Windows.Forms.TextBox();
            this.refTail = new System.Windows.Forms.TextBox();
            this.scanTail = new System.Windows.Forms.TextBox();
            this.locTail = new System.Windows.Forms.TextBox();
            this.pAPIbox = new System.Windows.Forms.TextBox();
            this.uaBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.About = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.verLB = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.botWorker = new System.ComponentModel.BackgroundWorker();
            this.scanInt = new System.Windows.Forms.Timer(this.components);
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.locMap1 = new AutoTick.LocMap();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.uiTabs.SuspendLayout();
            this.Home.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Users.SuspendLayout();
            this.edPan.SuspendLayout();
            this.Location.SuspendLayout();
            this.Settings.SuspendLayout();
            this.About.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.menuTree);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.uiTabs);
            this.splitContainer1.Size = new System.Drawing.Size(715, 406);
            this.splitContainer1.SplitterDistance = 183;
            this.splitContainer1.TabIndex = 0;
            // 
            // menuTree
            // 
            this.menuTree.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menuTree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.menuTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuTree.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuTree.FullRowSelect = true;
            this.menuTree.ItemHeight = 35;
            this.menuTree.Location = new System.Drawing.Point(0, 0);
            this.menuTree.Name = "menuTree";
            treeNode1.Name = "Home";
            treeNode1.Text = "Home";
            treeNode2.Name = "Users";
            treeNode2.Text = "Users";
            treeNode3.Name = "Location";
            treeNode3.Text = "Location";
            treeNode4.Name = "Settings";
            treeNode4.Text = "Settings";
            treeNode5.Name = "About";
            treeNode5.Text = "About";
            this.menuTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            this.menuTree.Scrollable = false;
            this.menuTree.ShowLines = false;
            this.menuTree.ShowRootLines = false;
            this.menuTree.Size = new System.Drawing.Size(183, 406);
            this.menuTree.TabIndex = 0;
            this.menuTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.menuTree_AfterSelect);
            // 
            // uiTabs
            // 
            this.uiTabs.Controls.Add(this.Home);
            this.uiTabs.Controls.Add(this.Users);
            this.uiTabs.Controls.Add(this.Location);
            this.uiTabs.Controls.Add(this.Settings);
            this.uiTabs.Controls.Add(this.About);
            this.uiTabs.Location = new System.Drawing.Point(-4, -21);
            this.uiTabs.Name = "uiTabs";
            this.uiTabs.SelectedIndex = 0;
            this.uiTabs.Size = new System.Drawing.Size(542, 435);
            this.uiTabs.TabIndex = 0;
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.AliceBlue;
            this.Home.Controls.Add(this.avgPts);
            this.Home.Controls.Add(this.totPts);
            this.Home.Controls.Add(this.nMeetup);
            this.Home.Controls.Add(this.disBt);
            this.Home.Controls.Add(this.groupBox1);
            this.Home.Controls.Add(this.enableBt);
            this.Home.Controls.Add(this.label7);
            this.Home.Controls.Add(this.label6);
            this.Home.Controls.Add(this.label5);
            this.Home.Controls.Add(this.lMeetup);
            this.Home.Controls.Add(this.label4);
            this.Home.Controls.Add(this.statLB);
            this.Home.Controls.Add(this.label2);
            this.Home.Location = new System.Drawing.Point(4, 22);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(3);
            this.Home.Size = new System.Drawing.Size(534, 409);
            this.Home.TabIndex = 1;
            this.Home.Text = "Home";
            // 
            // avgPts
            // 
            this.avgPts.AutoSize = true;
            this.avgPts.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgPts.Location = new System.Drawing.Point(219, 128);
            this.avgPts.Name = "avgPts";
            this.avgPts.Size = new System.Drawing.Size(44, 30);
            this.avgPts.TabIndex = 13;
            this.avgPts.Text = "n/a";
            // 
            // totPts
            // 
            this.totPts.AutoSize = true;
            this.totPts.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totPts.Location = new System.Drawing.Point(219, 98);
            this.totPts.Name = "totPts";
            this.totPts.Size = new System.Drawing.Size(44, 30);
            this.totPts.TabIndex = 12;
            this.totPts.Text = "n/a";
            // 
            // nMeetup
            // 
            this.nMeetup.AutoSize = true;
            this.nMeetup.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nMeetup.Location = new System.Drawing.Point(219, 68);
            this.nMeetup.Name = "nMeetup";
            this.nMeetup.Size = new System.Drawing.Size(44, 30);
            this.nMeetup.TabIndex = 11;
            this.nMeetup.Text = "n/a";
            // 
            // disBt
            // 
            this.disBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disBt.Location = new System.Drawing.Point(387, 350);
            this.disBt.Name = "disBt";
            this.disBt.Size = new System.Drawing.Size(124, 43);
            this.disBt.TabIndex = 10;
            this.disBt.Text = "Disable";
            this.disBt.UseVisualStyleBackColor = true;
            this.disBt.Click += new System.EventHandler(this.disBt_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tickView);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 173);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ticker";
            // 
            // tickView
            // 
            this.tickView.BackColor = System.Drawing.Color.AliceBlue;
            this.tickView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Persons,
            this.Points});
            this.tickView.Location = new System.Drawing.Point(6, 22);
            this.tickView.Name = "tickView";
            this.tickView.Size = new System.Drawing.Size(493, 143);
            this.tickView.TabIndex = 0;
            this.tickView.UseCompatibleStateImageBehavior = false;
            this.tickView.View = System.Windows.Forms.View.Details;
            // 
            // Persons
            // 
            this.Persons.Text = "Persons";
            this.Persons.Width = 200;
            // 
            // Points
            // 
            this.Points.Text = "Points";
            // 
            // enableBt
            // 
            this.enableBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enableBt.Location = new System.Drawing.Point(6, 350);
            this.enableBt.Name = "enableBt";
            this.enableBt.Size = new System.Drawing.Size(124, 43);
            this.enableBt.TabIndex = 9;
            this.enableBt.Text = "Enable";
            this.enableBt.UseVisualStyleBackColor = true;
            this.enableBt.Click += new System.EventHandler(this.enableBt_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 30);
            this.label7.TabIndex = 7;
            this.label7.Text = "Average Payout:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 30);
            this.label6.TabIndex = 6;
            this.label6.Text = "Total Points Earned:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 30);
            this.label5.TabIndex = 5;
            this.label5.Text = "Next Meetup:";
            // 
            // lMeetup
            // 
            this.lMeetup.AutoSize = true;
            this.lMeetup.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMeetup.Location = new System.Drawing.Point(219, 38);
            this.lMeetup.Name = "lMeetup";
            this.lMeetup.Size = new System.Drawing.Size(44, 30);
            this.lMeetup.TabIndex = 4;
            this.lMeetup.Text = "n/a";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Last Meetup:";
            // 
            // statLB
            // 
            this.statLB.AutoSize = true;
            this.statLB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statLB.ForeColor = System.Drawing.Color.IndianRed;
            this.statLB.Location = new System.Drawing.Point(219, 8);
            this.statLB.Name = "statLB";
            this.statLB.Size = new System.Drawing.Size(93, 30);
            this.statLB.TabIndex = 2;
            this.statLB.Text = "Disabled";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Status:";
            // 
            // Users
            // 
            this.Users.BackColor = System.Drawing.Color.AliceBlue;
            this.Users.Controls.Add(this.edPan);
            this.Users.Controls.Add(this.delUsr);
            this.Users.Controls.Add(this.editUsr);
            this.Users.Controls.Add(this.addUsr);
            this.Users.Controls.Add(this.label1);
            this.Users.Controls.Add(this.textBox1);
            this.Users.Controls.Add(this.userView);
            this.Users.Location = new System.Drawing.Point(4, 22);
            this.Users.Name = "Users";
            this.Users.Padding = new System.Windows.Forms.Padding(3);
            this.Users.Size = new System.Drawing.Size(534, 409);
            this.Users.TabIndex = 2;
            this.Users.Text = "Users";
            // 
            // edPan
            // 
            this.edPan.BackColor = System.Drawing.Color.Thistle;
            this.edPan.Controls.Add(this.edBt);
            this.edPan.Controls.Add(this.clPan);
            this.edPan.Controls.Add(this.saveUsr);
            this.edPan.Controls.Add(this.label9);
            this.edPan.Controls.Add(this.tokeBx);
            this.edPan.Controls.Add(this.label8);
            this.edPan.Controls.Add(this.nameBx);
            this.edPan.Location = new System.Drawing.Point(6, 281);
            this.edPan.Name = "edPan";
            this.edPan.Size = new System.Drawing.Size(506, 63);
            this.edPan.TabIndex = 8;
            this.edPan.Visible = false;
            // 
            // edBt
            // 
            this.edBt.Location = new System.Drawing.Point(426, 10);
            this.edBt.Name = "edBt";
            this.edBt.Size = new System.Drawing.Size(75, 23);
            this.edBt.TabIndex = 15;
            this.edBt.Text = "Edit";
            this.edBt.UseVisualStyleBackColor = true;
            this.edBt.Visible = false;
            this.edBt.Click += new System.EventHandler(this.edBt_Click);
            // 
            // clPan
            // 
            this.clPan.Location = new System.Drawing.Point(426, 34);
            this.clPan.Name = "clPan";
            this.clPan.Size = new System.Drawing.Size(75, 23);
            this.clPan.TabIndex = 14;
            this.clPan.Text = "Close";
            this.clPan.UseVisualStyleBackColor = true;
            this.clPan.Click += new System.EventHandler(this.clPan_Click);
            // 
            // saveUsr
            // 
            this.saveUsr.Location = new System.Drawing.Point(426, 9);
            this.saveUsr.Name = "saveUsr";
            this.saveUsr.Size = new System.Drawing.Size(75, 23);
            this.saveUsr.TabIndex = 13;
            this.saveUsr.Text = "Save";
            this.saveUsr.UseVisualStyleBackColor = true;
            this.saveUsr.Visible = false;
            this.saveUsr.Click += new System.EventHandler(this.saveUsr_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Token:";
            // 
            // tokeBx
            // 
            this.tokeBx.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tokeBx.Location = new System.Drawing.Point(98, 35);
            this.tokeBx.Name = "tokeBx";
            this.tokeBx.Size = new System.Drawing.Size(284, 22);
            this.tokeBx.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Member Name:";
            // 
            // nameBx
            // 
            this.nameBx.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBx.Location = new System.Drawing.Point(98, 7);
            this.nameBx.Name = "nameBx";
            this.nameBx.Size = new System.Drawing.Size(134, 22);
            this.nameBx.TabIndex = 9;
            // 
            // delUsr
            // 
            this.delUsr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delUsr.Location = new System.Drawing.Point(396, 350);
            this.delUsr.Name = "delUsr";
            this.delUsr.Size = new System.Drawing.Size(115, 43);
            this.delUsr.TabIndex = 6;
            this.delUsr.Text = "Delete";
            this.delUsr.UseVisualStyleBackColor = true;
            this.delUsr.Click += new System.EventHandler(this.delUsr_Click);
            // 
            // editUsr
            // 
            this.editUsr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editUsr.Location = new System.Drawing.Point(127, 350);
            this.editUsr.Name = "editUsr";
            this.editUsr.Size = new System.Drawing.Size(263, 43);
            this.editUsr.TabIndex = 5;
            this.editUsr.Text = "Edit";
            this.editUsr.UseVisualStyleBackColor = true;
            this.editUsr.Click += new System.EventHandler(this.editUsr_Click);
            // 
            // addUsr
            // 
            this.addUsr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUsr.Location = new System.Drawing.Point(6, 350);
            this.addUsr.Name = "addUsr";
            this.addUsr.Size = new System.Drawing.Size(115, 43);
            this.addUsr.TabIndex = 4;
            this.addUsr.Text = "Add";
            this.addUsr.UseVisualStyleBackColor = true;
            this.addUsr.Click += new System.EventHandler(this.addUsr_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(72, 299);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(437, 29);
            this.textBox1.TabIndex = 2;
            // 
            // userView
            // 
            this.userView.BackColor = System.Drawing.Color.AliceBlue;
            this.userView.CheckBoxes = true;
            this.userView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Member,
            this.Token});
            this.userView.Location = new System.Drawing.Point(0, 0);
            this.userView.MultiSelect = false;
            this.userView.Name = "userView";
            this.userView.Size = new System.Drawing.Size(518, 275);
            this.userView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.userView.TabIndex = 1;
            this.userView.UseCompatibleStateImageBehavior = false;
            this.userView.View = System.Windows.Forms.View.Details;
            // 
            // Member
            // 
            this.Member.Text = "Member";
            this.Member.Width = 180;
            // 
            // Token
            // 
            this.Token.Text = "Token";
            this.Token.Width = 325;
            // 
            // Location
            // 
            this.Location.BackColor = System.Drawing.Color.AliceBlue;
            this.Location.Controls.Add(this.updLoc);
            this.Location.Controls.Add(this.longBox);
            this.Location.Controls.Add(this.latBox);
            this.Location.Controls.Add(this.label3);
            this.Location.Controls.Add(this.label10);
            this.Location.Controls.Add(this.elementHost1);
            this.Location.Location = new System.Drawing.Point(4, 22);
            this.Location.Name = "Location";
            this.Location.Padding = new System.Windows.Forms.Padding(3);
            this.Location.Size = new System.Drawing.Size(534, 409);
            this.Location.TabIndex = 3;
            this.Location.Text = "Location";
            // 
            // updLoc
            // 
            this.updLoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updLoc.Location = new System.Drawing.Point(365, 319);
            this.updLoc.Name = "updLoc";
            this.updLoc.Size = new System.Drawing.Size(133, 44);
            this.updLoc.TabIndex = 8;
            this.updLoc.Text = "Update";
            this.updLoc.UseVisualStyleBackColor = true;
            this.updLoc.Click += new System.EventHandler(this.updLoc_Click);
            // 
            // longBox
            // 
            this.longBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longBox.Location = new System.Drawing.Point(136, 349);
            this.longBox.MaxLength = 9;
            this.longBox.Name = "longBox";
            this.longBox.Size = new System.Drawing.Size(153, 35);
            this.longBox.TabIndex = 7;
            this.longBox.WordWrap = false;
            // 
            // latBox
            // 
            this.latBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latBox.Location = new System.Drawing.Point(136, 297);
            this.latBox.MaxLength = 9;
            this.latBox.Name = "latBox";
            this.latBox.Size = new System.Drawing.Size(153, 35);
            this.latBox.TabIndex = 6;
            this.latBox.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Longitude:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 300);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 30);
            this.label10.TabIndex = 4;
            this.label10.Text = "Latitude:";
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.AliceBlue;
            this.Settings.Controls.Add(this.label19);
            this.Settings.Controls.Add(this.updSet);
            this.Settings.Controls.Add(this.tickSnooze);
            this.Settings.Controls.Add(this.gmBox);
            this.Settings.Controls.Add(this.tzId);
            this.Settings.Controls.Add(this.refTail);
            this.Settings.Controls.Add(this.scanTail);
            this.Settings.Controls.Add(this.locTail);
            this.Settings.Controls.Add(this.pAPIbox);
            this.Settings.Controls.Add(this.uaBox);
            this.Settings.Controls.Add(this.label18);
            this.Settings.Controls.Add(this.label17);
            this.Settings.Controls.Add(this.label16);
            this.Settings.Controls.Add(this.label15);
            this.Settings.Controls.Add(this.label14);
            this.Settings.Controls.Add(this.label13);
            this.Settings.Controls.Add(this.label12);
            this.Settings.Controls.Add(this.label11);
            this.Settings.Location = new System.Drawing.Point(4, 22);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(3);
            this.Settings.Size = new System.Drawing.Size(534, 409);
            this.Settings.TabIndex = 4;
            this.Settings.Text = "Settings";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(297, 316);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(48, 25);
            this.label19.TabIndex = 17;
            this.label19.Text = "(ms)";
            // 
            // updSet
            // 
            this.updSet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updSet.Location = new System.Drawing.Point(383, 359);
            this.updSet.Name = "updSet";
            this.updSet.Size = new System.Drawing.Size(133, 34);
            this.updSet.TabIndex = 16;
            this.updSet.Text = "Update";
            this.updSet.UseVisualStyleBackColor = true;
            this.updSet.Click += new System.EventHandler(this.updSet_Click);
            // 
            // tickSnooze
            // 
            this.tickSnooze.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tickSnooze.Location = new System.Drawing.Point(219, 316);
            this.tickSnooze.Name = "tickSnooze";
            this.tickSnooze.Size = new System.Drawing.Size(72, 29);
            this.tickSnooze.TabIndex = 15;
            // 
            // gmBox
            // 
            this.gmBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gmBox.Location = new System.Drawing.Point(219, 272);
            this.gmBox.Name = "gmBox";
            this.gmBox.Size = new System.Drawing.Size(297, 29);
            this.gmBox.TabIndex = 14;
            // 
            // tzId
            // 
            this.tzId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tzId.Location = new System.Drawing.Point(219, 228);
            this.tzId.Name = "tzId";
            this.tzId.Size = new System.Drawing.Size(297, 29);
            this.tzId.TabIndex = 13;
            // 
            // refTail
            // 
            this.refTail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refTail.Location = new System.Drawing.Point(219, 184);
            this.refTail.Name = "refTail";
            this.refTail.Size = new System.Drawing.Size(297, 29);
            this.refTail.TabIndex = 12;
            // 
            // scanTail
            // 
            this.scanTail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scanTail.Location = new System.Drawing.Point(219, 140);
            this.scanTail.Name = "scanTail";
            this.scanTail.Size = new System.Drawing.Size(297, 29);
            this.scanTail.TabIndex = 11;
            // 
            // locTail
            // 
            this.locTail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locTail.Location = new System.Drawing.Point(219, 96);
            this.locTail.Name = "locTail";
            this.locTail.Size = new System.Drawing.Size(297, 29);
            this.locTail.TabIndex = 10;
            // 
            // pAPIbox
            // 
            this.pAPIbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pAPIbox.Location = new System.Drawing.Point(219, 52);
            this.pAPIbox.Name = "pAPIbox";
            this.pAPIbox.Size = new System.Drawing.Size(297, 29);
            this.pAPIbox.TabIndex = 9;
            // 
            // uaBox
            // 
            this.uaBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uaBox.Location = new System.Drawing.Point(219, 8);
            this.uaBox.Name = "uaBox";
            this.uaBox.Size = new System.Drawing.Size(297, 29);
            this.uaBox.TabIndex = 8;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(8, 316);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(148, 25);
            this.label18.TabIndex = 7;
            this.label18.Text = "Meetup Snooze:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(8, 272);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(111, 25);
            this.label17.TabIndex = 6;
            this.label17.Text = "GMT Offset:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 228);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(121, 25);
            this.label16.TabIndex = 5;
            this.label16.Text = "Timezone ID:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 184);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 25);
            this.label15.TabIndex = 4;
            this.label15.Text = "Refresh Tail:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 140);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 25);
            this.label14.TabIndex = 3;
            this.label14.Text = "Scan Tail:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 25);
            this.label13.TabIndex = 2;
            this.label13.Text = "Location Tail:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(186, 25);
            this.label12.TabIndex = 1;
            this.label12.Text = "PhewTick API Server:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "User Agent:";
            // 
            // About
            // 
            this.About.Controls.Add(this.linkLabel1);
            this.About.Controls.Add(this.label25);
            this.About.Controls.Add(this.label24);
            this.About.Controls.Add(this.verLB);
            this.About.Controls.Add(this.label23);
            this.About.Controls.Add(this.label22);
            this.About.Controls.Add(this.label21);
            this.About.Controls.Add(this.label20);
            this.About.Controls.Add(this.pictureBox1);
            this.About.ForeColor = System.Drawing.Color.AliceBlue;
            this.About.Location = new System.Drawing.Point(4, 22);
            this.About.Name = "About";
            this.About.Padding = new System.Windows.Forms.Padding(3);
            this.About.Size = new System.Drawing.Size(534, 409);
            this.About.TabIndex = 5;
            this.About.Text = "About";
            this.About.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.MediumSeaGreen;
            this.linkLabel1.Location = new System.Drawing.Point(52, 269);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(128, 21);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Newtonsoft.Json;";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label25.Location = new System.Drawing.Point(6, 269);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(48, 21);
            this.label25.TabIndex = 8;
            this.label25.Text = "using";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label24.Location = new System.Drawing.Point(6, 322);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(463, 26);
            this.label24.TabIndex = 7;
            this.label24.Text = "This program is to be used only for educational purposes. Any for-profit or fradu" +
    "lent use\r\nviolates the end-user license of this sofware.\r\n";
            // 
            // verLB
            // 
            this.verLB.AutoSize = true;
            this.verLB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verLB.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.verLB.Location = new System.Drawing.Point(270, 182);
            this.verLB.Name = "verLB";
            this.verLB.Size = new System.Drawing.Size(28, 30);
            this.verLB.TabIndex = 6;
            this.verLB.Text = "...";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Crimson;
            this.label23.Location = new System.Drawing.Point(187, 182);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(87, 30);
            this.label23.TabIndex = 5;
            this.label23.Text = "Version:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label22.Location = new System.Drawing.Point(6, 358);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(467, 26);
            this.label22.TabIndex = 4;
            this.label22.Text = "PhewTick and/or the QR-code cat are respective copyrights of Parmy Inc. \r\nThere i" +
    "s no affiliation or claim of ownership provided by this program or davidstancula" +
    "bs.\r\n";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label21.Location = new System.Drawing.Point(189, 140);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(52, 17);
            this.label21.TabIndex = 3;
            this.label21.Text = "© 2013";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label20.Location = new System.Drawing.Point(187, 110);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(161, 30);
            this.label20.TabIndex = 2;
            this.label20.Text = "davidstanculabs";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::AutoTick.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(207, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 87);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // botWorker
            // 
            this.botWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.botWorker_DoWork);
            // 
            // scanInt
            // 
            this.scanInt.Enabled = true;
            this.scanInt.Interval = 3600000;
            this.scanInt.Tick += new System.EventHandler(this.scanInt_Tick);
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(-4, -1);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(532, 280);
            this.elementHost1.TabIndex = 0;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.locMap1;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 406);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoTick";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.uiTabs.ResumeLayout(false);
            this.Home.ResumeLayout(false);
            this.Home.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.Users.ResumeLayout(false);
            this.Users.PerformLayout();
            this.edPan.ResumeLayout(false);
            this.edPan.PerformLayout();
            this.Location.ResumeLayout(false);
            this.Location.PerformLayout();
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            this.About.ResumeLayout(false);
            this.About.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView menuTree;
        private System.Windows.Forms.TabControl uiTabs;
        private System.Windows.Forms.TabPage Home;
        private System.Windows.Forms.TabPage Users;
        private System.Windows.Forms.TabPage Location;
        private System.Windows.Forms.TabPage Settings;
        private System.Windows.Forms.TabPage About;
        private System.Windows.Forms.ListView userView;
        private System.Windows.Forms.ColumnHeader Member;
        private System.Windows.Forms.ColumnHeader Token;
        private System.Windows.Forms.Button delUsr;
        private System.Windows.Forms.Button editUsr;
        private System.Windows.Forms.Button addUsr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lMeetup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label statLB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView tickView;
        private System.Windows.Forms.ColumnHeader Persons;
        private System.Windows.Forms.ColumnHeader Points;
        private System.Windows.Forms.Button disBt;
        private System.Windows.Forms.Button enableBt;
        private System.ComponentModel.BackgroundWorker botWorker;
        private System.Windows.Forms.Panel edPan;
        private System.Windows.Forms.Button saveUsr;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tokeBx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nameBx;
        private System.Windows.Forms.Button clPan;
        private System.Windows.Forms.Button edBt;
        private System.Windows.Forms.Timer scanInt;
        private System.Windows.Forms.Label avgPts;
        private System.Windows.Forms.Label totPts;
        private System.Windows.Forms.Label nMeetup;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private LocMap locMap1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox latBox;
        private System.Windows.Forms.TextBox longBox;
        private System.Windows.Forms.Button updLoc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tickSnooze;
        private System.Windows.Forms.TextBox gmBox;
        private System.Windows.Forms.TextBox tzId;
        private System.Windows.Forms.TextBox refTail;
        private System.Windows.Forms.TextBox scanTail;
        private System.Windows.Forms.TextBox pAPIbox;
        private System.Windows.Forms.TextBox uaBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button updSet;
        private System.Windows.Forms.TextBox locTail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label verLB;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

