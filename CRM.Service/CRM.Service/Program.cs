using SuperGMS.Rpc;
using System;

namespace CRM.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            ServerProxy.Register(typeof(Program).Namespace);
            System.Threading.Thread.Sleep(int.MaxValue);
        }
    }
}
