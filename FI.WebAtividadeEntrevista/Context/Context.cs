using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;
using WebAtividadeEntrevista.Models;

namespace WebAtividadeEntrevista.Context
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options):base(options)
        
            {

            }
        public DbSet<ClienteModel> ClienteModel { get; set; }
    }
}