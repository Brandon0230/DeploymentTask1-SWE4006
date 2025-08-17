namespace PopUpForm
{
    partial class PopUpForm
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
            this.popupBtn = new System.Windows.Forms.Button();
            this.popupLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // popupBtn
            // 
            this.popupBtn.Location = new System.Drawing.Point(619, 315);
            this.popupBtn.Name = "popupBtn";
            this.popupBtn.Size = new System.Drawing.Size(169, 73);
            this.popupBtn.TabIndex = 0;
            this.popupBtn.Text = "PopUp";
            this.popupBtn.UseVisualStyleBackColor = true;
            this.popupBtn.Click += new System.EventHandler(this.popupBtn_Click);
            // 
            // popupLbl
            // 
            this.popupLbl.AutoSize = true;
            this.popupLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popupLbl.Location = new System.Drawing.Point(326, 9);
            this.popupLbl.Name = "popupLbl";
            this.popupLbl.Size = new System.Drawing.Size(133, 42);
            this.popupLbl.TabIndex = 1;
            this.popupLbl.Text = "PopUp";
            this.popupLbl.Click += new System.EventHandler(this.popupLbl_Click);
            // 
            // PopUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.popupLbl);
            this.Controls.Add(this.popupBtn);
            this.Name = "PopUpForm";
            this.Text = "Pop Up Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button popupBtn;
        private System.Windows.Forms.Label popupLbl;
    }
}

