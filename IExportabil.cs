using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
    public interface IExportabil
    {
        // Returneaza o reprezentare text formatata a obiectului
        string ExportText();
        // Returneaza o reprezentare XML a obiectului
        string ExportXML();
    }
}
