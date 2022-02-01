
namespace FormLoginApp2
{
    partial class FirstForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstForm));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.closeButtonFirst = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.RegistrButton = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.LogginButton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegistrButton)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogginButton)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.LavenderBlush;
            this.MainPanel.Controls.Add(this.closeButtonFirst);
            this.MainPanel.Controls.Add(this.panel3);
            this.MainPanel.Controls.Add(this.panel2);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(393, 491);
            this.MainPanel.TabIndex = 0;
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // closeButtonFirst
            // 
            this.closeButtonFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButtonFirst.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButtonFirst.Location = new System.Drawing.Point(354, 0);
            this.closeButtonFirst.Name = "closeButtonFirst";
            this.closeButtonFirst.Size = new System.Drawing.Size(50, 50);
            this.closeButtonFirst.TabIndex = 8;
            this.closeButtonFirst.Text = "x";
            this.closeButtonFirst.Click += new System.EventHandler(this.closeButtonFirst_Click);
            this.closeButtonFirst.MouseEnter += new System.EventHandler(this.closeButtonFirst_MouseEnter);
            this.closeButtonFirst.MouseLeave += new System.EventHandler(this.closeButtonFirst_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.RegistrButton);
            this.panel3.Location = new System.Drawing.Point(210, 175);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 190);
            this.panel3.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "registrera mig ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            this.label3.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            this.label3.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            // 
            // RegistrButton
            // 
            this.RegistrButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegistrButton.Image = ((System.Drawing.Image)(resources.GetObject("RegistrButton.Image")));
            this.RegistrButton.Location = new System.Drawing.Point(19, 13);
            this.RegistrButton.Margin = new System.Windows.Forms.Padding(2);
            this.RegistrButton.Name = "RegistrButton";
            this.RegistrButton.Size = new System.Drawing.Size(120, 120);
            this.RegistrButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RegistrButton.TabIndex = 1;
            this.RegistrButton.TabStop = false;
            this.RegistrButton.Click += new System.EventHandler(this.RegistrButton_Click);
            this.RegistrButton.MouseEnter += new System.EventHandler(this.RegistrButton_MouseEnter);
            this.RegistrButton.MouseLeave += new System.EventHandler(this.RegistrButton_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.LogginButton);
            this.panel2.Location = new System.Drawing.Point(3, 175);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 190);
            this.panel2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "logga in mig";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // LogginButton
            // 
            this.LogginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogginButton.Image = global::FormLoginApp2.Properties.Resources.premium_icon_cupcake_4516503;
            this.LogginButton.Location = new System.Drawing.Point(18, 13);
            this.LogginButton.Name = "LogginButton";
            this.LogginButton.Size = new System.Drawing.Size(120, 120);
            this.LogginButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogginButton.TabIndex = 5;
            this.LogginButton.TabStop = false;
            this.LogginButton.Click += new System.EventHandler(this.LogginButton_Click_1);
            this.LogginButton.MouseEnter += new System.EventHandler(this.LogginButton_MouseEnter_1);
            this.LogginButton.MouseLeave += new System.EventHandler(this.LogginButton_MouseLeave_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Välkommen";
            // 
            // FirstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 491);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FirstForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FirstForm";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RegistrButton)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogginButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox RegistrButton;
        private System.Windows.Forms.PictureBox LogginButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label closeButtonFirst;
    }
}