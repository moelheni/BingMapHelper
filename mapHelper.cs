using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Bing.Maps;
using Windows.UI.Xaml.Media.Imaging;

namespace App13.Map
{
    class mapHelper
    {
        public Bing.Maps.Map map;
        public double clicked_x;
        public double clicked_y;

        /* only when map used for forms */
        public TextBox lat;
        public TextBox lan;


        /* basic use of map to show places */
        public mapHelper(Bing.Maps.Map m)
        {
            map = m;
        }

        /* map with form, lat = textbox for Latitude and lan = text box for Longitude */
        public mapHelper(Bing.Maps.Map m,TextBox lat,TextBox lan)
        {
            map = m;
            this.lat = lat;
            this.lan = lan;
            map.PointerPressedOverride += MyMap_PointerPressedOverride;
        }

        private void MyMap_PointerPressedOverride(object sender, PointerRoutedEventArgs e)
        {
            map.Children.Clear();
            Bing.Maps.Location l = new Bing.Maps.Location();
            this.map.TryPixelToLocation(e.GetCurrentPoint(this.map).Position, out l);
            Bing.Maps.Pushpin pushpin = new Bing.Maps.Pushpin();
            pushpin.SetValue(Bing.Maps.MapLayer.PositionProperty, l);
            map.Children.Add(pushpin);

            clicked_x = l.Latitude;
            clicked_y = l.Longitude;

            lat.Text = clicked_x.ToString();
            lan.Text = clicked_y.ToString();
        }

        public void addPoint(double x, double y)
        {
            Pushpin pushpin = new Pushpin();
            pushpin.Text = "1";
            MapLayer.SetPosition(pushpin, new Location(x, y));
            map.Children.Add(pushpin);
        }
        
    }
}
