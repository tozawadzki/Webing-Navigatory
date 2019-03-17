using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using B2TomaszZawadzkiZadDom6.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace B2TomaszZawadzkiZadDom6.Context
{
    public class ApplicationDataContext : IdentityDbContext<AppUser>
    {
        public ApplicationDataContext()
            : base("DefaultConnection")
        { }

        public System.Data.Entity.DbSet<AppUser> AppUsers { get; set; }
    }
}