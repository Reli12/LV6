using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Notes
{
    class Notebook : IAbstractCollection
    {
        private List<Note> notes;
        public Notebook()
        {
            //implementation missing!
            notes = new List<Note>();

        }
        public Notebook(List<Note> notes)
        {
            //prisiljavam kopiranje liste 
            this.notes = new List<Note>(notes.ToArray());
        }
        public void AddNote(Note note)
        {
            //implementation missing!
            notes.Add(note);
        }
        public void RemoveNote(Note note)
        {
            //implementation missing!
            notes.Remove(note);
        }
        public void Clear()
        {
            //implementation missing!
            notes.Clear();
        }
        public int Count { get { return this.notes.Count; } }
        public Note this[int index] { get { return this.notes[index]; } }
        public IAbstractIterator GetIterator() { return new Iterator(this); }
    }
 }
