using DATA.CustomConventions;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{

    public class ArtsukiDBContext : DbContext
    {
        public ArtsukiDBContext() : base("name=Artsuki")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Add(new DateTime2Convention());

        }
    }
}
