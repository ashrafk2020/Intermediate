using System.Data.Common;
using System.Diagnostics;
using System;

namespace Intermediate
{   
    class Program
    {
        static void Main(string[] args)
        {
            #region classes
            // Person person = new Person();
            // person = Person.Parse("Mahmoud" , 37);
            // person = Person.Parse(null , 0);
            // person.Introduce("Omar");
            // Person newPerson = new Person
            // {
            //     name = "Ashraf",
            //     age = 37
            // };
            // newPerson.Introduce("Ebtehal");

            // Point point = new Point(265,9);
            // // int result = point.Add(10,20,30,4,50);
            // // System.Console.WriteLine(result);
            // int sum = 5;
            // point.AddToTheNumber( ref  sum);

            // // ref must be assigned before passing in the methode
            // // out can be passed with out initializing

            // point.Move(new Point(11,12));
            // bool hasValue = point.TryGetX(out int x , out int y);
            // if(hasValue)
            // {
            //  System.Console.WriteLine("THE X value is {0} the Y is {1}" , x , y);

            // }
            // point.Move(5,6);
            // System.Console.WriteLine("THE X value is {0} the Y is {1}" , point.x , point.y);
            // point.Move(null);

            // var calculator = new Calculator();
            //  sum = calculator.Add(5,6,8,9,10);
            // System.Console.WriteLine($"sum is {sum}");

            // var anotherPerson = Person.Parse("Omar" , 10);
            // anotherPerson.SetBirthDate(new DateTime(2013,4,30));
            // System.Console.WriteLine(anotherPerson.GetBirthDate());
            #endregion
            #region  Excersise 1
            // var stopWach = new StopWatch();
            // System.Console.WriteLine("type 'S' To start StopWach and 'E' to end");

            // while (true)
            // {
            //     var order = Console.ReadLine();
            //     if(order == "S")
            //     {
            //         System.Console.WriteLine("Started!");

            //         stopWach.Start();
            //     }
            //     if(order == "E")
            //     {
            //         System.Console.WriteLine(" try stopping Started!");

            //         stopWach.Stop();
            //         System.Console.WriteLine("Time Duration :{0}", stopWach.GetDuration());
            //          System.Console.WriteLine("type 'S' To start StopWach and 'E' to end");
            //     }
            //     if(order == "Q")
            //     {
            //         break;
            //     }
            // }


            #endregion
            #region  Excercise 2
            // Post newPost = new Post("hello friends" , "this post talk about how to greet friends");
            // for (int i = 0; i < 4; i++)
            // {
            //   newPost.UpVote();
                
            // }
            // newPost.DownVote();

            // System.Console.WriteLine(newPost.GetVoteValue());
            // System.Console.WriteLine(newPost.GetCreateDate());
            
            #endregion
            #region Stack
            // Stack<string>  stack = new Stack<string>();
            
            // stack.Push("ashraf");
            // stack.Push("mostafa");
            // stack.Push("kamal");
            // stack.Push("mohammed");

            // int stackCount = stack.GetStackElementsCount();

            // for (int i = 0; i < stackCount; i++)
            // {
            //     System.Console.WriteLine(stack.Pop());
            // }

            #endregion
            #region abstract and polymorphism
            // var dpCommand = new DbCommand(new SqlConnection("+SQL+") , "Running the Command Now");
            // dpCommand.Excute();
            //  dpCommand = new DbCommand(new OracleConnection("+ORACLE+") , "Running the Command Now");
            //  dpCommand.Excute();
            #endregion
            #region Excersice workFlow Engine
            // var firstActivity = new FirstActivity();
            // var sceActivity = new SecActivity();
            // var workFlow = new WorkFlow();
            // workFlow.AddActivities(sceActivity);
            // workFlow.AddActivities(firstActivity);
            //  workFlow.AddActivities(sceActivity);
            // workFlow.AddActivities(firstActivity);
            

            // var workFlowEngine = new WorkFlowEngine();
            // workFlowEngine.Run(workFlow);

            #endregion
      
      
        }
    }
}
