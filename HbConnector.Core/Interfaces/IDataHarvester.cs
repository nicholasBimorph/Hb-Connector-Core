using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HB.RestAPI.Core.Models;

namespace HbConnector.Core.Interfaces
{
    public interface IDataHarvester
    {

        IList<DataNode> Harvest();
    }
}
