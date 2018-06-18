using MobiManager.Repository.Core;
using MobiManager.RepositoryAbstraction.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobiManager.RepositoryFactory
{
    public class Getter
    {
        public static IRepositoryContext GetRepository()
        {
            bool framework = true;
            if (framework)
            {
                return new RepositoryContext();
            }
            return default(IRepositoryContext);
        }
    }
}
