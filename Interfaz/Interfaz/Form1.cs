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
using model;


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
                marker = new GMarkerGoogle(new PointLatLng(5.5158168, -73.377732), GMarkerGoogleType.green);
                marker2 = new GMarkerGoogle(new PointLatLng(5.5152168, -73.373732), GMarkerGoogleType.green);

                markerOverlay.Markers.Add(marker);
                markerOverlay.Markers.Add(marker2);

                //Agregamos un tooltop de texto a los marcadores
                marker.ToolTipMode = MarkerTooltipMode.Always;
                marker.ToolTipText = string.Format("Ubicacion: \n latitud");
                marker2.ToolTipMode = MarkerTooltipMode.Always;
                marker2.ToolTipText = string.Format("Ubicacion: \n latitud");

                //hora agregamos el mapa y el marcador al map control
                gMap.Overlays.Add(markerOverlay);
                foreach (var shop in tunjaShops.AutoServices.Keys)
                {
                    var businessName = tunjaShops.AutoServices[shop].BusinessName;
                    var adress = tunjaShops.AutoServices[shop].Adress;
                    var subject = tunjaShops.AutoServices[shop].Subject;
                    table.Rows.Add(businessName, adress, subject);
                }
            }
            else if (opcion.Equals("Supermercado"))
            {
                createBasicTable();
                markerOverlay = new GMapOverlay("Marker");
                marker = new GMarkerGoogle(new PointLatLng(5.5158168, -73.377732), GMarkerGoogleType.green);
                marker2 = new GMarkerGoogle(new PointLatLng(5.5152168, -73.373732), GMarkerGoogleType.green);
                markerOverlay.Markers.Add(marker);
                markerOverlay.Markers.Add(marker2);

                //Agregamos un tooltop de texto a los marcadores
                marker.ToolTipMode = MarkerTooltipMode.Always;
                marker.ToolTipText = string.Format("Ubicacion: \n latitud");
                marker2.ToolTipMode = MarkerTooltipMode.Always;
                marker2.ToolTipText = string.Format("Ubicacion: \n latitud");

                //hora agregamos el mapa y el marcador al map control
                gMap.Overlays.Add(markerOverlay);
                foreach (var shop in tunjaShops.SuperMarkets.Keys)
                {
                    var businessName = tunjaShops.SuperMarkets[shop].BusinessName;
                    var adress = tunjaShops.SuperMarkets[shop].Adress;
                    var subject = tunjaShops.SuperMarkets[shop].Subject;
                    table.Rows.Add(businessName, adress, subject);
                }

            }
            else if(opcion.Equals("Grandes Superficies"))
            {
                createBasicTable();
                markerOverlay = new GMapOverlay("Marker");
                marker = new GMarkerGoogle(new PointLatLng(5.5158168, -73.377732), GMarkerGoogleType.green);
                marker2 = new GMarkerGoogle(new PointLatLng(5.5152168, -73.373732), GMarkerGoogleType.green);

                markerOverlay.Markers.Add(marker);
                markerOverlay.Markers.Add(marker2);

                //Agregamos un tooltop de texto a los marcadores
                marker.ToolTipMode = MarkerTooltipMode.Always;
                marker.ToolTipText = string.Format("Ubicacion: \n latitud");
                marker2.ToolTipMode = MarkerTooltipMode.Always;
                marker2.ToolTipText = string.Format("Ubicacion: \n latitud");

                //hora agregamos el mapa y el marcador al map control
                gMap.Overlays.Add(markerOverlay);
                foreach (var shop in tunjaShops.BigSurfaces.Keys)
                {
                    var businessName = tunjaShops.BigSurfaces[shop].BusinessName;
                    var adress = tunjaShops.BigSurfaces[shop].Adress;
                    var subject = tunjaShops.BigSurfaces[shop].Subject;
                    table.Rows.Add(businessName, adress, subject);
                }
            }
            else if(opcion.Equals("Cenco Sud"))
            {
                createBasicTable();
                markerOverlay = new GMapOverlay("Marker");
                marker = new GMarkerGoogle(new PointLatLng(5.5158168, -73.377732), GMarkerGoogleType.green);
                marker2 = new GMarkerGoogle(new PointLatLng(5.5152168, -73.373732), GMarkerGoogleType.green);

                markerOverlay.Markers.Add(marker);
                markerOverlay.Markers.Add(marker2);

                //Agregamos un tooltop de texto a los marcadores
                marker.ToolTipMode = MarkerTooltipMode.Always;
                marker.ToolTipText = string.Format("Ubicacion: \n latitud");
                marker2.ToolTipMode = MarkerTooltipMode.Always;
                marker2.ToolTipText = string.Format("Ubicacion: \n latitud");

                //hora agregamos el mapa y el marcador al map control
                gMap.Overlays.Add(markerOverlay);
                foreach (var shop in tunjaShops.CencoSud.Keys)
                {
                    var businessName = tunjaShops.CencoSud[shop].BusinessName;
                    var adress = tunjaShops.CencoSud[shop].Adress;
                    var subject = tunjaShops.CencoSud[shop].Subject;
                    table.Rows.Add(businessName, adress, subject);
                }
            }
            else if (opcion.Equals("Minimercado"))
            {
                createBasicTable();
                markerOverlay = new GMapOverlay("Marker");
                marker = new GMarkerGoogle(new PointLatLng(5.5158168, -73.377732), GMarkerGoogleType.green);
                marker2 = new GMarkerGoogle(new PointLatLng(5.5152168, -73.373732), GMarkerGoogleType.green);

                markerOverlay.Markers.Add(marker);
                markerOverlay.Markers.Add(marker2);

                //Agregamos un tooltop de texto a los marcadores
                marker.ToolTipMode = MarkerTooltipMode.Always;
                marker.ToolTipText = string.Format("Ubicacion: \n latitud");
                marker2.ToolTipMode = MarkerTooltipMode.Always;
                marker2.ToolTipText = string.Format("Ubicacion: \n latitud");

                //hora agregamos el mapa y el marcador al map control
                gMap.Overlays.Add(markerOverlay);
                foreach (var shop in tunjaShops.MiniMarkets.Keys)
                {
                    var businessName = tunjaShops.MiniMarkets[shop].BusinessName;
                    var adress = tunjaShops.MiniMarkets[shop].Adress;
                    var subject = tunjaShops.MiniMarkets[shop].Subject;
                    table.Rows.Add(businessName, adress, subject);
                }
            }
            else if (opcion.Equals("Almacenes"))
            {
                createBasicTable();
                markerOverlay = new GMapOverlay("Marker");
                marker = new GMarkerGoogle(new PointLatLng(5.5158168, -73.377732), GMarkerGoogleType.green);
                marker2 = new GMarkerGoogle(new PointLatLng(5.5152168, -73.373732), GMarkerGoogleType.green);

                markerOverlay.Markers.Add(marker);
                markerOverlay.Markers.Add(marker2);

                //Agregamos un tooltop de texto a los marcadores
                marker.ToolTipMode = MarkerTooltipMode.Always;
                marker.ToolTipText = string.Format("Ubicacion: \n latitud");
                marker2.ToolTipMode = MarkerTooltipMode.Always;
                marker2.ToolTipText = string.Format("Ubicacion: \n latitud");

                //hora agregamos el mapa y el marcador al map control
                gMap.Overlays.Add(markerOverlay);
                foreach (var shop in tunjaShops.WareHouses.Keys)
                {
                    var businessName = tunjaShops.WareHouses[shop].BusinessName;
                    var adress = tunjaShops.WareHouses[shop].Adress;
                    var subject = tunjaShops.WareHouses[shop].Subject;
                    table.Rows.Add(businessName, adress, subject);
                }
            }


        }
    }
}
