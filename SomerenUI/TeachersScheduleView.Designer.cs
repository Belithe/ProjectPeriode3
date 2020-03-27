namespace SomerenUI {
    partial class TeachersScheduleView {
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
            this.label1 = new System.Windows.Forms.Label();
            this.teachersComboBox = new System.Windows.Forms.ComboBox();
            this.activitiesListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnChangeCounsellor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Teachers Schedule";
            // 
            // teachersComboBox
            // 
            this.teachersComboBox.FormattingEnabled = true;
            this.teachersComboBox.Location = new System.Drawing.Point(288, 24);
            this.teachersComboBox.Name = "teachersComboBox";
            this.teachersComboBox.Size = new System.Drawing.Size(647, 21);
            this.teachersComboBox.TabIndex = 8;
            this.teachersComboBox.SelectedIndexChanged += new System.EventHandler(this.teachersComboBox_SelectedIndexChanged);
            // 
            // activitiesListView
            // 
            this.activitiesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.activitiesListView.FullRowSelect = true;
            this.activitiesListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.activitiesListView.HideSelection = false;
            this.activitiesListView.Location = new System.Drawing.Point(8, 51);
            this.activitiesListView.Name = "activitiesListView";
            this.activitiesListView.Size = new System.Drawing.Size(927, 372);
            this.activitiesListView.TabIndex = 9;
            this.activitiesListView.UseCompatibleStateImageBehavior = false;
            this.activitiesListView.View = System.Windows.Forms.View.Details;
            this.activitiesListView.SelectedIndexChanged += new System.EventHandler(this.activitiesListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Activity";
            this.columnHeader1.Width = 186;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Participates as...";
            this.columnHeader2.Width = 179;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Activitie start time";
            this.columnHeader3.Width = 165;
            // 
            // btnChangeCounsellor
            // 
            this.btnChangeCounsellor.Enabled = false;
            this.btnChangeCounsellor.Location = new System.Drawing.Point(8, 429);
            this.btnChangeCounsellor.Name = "btnChangeCounsellor";
            this.btnChangeCounsellor.Size = new System.Drawing.Size(178, 23);
            this.btnChangeCounsellor.TabIndex = 10;
            this.btnChangeCounsellor.Text = "Search replacement";
            this.btnChangeCounsellor.UseVisualStyleBackColor = true;
            this.btnChangeCounsellor.Click += new System.EventHandler(this.btnChangeCounsellor_Click);
            // 
            // TeachersScheduleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnChangeCounsellor);
            this.Controls.Add(this.activitiesListView);
            this.Controls.Add(this.teachersComboBox);
            this.Controls.Add(this.label1);
            this.Name = "TeachersScheduleView";
            this.Size = new System.Drawing.Size(938, 455);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox teachersComboBox;
        private System.Windows.Forms.ListView activitiesListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnChangeCounsellor;
    }
}
