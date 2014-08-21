using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AOP.Domain.Interface;
using AOP.Dto;

namespace AOP.Domain.Implementation
{
    public class PressReleaseService : IPressReleaseService
    {
        public void InserPressRelease(PressReleaseDto pressRelease)
        {
            Console.WriteLine("InserPressRelease - Press Release was created successfully");
        }

        public PressReleaseDto GetPressRelease(Guid workflowId)
        {
            throw new Exception("Error at GetPressRelease");
            Console.WriteLine("Getting a PressReleaseDto from Repository");

            return new PressReleaseDto { Body = "My Body", PressReleaseTitle = "My Title", WorkflowId = new Guid() };
        }
    }
}
