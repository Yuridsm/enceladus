using BusinessContracts;
using BusinessEntities.CustomerEntity;
using System;
using System.Collections.Generic;

namespace BusinessEntities.DriverEntity
{
    public class Driver : Identifier
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
        public List<Customer> Customers { get; set; }
    }
}
