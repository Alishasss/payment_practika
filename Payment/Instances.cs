using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment
{
    internal class Instances
    {
        private static Расчет_платежейEntities _db = null;
        public static Расчет_платежейEntities db
        {
            get
            {
                if (_db == null)
                    _db = new Расчет_платежейEntities();
                return _db;
            }
        }

    }
}
