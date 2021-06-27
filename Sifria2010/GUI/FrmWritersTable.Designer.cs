namespace Sifria2010.GUI
{
    partial class FrmWritersTable
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
            this.DGVwritersTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVwritersTable)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVwritersTable
            // 
            this.DGVwritersTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVwritersTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVwritersTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGVwritersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVwritersTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVwritersTable.Location = new System.Drawing.Point(0, 0);
            this.DGVwritersTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGVwritersTable.Name = "DGVwritersTable";
            this.DGVwritersTable.Size = new System.Drawing.Size(900, 603);
            this.DGVwritersTable.TabIndex = 0;
            // 
            // FrmWritersTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 603);
            this.Controls.Add(this.DGVwritersTable);
            this.Font = new System.Drawing.Font("Varela Round", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmWritersTable";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "כל הסופרים";
            this.Load += new System.EventHandler(this.FrmWritersTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVwritersTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVwritersTable;
    }
}