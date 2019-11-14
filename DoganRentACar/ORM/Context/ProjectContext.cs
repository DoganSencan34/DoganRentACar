using DoganRentACar.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoganRentACar.ORM.Context
{
    class ProjectContext:DbContext
    {
        public ProjectContext()
        {
            Database.Connection.ConnectionString = "Server=.;Database=DoganRentACar;uid=sa;pwd=1234;";
        }

        public DbSet<Arabalar> Arabalars { get; set; }
        public DbSet<Musteriler> Musterilers { get; set; }
        public DbSet<Kiralama> Kiralamas { get; set; }
        

    }
}
