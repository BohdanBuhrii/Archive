

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
            //DocumentsRepo repo = new DocumentsRepo();
            //UsersRepo userRepo = new UsersRepo();
            IssuanceFormsRepo issuanceFormsRepo = new IssuanceFormsRepo();

            //repo.Add(new Document { document_id=2, existence=true, owner_id=1, type="заліковка" });
            //if(repo.Delete(new DocumentFilter { owner_id = 1, type = "заліковка"})==false) Console.Write("error");
            //if (!repo.Update(new DocumentFilter { owner_id = 1, type = "заліковка" }, new DocumentFilter { existence = false, type = "не заліковка" }))
            //{ Console.Write("error"); }
            //var a=repo.Get(new DocumentFilter { owner_id = 1 });
            //userRepo.Add(new User { user_id = 6, user_name = "Olesya", email = "olesya@gmail.com", date_of_birth = new DateTime(2000,2,19) });
            //userRepo.Update(new UserFilter { user_name="Petro" },new UserFilter { user_name="Vasya", email="vasya@gmail.com" });
            //var b=userRepo.Get(new UserFilter { user_id=1 });
            //issuanceFormsRepo.Add(new IssuanceForm { date_of_issue = new DateTime(2019, 5, 5), document_id = 1, user_id = 1, was_returned = false });
            //issuanceFormsRepo.Update(
            //    new IssuanceFormFilter { date_of_issue = new DateTime(2019, 5, 5) }, new IssuanceFormFilter { was_returned = true });
            //var c=issuanceFormsRepo.Get(new IssuanceFormFilter { document_id=1, user_id=1 });
            
            //Console.Read();
        }
    }
}
