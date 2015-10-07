using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace CouchbaseMain.Commons
{
    public class CouchbaseApi
    {
        public string Method { get; set; }

        public string Path { get; set; }

        public string Description { get; set; }
    }
}
