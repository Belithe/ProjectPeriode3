﻿namespace SomerenUI
{
    partial class SomerenUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SomerenUI));
            this.img_Dashboard = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lecturersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsOverviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kassaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_Dashboard = new System.Windows.Forms.Panel();
            this.lbl_Dashboard = new System.Windows.Forms.Label();
            this.pnl_Students = new System.Windows.Forms.Panel();
            this.pnl_Rooms = new System.Windows.Forms.Panel();
            this.listViewRooms = new System.Windows.Forms.ListView();
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Capacity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_Rooms = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Students = new System.Windows.Forms.Label();
            this.listViewStudents = new System.Windows.Forms.ListView();
            this.studentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentDOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnl_RoomsOverview = new System.Windows.Forms.Panel();
            this.flowLayoutRoomsOverview = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_Lecturers = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewTeachers = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.img_Dashboard)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.pnl_Dashboard.SuspendLayout();
            this.pnl_Students.SuspendLayout();
            this.pnl_Rooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_RoomsOverview.SuspendLayout();
            this.flowLayoutRoomsOverview.SuspendLayout();
            this.pnl_Lecturers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // img_Dashboard
            // 
            this.img_Dashboard.Location = new System.Drawing.Point(940, 0);
            this.img_Dashboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.img_Dashboard.Name = "img_Dashboard";
            this.img_Dashboard.Size = new System.Drawing.Size(466, 415);
            this.img_Dashboard.TabIndex = 0;
            this.img_Dashboard.TabStop = false;
            this.img_Dashboard.Click += new System.EventHandler(this.img_Dashboard_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.lecturersToolStripMenuItem,
            this.activitiesToolStripMenuItem,
            this.roomsToolStripMenuItem,
            this.roomsOverviewToolStripMenuItem,
            this.kassaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1443, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem1,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(118, 29);
            this.dashboardToolStripMenuItem.Text = "Application";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // dashboardToolStripMenuItem1
            // 
            this.dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            this.dashboardToolStripMenuItem1.Size = new System.Drawing.Size(202, 34);
            this.dashboardToolStripMenuItem1.Text = "Dashboard";
            this.dashboardToolStripMenuItem1.Click += new System.EventHandler(this.dashboardToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(199, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(202, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(97, 29);
            this.studentsToolStripMenuItem.Text = "Students";
            this.studentsToolStripMenuItem.Click += new System.EventHandler(this.studentsToolStripMenuItem_Click);
            // 
            // lecturersToolStripMenuItem
            // 
            this.lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            this.lecturersToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.lecturersToolStripMenuItem.Text = "Lecturers";
            this.lecturersToolStripMenuItem.Click += new System.EventHandler(this.LecturersToolStripMenuItem_Click);
            // 
            // activitiesToolStripMenuItem
            // 
            this.activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            this.activitiesToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.activitiesToolStripMenuItem.Text = "Activities";
            // 
            // roomsToolStripMenuItem
            // 
            this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            this.roomsToolStripMenuItem.Size = new System.Drawing.Size(84, 29);
            this.roomsToolStripMenuItem.Text = "Rooms";
            this.roomsToolStripMenuItem.Click += new System.EventHandler(this.roomsToolStripMenuItem_Click);
            // 
            // roomsOverviewToolStripMenuItem
            // 
            this.roomsOverviewToolStripMenuItem.Name = "roomsOverviewToolStripMenuItem";
            this.roomsOverviewToolStripMenuItem.Size = new System.Drawing.Size(162, 29);
            this.roomsOverviewToolStripMenuItem.Text = "Rooms Overview";
            this.roomsOverviewToolStripMenuItem.Click += new System.EventHandler(this.roomsOverviewToolStripMenuItem_Click);
            // 
            // kassaToolStripMenuItem
            // 
            this.kassaToolStripMenuItem.Name = "kassaToolStripMenuItem";
            this.kassaToolStripMenuItem.Size = new System.Drawing.Size(72, 29);
            this.kassaToolStripMenuItem.Text = "Kassa";
            this.kassaToolStripMenuItem.Click += new System.EventHandler(this.KassaToolStripMenuItem_Click);
            // 
            // pnl_Dashboard
            // 
            this.pnl_Dashboard.Controls.Add(this.lbl_Dashboard);
            this.pnl_Dashboard.Controls.Add(this.img_Dashboard);
            this.pnl_Dashboard.Location = new System.Drawing.Point(18, 42);
            this.pnl_Dashboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_Dashboard.Name = "pnl_Dashboard";
            this.pnl_Dashboard.Size = new System.Drawing.Size(1407, 717);
            this.pnl_Dashboard.TabIndex = 2;
            // 
            // lbl_Dashboard
            // 
            this.lbl_Dashboard.AutoSize = true;
            this.lbl_Dashboard.Location = new System.Drawing.Point(20, 20);
            this.lbl_Dashboard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Dashboard.Name = "lbl_Dashboard";
            this.lbl_Dashboard.Size = new System.Drawing.Size(275, 20);
            this.lbl_Dashboard.TabIndex = 1;
            this.lbl_Dashboard.Text = "Welcome to the Someren Application!";
            this.lbl_Dashboard.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnl_Students
            // 
            this.pnl_Students.Controls.Add(this.pnl_Rooms);
            this.pnl_Students.Controls.Add(this.pictureBox1);
            this.pnl_Students.Controls.Add(this.lbl_Students);
            this.pnl_Students.Controls.Add(this.listViewStudents);
            this.pnl_Students.Location = new System.Drawing.Point(18, 37);
            this.pnl_Students.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_Students.Name = "pnl_Students";
            this.pnl_Students.Size = new System.Drawing.Size(1407, 717);
            this.pnl_Students.TabIndex = 4;
            // 
            // pnl_Rooms
            // 
            this.pnl_Rooms.Controls.Add(this.listViewRooms);
            this.pnl_Rooms.Controls.Add(this.pictureBox2);
            this.pnl_Rooms.Controls.Add(this.lbl_Rooms);
            this.pnl_Rooms.Location = new System.Drawing.Point(0, 0);
            this.pnl_Rooms.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_Rooms.Name = "pnl_Rooms";
            this.pnl_Rooms.Size = new System.Drawing.Size(1407, 717);
            this.pnl_Rooms.TabIndex = 6;
            // 
            // listViewRooms
            // 
            this.listViewRooms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Number,
            this.Type,
            this.Capacity});
            this.listViewRooms.HideSelection = false;
            this.listViewRooms.Location = new System.Drawing.Point(22, 65);
            this.listViewRooms.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewRooms.Name = "listViewRooms";
            this.listViewRooms.Size = new System.Drawing.Size(1147, 470);
            this.listViewRooms.TabIndex = 6;
            this.listViewRooms.UseCompatibleStateImageBehavior = false;
            this.listViewRooms.View = System.Windows.Forms.View.Details;
            this.listViewRooms.SelectedIndexChanged += new System.EventHandler(this.listViewRooms_SelectedIndexChanged);
            // 
            // Number
            // 
            this.Number.Text = "Number";
            // 
            // Type
            // 
            this.Type.Text = "Type";
            // 
            // Capacity
            // 
            this.Capacity.Text = "Capacity";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SomerenUI.Properties.Resources.someren;
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(1208, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(195, 189);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_Rooms
            // 
            this.lbl_Rooms.AutoSize = true;
            this.lbl_Rooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rooms.Location = new System.Drawing.Point(15, 15);
            this.lbl_Rooms.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Rooms.Name = "lbl_Rooms";
            this.lbl_Rooms.Size = new System.Drawing.Size(125, 39);
            this.lbl_Rooms.TabIndex = 3;
            this.lbl_Rooms.Text = "Rooms";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SomerenUI.Properties.Resources.someren;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(1208, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 189);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Students
            // 
            this.lbl_Students.AutoSize = true;
            this.lbl_Students.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Students.Location = new System.Drawing.Point(15, 15);
            this.lbl_Students.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Students.Name = "lbl_Students";
            this.lbl_Students.Size = new System.Drawing.Size(151, 39);
            this.lbl_Students.TabIndex = 3;
            this.lbl_Students.Text = "Students";
            // 
            // listViewStudents
            // 
            this.listViewStudents.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.listViewStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.studentID,
            this.studentName,
            this.studentDOB});
            this.listViewStudents.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewStudents.HideSelection = false;
            this.listViewStudents.Location = new System.Drawing.Point(24, 65);
            this.listViewStudents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewStudents.Name = "listViewStudents";
            this.listViewStudents.Size = new System.Drawing.Size(1147, 470);
            this.listViewStudents.TabIndex = 5;
            this.listViewStudents.UseCompatibleStateImageBehavior = false;
            // 
            // studentID
            // 
            this.studentID.Text = "ID";
            // 
            // studentName
            // 
            this.studentName.Text = "Name";
            // 
            // studentDOB
            // 
            this.studentDOB.Text = "Date of Birth";
            // 
            // pnl_RoomsOverview
            // 
            this.pnl_RoomsOverview.Controls.Add(this.flowLayoutRoomsOverview);
            this.pnl_RoomsOverview.Controls.Add(this.pictureBox3);
            this.pnl_RoomsOverview.Controls.Add(this.label1);
            this.pnl_RoomsOverview.Location = new System.Drawing.Point(18, 37);
            this.pnl_RoomsOverview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_RoomsOverview.Name = "pnl_RoomsOverview";
            this.pnl_RoomsOverview.Size = new System.Drawing.Size(1407, 717);
            this.pnl_RoomsOverview.TabIndex = 7;
            // 
            // flowLayoutRoomsOverview
            // 
            this.flowLayoutRoomsOverview.Controls.Add(this.pnl_Lecturers);
            this.flowLayoutRoomsOverview.Location = new System.Drawing.Point(24, 65);
            this.flowLayoutRoomsOverview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutRoomsOverview.Name = "flowLayoutRoomsOverview";
            this.flowLayoutRoomsOverview.Size = new System.Drawing.Size(1174, 648);
            this.flowLayoutRoomsOverview.TabIndex = 4;
            // 
            // pnl_Lecturers
            // 
            this.pnl_Lecturers.Controls.Add(this.listViewTeachers);
            this.pnl_Lecturers.Location = new System.Drawing.Point(3, 3);
            this.pnl_Lecturers.Name = "pnl_Lecturers";
            this.pnl_Lecturers.Size = new System.Drawing.Size(1144, 413);
            this.pnl_Lecturers.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SomerenUI.Properties.Resources.someren;
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(1208, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(195, 189);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rooms Overview";
            // 
            // listViewTeachers
            // 
            this.listViewTeachers.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.listViewTeachers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewTeachers.HideSelection = false;
            this.listViewTeachers.Location = new System.Drawing.Point(24, 65);
            this.listViewTeachers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewTeachers.Name = "listViewTeachers";
            this.listViewTeachers.Size = new System.Drawing.Size(1147, 470);
            this.listViewTeachers.TabIndex = 5;
            this.listViewTeachers.UseCompatibleStateImageBehavior = false;
            // 
            // SomerenUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 780);
            this.Controls.Add(this.pnl_RoomsOverview);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnl_Students);
            this.Controls.Add(this.pnl_Dashboard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SomerenUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "SomerenApp";
            this.Load += new System.EventHandler(this.SomerenUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_Dashboard)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnl_Dashboard.ResumeLayout(false);
            this.pnl_Dashboard.PerformLayout();
            this.pnl_Students.ResumeLayout(false);
            this.pnl_Students.PerformLayout();
            this.pnl_Rooms.ResumeLayout(false);
            this.pnl_Rooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_RoomsOverview.ResumeLayout(false);
            this.pnl_RoomsOverview.PerformLayout();
            this.flowLayoutRoomsOverview.ResumeLayout(false);
            this.pnl_Lecturers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img_Dashboard;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_Dashboard;
        private System.Windows.Forms.Label lbl_Dashboard;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_Students;
        private System.Windows.Forms.Label lbl_Students;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnl_Rooms;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_Rooms;
        private System.Windows.Forms.ListView listViewRooms;
        private System.Windows.Forms.ColumnHeader Number;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Capacity;
        private System.Windows.Forms.Panel pnl_RoomsOverview;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem roomsOverviewToolStripMenuItem;
        private System.Windows.Forms.ListView listViewStudents;
        private System.Windows.Forms.ColumnHeader studentID;
        private System.Windows.Forms.ColumnHeader studentName;
        private System.Windows.Forms.ColumnHeader studentDOB;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutRoomsOverview;
        private System.Windows.Forms.ToolStripMenuItem kassaToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_Lecturers;
        private System.Windows.Forms.ListView listViewTeachers;
    }
}

