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
            this.labelSeleccion = new System.Windows.Forms.Label();
            this.opcionesClasificacion = new System.Windows.Forms.ComboBox();
            this.labelMapa = new System.Windows.Forms.Label();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.labelDatosTienda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSeleccion
            // 
            this.labelSeleccion.AutoSize = true;
            this.labelSeleccion.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeleccion.Location = new System.Drawing.Point(12, 44);
            this.labelSeleccion.Name = "labelSeleccion";
            this.labelSeleccion.Size = new System.Drawing.Size(330, 32);
            this.labelSeleccion.TabIndex = 0;
            this.labelSeleccion.Text = "Selecciona Clasificacion";
            this.labelSeleccion.Click += new System.EventHandler(this.labelSeleccion_Click);
            // 
            // opcionesClasificacion
            // 
            this.opcionesClasificacion.FormattingEnabled = true;
            this.opcionesClasificacion.Location = new System.Drawing.Point(18, 79);
            this.opcionesClasificacion.Name = "opcionesClasificacion";
            this.opcionesClasificacion.Size = new System.Drawing.Size(324, 21);
            this.opcionesClasificacion.TabIndex = 1;
            // 
            // labelMapa
            // 
            this.labelMapa.AutoSize = true;
            this.labelMapa.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMapa.Location = new System.Drawing.Point(606, 9);
            this.labelMapa.Name = "labelMapa";
            this.labelMapa.Size = new System.Drawing.Size(76, 29);
            this.labelMapa.TabIndex = 2;
            this.labelMapa.Text = "Mapa";
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(390, 44);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(508, 338);
            this.gMapControl1.TabIndex = 3;
            this.gMapControl1.Zoom = 0D;
            // 
            // labelDatosTienda
            // 
            this.labelDatosTienda.AutoSize = true;
            this.labelDatosTienda.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatosTienda.Location = new System.Drawing.Point(12, 144);
            this.labelDatosTienda.Name = "labelDatosTienda";
            this.labelDatosTienda.Size = new System.Drawing.Size(305, 32);
            this.labelDatosTienda.TabIndex = 4;
            this.labelDatosTienda.Text = "Datos sobre la tienda";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 414);
            this.Controls.Add(this.labelDatosTienda);
            this.Controls.Add(this.gMapControl1);
            this.Controls.Add(this.labelMapa);
            this.Controls.Add(this.opcionesClasificacion);
            this.Controls.Add(this.labelSeleccion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(926, 389);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSeleccion;
        private System.Windows.Forms.ComboBox opcionesClasificacion;
        private System.Windows.Forms.Label labelMapa;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Label labelDatosTienda;
    }
}

