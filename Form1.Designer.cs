namespace Figures
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCount = new System.Windows.Forms.Button();
            this.txtCircuit = new System.Windows.Forms.TextBox();
            this.txtField = new System.Windows.Forms.TextBox();
            this.btnChangeWindow = new System.Windows.Forms.Button();
            this.numInput = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numInput)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(99, 136);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(149, 48);
            this.btnCount.TabIndex = 2;
            this.btnCount.Text = "Licz";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // txtCircuit
            // 
            this.txtCircuit.Location = new System.Drawing.Point(99, 299);
            this.txtCircuit.Multiline = true;
            this.txtCircuit.Name = "txtCircuit";
            this.txtCircuit.Size = new System.Drawing.Size(149, 44);
            this.txtCircuit.TabIndex = 3;
            // 
            // txtField
            // 
            this.txtField.Location = new System.Drawing.Point(323, 299);
            this.txtField.Multiline = true;
            this.txtField.Name = "txtField";
            this.txtField.Size = new System.Drawing.Size(149, 44);
            this.txtField.TabIndex = 4;
            // 
            // btnChangeWindow
            // 
            this.btnChangeWindow.Location = new System.Drawing.Point(13, 13);
            this.btnChangeWindow.Name = "btnChangeWindow";
            this.btnChangeWindow.Size = new System.Drawing.Size(75, 23);
            this.btnChangeWindow.TabIndex = 5;
            this.btnChangeWindow.Text = "Prostokąt";
            this.btnChangeWindow.UseVisualStyleBackColor = true;
            this.btnChangeWindow.Click += new System.EventHandler(this.btnChangeWindow_Click);
            // 
            // numInput
            // 
            this.numInput.Location = new System.Drawing.Point(323, 152);
            this.numInput.Name = "numInput";
            this.numInput.Size = new System.Drawing.Size(120, 20);
            this.numInput.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 461);
            this.Controls.Add(this.numInput);
            this.Controls.Add(this.btnChangeWindow);
            this.Controls.Add(this.txtField);
            this.Controls.Add(this.txtCircuit);
            this.Controls.Add(this.btnCount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.TextBox txtCircuit;
        private System.Windows.Forms.TextBox txtField;
        private System.Windows.Forms.Button btnChangeWindow;
        private System.Windows.Forms.NumericUpDown numInput;
    }
}

