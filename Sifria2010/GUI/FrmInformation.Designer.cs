namespace Sifria2010.GUI
{
    partial class FrmInformation
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
            this.btnFinish = new System.Windows.Forms.Button();
            this.lblHeadLine = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumDays = new System.Windows.Forms.TextBox();
            this.txtAddLending = new System.Windows.Forms.TextBox();
            this.txtPrecent = new System.Windows.Forms.TextBox();
            this.errorp1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtFinePriceForOneDay = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorp1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFinish
            // 
            this.btnFinish.Font = new System.Drawing.Font("Varela Round", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnFinish.ForeColor = System.Drawing.Color.Indigo;
            this.btnFinish.Location = new System.Drawing.Point(296, 394);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(153, 40);
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
            this.lblHeadLine.Location = new System.Drawing.Point(211, 25);
            this.lblHeadLine.Name = "lblHeadLine";
            this.lblHeadLine.Size = new System.Drawing.Size(306, 48);
            this.lblHeadLine.TabIndex = 1;
            this.lblHeadLine.Text = "עדכון פרטי מערכת";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Varela Round", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtPrice.Location = new System.Drawing.Point(350, 108);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(128, 28);
            this.txtPrice.TabIndex = 2;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nehama", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.OliveDrab;
            this.label2.Location = new System.Drawing.Point(77, 282);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(234, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "מספר פעמים שמתאפשר להאריך השאלה";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nehama", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.OliveDrab;
            this.label3.Location = new System.Drawing.Point(112, 222);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(169, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "מספר ימי השאלה מקסימלי";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nehama", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.OliveDrab;
            this.label4.Location = new System.Drawing.Point(112, 170);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(187, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "אחוזים מהספר עבור חיוב קנס";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nehama", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.Color.OliveDrab;
            this.label5.Location = new System.Drawing.Point(112, 113);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(159, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "מחיר מנוי עבור ספר אחד";
            // 
            // txtNumDays
            // 
            this.txtNumDays.Font = new System.Drawing.Font("Varela Round", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtNumDays.Location = new System.Drawing.Point(350, 218);
            this.txtNumDays.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumDays.Name = "txtNumDays";
            this.txtNumDays.Size = new System.Drawing.Size(128, 28);
            this.txtNumDays.TabIndex = 7;
            this.txtNumDays.TextChanged += new System.EventHandler(this.txtNumDays_TextChanged);
            this.txtNumDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumDays_KeyPress);
            // 
            // txtAddLending
            // 
            this.txtAddLending.Font = new System.Drawing.Font("Varela Round", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtAddLending.Location = new System.Drawing.Point(350, 274);
            this.txtAddLending.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddLending.Name = "txtAddLending";
            this.txtAddLending.Size = new System.Drawing.Size(128, 28);
            this.txtAddLending.TabIndex = 9;
            this.txtAddLending.TextChanged += new System.EventHandler(this.txtAddLending_TextChanged);
            this.txtAddLending.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddLending_KeyPress);
            // 
            // txtPrecent
            // 
            this.txtPrecent.Font = new System.Drawing.Font("Varela Round", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtPrecent.Location = new System.Drawing.Point(350, 166);
            this.txtPrecent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecent.Name = "txtPrecent";
            this.txtPrecent.Size = new System.Drawing.Size(128, 28);
            this.txtPrecent.TabIndex = 10;
            this.txtPrecent.TextChanged += new System.EventHandler(this.txtPrecent_TextChanged);
            this.txtPrecent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecent_KeyPress);
            // 
            // errorp1
            // 
            this.errorp1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nehama", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.OliveDrab;
            this.label1.Location = new System.Drawing.Point(112, 326);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "מחיר קנס ליום איחור";
            // 
            // txtFinePriceForOneDay
            // 
            this.txtFinePriceForOneDay.Font = new System.Drawing.Font("Varela Round", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtFinePriceForOneDay.Location = new System.Drawing.Point(350, 322);
            this.txtFinePriceForOneDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFinePriceForOneDay.Name = "txtFinePriceForOneDay";
            this.txtFinePriceForOneDay.Size = new System.Drawing.Size(128, 28);
            this.txtFinePriceForOneDay.TabIndex = 11;
            this.txtFinePriceForOneDay.TextChanged += new System.EventHandler(this.txtFinePriceForOneDay_TextChanged);
            this.txtFinePriceForOneDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFinePriceForOneDay_KeyPress);
            // 
            // FrmInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFinePriceForOneDay);
            this.Controls.Add(this.txtPrecent);
            this.Controls.Add(this.txtAddLending);
            this.Controls.Add(this.txtNumDays);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblHeadLine);
            this.Controls.Add(this.btnFinish);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmInformation";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "נתוני מערכת";
            this.Load += new System.EventHandler(this.FrmInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorp1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Label lblHeadLine;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumDays;
        private System.Windows.Forms.TextBox txtAddLending;
        private System.Windows.Forms.TextBox txtPrecent;
        private System.Windows.Forms.ErrorProvider errorp1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFinePriceForOneDay;
    }
}