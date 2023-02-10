using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronOcr;
using System.Windows.Forms;

namespace testocr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.AllowDrop = true;
            InitializeComponent();
            panel1.DragEnter += new DragEventHandler(Form1_DragEnter);
            panel1.DragDrop += new DragEventHandler(Form1_DragDrop);
            
        }

        void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files) Console.WriteLine(file);
            foreach (string file in files)
            {
                panel1.BackgroundImage = Image.FromFile(file);
                textBox1.Text = new IronTesseract().Read(file).Text;
            }
            // NuGet PM> Install-Package IronOcr
            
            
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            Panel destination = (Panel)sender;
            destination.BackgroundImage = (Bitmap)e.Data.GetData(typeof(Bitmap));
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                string nolose = file;
                //panel1.BackgroundImage = file;
            }
        }
    }
}
