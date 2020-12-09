using CatsTagram.Server.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CatsTagram.Server.Data
{
    public class CatsTagramDbContext : IdentityDbContext<User>
    {
        public CatsTagramDbContext(DbContextOptions<CatsTagramDbContext> options)
            : base(options)
        {
        }
    }
}
