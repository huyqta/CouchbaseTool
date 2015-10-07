using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CouchbaseMain.Commons;

namespace CouchbaseMain.Api
{
    public static class Cluster
    {
        public static CouchbaseApi RetrievesClusterInformation = new CouchbaseApi()
        {
            Method = "GET",
            Path = "/pools",
            Description = "Retrieves cluster information."
        };

        public static CouchbaseApi RetrievesClusterDetails = new CouchbaseApi()
        {
            Method = "GET",
            Path = "/pools/default",
            Description = "Retrieves cluster details."
        };

        public static CouchbaseApi AddsNodesToClusters = new CouchbaseApi()
        {
            Method = "POST",
            Path = "/controller/addNode",
            Description = "Adds nodes to clusters."
        };
    }
}
