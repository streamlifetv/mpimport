﻿namespace MpMigrate.Data.Entity
{
    using System.Collections.Generic;

    public class Reseller
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Organization { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string fax { get; set; }

        public List<HostPlan> HostPlans { get; set; }
        public HostLimit Limits { get; set; }

        public Reseller()
        {
            Limits = new HostLimit();
            HostPlans = new List<HostPlan>();
        }
    }
}
