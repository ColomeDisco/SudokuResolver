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
        private static bool atura = false;
        private bool esvalid(int valor,int x,int y)
        {
            if (x == 2 && y == 8 && valor ==6)
                Application.DoEvents();
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
            int inix = 0, iniy = 0;
            if (x < 3)
            {
                inix = 0;
            }
            else if (x < 6)
            {
                inix = 3;
            }
            else
                inix = 6;
            if (y < 3)
            {
                iniy = 0;
            }
            else if (y < 6)
            {
                iniy = 3;
            }
            else
                iniy = 6;
            for (int i = inix; i < inix + 3; i++)
            {
                for(int j = iniy; j < iniy + 3; j++)
                {
                    if (i!=x && j!=y)
                    {
                        if (prova[i, j] == valor)
                            return false;
                    }
                }

            }

            return true;
        }
        private void EmplenaInicial()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    prova[i, j] = 0;
                    inicial[i, j] = 0;
                }
            }
            if (!string.IsNullOrEmpty(txt1.Text)) inicial[0, 0] = Convert.ToInt32(txt1.Text);
            if (!string.IsNullOrEmpty(txt2.Text)) inicial[0, 1] = Convert.ToInt32(txt2.Text);
            if (!string.IsNullOrEmpty(txt3.Text)) inicial[0, 2] = Convert.ToInt32(txt3.Text);
            if (!string.IsNullOrEmpty(txt4.Text)) inicial[0, 3] = Convert.ToInt32(txt4.Text);
            if (!string.IsNullOrEmpty(txt5.Text)) inicial[0, 4] = Convert.ToInt32(txt5.Text);
            if (!string.IsNullOrEmpty(txt6.Text)) inicial[0, 5] = Convert.ToInt32(txt6.Text);
            if (!string.IsNullOrEmpty(txt7.Text)) inicial[0, 6] = Convert.ToInt32(txt7.Text);
            if (!string.IsNullOrEmpty(txt8.Text)) inicial[0, 7] = Convert.ToInt32(txt8.Text);
            if (!string.IsNullOrEmpty(txt9.Text)) inicial[0, 8] = Convert.ToInt32(txt9.Text);

            if (!string.IsNullOrEmpty(txt10.Text)) inicial[1, 0] = Convert.ToInt32(txt10.Text);
            if (!string.IsNullOrEmpty(txt11.Text)) inicial[1, 1] = Convert.ToInt32(txt11.Text);
            if (!string.IsNullOrEmpty(txt12.Text)) inicial[1, 2] = Convert.ToInt32(txt12.Text);
            if (!string.IsNullOrEmpty(txt13.Text)) inicial[1, 3] = Convert.ToInt32(txt13.Text);
            if (!string.IsNullOrEmpty(txt14.Text)) inicial[1, 4] = Convert.ToInt32(txt14.Text);
            if (!string.IsNullOrEmpty(txt15.Text)) inicial[1, 5] = Convert.ToInt32(txt15.Text);
            if (!string.IsNullOrEmpty(txt16.Text)) inicial[1, 6] = Convert.ToInt32(txt16.Text);
            if (!string.IsNullOrEmpty(txt17.Text)) inicial[1, 7] = Convert.ToInt32(txt17.Text);
            if (!string.IsNullOrEmpty(txt18.Text)) inicial[1, 8] = Convert.ToInt32(txt18.Text);

            if (!string.IsNullOrEmpty(txt19.Text)) inicial[2, 0] = Convert.ToInt32(txt19.Text);
            if (!string.IsNullOrEmpty(txt20.Text)) inicial[2, 1] = Convert.ToInt32(txt20.Text);
            if (!string.IsNullOrEmpty(txt21.Text)) inicial[2, 2] = Convert.ToInt32(txt21.Text);
            if (!string.IsNullOrEmpty(txt22.Text)) inicial[2, 3] = Convert.ToInt32(txt22.Text);
            if (!string.IsNullOrEmpty(txt23.Text)) inicial[2, 4] = Convert.ToInt32(txt23.Text);
            if (!string.IsNullOrEmpty(txt24.Text)) inicial[2, 5] = Convert.ToInt32(txt24.Text);
            if (!string.IsNullOrEmpty(txt25.Text)) inicial[2, 6] = Convert.ToInt32(txt25.Text);
            if (!string.IsNullOrEmpty(txt26.Text)) inicial[2, 7] = Convert.ToInt32(txt26.Text);
            if (!string.IsNullOrEmpty(txt27.Text)) inicial[2, 8] = Convert.ToInt32(txt27.Text);

            if (!string.IsNullOrEmpty(txt28.Text)) inicial[3, 0] = Convert.ToInt32(txt28.Text);
            if (!string.IsNullOrEmpty(txt29.Text)) inicial[3, 1] = Convert.ToInt32(txt29.Text);
            if (!string.IsNullOrEmpty(txt30.Text)) inicial[3, 2] = Convert.ToInt32(txt30.Text);
            if (!string.IsNullOrEmpty(txt31.Text)) inicial[3, 3] = Convert.ToInt32(txt31.Text);
            if (!string.IsNullOrEmpty(txt32.Text)) inicial[3, 4] = Convert.ToInt32(txt32.Text);
            if (!string.IsNullOrEmpty(txt33.Text)) inicial[3, 5] = Convert.ToInt32(txt33.Text);
            if (!string.IsNullOrEmpty(txt34.Text)) inicial[3, 6] = Convert.ToInt32(txt34.Text);
            if (!string.IsNullOrEmpty(txt35.Text)) inicial[3, 7] = Convert.ToInt32(txt35.Text);
            if (!string.IsNullOrEmpty(txt36.Text)) inicial[3, 8] = Convert.ToInt32(txt36.Text);

            if (!string.IsNullOrEmpty(txt37.Text)) inicial[4, 0] = Convert.ToInt32(txt37.Text);
            if (!string.IsNullOrEmpty(txt38.Text)) inicial[4, 1] = Convert.ToInt32(txt38.Text);
            if (!string.IsNullOrEmpty(txt39.Text)) inicial[4, 2] = Convert.ToInt32(txt39.Text);
            if (!string.IsNullOrEmpty(txt40.Text)) inicial[4, 3] = Convert.ToInt32(txt40.Text);
            if (!string.IsNullOrEmpty(txt41.Text)) inicial[4, 4] = Convert.ToInt32(txt41.Text);
            if (!string.IsNullOrEmpty(txt42.Text)) inicial[4, 5] = Convert.ToInt32(txt42.Text);
            if (!string.IsNullOrEmpty(txt43.Text)) inicial[4, 6] = Convert.ToInt32(txt43.Text);
            if (!string.IsNullOrEmpty(txt44.Text)) inicial[4, 7] = Convert.ToInt32(txt44.Text);
            if (!string.IsNullOrEmpty(txt45.Text)) inicial[4, 8] = Convert.ToInt32(txt45.Text);

            if (!string.IsNullOrEmpty(txt46.Text)) inicial[5, 0] = Convert.ToInt32(txt46.Text);
            if (!string.IsNullOrEmpty(txt47.Text)) inicial[5, 1] = Convert.ToInt32(txt47.Text);
            if (!string.IsNullOrEmpty(txt48.Text)) inicial[5, 2] = Convert.ToInt32(txt48.Text);
            if (!string.IsNullOrEmpty(txt49.Text)) inicial[5, 3] = Convert.ToInt32(txt49.Text);
            if (!string.IsNullOrEmpty(txt50.Text)) inicial[5, 4] = Convert.ToInt32(txt50.Text);
            if (!string.IsNullOrEmpty(txt51.Text)) inicial[5, 5] = Convert.ToInt32(txt51.Text);
            if (!string.IsNullOrEmpty(txt52.Text)) inicial[5, 6] = Convert.ToInt32(txt52.Text);
            if (!string.IsNullOrEmpty(txt53.Text)) inicial[5, 7] = Convert.ToInt32(txt53.Text);
            if (!string.IsNullOrEmpty(txt54.Text)) inicial[5, 8] = Convert.ToInt32(txt54.Text);

            if (!string.IsNullOrEmpty(txt55.Text)) inicial[6, 0] = Convert.ToInt32(txt55.Text);
            if (!string.IsNullOrEmpty(txt56.Text)) inicial[6, 1] = Convert.ToInt32(txt56.Text);
            if (!string.IsNullOrEmpty(txt57.Text)) inicial[6, 2] = Convert.ToInt32(txt57.Text);
            if (!string.IsNullOrEmpty(txt58.Text)) inicial[6, 3] = Convert.ToInt32(txt58.Text);
            if (!string.IsNullOrEmpty(txt59.Text)) inicial[6, 4] = Convert.ToInt32(txt59.Text);
            if (!string.IsNullOrEmpty(txt60.Text)) inicial[6, 5] = Convert.ToInt32(txt60.Text);
            if (!string.IsNullOrEmpty(txt61.Text)) inicial[6, 6] = Convert.ToInt32(txt61.Text);
            if (!string.IsNullOrEmpty(txt62.Text)) inicial[6, 7] = Convert.ToInt32(txt62.Text);
            if (!string.IsNullOrEmpty(txt63.Text)) inicial[6, 8] = Convert.ToInt32(txt63.Text);

            if (!string.IsNullOrEmpty(txt64.Text)) inicial[7, 0] = Convert.ToInt32(txt64.Text);
            if (!string.IsNullOrEmpty(txt65.Text)) inicial[7, 1] = Convert.ToInt32(txt65.Text);
            if (!string.IsNullOrEmpty(txt66.Text)) inicial[7, 2] = Convert.ToInt32(txt66.Text);
            if (!string.IsNullOrEmpty(txt67.Text)) inicial[7, 3] = Convert.ToInt32(txt67.Text);
            if (!string.IsNullOrEmpty(txt68.Text)) inicial[7, 4] = Convert.ToInt32(txt68.Text);
            if (!string.IsNullOrEmpty(txt69.Text)) inicial[7, 5] = Convert.ToInt32(txt69.Text);
            if (!string.IsNullOrEmpty(txt70.Text)) inicial[7, 6] = Convert.ToInt32(txt70.Text);
            if (!string.IsNullOrEmpty(txt71.Text)) inicial[7, 7] = Convert.ToInt32(txt71.Text);
            if (!string.IsNullOrEmpty(txt72.Text)) inicial[7, 8] = Convert.ToInt32(txt72.Text);

            if (!string.IsNullOrEmpty(txt73.Text)) inicial[8, 0] = Convert.ToInt32(txt73.Text);
            if (!string.IsNullOrEmpty(txt74.Text)) inicial[8, 1] = Convert.ToInt32(txt74.Text);
            if (!string.IsNullOrEmpty(txt75.Text)) inicial[8, 2] = Convert.ToInt32(txt75.Text);
            if (!string.IsNullOrEmpty(txt76.Text)) inicial[8, 3] = Convert.ToInt32(txt76.Text);
            if (!string.IsNullOrEmpty(txt77.Text)) inicial[8, 4] = Convert.ToInt32(txt77.Text);
            if (!string.IsNullOrEmpty(txt78.Text)) inicial[8, 5] = Convert.ToInt32(txt78.Text);
            if (!string.IsNullOrEmpty(txt79.Text)) inicial[8, 6] = Convert.ToInt32(txt79.Text);
            if (!string.IsNullOrEmpty(txt80.Text)) inicial[8, 7] = Convert.ToInt32(txt80.Text);
            if (!string.IsNullOrEmpty(txt81.Text)) inicial[8, 8] = Convert.ToInt32(txt81.Text);

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    prova[i, j] = inicial[i, j];
                }
            }
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void txt_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.LightGreen;
            ((TextBox)sender).Text = "";
        }

        private void txt_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
            if (!string.IsNullOrEmpty(((TextBox)sender).Text))
                ((TextBox)sender).BackColor = Color.LightPink;
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {

                tb.Enter += new System.EventHandler(this.txt_Enter);
                tb.Leave += new System.EventHandler(this.txt_Leave);
                tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            }


         
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

        private void button1_Click(object sender, EventArgs e)
        {
            EmplenaInicial();
            bool possible= Calcula(0,0,1);
            atura = false;
        }
        private  bool  Calcula(int x, int y, int level)
        {
            bool final = false;
            if (inicial[x, y] == 0)
            {
                if (level == 4 )
                    Application.DoEvents();

                for (int a = 1; a < 10; a++)
                {
                    if (esvalid(a, x, y))
                    {
                        prova[x, y] = a;
                        Pinta(x, y, a.ToString());
                        if (x == 8 && y == 8)
                        {
                            return true;
                        }

                        //seguent element
                        if (y < 8)
                            y++;
                        else
                        {
                            if (x < 8)
                            {
                                x++;
                                y = 0;
                            }

                        }
                        if (!atura)
                           final = Calcula(x, y,level+1);
                        if (!final && inicial[x, y] == 0)
                        {
                            prova[x, y] = 0;
                            Pinta(x, y, "");
                            //restar element
                            
                            if (y > 0)
                                y--;
                            else if (x>0)
                            {
                                x = x - 1;
                                y = 8;
                            }
                            //return final;
                           
                        }
                        else
                        {
                            if (!final)
                            {
                                if (y > 0)
                                    y--;
                                else if (x > 0)
                                {
                                    x = x - 1;
                                    y = 8;
                                }
                            }
                            else
                                return final;
                        }
                            


                    }

                }
                prova[x, y] = 0;
                Pinta(x, y, "");
                return false;
            }
            else
            {
                if (x == 8 && y == 8)
                {
                    return true;
                }

                //seguent element
                if (y < 8)
                    y++;
                else
                {
                    if (x < 8)
                    {
                        x++;
                        y = 0;
                    }

                }
                if (!atura)
                    final = Calcula(x, y,level+1);
                if (!final && inicial[x, y] == 0)
                {
                    prova[x, y] = 0;
                    Pinta(x, y, "");
                    //restar element
                    if (y > 0)
                        y--;
                    else if (x > 0)
                    {
                        x = x - 1;
                        y = 8;
                    }
                    return final;

                }
                else
                    return final;
            }

            return final;
        }
        private void Pinta(int x, int y, string valor)
        {
            int num = x * 9 + y + 1;
            //System.Threading.Thread.Sleep(1);
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                Application.DoEvents();
                if (tb.Name=="txt"+num.ToString())
                {
                    tb.Text = valor;
                }
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                if (tb.BackColor != Color.LightPink)
                {
                    Application.DoEvents();
                    tb.Text = "";
                    tb.BackColor = Color.White;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            atura = true;
        }
    }
}
