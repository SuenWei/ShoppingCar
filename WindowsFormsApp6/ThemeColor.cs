using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public static class ThemeColor
    {
        public static List<string> ColorList = new List<string>() {
            "#07c3cf", "#1679f2", "#2b6fa9", "#72ebf2", "#2a35c3",
            "#9cdcc8", "#504e7a", "#4c70b9", "#0691f1", "#88a1bf",
            "#5287f1", "#1eadb1", "#0582fa", "#2f4bea", "#547aa9"
        };

        public static List<string> ColorList2 = new List<string>() {
            "#b98141", "#ad9081", "#f18b6b", "#a15b60", "#de6f50",
            "#994f12", "#7e3900", "#87382f", "#bd863e", "#eb9f72",
            "#99805d", "#ef7f77", "#b08e5c", "#e38402", "#c55415"
        };



        public static Color ChangeColorBrightness(Color color, double correctionFactor) 
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;

            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            else 
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;            
            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);        
        }

    }    
}
