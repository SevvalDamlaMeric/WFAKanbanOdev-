using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAKanbanOdevı
{
    public partial class KanbanBoard : Form
    {
        public KanbanBoard()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int maxSinir = textBox1.TextLength;
            lblKarakter.Text = "Kalan Karakter Sayısı : " + (textBox1.MaxLength - textBox1.TextLength).ToString();
            if (maxSinir==textBox1.MaxLength)
            {
                MessageBox.Show("Karakter Sayısı Sınırına Ulaşıldı!");
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                lstToDo.Items.Add(textBox1.Text);
            }
            
        }

        private void listBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
                e.Effect = DragDropEffects.Move;

        }

        private void listBox_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
                e.Effect = DragDropEffects.All;
        }

        ListBox listbox_Item_Alinan;
        ListBox lstbox_Item_Birakilan;
        int Listbox_Index = 0;

        private void listBox_MouseDown(object sender, MouseEventArgs e)
        {
            listbox_Item_Alinan = sender as ListBox;
            Point kor_nokta = new Point(e.X, e.Y);
            Listbox_Index = listbox_Item_Alinan.IndexFromPoint(kor_nokta);
            if (Listbox_Index == -1)
                return;
            if (e.Button == MouseButtons.Left)
                listbox_Item_Alinan.DoDragDrop(listbox_Item_Alinan.Items[Listbox_Index].ToString(), DragDropEffects.All);
        }

        private void listBox_DragDrop(object sender, DragEventArgs e)
        {
            lstbox_Item_Birakilan = sender as ListBox;
            lstbox_Item_Birakilan.Items.Add(listbox_Item_Alinan.Items[Listbox_Index]);
            listbox_Item_Alinan.Items.Remove(listbox_Item_Alinan.Items[Listbox_Index]);
        }
    }
}
