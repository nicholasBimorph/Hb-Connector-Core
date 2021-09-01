using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HB.RestAPI.Core.Interfaces;

namespace HbConnector.Core.Interfaces
{
    
    public interface IGeometryConverter<in T>
    {
        IHbObject ToHbType(T mesh);
    }
}
