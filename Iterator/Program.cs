using Iterator.Notes;
using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            RunNotesDemo();
        }
        private static void RunNotesDemo()
        {
            Notebook notebook = new Notebook();
            int count = 3;
            for(int i = 0; i < count; i++)
            {
                notebook.AddNote(new Note($"Hellp{i + 1}", $"Doop{i + 1}"));
            }
            IAbstractIterator iterator = notebook.GetIterator();
            for(Note note = iterator.First(); iterator.IsDone == false;note=iterator.Next())
            {
                note.Show();
            }
        }
    }
}
