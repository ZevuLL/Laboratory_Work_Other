using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6
{
    public class Figure
    {
        double value;
        double volume = 0;
        double surface_area = 0;

        public Figure()
        {
            value = 0;
        }
        public Figure(double _value)
        {
            value = _value;

        }
        public Figure(Figure Temp)
        {
            value = Temp.value;
            volume = Temp.volume;
            surface_area = Temp.surface_area;
        }
        public string Print()
        {
            string returnstring = "Длина ребра: " + Convert.ToString(value);
            if (volume != 0) returnstring += "\nОбъём: " + Convert.ToString(volume);
            if (surface_area != 0) returnstring += "\nПлощадь: " + Convert.ToString(surface_area);
            return returnstring;
        }
        public void Read(double TempValue)
        {
            value = TempValue;
        }
        public void Surface_Area()
        {
            surface_area = Math.Abs(7 * Math.Sqrt(3) * Math.Pow(value, 2));
        }
        public void Volume()
        {
            volume = Math.Abs((23/12)*Math.Sqrt(2)*Math.Pow(value,3));
        }
        public void ClearVolume()
        {
            volume = 0;
        }
        public void ClearSurface_Area()
        {
            surface_area = 0;
        }
    }
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
