namespace SomerenUI
{
    partial class WeekRoosterView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gridViewMon = new System.Windows.Forms.DataGridView();
            this.gridViewTue = new System.Windows.Forms.DataGridView();
            this.gridViewWed = new System.Windows.Forms.DataGridView();
            this.gridViewThu = new System.Windows.Forms.DataGridView();
            this.gridViewFri = new System.Windows.Forms.DataGridView();
            this.columnActivityNameMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.counsellorNamesColumnMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnActivityNameTue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.counsellorNamesColumnTue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnActivityNameWed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.counsellorNamesColumnWed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnActivityNameThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.counsellorNamesColumnThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnActivityNameFri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.counsellorNamesColumnFri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewWed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFri)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Week Rooster";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SomerenUI.Properties.Resources.someren;
            this.pictureBox1.Location = new System.Drawing.Point(825, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 110);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // gridViewMon
            // 
            this.gridViewMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewMon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnActivityNameMon,
            this.counsellorNamesColumnMon});
            this.gridViewMon.Location = new System.Drawing.Point(172, 53);
            this.gridViewMon.Name = "gridViewMon";
            this.gridViewMon.Size = new System.Drawing.Size(241, 163);
            this.gridViewMon.TabIndex = 9;
            // 
            // gridViewTue
            // 
            this.gridViewTue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewTue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnActivityNameTue,
            this.counsellorNamesColumnTue});
            this.gridViewTue.Location = new System.Drawing.Point(485, 53);
            this.gridViewTue.Name = "gridViewTue";
            this.gridViewTue.Size = new System.Drawing.Size(241, 163);
            this.gridViewTue.TabIndex = 10;
            // 
            // gridViewWed
            // 
            this.gridViewWed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewWed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnActivityNameWed,
            this.counsellorNamesColumnWed});
            this.gridViewWed.Location = new System.Drawing.Point(41, 251);
            this.gridViewWed.Name = "gridViewWed";
            this.gridViewWed.Size = new System.Drawing.Size(241, 163);
            this.gridViewWed.TabIndex = 11;
            // 
            // gridViewThu
            // 
            this.gridViewThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnActivityNameThu,
            this.counsellorNamesColumnThu});
            this.gridViewThu.Location = new System.Drawing.Point(330, 251);
            this.gridViewThu.Name = "gridViewThu";
            this.gridViewThu.Size = new System.Drawing.Size(241, 163);
            this.gridViewThu.TabIndex = 12;
            // 
            // gridViewFri
            // 
            this.gridViewFri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewFri.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnActivityNameFri,
            this.counsellorNamesColumnFri});
            this.gridViewFri.Location = new System.Drawing.Point(621, 251);
            this.gridViewFri.Name = "gridViewFri";
            this.gridViewFri.Size = new System.Drawing.Size(241, 163);
            this.gridViewFri.TabIndex = 13;
            // 
            // columnActivityNameMon
            // 
            this.columnActivityNameMon.HeaderText = "Activiteit";
            this.columnActivityNameMon.Name = "columnActivityNameMon";
            // 
            // counsellorNamesColumnMon
            // 
            this.counsellorNamesColumnMon.HeaderText = "Begeleiding";
            this.counsellorNamesColumnMon.Name = "counsellorNamesColumnMon";
            // 
            // columnActivityNameTue
            // 
            this.columnActivityNameTue.HeaderText = "Activiteit";
            this.columnActivityNameTue.Name = "columnActivityNameTue";
            // 
            // counsellorNamesColumnTue
            // 
            this.counsellorNamesColumnTue.HeaderText = "Begeleiding";
            this.counsellorNamesColumnTue.Name = "counsellorNamesColumnTue";
            // 
            // columnActivityNameWed
            // 
            this.columnActivityNameWed.HeaderText = "Activiteit";
            this.columnActivityNameWed.Name = "columnActivityNameWed";
            // 
            // counsellorNamesColumnWed
            // 
            this.counsellorNamesColumnWed.HeaderText = "Begeleiding";
            this.counsellorNamesColumnWed.Name = "counsellorNamesColumnWed";
            // 
            // columnActivityNameThu
            // 
            this.columnActivityNameThu.HeaderText = "Activiteit";
            this.columnActivityNameThu.Name = "columnActivityNameThu";
            // 
            // counsellorNamesColumnThu
            // 
            this.counsellorNamesColumnThu.HeaderText = "Begeleiding";
            this.counsellorNamesColumnThu.Name = "counsellorNamesColumnThu";
            // 
            // columnActivityNameFri
            // 
            this.columnActivityNameFri.HeaderText = "Activiteit";
            this.columnActivityNameFri.Name = "columnActivityNameFri";
            // 
            // counsellorNamesColumnFri
            // 
            this.counsellorNamesColumnFri.HeaderText = "Begeleiding";
            this.counsellorNamesColumnFri.Name = "counsellorNamesColumnFri";
            // 
            // WeekRoosterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridViewFri);
            this.Controls.Add(this.gridViewThu);
            this.Controls.Add(this.gridViewWed);
            this.Controls.Add(this.gridViewTue);
            this.Controls.Add(this.gridViewMon);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "WeekRoosterView";
            this.Size = new System.Drawing.Size(938, 455);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewWed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView gridViewMon;
        private System.Windows.Forms.DataGridView gridViewTue;
        private System.Windows.Forms.DataGridView gridViewWed;
        private System.Windows.Forms.DataGridView gridViewThu;
        private System.Windows.Forms.DataGridView gridViewFri;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnActivityNameMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn counsellorNamesColumnMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnActivityNameTue;
        private System.Windows.Forms.DataGridViewTextBoxColumn counsellorNamesColumnTue;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnActivityNameWed;
        private System.Windows.Forms.DataGridViewTextBoxColumn counsellorNamesColumnWed;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnActivityNameThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn counsellorNamesColumnThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnActivityNameFri;
        private System.Windows.Forms.DataGridViewTextBoxColumn counsellorNamesColumnFri;
    }
}
