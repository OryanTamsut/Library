namespace Sifria2010.GUI
{
    partial class frmFinePaying
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFinePaying));
            this.lblHeadLine = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.txtPayingSum = new System.Windows.Forms.TextBox();
            this.cmbMembers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.grbDetails = new System.Windows.Forms.GroupBox();
            this.errorp1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnNext = new System.Windows.Forms.Button();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.lblSumFineUpdate = new System.Windows.Forms.Label();
            this.txtSumFineNew = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvUpdateDetail = new System.Windows.Forms.DataGridView();
            this.grbDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorp1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdateDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeadLine
            // 
            this.lblHeadLine.AutoSize = true;
            this.lblHeadLine.Font = new System.Drawing.Font("Abraham", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblHeadLine.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblHeadLine.Location = new System.Drawing.Point(256, 28);
            this.lblHeadLine.Name = "lblHeadLine";
            this.lblHeadLine.Size = new System.Drawing.Size(238, 48);
            this.lblHeadLine.TabIndex = 0;
            this.lblHeadLine.Text = "תשלום קנסות";
            // 
            // btnFinish
            // 
            this.btnFinish.Enabled = false;
            this.btnFinish.Font = new System.Drawing.Font("Varela Round", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnFinish.ForeColor = System.Drawing.Color.Indigo;
            this.btnFinish.Location = new System.Drawing.Point(345, 647);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(95, 38);
            this.btnFinish.TabIndex = 1;
            this.btnFinish.Text = "לתשלום";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // txtPayingSum
            // 
            this.txtPayingSum.Font = new System.Drawing.Font("Varela Round", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtPayingSum.Location = new System.Drawing.Point(28, 74);
            this.txtPayingSum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPayingSum.Name = "txtPayingSum";
            this.txtPayingSum.Size = new System.Drawing.Size(136, 28);
            this.txtPayingSum.TabIndex = 2;
            this.txtPayingSum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPayingSum_KeyPress);
            // 
            // cmbMembers
            // 
            this.cmbMembers.Font = new System.Drawing.Font("Varela Round", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmbMembers.FormattingEnabled = true;
            this.cmbMembers.Location = new System.Drawing.Point(104, 6);
            this.cmbMembers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMembers.Name = "cmbMembers";
            this.cmbMembers.Size = new System.Drawing.Size(164, 25);
            this.cmbMembers.TabIndex = 3;
            this.cmbMembers.Text = "-בחר או הקש קוד מנוי-";
            this.cmbMembers.SelectionChangeCommitted += new System.EventHandler(this.cmbMembers_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nehama", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.OliveDrab;
            this.label2.Location = new System.Drawing.Point(197, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "סכום תשלום";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Varela Round", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblCode.Location = new System.Drawing.Point(92, 37);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(0, 22);
            this.lblCode.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nehama", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.OliveDrab;
            this.label4.Location = new System.Drawing.Point(204, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "קוד תשלום";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nehama", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.Color.OliveDrab;
            this.label5.Location = new System.Drawing.Point(273, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "בחר או הקש קוד מנוי";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Varela Round", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblDate.Location = new System.Drawing.Point(63, 55);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 18);
            this.lblDate.TabIndex = 8;
            // 
            // grbDetails
            // 
            this.grbDetails.Controls.Add(this.label4);
            this.grbDetails.Controls.Add(this.lblCode);
            this.grbDetails.Controls.Add(this.label2);
            this.grbDetails.Controls.Add(this.txtPayingSum);
            this.grbDetails.Enabled = false;
            this.grbDetails.Font = new System.Drawing.Font("Nehama", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.grbDetails.Location = new System.Drawing.Point(57, 76);
            this.grbDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbDetails.Name = "grbDetails";
            this.grbDetails.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grbDetails.Size = new System.Drawing.Size(288, 119);
            this.grbDetails.TabIndex = 9;
            this.grbDetails.TabStop = false;
            this.grbDetails.Text = "פרטי תשלום";
            // 
            // errorp1
            // 
            this.errorp1.ContainerControl = this;
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnNext.ForeColor = System.Drawing.Color.Indigo;
            this.btnNext.Location = new System.Drawing.Point(12, 6);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(73, 27);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "המשך";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Font = new System.Drawing.Font("Nehama", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblUpdate.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblUpdate.Location = new System.Drawing.Point(105, 116);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(271, 17);
            this.lblUpdate.TabIndex = 12;
            this.lblUpdate.Text = "סמן את ההשאלה שתרצה לשנות את פרטיה:";
            // 
            // lblSumFineUpdate
            // 
            this.lblSumFineUpdate.AutoSize = true;
            this.lblSumFineUpdate.Font = new System.Drawing.Font("Nehama", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSumFineUpdate.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblSumFineUpdate.Location = new System.Drawing.Point(173, 593);
            this.lblSumFineUpdate.Name = "lblSumFineUpdate";
            this.lblSumFineUpdate.Size = new System.Drawing.Size(162, 17);
            this.lblSumFineUpdate.TabIndex = 8;
            this.lblSumFineUpdate.Text = "שנה את סכום התשלום ל:";
            // 
            // txtSumFineNew
            // 
            this.txtSumFineNew.Font = new System.Drawing.Font("Varela Round", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtSumFineNew.Location = new System.Drawing.Point(380, 586);
            this.txtSumFineNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSumFineNew.Name = "txtSumFineNew";
            this.txtSumFineNew.Size = new System.Drawing.Size(136, 28);
            this.txtSumFineNew.TabIndex = 7;
            this.txtSumFineNew.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSumFineNew_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.grbDetails);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbMembers);
            this.panel1.Location = new System.Drawing.Point(151, 146);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 213);
            this.panel1.TabIndex = 13;
            // 
            // dgvUpdateDetail
            // 
            this.dgvUpdateDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpdateDetail.Location = new System.Drawing.Point(67, 199);
            this.dgvUpdateDetail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvUpdateDetail.Name = "dgvUpdateDetail";
            this.dgvUpdateDetail.RowHeadersWidth = 51;
            this.dgvUpdateDetail.Size = new System.Drawing.Size(593, 342);
            this.dgvUpdateDetail.TabIndex = 14;
            this.dgvUpdateDetail.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUpdateDetail_RowHeaderMouseClick_1);
            // 
            // frmFinePaying
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 724);
            this.Controls.Add(this.dgvUpdateDetail);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSumFineUpdate);
            this.Controls.Add(this.txtSumFineNew);
            this.Controls.Add(this.lblUpdate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.lblHeadLine);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmFinePaying";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "תשלום קנסות";
            this.Load += new System.EventHandler(this.frmFinePaying_Load);
            this.grbDetails.ResumeLayout(false);
            this.grbDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorp1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdateDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeadLine;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.TextBox txtPayingSum;
        private System.Windows.Forms.ComboBox cmbMembers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox grbDetails;
        private System.Windows.Forms.ErrorProvider errorp1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSumFineUpdate;
        private System.Windows.Forms.TextBox txtSumFineNew;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.DataGridView dgvUpdateDetail;
    }
}