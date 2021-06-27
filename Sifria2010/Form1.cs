using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sifria2010.GUI;

namespace Sifria2010
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DAL.DAL.ConnectToDB();
        }

        private void הכולToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMembersTable f = new FrmMembersTable();
            f.Show();
        }

        private void הוסףמנויToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMember f = new FrmMember(statusKind.add);
            f.Show();
        }

        

        private void מחקמנויToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMember f = new FrmMember(statusKind.delete);
            f.Show();
        }

        private void עדכןפרטימנויToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMember f = new FrmMember(statusKind.update);
            f.Show();
        }

        private void הכולToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmWritersTable f = new FrmWritersTable();
            f.Show();
        }

        

        private void מחיקתסופרToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmWriter f = new FrmWriter(statusKind.delete);
            f.Show();
        }

        private void הוספתסופרToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmWriter f = new FrmWriter(statusKind.add);
            f.Show();
        }

        private void הצגToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBooksTable f = new frmBooksTable();
            f.Show();
        }

        private void הוסףספרToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBooks f = new frmBooks(statusKind.add);
            f.Show();
        }

        private void מחקספרToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCopies f = new frmCopies(statusKind.delete);
            f.Show();
        }

        private void עדכןפרטיספרToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBooks f = new frmBooks(statusKind.update);
            f.Show();
        }

        private void הוסףתוכןספרToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmContents f = new FrmContents(statusKind.add);
            f.Show();
        }

        private void מחקתוכןספרToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmContents f = new FrmContents(statusKind.delete);
            f.Show();
        }

        private void רשימתהתכניםToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmContentsTable f = new FrmContentsTable();
            f.Show();
        }

        private void הצגהכולToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmJanersTable f = new FrmJanersTable();
            f.Show();
        }

        private void הוסףזאנרספרToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmJanersSabject f = new FrmJanersSabject(statusKind.add);
            f.Show();
        }

        private void מחקזאנרספרToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmJanersSabject f = new FrmJanersSabject(statusKind.delete);
            f.Show();
        }

        private void הצגהכולToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmLibriansTable f = new FrmLibriansTable();
            f.Show();
     
        }

        private void הוסףספרניתToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLibirians f = new FrmLibirians(statusKind.add);
            f.Show();
        }

        private void מחקספרניתToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLibirians f = new FrmLibirians(statusKind.delete);
            f.Show();
        }

        private void עדכןספרניתToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLibirians f = new FrmLibirians(statusKind.update);
            f.Show();
        }

        private void הכולToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmBooksTable f = new frmBooksTable();
            f.Show();
        }

        private void נתונימערכתToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInformation f = new FrmInformation(statusKind.update);
            f.Show();
        }

        private void הצToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCopiesTable f = new frmCopiesTable();
            f.Show();
        }

        private void הוסףעותקלספרToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCopies f = new frmCopies(statusKind.add);
            f.Show();
        }

        private void מחקעותקספרToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCopies f = new frmCopies(statusKind.delete);
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmFinishLending f = new FrmFinishLending();
            f.Show();
        }

        private void שלםקנסToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFinePaying f = new frmFinePaying(statusKind.add);
            f.Show();
        }

        private void שנהקנסשכברניגבהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFinePaying f = new frmFinePaying(statusKind.update);
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmMember f = new FrmMember(statusKind.add);
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmBooks f = new frmBooks(statusKind.add);
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmLibirians f = new FrmLibirians(statusKind.add);
            f.Show();
        }

        private void הצגאתכלההשאלותוההחזרותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAllLending f = new frmAllLending();
            f.Show();
        }

        private void בצעהשאלהאוהחזרהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFinishLending f = new FrmFinishLending();
            f.Show();
        }

        private void הצגאתכלהתשלומיםToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAllFinePayingTable f = new frmAllFinePayingTable();
            f.Show();
        }

        private void הצגפרטימנויToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMember f = new FrmMember(statusKind.show);
            f.Show();
        }

        private void הצגפרטיספרToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBooks f = new frmBooks(statusKind.show);
            f.Show();
        }

        private void המנוייםשישלהםחובToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMemberWithFine f = new frmMemberWithFine();
            f.Show();
        }

        private void חפשמנויעישםועירToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void עיתעודתזהותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearchMemberById f = new frmSearchMemberById();
            f.Show();
        }

        private void עישםומספרטלפוןToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearchMember f = new frmSearchMember();
            f.Show();
        }
    }
}
