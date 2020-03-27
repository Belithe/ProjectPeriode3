namespace SomerenUI
{
    partial class BTWView
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.quarterSelectList = new System.Windows.Forms.CheckedListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.afdracht6Box = new System.Windows.Forms.TextBox();
            this.afdracht21Box = new System.Windows.Forms.TextBox();
            this.totalAfdrachtBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SomerenUI.Properties.Resources.someren;
            this.pictureBox1.Location = new System.Drawing.Point(825, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 110);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Calculate Taxes";
            // 
            // quarterSelectList
            // 
            this.quarterSelectList.CheckOnClick = true;
            this.quarterSelectList.Cursor = System.Windows.Forms.Cursors.Default;
            this.quarterSelectList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quarterSelectList.FormattingEnabled = true;
            this.quarterSelectList.Items.AddRange(new object[] {
            "Kwartaal 1",
            "Kwartaal 2",
            "Kwartaal 3",
            "Kwartaal 4"});
            this.quarterSelectList.Location = new System.Drawing.Point(40, 74);
            this.quarterSelectList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.quarterSelectList.Name = "quarterSelectList";
            this.quarterSelectList.Size = new System.Drawing.Size(188, 64);
            this.quarterSelectList.TabIndex = 11;
            this.quarterSelectList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.quarterSelectList_ItemCheck);
            this.quarterSelectList.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(242, 74);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(361, 21);
            this.textBox1.TabIndex = 12;
            // 
            // afdracht6Box
            // 
            this.afdracht6Box.Location = new System.Drawing.Point(242, 98);
            this.afdracht6Box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.afdracht6Box.Name = "afdracht6Box";
            this.afdracht6Box.Size = new System.Drawing.Size(361, 20);
            this.afdracht6Box.TabIndex = 14;
            // 
            // afdracht21Box
            // 
            this.afdracht21Box.Location = new System.Drawing.Point(242, 121);
            this.afdracht21Box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.afdracht21Box.Name = "afdracht21Box";
            this.afdracht21Box.Size = new System.Drawing.Size(361, 20);
            this.afdracht21Box.TabIndex = 15;
            // 
            // totalAfdrachtBox
            // 
            this.totalAfdrachtBox.Location = new System.Drawing.Point(242, 144);
            this.totalAfdrachtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.totalAfdrachtBox.Name = "totalAfdrachtBox";
            this.totalAfdrachtBox.Size = new System.Drawing.Size(361, 20);
            this.totalAfdrachtBox.TabIndex = 16;
            // 
            // BTWView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.totalAfdrachtBox);
            this.Controls.Add(this.afdracht21Box);
            this.Controls.Add(this.afdracht6Box);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.quarterSelectList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BTWView";
            this.Size = new System.Drawing.Size(938, 455);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox quarterSelectList;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox afdracht6Box;
        private System.Windows.Forms.TextBox afdracht21Box;
        private System.Windows.Forms.TextBox totalAfdrachtBox;
    }
}
