using System;
namespace first
{
    class Program
    {
        static void Main(string[] args)
        {



            var ToDos = new List<string>();

            while (true)
            {
                Console.WriteLine("**************************************");
                Console.WriteLine("What do you want to do\n 1. [A]dd to do \n 2. [R]emove Todo \n 3. [S]ee all todo \n 4. [E]xit to do");
                string? choice = Console.ReadLine();
                switch (choice?.ToUpper())
                {
                    case "A":
                        AddToDo();
                        break;
                    case "R":
                        RemoveToDo();

                        break;
                    case "S":
                        showAllTodos();
                        break;
                    case "E":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("invalid input");
                        break;


                }
            }

            //addToDo  function
            void AddToDo()
            {
                bool invalidInput;
                do
                {

                    Console.Write($"enter the description you want to add to do::");
                    string? userTodo = Console.ReadLine();
                    if (ToDos.Contains(userTodo))
                    {
                        invalidInput = true;
                        Console.WriteLine("The description in tods must be unique");
                        continue;
                    }
                    else if (string.IsNullOrWhiteSpace(userTodo))
                    {
                        invalidInput = true;
                        Console.WriteLine("The description cannot be empty string or null");
                        continue;

                    }
                    else
                    {
                        invalidInput = false;
                        ToDos.Add(userTodo);
                        Console.WriteLine("Todos added successfully");
                    }

                } while (invalidInput);

            }

            // removeToDo function

            void RemoveToDo()
            {
                int ToDoCount = ToDos.Count;
                Console.WriteLine($"Todo items {ToDos[ToDoCount - 1]} is removed successfully");
                ToDos.RemoveAt(ToDoCount - 1);
            }


            // show all Todos
            void showAllTodos()
            {
                Console.WriteLine($"Your todos List are::");
                int i = 1;
                foreach (var todoItem in ToDos)
                {
                    Console.WriteLine($"{i}.{todoItem}");
                    i++;
                }
            }




        }
    }
}
