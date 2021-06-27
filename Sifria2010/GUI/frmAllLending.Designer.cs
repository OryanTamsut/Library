namespace Sifria2010.GUI
{
    partial class frmAllLending
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
            this.dgvAllLending = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllLending)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllLending
            // 
            this.dgvAllLending.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAllLending.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAllLending.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvAllLending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllLending.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllLending.Location = new System.Drawing.Point(0, 0);
            this.dgvAllLending.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvAllLending.Name = "dgvAllLending";
            this.dgvAllLending.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvAllLending.Size = new System.Drawing.Size(849, 575);
            this.dgvAllLending.TabIndex = 0;
            // 
            // frmAllLending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 575);
            this.Controls.Add(this.dgvAllLending);
            this.Font = new System.Drawing.Font("Varela Round", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAllLending";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "כל ההשאלות וההחזרות";
            this.Load += new System.EventHandler(this.frmAllLending_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllLending)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllLending;
    }
}