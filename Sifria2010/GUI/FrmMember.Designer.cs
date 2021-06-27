namespace Sifria2010.GUI
{
    partial class FrmMember
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
            this.lblMemberId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMemberFN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMemberStreet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMemberNamHouse = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMemberCity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMemberPhon1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMemberPhon2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMemberLN = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblAdd = new System.Windows.Forms.Label();
            this.errop1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumBooks = new System.Windows.Forms.TextBox();
            this.grpMemberDetails = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIsralId = new System.Windows.Forms.TextBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.lblChooseMember = new System.Windows.Forms.Label();
            this.cmbChhoseMember = new System.Windows.Forms.ComboBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLending = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errop1)).BeginInit();
            this.grpMemberDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMemberId
            // 
            this.lblMemberId.AutoSize = true;
            this.lblMemberId.Font = new System.Drawing.Font("Varela Round", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblMemberId.Location = new System.Drawing.Point(208, 54);
            this.lblMemberId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMemberId.Name = "lblMemberId";
            this.lblMemberId.Size = new System.Drawing.Size(0, 22);
            this.lblMemberId.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nehama", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.OliveDrab;
            this.label2.Location = new System.Drawing.Point(297, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "קוד מנוי";
            // 
            // txtMemberFN
            // 
            this.txtMemberFN.Font = new System.Drawing.Font("Varela Round", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtMemberFN.Location = new System.Drawing.Point(144, 135);
            this.txtMemberFN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMemberFN.Name = "txtMemberFN";
            this.txtMemberFN.Size = new System.Drawing.Size(113, 28);
            this.txtMemberFN.TabIndex = 2;
            this.txtMemberFN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMemberFN_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nehama", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.OliveDrab;
            this.label3.Location = new System.Drawing.Point(297, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "שם פרטי";
            // 
            // txtMemberStreet
            // 
            this.txtMemberStreet.Font = new System.Drawing.Font("Varela Round", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtMemberStreet.Location = new System.Drawing.Point(144, 219);
            this.txtMemberStreet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMemberStreet.Name = "txtMemberStreet";
            this.txtMemberStreet.Size = new System.Drawing.Size(113, 28);
            this.txtMemberStreet.TabIndex = 4;
            this.txtMemberStreet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMemberStreet_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nehama", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.Color.OliveDrab;
            this.label5.Location = new System.Drawing.Point(283, 180);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "שם משפחה";
            // 
            // txtMemberNamHouse
            // 
            this.txtMemberNamHouse.Font = new System.Drawing.Font("Varela Round", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtMemberNamHouse.Location = new System.Drawing.Point(144, 256);
            this.txtMemberNamHouse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMemberNamHouse.Name = "txtMemberNamHouse";
            this.txtMemberNamHouse.Size = new System.Drawing.Size(113, 28);
            this.txtMemberNamHouse.TabIndex = 6;
            this.txtMemberNamHouse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMemberNamHouse_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nehama", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.Color.OliveDrab;
            this.label6.Location = new System.Drawing.Point(303, 260);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "מס\' בית";
            // 
            // txtMemberCity
            // 
            this.txtMemberCity.Font = new System.Drawing.Font("Varela Round", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtMemberCity.Location = new System.Drawing.Point(144, 300);
            this.txtMemberCity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMemberCity.Name = "txtMemberCity";
            this.txtMemberCity.Size = new System.Drawing.Size(113, 28);
            this.txtMemberCity.TabIndex = 8;
            this.txtMemberCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMemberCity_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nehama", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.ForeColor = System.Drawing.Color.OliveDrab;
            this.label7.Location = new System.Drawing.Point(325, 300);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "עיר";
            // 
            // txtMemberPhon1
            // 
            this.txtMemberPhon1.Font = new System.Drawing.Font("Varela Round", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtMemberPhon1.Location = new System.Drawing.Point(144, 337);
            this.txtMemberPhon1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMemberPhon1.Name = "txtMemberPhon1";
            this.txtMemberPhon1.Size = new System.Drawing.Size(113, 28);
            this.txtMemberPhon1.TabIndex = 10;
            this.txtMemberPhon1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMemberPhon1_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nehama", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.ForeColor = System.Drawing.Color.OliveDrab;
            this.label8.Location = new System.Drawing.Point(271, 342);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "מס\' פלאפון 1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nehama", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.ForeColor = System.Drawing.Color.OliveDrab;
            this.label9.Location = new System.Drawing.Point(271, 375);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "מס\' פלאפון 2";
            // 
            // txtMemberPhon2
            // 
            this.txtMemberPhon2.Font = new System.Drawing.Font("Varela Round", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtMemberPhon2.Location = new System.Drawing.Point(144, 374);
            this.txtMemberPhon2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMemberPhon2.Name = "txtMemberPhon2";
            this.txtMemberPhon2.Size = new System.Drawing.Size(113, 28);
            this.txtMemberPhon2.TabIndex = 14;
            this.txtMemberPhon2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMemberPhon2_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nehama", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.ForeColor = System.Drawing.Color.OliveDrab;
            this.label10.Location = new System.Drawing.Point(309, 222);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "כתובת";
            // 
            // txtMemberLN
            // 
            this.txtMemberLN.Font = new System.Drawing.Font("Varela Round", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtMemberLN.Location = new System.Drawing.Point(144, 177);
            this.txtMemberLN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMemberLN.Name = "txtMemberLN";
            this.txtMemberLN.Size = new System.Drawing.Size(113, 28);
            this.txtMemberLN.TabIndex = 16;
            this.txtMemberLN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMemberLN_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Font = new System.Drawing.Font("Varela Round", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAdd.ForeColor = System.Drawing.Color.Indigo;
            this.btnAdd.Location = new System.Drawing.Point(227, 684);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(148, 62);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "הוסף מנוי ";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Font = new System.Drawing.Font("Abraham", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblAdd.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblAdd.Location = new System.Drawing.Point(231, 39);
            this.lblAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(276, 48);
            this.lblAdd.TabIndex = 19;
            this.lblAdd.Text = "הוספת מנוי חדש";
            // 
            // errop1
            // 
            this.errop1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nehama", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.OliveDrab;
            this.label1.Location = new System.Drawing.Point(276, 414);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "תאריך לידה";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nehama", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.OliveDrab;
            this.label4.Location = new System.Drawing.Point(225, 463);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "מספר ספרים להשאלה";
            // 
            // txtNumBooks
            // 
            this.txtNumBooks.Font = new System.Drawing.Font("Varela Round", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtNumBooks.Location = new System.Drawing.Point(144, 455);
            this.txtNumBooks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumBooks.Name = "txtNumBooks";
            this.txtNumBooks.Size = new System.Drawing.Size(75, 28);
            this.txtNumBooks.TabIndex = 23;
            this.txtNumBooks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumBooks_KeyPress);
            // 
            // grpMemberDetails
            // 
            this.grpMemberDetails.Controls.Add(this.label11);
            this.grpMemberDetails.Controls.Add(this.txtIsralId);
            this.grpMemberDetails.Controls.Add(this.cmbMonth);
            this.grpMemberDetails.Controls.Add(this.cmbYear);
            this.grpMemberDetails.Controls.Add(this.cmbDay);
            this.grpMemberDetails.Controls.Add(this.label8);
            this.grpMemberDetails.Controls.Add(this.lblMemberId);
            this.grpMemberDetails.Controls.Add(this.label4);
            this.grpMemberDetails.Controls.Add(this.label2);
            this.grpMemberDetails.Controls.Add(this.txtNumBooks);
            this.grpMemberDetails.Controls.Add(this.txtMemberFN);
            this.grpMemberDetails.Controls.Add(this.label1);
            this.grpMemberDetails.Controls.Add(this.label3);
            this.grpMemberDetails.Controls.Add(this.txtMemberStreet);
            this.grpMemberDetails.Controls.Add(this.txtMemberNamHouse);
            this.grpMemberDetails.Controls.Add(this.label5);
            this.grpMemberDetails.Controls.Add(this.label10);
            this.grpMemberDetails.Controls.Add(this.txtMemberCity);
            this.grpMemberDetails.Controls.Add(this.txtMemberLN);
            this.grpMemberDetails.Controls.Add(this.label6);
            this.grpMemberDetails.Controls.Add(this.label9);
            this.grpMemberDetails.Controls.Add(this.txtMemberPhon1);
            this.grpMemberDetails.Controls.Add(this.txtMemberPhon2);
            this.grpMemberDetails.Controls.Add(this.label7);
            this.grpMemberDetails.Font = new System.Drawing.Font("Nehama", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.grpMemberDetails.Location = new System.Drawing.Point(143, 171);
            this.grpMemberDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpMemberDetails.Name = "grpMemberDetails";
            this.grpMemberDetails.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpMemberDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpMemberDetails.Size = new System.Drawing.Size(476, 497);
            this.grpMemberDetails.TabIndex = 26;
            this.grpMemberDetails.TabStop = false;
            this.grpMemberDetails.Text = "פרטי מנוי";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nehama", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label11.ForeColor = System.Drawing.Color.OliveDrab;
            this.label11.Location = new System.Drawing.Point(277, 96);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 17);
            this.label11.TabIndex = 29;
            this.label11.Text = "תעודת זהות";
            // 
            // txtIsralId
            // 
            this.txtIsralId.Font = new System.Drawing.Font("Varela Round", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtIsralId.Location = new System.Drawing.Point(143, 96);
            this.txtIsralId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIsralId.Name = "txtIsralId";
            this.txtIsralId.Size = new System.Drawing.Size(115, 28);
            this.txtIsralId.TabIndex = 28;
            this.txtIsralId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIsralId_KeyPress);
            // 
            // cmbMonth
            // 
            this.cmbMonth.Font = new System.Drawing.Font("Varela Round", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbMonth.Location = new System.Drawing.Point(100, 409);
            this.cmbMonth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(59, 30);
            this.cmbMonth.TabIndex = 27;
            // 
            // cmbYear
            // 
            this.cmbYear.Font = new System.Drawing.Font("Varela Round", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(167, 409);
            this.cmbYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(91, 30);
            this.cmbYear.TabIndex = 26;
            // 
            // cmbDay
            // 
            this.cmbDay.Font = new System.Drawing.Font("Varela Round", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cmbDay.Location = new System.Drawing.Point(23, 409);
            this.cmbDay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(71, 30);
            this.cmbDay.TabIndex = 25;
            // 
            // lblChooseMember
            // 
            this.lblChooseMember.AutoSize = true;
            this.lblChooseMember.Font = new System.Drawing.Font("Nehama", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblChooseMember.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblChooseMember.Location = new System.Drawing.Point(148, 130);
            this.lblChooseMember.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChooseMember.Name = "lblChooseMember";
            this.lblChooseMember.Size = new System.Drawing.Size(62, 17);
            this.lblChooseMember.TabIndex = 27;
            this.lblChooseMember.Text = "בחר מנוי";
            // 
            // cmbChhoseMember
            // 
            this.cmbChhoseMember.Font = new System.Drawing.Font("Varela Round", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmbChhoseMember.FormattingEnabled = true;
            this.cmbChhoseMember.Location = new System.Drawing.Point(240, 123);
            this.cmbChhoseMember.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbChhoseMember.Name = "cmbChhoseMember";
            this.cmbChhoseMember.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbChhoseMember.Size = new System.Drawing.Size(231, 30);
            this.cmbChhoseMember.TabIndex = 28;
            this.cmbChhoseMember.Text = "-בחר מנוי-";
            this.cmbChhoseMember.SelectionChangeCommitted += new System.EventHandler(this.cmbChhoseMember_SelectionChangeCommitted);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Varela Round", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnNext.ForeColor = System.Drawing.Color.Indigo;
            this.btnNext.Location = new System.Drawing.Point(503, 123);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(125, 33);
            this.btnNext.TabIndex = 29;
            this.btnNext.Text = "המשך";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLending
            // 
            this.btnLending.BackColor = System.Drawing.SystemColors.Control;
            this.btnLending.Font = new System.Drawing.Font("Varela Round", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnLending.ForeColor = System.Drawing.Color.Indigo;
            this.btnLending.Location = new System.Drawing.Point(415, 684);
            this.btnLending.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLending.Name = "btnLending";
            this.btnLending.Size = new System.Drawing.Size(161, 62);
            this.btnLending.TabIndex = 30;
            this.btnLending.Text = "הוסף מנוי ובצע לו השאלה ";
            this.btnLending.UseVisualStyleBackColor = false;
            this.btnLending.Click += new System.EventHandler(this.btnLending_Click);
            // 
            // FrmMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(719, 767);
            this.Controls.Add(this.btnLending);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.cmbChhoseMember);
            this.Controls.Add(this.lblChooseMember);
            this.Controls.Add(this.grpMemberDetails);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.btnAdd);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMember";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "מנויים";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMember_FormClosed);
            this.Load += new System.EventHandler(this.FrmMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errop1)).EndInit();
            this.grpMemberDetails.ResumeLayout(false);
            this.grpMemberDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMemberFN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMemberStreet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMemberNamHouse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMemberCity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMemberPhon1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMemberPhon2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMemberLN;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.ErrorProvider errop1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblChooseMember;
        private System.Windows.Forms.GroupBox grpMemberDetails;
        private System.Windows.Forms.ComboBox cmbChhoseMember;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ComboBox cmbDay;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLending;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtIsralId;
    }
}