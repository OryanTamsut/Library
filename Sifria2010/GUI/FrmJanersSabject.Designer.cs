namespace Sifria2010.GUI
{
    partial class FrmJanersSabject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJanersSabject));
            this.btnFinish = new System.Windows.Forms.Button();
            this.lblHeadLine = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbChooseJaner = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbJanerDetails = new System.Windows.Forms.GroupBox();
            this.errorp1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbJanerDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorp1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFinish
            // 
            this.btnFinish.Enabled = false;
            this.btnFinish.Font = new System.Drawing.Font("Varela Round", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnFinish.ForeColor = System.Drawing.Color.Indigo;
            this.btnFinish.Location = new System.Drawing.Point(254, 342);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(152, 48);
            this.btnFinish.TabIndex = 0;
            this.btnFinish.Text = "לסיום";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // lblHeadLine
            // 
            this.lblHeadLine.AutoSize = true;
            this.lblHeadLine.Font = new System.Drawing.Font("Abraham", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblHeadLine.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblHeadLine.Location = new System.Drawing.Point(232, 34);
            this.lblHeadLine.Name = "lblHeadLine";
            this.lblHeadLine.Size = new System.Drawing.Size(185, 48);
            this.lblHeadLine.TabIndex = 1;
            this.lblHeadLine.Text = "הוסף ז\'אנר";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Varela Round", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtName.Location = new System.Drawing.Point(43, 70);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(169, 28);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // cmbChooseJaner
            // 
            this.cmbChooseJaner.Font = new System.Drawing.Font("Varela Round", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmbChooseJaner.FormattingEnabled = true;
            this.cmbChooseJaner.Location = new System.Drawing.Point(254, 122);
            this.cmbChooseJaner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbChooseJaner.Name = "cmbChooseJaner";
            this.cmbChooseJaner.Size = new System.Drawing.Size(203, 30);
            this.cmbChooseJaner.TabIndex = 3;
            this.cmbChooseJaner.SelectionChangeCommitted += new System.EventHandler(this.cmbChooseJaner_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nehama", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.OliveDrab;
            this.label2.Location = new System.Drawing.Point(287, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "שם הז\'אנר";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nehama", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.OliveDrab;
            this.label3.Location = new System.Drawing.Point(292, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "קוד ז\'אנר";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Varela Round", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblCode.Location = new System.Drawing.Point(142, 33);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(0, 22);
            this.lblCode.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nehama", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.OliveDrab;
            this.label1.Location = new System.Drawing.Point(169, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "בחר ז\'אנר";
            // 
            // grbJanerDetails
            // 
            this.grbJanerDetails.Controls.Add(this.lblCode);
            this.grbJanerDetails.Controls.Add(this.label3);
            this.grbJanerDetails.Controls.Add(this.label2);
            this.grbJanerDetails.Controls.Add(this.txtName);
            this.grbJanerDetails.Font = new System.Drawing.Font("Nehama", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.grbJanerDetails.Location = new System.Drawing.Point(120, 178);
            this.grbJanerDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbJanerDetails.Name = "grbJanerDetails";
            this.grbJanerDetails.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbJanerDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grbJanerDetails.Size = new System.Drawing.Size(389, 126);
            this.grbJanerDetails.TabIndex = 8;
            this.grbJanerDetails.TabStop = false;
            this.grbJanerDetails.Text = "פרטי הז\'אנר";
            // 
            // errorp1
            // 
            this.errorp1.ContainerControl = this;
            // 
            // FrmJanersSabject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 443);
            this.Controls.Add(this.grbJanerDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbChooseJaner);
            this.Controls.Add(this.lblHeadLine);
            this.Controls.Add(this.btnFinish);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmJanersSabject";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "ז\'אנרי ספרים";
            this.Load += new System.EventHandler(this.FrmJanersSabject_Load);
            this.grbJanerDetails.ResumeLayout(false);
            this.grbJanerDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorp1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Label lblHeadLine;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbChooseJaner;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbJanerDetails;
        private System.Windows.Forms.ErrorProvider errorp1;
    }
}