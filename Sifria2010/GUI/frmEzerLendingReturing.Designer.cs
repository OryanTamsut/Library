namespace Sifria2010.GUI
{
    partial class frmEzerLendingReturing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEzerLendingReturing));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInfoOfDefect = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFineForDefect = new System.Windows.Forms.TextBox();
            this.btnFinish = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtInfoOfDefect);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtFineForDefect);
            this.panel2.Location = new System.Drawing.Point(92, 78);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 146);
            this.panel2.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nehama", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.OliveDrab;
            this.label3.Location = new System.Drawing.Point(155, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "מידע על פגם";
            this.label3.Visible = false;
            // 
            // txtInfoOfDefect
            // 
            this.txtInfoOfDefect.Font = new System.Drawing.Font("Varela Round", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtInfoOfDefect.Location = new System.Drawing.Point(16, 110);
            this.txtInfoOfDefect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInfoOfDefect.Name = "txtInfoOfDefect";
            this.txtInfoOfDefect.Size = new System.Drawing.Size(205, 26);
            this.txtInfoOfDefect.TabIndex = 24;
            this.txtInfoOfDefect.Visible = false;
            this.txtInfoOfDefect.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInfoOfDefect_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nehama", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.Color.OliveDrab;
            this.label6.Location = new System.Drawing.Point(155, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "קנס עבור פגם";
            // 
            // txtFineForDefect
            // 
            this.txtFineForDefect.Font = new System.Drawing.Font("Varela Round", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtFineForDefect.Location = new System.Drawing.Point(158, 48);
            this.txtFineForDefect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFineForDefect.Name = "txtFineForDefect";
            this.txtFineForDefect.Size = new System.Drawing.Size(73, 26);
            this.txtFineForDefect.TabIndex = 21;
            this.txtFineForDefect.Text = "0";
            this.txtFineForDefect.TextChanged += new System.EventHandler(this.txtFineForDefect_TextChanged);
            this.txtFineForDefect.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFineForDefect_KeyPress);
            // 
            // btnFinish
            // 
            this.btnFinish.Enabled = false;
            this.btnFinish.Font = new System.Drawing.Font("Varela Round", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnFinish.ForeColor = System.Drawing.Color.Indigo;
            this.btnFinish.Location = new System.Drawing.Point(204, 252);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(103, 36);
            this.btnFinish.TabIndex = 30;
            this.btnFinish.Text = "סיום";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Abraham", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(133, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 41);
            this.label1.TabIndex = 25;
            this.label1.Text = "קנס על פגם";
            // 
            // frmEzerLendingReturing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 313);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmEzerLendingReturing";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "הוספת קנס על פגם";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmEzerLendingReturing_FormClosed);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInfoOfDefect;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFineForDefect;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Label label1;
    }
}