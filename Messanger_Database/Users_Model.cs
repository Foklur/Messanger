using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Messanger_Database
{
    public partial class Users_Model : DbContext
    {
        public Users_Model()
            : base("name=Users_Model")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
