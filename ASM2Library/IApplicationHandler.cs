using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2Library
{
    public interface IApplicationHandler
    {
        void SetNextHandler(IApplicationHandler handler);
        void ProcessApplication(StudentApplication application);
    }

}
