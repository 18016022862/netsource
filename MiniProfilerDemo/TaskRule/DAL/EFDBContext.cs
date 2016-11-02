using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TaskRule.Models;
namespace TaskRule.DAL
{
    public class EFDBContext:DbContext
    {
        public DbSet<MemberBase> DBMemberBase { get; set; }

        public DbSet<Act_Record> DBAct { get; set; }

        public EFDBContext() : base("JYDB") { 
        
        }
    }
}