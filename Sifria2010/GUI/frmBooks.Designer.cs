namespace Sifria2010.GUI
{
    partial class frmBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBooks));
            this.lblHeadLine = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBookId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtFromAge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtToAge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chbIsComics = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbJanerSubject = new System.Windows.Forms.ComboBox();
            this.cmbWriterName = new System.Windows.Forms.ComboBox();
            this.cmbBookSructure = new System.Windows.Forms.ComboBox();
            this.grbBookDetails = new System.Windows.Forms.GroupBox();
            this.contentAdd = new System.Windows.Forms.Button();
            this.cmbBookContent = new System.Windows.Forms.ComboBox();
            this.writerAdd = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.janerAdd = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.lblChooseBook = new System.Windows.Forms.Label();
            this.cmbChooseBook = new System.Windows.Forms.ComboBox();
            this.errop1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbBookDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errop1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeadLine
            // 
            this.lblHeadLine.AutoSize = true;
            this.lblHeadLine.Font = new System.Drawing.Font("Abraham", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblHeadLine.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblHeadLine.Location = new System.Drawing.Point(196, 9);
            this.lblHeadLine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeadLine.Name = "lblHeadLine";
            this.lblHeadLine.Size = new System.Drawing.Size(203, 56);
            this.lblHeadLine.TabIndex = 0;
            this.lblHeadLine.Text = "הוסף ספר";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.OliveDrab;
            this.label1.Location = new System.Drawing.Point(490, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "קוד ספר";
            // 
            // lblBookId
            // 
            this.lblBookId.AutoSize = true;
            this.lblBookId.ForeColor = System.Drawing.Color.Black;
            this.lblBookId.Location = new System.Drawing.Point(328, 45);
            this.lblBookId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.Size = new System.Drawing.Size(0, 18);
            this.lblBookId.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.OliveDrab;
            this.label3.Location = new System.Drawing.Point(495, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "שם ספר";
            // 
            // txtBookName
            // 
            this.txtBookName.Font = new System.Drawing.Font("Varela Round", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtBookName.Location = new System.Drawing.Point(278, 75);
            this.txtBookName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(158, 28);
            this.txtBookName.TabIndex = 4;
            this.txtBookName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBookName_KeyPress);
            // 
            // txtFromAge
            // 
            this.txtFromAge.Font = new System.Drawing.Font("Varela Round", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtFromAge.Location = new System.Drawing.Point(277, 363);
            this.txtFromAge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFromAge.Name = "txtFromAge";
            this.txtFromAge.Size = new System.Drawing.Size(158, 28);
            this.txtFromAge.TabIndex = 6;
            this.txtFromAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFromAge_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.OliveDrab;
            this.label4.Location = new System.Drawing.Point(466, 363);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "מיועד מגיל";
            // 
            // txtToAge
            // 
            this.txtToAge.Font = new System.Drawing.Font("Varela Round", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtToAge.Location = new System.Drawing.Point(277, 400);
            this.txtToAge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtToAge.Name = "txtToAge";
            this.txtToAge.Size = new System.Drawing.Size(158, 28);
            this.txtToAge.TabIndex = 8;
            this.txtToAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtToAge_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.OliveDrab;
            this.label5.Location = new System.Drawing.Point(451, 407);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "מיועד עד גיל";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Varela Round", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtPrice.Location = new System.Drawing.Point(279, 435);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(158, 28);
            this.txtPrice.TabIndex = 10;
            this.txtPrice.TextChanged += new System.EventHandler(this.TxtPrice_TextChanged);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.OliveDrab;
            this.label6.Location = new System.Drawing.Point(469, 450);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "מחיר עלות";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.OliveDrab;
            this.label9.Location = new System.Drawing.Point(465, 333);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 18);
            this.label9.TabIndex = 15;
            this.label9.Text = "האם קומיקס?";
            // 
            // chbIsComics
            // 
            this.chbIsComics.AutoSize = true;
            this.chbIsComics.Location = new System.Drawing.Point(420, 332);
            this.chbIsComics.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbIsComics.Name = "chbIsComics";
            this.chbIsComics.Size = new System.Drawing.Size(18, 17);
            this.chbIsComics.TabIndex = 16;
            this.chbIsComics.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.OliveDrab;
            this.label10.Location = new System.Drawing.Point(471, 192);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 18);
            this.label10.TabIndex = 17;
            this.label10.Text = "מבנה הספר";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.OliveDrab;
            this.label11.Location = new System.Drawing.Point(483, 245);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 18);
            this.label11.TabIndex = 18;
            this.label11.Text = "שם הסופר";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.OliveDrab;
            this.label12.Location = new System.Drawing.Point(482, 132);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 18);
            this.label12.TabIndex = 19;
            this.label12.Text = "ז\'אנר ספר";
            // 
            // cmbJanerSubject
            // 
            this.cmbJanerSubject.Font = new System.Drawing.Font("Varela Round", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmbJanerSubject.FormattingEnabled = true;
            this.cmbJanerSubject.Location = new System.Drawing.Point(278, 128);
            this.cmbJanerSubject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbJanerSubject.Name = "cmbJanerSubject";
            this.cmbJanerSubject.Size = new System.Drawing.Size(160, 30);
            this.cmbJanerSubject.TabIndex = 20;
            this.cmbJanerSubject.SelectionChangeCommitted += new System.EventHandler(this.cmbJanerSubject_SelectionChangeCommitted);
            // 
            // cmbWriterName
            // 
            this.cmbWriterName.Font = new System.Drawing.Font("Varela Round", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmbWriterName.FormattingEnabled = true;
            this.cmbWriterName.Location = new System.Drawing.Point(278, 239);
            this.cmbWriterName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbWriterName.Name = "cmbWriterName";
            this.cmbWriterName.Size = new System.Drawing.Size(160, 30);
            this.cmbWriterName.TabIndex = 21;
            this.cmbWriterName.SelectionChangeCommitted += new System.EventHandler(this.cmbWriterName_SelectionChangeCommitted);
            // 
            // cmbBookSructure
            // 
            this.cmbBookSructure.Font = new System.Drawing.Font("Varela Round", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmbBookSructure.FormattingEnabled = true;
            this.cmbBookSructure.Items.AddRange(new object[] {
            "סיפורים סיפורים",
            "סיפור ארוך",
            "אינצקלופדיה",
            "מילון"});
            this.cmbBookSructure.Location = new System.Drawing.Point(278, 181);
            this.cmbBookSructure.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbBookSructure.Name = "cmbBookSructure";
            this.cmbBookSructure.Size = new System.Drawing.Size(160, 30);
            this.cmbBookSructure.TabIndex = 22;
            this.cmbBookSructure.SelectionChangeCommitted += new System.EventHandler(this.cmbBookSructure_SelectionChangeCommitted);
            // 
            // grbBookDetails
            // 
            this.grbBookDetails.Controls.Add(this.contentAdd);
            this.grbBookDetails.Controls.Add(this.cmbBookContent);
            this.grbBookDetails.Controls.Add(this.writerAdd);
            this.grbBookDetails.Controls.Add(this.label14);
            this.grbBookDetails.Controls.Add(this.cmbBookSructure);
            this.grbBookDetails.Controls.Add(this.cmbWriterName);
            this.grbBookDetails.Controls.Add(this.janerAdd);
            this.grbBookDetails.Controls.Add(this.cmbJanerSubject);
            this.grbBookDetails.Controls.Add(this.label9);
            this.grbBookDetails.Controls.Add(this.chbIsComics);
            this.grbBookDetails.Controls.Add(this.label12);
            this.grbBookDetails.Controls.Add(this.label11);
            this.grbBookDetails.Controls.Add(this.label10);
            this.grbBookDetails.Controls.Add(this.txtPrice);
            this.grbBookDetails.Controls.Add(this.label6);
            this.grbBookDetails.Controls.Add(this.txtToAge);
            this.grbBookDetails.Controls.Add(this.label5);
            this.grbBookDetails.Controls.Add(this.txtFromAge);
            this.grbBookDetails.Controls.Add(this.label4);
            this.grbBookDetails.Controls.Add(this.txtBookName);
            this.grbBookDetails.Controls.Add(this.label3);
            this.grbBookDetails.Controls.Add(this.lblBookId);
            this.grbBookDetails.Controls.Add(this.label1);
            this.grbBookDetails.Font = new System.Drawing.Font("Nehama", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.grbBookDetails.Location = new System.Drawing.Point(30, 109);
            this.grbBookDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbBookDetails.Name = "grbBookDetails";
            this.grbBookDetails.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbBookDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grbBookDetails.Size = new System.Drawing.Size(568, 474);
            this.grbBookDetails.TabIndex = 23;
            this.grbBookDetails.TabStop = false;
            this.grbBookDetails.Text = "פרטי ספר";
            // 
            // contentAdd
            // 
            this.contentAdd.Font = new System.Drawing.Font("Varela Round", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.contentAdd.ForeColor = System.Drawing.Color.Indigo;
            this.contentAdd.Location = new System.Drawing.Point(51, 294);
            this.contentAdd.Name = "contentAdd";
            this.contentAdd.Size = new System.Drawing.Size(154, 37);
            this.contentAdd.TabIndex = 29;
            this.contentAdd.Text = "הוספת תוכן";
            this.contentAdd.UseVisualStyleBackColor = true;
            this.contentAdd.Click += new System.EventHandler(this.contentAdd_Click);
            // 
            // cmbBookContent
            // 
            this.cmbBookContent.Font = new System.Drawing.Font("Varela Round", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmbBookContent.FormattingEnabled = true;
            this.cmbBookContent.Location = new System.Drawing.Point(278, 291);
            this.cmbBookContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbBookContent.Name = "cmbBookContent";
            this.cmbBookContent.Size = new System.Drawing.Size(160, 30);
            this.cmbBookContent.TabIndex = 24;
            this.cmbBookContent.SelectionChangeCommitted += new System.EventHandler(this.cmbBookContent_SelectionChangeCommitted);
            // 
            // writerAdd
            // 
            this.writerAdd.Font = new System.Drawing.Font("Varela Round", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.writerAdd.ForeColor = System.Drawing.Color.Indigo;
            this.writerAdd.Location = new System.Drawing.Point(51, 245);
            this.writerAdd.Name = "writerAdd";
            this.writerAdd.Size = new System.Drawing.Size(154, 38);
            this.writerAdd.TabIndex = 28;
            this.writerAdd.Text = "הוספת סופר";
            this.writerAdd.UseVisualStyleBackColor = true;
            this.writerAdd.Click += new System.EventHandler(this.writerAdd_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.OliveDrab;
            this.label14.Location = new System.Drawing.Point(476, 294);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 18);
            this.label14.TabIndex = 23;
            this.label14.Text = "תוכן הספר";
            // 
            // janerAdd
            // 
            this.janerAdd.Font = new System.Drawing.Font("Varela Round", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.janerAdd.ForeColor = System.Drawing.Color.Indigo;
            this.janerAdd.Location = new System.Drawing.Point(51, 132);
            this.janerAdd.Name = "janerAdd";
            this.janerAdd.Size = new System.Drawing.Size(154, 37);
            this.janerAdd.TabIndex = 27;
            this.janerAdd.Text = "הוספת ז\'אנר";
            this.janerAdd.UseVisualStyleBackColor = true;
            this.janerAdd.Click += new System.EventHandler(this.janerAdd_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Enabled = false;
            this.btnEnd.Font = new System.Drawing.Font("Varela Round", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnEnd.ForeColor = System.Drawing.Color.Indigo;
            this.btnEnd.Location = new System.Drawing.Point(211, 593);
            this.btnEnd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(204, 47);
            this.btnEnd.TabIndex = 24;
            this.btnEnd.Text = "הוסף ספר";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // lblChooseBook
            // 
            this.lblChooseBook.AutoSize = true;
            this.lblChooseBook.Font = new System.Drawing.Font("Nehama", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblChooseBook.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblChooseBook.Location = new System.Drawing.Point(156, 87);
            this.lblChooseBook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChooseBook.Name = "lblChooseBook";
            this.lblChooseBook.Size = new System.Drawing.Size(65, 18);
            this.lblChooseBook.TabIndex = 25;
            this.lblChooseBook.Text = "בחר ספר";
            this.lblChooseBook.Visible = false;
            // 
            // cmbChooseBook
            // 
            this.cmbChooseBook.FormattingEnabled = true;
            this.cmbChooseBook.Location = new System.Drawing.Point(254, 81);
            this.cmbChooseBook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbChooseBook.Name = "cmbChooseBook";
            this.cmbChooseBook.Size = new System.Drawing.Size(210, 24);
            this.cmbChooseBook.TabIndex = 26;
            this.cmbChooseBook.Visible = false;
            this.cmbChooseBook.SelectionChangeCommitted += new System.EventHandler(this.cmbChooseBook_SelectionChangeCommitted);
            // 
            // errop1
            // 
            this.errop1.ContainerControl = this;
            // 
            // frmBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(620, 667);
            this.Controls.Add(this.cmbChooseBook);
            this.Controls.Add(this.lblChooseBook);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.grbBookDetails);
            this.Controls.Add(this.lblHeadLine);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBooks";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "ספרים";
            this.Load += new System.EventHandler(this.frmBooks_Load);
            this.grbBookDetails.ResumeLayout(false);
            this.grbBookDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errop1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeadLine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtFromAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtToAge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chbIsComics;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbJanerSubject;
        private System.Windows.Forms.ComboBox cmbWriterName;
        private System.Windows.Forms.ComboBox cmbBookSructure;
        private System.Windows.Forms.GroupBox grbBookDetails;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Label lblChooseBook;
        private System.Windows.Forms.ComboBox cmbChooseBook;
        private System.Windows.Forms.ComboBox cmbBookContent;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ErrorProvider errop1;
        private System.Windows.Forms.Button janerAdd;
        private System.Windows.Forms.Button contentAdd;
        private System.Windows.Forms.Button writerAdd;
    }
}