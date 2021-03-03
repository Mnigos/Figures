namespace Figures
{
    partial class Form2
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
            this.numInputA = new System.Windows.Forms.NumericUpDown();
            this.btnChangeWindow = new System.Windows.Forms.Button();
            this.txtField = new System.Windows.Forms.TextBox();
            this.txtCircuit = new System.Windows.Forms.TextBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.numInputB = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numInputA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInputB)).BeginInit();
            this.SuspendLayout();
            // 
            // numInputA
            // 
            this.numInputA.Location = new System.Drawing.Point(322, 163);
            this.numInputA.Name = "numInputA";
            this.numInputA.Size = new System.Drawing.Size(120, 20);
            this.numInputA.TabIndex = 11;
            // 
            // btnChangeWindow
            // 
            this.btnChangeWindow.Location = new System.Drawing.Point(12, 12);
            this.btnChangeWindow.Name = "btnChangeWindow";
            this.btnChangeWindow.Size = new System.Drawing.Size(75, 23);
            this.btnChangeWindow.TabIndex = 10;
            this.btnChangeWindow.Text = "Koło";
            this.btnChangeWindow.UseVisualStyleBackColor = true;
            this.btnChangeWindow.Click += new System.EventHandler(this.btnChangeWindow_Click);
            // 
            // txtField
            // 
            this.txtField.Location = new System.Drawing.Point(322, 298);
            this.txtField.Multiline = true;
            this.txtField.Name = "txtField";
            this.txtField.Size = new System.Drawing.Size(149, 44);
            this.txtField.TabIndex = 9;
            // 
            // txtCircuit
            // 
            this.txtCircuit.Location = new System.Drawing.Point(98, 298);
            this.txtCircuit.Multiline = true;
            this.txtCircuit.Name = "txtCircuit";
            this.txtCircuit.Size = new System.Drawing.Size(149, 44);
            this.txtCircuit.TabIndex = 8;
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(98, 135);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(149, 48);
            this.btnCount.TabIndex = 7;
            this.btnCount.Text = "Licz";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // numInputB
            // 
            this.numInputB.Location = new System.Drawing.Point(322, 137);
            this.numInputB.Name = "numInputB";
            this.numInputB.Size = new System.Drawing.Size(120, 20);
            this.numInputB.TabIndex = 12;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numInputB);
            this.Controls.Add(this.numInputA);
            this.Controls.Add(this.btnChangeWindow);
            this.Controls.Add(this.txtField);
            this.Controls.Add(this.txtCircuit);
            this.Controls.Add(this.btnCount);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numInputA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInputB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numInputA;
        private System.Windows.Forms.Button btnChangeWindow;
        private System.Windows.Forms.TextBox txtField;
        private System.Windows.Forms.TextBox txtCircuit;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.NumericUpDown numInputB;
    }
}