using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public interface ISale
    {
        void Sales(Campaign campaign);
        void ValidationService(Customer customer);
    }
}
