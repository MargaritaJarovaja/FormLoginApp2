
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RegistrButton = new System.Windows.Forms.PictureBox();
            this.LogginButton = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegistrButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogginButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Controls.Add(this.LogginButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.RegistrButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 491);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Logga in mig";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(224, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Regestrera mig";
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
            // RegistrButton
            // 
            this.RegistrButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegistrButton.Image = ((System.Drawing.Image)(resources.GetObject("RegistrButton.Image")));
            this.RegistrButton.Location = new System.Drawing.Point(222, 182);
            this.RegistrButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RegistrButton.Name = "RegistrButton";
            this.RegistrButton.Size = new System.Drawing.Size(120, 120);
            this.RegistrButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RegistrButton.TabIndex = 1;
            this.RegistrButton.TabStop = false;
            this.RegistrButton.Click += new System.EventHandler(this.RegistrButton_Click);
            this.RegistrButton.MouseEnter += new System.EventHandler(this.RegistrButton_MouseEnter);
            this.RegistrButton.MouseLeave += new System.EventHandler(this.RegistrButton_MouseLeave);
            // 
            // LogginButton
            // 
            this.LogginButton.Image = global::FormLoginApp2.Properties.Resources.premium_icon_cupcake_4516503;
            this.LogginButton.Location = new System.Drawing.Point(61, 182);
            this.LogginButton.Name = "LogginButton";
            this.LogginButton.Size = new System.Drawing.Size(120, 120);
            this.LogginButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogginButton.TabIndex = 5;
            this.LogginButton.TabStop = false;
            this.LogginButton.Click += new System.EventHandler(this.LogginButton_Click_1);
            this.LogginButton.MouseEnter += new System.EventHandler(this.LogginButton_MouseEnter_1);
            this.LogginButton.MouseLeave += new System.EventHandler(this.LogginButton_MouseLeave_1);
            // 
            // FirstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 491);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FirstForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FirstForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegistrButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogginButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox RegistrButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox LogginButton;
    }
}