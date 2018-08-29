using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocomotivaServer.Models
{
    public class PimsServerModel : EntityBase
    {
        public virtual string  Server { get; set; }

        public PimsServerModel() { }

        public PimsServerModel(string server)
        {
            Server = server;
        }
    }
}