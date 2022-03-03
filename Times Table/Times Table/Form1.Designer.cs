namespace Times_Table
{
    partial class Form1
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
            this.btnTimesTable = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtTimesTable = new System.Windows.Forms.RichTextBox();
            this.txtBigBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnTimesTable
            // 
            this.btnTimesTable.Location = new System.Drawing.Point(485, 57);
            this.btnTimesTable.Name = "btnTimesTable";
            this.btnTimesTable.Size = new System.Drawing.Size(87, 43);
            this.btnTimesTable.TabIndex = 0;
            this.btnTimesTable.Text = "Generate Times Table";
            this.btnTimesTable.UseVisualStyleBackColor = true;
            this.btnTimesTable.Click += new System.EventHandler(this.btnTimesTable_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(379, 69);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 1;
            // 
            // txtTimesTable
            // 
            this.txtTimesTable.Location = new System.Drawing.Point(416, 106);
            this.txtTimesTable.Name = "txtTimesTable";
            this.txtTimesTable.Size = new System.Drawing.Size(254, 170);
            this.txtTimesTable.TabIndex = 2;
            this.txtTimesTable.Text = "";
            // 
            // txtBigBox
            // 
            this.txtBigBox.Location = new System.Drawing.Point(21, 7);
            this.txtBigBox.Name = "txtBigBox";
            this.txtBigBox.Size = new System.Drawing.Size(339, 268);
            this.txtBigBox.TabIndex = 3;
            this.txtBigBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 288);
            this.Controls.Add(this.txtBigBox);
            this.Controls.Add(this.txtTimesTable);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.btnTimesTable);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimesTable;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.RichTextBox txtTimesTable;
        private System.Windows.Forms.RichTextBox txtBigBox;
    }
}

