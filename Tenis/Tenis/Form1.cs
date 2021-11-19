using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tenis
{
    public partial class Form1 : Form
    {
        public static string[] saque = new string[] { "respuesta", "punto", "fuera", "respuesta"   };
        public int puntosj1 = 0, puntosj2 = 0, unidadesj1 = 0, unidadesj2 = 0;
        public int ganador = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnJugador1_Click(object sender, EventArgs e)
        {
            Random ran= new Random();
            int value = ran.Next(0, saque.Length);
            string res = saque[value];

            Calculo(1, res);
            MostrarDatos();
            MessageBox.Show(res);
        }

        private void btnJugador2_Click(object sender, EventArgs e)
        {
            Random ran = new Random();
            int value = ran.Next(0, saque.Length);
            string res = saque[value];

            Calculo(2, res);
            MostrarDatos();
            MessageBox.Show(res);
        }

        private void Calculo(int jugador, string res)
        {
            Boolean aumentoj1 = false;
            Boolean aumentoj2 = false;

            if (jugador==1)
            {
                switch (res)
                {
                    case "punto":
                        aumentoj1 = true;
                        break;
                    case "fuera":
                        aumentoj2 = true;
                        break;
                    case "respuesta":
                        return;
                }
            }
            else if (jugador==2)
            {
                switch (res)
                {
                    case "punto":
                        aumentoj2 = true;
                        break;
                    case "fuera":
                        aumentoj1 = true;
                        break;
                    case "respuesta":
                        return;
                }
            }

            if (aumentoj2)
            {
                unidadesj2 = unidadesj2 + 1;

                if (unidadesj2 > 3 )
                {
                    if ((unidadesj2 - unidadesj1) >= 2)
                    {
                        puntosj2++;
                        unidadesj1 = 0;
                        unidadesj2 = 0;
                        ganador = 2;
                    }
                    else
                    {
                        if (unidadesj2>4 && unidadesj1>4)
                        {
                            unidadesj1 = 3;
                            unidadesj2 = 3;
                        }
                    }
                }
            }

            if (aumentoj1)
            {
                unidadesj1 = unidadesj1 + 1;

                if (unidadesj1 > 3)
                {
                    if ((unidadesj1 - unidadesj2) >= 2)
                    {
                        puntosj1++;
                        unidadesj2 = 0;
                        unidadesj1 = 0;
                        ganador = 1;
                    }
                    else
                    {
                        if (unidadesj1 > 4 && unidadesj2 > 4)
                        {
                            unidadesj1 = 3;
                            unidadesj2 = 3;
                        }
                    }
                }
            }
        }

        private string Texto(int unidades)
        {
            switch (unidades)
            {
                case 0:
                    return "0";
                    //break;
                case 1:
                    return "15";
                    //break;
                case 2:
                    return "30";
                    //break;
                case 3:
                    return "40";
                    //break;
            }
            return string.Empty;
        }

        private string MensajeRespuesta()
        {

            if (unidadesj1 == 4 && unidadesj1 == unidadesj2)
            {
                return "Deuce";
            }
            else
            {
                if (unidadesj1 == 5 && unidadesj2 == 4)
                {
                    return "Advantage PlayerOne";
                }
                else if (unidadesj2 == 5 && unidadesj1 == 4)
                {
                    return "Advantage PlayerTwo";
                }
                else if(ganador>0)
                {
                    switch (ganador)
                    {
                        case 1:
                            return "PlayerOne wins";
                            //break;
                        case 2:
                            return "PlayerTwo wins";
                            //break;
                    }
                }
                else
                {
                    return "PlayerOne " + lblJugador1.Text + " PlayerTwo " + lblJugador2.Text;
                }
            }
            return "";
        }
        private void MostrarDatos()
        {
            lblJugador1.Text = Texto(unidadesj1);
            lblJugador2.Text = Texto(unidadesj2);
            lblJugador1p.Text = puntosj1.ToString();
            lblJugador2p.Text = puntosj2.ToString();
            lblRespuesta.Text = MensajeRespuesta();
        }
    }
}
