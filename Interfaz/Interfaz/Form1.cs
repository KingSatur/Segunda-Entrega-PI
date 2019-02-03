using GMap.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;


namespace Interfaz
{
    public partial class Form1 : Form
    {

        private GMarkerGoogle marker;
        private GMapOverlay markerOverlay;
        private DataTable dt;
        private int rowSeleccionated;

        public Form1()
        {
            InitializeComponent();
            loadTable();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelSeleccion_Click(object sender, EventArgs e)
        {

        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            gMap.DragButton = MouseButtons.Left;
            gMap.CanDragMap = true;
            gMap.MapProvider = GMapProviders.GoogleMap;
            gMap.Position = new PointLatLng(5.5158168, -73.377732);
            gMap.MinZoom = 0;
            gMap.MaxZoom = 100;
            gMap.Zoom = 14;
            gMap.AutoScroll = true;

            //Marcador
            markerOverlay = new GMapOverlay("Marker");
            marker = new GMarkerGoogle(new PointLatLng(5.5158168, -73.377732), GMarkerGoogleType.green);
            //Agregamos al mapa
            markerOverlay.Markers.Add(marker);

            //Agregamos un tooltop de texto a los marcadores
            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = string.Format("Ubicacion: \n latitud");

            //hora agregamos el mapa y el marcador al map control
            gMap.Overlays.Add(markerOverlay);
        }

        private void shopsData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable table = new DataTable();

            table.Columns.Add("Razon Social", typeof(String));
            table.Columns.Add("Direccion", typeof(String));
            table.Columns.Add("Tipo de tienda", typeof(String));
            table.Columns.Add("Latitud", typeof(double));
            table.Columns.Add("Longitud", typeof(double));

            table.Rows.Add("Juan", "Calle hola", "Super", 123123,12312312);

            shopsData.DataSource = table;

        }

        private void loadTable()
        {
            DataTable table = new DataTable();

            table.Columns.Add("Razon Social", typeof(String));
            table.Columns.Add("Direccion", typeof(String));
            table.Columns.Add("Tipo de tienda", typeof(String));
            table.Columns.Add("Latitud", typeof(double));
            table.Columns.Add("Longitud", typeof(double));

            table.Rows.Add("Juan", "Calle hola", "Super", 123123, 12312312);

            shopsData.DataSource = table;

        }


    }
}
