

using Models.Concrete;
using Models.Concrete.Filters;
using Repository.Concrete.Database;
using System;

namespace Archive
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentsRepo repo = new DocumentsRepo();
            //repo.Add(new Document { document_id=2, existence=true, owner_id=1, type="заліковка" });
            //if(repo.Delete(new DocumentFilter { owner_id = 1, type = "заліковка"})==false) Console.Write("error");
            //if (!repo.Update(new DocumentFilter { owner_id = 1, type = "заліковка" }, new DocumentFilter { existence = false, type = "не заліковка" }))
            //{ Console.Write("error"); }
            //var a=repo.Get(new DocumentFilter { owner_id = 1 });

            Console.Read();
        }
    }
}
