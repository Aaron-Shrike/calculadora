using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace pryHelloForm
{
    public partial class formCalculadora : Form
    {
        private TextBox txtNumero;
        
        public formCalculadora()
        {
            InitializeComponent();
        }

        private void formCalculadora_Load(object sender, EventArgs e)
        {
            this.txtNumero = this.txtNumero1;
            this.txtNumero1.BackColor = SystemColors.Info;
        }

        private void CambiarFocoOperando()
        {
            //Indicador del foco en llenado de numeros
            this.txtNumero1.BackColor = SystemColors.Window;
            this.txtNumero2.BackColor = SystemColors.Window;
            this.txtNumero.BackColor = SystemColors.Info;
        }

        private void QuitarFoco()
        {
            //define el control a null para no quedar marcado
            this.ActiveControl = null;
        }

        private void SonidoError()
        {
            //sonido para indicador q no se puede hacer dicha accion
            SystemSounds.Beep.Play();
        }

        private void btnNumero_Click(object sender, EventArgs e)
        {
            this.txtNumero.Text += ((Button)sender).Text;
            this.QuitarFoco();
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (!this.txtNumero.Text.Contains(","))
            {
                this.txtNumero.Text += ",";
            }
            else
            {
                this.SonidoError();
            }
            this.QuitarFoco();
        }

        private void btnOperador_Click(object sender, EventArgs e)
        {
            if ((this.txtNumero1.Text.Length > 0 && this.txtNumero1.Text != ","))
            {
                if (this.txtNumero2.Text.Length == 0 && sender is Button)
                {
                    this.lblOperador.Text = ((Button)sender).Text;
                }
                else
                {
                    this.SonidoError();
                }
                this.txtNumero = this.txtNumero2;
                this.CambiarFocoOperando();
            }
            else
            {
                this.SonidoError();
            }
            this.QuitarFoco();
        }

        private void btnOperacion_Click(object sender, EventArgs e)
        {
            if (this.txtNumero2.Text.Length == 0 && sender is Button)
            {
                this.txtNumero1.Text = "";
                this.lblOperador.Text = ((Button)sender).Text;
                this.txtNumero = this.txtNumero2;
                this.CambiarFocoOperando();
            }
            else
            {
                this.SonidoError();
            }
            this.QuitarFoco();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (((this.txtNumero1.Text.Length > 0 && this.txtNumero2.Text.Length > 0) || (this.txtNumero1.Text.Length == 0 && this.txtNumero2.Text.Length > 0)) && this.txtNumero.Text != ",")
            {
                double numero1 = 0;
                double numero2 = 0;
                double resultado = 0;

                if (this.txtNumero1.Text.Length > 0)
                {
                    numero1 = Double.Parse(this.txtNumero1.Text);
                    
                }
                numero2 = Double.Parse(this.txtNumero2.Text);

                switch (this.lblOperador.Text)
                {
                    case "+": resultado = numero1 + numero2; break;
                    case "-": resultado = numero1 - numero2; break;
                    case "÷": resultado = numero1 / numero2; break;
                    case "x": resultado = numero1 * numero2; break;
                    case "^": resultado = Math.Pow(numero1, numero2); break;
                    case "√": resultado = Math.Pow(numero2, 1/numero1); break;
                    case "sen": resultado = Math.Sin(numero2 * Math.PI / 180); break;
                    case "cos": resultado = Math.Cos(numero2 * Math.PI / 180); break;
                    case "tg": resultado = Math.Tan(numero2 * Math.PI / 180); break;
                    case "log": resultado = Math.Log10(numero2); break;
                    case "ln": resultado = Math.Log(numero2); break;
                    case "MOD": resultado = numero1 % numero2; break;
                    case "Max": resultado = Math.Max(numero1, numero2); break;
                    case "Min": resultado = Math.Min(numero1, numero2); break;
                    case "(a^4+b^2+1)^2": resultado = Math.Pow(Math.Pow(numero1,4)+Math.Pow(numero2,2)+1,2); break;
                }

                this.ValidarResultado(resultado);
            }
            else
            {
                this.SonidoError();
            }
            this.QuitarFoco();
        }

        private void ValidarResultado(double resultado)
        {
            if (Char.IsNumber(resultado.ToString(), resultado.ToString().Length-1))
            {
                this.txtResultado.Text = resultado.ToString();
                this.LimpiarPostEjecutarIgual();
            }
            else
            {
                this.SonidoError();
            }
        }

        private void LimpiarPostEjecutarIgual()
        {
            this.lblOperador.Text = "";
            this.txtNumero = this.txtNumero1;
            this.CambiarFocoOperando();

            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (this.txtNumero1.Text != "" || this.txtNumero2.Text != "" || this.txtResultado.Text != "")
            {
                this.txtResultado.Text = "";
                this.LimpiarPostEjecutarIgual();
            }
            else
            {
                this.SonidoError();
            }
            this.QuitarFoco();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (this.txtNumero.Text.Length > 0)
            {
                this.txtNumero.Text = this.txtNumero.Text.Substring(0, this.txtNumero.Text.Length-1);
            }
            else
            {
                this.SonidoError();
            }
            this.QuitarFoco();
        }

        private void formCalculadora_KeyDown(object sender, KeyEventArgs e)
        {
            //8:Borrar, 13:Enter, 67:Limpiar
            switch (e.KeyValue)
            {
                case 8: this.btnBorrar.PerformClick(); break;
                case 13: this.btnIgual.PerformClick(); break;
                case 67: this.btnLimpiar.PerformClick(); break;
            }
        }

        private void formCalculadora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.ValidarTecla_Press(e))
            {
                switch (e.KeyChar)
                {
                    case '+': btnSuma.PerformClick(); break;
                    case '-': btnResta.PerformClick(); break;
                    case '*': btnMultiplicacion.PerformClick(); break;
                    case '/': btnDivision.PerformClick(); break;
                    case '.': btnPunto.PerformClick(); break;
                    default: this.txtNumero.Text += e.KeyChar; break;
                }
            }
        }

        private bool ValidarTecla_Press(KeyPressEventArgs e)
        {
            char[] caracteresValidos = { '+','-','*','/','.' };
            char key = e.KeyChar;

            foreach (var i in caracteresValidos)
            {
                if (Char.IsNumber(key) || key.Equals(i))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
