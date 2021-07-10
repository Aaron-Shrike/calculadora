namespace pryHelloForm
{
    partial class formCalculadora
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
            this.lblOperacion = new System.Windows.Forms.Label();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.lblOperador = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSiete = new System.Windows.Forms.Button();
            this.btnOcho = new System.Windows.Forms.Button();
            this.btnNueve = new System.Windows.Forms.Button();
            this.btnCuatro = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnUno = new System.Windows.Forms.Button();
            this.btnDos = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnCero = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnMultiplicacion = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.button21 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.btnPotencia = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOperacion
            // 
            this.lblOperacion.AutoSize = true;
            this.lblOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperacion.Location = new System.Drawing.Point(24, 26);
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(165, 31);
            this.lblOperacion.TabIndex = 0;
            this.lblOperacion.Text = "Operación :";
            // 
            // txtNumero1
            // 
            this.txtNumero1.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumero1.Enabled = false;
            this.txtNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero1.Location = new System.Drawing.Point(48, 75);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(228, 38);
            this.txtNumero1.TabIndex = 1;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Enabled = false;
            this.txtNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero2.Location = new System.Drawing.Point(378, 75);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(237, 38);
            this.txtNumero2.TabIndex = 3;
            // 
            // lblOperador
            // 
            this.lblOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperador.Location = new System.Drawing.Point(282, 74);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(90, 38);
            this.lblOperador.TabIndex = 2;
            this.lblOperador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(295, 501);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(66, 57);
            this.btnLimpiar.TabIndex = 21;
            this.btnLimpiar.Text = "&C";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSiete
            // 
            this.btnSiete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiete.Location = new System.Drawing.Point(295, 282);
            this.btnSiete.Name = "btnSiete";
            this.btnSiete.Size = new System.Drawing.Size(66, 57);
            this.btnSiete.TabIndex = 9;
            this.btnSiete.Text = "7";
            this.btnSiete.UseVisualStyleBackColor = true;
            this.btnSiete.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btnOcho
            // 
            this.btnOcho.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcho.Location = new System.Drawing.Point(378, 282);
            this.btnOcho.Name = "btnOcho";
            this.btnOcho.Size = new System.Drawing.Size(66, 57);
            this.btnOcho.TabIndex = 10;
            this.btnOcho.Text = "8";
            this.btnOcho.UseVisualStyleBackColor = true;
            this.btnOcho.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btnNueve
            // 
            this.btnNueve.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNueve.Location = new System.Drawing.Point(463, 282);
            this.btnNueve.Name = "btnNueve";
            this.btnNueve.Size = new System.Drawing.Size(66, 57);
            this.btnNueve.TabIndex = 11;
            this.btnNueve.Text = "9";
            this.btnNueve.UseVisualStyleBackColor = true;
            this.btnNueve.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btnCuatro
            // 
            this.btnCuatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuatro.Location = new System.Drawing.Point(295, 355);
            this.btnCuatro.Name = "btnCuatro";
            this.btnCuatro.Size = new System.Drawing.Size(66, 57);
            this.btnCuatro.TabIndex = 13;
            this.btnCuatro.Text = "4";
            this.btnCuatro.UseVisualStyleBackColor = true;
            this.btnCuatro.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btnCinco
            // 
            this.btnCinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCinco.Location = new System.Drawing.Point(378, 355);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(66, 57);
            this.btnCinco.TabIndex = 14;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = true;
            this.btnCinco.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btnSeis
            // 
            this.btnSeis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeis.Location = new System.Drawing.Point(463, 355);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(66, 57);
            this.btnSeis.TabIndex = 15;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = true;
            this.btnSeis.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btnUno
            // 
            this.btnUno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUno.Location = new System.Drawing.Point(295, 428);
            this.btnUno.Name = "btnUno";
            this.btnUno.Size = new System.Drawing.Size(66, 57);
            this.btnUno.TabIndex = 17;
            this.btnUno.Text = "1";
            this.btnUno.UseVisualStyleBackColor = true;
            this.btnUno.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btnDos
            // 
            this.btnDos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDos.Location = new System.Drawing.Point(378, 428);
            this.btnDos.Name = "btnDos";
            this.btnDos.Size = new System.Drawing.Size(66, 57);
            this.btnDos.TabIndex = 18;
            this.btnDos.Text = "2";
            this.btnDos.UseVisualStyleBackColor = true;
            this.btnDos.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btnTres
            // 
            this.btnTres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTres.Location = new System.Drawing.Point(463, 428);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(66, 57);
            this.btnTres.TabIndex = 19;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = true;
            this.btnTres.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btnCero
            // 
            this.btnCero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCero.Location = new System.Drawing.Point(378, 501);
            this.btnCero.Name = "btnCero";
            this.btnCero.Size = new System.Drawing.Size(66, 57);
            this.btnCero.TabIndex = 22;
            this.btnCero.Text = "0";
            this.btnCero.UseVisualStyleBackColor = true;
            this.btnCero.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(295, 208);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(149, 57);
            this.btnBorrar.TabIndex = 6;
            this.btnBorrar.Text = "<<<";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivision.Location = new System.Drawing.Point(463, 208);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(66, 57);
            this.btnDivision.TabIndex = 7;
            this.btnDivision.Text = "÷";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnOperador_Click);
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicacion.Location = new System.Drawing.Point(549, 208);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(66, 57);
            this.btnMultiplicacion.TabIndex = 8;
            this.btnMultiplicacion.Text = "x";
            this.btnMultiplicacion.UseVisualStyleBackColor = true;
            this.btnMultiplicacion.Click += new System.EventHandler(this.btnOperador_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.Location = new System.Drawing.Point(549, 355);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(66, 57);
            this.btnSuma.TabIndex = 16;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnOperador_Click);
            // 
            // btnPunto
            // 
            this.btnPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPunto.Location = new System.Drawing.Point(463, 501);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(66, 57);
            this.btnPunto.TabIndex = 23;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = true;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // btnResta
            // 
            this.btnResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.Location = new System.Drawing.Point(549, 282);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(66, 57);
            this.btnResta.TabIndex = 12;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnOperador_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.Location = new System.Drawing.Point(549, 428);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(66, 130);
            this.btnIgual.TabIndex = 20;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(191, 138);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(146, 31);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Resultado";
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(343, 138);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(272, 38);
            this.txtResultado.TabIndex = 5;
            // 
            // button21
            // 
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.Location = new System.Drawing.Point(92, 428);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(66, 57);
            this.button21.TabIndex = 28;
            this.button21.Text = "log";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.btnOperacion_Click);
            // 
            // button23
            // 
            this.button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.Location = new System.Drawing.Point(15, 428);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(66, 57);
            this.button23.TabIndex = 27;
            this.button23.Text = "ln";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.btnOperacion_Click);
            // 
            // button25
            // 
            this.button25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button25.Location = new System.Drawing.Point(92, 355);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(66, 57);
            this.button25.TabIndex = 25;
            this.button25.Text = "cos";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.btnOperacion_Click);
            // 
            // button26
            // 
            this.button26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button26.Location = new System.Drawing.Point(15, 356);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(66, 57);
            this.button26.TabIndex = 24;
            this.button26.Text = "sen";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.btnOperacion_Click);
            // 
            // btnRaiz
            // 
            this.btnRaiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaiz.Location = new System.Drawing.Point(174, 501);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(66, 57);
            this.btnRaiz.TabIndex = 35;
            this.btnRaiz.Text = "√";
            this.btnRaiz.UseVisualStyleBackColor = true;
            this.btnRaiz.Click += new System.EventHandler(this.btnOperador_Click);
            // 
            // btnPotencia
            // 
            this.btnPotencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotencia.Location = new System.Drawing.Point(174, 428);
            this.btnPotencia.Name = "btnPotencia";
            this.btnPotencia.Size = new System.Drawing.Size(66, 57);
            this.btnPotencia.TabIndex = 32;
            this.btnPotencia.Text = "^";
            this.btnPotencia.UseVisualStyleBackColor = true;
            this.btnPotencia.Click += new System.EventHandler(this.btnOperador_Click);
            // 
            // button30
            // 
            this.button30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button30.Location = new System.Drawing.Point(174, 355);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(66, 57);
            this.button30.TabIndex = 26;
            this.button30.Text = "tg";
            this.button30.UseVisualStyleBackColor = true;
            this.button30.Click += new System.EventHandler(this.btnOperacion_Click);
            // 
            // button28
            // 
            this.button28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button28.Location = new System.Drawing.Point(15, 282);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(66, 57);
            this.button28.TabIndex = 29;
            this.button28.Text = "MOD";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.btnOperador_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(92, 501);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 57);
            this.button1.TabIndex = 34;
            this.button1.Text = "Min";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnOperador_Click);
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(15, 501);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(66, 57);
            this.button17.TabIndex = 33;
            this.button17.Text = "Max";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.btnOperador_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(92, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 57);
            this.button2.TabIndex = 29;
            this.button2.Text = "(a^4+b^2+1)^2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnOperador_Click);
            // 
            // formCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 573);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnMultiplicacion);
            this.Controls.Add(this.btnDos);
            this.Controls.Add(this.btnSeis);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btnNueve);
            this.Controls.Add(this.btnCero);
            this.Controls.Add(this.btnUno);
            this.Controls.Add(this.btnOcho);
            this.Controls.Add(this.btnCuatro);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button30);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.btnPotencia);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.btnSiete);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.lblOperador);
            this.Controls.Add(this.lblOperacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formCalculadora";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.formCalculadora_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formCalculadora_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.formCalculadora_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOperacion;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSiete;
        private System.Windows.Forms.Button btnOcho;
        private System.Windows.Forms.Button btnNueve;
        private System.Windows.Forms.Button btnCuatro;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnUno;
        private System.Windows.Forms.Button btnDos;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnCero;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnMultiplicacion;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.Button btnPotencia;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button2;
    }
}

