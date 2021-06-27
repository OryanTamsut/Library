namespace Sifria2010.GUI
{
    partial class frmAllFinePayingTable
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAllPaying = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllPaying)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllPaying
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Varela Round", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dgvAllPaying.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllPaying.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvAllPaying.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllPaying.Location = new System.Drawing.Point(26, 15);
            this.dgvAllPaying.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvAllPaying.Name = "dgvAllPaying";
            this.dgvAllPaying.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Varela Round", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dgvAllPaying.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAllPaying.Size = new System.Drawing.Size(787, 509);
            this.dgvAllPaying.TabIndex = 0;
            // 
            // frmAllFinePayingTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 548);
            this.Controls.Add(this.dgvAllPaying);
            this.Font = new System.Drawing.Font("Varela Round", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAllFinePayingTable";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "כל תשלומי הקנסות";
            this.Load += new System.EventHandler(this.frmAllFinePayingTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllPaying)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllPaying;
    }
}