using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAKanbanOdevı
{
    public partial class MDI : Form
    {
        Form frm = new Form();

        public MDI()
        {
            InitializeComponent();
        }

        //private void ShowNewForm(object sender, EventArgs e)
        //{
        //    Form childForm = new Form();
        //    childForm.MdiParent = this;
        //    childForm.Text = "Window " + childFormNumber++;
        //    childForm.Show();
        //}
        private void addKanbanBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KanbanBoard kb = new KanbanBoard();
            kb.MdiParent = this;
            kb.Show();
        }
    }
}
