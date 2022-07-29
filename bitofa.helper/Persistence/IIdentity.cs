using System;

namespace BitOfA.Helper.Persistence {
    public interface IGlobalIdentity {
        public Guid Identity { get; }
    }
}
