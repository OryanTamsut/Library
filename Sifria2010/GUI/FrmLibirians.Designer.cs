namespace Sifria2010.GUI
{
    partial class FrmLibirians
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLibirians));
            this.txtPassward = new System.Windows.Forms.TextBox();
            this.txtLibrianId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHeadLine = new System.Windows.Forms.Label();
            this.cmbLibrians = new System.Windows.Forms.ComboBox();
            this.grbDetails = new System.Windows.Forms.GroupBox();
            this.txtFn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.errop1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errop1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassward
            // 
            this.txtPassward.Font = new System.Drawing.Font("Varela Round", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtPassward.Location = new System.Drawing.Point(36, 102);
            this.txtPassward.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassward.Name = "txtPassward";
            this.txtPassward.Size = new System.Drawing.Size(161, 28);
            this.txtPassward.TabIndex = 8;
            this.txtPassward.TextChanged += new System.EventHandler(this.txtPassward_TextChanged);
            this.txtPassward.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassward_KeyPress);
            // 
            // txtLibrianId
            // 
            this.txtLibrianId.Font = new System.Drawing.Font("Varela Round", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtLibrianId.Location = new System.Drawing.Point(36, 59);
            this.txtLibrianId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLibrianId.Name = "txtLibrianId";
            this.txtLibrianId.Size = new System.Drawing.Size(161, 28);
            this.txtLibrianId.TabIndex = 7;
            this.txtLibrianId.TextChanged += new System.EventHandler(this.txtLibrianId_TextChanged);
            this.txtLibrianId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLibrianId_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nehama", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.OliveDrab;
            this.label3.Location = new System.Drawing.Point(277, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "סיסמה";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nehama", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.OliveDrab;
            this.label2.Location = new System.Drawing.Point(244, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "ת.ז. ספרנית";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nehama", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.OliveDrab;
            this.label1.Location = new System.Drawing.Point(172, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "בחר ספרנית";
            // 
            // lblHeadLine
            // 
            this.lblHeadLine.AutoSize = true;
            this.lblHeadLine.Font = new System.Drawing.Font("Abraham", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblHeadLine.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblHeadLine.Location = new System.Drawing.Point(226, 38);
            this.lblHeadLine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeadLine.Name = "lblHeadLine";
            this.lblHeadLine.Size = new System.Drawing.Size(0, 48);
            this.lblHeadLine.TabIndex = 10;
            // 
            // cmbLibrians
            // 
            this.cmbLibrians.Font = new System.Drawing.Font("Varela Round", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmbLibrians.FormattingEnabled = true;
            this.cmbLibrians.Location = new System.Drawing.Point(291, 124);
            this.cmbLibrians.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbLibrians.Name = "cmbLibrians";
            this.cmbLibrians.Size = new System.Drawing.Size(216, 30);
            this.cmbLibrians.TabIndex = 11;
            this.cmbLibrians.SelectionChangeCommitted += new System.EventHandler(this.cmbLibrians_SelectionChangeCommitted);
            // 
            // grbDetails
            // 
            this.grbDetails.Controls.Add(this.txtFn);
            this.grbDetails.Controls.Add(this.label5);
            this.grbDetails.Controls.Add(this.txtLn);
            this.grbDetails.Controls.Add(this.label4);
            this.grbDetails.Controls.Add(this.txtPassward);
            this.grbDetails.Controls.Add(this.txtLibrianId);
            this.grbDetails.Controls.Add(this.label3);
            this.grbDetails.Controls.Add(this.label2);
            this.grbDetails.Font = new System.Drawing.Font("Nehama", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.grbDetails.Location = new System.Drawing.Point(155, 191);
            this.grbDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbDetails.Name = "grbDetails";
            this.grbDetails.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grbDetails.Size = new System.Drawing.Size(374, 228);
            this.grbDetails.TabIndex = 12;
            this.grbDetails.TabStop = false;
            this.grbDetails.Text = "פרטי ספרנית";
            // 
            // txtFn
            // 
            this.txtFn.Font = new System.Drawing.Font("Varela Round", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtFn.Location = new System.Drawing.Point(36, 142);
            this.txtFn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFn.Name = "txtFn";
            this.txtFn.Size = new System.Drawing.Size(161, 28);
            this.txtFn.TabIndex = 12;
            this.txtFn.TextChanged += new System.EventHandler(this.txtFn_TextChanged);
            this.txtFn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFn_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nehama", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.Color.OliveDrab;
            this.label5.Location = new System.Drawing.Point(260, 142);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "שם פרטי";
            // 
            // txtLn
            // 
            this.txtLn.Font = new System.Drawing.Font("Varela Round", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtLn.Location = new System.Drawing.Point(36, 178);
            this.txtLn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLn.Name = "txtLn";
            this.txtLn.Size = new System.Drawing.Size(161, 28);
            this.txtLn.TabIndex = 10;
            this.txtLn.TextChanged += new System.EventHandler(this.txtLn_TextChanged);
            this.txtLn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLn_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nehama", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.OliveDrab;
            this.label4.Location = new System.Drawing.Point(239, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "שם משפחה";
            // 
            // btnFinish
            // 
            this.btnFinish.Enabled = false;
            this.btnFinish.Font = new System.Drawing.Font("Varela Round", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnFinish.ForeColor = System.Drawing.Color.Indigo;
            this.btnFinish.Location = new System.Drawing.Point(277, 454);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(169, 58);
            this.btnFinish.TabIndex = 14;
            this.btnFinish.Text = "לסיום";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // errop1
            // 
            this.errop1.ContainerControl = this;
            // 
            // FrmLibirians
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 554);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.grbDetails);
            this.Controls.Add(this.cmbLibrians);
            this.Controls.Add(this.lblHeadLine);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmLibirians";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "ספרניות";
            this.Load += new System.EventHandler(this.FrmLibirians_Load);
            this.grbDetails.ResumeLayout(false);
            this.grbDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errop1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassward;
        private System.Windows.Forms.TextBox txtLibrianId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHeadLine;
        private System.Windows.Forms.ComboBox cmbLibrians;
        private System.Windows.Forms.GroupBox grbDetails;
        private System.Windows.Forms.TextBox txtFn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.ErrorProvider errop1;
    }
}