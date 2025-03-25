using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;

namespace _06._8_Queens_Puzzle
{
    public class NotesStore
    {
        public NotesStore()
        {
        }

        public List<string> Completed { get; set; } = new List<string>();
        public List<string> Active { get; set; } = new List<string>();
        public List<string> Others { get; set; } = new List<string>();

        public void AddNote(string state, string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name cannot be empty");
            }

            switch (state.ToLower())
            {
                case "completed":
                    Completed.Add(name);
                    break;
                case "active":
                    Active.Add(name);
                    break;
                case "others":
                    Others.Add(name);
                    break;
                default:
                    break;
            }
        }

        public List<string> GetNotes(string state)
        {
            switch (state.ToLower())
            {
                case "completed":
                    return Completed;
                case "active":
                    return Active;
                case "others":
                    return Others;
                default:
                    break;
            }

            return new List<string>();
        }
    }

    internal class Program
    {
        public static void Main()
        {
            var notesStoreObj = new NotesStore();
            var n = int.Parse(Console.ReadLine());

            for (var i = 0; i < n; i++)
            {
                var operationInfo = Console.ReadLine().Split(' ');
                try
                {
                    if (operationInfo[0] == "AddNote")
                        notesStoreObj.AddNote(operationInfo[1], operationInfo.Length == 2 ? "" : operationInfo[2]);
                    else if (operationInfo[0] == "GetNotes")
                    {
                        var result = notesStoreObj.GetNotes(operationInfo[1]);
                        if (result.Count == 0)
                            Console.WriteLine("No Notes");
                        else
                            Console.WriteLine(string.Join(",", result));
                    }
                    else
                    {
                        Console.WriteLine("Invalid Parameter");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }
        }

    }
}