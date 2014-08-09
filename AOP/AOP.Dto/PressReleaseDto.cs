using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOP.Dto
{
    public class PressReleaseDto
    {
        private Guid _workflowId;

        private string _pressReleaseTitle;

        private string _body;

        public Guid WorkflowId
        {
            get { return _workflowId; }
            set { _workflowId = value; }
        }
        

        public string PressReleaseTitle
        {
            get { return _pressReleaseTitle; }
            set { _pressReleaseTitle = value; }
        }
        
        public string Body
        {
            get { return _body; }
            set { _body = value; }
        }
    }
}
