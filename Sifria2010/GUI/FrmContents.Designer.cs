namespace Sifria2010.GUI
{
    partial class FrmContents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContents));
            this.btnFinish = new System.Windows.Forms.Button();
            this.lblHeadLine = new System.Windows.Forms.Label();
            this.txtContentName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbContents = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grbContentsDetails = new System.Windows.Forms.GroupBox();
            this.errorp1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbContentsDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorp1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFinish
            // 
            this.btnFinish.Enabled = false;
            this.btnFinish.Font = new System.Drawing.Font("Varela Round", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnFinish.ForeColor = System.Drawing.Color.Indigo;
            this.btnFinish.Location = new System.Drawing.Point(220, 374);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(194, 56);
            this.btnFinish.TabIndex = 0;
            this.btnFinish.Text = "סיום";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // lblHeadLine
            // 
            this.lblHeadLine.AutoSize = true;
            this.lblHeadLine.Font = new System.Drawing.Font("Abraham", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblHeadLine.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblHeadLine.Location = new System.Drawing.Point(184, 24);
            this.lblHeadLine.Name = "lblHeadLine";
            this.lblHeadLine.Size = new System.Drawing.Size(221, 53);
            this.lblHeadLine.TabIndex = 1;
            this.lblHeadLine.Text = "הוספת תוכן";
            // 
            // txtContentName
            // 
            this.txtContentName.Font = new System.Drawing.Font("Varela Round", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtContentName.Location = new System.Drawing.Point(73, 86);
            this.txtContentName.Name = "txtContentName";
            this.txtContentName.Size = new System.Drawing.Size(176, 24);
            this.txtContentName.TabIndex = 2;
            this.txtContentName.TextChanged += new System.EventHandler(this.txtContentName_TextChanged);
            this.txtContentName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContentName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nehama", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.OliveDrab;
            this.label2.Location = new System.Drawing.Point(299, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "שם התוכן";
            // 
            // cmbContents
            // 
            this.cmbContents.Font = new System.Drawing.Font("Varela Round", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmbContents.FormattingEnabled = true;
            this.cmbContents.Location = new System.Drawing.Point(242, 121);
            this.cmbContents.Name = "cmbContents";
            this.cmbContents.Size = new System.Drawing.Size(201, 25);
            this.cmbContents.TabIndex = 4;
            this.cmbContents.SelectionChangeCommitted += new System.EventHandler(this.cmbContents_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nehama", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.OliveDrab;
            this.label1.Location = new System.Drawing.Point(138, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "בחר תוכן";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Varela Round", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblCode.Location = new System.Drawing.Point(140, 43);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(0, 18);
            this.lblCode.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nehama", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.OliveDrab;
            this.label4.Location = new System.Drawing.Point(299, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "קוד התוכן";
            // 
            // grbContentsDetails
            // 
            this.grbContentsDetails.Controls.Add(this.label4);
            this.grbContentsDetails.Controls.Add(this.lblCode);
            this.grbContentsDetails.Controls.Add(this.label2);
            this.grbContentsDetails.Controls.Add(this.txtContentName);
            this.grbContentsDetails.Font = new System.Drawing.Font("Nehama", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.grbContentsDetails.Location = new System.Drawing.Point(102, 184);
            this.grbContentsDetails.Name = "grbContentsDetails";
            this.grbContentsDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grbContentsDetails.Size = new System.Drawing.Size(414, 147);
            this.grbContentsDetails.TabIndex = 8;
            this.grbContentsDetails.TabStop = false;
            this.grbContentsDetails.Text = "פרטי תוכן";
            // 
            // errorp1
            // 
            this.errorp1.ContainerControl = this;
            // 
            // FrmContents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(593, 472);
            this.Controls.Add(this.grbContentsDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbContents);
            this.Controls.Add(this.lblHeadLine);
            this.Controls.Add(this.btnFinish);
            this.Font = new System.Drawing.Font("Varela Round", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmContents";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "תכני ספר";
            this.Load += new System.EventHandler(this.FrmContents_Load);
            this.grbContentsDetails.ResumeLayout(false);
            this.grbContentsDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorp1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Label lblHeadLine;
        private System.Windows.Forms.TextBox txtContentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbContents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grbContentsDetails;
        private System.Windows.Forms.ErrorProvider errorp1;
    }
}