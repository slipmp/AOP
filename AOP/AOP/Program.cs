using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AOP.Domain.Factory;
using AOP.Domain.Interface;
using AOP.Dto;
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

                //pressReleaseService.GetPressRelease(new Guid());
            }

            System.Console.ReadKey();
        }
    }
}
