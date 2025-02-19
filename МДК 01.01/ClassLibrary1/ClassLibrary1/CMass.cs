using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class CMass
    {
        private int[] mass;
        //Конструкторы

        public CMass(int lenght)
        {
            mass = new int[lenght];
        }
        public CMass(int[] massValue)
        {
            mass = new int[massValue.Length];
            mass = massValue;
        }
        //Свойство определения длинный массива
        public int this[int i]
        {
            get { return mass[i]; }
            set { mass[i] = value; }
        }
        //ВЫЧИСЛЕНИЕ ПРОИЗВЕДЕНИЯ МАССИВА С ЧЕТНЫМИ НОМЕРАМИ
        public int compositionMass()
        {
            int composit = 1;
            bool isComposit = false;
            for (int i = 0; i < mass.Length; i++)
            {
                if ((i + 1) % 2 == 0)
                {
                    composit = composit * mass[i];
                    isComposit = true;
                }
            }
            if (isComposit) return composit;
            else return 0;
        }
        //вычисление произведения массива в интервале зачений номеров массива
        public int compositionMass (int primary, int lastThing)
        {
            int composit = 1;
            bool isComposit = false;
            for (int i = primary; i < lastThing; i++)
            {
                composit = composit * mass[i];
                isComposit = true;
            }

            if (isComposit) return composit;
            else return 0;
        }
    }
}
