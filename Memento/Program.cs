using Memento.ToDos;
using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            RunToDoDemo();
            //dz br 2 i 4 
        }
        private static void RunToDoDemo()
        {
            ToDoItem toDoItem = new ToDoItem(
                "Buy bread",
                "Go to the bakery.Buy bread.", 
                new System.DateTime(2021,5,7,13,55,55)
                );
            ToDos.Memento memento = toDoItem.StoreState();
            CareTaker careTaker = new CareTaker();
            careTaker.Save ("Bread" ,memento);

            Console.WriteLine(toDoItem);
            toDoItem.Rename("Buy milk.");
            careTaker.Save("Milk", toDoItem.StoreState());
            Console.WriteLine(toDoItem);

            toDoItem.RestoreState(careTaker.GetState("Bread"));
            Console.WriteLine(toDoItem);
            toDoItem.RestoreState(careTaker.GetState("Milk"));
            Console.WriteLine(toDoItem);
        }
    }
}
