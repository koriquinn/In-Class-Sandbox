using System.Collections.Generic;
using System.Linq;
using DataEntities;
using ServerSide.DAL;

namespace ServerSide.BLL
{
    public class CodeDemoController
    {
        public List<CodeDemo> ListAllDemos()
        {
            using (var context = new DemoLibraryContext())
            {
                return context.CodeDemos.ToList();
            }
        }
    }
}
