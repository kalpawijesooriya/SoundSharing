namespace MusicShareing
{
    using System;
    using System.Data.Entity;
    using MusicShareing.Models;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DefaultConnection : DbContext
    {
        public DefaultConnection()
            : base("name=DefaultConnection")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
          
        }

     
    }
}
