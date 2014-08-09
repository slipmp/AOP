using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AOP.Dto;

namespace AOP.Domain.Interface
{
    public interface IPressReleaseService
    {
        void InserPressRelease(PressReleaseDto pressRelease);
        PressReleaseDto GetPressRelease(Guid workflowId);
    }
}
