using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptc.Demo.Web.Models
{
    public interface IDataTablePayload
    {
        string[] Column { get; set; }
    }
}
