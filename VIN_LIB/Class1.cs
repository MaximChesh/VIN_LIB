using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIN_LIB
{
    public class Class1
    {
        public char[] vinCode = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        public char[] Africa = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H'};
        public char[] Asia = { 'J', 'K', 'L', 'M', 'N', 'P', 'R'};
        public char[] Europe = { 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
        public char[] NAmerica = { '1', '2', '3', '4', '5'};
        public char[] Oceania = { '6', '7'};
        public char[] UAmerica = { '8', '9'};
        public string country;
        public Boolean CheckVIN(String vin)
        {
            int schet = 0;
            if (vin.Length == 17)
            {
                for (int i = 0; i < 17; i++)
                {
                    for (int j = 0; j < vinCode.Length; j++)
                    {
                        if (vin[i] == vinCode[j])
                        {
                            schet++;
                        }
                    }
                }
                if (schet == 17)
                {
                    return true;
                }
            }
            return false;
        }
        public String GetVINCountry(String vin)
        {
            for(int i = 0; i<8;i++)
            {
                country = "Aфрика";
                if (vin[11] == Africa[i])
                {
                    return country;
                }
            }
            for (int i = 0; i < 7; i++)
            {
                country = "Азия";
                if (vin[11] == Asia[i])
                {
                    return country;
                }
            }
            for (int i = 0; i < 8; i++)
            {
                country = "Европа";
                if (vin[11] == Europe[i])
                {
                    return country;
                }
            }
            for (int i = 0; i < 5; i++)
            {
                country = "Северная Америка";
                if (vin[11] == UAmerica[i])
                {
                    return country;
                }
            }
            for (int i = 0; i < 2; i++)
            {
                country = "Окенания";
                if (vin[11] == Oceania[i])
                {
                    return country;
                }
            }
            for (int i = 0; i < 2; i++)
            {
                country = "Южная Америка";
                if (vin[11] == NAmerica[i])
                {
                    return country;
                }
            }
            return country;
        }
    }
}
