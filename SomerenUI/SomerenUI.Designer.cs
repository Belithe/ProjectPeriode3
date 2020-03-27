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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lecturersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activitiesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.weekOverviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teachersSchedulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsOverviewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salesOverviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_Dashboard = new System.Windows.Forms.Panel();
            this.lbl_Dashboard = new System.Windows.Forms.Label();
            this.img_Dashboard = new System.Windows.Forms.PictureBox();
            this.mainViewport = new System.Windows.Forms.Panel();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateTaxesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.pnl_Dashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Dashboard)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.lecturersToolStripMenuItem,
            this.activitiesToolStripMenuItem,
            this.roomsToolStripMenuItem,
            this.salesToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(962, 24);
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
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.dashboardToolStripMenuItem.Text = "Application";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // dashboardToolStripMenuItem1
            // 
            this.dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            this.dashboardToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.dashboardToolStripMenuItem1.Text = "Dashboard";
            this.dashboardToolStripMenuItem1.Click += new System.EventHandler(this.dashboardToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.studentsToolStripMenuItem.Text = "Students";
            this.studentsToolStripMenuItem.Click += new System.EventHandler(this.studentsToolStripMenuItem_Click);
            // 
            // lecturersToolStripMenuItem
            // 
            this.lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            this.lecturersToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.lecturersToolStripMenuItem.Text = "Lecturers";
            this.lecturersToolStripMenuItem.Click += new System.EventHandler(this.LecturersToolStripMenuItem_Click);
            // 
            // activitiesToolStripMenuItem
            // 
            this.activitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activitiesToolStripMenuItem1,
            this.weekOverviewToolStripMenuItem,
            this.teachersSchedulesToolStripMenuItem});
            this.activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            this.activitiesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.activitiesToolStripMenuItem.Text = "Activities";
            // 
            // activitiesToolStripMenuItem1
            // 
            this.activitiesToolStripMenuItem1.Name = "activitiesToolStripMenuItem1";
            this.activitiesToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
            this.activitiesToolStripMenuItem1.Text = "Activities";
            this.activitiesToolStripMenuItem1.Click += new System.EventHandler(this.ActivitiesToolStripMenuItem1_Click);
            // 
            // weekOverviewToolStripMenuItem
            // 
            this.weekOverviewToolStripMenuItem.Name = "weekOverviewToolStripMenuItem";
            this.weekOverviewToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.weekOverviewToolStripMenuItem.Text = "Week Overview";
            this.weekOverviewToolStripMenuItem.Click += new System.EventHandler(this.weekOverviewToolStripMenuItem_Click);
            // 
            // teachersSchedulesToolStripMenuItem
            // 
            this.teachersSchedulesToolStripMenuItem.Name = "teachersSchedulesToolStripMenuItem";
            this.teachersSchedulesToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.teachersSchedulesToolStripMenuItem.Text = "Teachers Schedules";
            this.teachersSchedulesToolStripMenuItem.Click += new System.EventHandler(this.teachersSchedulesToolStripMenuItem_Click);
            // 
            // roomsToolStripMenuItem
            // 
            this.roomsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.roomsListToolStripMenuItem,
            this.roomsOverviewToolStripMenuItem1});
            this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            this.roomsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.roomsToolStripMenuItem.Text = "Rooms";
            // 
            // roomsListToolStripMenuItem
            // 
            this.roomsListToolStripMenuItem.Name = "roomsListToolStripMenuItem";
            this.roomsListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.roomsListToolStripMenuItem.Text = "Rooms List";
            this.roomsListToolStripMenuItem.Click += new System.EventHandler(this.roomsListToolStripMenuItem_Click);
            // 
            // roomsOverviewToolStripMenuItem1
            // 
            this.roomsOverviewToolStripMenuItem1.Name = "roomsOverviewToolStripMenuItem1";
            this.roomsOverviewToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.roomsOverviewToolStripMenuItem1.Text = "Rooms Overview";
            this.roomsOverviewToolStripMenuItem1.Click += new System.EventHandler(this.roomsOverviewToolStripMenuItem1_Click);
            // 
            // salesToolStripMenuItem1
            // 
            this.salesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderToolStripMenuItem,
            this.salesOverviewToolStripMenuItem,
            this.calculateTaxesToolStripMenuItem});
            this.salesToolStripMenuItem1.Name = "salesToolStripMenuItem1";
            this.salesToolStripMenuItem1.Size = new System.Drawing.Size(45, 20);
            this.salesToolStripMenuItem1.Text = "Sales";
            // 
            // salesOverviewToolStripMenuItem
            // 
            this.salesOverviewToolStripMenuItem.Name = "salesOverviewToolStripMenuItem";
            this.salesOverviewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salesOverviewToolStripMenuItem.Text = "Sales Overview";
            this.salesOverviewToolStripMenuItem.Click += new System.EventHandler(this.salesOverviewToolStripMenuItem_Click);
            // 
            // pnl_Dashboard
            // 
            this.pnl_Dashboard.Controls.Add(this.lbl_Dashboard);
            this.pnl_Dashboard.Controls.Add(this.img_Dashboard);
            this.pnl_Dashboard.Location = new System.Drawing.Point(12, 28);
            this.pnl_Dashboard.Name = "pnl_Dashboard";
            this.pnl_Dashboard.Size = new System.Drawing.Size(938, 466);
            this.pnl_Dashboard.TabIndex = 2;
            // 
            // lbl_Dashboard
            // 
            this.lbl_Dashboard.AutoSize = true;
            this.lbl_Dashboard.Location = new System.Drawing.Point(14, 13);
            this.lbl_Dashboard.Name = "lbl_Dashboard";
            this.lbl_Dashboard.Size = new System.Drawing.Size(185, 13);
            this.lbl_Dashboard.TabIndex = 1;
            this.lbl_Dashboard.Text = "Welcome to the Someren Application!";
            // 
            // img_Dashboard
            // 
            this.img_Dashboard.Location = new System.Drawing.Point(627, 0);
            this.img_Dashboard.Name = "img_Dashboard";
            this.img_Dashboard.Size = new System.Drawing.Size(310, 270);
            this.img_Dashboard.TabIndex = 0;
            this.img_Dashboard.TabStop = false;
            this.img_Dashboard.Click += new System.EventHandler(this.img_Dashboard_Click);
            // 
            // mainViewport
            // 
            this.mainViewport.Location = new System.Drawing.Point(0, 13);
            this.mainViewport.Name = "mainViewport";
            this.mainViewport.Size = new System.Drawing.Size(938, 455);
            this.mainViewport.TabIndex = 5;
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.orderToolStripMenuItem.Text = "Order";
            this.orderToolStripMenuItem.Click += new System.EventHandler(this.orderToolStripMenuItem_Click);
            // 
            // calculateTaxesToolStripMenuItem
            // 
            this.calculateTaxesToolStripMenuItem.Name = "calculateTaxesToolStripMenuItem";
            this.calculateTaxesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.calculateTaxesToolStripMenuItem.Text = "Calculate Taxes";
            this.calculateTaxesToolStripMenuItem.Click += new System.EventHandler(this.calculateTaxesToolStripMenuItem_Click);
            // 
            // SomerenUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 507);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnl_Dashboard);
            this.Controls.Add(this.mainViewport);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SomerenUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "SomerenApp";
            this.Load += new System.EventHandler(this.SomerenUI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnl_Dashboard.ResumeLayout(false);
            this.pnl_Dashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Dashboard)).EndInit();
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
        private System.Windows.Forms.Panel mainViewport;
        private System.Windows.Forms.ToolStripMenuItem teachersSchedulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem weekOverviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsOverviewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salesOverviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateTaxesToolStripMenuItem;
    }
}

