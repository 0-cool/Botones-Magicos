using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResponseReader
{
    /*  Creado por: Diego Ivan Perez Michel, Matricula: 2013-1488
     *
     *  En esta Clase contendra el alfabeto;
     * */
    public class Caracteres
    {
        //Contiene a todas las letras
        private Panel[] caracteres = new Panel[10];

        //Retorna los caracteres
        public Panel[] GetCaracteres()
        {
        	return this.caracteres;
        }

        //0
        public Panel No0(char letra)
        {
            caracteres[0] = new Panel();
            caracteres[0].Size = new Size(75, 125);
            caracteres[0].BackColor = Color.DeepSkyBlue;

            int i = 0;
            while (i <= 125)
            {
                Button pixel = new Button();
                pixel.Size = new Size(25, 25);
                pixel.Location = new Point(0, i);
                pixel.ForeColor = Color.DarkGreen;
                pixel.Text = letra.ToString();

                caracteres[0].Controls.Add(pixel);
                i += 25;
            }

            i = 0;
            while (i <= 125)
            {
                Button pixel = new Button();
                pixel.Size = new Size(25, 25);
                pixel.Location = new Point(50,i);
                pixel.ForeColor = Color.DarkGreen;
                pixel.Text = letra.ToString();

                caracteres[0].Controls.Add(pixel);
                i += 25;
            }

            Button pixelUp = new Button();
            pixelUp.Size = new Size(25, 25);
            pixelUp.Location = new Point(25, 0);
            pixelUp.ForeColor = Color.DarkGreen;
            pixelUp.Text = letra.ToString();
            caracteres[0].Controls.Add(pixelUp);

            Button pixelBottom = new Button();
            pixelBottom.Size = new Size(25, 25);
            pixelBottom.Location = new Point(25, 100);
            pixelBottom.ForeColor = Color.DarkGreen;
            pixelBottom.Text = letra.ToString();

            caracteres[0].Controls.Add(pixelBottom);

            return caracteres[0];
        }

        //1
        public Panel No1(char letra)
        {
            caracteres[1] = new Panel();
            caracteres[1].Size = new Size(25, 125);
            caracteres[1].BackColor = Color.DeepSkyBlue;

            int i = 0;
            while(i <= 125)
            {
                Button pixel = new Button();
                pixel.Size = new Size(25, 25);
                pixel.Location = new Point(0,i);
                pixel.ForeColor = Color.DarkGreen;
                pixel.Text = letra.ToString();

                caracteres[1].Controls.Add(pixel);
                i+= 25;
            }
                
            return caracteres[1];
        }

        //2
        public Panel No2(char letra)
        {
            caracteres[2] = new Panel();
            caracteres[2].Size = new Size(75, 125);
            caracteres[2].BackColor = Color.DeepSkyBlue;
           
            int i = 0;
            while (i <= 50)
            {
                Button pixel = new Button();
                pixel.Text = letra.ToString();
                pixel.Size = new Size(25, 25);
                pixel.Location = new Point(i, 0);
                pixel.ForeColor = Color.DarkGreen;
                caracteres[2].Controls.Add(pixel);
                i += 25;
            }

            i = 0;
            while (i <= 50)
            {
                Button pixel = new Button();
                pixel.Text = letra.ToString();
                pixel.Size = new Size(25, 25);
                pixel.Location = new Point(50, i);
                pixel.ForeColor = Color.DarkGreen;
                caracteres[2].Controls.Add(pixel);
                i += 25;
            }

            i = 25;
            while (0 <= i)
            {
                Button pixel = new Button();
                pixel.Text = letra.ToString();
                pixel.Size = new Size(25, 25);
                pixel.Location = new Point(i,50);
                pixel.ForeColor = Color.DarkGreen;
                caracteres[2].Controls.Add(pixel);
                i -= 25;
            }
            
            while (0 <= i)
            {
                Button pixel = new Button();
                pixel.Text = letra.ToString();
                pixel.Size = new Size(25, 25);
                pixel.Location = new Point(i, 50);
                pixel.ForeColor = Color.Blue;
                caracteres[2].Controls.Add(pixel);
                i -= 25;
            }

            i = 0;
            while (0 <= i)
            {
                Button pixel = new Button();
                pixel.Text = letra.ToString();
                pixel.Size = new Size(25, 25);
                pixel.Location = new Point(i, 50);
                pixel.ForeColor = Color.DarkGreen;
                caracteres[2].Controls.Add(pixel);
                i -= 25;
            }

            i = 50;
            while (i <= 100)
            {
                Button pixel = new Button();
                pixel.Text = letra.ToString();
                pixel.Size = new Size(25, 25);
                pixel.Location = new Point(0, i);
                pixel.ForeColor = Color.DarkGreen;
                caracteres[2].Controls.Add(pixel);
                i += 25;
            }

            i = 25;
            while (i <= 50)
            {
                Button pixel = new Button();
                pixel.Text = letra.ToString();
                pixel.Size = new Size(25, 25);
                pixel.Location = new Point(i, 100);
                pixel.ForeColor = Color.DarkGreen;
                caracteres[2].Controls.Add(pixel);
                i += 25;
            }

            return caracteres[2];
        }

        //3
        public Panel No3(char letra)
        {
            caracteres[3] = new Panel();
            caracteres[3].Size = new Size(75, 125);
            caracteres[3].BackColor = Color.DeepSkyBlue;

            int i = 0;
            while (i <= 125)
            {
                Button pixel = new Button();
                pixel.Size = new Size(25, 25);
                pixel.Location = new Point(50, i);
                pixel.ForeColor = Color.DarkGreen;
                pixel.Text = letra.ToString();

                caracteres[3].Controls.Add(pixel);
                i += 25;
            }

            i = 0;
            while (i <= 25)
            {
                Button pixel = new Button();
                pixel.Size = new Size(25, 25);
                pixel.Location = new Point(i, 0);
                pixel.ForeColor = Color.DarkGreen;
                pixel.Text = letra.ToString();

                caracteres[3].Controls.Add(pixel);
                i += 25;
            }

            i = 0;
            while (i <= 25)
            {
                Button pixel = new Button();
                pixel.Size = new Size(25, 25);
                pixel.Location = new Point(i, 50);
                pixel.ForeColor = Color.DarkGreen;
                pixel.Text = letra.ToString();

                caracteres[3].Controls.Add(pixel);
                i += 25;
            }

            i = 0;
            while (i <= 25)
            {
                Button pixel = new Button();
                pixel.Size = new Size(25, 25);
                pixel.Location = new Point(i, 100);
                pixel.ForeColor = Color.DarkGreen;
                pixel.Text = letra.ToString();

                caracteres[3].Controls.Add(pixel);
                i += 25;
            }

            return caracteres[3];
        }

        //4
        public Panel No4(char letra)
        {
            caracteres[4] = new Panel();
            caracteres[4].Size = new Size(75, 125);
            caracteres[4].BackColor = Color.DeepSkyBlue;

            int i = 0;
            while (i <= 50)
            {
                Button pixel = new Button();
                pixel.Size = new Size(25, 25);
                pixel.Location = new Point(0, i);
                pixel.ForeColor = Color.DarkGreen;
                pixel.Text = letra.ToString();

                caracteres[4].Controls.Add(pixel);
                i += 25;
            }

            i = 0;
            while (i <= 100)
            {
                Button pixel = new Button();
                pixel.Size = new Size(25, 25);
                pixel.Location = new Point(50, i);
                pixel.ForeColor = Color.DarkGreen;
                pixel.Text = letra.ToString();

                caracteres[4].Controls.Add(pixel);
                i += 25;
            }

            Button pixelMiddle = new Button();
            pixelMiddle.Size = new Size(25, 25);
            pixelMiddle.Location = new Point(25, 50);
            pixelMiddle.ForeColor = Color.DarkGreen;
            pixelMiddle.Text = letra.ToString();
            caracteres[4].Controls.Add(pixelMiddle);

            return caracteres[4];
        }

        //5
        public Panel No5(char letra)
        {
            caracteres[5] = new Panel();
            caracteres[5].Size = new Size(75, 125);
            caracteres[5].BackColor = Color.DeepSkyBlue;

            int i = 0;
            while (i <= 50)
            {
                Button pixel = new Button();
                pixel.Size = new Size(25, 25);
                pixel.Location = new Point(i, 0);
                pixel.ForeColor = Color.DarkGreen;
                pixel.Text = letra.ToString();

                caracteres[5].Controls.Add(pixel);
                i += 25;
            }

            i = 0;
            while (i <= 50)
            {
                Button pixel = new Button();
                pixel.Size = new Size(25, 25);
                pixel.Location = new Point(0, i);
                pixel.ForeColor = Color.DarkGreen;
                pixel.Text = letra.ToString();

                caracteres[5].Controls.Add(pixel);
                i += 25;
            }

            i = 0;
            while (i <= 50)
            {
                Button pixel = new Button();
                pixel.Size = new Size(25, 25);
                pixel.Location = new Point(i, 50);
                pixel.ForeColor = Color.DarkGreen;
                pixel.Text = letra.ToString();

                caracteres[5].Controls.Add(pixel);
                i += 25;
            }

            i = 50;
            while (i <= 100)
            {
                Button pixel = new Button();
                pixel.Size = new Size(25, 25);
                pixel.Location = new Point(50, i);
                pixel.ForeColor = Color.DarkGreen;
                pixel.Text = letra.ToString();

                caracteres[5].Controls.Add(pixel);
                i += 25;
            }

            i = 0;
            while (i <= 25)
            {
                Button pixel = new Button();
                pixel.Size = new Size(25, 25);
                pixel.Location = new Point(i, 100);
                pixel.ForeColor = Color.DarkGreen;
                pixel.Text = letra.ToString();

                caracteres[5].Controls.Add(pixel);
                i += 25;
            }

            return caracteres[5];   
        }

        //6
        public Panel No6(char letra)
        {
            caracteres[6] = new Panel();
            caracteres[6].Size = new Size(75, 125);
            caracteres[6].BackColor = Color.DeepSkyBlue;

            int i = 0;
            while (i <= 125)
            {
                Button pixel = new Button();
                pixel.Size = new Size(25, 25);
                pixel.Location = new Point(0, i);
                pixel.ForeColor = Color.DarkGreen;
                pixel.Text = letra.ToString();

                caracteres[6].Controls.Add(pixel);
                i += 25;
            }

            i = 0;
            while (i <= 50)
            {
                Button pixel = new Button();
                pixel.Size = new Size(25, 25);
                pixel.Location = new Point(i, 0);
                pixel.ForeColor = Color.DarkGreen;
                pixel.Text = letra.ToString();

                caracteres[6].Controls.Add(pixel);
                i += 25;
            }

            i = 25;
            while (i <= 50)
            {
                Button pixel = new Button();
                pixel.Size = new Size(25, 25);
                pixel.Location = new Point(i, 50);
                pixel.ForeColor = Color.DarkGreen;
                pixel.Text = letra.ToString();

                caracteres[6].Controls.Add(pixel);
                i += 25;
            }

            i = 25;
            while (i <= 50)
            {
                Button pixel = new Button();
                pixel.Size = new Size(25, 25);
                pixel.Location = new Point(i, 50);
                pixel.ForeColor = Color.DarkGreen;
                pixel.Text = letra.ToString();

                caracteres[6].Controls.Add(pixel);
                i += 25;
            }

            i = 75;
            while (i <= 100)
            {
                Button pixel = new Button();
                pixel.Size = new Size(25, 25);
                pixel.Location = new Point(50, i);
                pixel.ForeColor = Color.DarkGreen;
                pixel.Text = letra.ToString();

                caracteres[6].Controls.Add(pixel);
                i += 25;
            }

            Button pixelBottom = new Button();
            pixelBottom.Size = new Size(25, 25);
            pixelBottom.Location = new Point(25, 100);
            pixelBottom.ForeColor = Color.DarkGreen;
            pixelBottom.Text = letra.ToString();
            caracteres[6].Controls.Add(pixelBottom);

            return caracteres[6];
        }

        //7
        public Panel No7(char letra)
        {
            caracteres[7] = new Panel();
            caracteres[7].Size = new Size(75, 125);
            caracteres[7].BackColor = Color.DeepSkyBlue;

            int i = 0;
            while (i <= 50)
            {
                Button pixel = new Button();
                pixel.Size = new Size(25, 25);
                pixel.Location = new Point(i, 0);
                pixel.ForeColor = Color.DarkGreen;
                pixel.Text = letra.ToString();

                caracteres[7].Controls.Add(pixel);
                i += 25;
            }

            i = 25;
            while (i <= 50)
            {
                Button pixel = new Button();
                pixel.Size = new Size(25, 25);
                pixel.Location = new Point(50, i);
                pixel.ForeColor = Color.DarkGreen;
                pixel.Text = letra.ToString();

                caracteres[7].Controls.Add(pixel);
                i += 25;
            }

            i = 50;
            while (i <= 100)
            {
                Button pixel = new Button();
                pixel.Size = new Size(25, 25);
                pixel.Location = new Point(25, i);
                pixel.ForeColor = Color.DarkGreen;
                pixel.Text = letra.ToString();

                caracteres[7].Controls.Add(pixel);
                i += 25;
            }

            return caracteres[7];
        }

        //8
        public Panel No8(char letra)
        {
            caracteres[8] = new Panel();
            caracteres[8].Size = new Size(75, 125);
            caracteres[8].BackColor = Color.DeepSkyBlue;

            int i = 0;
            while (i <= 125)
            {
                Button pixel = new Button();
                pixel.Size = new Size(25, 25);
                pixel.Location = new Point(0, i);
                pixel.ForeColor = Color.DarkGreen;
                pixel.Text = letra.ToString();

                caracteres[8].Controls.Add(pixel);
                i += 25;
            }

            i = 0;
            while (i <= 50)
            {
                Button pixel = new Button();
                pixel.Size = new Size(25, 25);
                pixel.Location = new Point(i, 0);
                pixel.ForeColor = Color.DarkGreen;
                pixel.Text = letra.ToString();

                caracteres[8].Controls.Add(pixel);
                i += 25;
            }

            i = 25;
            while (i <= 50)
            {
                Button pixel = new Button();
                pixel.Size = new Size(25, 25);
                pixel.Location = new Point(i, 50);
                pixel.ForeColor = Color.DarkGreen;
                pixel.Text = letra.ToString();

                caracteres[8].Controls.Add(pixel);
                i += 25;
            }

            i = 25;
            while (i <= 50)
            {
                Button pixel = new Button();
                pixel.Size = new Size(25, 25);
                pixel.Location = new Point(i, 50);
                pixel.ForeColor = Color.DarkGreen;
                pixel.Text = letra.ToString();

                caracteres[8].Controls.Add(pixel);
                i += 25;
            }

            i = 75;
            while (i <= 100)
            {
                Button pixel = new Button();
                pixel.Size = new Size(25, 25);
                pixel.Location = new Point(50, i);
                pixel.ForeColor = Color.DarkGreen;
                pixel.Text = letra.ToString();

                caracteres[8].Controls.Add(pixel);
                i += 25;
            }

            Button pixelBottom = new Button();
            pixelBottom.Size = new Size(25, 25);
            pixelBottom.Location = new Point(25, 100);
            pixelBottom.ForeColor = Color.DarkGreen;
            pixelBottom.Text = letra.ToString();
            caracteres[8].Controls.Add(pixelBottom);

            Button pixelEight = new Button();
            pixelEight.Size = new Size(25, 25);
            pixelEight.Location = new Point(50, 25);
            pixelEight.ForeColor = Color.DarkGreen;
            pixelEight.Text = letra.ToString();
            caracteres[8].Controls.Add(pixelEight);

            return caracteres[8];
        }

        //9
        public Panel No9(char letra)
        {
            caracteres[9] = new Panel();
            caracteres[9].Size = new Size(75, 125);
            caracteres[9].BackColor = Color.DeepSkyBlue;

            int i = 0;
            while (i <= 50)
            {
                Button pixel = new Button();
                pixel.Size = new Size(25, 25);
                pixel.Location = new Point(i, 0);
                pixel.ForeColor = Color.DarkGreen;
                pixel.Text = letra.ToString();

                caracteres[9].Controls.Add(pixel);
                i += 25;
            }

            i = 25;
            while (i <= 100)
            {
                Button pixel = new Button();
                pixel.Size = new Size(25, 25);
                pixel.Location = new Point(50, i);
                pixel.ForeColor = Color.DarkGreen;
                pixel.Text = letra.ToString();

                caracteres[9].Controls.Add(pixel);
                i += 25;
            }

            i = 0;
            while (i <= 25)
            {
                Button pixel = new Button();
                pixel.Size = new Size(25, 25);
                pixel.Location = new Point(i, 100);
                pixel.ForeColor = Color.DarkGreen;
                pixel.Text = letra.ToString();

                caracteres[9].Controls.Add(pixel);
                i += 25;
            }

            i = 25;
            while (i <= 50)
            {
                Button pixel = new Button();
                pixel.Size = new Size(25, 25);
                pixel.Location = new Point(0, i);
                pixel.ForeColor = Color.DarkGreen;
                pixel.Text = letra.ToString();

                caracteres[9].Controls.Add(pixel);
                i += 25;
            }

            Button pixelMiddle = new Button();
            pixelMiddle.Size = new Size(25, 25);
            pixelMiddle.Location = new Point(25, 50);
            pixelMiddle.ForeColor = Color.DarkGreen;
            pixelMiddle.Text = letra.ToString();
            caracteres[9].Controls.Add(pixelMiddle);

            return caracteres[9];
        }

    }
}   
