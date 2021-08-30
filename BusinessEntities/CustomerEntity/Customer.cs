using BusinessContracts;
using System;

namespace BusinessEntities.CustomerEntity
{
    public class Customer : Identifier
    {
        public override Guid IdentifierOfEntity 
        { 
            get
            {
                return Id;
            }
            set
            {
                Id = Guid.NewGuid();
            }
        }
        public string Name { get; set; }
    }
}
