using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
    public class Activitate:ElementAgenda,ICloneable,IComparable
    {
        #region Atribute
        private Domeniu domeniu;
        private DateTime dataStart;
        private DateTime dataEnd;
        private int prioritate; //1-5, 1 fiind cea mai mica prioritate
        #endregion
    }
}
