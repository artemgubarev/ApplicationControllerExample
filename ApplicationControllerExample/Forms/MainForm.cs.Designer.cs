namespace ApplicationControllerExample.Forms
{
    partial class MainForm
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
            this.btnRunChildForm = new System.Windows.Forms.Button();
            this.txtboxSomeArgumentValue = new System.Windows.Forms.TextBox();
            this.lbSomeArgumentValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRunChildForm
            // 
            this.btnRunChildForm.Location = new System.Drawing.Point(274, 109);
            this.btnRunChildForm.Name = "btnRunChildForm";
            this.btnRunChildForm.Size = new System.Drawing.Size(170, 23);
            this.btnRunChildForm.TabIndex = 0;
            this.btnRunChildForm.Text = "Run Child Form";
            this.btnRunChildForm.UseVisualStyleBackColor = true;
            // 
            // txtboxSomeArgumentValue
            // 
            this.txtboxSomeArgumentValue.Location = new System.Drawing.Point(214, 46);
            this.txtboxSomeArgumentValue.Name = "txtboxSomeArgumentValue";
            this.txtboxSomeArgumentValue.Size = new System.Drawing.Size(283, 20);
            this.txtboxSomeArgumentValue.TabIndex = 1;
            // 
            // lbSomeArgumentValue
            // 
            this.lbSomeArgumentValue.AutoSize = true;
            this.lbSomeArgumentValue.Location = new System.Drawing.Point(95, 46);
            this.lbSomeArgumentValue.Name = "lbSomeArgumentValue";
            this.lbSomeArgumentValue.Size = new System.Drawing.Size(113, 13);
            this.lbSomeArgumentValue.TabIndex = 2;
            this.lbSomeArgumentValue.Text = "Some argument value:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 325);
            this.Controls.Add(this.lbSomeArgumentValue);
            this.Controls.Add(this.txtboxSomeArgumentValue);
            this.Controls.Add(this.btnRunChildForm);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRunChildForm;
        private System.Windows.Forms.TextBox txtboxSomeArgumentValue;
        private System.Windows.Forms.Label lbSomeArgumentValue;
    }
}