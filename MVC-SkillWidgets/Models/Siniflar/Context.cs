using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC_SkillWidgets.Models.Siniflar
{
    public class Context:DbContext
    {
        public DbSet<Yetenek> Yeteneks { get; set; }
    }
}