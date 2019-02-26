namespace WindowsFormPorlymorphism
{
    partial class frmShape
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
            this.pnlDraw = new System.Windows.Forms.Panel();
            this.rdRectangle = new System.Windows.Forms.RadioButton();
            this.rdCircle = new System.Windows.Forms.RadioButton();
            this.rdTriangle = new System.Windows.Forms.RadioButton();
            this.nud1 = new System.Windows.Forms.NumericUpDown();
            this.nud2 = new System.Windows.Forms.NumericUpDown();
            this.lblDim1 = new System.Windows.Forms.Label();
            this.lblDim2 = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDraw
            // 
            this.pnlDraw.BackColor = System.Drawing.Color.White;
            this.pnlDraw.Location = new System.Drawing.Point(12, 12);
            this.pnlDraw.Name = "pnlDraw";
            this.pnlDraw.Size = new System.Drawing.Size(336, 329);
            this.pnlDraw.TabIndex = 0;
            // 
            // rdRectangle
            // 
            this.rdRectangle.AutoSize = true;
            this.rdRectangle.Location = new System.Drawing.Point(388, 34);
            this.rdRectangle.Name = "rdRectangle";
            this.rdRectangle.Size = new System.Drawing.Size(107, 24);
            this.rdRectangle.TabIndex = 1;
            this.rdRectangle.TabStop = true;
            this.rdRectangle.Text = "Rectangle";
            this.rdRectangle.UseVisualStyleBackColor = true;
            this.rdRectangle.CheckedChanged += new System.EventHandler(this.changed);
            // 
            // rdCircle
            // 
            this.rdCircle.AutoSize = true;
            this.rdCircle.Location = new System.Drawing.Point(388, 74);
            this.rdCircle.Name = "rdCircle";
            this.rdCircle.Size = new System.Drawing.Size(73, 24);
            this.rdCircle.TabIndex = 2;
            this.rdCircle.TabStop = true;
            this.rdCircle.Text = "Circle";
            this.rdCircle.UseVisualStyleBackColor = true;
            this.rdCircle.CheckedChanged += new System.EventHandler(this.changed);
            // 
            // rdTriangle
            // 
            this.rdTriangle.AutoSize = true;
            this.rdTriangle.Location = new System.Drawing.Point(388, 114);
            this.rdTriangle.Name = "rdTriangle";
            this.rdTriangle.Size = new System.Drawing.Size(90, 24);
            this.rdTriangle.TabIndex = 3;
            this.rdTriangle.TabStop = true;
            this.rdTriangle.Text = "Triangle";
            this.rdTriangle.UseVisualStyleBackColor = true;
            this.rdTriangle.CheckedChanged += new System.EventHandler(this.changed);
            // 
            // nud1
            // 
            this.nud1.Location = new System.Drawing.Point(388, 203);
            this.nud1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud1.Name = "nud1";
            this.nud1.Size = new System.Drawing.Size(73, 26);
            this.nud1.TabIndex = 4;
            this.nud1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud1.ValueChanged += new System.EventHandler(this.changed);
            // 
            // nud2
            // 
            this.nud2.Location = new System.Drawing.Point(388, 246);
            this.nud2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud2.Name = "nud2";
            this.nud2.Size = new System.Drawing.Size(73, 26);
            this.nud2.TabIndex = 5;
            this.nud2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud2.ValueChanged += new System.EventHandler(this.changed);
            // 
            // lblDim1
            // 
            this.lblDim1.AutoSize = true;
            this.lblDim1.Location = new System.Drawing.Point(468, 203);
            this.lblDim1.Name = "lblDim1";
            this.lblDim1.Size = new System.Drawing.Size(55, 20);
            this.lblDim1.TabIndex = 6;
            this.lblDim1.Text = "label 1";
            // 
            // lblDim2
            // 
            this.lblDim2.AutoSize = true;
            this.lblDim2.Location = new System.Drawing.Point(472, 246);
            this.lblDim2.Name = "lblDim2";
            this.lblDim2.Size = new System.Drawing.Size(55, 20);
            this.lblDim2.TabIndex = 7;
            this.lblDim2.Text = "label 2";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(388, 305);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(107, 36);
            this.btnColor.TabIndex = 8;
            this.btnColor.Text = "Color...";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.changed);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblArea);
            this.groupBox1.Controls.Add(this.lblInfo);
            this.groupBox1.Location = new System.Drawing.Point(12, 362);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 137);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(22, 86);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(51, 20);
            this.lblArea.TabIndex = 1;
            this.lblArea.Text = "label4";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(22, 43);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(51, 20);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "label3";
            // 
            // frmShape
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 510);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.lblDim2);
            this.Controls.Add(this.lblDim1);
            this.Controls.Add(this.nud2);
            this.Controls.Add(this.nud1);
            this.Controls.Add(this.rdTriangle);
            this.Controls.Add(this.rdCircle);
            this.Controls.Add(this.rdRectangle);
            this.Controls.Add(this.pnlDraw);
            this.MaximizeBox = false;
            this.Name = "frmShape";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shape Porlymorphism";
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDraw;
        private System.Windows.Forms.RadioButton rdRectangle;
        private System.Windows.Forms.RadioButton rdCircle;
        private System.Windows.Forms.RadioButton rdTriangle;
        private System.Windows.Forms.NumericUpDown nud1;
        private System.Windows.Forms.NumericUpDown nud2;
        private System.Windows.Forms.Label lblDim1;
        private System.Windows.Forms.Label lblDim2;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblInfo;
    }
}

