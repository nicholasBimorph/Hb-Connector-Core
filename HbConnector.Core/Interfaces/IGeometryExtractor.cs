using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HbConnector.Core.Interfaces
{
    /// <summary>
    /// A contract to extract a specific type of geometry
    /// from an element in a host application.
    /// </summary>
    /// <typeparam name="TGeometry">
    /// The output geometry type.
    /// </typeparam>
    /// <typeparam name="THostApp">
    /// A host application type to extract the geometry from.
    /// </typeparam>
    public interface IGeometryExtractor<TGeometry,THostApp>
    {
        IList<TGeometry> Extract(IList<THostApp> hostAppType);
    }
}
