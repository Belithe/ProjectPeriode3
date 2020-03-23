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
            this.listViewDrinks = new System.Windows.Forms.ListView();
            this.DrinkName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kassa";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SomerenUI.Properties.Resources.someren;
            this.pictureBox1.Location = new System.Drawing.Point(825, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 110);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // listViewStudentsKassa
            // 
            this.listViewStudentsKassa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Number,
            this.Name});
            this.listViewStudentsKassa.HideSelection = false;
            this.listViewStudentsKassa.Location = new System.Drawing.Point(26, 50);
            this.listViewStudentsKassa.Name = "listViewStudentsKassa";
            this.listViewStudentsKassa.Size = new System.Drawing.Size(120, 383);
            this.listViewStudentsKassa.TabIndex = 9;
            this.listViewStudentsKassa.UseCompatibleStateImageBehavior = false;
            this.listViewStudentsKassa.View = System.Windows.Forms.View.Details;
            this.listViewStudentsKassa.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listViewStudentsKassa_ItemCheck);
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
            // listViewDrinks
            // 
            this.listViewDrinks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DrinkName});
            this.listViewDrinks.HideSelection = false;
            this.listViewDrinks.Location = new System.Drawing.Point(178, 50);
            this.listViewDrinks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewDrinks.Name = "listViewDrinks";
            this.listViewDrinks.Size = new System.Drawing.Size(120, 383);
            this.listViewDrinks.TabIndex = 10;
            this.listViewDrinks.UseCompatibleStateImageBehavior = false;
            this.listViewDrinks.View = System.Windows.Forms.View.Details;
            // 
            // DrinkName
            // 
            this.DrinkName.Text = "DrinkName";
            this.DrinkName.Width = 134;
            // 
            // KassaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listViewDrinks);
            this.Controls.Add(this.listViewStudentsKassa);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "KassaView";
            this.Size = new System.Drawing.Size(938, 455);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewStudentsKassa;
        private System.Windows.Forms.ColumnHeader DrinkName;
        private System.Windows.Forms.ListView listViewDrinks;
        private System.Windows.Forms.ColumnHeader Number;
        private System.Windows.Forms.ColumnHeader Name;
    }
}
