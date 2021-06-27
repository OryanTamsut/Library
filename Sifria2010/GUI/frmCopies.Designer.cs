namespace Sifria2010.GUI
{
    partial class frmCopies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCopies));
            this.lblHeadLine = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.cmbChooseBook = new System.Windows.Forms.ComboBox();
            this.cmbChooseCopy = new System.Windows.Forms.ComboBox();
            this.lblNumCopies = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblChooseCopy = new System.Windows.Forms.Label();
            this.txtNumCopies = new System.Windows.Forms.TextBox();
            this.grb = new System.Windows.Forms.GroupBox();
            this.grb.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeadLine
            // 
            this.lblHeadLine.AutoSize = true;
            this.lblHeadLine.Font = new System.Drawing.Font("Abraham", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblHeadLine.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblHeadLine.Location = new System.Drawing.Point(289, 26);
            this.lblHeadLine.Name = "lblHeadLine";
            this.lblHeadLine.Size = new System.Drawing.Size(131, 53);
            this.lblHeadLine.TabIndex = 0;
            this.lblHeadLine.Text = "label1";
            // 
            // btnFinish
            // 
            this.btnFinish.Enabled = false;
            this.btnFinish.Font = new System.Drawing.Font("Varela Round", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnFinish.ForeColor = System.Drawing.Color.Indigo;
            this.btnFinish.Location = new System.Drawing.Point(299, 281);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(107, 48);
            this.btnFinish.TabIndex = 1;
            this.btnFinish.Text = "button1";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // cmbChooseBook
            // 
            this.cmbChooseBook.Font = new System.Drawing.Font("Varela Round", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmbChooseBook.FormattingEnabled = true;
            this.cmbChooseBook.Location = new System.Drawing.Point(335, 118);
            this.cmbChooseBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbChooseBook.Name = "cmbChooseBook";
            this.cmbChooseBook.Size = new System.Drawing.Size(186, 25);
            this.cmbChooseBook.TabIndex = 2;
            this.cmbChooseBook.SelectionChangeCommitted += new System.EventHandler(this.cmbChooseBook_SelectionChangeCommitted);
            // 
            // cmbChooseCopy
            // 
            this.cmbChooseCopy.Font = new System.Drawing.Font("Varela Round", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmbChooseCopy.FormattingEnabled = true;
            this.cmbChooseCopy.Location = new System.Drawing.Point(20, 10);
            this.cmbChooseCopy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbChooseCopy.Name = "cmbChooseCopy";
            this.cmbChooseCopy.Size = new System.Drawing.Size(187, 25);
            this.cmbChooseCopy.TabIndex = 3;
            this.cmbChooseCopy.SelectionChangeCommitted += new System.EventHandler(this.cmbChooseCopy_SelectionChangeCommitted);
            // 
            // lblNumCopies
            // 
            this.lblNumCopies.AutoSize = true;
            this.lblNumCopies.Font = new System.Drawing.Font("Nehama", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblNumCopies.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblNumCopies.Location = new System.Drawing.Point(178, 169);
            this.lblNumCopies.Name = "lblNumCopies";
            this.lblNumCopies.Size = new System.Drawing.Size(144, 17);
            this.lblNumCopies.TabIndex = 4;
            this.lblNumCopies.Text = "מספר עותקים להוספה";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nehama", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.OliveDrab;
            this.label3.Location = new System.Drawing.Point(178, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "בחר ספר";
            // 
            // lblChooseCopy
            // 
            this.lblChooseCopy.AutoSize = true;
            this.lblChooseCopy.Font = new System.Drawing.Font("Nehama", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblChooseCopy.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblChooseCopy.Location = new System.Drawing.Point(285, 17);
            this.lblChooseCopy.Name = "lblChooseCopy";
            this.lblChooseCopy.Size = new System.Drawing.Size(69, 17);
            this.lblChooseCopy.TabIndex = 6;
            this.lblChooseCopy.Text = "בחר עותק";
            // 
            // txtNumCopies
            // 
            this.txtNumCopies.Font = new System.Drawing.Font("Varela Round", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtNumCopies.Location = new System.Drawing.Point(335, 162);
            this.txtNumCopies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumCopies.Name = "txtNumCopies";
            this.txtNumCopies.Size = new System.Drawing.Size(185, 24);
            this.txtNumCopies.TabIndex = 7;
            this.txtNumCopies.TextChanged += new System.EventHandler(this.txtNumCopies_TextChanged);
            // 
            // grb
            // 
            this.grb.Controls.Add(this.lblChooseCopy);
            this.grb.Controls.Add(this.cmbChooseCopy);
            this.grb.Location = new System.Drawing.Point(180, 194);
            this.grb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb.Name = "grb";
            this.grb.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb.Size = new System.Drawing.Size(362, 42);
            this.grb.TabIndex = 8;
            this.grb.TabStop = false;
            // 
            // frmCopies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.grb);
            this.Controls.Add(this.txtNumCopies);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNumCopies);
            this.Controls.Add(this.cmbChooseBook);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.lblHeadLine);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCopies";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "עותקים";
            this.Load += new System.EventHandler(this.frmCopies_Load);
            this.grb.ResumeLayout(false);
            this.grb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeadLine;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.ComboBox cmbChooseBook;
        private System.Windows.Forms.ComboBox cmbChooseCopy;
        private System.Windows.Forms.Label lblNumCopies;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblChooseCopy;
        private System.Windows.Forms.TextBox txtNumCopies;
        private System.Windows.Forms.GroupBox grb;
    }
}