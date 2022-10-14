﻿using Core.Entities;

namespace Entities.Concrete
{
    public class Customer:IEntity
    {
        public int UserId { get; set; }
        public int CustomerId { get; set; }
        public string CompanyName { get; set; }
    }
}
