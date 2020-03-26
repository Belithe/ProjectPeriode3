namespace SomerenUI {
    partial class TeacherSelectPopup {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.teachersComboBox = new System.Windows.Forms.ComboBox();
            this.btnConfirmSelection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select Teacher";
            // 
            // teachersComboBox
            // 
            this.teachersComboBox.FormattingEnabled = true;
            this.teachersComboBox.Location = new System.Drawing.Point(17, 55);
            this.teachersComboBox.Name = "teachersComboBox";
            this.teachersComboBox.Size = new System.Drawing.Size(771, 21);
            this.teachersComboBox.TabIndex = 9;
            // 
            // btnConfirmSelection
            // 
            this.btnConfirmSelection.Location = new System.Drawing.Point(615, 82);
            this.btnConfirmSelection.Name = "btnConfirmSelection";
            this.btnConfirmSelection.Size = new System.Drawing.Size(173, 23);
            this.btnConfirmSelection.TabIndex = 10;
            this.btnConfirmSelection.Text = "Choose selected teacher";
            this.btnConfirmSelection.UseVisualStyleBackColor = true;
            this.btnConfirmSelection.Click += new System.EventHandler(this.btnConfirmSelection_Click);
            // 
            // TeacherSelectPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 114);
            this.Controls.Add(this.btnConfirmSelection);
            this.Controls.Add(this.teachersComboBox);
            this.Controls.Add(this.label1);
            this.Name = "TeacherSelectPopup";
            this.Text = "TeacherSelectPopup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox teachersComboBox;
        private System.Windows.Forms.Button btnConfirmSelection;
    }
}