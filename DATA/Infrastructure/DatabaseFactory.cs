using DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Infrastructure
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private ArtsukiDBContext dataContext;
        public ArtsukiDBContext DataContext { get { return dataContext; } }

        public DatabaseFactory()
        {
            dataContext = new ArtsukiDBContext();
        }

        protected override void DisposeCore()
        {
            // libérer espace mémoire du context
            if(DataContext!=null)
            DataContext.Dispose();
        }
    }

}
