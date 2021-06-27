namespace Sifria2010.GUI
{
    partial class FrmFinishLending
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFinishLending));
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnFinishReturing = new System.Windows.Forms.Button();
            this.cmbChooseMember = new System.Windows.Forms.ComboBox();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtFineForDelay = new System.Windows.Forms.TextBox();
            this.grbAll = new System.Windows.Forms.GroupBox();
            this.grbReturning = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblShach2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInfoOfDefect = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFineForDefect = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblshach = new System.Windows.Forms.Label();
            this.chb1 = new System.Windows.Forms.CheckBox();
            this.btnFineForDelayPaying = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnLosingBook = new System.Windows.Forms.Button();
            this.grbLending = new System.Windows.Forms.GroupBox();
            this.btnNextLending = new System.Windows.Forms.Button();
            this.cmbChhoseCopy = new System.Windows.Forms.ComboBox();
            this.lblChooseCopy = new System.Windows.Forms.Label();
            this.txtBookIdLending = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnFinishLending = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvMembersBooks = new System.Windows.Forms.DataGridView();
            this.btnNext = new System.Windows.Forms.Button();
            this.dgvHelpingLoanExtention = new System.Windows.Forms.DataGridView();
            this.btnShowMemberDetails = new System.Windows.Forms.Button();
            this.rdbCmb = new System.Windows.Forms.RadioButton();
            this.rdbTxt = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSumPreviousFine = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grbAll.SuspendLayout();
            this.grbReturning.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grbLending.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembersBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHelpingLoanExtention)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Abraham", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(626, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "השאלה\\החזרה";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nehama", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.ForeColor = System.Drawing.Color.OliveDrab;
            this.label7.Location = new System.Drawing.Point(207, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "קנס עבור איחור";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nehama", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.ForeColor = System.Drawing.Color.OliveDrab;
            this.label10.Location = new System.Drawing.Point(492, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "בחר מנוי";
            // 
            // btnFinishReturing
            // 
            this.btnFinishReturing.Font = new System.Drawing.Font("Varela Round", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnFinishReturing.ForeColor = System.Drawing.Color.Indigo;
            this.btnFinishReturing.Location = new System.Drawing.Point(76, 410);
            this.btnFinishReturing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFinishReturing.Name = "btnFinishReturing";
            this.btnFinishReturing.Size = new System.Drawing.Size(144, 36);
            this.btnFinishReturing.TabIndex = 11;
            this.btnFinishReturing.Text = "בצע החזרה";
            this.btnFinishReturing.UseVisualStyleBackColor = true;
            this.btnFinishReturing.Click += new System.EventHandler(this.btnFinishReturing_Click);
            // 
            // cmbChooseMember
            // 
            this.cmbChooseMember.Enabled = false;
            this.cmbChooseMember.Font = new System.Drawing.Font("Varela Round", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmbChooseMember.FormattingEnabled = true;
            this.cmbChooseMember.Location = new System.Drawing.Point(629, 147);
            this.cmbChooseMember.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbChooseMember.Name = "cmbChooseMember";
            this.cmbChooseMember.Size = new System.Drawing.Size(208, 27);
            this.cmbChooseMember.TabIndex = 12;
            this.cmbChooseMember.Text = "-בחר מנוי-";
            this.cmbChooseMember.SelectionChangeCommitted += new System.EventHandler(this.cmbChooseMember_SelectionChangeCommitted);
            // 
            // btnAddMember
            // 
            this.btnAddMember.Font = new System.Drawing.Font("Varela Round", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAddMember.ForeColor = System.Drawing.Color.Indigo;
            this.btnAddMember.Location = new System.Drawing.Point(865, 144);
            this.btnAddMember.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(144, 27);
            this.btnAddMember.TabIndex = 18;
            this.btnAddMember.Text = "הוסף מנוי חדש";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(619, 444);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 27);
            this.button3.TabIndex = 19;
            this.button3.Text = "לתשלום הקנס";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txtFineForDelay
            // 
            this.txtFineForDelay.Font = new System.Drawing.Font("Varela Round", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtFineForDelay.Location = new System.Drawing.Point(231, 56);
            this.txtFineForDelay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFineForDelay.Name = "txtFineForDelay";
            this.txtFineForDelay.Size = new System.Drawing.Size(73, 26);
            this.txtFineForDelay.TabIndex = 22;
            this.txtFineForDelay.TextChanged += new System.EventHandler(this.txtFineForDelay_TextChanged);
            this.txtFineForDelay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFineForDelay_KeyPress);
            // 
            // grbAll
            // 
            this.grbAll.Controls.Add(this.grbReturning);
            this.grbAll.Controls.Add(this.grbLending);
            this.grbAll.Controls.Add(this.label2);
            this.grbAll.Controls.Add(this.dgvMembersBooks);
            this.grbAll.Font = new System.Drawing.Font("Varela Round", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.grbAll.Location = new System.Drawing.Point(109, 346);
            this.grbAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbAll.Name = "grbAll";
            this.grbAll.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbAll.Size = new System.Drawing.Size(1269, 476);
            this.grbAll.TabIndex = 26;
            this.grbAll.TabStop = false;
            // 
            // grbReturning
            // 
            this.grbReturning.Controls.Add(this.panel2);
            this.grbReturning.Controls.Add(this.panel1);
            this.grbReturning.Controls.Add(this.btnFineForDelayPaying);
            this.grbReturning.Controls.Add(this.label9);
            this.grbReturning.Controls.Add(this.btnFinishReturing);
            this.grbReturning.Controls.Add(this.btnLosingBook);
            this.grbReturning.Location = new System.Drawing.Point(798, 14);
            this.grbReturning.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbReturning.Name = "grbReturning";
            this.grbReturning.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbReturning.Size = new System.Drawing.Size(453, 446);
            this.grbReturning.TabIndex = 26;
            this.grbReturning.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblShach2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtInfoOfDefect);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtFineForDefect);
            this.panel2.Location = new System.Drawing.Point(7, 60);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(431, 146);
            this.panel2.TabIndex = 28;
            this.panel2.Visible = false;
            // 
            // lblShach2
            // 
            this.lblShach2.AutoSize = true;
            this.lblShach2.Font = new System.Drawing.Font("Nehama", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblShach2.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblShach2.Location = new System.Drawing.Point(206, 60);
            this.lblShach2.Name = "lblShach2";
            this.lblShach2.Size = new System.Drawing.Size(15, 17);
            this.lblShach2.TabIndex = 25;
            this.lblShach2.Text = "₪";
            this.lblShach2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nehama", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.OliveDrab;
            this.label3.Location = new System.Drawing.Point(228, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "מידע על פגם";
            this.label3.Visible = false;
            // 
            // txtInfoOfDefect
            // 
            this.txtInfoOfDefect.Font = new System.Drawing.Font("Varela Round", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtInfoOfDefect.Location = new System.Drawing.Point(89, 120);
            this.txtInfoOfDefect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInfoOfDefect.Name = "txtInfoOfDefect";
            this.txtInfoOfDefect.Size = new System.Drawing.Size(205, 26);
            this.txtInfoOfDefect.TabIndex = 24;
            this.txtInfoOfDefect.Visible = false;
            this.txtInfoOfDefect.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInfoOfDefect_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nehama", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.Color.OliveDrab;
            this.label6.Location = new System.Drawing.Point(228, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "קנס עבור פגם";
            // 
            // txtFineForDefect
            // 
            this.txtFineForDefect.Font = new System.Drawing.Font("Varela Round", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtFineForDefect.Location = new System.Drawing.Point(231, 58);
            this.txtFineForDefect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFineForDefect.Name = "txtFineForDefect";
            this.txtFineForDefect.Size = new System.Drawing.Size(73, 26);
            this.txtFineForDefect.TabIndex = 21;
            this.txtFineForDefect.TextChanged += new System.EventHandler(this.txtFineForDefect_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblshach);
            this.panel1.Controls.Add(this.chb1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtFineForDelay);
            this.panel1.Location = new System.Drawing.Point(7, 224);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 124);
            this.panel1.TabIndex = 27;
            this.panel1.Visible = false;
            // 
            // lblshach
            // 
            this.lblshach.AutoSize = true;
            this.lblshach.Font = new System.Drawing.Font("Nehama", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblshach.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblshach.Location = new System.Drawing.Point(207, 58);
            this.lblshach.Name = "lblshach";
            this.lblshach.Size = new System.Drawing.Size(15, 17);
            this.lblshach.TabIndex = 26;
            this.lblshach.Text = "₪";
            this.lblshach.Visible = false;
            // 
            // chb1
            // 
            this.chb1.AutoSize = true;
            this.chb1.Font = new System.Drawing.Font("Nehama", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.chb1.ForeColor = System.Drawing.Color.OliveDrab;
            this.chb1.Location = new System.Drawing.Point(16, 102);
            this.chb1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chb1.Name = "chb1";
            this.chb1.Size = new System.Drawing.Size(334, 21);
            this.chb1.TabIndex = 26;
            this.chb1.Text = "הוסף את הקנס לחובת המנוי עבור הפעמים הבאות";
            this.chb1.UseVisualStyleBackColor = true;
            // 
            // btnFineForDelayPaying
            // 
            this.btnFineForDelayPaying.Font = new System.Drawing.Font("Varela Round", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnFineForDelayPaying.ForeColor = System.Drawing.Color.Indigo;
            this.btnFineForDelayPaying.Location = new System.Drawing.Point(248, 368);
            this.btnFineForDelayPaying.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFineForDelayPaying.Name = "btnFineForDelayPaying";
            this.btnFineForDelayPaying.Size = new System.Drawing.Size(145, 69);
            this.btnFineForDelayPaying.TabIndex = 25;
            this.btnFineForDelayPaying.Text = "שלם קנסות והחזר ספר לספרייה";
            this.btnFineForDelayPaying.UseVisualStyleBackColor = true;
            this.btnFineForDelayPaying.Click += new System.EventHandler(this.btnFineForDelayPaying_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nehama", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.Location = new System.Drawing.Point(160, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 28);
            this.label9.TabIndex = 8;
            this.label9.Text = "ביצוע החזרה";
            // 
            // btnLosingBook
            // 
            this.btnLosingBook.Enabled = false;
            this.btnLosingBook.Font = new System.Drawing.Font("Varela Round", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnLosingBook.ForeColor = System.Drawing.Color.Indigo;
            this.btnLosingBook.Location = new System.Drawing.Point(76, 368);
            this.btnLosingBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLosingBook.Name = "btnLosingBook";
            this.btnLosingBook.Size = new System.Drawing.Size(144, 38);
            this.btnLosingBook.TabIndex = 20;
            this.btnLosingBook.Text = "דווח על אובדן ספר";
            this.btnLosingBook.UseVisualStyleBackColor = true;
            this.btnLosingBook.Click += new System.EventHandler(this.btnLosingBook_Click);
            // 
            // grbLending
            // 
            this.grbLending.Controls.Add(this.btnNextLending);
            this.grbLending.Controls.Add(this.cmbChhoseCopy);
            this.grbLending.Controls.Add(this.lblChooseCopy);
            this.grbLending.Controls.Add(this.txtBookIdLending);
            this.grbLending.Controls.Add(this.label5);
            this.grbLending.Controls.Add(this.label8);
            this.grbLending.Controls.Add(this.btnFinishLending);
            this.grbLending.Location = new System.Drawing.Point(20, 12);
            this.grbLending.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbLending.Name = "grbLending";
            this.grbLending.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbLending.Size = new System.Drawing.Size(395, 290);
            this.grbLending.TabIndex = 25;
            this.grbLending.TabStop = false;
            // 
            // btnNextLending
            // 
            this.btnNextLending.Font = new System.Drawing.Font("Varela Round", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnNextLending.ForeColor = System.Drawing.Color.Indigo;
            this.btnNextLending.Location = new System.Drawing.Point(78, 119);
            this.btnNextLending.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNextLending.Name = "btnNextLending";
            this.btnNextLending.Size = new System.Drawing.Size(116, 34);
            this.btnNextLending.TabIndex = 30;
            this.btnNextLending.Text = "המשך";
            this.btnNextLending.UseVisualStyleBackColor = true;
            this.btnNextLending.Click += new System.EventHandler(this.btnNextLending_Click);
            // 
            // cmbChhoseCopy
            // 
            this.cmbChhoseCopy.Font = new System.Drawing.Font("Varela Round", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmbChhoseCopy.FormattingEnabled = true;
            this.cmbChhoseCopy.Location = new System.Drawing.Point(25, 164);
            this.cmbChhoseCopy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbChhoseCopy.Name = "cmbChhoseCopy";
            this.cmbChhoseCopy.Size = new System.Drawing.Size(103, 27);
            this.cmbChhoseCopy.TabIndex = 29;
            this.cmbChhoseCopy.Visible = false;
            this.cmbChhoseCopy.SelectedIndexChanged += new System.EventHandler(this.cmbChhoseCopy_SelectedIndexChanged);
            // 
            // lblChooseCopy
            // 
            this.lblChooseCopy.AutoSize = true;
            this.lblChooseCopy.Font = new System.Drawing.Font("Nehama", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblChooseCopy.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblChooseCopy.Location = new System.Drawing.Point(226, 167);
            this.lblChooseCopy.Name = "lblChooseCopy";
            this.lblChooseCopy.Size = new System.Drawing.Size(98, 17);
            this.lblChooseCopy.TabIndex = 28;
            this.lblChooseCopy.Text = "בחר עותק ספר";
            this.lblChooseCopy.Visible = false;
            // 
            // txtBookIdLending
            // 
            this.txtBookIdLending.Font = new System.Drawing.Font("Varela Round", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtBookIdLending.Location = new System.Drawing.Point(25, 84);
            this.txtBookIdLending.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBookIdLending.Name = "txtBookIdLending";
            this.txtBookIdLending.Size = new System.Drawing.Size(73, 26);
            this.txtBookIdLending.TabIndex = 10;
            this.txtBookIdLending.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBookIdLending_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nehama", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.Color.OliveDrab;
            this.label5.Location = new System.Drawing.Point(174, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "הזן קוד ספר להשאלה";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nehama", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(121, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 28);
            this.label8.TabIndex = 7;
            this.label8.Text = "ביצוע השאלה";
            // 
            // btnFinishLending
            // 
            this.btnFinishLending.Enabled = false;
            this.btnFinishLending.Font = new System.Drawing.Font("Varela Round", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnFinishLending.ForeColor = System.Drawing.Color.Indigo;
            this.btnFinishLending.Location = new System.Drawing.Point(72, 208);
            this.btnFinishLending.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFinishLending.Name = "btnFinishLending";
            this.btnFinishLending.Size = new System.Drawing.Size(160, 37);
            this.btnFinishLending.TabIndex = 23;
            this.btnFinishLending.Text = "בצע השאלה";
            this.btnFinishLending.UseVisualStyleBackColor = true;
            this.btnFinishLending.Click += new System.EventHandler(this.btnFinishLending_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nehama", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(471, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 28);
            this.label2.TabIndex = 24;
            this.label2.Text = "הספרים שברשות המנוי";
            // 
            // dgvMembersBooks
            // 
            this.dgvMembersBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMembersBooks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMembersBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembersBooks.Location = new System.Drawing.Point(430, 66);
            this.dgvMembersBooks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMembersBooks.Name = "dgvMembersBooks";
            this.dgvMembersBooks.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvMembersBooks.RowHeadersWidth = 51;
            this.dgvMembersBooks.RowTemplate.Height = 28;
            this.dgvMembersBooks.Size = new System.Drawing.Size(324, 182);
            this.dgvMembersBooks.TabIndex = 13;
            this.dgvMembersBooks.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMembersBooks_RowHeaderMouseClick);
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Font = new System.Drawing.Font("Varela Round", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnNext.ForeColor = System.Drawing.Color.Indigo;
            this.btnNext.Location = new System.Drawing.Point(658, 288);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(167, 30);
            this.btnNext.TabIndex = 27;
            this.btnNext.Text = "המשך";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // dgvHelpingLoanExtention
            // 
            this.dgvHelpingLoanExtention.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHelpingLoanExtention.Location = new System.Drawing.Point(1156, 76);
            this.dgvHelpingLoanExtention.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvHelpingLoanExtention.Name = "dgvHelpingLoanExtention";
            this.dgvHelpingLoanExtention.RowHeadersWidth = 51;
            this.dgvHelpingLoanExtention.RowTemplate.Height = 28;
            this.dgvHelpingLoanExtention.Size = new System.Drawing.Size(124, 90);
            this.dgvHelpingLoanExtention.TabIndex = 28;
            this.dgvHelpingLoanExtention.Visible = false;
            // 
            // btnShowMemberDetails
            // 
            this.btnShowMemberDetails.Font = new System.Drawing.Font("Varela Round", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnShowMemberDetails.ForeColor = System.Drawing.Color.Indigo;
            this.btnShowMemberDetails.Location = new System.Drawing.Point(672, 244);
            this.btnShowMemberDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowMemberDetails.Name = "btnShowMemberDetails";
            this.btnShowMemberDetails.Size = new System.Drawing.Size(142, 25);
            this.btnShowMemberDetails.TabIndex = 29;
            this.btnShowMemberDetails.Text = "הצג פרטי מנוי";
            this.btnShowMemberDetails.UseVisualStyleBackColor = true;
            this.btnShowMemberDetails.Visible = false;
            this.btnShowMemberDetails.Click += new System.EventHandler(this.btnShowMemberDetails_Click);
            // 
            // rdbCmb
            // 
            this.rdbCmb.AutoSize = true;
            this.rdbCmb.Location = new System.Drawing.Point(583, 150);
            this.rdbCmb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbCmb.Name = "rdbCmb";
            this.rdbCmb.Size = new System.Drawing.Size(17, 16);
            this.rdbCmb.TabIndex = 30;
            this.rdbCmb.TabStop = true;
            this.rdbCmb.UseVisualStyleBackColor = true;
            this.rdbCmb.CheckedChanged += new System.EventHandler(this.rdbCmb_CheckedChanged);
            // 
            // rdbTxt
            // 
            this.rdbTxt.AutoSize = true;
            this.rdbTxt.Location = new System.Drawing.Point(583, 193);
            this.rdbTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbTxt.Name = "rdbTxt";
            this.rdbTxt.Size = new System.Drawing.Size(17, 16);
            this.rdbTxt.TabIndex = 31;
            this.rdbTxt.TabStop = true;
            this.rdbTxt.UseVisualStyleBackColor = true;
            this.rdbTxt.CheckedChanged += new System.EventHandler(this.rdbTxt_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nehama", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.OliveDrab;
            this.label4.Location = new System.Drawing.Point(473, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "הקש קוד מנוי";
            // 
            // txtCode
            // 
            this.txtCode.Enabled = false;
            this.txtCode.Font = new System.Drawing.Font("Varela Round", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtCode.Location = new System.Drawing.Point(629, 194);
            this.txtCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(129, 26);
            this.txtCode.TabIndex = 33;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            this.txtCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCode_KeyPress);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Varela Round", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.ForeColor = System.Drawing.Color.Indigo;
            this.button1.Location = new System.Drawing.Point(58, 84);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 50);
            this.button1.TabIndex = 27;
            this.button1.Text = "שלם קנס";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSumPreviousFine
            // 
            this.txtSumPreviousFine.Font = new System.Drawing.Font("Varela Round", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtSumPreviousFine.Location = new System.Drawing.Point(89, 49);
            this.txtSumPreviousFine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSumPreviousFine.Name = "txtSumPreviousFine";
            this.txtSumPreviousFine.ReadOnly = true;
            this.txtSumPreviousFine.Size = new System.Drawing.Size(73, 26);
            this.txtSumPreviousFine.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nehama", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label11.ForeColor = System.Drawing.Color.OliveDrab;
            this.label11.Location = new System.Drawing.Point(14, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(195, 17);
            this.label11.TabIndex = 31;
            this.label11.Text = "למנוי זה קיים חוב קודם על סך:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txtSumPreviousFine);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(1046, 185);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(269, 141);
            this.panel3.TabIndex = 34;
            this.panel3.Visible = false;
            // 
            // FrmFinishLending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1403, 840);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rdbTxt);
            this.Controls.Add(this.rdbCmb);
            this.Controls.Add(this.btnShowMemberDetails);
            this.Controls.Add(this.dgvHelpingLoanExtention);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.grbAll);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.cmbChooseMember);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmFinishLending";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "השאלות והחזרות";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Lending_Load);
            this.grbAll.ResumeLayout(false);
            this.grbAll.PerformLayout();
            this.grbReturning.ResumeLayout(false);
            this.grbReturning.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grbLending.ResumeLayout(false);
            this.grbLending.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembersBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHelpingLoanExtention)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnFinishReturing;
        private System.Windows.Forms.ComboBox cmbChooseMember;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtFineForDelay;
        private System.Windows.Forms.GroupBox grbAll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFinishLending;
        private System.Windows.Forms.TextBox txtFineForDefect;
        private System.Windows.Forms.Button btnLosingBook;
        private System.Windows.Forms.DataGridView dgvMembersBooks;
        private System.Windows.Forms.TextBox txtBookIdLending;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grbReturning;
        private System.Windows.Forms.GroupBox grbLending;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInfoOfDefect;
        private System.Windows.Forms.Button btnFineForDelayPaying;
        private System.Windows.Forms.CheckBox chb1;
        private System.Windows.Forms.ComboBox cmbChhoseCopy;
        private System.Windows.Forms.Label lblChooseCopy;
        private System.Windows.Forms.Button btnNextLending;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvHelpingLoanExtention;
        private System.Windows.Forms.Button btnShowMemberDetails;
        private System.Windows.Forms.RadioButton rdbCmb;
        private System.Windows.Forms.RadioButton rdbTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblShach2;
        private System.Windows.Forms.Label lblshach;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSumPreviousFine;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel3;
    }
}