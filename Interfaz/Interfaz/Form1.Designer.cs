namespace Interfaz
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelSeleccion = new System.Windows.Forms.Label();
            this.opcionesClasificacion = new System.Windows.Forms.ComboBox();
            this.labelMapa = new System.Windows.Forms.Label();
            this.gMap = new GMap.NET.WindowsForms.GMapControl();
            this.labelDatosTienda = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSeleccion
            // 
            this.labelSeleccion.AutoSize = true;
            this.labelSeleccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelSeleccion.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeleccion.ForeColor = System.Drawing.Color.White;
            this.labelSeleccion.Image = ((System.Drawing.Image)(resources.GetObject("labelSeleccion.Image")));
            this.labelSeleccion.Location = new System.Drawing.Point(41, 51);
            this.labelSeleccion.Name = "labelSeleccion";
            this.labelSeleccion.Size = new System.Drawing.Size(263, 25);
            this.labelSeleccion.TabIndex = 0;
            this.labelSeleccion.Text = "Selecciona Clasificación";
            this.labelSeleccion.Click += new System.EventHandler(this.labelSeleccion_Click);
            // 
            // opcionesClasificacion
            // 
            this.opcionesClasificacion.FormattingEnabled = true;
            this.opcionesClasificacion.Items.AddRange(new object[] {
            "Autoservicio",
            "Supermercado",
            "Grandes Superficies",
            "Cenco Sud",
            "Minimercado",
            "Almacenes"});
            this.opcionesClasificacion.Location = new System.Drawing.Point(18, 79);
            this.opcionesClasificacion.Name = "opcionesClasificacion";
            this.opcionesClasificacion.Size = new System.Drawing.Size(324, 21);
            this.opcionesClasificacion.TabIndex = 1;
            // 
            // labelMapa
            // 
            this.labelMapa.AutoSize = true;
            this.labelMapa.BackColor = System.Drawing.Color.Transparent;
            this.labelMapa.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMapa.ForeColor = System.Drawing.Color.Linen;
            this.labelMapa.Image = ((System.Drawing.Image)(resources.GetObject("labelMapa.Image")));
            this.labelMapa.Location = new System.Drawing.Point(606, 9);
            this.labelMapa.Name = "labelMapa";
            this.labelMapa.Size = new System.Drawing.Size(76, 29);
            this.labelMapa.TabIndex = 2;
            this.labelMapa.Text = "Mapa";
            // 
            // gMap
            // 
            this.gMap.Bearing = 0F;
            this.gMap.CanDragMap = true;
            this.gMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMap.GrayScaleMode = false;
            this.gMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMap.LevelsKeepInMemmory = 5;
            this.gMap.Location = new System.Drawing.Point(396, 44);
            this.gMap.MarkersEnabled = true;
            this.gMap.MaxZoom = 20;
            this.gMap.MinZoom = 5;
            this.gMap.MouseWheelZoomEnabled = true;
            this.gMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMap.Name = "gMap";
            this.gMap.NegativeMode = false;
            this.gMap.PolygonsEnabled = true;
            this.gMap.RetryLoadTile = 0;
            this.gMap.RoutesEnabled = true;
            this.gMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMap.ShowTileGridLines = false;
            this.gMap.Size = new System.Drawing.Size(486, 481);
            this.gMap.TabIndex = 3;
            this.gMap.Zoom = 14D;
            this.gMap.Load += new System.EventHandler(this.gMapControl1_Load);
            // 
            // labelDatosTienda
            // 
            this.labelDatosTienda.AutoSize = true;
            this.labelDatosTienda.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatosTienda.ForeColor = System.Drawing.Color.White;
            this.labelDatosTienda.Image = ((System.Drawing.Image)(resources.GetObject("labelDatosTienda.Image")));
            this.labelDatosTienda.Location = new System.Drawing.Point(41, 132);
            this.labelDatosTienda.Name = "labelDatosTienda";
            this.labelDatosTienda.Size = new System.Drawing.Size(238, 25);
            this.labelDatosTienda.TabIndex = 4;
            this.labelDatosTienda.Text = "Datos sobre la tienda";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(912, 546);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 537);
            this.Controls.Add(this.labelDatosTienda);
            this.Controls.Add(this.gMap);
            this.Controls.Add(this.labelMapa);
            this.Controls.Add(this.opcionesClasificacion);
            this.Controls.Add(this.labelSeleccion);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(926, 389);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSeleccion;
        private System.Windows.Forms.ComboBox opcionesClasificacion;
        private System.Windows.Forms.Label labelMapa;
        private GMap.NET.WindowsForms.GMapControl gMap;
        private System.Windows.Forms.Label labelDatosTienda;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

