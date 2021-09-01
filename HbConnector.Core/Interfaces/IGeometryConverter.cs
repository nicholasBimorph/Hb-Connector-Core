using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HB.RestAPI.Core.Interfaces;

namespace HbConnector.Core.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TGeometry">
    /// The host application's geometry to convert from.
    /// </typeparam>
    public interface IGeometryConverter<in TGeometry>
    {
        IHbObject ToHbType(TGeometry geometry);
    }
}
