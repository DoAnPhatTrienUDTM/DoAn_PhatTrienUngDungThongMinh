using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraMap;

namespace GUI
{
    public partial class TestMapControl : DevExpress.XtraEditors.XtraForm
    {
        string bingKey = "";
        string FromAddress, ToAddress;
        public string Khoangcach = "";
        public TestMapControl()
        {
            InitializeComponent();
            bingKey = "AfZfySbZHoncdc1eVAof~GtnslxluK2HzjJJcD74jmA~AjjuvKu5PtgxKMpqgvkY-O6n_7AVw82zkzsHXr434lumQ45H9Kx1oFq9U9NlMLOK";
        }

        //Bing key form account Microsoft Bing 
        //WayPoint function
        //For add we need devexpress.Data dll
        public void AddWayPoint()
        {
            try
            {
                BingRouteDataProvider provider = new BingRouteDataProvider
                {
                    BingKey = bingKey
                };
                mapControl1.Layers.Add(new InformationLayer
                {
                    DataProvider = provider
                });
                mapControl1.Layers.Add(new ImageLayer()
                { 
                    DataProvider = new BingMapDataProvider()
                    {
                        BingKey = bingKey
                    }
                });

                //this event will generate later
                

                List<RouteWaypoint> waypoints = new List<RouteWaypoint>();
                //Add waypoint means Address
                FromAddress = txtFromAddress.Text;
                ToAddress = txtToAddress.Text;
                waypoints.Add(new RouteWaypoint("From Address", FromAddress));
                waypoints.Add(new RouteWaypoint("To Address", ToAddress));
                provider.CalculateRoute(waypoints);
                provider.RouteCalculated += OnRouteCalculated;
               
                provider.LayerItemsGenerating += routeLayerItemGenerating;
                System.Threading.Thread.Sleep((int)System.TimeSpan.FromSeconds(2).TotalMilliseconds);
            }
            catch
            {

            }
        }

        public void OnRouteCalculated(object sender, BingRouteCalculatedEventArgs e)
        {
            SearchBoundingBox box = e.CalculationResult.RouteResults[0].BoundingBox;
            GeoPoint topleft = new GeoPoint
            {
                Latitude = box.NorthLatitude,
                Longitude = box.WestLongitude,
            };
            GeoPoint bottomRight = new GeoPoint 
            { 
                Latitude = box.SouthLatitude,
                Longitude = box.EastLongitude,
            };

            //Add devpress.map.core.dll
            mapControl1.ZoomToRegion(topleft, bottomRight, 0.4);
            RouteCalculationResult result = e.CalculationResult;
            if ((result.RouteResults != null) & (result.ResultCode == RequestResultCode.Success))
            {
                for(int rnum = 0; rnum < e.CalculationResult.RouteResults.Count; rnum++)
                {
                    if(e.CalculationResult.RouteResults[rnum].Legs != null)
                    {
                        //int legNum = 1;
                        foreach (BingRouteLeg leg in e.CalculationResult.RouteResults[rnum].Legs)
                            Khoangcach = leg.Distance.ToString("0.00") + " KM";
                    }
                }
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            AddWayPoint();
        }

        private void routeLayerItemGenerating(object sender, LayerItemsGeneratingEventArgs e)
        {
            if (e.Cancelled || (e.Error != null)) return;

            //Char PushPin Marker = 'A';
            foreach(MapItem item in e.Items)
            {
                MapPolyline polyline = item as MapPolyline;
                if(polyline != null)
                {
                    polyline.Stroke = Color.FromArgb(0xFF, 0x00, 0x72, 0xC6);
                    polyline.StrokeWidth = 4;
                }
            }
        }
    }
}