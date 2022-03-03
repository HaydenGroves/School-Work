namespace CALCULATOR
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
            this.btnEquals = new System.Windows.Forms.Button();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtOperator1 = new System.Windows.Forms.TextBox();
            this.txtOperator2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEquals
            // 
            this.btnEquals.Location = new System.Drawing.Point(552, 91);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(23, 22);
            this.btnEquals.TabIndex = 0;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(447, 94);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(102, 20);
            this.txtNumber2.TabIndex = 1;
            // 
            // txtOutput
            // 
            this.txtOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOutput.Location = new System.Drawing.Point(579, 94);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(102, 19);
            this.txtOutput.TabIndex = 2;
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(283, 95);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(102, 20);
            this.txtNumber1.TabIndex = 3;
            // 
            // txtOperator1
            // 
            this.txtOperator1.Location = new System.Drawing.Point(391, 94);
            this.txtOperator1.Name = "txtOperator1";
            this.txtOperator1.Size = new System.Drawing.Size(22, 20);
            this.txtOperator1.TabIndex = 4;
            // 
            // txtOperator2
            // 
            this.txtOperator2.Location = new System.Drawing.Point(419, 95);
            this.txtOperator2.Name = "txtOperator2";
            this.txtOperator2.Size = new System.Drawing.Size(22, 20);
            this.txtOperator2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 261);
            this.Controls.Add(this.txtOperator2);
            this.Controls.Add(this.txtOperator1);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.btnEquals);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtOperator1;
        private System.Windows.Forms.TextBox txtOperator2;
    }
}

