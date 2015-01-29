using Colaboratorio.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Colaboratorio.Data
{
    public class ColaboratorioDBContext : DbContext
    {
        public DbSet<Projeto> Projetos { get; set; }
    }
}