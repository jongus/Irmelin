namespace Irmelin
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
            this.gamePicture = new System.Windows.Forms.PictureBox();
            this.lblPlatform = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelModel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gamePicture)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gamePicture
            // 
            this.gamePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gamePicture.Location = new System.Drawing.Point(25, 125);
            this.gamePicture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gamePicture.Name = "gamePicture";
            this.gamePicture.Size = new System.Drawing.Size(1000, 480);
            this.gamePicture.TabIndex = 1;
            this.gamePicture.TabStop = false;
            // 
            // lblPlatform
            // 
            this.lblPlatform.BackColor = System.Drawing.Color.Gainsboro;
            this.lblPlatform.Font = new System.Drawing.Font("Segoe UI Semibold", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlatform.ForeColor = System.Drawing.Color.DimGray;
            this.lblPlatform.Location = new System.Drawing.Point(21, 9);
            this.lblPlatform.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlatform.Name = "lblPlatform";
            this.lblPlatform.Size = new System.Drawing.Size(1000, 75);
            this.lblPlatform.TabIndex = 3;
            this.lblPlatform.Text = "Super Nintendo Entertainment System";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.lblPlatform);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 100);
            this.panel1.TabIndex = 4;
            // 
            // labelModel
            // 
            this.labelModel.BackColor = System.Drawing.Color.DarkGray;
            this.labelModel.Font = new System.Drawing.Font("Segoe UI Semilight", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModel.ForeColor = System.Drawing.Color.DimGray;
            this.labelModel.Location = new System.Drawing.Point(25, 625);
            this.labelModel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(1000, 50);
            this.labelModel.TabIndex = 5;
            this.labelModel.Text = "Arkanoid, 1981";
            this.labelModel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelModel.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Location = new System.Drawing.Point(0, 1580);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1050, 100);
            this.panel2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1050, 1680);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.gamePicture);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gamePicture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox gamePicture;
        private System.Windows.Forms.Label lblPlatform;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Panel panel2;
    }
}

