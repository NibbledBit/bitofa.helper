using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitOfA.Helper.Persistence
{
    public interface IGlobalIdentity
    {
        public Guid Identity { get; }
    }
}
