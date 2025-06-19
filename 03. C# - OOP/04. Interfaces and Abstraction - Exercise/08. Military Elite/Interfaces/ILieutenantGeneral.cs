using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._Military_Elite.Interfaces
{
    internal interface ILieutenantGeneral : IPrivate
    {
        ICollection<IPrivate> ListOfPrivates { get; }
    }
}
