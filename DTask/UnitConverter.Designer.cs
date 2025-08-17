namespace DTask
{
    partial class UnitConverterForm
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
            this.dropDnFrom = new System.Windows.Forms.ComboBox();
            this.txtBxInput = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dropDnTo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dropDnFrom
            // 
            this.dropDnFrom.FormattingEnabled = true;
            this.dropDnFrom.Items.AddRange(new object[] {
            "metre",
            "kilometre",
            "inch",
            "yard",
            "mile",
            "feet"});
            this.dropDnFrom.Location = new System.Drawing.Point(227, 167);
            this.dropDnFrom.Name = "dropDnFrom";
            this.dropDnFrom.Size = new System.Drawing.Size(121, 21);
            this.dropDnFrom.TabIndex = 0;
            // 
            // txtBxInput
            // 
            this.txtBxInput.Location = new System.Drawing.Point(51, 168);
            this.txtBxInput.Name = "txtBxInput";
            this.txtBxInput.Size = new System.Drawing.Size(133, 20);
            this.txtBxInput.TabIndex = 1;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(320, 323);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 39);
            this.lblOutput.TabIndex = 2;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(535, 158);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(99, 39);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(278, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(241, 39);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Unit Converter";
            // 
            // dropDnTo
            // 
            this.dropDnTo.FormattingEnabled = true;
            this.dropDnTo.Items.AddRange(new object[] {
            "metre",
            "kilometre",
            "inch",
            "yard",
            "mile",
            "feet"});
            this.dropDnTo.Location = new System.Drawing.Point(398, 168);
            this.dropDnTo.Name = "dropDnTo";
            this.dropDnTo.Size = new System.Drawing.Size(121, 21);
            this.dropDnTo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter Value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Current Unit:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "New Unit";
            // 
            // UnitConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 454);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dropDnTo);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtBxInput);
            this.Controls.Add(this.dropDnFrom);
            this.Name = "UnitConverter";
            this.Text = "s";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox dropDnFrom;
        private System.Windows.Forms.TextBox txtBxInput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox dropDnTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

