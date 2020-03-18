namespace SomerenUI {
    partial class SalesView {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.ColumnHeader columnHeader2;
            this.label1 = new System.Windows.Forms.Label();
            this.startDateCalendar = new System.Windows.Forms.MonthCalendar();
            this.viewSalesBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.salesList = new System.Windows.Forms.ListView();
            this.endDateCalendar = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Sales";
            // 
            // startDateCalendar
            // 
            this.startDateCalendar.Location = new System.Drawing.Point(8, 72);
            this.startDateCalendar.MaxSelectionCount = 1;
            this.startDateCalendar.Name = "startDateCalendar";
            this.startDateCalendar.TabIndex = 13;
            // 
            // viewSalesBtn
            // 
            this.viewSalesBtn.Location = new System.Drawing.Point(9, 429);
            this.viewSalesBtn.Name = "viewSalesBtn";
            this.viewSalesBtn.Size = new System.Drawing.Size(226, 23);
            this.viewSalesBtn.TabIndex = 14;
            this.viewSalesBtn.Text = "View Sales";
            this.viewSalesBtn.UseVisualStyleBackColor = true;
            this.viewSalesBtn.Click += new System.EventHandler(this.viewSalesBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Start Date";
            // 
            // salesList
            // 
            this.salesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.salesList.HideSelection = false;
            this.salesList.Location = new System.Drawing.Point(247, 72);
            this.salesList.Name = "salesList";
            this.salesList.Size = new System.Drawing.Size(688, 380);
            this.salesList.TabIndex = 17;
            this.salesList.UseCompatibleStateImageBehavior = false;
            this.salesList.View = System.Windows.Forms.View.Details;
            // 
            // endDateCalendar
            // 
            this.endDateCalendar.Location = new System.Drawing.Point(8, 265);
            this.endDateCalendar.MaxSelectionCount = 1;
            this.endDateCalendar.Name = "endDateCalendar";
            this.endDateCalendar.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "End Date";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sale ID";
            this.columnHeader1.Width = 72;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Drink Name";
            columnHeader2.Width = 93;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Quantity";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Revenue";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Total Revenue";
            this.columnHeader5.Width = 95;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Alchoholic";
            this.columnHeader6.Width = 88;
            // 
            // SalesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.salesList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.viewSalesBtn);
            this.Controls.Add(this.startDateCalendar);
            this.Controls.Add(this.endDateCalendar);
            this.Controls.Add(this.label1);
            this.Name = "SalesView";
            this.Size = new System.Drawing.Size(938, 455);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar startDateCalendar;
        private System.Windows.Forms.Button viewSalesBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView salesList;
        private System.Windows.Forms.MonthCalendar endDateCalendar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}
