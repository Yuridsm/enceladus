using System;

namespace BusinessContracts
{
    public abstract class Identifier
    {
        protected Guid Id;
        public abstract Guid IdentifierOfEntity { get;set; }
    }
}
