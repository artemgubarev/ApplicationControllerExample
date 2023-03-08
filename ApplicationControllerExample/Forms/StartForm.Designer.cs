namespace ApplicationControllerExample.Forms
{
    partial class StartForm
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
            this.btnRunMainForm = new System.Windows.Forms.Button();
            this.txtboxSomeArgument = new System.Windows.Forms.TextBox();
            this.lbSomeArgument = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRunMainForm
            // 
            this.btnRunMainForm.Location = new System.Drawing.Point(86, 180);
            this.btnRunMainForm.Name = "btnRunMainForm";
            this.btnRunMainForm.Size = new System.Drawing.Size(138, 23);
            this.btnRunMainForm.TabIndex = 0;
            this.btnRunMainForm.Text = "Run main form";
            this.btnRunMainForm.UseVisualStyleBackColor = true;
            // 
            // txtboxSomeArgument
            // 
            this.txtboxSomeArgument.Location = new System.Drawing.Point(206, 115);
            this.txtboxSomeArgument.Name = "txtboxSomeArgument";
            this.txtboxSomeArgument.Size = new System.Drawing.Size(145, 20);
            this.txtboxSomeArgument.TabIndex = 1;
            // 
            // lbSomeArgument
            // 
            this.lbSomeArgument.AutoSize = true;
            this.lbSomeArgument.Location = new System.Drawing.Point(53, 118);
            this.lbSomeArgument.Name = "lbSomeArgument";
            this.lbSomeArgument.Size = new System.Drawing.Size(147, 13);
            this.lbSomeArgument.TabIndex = 2;
            this.lbSomeArgument.Text = "Some argument value (string):";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.lbSomeArgument);
            this.Controls.Add(this.txtboxSomeArgument);
            this.Controls.Add(this.btnRunMainForm);
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRunMainForm;
        private System.Windows.Forms.TextBox txtboxSomeArgument;
        private System.Windows.Forms.Label lbSomeArgument;
    }
}