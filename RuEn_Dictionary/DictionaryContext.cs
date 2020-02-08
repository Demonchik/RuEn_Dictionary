using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuEn_Dictionary
{
    public class DictionaryContext: DbContext
    {
        public DictionaryContext(): base("connectStr")
        { }

        public DbSet<Record> Records {get;set;}
    }
}
