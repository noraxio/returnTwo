using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace returnTwo
{
    internal class WeatherData
    {
        public WeatherData (int temp, int humi, string scal)
        {
            temperature = temp;  
            humidity = humi;
            scale = scal;

        }

        public int temperature { get; set; }
        
        public int humidity { get; set; }
        public string scale { get; set; }


        // skil ekki hvad er i gangi med scale herna 
        public int convertor(string turnTo)
        {
            if(turnTo == "f" && scale == "c")
            {
                temperature = (temperature * 9) / 5 + 32;
                scale = "f";
                return temperature;

            } else if (turnTo == "c" && scale == "f")
            {
                temperature = (temperature - 32)*5/9;
                scale = "c";
                return temperature;
            }
            else
            {
                return temperature;
            }   
        }
        
    }
}
