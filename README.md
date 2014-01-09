BingMapHelper
=============

Bing Maps helper class for simple use of Bing Map SDK
<br> <br> <br>
Put the Bing Maps XAML code then use the mapHelper Class to use Bing Maps in simple way.


        <bm:Map 
            Grid.Row="0"
            Credentials="ApMMu9EJVCzluSvRJysHTmMmgHqdzgZFr2LflWcJO7gq72kob7Vzrdr6uHnIdwdi" 
            x:Name="BingMap"
            ZoomLevel="8" Grid.RowSpan="3"
            >
            <bm:Map.Center>
                <bm:Location Latitude="36.818810000000000000" Longitude="10.165960000000041000" />
            </bm:Map.Center>
        </bm:Map>


<br>
The Class have tow types of constructor : <br>
One for Just disply the map <br>

        mapHelper map = new mapHelper(BingMap);
        /* BingMap is the Name of the Map in the XAML file */


The second for a Map with click listener


        mapHelper map = new mapHelper(BingMap,xText,yText); 
        /* xText and yText are the textboxs where the X and Y will display */


Use the Method addPoint(double x, double y) to add a Pin to the Map
      
        map.addPoint(x,y)
