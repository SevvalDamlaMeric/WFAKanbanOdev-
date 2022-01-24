
namespace WFAKanbanOdevı
{
    partial class KanbanBoard
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
            this.lstDoing = new System.Windows.Forms.ListBox();
            this.lstDone = new System.Windows.Forms.ListBox();
            this.lstToDo = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblKarakter = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstDoing
            // 
            this.lstDoing.AllowDrop = true;
            this.lstDoing.BackColor = System.Drawing.Color.Aqua;
            this.lstDoing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstDoing.ForeColor = System.Drawing.Color.Magenta;
            this.lstDoing.FormattingEnabled = true;
            this.lstDoing.ItemHeight = 16;
            this.lstDoing.Location = new System.Drawing.Point(209, 40);
            this.lstDoing.Name = "lstDoing";
            this.lstDoing.Size = new System.Drawing.Size(212, 260);
            this.lstDoing.TabIndex = 1;
            this.lstDoing.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox_DragDrop);
            this.lstDoing.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox_DragEnter);
            this.lstDoing.DragOver += new System.Windows.Forms.DragEventHandler(this.listBox_DragOver);
            this.lstDoing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDown);
            // 
            // lstDone
            // 
            this.lstDone.AllowDrop = true;
            this.lstDone.BackColor = System.Drawing.Color.Gold;
            this.lstDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstDone.ForeColor = System.Drawing.Color.Magenta;
            this.lstDone.FormattingEnabled = true;
            this.lstDone.ItemHeight = 16;
            this.lstDone.Location = new System.Drawing.Point(446, 40);
            this.lstDone.Name = "lstDone";
            this.lstDone.Size = new System.Drawing.Size(208, 260);
            this.lstDone.TabIndex = 2;
            this.lstDone.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox_DragDrop);
            this.lstDone.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox_DragEnter);
            this.lstDone.DragOver += new System.Windows.Forms.DragEventHandler(this.listBox_DragOver);
            this.lstDone.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDown);
            // 
            // lstToDo
            // 
            this.lstToDo.AllowDrop = true;
            this.lstToDo.BackColor = System.Drawing.Color.Chartreuse;
            this.lstToDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstToDo.ForeColor = System.Drawing.Color.Magenta;
            this.lstToDo.FormattingEnabled = true;
            this.lstToDo.ItemHeight = 16;
            this.lstToDo.Location = new System.Drawing.Point(1, 40);
            this.lstToDo.Name = "lstToDo";
            this.lstToDo.Size = new System.Drawing.Size(182, 260);
            this.lstToDo.TabIndex = 3;
            this.lstToDo.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox_DragDrop);
            this.lstToDo.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox_DragEnter);
            this.lstToDo.DragOver += new System.Windows.Forms.DragEventHandler(this.listBox_DragOver);
            this.lstToDo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDown);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(178, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 260);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(418, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 260);
            this.label2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 361);
            this.textBox1.MaxLength = 140;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 57);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblKarakter
            // 
            this.lblKarakter.AutoSize = true;
            this.lblKarakter.Location = new System.Drawing.Point(9, 330);
            this.lblKarakter.Name = "lblKarakter";
            this.lblKarakter.Size = new System.Drawing.Size(113, 13);
            this.lblKarakter.TabIndex = 7;
            this.lblKarakter.Text = "Kalan Karakter Sayısı :";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.LightSalmon;
            this.btnEkle.Location = new System.Drawing.Point(181, 325);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Ekle ";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(8, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "TODO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(220, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "DOING";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(462, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "DONE";
            // 
            // KanbanBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(653, 447);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lblKarakter);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstToDo);
            this.Controls.Add(this.lstDone);
            this.Controls.Add(this.lstDoing);
            this.Name = "KanbanBoard";
            this.Text = "KanbanBoard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstDoing;
        private System.Windows.Forms.ListBox lstDone;
        private System.Windows.Forms.ListBox lstToDo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblKarakter;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}