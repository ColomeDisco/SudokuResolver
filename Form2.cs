using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testocr
{
    public partial class Form2 : Form
    {
        private int[,] inicial = new int[9, 9];
        private int[,] prova = new int[9, 9];
        private bool esvalid(int valor,int x,int y)
        {
            for (int i = 0; i < 9; i++)
            {
                if (i != x && prova[i, y] == valor)
                    return false;
            }
            for (int i = 0; i < 9; i++)
            {
                if (i != y && prova[x, i] == valor)
                    return false;
            }

        }
        public Form2()
        {
            InitializeComponent();
        }

        private void txt_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.LightGreen;
            ((TextBox)sender).SelectAll();
        }

        private void txt_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.txt1.Enter += new System.EventHandler(this.txt_Enter);
            this.txt2.Enter += new System.EventHandler(this.txt_Enter);
            this.txt3.Enter += new System.EventHandler(this.txt_Enter);
            this.txt4.Enter += new System.EventHandler(this.txt_Enter);
            this.txt5.Enter += new System.EventHandler(this.txt_Enter);
            this.txt6.Enter += new System.EventHandler(this.txt_Enter);
            this.txt7.Enter += new System.EventHandler(this.txt_Enter);
            this.txt8.Enter += new System.EventHandler(this.txt_Enter);
            this.txt9.Enter += new System.EventHandler(this.txt_Enter);
            this.txt10.Enter += new System.EventHandler(this.txt_Enter);
            this.txt11.Enter += new System.EventHandler(this.txt_Enter);
            this.txt12.Enter += new System.EventHandler(this.txt_Enter);
            this.txt13.Enter += new System.EventHandler(this.txt_Enter);
            this.txt14.Enter += new System.EventHandler(this.txt_Enter);
            this.txt15.Enter += new System.EventHandler(this.txt_Enter);
            this.txt16.Enter += new System.EventHandler(this.txt_Enter);
            this.txt17.Enter += new System.EventHandler(this.txt_Enter);
            this.txt18.Enter += new System.EventHandler(this.txt_Enter);
            this.txt19.Enter += new System.EventHandler(this.txt_Enter);
            this.txt20.Enter += new System.EventHandler(this.txt_Enter);
            this.txt21.Enter += new System.EventHandler(this.txt_Enter);
            this.txt22.Enter += new System.EventHandler(this.txt_Enter);
            this.txt23.Enter += new System.EventHandler(this.txt_Enter);
            this.txt24.Enter += new System.EventHandler(this.txt_Enter);
            this.txt25.Enter += new System.EventHandler(this.txt_Enter);
            this.txt26.Enter += new System.EventHandler(this.txt_Enter);
            this.txt27.Enter += new System.EventHandler(this.txt_Enter);
            this.txt28.Enter += new System.EventHandler(this.txt_Enter);
            this.txt29.Enter += new System.EventHandler(this.txt_Enter);
            this.txt30.Enter += new System.EventHandler(this.txt_Enter);
            this.txt31.Enter += new System.EventHandler(this.txt_Enter);
            this.txt32.Enter += new System.EventHandler(this.txt_Enter);
            this.txt33.Enter += new System.EventHandler(this.txt_Enter);
            this.txt34.Enter += new System.EventHandler(this.txt_Enter);
            this.txt35.Enter += new System.EventHandler(this.txt_Enter);
            this.txt36.Enter += new System.EventHandler(this.txt_Enter);
            this.txt37.Enter += new System.EventHandler(this.txt_Enter);
            this.txt38.Enter += new System.EventHandler(this.txt_Enter);
            this.txt39.Enter += new System.EventHandler(this.txt_Enter);
            this.txt40.Enter += new System.EventHandler(this.txt_Enter);
            this.txt41.Enter += new System.EventHandler(this.txt_Enter);
            this.txt42.Enter += new System.EventHandler(this.txt_Enter);
            this.txt43.Enter += new System.EventHandler(this.txt_Enter);
            this.txt44.Enter += new System.EventHandler(this.txt_Enter);
            this.txt45.Enter += new System.EventHandler(this.txt_Enter);
            this.txt46.Enter += new System.EventHandler(this.txt_Enter);
            this.txt47.Enter += new System.EventHandler(this.txt_Enter);
            this.txt48.Enter += new System.EventHandler(this.txt_Enter);
            this.txt49.Enter += new System.EventHandler(this.txt_Enter);
            this.txt50.Enter += new System.EventHandler(this.txt_Enter);
            this.txt51.Enter += new System.EventHandler(this.txt_Enter);
            this.txt52.Enter += new System.EventHandler(this.txt_Enter);
            this.txt53.Enter += new System.EventHandler(this.txt_Enter);
            this.txt54.Enter += new System.EventHandler(this.txt_Enter);
            this.txt55.Enter += new System.EventHandler(this.txt_Enter);
            this.txt56.Enter += new System.EventHandler(this.txt_Enter);
            this.txt57.Enter += new System.EventHandler(this.txt_Enter);
            this.txt58.Enter += new System.EventHandler(this.txt_Enter);
            this.txt59.Enter += new System.EventHandler(this.txt_Enter);
            this.txt60.Enter += new System.EventHandler(this.txt_Enter);
            this.txt61.Enter += new System.EventHandler(this.txt_Enter);
            this.txt62.Enter += new System.EventHandler(this.txt_Enter);
            this.txt63.Enter += new System.EventHandler(this.txt_Enter);
            this.txt64.Enter += new System.EventHandler(this.txt_Enter);
            this.txt65.Enter += new System.EventHandler(this.txt_Enter);
            this.txt66.Enter += new System.EventHandler(this.txt_Enter);
            this.txt67.Enter += new System.EventHandler(this.txt_Enter);
            this.txt68.Enter += new System.EventHandler(this.txt_Enter);
            this.txt69.Enter += new System.EventHandler(this.txt_Enter);
            this.txt70.Enter += new System.EventHandler(this.txt_Enter);
            this.txt71.Enter += new System.EventHandler(this.txt_Enter);
            this.txt72.Enter += new System.EventHandler(this.txt_Enter);
            this.txt73.Enter += new System.EventHandler(this.txt_Enter);
            this.txt74.Enter += new System.EventHandler(this.txt_Enter);
            this.txt75.Enter += new System.EventHandler(this.txt_Enter);
            this.txt76.Enter += new System.EventHandler(this.txt_Enter);
            this.txt77.Enter += new System.EventHandler(this.txt_Enter);
            this.txt78.Enter += new System.EventHandler(this.txt_Enter);
            this.txt79.Enter += new System.EventHandler(this.txt_Enter);
            this.txt80.Enter += new System.EventHandler(this.txt_Enter);
            this.txt81.Enter += new System.EventHandler(this.txt_Enter);

            this.txt1.Leave += new System.EventHandler(this.txt_Leave);
            this.txt2.Leave += new System.EventHandler(this.txt_Leave);
            this.txt3.Leave += new System.EventHandler(this.txt_Leave);
            this.txt4.Leave += new System.EventHandler(this.txt_Leave);
            this.txt5.Leave += new System.EventHandler(this.txt_Leave);
            this.txt6.Leave += new System.EventHandler(this.txt_Leave);
            this.txt7.Leave += new System.EventHandler(this.txt_Leave);
            this.txt8.Leave += new System.EventHandler(this.txt_Leave);
            this.txt9.Leave += new System.EventHandler(this.txt_Leave);
            this.txt10.Leave += new System.EventHandler(this.txt_Leave);
            this.txt11.Leave += new System.EventHandler(this.txt_Leave);
            this.txt12.Leave += new System.EventHandler(this.txt_Leave);
            this.txt13.Leave += new System.EventHandler(this.txt_Leave);
            this.txt14.Leave += new System.EventHandler(this.txt_Leave);
            this.txt15.Leave += new System.EventHandler(this.txt_Leave);
            this.txt16.Leave += new System.EventHandler(this.txt_Leave);
            this.txt17.Leave += new System.EventHandler(this.txt_Leave);
            this.txt18.Leave += new System.EventHandler(this.txt_Leave);
            this.txt19.Leave += new System.EventHandler(this.txt_Leave);
            this.txt20.Leave += new System.EventHandler(this.txt_Leave);
            this.txt21.Leave += new System.EventHandler(this.txt_Leave);
            this.txt22.Leave += new System.EventHandler(this.txt_Leave);
            this.txt23.Leave += new System.EventHandler(this.txt_Leave);
            this.txt24.Leave += new System.EventHandler(this.txt_Leave);
            this.txt25.Leave += new System.EventHandler(this.txt_Leave);
            this.txt26.Leave += new System.EventHandler(this.txt_Leave);
            this.txt27.Leave += new System.EventHandler(this.txt_Leave);
            this.txt28.Leave += new System.EventHandler(this.txt_Leave);
            this.txt29.Leave += new System.EventHandler(this.txt_Leave);
            this.txt30.Leave += new System.EventHandler(this.txt_Leave);
            this.txt31.Leave += new System.EventHandler(this.txt_Leave);
            this.txt32.Leave += new System.EventHandler(this.txt_Leave);
            this.txt33.Leave += new System.EventHandler(this.txt_Leave);
            this.txt34.Leave += new System.EventHandler(this.txt_Leave);
            this.txt35.Leave += new System.EventHandler(this.txt_Leave);
            this.txt36.Leave += new System.EventHandler(this.txt_Leave);
            this.txt37.Leave += new System.EventHandler(this.txt_Leave);
            this.txt38.Leave += new System.EventHandler(this.txt_Leave);
            this.txt39.Leave += new System.EventHandler(this.txt_Leave);
            this.txt40.Leave += new System.EventHandler(this.txt_Leave);
            this.txt41.Leave += new System.EventHandler(this.txt_Leave);
            this.txt42.Leave += new System.EventHandler(this.txt_Leave);
            this.txt43.Leave += new System.EventHandler(this.txt_Leave);
            this.txt44.Leave += new System.EventHandler(this.txt_Leave);
            this.txt45.Leave += new System.EventHandler(this.txt_Leave);
            this.txt46.Leave += new System.EventHandler(this.txt_Leave);
            this.txt47.Leave += new System.EventHandler(this.txt_Leave);
            this.txt48.Leave += new System.EventHandler(this.txt_Leave);
            this.txt49.Leave += new System.EventHandler(this.txt_Leave);
            this.txt50.Leave += new System.EventHandler(this.txt_Leave);
            this.txt51.Leave += new System.EventHandler(this.txt_Leave);
            this.txt52.Leave += new System.EventHandler(this.txt_Leave);
            this.txt53.Leave += new System.EventHandler(this.txt_Leave);
            this.txt54.Leave += new System.EventHandler(this.txt_Leave);
            this.txt55.Leave += new System.EventHandler(this.txt_Leave);
            this.txt56.Leave += new System.EventHandler(this.txt_Leave);
            this.txt57.Leave += new System.EventHandler(this.txt_Leave);
            this.txt58.Leave += new System.EventHandler(this.txt_Leave);
            this.txt59.Leave += new System.EventHandler(this.txt_Leave);
            this.txt60.Leave += new System.EventHandler(this.txt_Leave);
            this.txt61.Leave += new System.EventHandler(this.txt_Leave);
            this.txt62.Leave += new System.EventHandler(this.txt_Leave);
            this.txt63.Leave += new System.EventHandler(this.txt_Leave);
            this.txt64.Leave += new System.EventHandler(this.txt_Leave);
            this.txt65.Leave += new System.EventHandler(this.txt_Leave);
            this.txt66.Leave += new System.EventHandler(this.txt_Leave);
            this.txt67.Leave += new System.EventHandler(this.txt_Leave);
            this.txt68.Leave += new System.EventHandler(this.txt_Leave);
            this.txt69.Leave += new System.EventHandler(this.txt_Leave);
            this.txt70.Leave += new System.EventHandler(this.txt_Leave);
            this.txt71.Leave += new System.EventHandler(this.txt_Leave);
            this.txt72.Leave += new System.EventHandler(this.txt_Leave);
            this.txt73.Leave += new System.EventHandler(this.txt_Leave);
            this.txt74.Leave += new System.EventHandler(this.txt_Leave);
            this.txt75.Leave += new System.EventHandler(this.txt_Leave);
            this.txt76.Leave += new System.EventHandler(this.txt_Leave);
            this.txt77.Leave += new System.EventHandler(this.txt_Leave);
            this.txt78.Leave += new System.EventHandler(this.txt_Leave);
            this.txt79.Leave += new System.EventHandler(this.txt_Leave);
            this.txt80.Leave += new System.EventHandler(this.txt_Leave);
            this.txt81.Leave += new System.EventHandler(this.txt_Leave);

            this.txt1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt10.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt11.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt12.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt13.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt14.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt15.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt16.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt17.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt18.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt19.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt20.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt21.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt22.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt23.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt24.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt25.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt26.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt27.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt28.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt29.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt30.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt31.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt32.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt33.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt34.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt35.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt36.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt37.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt38.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt39.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt40.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt41.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt42.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt43.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt44.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt45.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt46.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt47.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt48.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt49.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt50.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt51.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt52.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt53.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt54.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt55.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt56.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt57.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt58.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt59.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt60.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt61.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt62.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt63.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt64.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt65.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt66.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt67.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt68.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt69.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt70.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt71.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt72.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt73.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt74.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt75.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt76.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt77.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt78.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt79.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt80.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt81.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);

            this.txt1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
        }

        private void txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (this.GetNextControl(ActiveControl, true) != null)
                {
                    e.Handled = true;
                    this.GetNextControl(ActiveControl, true).Focus();

                }
            }
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
