using com.example.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace com.example.host
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("start");

           // log4net.Config.XmlConfigurator.Configure();

            LogHelper.Debug("Debug");
            LogHelper.Info("Info");
            LogHelper.Warn("Warn");
            LogHelper.Error("Error", new Exception("exception throw"));

            Console.WriteLine("end");
            Console.ReadLine();
        }
    }
}
