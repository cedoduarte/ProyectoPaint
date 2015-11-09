namespace ProyectoPaint
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.btnLapiz = new System.Windows.Forms.Button();
            this.btnCuadrado = new System.Windows.Forms.Button();
            this.btnColores = new System.Windows.Forms.Button();
            this.btnCirculo = new System.Windows.Forms.Button();
            this.btnLinea = new System.Windows.Forms.Button();
            this.btnCirculoRelleno = new System.Windows.Forms.Button();
            this.btnCuadradoRelleno = new System.Windows.Forms.Button();
            this.btnGuardarImagen = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dibujoNuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitarAplicaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acerdaDeDuartePaintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLapiz
            // 
            this.btnLapiz.Image = ((System.Drawing.Image)(resources.GetObject("btnLapiz.Image")));
            this.btnLapiz.Location = new System.Drawing.Point(12, 27);
            this.btnLapiz.Name = "btnLapiz";
            this.btnLapiz.Size = new System.Drawing.Size(50, 42);
            this.btnLapiz.TabIndex = 0;
            this.btnLapiz.UseVisualStyleBackColor = true;
            this.btnLapiz.Click += new System.EventHandler(this.btnLapiz_Click);
            // 
            // btnCuadrado
            // 
            this.btnCuadrado.Image = ((System.Drawing.Image)(resources.GetObject("btnCuadrado.Image")));
            this.btnCuadrado.Location = new System.Drawing.Point(195, 27);
            this.btnCuadrado.Name = "btnCuadrado";
            this.btnCuadrado.Size = new System.Drawing.Size(50, 42);
            this.btnCuadrado.TabIndex = 1;
            this.btnCuadrado.UseVisualStyleBackColor = true;
            this.btnCuadrado.Click += new System.EventHandler(this.btnCuadrado_Click);
            // 
            // btnColores
            // 
            this.btnColores.Image = ((System.Drawing.Image)(resources.GetObject("btnColores.Image")));
            this.btnColores.Location = new System.Drawing.Point(378, 27);
            this.btnColores.Name = "btnColores";
            this.btnColores.Size = new System.Drawing.Size(50, 42);
            this.btnColores.TabIndex = 2;
            this.btnColores.UseVisualStyleBackColor = true;
            this.btnColores.Click += new System.EventHandler(this.btnColores_Click);
            // 
            // btnCirculo
            // 
            this.btnCirculo.Image = ((System.Drawing.Image)(resources.GetObject("btnCirculo.Image")));
            this.btnCirculo.Location = new System.Drawing.Point(134, 27);
            this.btnCirculo.Name = "btnCirculo";
            this.btnCirculo.Size = new System.Drawing.Size(50, 42);
            this.btnCirculo.TabIndex = 3;
            this.btnCirculo.UseVisualStyleBackColor = true;
            this.btnCirculo.Click += new System.EventHandler(this.btnCirculo_Click);
            // 
            // btnLinea
            // 
            this.btnLinea.Image = ((System.Drawing.Image)(resources.GetObject("btnLinea.Image")));
            this.btnLinea.Location = new System.Drawing.Point(73, 27);
            this.btnLinea.Name = "btnLinea";
            this.btnLinea.Size = new System.Drawing.Size(50, 42);
            this.btnLinea.TabIndex = 5;
            this.btnLinea.UseVisualStyleBackColor = true;
            this.btnLinea.Click += new System.EventHandler(this.btnLinea_Click);
            // 
            // btnCirculoRelleno
            // 
            this.btnCirculoRelleno.Image = ((System.Drawing.Image)(resources.GetObject("btnCirculoRelleno.Image")));
            this.btnCirculoRelleno.Location = new System.Drawing.Point(256, 27);
            this.btnCirculoRelleno.Name = "btnCirculoRelleno";
            this.btnCirculoRelleno.Size = new System.Drawing.Size(50, 42);
            this.btnCirculoRelleno.TabIndex = 7;
            this.btnCirculoRelleno.UseVisualStyleBackColor = true;
            this.btnCirculoRelleno.Click += new System.EventHandler(this.btnCirculoRelleno_Click);
            // 
            // btnCuadradoRelleno
            // 
            this.btnCuadradoRelleno.Image = ((System.Drawing.Image)(resources.GetObject("btnCuadradoRelleno.Image")));
            this.btnCuadradoRelleno.Location = new System.Drawing.Point(317, 27);
            this.btnCuadradoRelleno.Name = "btnCuadradoRelleno";
            this.btnCuadradoRelleno.Size = new System.Drawing.Size(50, 42);
            this.btnCuadradoRelleno.TabIndex = 8;
            this.btnCuadradoRelleno.UseVisualStyleBackColor = true;
            this.btnCuadradoRelleno.Click += new System.EventHandler(this.btnCuadradoRelleno_Click);
            // 
            // btnGuardarImagen
            // 
            this.btnGuardarImagen.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarImagen.Image")));
            this.btnGuardarImagen.Location = new System.Drawing.Point(439, 27);
            this.btnGuardarImagen.Name = "btnGuardarImagen";
            this.btnGuardarImagen.Size = new System.Drawing.Size(50, 42);
            this.btnGuardarImagen.TabIndex = 9;
            this.btnGuardarImagen.UseVisualStyleBackColor = true;
            this.btnGuardarImagen.Click += new System.EventHandler(this.btnGuardarImagen_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(621, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dibujoNuevoToolStripMenuItem,
            this.quitarAplicaciónToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // dibujoNuevoToolStripMenuItem
            // 
            this.dibujoNuevoToolStripMenuItem.Name = "dibujoNuevoToolStripMenuItem";
            this.dibujoNuevoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.dibujoNuevoToolStripMenuItem.Text = "Dibujo nuevo";
            this.dibujoNuevoToolStripMenuItem.Click += new System.EventHandler(this.dibujoNuevoToolStripMenuItem_Click);
            // 
            // quitarAplicaciónToolStripMenuItem
            // 
            this.quitarAplicaciónToolStripMenuItem.Name = "quitarAplicaciónToolStripMenuItem";
            this.quitarAplicaciónToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.quitarAplicaciónToolStripMenuItem.Text = "Quitar aplicación";
            this.quitarAplicaciónToolStripMenuItem.Click += new System.EventHandler(this.quitarAplicaciónToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acerdaDeDuartePaintToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acerdaDeDuartePaintToolStripMenuItem
            // 
            this.acerdaDeDuartePaintToolStripMenuItem.Name = "acerdaDeDuartePaintToolStripMenuItem";
            this.acerdaDeDuartePaintToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.acerdaDeDuartePaintToolStripMenuItem.Text = "Acerda de DuartePaint";
            this.acerdaDeDuartePaintToolStripMenuItem.Click += new System.EventHandler(this.acerdaDeDuartePaintToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 459);
            this.Controls.Add(this.btnGuardarImagen);
            this.Controls.Add(this.btnLapiz);
            this.Controls.Add(this.btnColores);
            this.Controls.Add(this.btnCuadradoRelleno);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnCirculoRelleno);
            this.Controls.Add(this.btnCuadrado);
            this.Controls.Add(this.btnCirculo);
            this.Controls.Add(this.btnLinea);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLapiz;
        private System.Windows.Forms.Button btnCuadrado;
        private System.Windows.Forms.Button btnColores;
        private System.Windows.Forms.Button btnCirculo;
        private System.Windows.Forms.Button btnLinea;
        private System.Windows.Forms.Button btnCirculoRelleno;
        private System.Windows.Forms.Button btnCuadradoRelleno;
        private System.Windows.Forms.Button btnGuardarImagen;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dibujoNuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitarAplicaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acerdaDeDuartePaintToolStripMenuItem;
    }
}