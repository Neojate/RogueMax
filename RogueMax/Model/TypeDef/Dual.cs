using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueMax.Model.TypeDef
{
    public class Dual
    {

        #region ATRIBUTOS
        // Cantidad actual
        public int Current
        {
            get { return Current; }
            set { Current = value > Max ? Max : value; }
        }

        //Cantidad máxima
        public int Max { get; set; }
        #endregion

        #region CONSTRUCTORES
        public Dual(int max)
        {
            Current = max;
            Max = max;
        }

        public Dual(int current, int max)
        {
            Current = current;
            Max = max;
        }
        #endregion

    }
}
