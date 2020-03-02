using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace CNC.Utils.Artist
{
    public enum Role
    {
        [Description("Diretor")]
        AsDirector = 1,
        [Description("Produtor")]
        AsProducer = 2,
        [Description("Ator")]
        AsActor = 3
    }
}
