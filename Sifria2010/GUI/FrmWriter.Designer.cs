namespace Sifria2010.GUI
{
    partial class FrmWriter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWriter));
            this.lblAddWriter = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWriterId = new System.Windows.Forms.Label();
            this.txtWriterName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.errop1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbChooseWriter = new System.Windows.Forms.ComboBox();
            this.GRBwriterDetails = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errop1)).BeginInit();
            this.GRBwriterDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAddWriter
            // 
            this.lblAddWriter.AutoSize = true;
            this.lblAddWriter.Font = new System.Drawing.Font("Abraham", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblAddWriter.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblAddWriter.Location = new System.Drawing.Point(134, 30);
            this.lblAddWriter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddWriter.Name = "lblAddWriter";
            this.lblAddWriter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAddWriter.Size = new System.Drawing.Size(209, 48);
            this.lblAddWriter.TabIndex = 0;
            this.lblAddWriter.Text = "הוספת סופר";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nehama", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.OliveDrab;
            this.label2.Location = new System.Drawing.Point(183, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "קוד סופר";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nehama", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.OliveDrab;
            this.label3.Location = new System.Drawing.Point(187, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "שם סופר";
            // 
            // lblWriterId
            // 
            this.lblWriterId.AutoSize = true;
            this.lblWriterId.Font = new System.Drawing.Font("Varela Round", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblWriterId.Location = new System.Drawing.Point(66, 26);
            this.lblWriterId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWriterId.Name = "lblWriterId";
            this.lblWriterId.Size = new System.Drawing.Size(0, 22);
            this.lblWriterId.TabIndex = 3;
            // 
            // txtWriterName
            // 
            this.txtWriterName.Font = new System.Drawing.Font("Varela Round", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtWriterName.Location = new System.Drawing.Point(37, 78);
            this.txtWriterName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtWriterName.Name = "txtWriterName";
            this.txtWriterName.Size = new System.Drawing.Size(114, 28);
            this.txtWriterName.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Varela Round", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAdd.ForeColor = System.Drawing.Color.Indigo;
            this.btnAdd.Location = new System.Drawing.Point(196, 327);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 43);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "הוסף סופר";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // errop1
            // 
            this.errop1.ContainerControl = this;
            // 
            // cmbChooseWriter
            // 
            this.cmbChooseWriter.Font = new System.Drawing.Font("Varela Round", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmbChooseWriter.FormattingEnabled = true;
            this.cmbChooseWriter.Location = new System.Drawing.Point(215, 127);
            this.cmbChooseWriter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbChooseWriter.Name = "cmbChooseWriter";
            this.cmbChooseWriter.Size = new System.Drawing.Size(173, 30);
            this.cmbChooseWriter.TabIndex = 6;
            this.cmbChooseWriter.SelectionChangeCommitted += new System.EventHandler(this.cmbChooseWriter_SelectionChangeCommitted);
            // 
            // GRBwriterDetails
            // 
            this.GRBwriterDetails.Controls.Add(this.txtWriterName);
            this.GRBwriterDetails.Controls.Add(this.lblWriterId);
            this.GRBwriterDetails.Controls.Add(this.label3);
            this.GRBwriterDetails.Controls.Add(this.label2);
            this.GRBwriterDetails.Font = new System.Drawing.Font("Nehama", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.GRBwriterDetails.Location = new System.Drawing.Point(117, 180);
            this.GRBwriterDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GRBwriterDetails.Name = "GRBwriterDetails";
            this.GRBwriterDetails.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GRBwriterDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GRBwriterDetails.Size = new System.Drawing.Size(327, 130);
            this.GRBwriterDetails.TabIndex = 7;
            this.GRBwriterDetails.TabStop = false;
            this.GRBwriterDetails.Text = "פרטי סופר";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nehama", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.OliveDrab;
            this.label1.Location = new System.Drawing.Point(122, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "בחר סופר";
            // 
            // FrmWriter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 412);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GRBwriterDetails);
            this.Controls.Add(this.cmbChooseWriter);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblAddWriter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmWriter";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "סופרים";
            this.Load += new System.EventHandler(this.FrmWriter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errop1)).EndInit();
            this.GRBwriterDetails.ResumeLayout(false);
            this.GRBwriterDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddWriter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWriterId;
        private System.Windows.Forms.TextBox txtWriterName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ErrorProvider errop1;
        private System.Windows.Forms.GroupBox GRBwriterDetails;
        private System.Windows.Forms.ComboBox cmbChooseWriter;
        private System.Windows.Forms.Label label1;
    }
}