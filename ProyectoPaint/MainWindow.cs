using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Design;

namespace ProyectoPaint
{
    public partial class MainWindow : Form
    {
        public enum Herramienta
        {
            Lapiz,
            Cuadrado,
            Circulo,
            Linea,
            CuadradoRelleno,
            CirculoRelleno
        }

        public struct Punto
        {
            public int x1;
            public int x2;
            public int y1;
            public int y2;
        }

        public MainWindow()
        {
            InitializeComponent();
            pintar = false;
            puntoCuadrado = new Punto();
            colorPintura = Color.Black;
            Text = "DuartePaint";
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            MinimumSize = new Size(500, 500);
            CenterToScreen();
        }

        private void MainWindow_MouseDown(object sender, MouseEventArgs e)
        {
            pintar = true;
            puntoCuadrado.x1 = e.X;
            puntoCuadrado.y1 = e.Y;
        }

        private void pintaCuadradoRelleno()
        {
            SolidBrush linea = new System.Drawing.SolidBrush(colorPintura);
            Graphics g = CreateGraphics();

            if ((puntoCuadrado.x1 > puntoCuadrado.x2)
                && (puntoCuadrado.y1 > puntoCuadrado.y2))
            {
                g.FillRectangle(linea,
                puntoCuadrado.x2,
                puntoCuadrado.y2,
                puntoCuadrado.x1 < puntoCuadrado.x2 ?
                    puntoCuadrado.x2 - puntoCuadrado.x1
                  : puntoCuadrado.x1 - puntoCuadrado.x2,
                puntoCuadrado.y1 < puntoCuadrado.y2 ?
                    puntoCuadrado.y2 - puntoCuadrado.y1
                  : puntoCuadrado.y1 - puntoCuadrado.y2);
            }
            else
            {
                g.FillRectangle(linea,
                puntoCuadrado.x1,
                puntoCuadrado.y1,
                puntoCuadrado.x1 < puntoCuadrado.x2 ?
                    puntoCuadrado.x2 - puntoCuadrado.x1
                  : puntoCuadrado.x1 - puntoCuadrado.x2,
                puntoCuadrado.y1 < puntoCuadrado.y2 ?
                    puntoCuadrado.y2 - puntoCuadrado.y1
                  : puntoCuadrado.y1 - puntoCuadrado.y2);
            }
        }

        private void pintaCirculo()
        {
            SolidBrush linea = new System.Drawing.SolidBrush(colorPintura);
            Graphics g = CreateGraphics();
            if ((puntoCuadrado.x1 > puntoCuadrado.x2)
                && (puntoCuadrado.y1 > puntoCuadrado.y2))
            {
                g.DrawEllipse(new Pen(new SolidBrush(colorPintura)), puntoCuadrado.x2,
                puntoCuadrado.y2,
                puntoCuadrado.x1 < puntoCuadrado.x2 ?
                    puntoCuadrado.x2 - puntoCuadrado.x1
                  : puntoCuadrado.x1 - puntoCuadrado.x2,
                puntoCuadrado.y1 < puntoCuadrado.y2 ?
                    puntoCuadrado.y2 - puntoCuadrado.y1
                  : puntoCuadrado.y1 - puntoCuadrado.y2);
            }
            else
            {
                g.DrawEllipse(new Pen(new SolidBrush(colorPintura)), puntoCuadrado.x2,
                puntoCuadrado.y2,
                puntoCuadrado.x1 < puntoCuadrado.x2 ?
                    puntoCuadrado.x2 - puntoCuadrado.x1
                  : puntoCuadrado.x1 - puntoCuadrado.x2,
                puntoCuadrado.y1 < puntoCuadrado.y2 ?
                    puntoCuadrado.y2 - puntoCuadrado.y1
                  : puntoCuadrado.y1 - puntoCuadrado.y2);

            }
        }

        private void pintaLinea()
        {
            SolidBrush linea = new System.Drawing.SolidBrush(colorPintura);
            Graphics g = CreateGraphics();
            g.DrawLine(new Pen(colorPintura), puntoCuadrado.x1,
                puntoCuadrado.y1, puntoCuadrado.x2, puntoCuadrado.y2);
        }

