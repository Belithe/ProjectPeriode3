namespace SomerenUI
{
    partial class KassaView
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
            this.listViewStudentsKassa = new System.Windows.Forms.ListView();
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.DrinkName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kassa";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SomerenUI.Properties.Resources.someren;
            this.pictureBox1.Location = new System.Drawing.Point(1238, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 169);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // listViewStudentsKassa
            // 
            this.listViewStudentsKassa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Number,
            this.Name});
            this.listViewStudentsKassa.HideSelection = false;
            this.listViewStudentsKassa.Location = new System.Drawing.Point(39, 77);
            this.listViewStudentsKassa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewStudentsKassa.Name = "listViewStudentsKassa";
            this.listViewStudentsKassa.Size = new System.Drawing.Size(177, 586);
            this.listViewStudentsKassa.TabIndex = 9;
            this.listViewStudentsKassa.UseCompatibleStateImageBehavior = false;
            this.listViewStudentsKassa.View = System.Windows.Forms.View.Details;
            // 
            // Number
            // 
            this.Number.Text = "Number";
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 180;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DrinkName});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(268, 77);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(177, 586);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // DrinkName
            // 
            this.DrinkName.Text = "DrinkName";
            this.DrinkName.Width = 134;
            // 
            // KassaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listViewStudentsKassa);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Size = new System.Drawing.Size(1407, 700);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewStudentsKassa;
        private System.Windows.Forms.ColumnHeader Number;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader DrinkName;
    }
}
