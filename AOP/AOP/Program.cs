using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AOP.Domain.Factory;
using AOP.Domain.Interface;
using AOP.Dto;
using System.Diagnostics;

namespace AOP.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            foreach (var container in new IoCFactory().GetContainerList())
            {
                var pressReleaseService = container.Resolve<IPressReleaseService>();
                var entity = new PressReleaseDto { Body = "My Body", PressReleaseTitle = "My Title", WorkflowId = new Guid() };

                pressReleaseService.InserPressRelease(entity);

                System.Console.WriteLine("Container " + container.GetType().Name + " has finished." +
                                         Environment.NewLine);
                System.Console.WriteLine("****************************************************" +
                                         Environment.NewLine);
            }

            foreach (var container in new IoCFactory().GetContainerList())
            {
                System.Console.WriteLine("Container " + container.GetType().Name + " Performance test has started." +
                                             Environment.NewLine);
                var watch = Stopwatch.StartNew();

                for(int i=0;i<1000;i++)
                {
                    var pressReleaseService = container.Resolve<IPressReleaseService>(); 
                }

                watch.Stop();

                System.Console.WriteLine("Container " + container.GetType().Name + " Performance test has finished." +
                                             Environment.NewLine);
                System.Console.WriteLine("Time: " + watch.ElapsedMilliseconds + " milliseconds."+Environment.NewLine);

                System.Console.WriteLine("****************************************************" +
                                             Environment.NewLine);

            }

            System.Console.ReadKey();
        }
    }
}
