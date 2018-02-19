using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;

namespace wq_deps_repro
{
    public class SomeClass
    {
        public ConnectionFactory _factory;


        public SomeClass()
        {

        }

        public string SomeFunctionReturningString()
        {
            this._factory = new ConnectionFactory()
            {
                UserName = "",
                Password = "",
                VirtualHost = "/",
                HostName = "",
                Port = 1235
            };

            return "just something returned";
        }
    }
}
