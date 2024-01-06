using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neiroseti.ModelNW
{
    public enum TypeNeuron  // тип нейрона
    {
        Hidden,
        Output
    }
    public enum MemoryMode
    {
        GET,
        SET,
        INIT
    }
    public enum NetworkMode  // режимы работы нейронки
    {
        Train,
        Test,
        Recognize
    }

}