        private void pintaCuadrado()
        {
            SolidBrush linea = new System.Drawing.SolidBrush(colorPintura);
            Graphics g = CreateGraphics();

            if ((puntoCuadrado.x1 > puntoCuadrado.x2)
                && (puntoCuadrado.y1 > puntoCuadrado.y2))
            {
                g.DrawRectangle(new Pen(new SolidBrush(colorPintura)), puntoCuadrado.x2,
                puntoCuadrado.y2,
                puntoCuadrado.x1 < puntoCuadrado.x2 ?
                    puntoCuadrado.x2 - puntoCuadrado.x1
                  : puntoCuadrado.x1 - puntoCuadrado.x2,
                puntoCuadrado.y1 < puntoCuadrado.y2 ?
                    puntoCuadrado.y2 - puntoCuadrado.y1
                  : puntoCuadrado.y1 - puntoCuadrado.y2);

            }
            else
            {
                g.DrawRectangle(new Pen(new SolidBrush(colorPintura)), puntoCuadrado.x2,
                puntoCuadrado.y2,
                puntoCuadrado.x1 < puntoCuadrado.x2 ?
                    puntoCuadrado.x2 - puntoCuadrado.x1
                  : puntoCuadrado.x1 - puntoCuadrado.x2,
                puntoCuadrado.y1 < puntoCuadrado.y2 ?
                    puntoCuadrado.y2 - puntoCuadrado.y1
                  : puntoCuadrado.y1 - puntoCuadrado.y2);
            }
        }

        private void pintaCirculoRelleno()
        {
            SolidBrush linea = new System.Drawing.SolidBrush(colorPintura);
            Graphics g = CreateGraphics();
            if ((puntoCuadrado.x1 > puntoCuadrado.x2)
                && (puntoCuadrado.y1 > puntoCuadrado.y2))
            {
                g.FillEllipse(linea,
                puntoCuadrado.x2,
                puntoCuadrado.y2,
                puntoCuadrado.x1 < puntoCuadrado.x2 ?
                    puntoCuadrado.x2 - puntoCuadrado.x1
                  : puntoCuadrado.x1 - puntoCuadrado.x2,
                puntoCuadrado.y1 < puntoCuadrado.y2 ?
                    puntoCuadrado.y2 - puntoCuadrado.y1
                  : puntoCuadrado.y1 - puntoCuadrado.y2);
            }
            else
            {
                g.FillEllipse(linea,
                puntoCuadrado.x1,
                puntoCuadrado.y1,
                puntoCuadrado.x1 < puntoCuadrado.x2 ?
                    puntoCuadrado.x2 - puntoCuadrado.x1
                  : puntoCuadrado.x1 - puntoCuadrado.x2,
                puntoCuadrado.y1 < puntoCuadrado.y2 ?
                    puntoCuadrado.y2 - puntoCuadrado.y1
                  : puntoCuadrado.y1 - puntoCuadrado.y2);

            }
        }

        private void MainWindow_MouseUp(object sender, MouseEventArgs e)
        {
            pintar = false;
            puntoCuadrado.x2 = e.X;
            puntoCuadrado.y2 = e.Y;
            switch (herramienta)
            {
                case Herramienta.Cuadrado:
                    pintaCuadrado();
                    break;
                case Herramienta.Circulo:
                    pintaCirculo();
                    break;
                case Herramienta.Linea:
                    pintaLinea();
                    break;
                case Herramienta.CirculoRelleno:
                    pintaCirculoRelleno();
                    break;
                case Herramienta.CuadradoRelleno:
                    pintaCuadradoRelleno();
                    break;
            }
        }

        private void btnLapiz_Click(object sender, EventArgs e)
        {
            herramienta = Herramienta.Lapiz;
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            herramienta = Herramienta.Cuadrado;
        }

        private void MainWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (pintar)
            {
                if (herramienta == Herramienta.Lapiz)
                {
                    Graphics graphics = CreateGraphics();
                    graphics.FillEllipse(new SolidBrush(colorPintura),
                        e.X, e.Y, 4, 4);
                }
            }
        }

        private void quitarAplicaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnColores_Click(object sender, EventArgs e)
        {
            ColorDialog d = new ColorDialog();
            if (d.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            colorPintura = d.Color;
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            herramienta = Herramienta.Circulo;
        }

        private void btnLinea_Click(object sender, EventArgs e)
        {
            herramienta = Herramienta.Linea;
        }

        private void btnCuadradoRelleno_Click(object sender, EventArgs e)
        {
            herramienta = Herramienta.CuadradoRelleno;
        }

        private void btnCirculoRelleno_Click(object sender, EventArgs e)
        {
            herramienta = Herramienta.CirculoRelleno;
        }

        private void btnGuardarImagen_Click(object sender, EventArgs e)
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            var memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
            SaveFileDialog d = new SaveFileDialog();
            if (d.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }
            memoryImage.Save(d.FileName);
        }

        private void acerdaDeDuartePaintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autor: Carlos Enrique Duarte Ortiz");
        }

        private void dibujoNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var g = CreateGraphics();
            g.Clear(Color.White);
        }

        private bool pintar;
        private Herramienta herramienta;
        private Punto puntoCuadrado;
        private Color colorPintura;
    }
}
