namespace aGEtest
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
            this.btnDogAge = new System.Windows.Forms.Button();
            this.lblHumanAge = new System.Windows.Forms.Label();
            this.txtHumanAge = new System.Windows.Forms.TextBox();
            this.txtAnimalAge = new System.Windows.Forms.TextBox();
            this.lblAnimalAge = new System.Windows.Forms.Label();
            this.btnCatAge = new System.Windows.Forms.Button();
            this.btnTurtleAge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDogAge
            // 
            this.btnDogAge.Location = new System.Drawing.Point(125, 40);
            this.btnDogAge.Name = "btnDogAge";
            this.btnDogAge.Size = new System.Drawing.Size(75, 23);
            this.btnDogAge.TabIndex = 0;
            this.btnDogAge.Text = "Dog age converter";
            this.btnDogAge.UseVisualStyleBackColor = true;
            this.btnDogAge.Click += new System.EventHandler(this.btnDogAge_Click);
            // 
            // lblHumanAge
            // 
            this.lblHumanAge.AutoSize = true;
            this.lblHumanAge.Location = new System.Drawing.Point(48, 17);
            this.lblHumanAge.Name = "lblHumanAge";
            this.lblHumanAge.Size = new System.Drawing.Size(60, 13);
            this.lblHumanAge.TabIndex = 1;
            this.lblHumanAge.Text = "human age";
            // 
            // txtHumanAge
            // 
            this.txtHumanAge.Location = new System.Drawing.Point(114, 14);
            this.txtHumanAge.Name = "txtHumanAge";
            this.txtHumanAge.Size = new System.Drawing.Size(100, 20);
            this.txtHumanAge.TabIndex = 2;
            // 
            // txtAnimalAge
            // 
            this.txtAnimalAge.Location = new System.Drawing.Point(114, 69);
            this.txtAnimalAge.Name = "txtAnimalAge";
            this.txtAnimalAge.Size = new System.Drawing.Size(100, 20);
            this.txtAnimalAge.TabIndex = 3;
            // 
            // lblAnimalAge
            // 
            this.lblAnimalAge.AutoSize = true;
            this.lblAnimalAge.Location = new System.Drawing.Point(48, 72);
            this.lblAnimalAge.Name = "lblAnimalAge";
            this.lblAnimalAge.Size = new System.Drawing.Size(60, 13);
            this.lblAnimalAge.TabIndex = 4;
            this.lblAnimalAge.Text = "Animal Age";
            // 
            // btnCatAge
            // 
            this.btnCatAge.Location = new System.Drawing.Point(44, 40);
            this.btnCatAge.Name = "btnCatAge";
            this.btnCatAge.Size = new System.Drawing.Size(75, 23);
            this.btnCatAge.TabIndex = 5;
            this.btnCatAge.Text = "Cat Age";
            this.btnCatAge.UseVisualStyleBackColor = true;
            this.btnCatAge.Click += new System.EventHandler(this.btnCatAge_Click);
            // 
            // btnTurtleAge
            // 
            this.btnTurtleAge.Location = new System.Drawing.Point(206, 40);
            this.btnTurtleAge.Name = "btnTurtleAge";
            this.btnTurtleAge.Size = new System.Drawing.Size(75, 23);
            this.btnTurtleAge.TabIndex = 6;
            this.btnTurtleAge.Text = "Turtle Age";
            this.btnTurtleAge.UseVisualStyleBackColor = true;
            this.btnTurtleAge.Click += new System.EventHandler(this.btnTurtleAge_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(309, 97);
            this.Controls.Add(this.btnTurtleAge);
            this.Controls.Add(this.btnCatAge);
            this.Controls.Add(this.lblAnimalAge);
            this.Controls.Add(this.txtAnimalAge);
            this.Controls.Add(this.txtHumanAge);
            this.Controls.Add(this.lblHumanAge);
            this.Controls.Add(this.btnDogAge);
            this.Name = "Form1";
            this.Text = "Animal Age Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDogAge;
        private System.Windows.Forms.Label lblHumanAge;
        private System.Windows.Forms.TextBox txtHumanAge;
        private System.Windows.Forms.TextBox txtAnimalAge;
        private System.Windows.Forms.Label lblAnimalAge;
        private System.Windows.Forms.Button btnCatAge;
        private System.Windows.Forms.Button btnTurtleAge;
    }
}

