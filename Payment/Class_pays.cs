using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment
{
    public class Class_pays
    {
        public string Наименование_платежа { get; set; }
        public int Количество { get; set; }
        public double Цена { get; set; }
        public double Сумма { get; set; }
        public string Категория { get; set; }
        public Class_pays(string Наименование_платежа, int Количество, double Цена, double Сумма, string Категория)
        {
            this.Наименование_платежа = Наименование_платежа;
            this.Количество = Количество;
            this.Цена = Цена;
            this.Сумма = Сумма;
            this.Категория = Категория;
        }
    }
}
