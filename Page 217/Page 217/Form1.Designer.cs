namespace Page_217
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
            this.greetingsTextBox = new System.Windows.Forms.TextBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.greetings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // greetingsTextBox
            // 
            this.greetingsTextBox.Location = new System.Drawing.Point(264, 48);
            this.greetingsTextBox.Name = "greetingsTextBox";
            this.greetingsTextBox.Size = new System.Drawing.Size(65, 20);
            this.greetingsTextBox.TabIndex = 7;
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outputLabel.Location = new System.Drawing.Point(144, 181);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(103, 251);
            this.outputLabel.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "How many greetings do you want?";
            // 
            // greetings
            // 
            this.greetings.Location = new System.Drawing.Point(159, 128);
            this.greetings.Name = "greetings";
            this.greetings.Size = new System.Drawing.Size(75, 23);
            this.greetings.TabIndex = 4;
            this.greetings.Text = "Click";
            this.greetings.UseVisualStyleBackColor = true;
            this.greetings.Click += new System.EventHandler(this.greetings_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 441);
            this.Controls.Add(this.greetingsTextBox);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.greetings);
            this.Name = "Form1";
            this.Text = "Greetings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox greetingsTextBox;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button greetings;
    }
}

