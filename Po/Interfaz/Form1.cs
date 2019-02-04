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
using model;
using GMap.NET.WindowsForms.Markers;

namespace Interfaz
{
    public partial class Form1 : Form
    {
        private TunjaC tunjaShops;
        private GMarkerGoogle marker;
        private GMarkerGoogle marker2;
        private GMapOverlay markerOverlay;
        private DataTable table;


        public Form1()
        {
            InitializeComponent();
            tunjaShops = new TunjaC();

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
        }

        private void shopsData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
    
        }

        private void createBasicTable()
        {
            table = new DataTable();

            table.Columns.Add("Razon Social", typeof(String));
            table.Columns.Add("Direccion", typeof(String));
            table.Columns.Add("Tipo de tienda", typeof(String));
            shopsData.DataSource = table;

        }

        private void opcionesClasificacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            String opcion = opcionesClasificacion.Items[opcionesClasificacion.SelectedIndex].ToString();

            if (opcion.Equals("Autoservicio"))
            {
                createBasicTable();
                markerOverlay = new GMapOverlay("Marker");
                foreach (var shop in tunjaShops.AutoServices.Keys)
                {
                    var businessName = tunjaShops.AutoServices[shop].BusinessName;
                    var adress = tunjaShops.AutoServices[shop].Adress;
                    var subject = tunjaShops.AutoServices[shop].Subject;
                    var lat = tunjaShops.AutoServices[shop].Latitud;
                    var longi = tunjaShops.AutoServices[shop].Longitud;
                    GMarkerGoogle mark = new GMarkerGoogle(new PointLatLng(lat, longi), GMarkerGoogleType.blue);
                    mark.ToolTipMode = MarkerTooltipMode.Always;
                    mark.ToolTipText = string.Format(subject);
                    markerOverlay.Markers.Add(mark);
                    gMap.Overlays.Add(markerOverlay);

                    table.Rows.Add(businessName, adress, subject);
                }
            }
            else if (opcion.Equals("Supermercado"))
            {
                createBasicTable();
                markerOverlay = new GMapOverlay("Marker");
                foreach (var shop in tunjaShops.SuperMarkets.Keys)
                {
                    var businessName = tunjaShops.SuperMarkets[shop].BusinessName;
                    var adress = tunjaShops.SuperMarkets[shop].Adress;
                    var subject = tunjaShops.SuperMarkets[shop].Subject;
                    var lat = tunjaShops.SuperMarkets[shop].Latitud;
                    var longi = tunjaShops.SuperMarkets[shop].Longitud;
                    GMarkerGoogle mark = new GMarkerGoogle(new PointLatLng(lat, longi), GMarkerGoogleType.red);
                    mark.ToolTipMode = MarkerTooltipMode.Always;
                    mark.ToolTipText = string.Format(subject);
                    markerOverlay.Markers.Add(mark);
                    gMap.Overlays.Add(markerOverlay);
                    table.Rows.Add(businessName, adress, subject);
                }

            }
            else if(opcion.Equals("Grandes Superficies"))
            {

                createBasicTable();
                markerOverlay = new GMapOverlay("Marker");
                foreach (var shop in tunjaShops.BigSurfaces.Keys)
                {
                    var businessName = tunjaShops.BigSurfaces[shop].BusinessName;
                    var adress = tunjaShops.BigSurfaces[shop].Adress;
                    var subject = tunjaShops.BigSurfaces[shop].Subject;
                    var lat = tunjaShops.BigSurfaces[shop].Latitud;
                    var longi = tunjaShops.BigSurfaces[shop].Longitud;
                    GMarkerGoogle mark = new GMarkerGoogle(new PointLatLng(lat, longi), GMarkerGoogleType.green);
                    mark.ToolTipMode = MarkerTooltipMode.Always;
                    mark.ToolTipText = string.Format(subject);
                    markerOverlay.Markers.Add(mark);
                    gMap.Overlays.Add(markerOverlay);
                    table.Rows.Add(businessName, adress, subject);
                }
            }
            else if(opcion.Equals("Cenco Sud"))
            {
                createBasicTable();
                markerOverlay = new GMapOverlay("Marker");

                foreach (var shop in tunjaShops.CencoSud.Keys)
                {
                    var businessName = tunjaShops.CencoSud[shop].BusinessName;
                    var adress = tunjaShops.CencoSud[shop].Adress;
                    var subject = tunjaShops.CencoSud[shop].Subject;
                    var lat = tunjaShops.CencoSud[shop].Latitud;
                    var longi = tunjaShops.CencoSud[shop].Longitud;
                    GMarkerGoogle mark = new GMarkerGoogle(new PointLatLng(lat, longi), GMarkerGoogleType.yellow);
                    mark.ToolTipMode = MarkerTooltipMode.Always;
                    mark.ToolTipText = string.Format(subject);
                    markerOverlay.Markers.Add(mark);
                    gMap.Overlays.Add(markerOverlay);
                    table.Rows.Add(businessName, adress, subject);

                }
            }
            else if (opcion.Equals("Minimercado"))
            {
                createBasicTable();
                markerOverlay = new GMapOverlay("Marker");

                foreach (var shop in tunjaShops.MiniMarkets.Keys)
                {
                    var businessName = tunjaShops.MiniMarkets[shop].BusinessName;
                    var adress = tunjaShops.MiniMarkets[shop].Adress;
                    var subject = tunjaShops.MiniMarkets[shop].Subject;
                    var lat = tunjaShops.MiniMarkets[shop].Latitud;
                    var longi = tunjaShops.MiniMarkets[shop].Longitud;
                    GMarkerGoogle mark = new GMarkerGoogle(new PointLatLng(lat, longi), GMarkerGoogleType.white_small);
                    mark.ToolTipMode = MarkerTooltipMode.Always;
                    mark.ToolTipText = string.Format(subject);
                    markerOverlay.Markers.Add(mark);
                    gMap.Overlays.Add(markerOverlay);

                    table.Rows.Add(businessName, adress, subject);
                }
            }
            else if (opcion.Equals("Almacenes"))
            {
                createBasicTable();
                markerOverlay = new GMapOverlay("Marker");

                foreach (var shop in tunjaShops.WareHouses.Keys)
                {
                    var businessName = tunjaShops.WareHouses[shop].BusinessName;
                    var adress = tunjaShops.WareHouses[shop].Adress;
                    var subject = tunjaShops.WareHouses[shop].Subject;
                    var lat = tunjaShops.WareHouses[shop].Latitud;
                    var longi = tunjaShops.WareHouses[shop].Longitud;
                    GMarkerGoogle mark = new GMarkerGoogle(new PointLatLng(lat, longi), GMarkerGoogleType.orange);
                    mark.ToolTipMode = MarkerTooltipMode.Always;
                    mark.ToolTipText = string.Format(subject);
                    markerOverlay.Markers.Add(mark);
                    gMap.Overlays.Add(markerOverlay);
                    table.Rows.Add(businessName, adress, subject);
                }
            }


        }
    }
}
