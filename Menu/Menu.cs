using Factory.Abstract;
using System;
using Factory.Concrete;
using System.Collections.Generic;
using System.Text;
using Models.Abstract;
using Models.Concrete;
using Models.Concrete.Filters;
using Repository.Abstract;

namespace Menu
{
    public class ConsoleMenu
    {
        public void Init()
        {
            IFactory factory = FactoryProvider.GetFactory("DB");
            IRepository usersRepo = factory.GetRepository("users");
            IRepository documentsRepo = factory.GetRepository("documents");
            IRepository issuanceformsRepo = factory.GetRepository("issuanceforms");
            int choise=0;
            while (choise != 5)
            {
                Console.Write("See information (1)\n" +
                              "Take the document (2)\n" +
                              "Take back the document (3)\n" +
                              "See debtors (4)\n" +
                              "Exit (5)\n");

                choise = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (choise == 1)
                {
                    Console.WriteLine("Choose repository (documents, users, issuanceforms)");
                    string repo = Console.ReadLine();

                    try
                    {
                        List<IModel> models = factory.GetRepository(repo).GetAll();
                        foreach (IModel model in models)
                        {
                            Console.WriteLine(model);
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Can't find repository \"{0}\"",repo);
                    }
                }
                else if (choise == 2)
                {
                    //todo
                    Console.WriteLine("Enter user's name: ");
                    
                    //try
                    User user=(User)usersRepo.Get(new UserFilter { user_name = Console.ReadLine() })[0];

                    //try
                    List<IModel> documents = documentsRepo.Get(new DocumentFilter { owner_id=user.user_id });

                    Console.WriteLine("Choose document:");

                    for (int i=0;i< documents.Count;i++)
                    {
                        Console.WriteLine((i+1).ToString()+ ":\n" +documents[i]);
                    }

                    int documentNumber = Convert.ToInt32(Console.ReadLine())-1;

                    if
                    (
                    issuanceformsRepo.Add(new IssuanceForm
                    {
                        date_of_issue = DateTime.Now,
                        was_returned = false,
                        document_id = ((Document)documents[documentNumber]).document_id,
                        user_id = user.user_id
                    })
                    )
                    {
                        documentsRepo.Update(new DocumentFilter)
                        Console.WriteLine("\nDone");
                    }
                    else Console.WriteLine("\nError");

                }
                else if (choise == 3)
                {

                }
                else if (choise == 4)
                {

                }
            }
        }
    }
}
