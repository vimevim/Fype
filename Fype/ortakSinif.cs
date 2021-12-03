using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;

namespace PasoKey
{
    class ortakSinif
    {
        string[,] keyPad = new string[5, 8] {
            {"a","b","c","d","e","f","g","h"},
            {"i","j","k","l","m","n","o","p"},
            {"q","r","s","t","u","v","w","x"},
            {"y","z","1","2","3","4","5","6"},
            {"7","8","9","0",".",",","!","?"}
        };
        public string x;
        public string TypeTheLetter(int firstStep, int secondStep, string upOrLow)
        {

            if (firstStep == 5)//ilk aksiyonumuz gerçekleşmediyse ikinci aksiyona geçmeyi engelliyorum
            {
                //MessageBox.Show("Lütfen ilk adımı giriniz.");
            }
            else
            {
                if (upOrLow == "low")
                {
                    x = keyPad[firstStep, secondStep];//seçilen karakter hafızada buton değeri olarak tutuluyor
                }
                else
                {
                    x = keyPad[firstStep, secondStep].ToUpper();
                }
            }
            return x;
        }
        public int secondStep;
        public int DeclareSecondStep(double rightAngle)
        {
            if (rightAngle > 337.5 || rightAngle < 22.5)
            {
                secondStep = 4;
            }
            else if (rightAngle > 22.5 && rightAngle < 67.5)
            {
                secondStep = 5;
            }
            else if (rightAngle > 67.5 && rightAngle < 112.5)
            {
                secondStep = 6;
            }
            else if (rightAngle > 112.5 && rightAngle < 157.5)
            {
                secondStep = 7;
            }
            else if (rightAngle > 157.5 && rightAngle < 202.5)
            {
                secondStep = 0;
            }
            else if (rightAngle > 202.5 && rightAngle < 247.5)
            {
                secondStep = 1;
            }
            else if (rightAngle > 247.5 && rightAngle < 292.5)
            {
                secondStep = 2;
            }
            else if (rightAngle > 292.5 && rightAngle < 337.5)
            {
                secondStep = 3;
            }
            return secondStep;
        }
    }
}
