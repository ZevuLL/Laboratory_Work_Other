using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _6
{
    public partial class Form1 : Form
    {
        Figure MainFigure = new Figure();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            { MainFigure.Volume(); }
            else
            { MainFigure.ClearVolume(); }

            if (checkBox2.Checked == true)
            { MainFigure.Surface_Area(); }
            else
            { MainFigure.ClearSurface_Area(); }
            if (checkBox1.Checked == false && checkBox2.Checked == false)
            {
                if (radioButton2.Checked == true)
                { MainFigure.Volume(); }
                else
                { MainFigure.ClearVolume(); }

                if (radioButton1.Checked == true)
                { MainFigure.Surface_Area(); }
                else
                { MainFigure.ClearSurface_Area(); }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString("dd MMMM yyyy HH:mm:ss dddd");
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                MainFigure.Read(Convert.ToDouble(textBox1.Text));

            }
            catch
            {
                //MessageBox.Show("Введи число!1!!!!1!1!!");
                textBox1.Clear();

            }
            
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            сохранитьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.DefaultExt = ".txt";
            saveFile.Filter = "Test files|*.txt";
            if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFile.FileName.Length > 0)
            {
                using (StreamWriter sw = new StreamWriter(saveFile.FileName, true))
                {
                    sw.WriteLine(MainFigure.Print());
                    sw.Close();
                }
            }
        }


        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            /*сохранитьToolStripMenuItem_Click(sender, e);
            выходToolStripMenuItem_Click(sender, e);
            показатьToolStripMenuItem_Click(sender, e);
            условиеЗадачиToolStripMenuItem_Click(sender, e);
            оПрограммеToolStripMenuItem_Click(sender, e);*/
        }

        private void показатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MainFigure.Print());
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void условиеЗадачиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Приложение для расчёта параметров усечённого тетраэдра. Главная форма содержит: элемент для ввода значений длины ребра; группу элементов для выбора вычислений объёма и площади поверхности усечённого тетраэдра.");
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Сделал Иван Мягкий, 15 вариант");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            сохранитьToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            выходToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            показатьToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            условиеЗадачиToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            оПрограммеToolStripMenuItem_Click(sender, e);
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString("dd MMMM yyyy HH:mm:ss dddd");
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
