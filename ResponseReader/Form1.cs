using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace ResponseReader
{
    /*  Creado por: Diego Ivan Perez Michel, Matricula: 2013-1488
     **/
    public partial class Form1 : Form
    {

        private WebClient conexion;
 
        public Form1()
        {
            conexion = new WebClient();

            InitializeComponent();

            //Asi se abrira con mi matricula por defecto
            EstablecerTexto();

            
        }

        private void boton_Click(object sender, EventArgs e)
        {
            EstablecerTexto(campoEntrada.Text);
        }

        public void EstablecerTexto() 
        {
            EstablecerTexto("20131488");
        }

        public void EstablecerTexto(string entrada)
        {

            try
            {

                if(!(entrada.Equals("") || entrada == null))
                {
                    //Si ya contiene texto, lo remueve
                    if (panel.HasChildren)
                        panel.Controls.Clear();

                    mensaje.Text = "Digite su matricula";
                    string respuesta = conexion.DownloadString(string.Format("http://adamix.net/practica/?m=sof-001&t=8&e={0}&op=AbrirPrograma", entrada));

                    Caracteres caracteres = new Caracteres();

                    //Valor de Prueba en Debug
                   //string respuesta = "20131488";

                    foreach (char letra in respuesta)
                    {
                        switch (letra.ToString().ToUpper()[0])
                        {
                            case '0':
                                this.panel.Controls.Add(caracteres.No0(letra));
                                break;
                            case '1':
                                this.panel.Controls.Add(caracteres.No1(letra));
                                break;
                            case '2':
                                this.panel.Controls.Add(caracteres.No2(letra));
                                break;
                            case '3':
                                this.panel.Controls.Add(caracteres.No3(letra));
                                break;
                            case '4':
                                this.panel.Controls.Add(caracteres.No4(letra));
                                break;
                            case '5':
                                this.panel.Controls.Add(caracteres.No5(letra));
                                break;
                            case '6':
                                this.panel.Controls.Add(caracteres.No6(letra));
                                break;
                            case '7':
                                this.panel.Controls.Add(caracteres.No7(letra));
                                break;
                            case '8':
                                this.panel.Controls.Add(caracteres.No8(letra));
                                break;
                            case '9':
                                this.panel.Controls.Add(caracteres.No9(letra));
                                break;
                        }
                    }
                }
                else
                {
                    mensaje.Text = "Entrada no valida, debe digitar una matricula";
                }
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(WebException ex)
            {
                mensaje.Text = "Hubo un problema con la conexion a internet";
                mensaje.BackColor = Color.Red;
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
