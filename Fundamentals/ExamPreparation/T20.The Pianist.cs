using System;
using System.Collections.Generic;
using System.Linq;

namespace T20.The_Pianist
{
    class Piece
    {
        public string compositor { get; set; }
        public string note { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var pieces = new Dictionary<string, Piece>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("|");
                string pieceName = input[0];
                if (!pieces.ContainsKey(pieceName))
                {
                    Piece currPiece = new Piece();
                    currPiece.compositor = input[1];
                    currPiece.note = input[2];
                    pieces.Add(pieceName, currPiece);
                }
            }

            string commands = Console.ReadLine();
            while (commands != "Stop")
            {
                string[] currCmd = commands.Split("|");
                if (currCmd[0] == "Add")
                {
                    string pieceName = currCmd[1];
                    if (!pieces.ContainsKey(pieceName))
                    {
                        Piece currPiece = new Piece();
                        currPiece.compositor = currCmd[2];
                        currPiece.note = currCmd[3];
                        pieces.Add(pieceName, currPiece);
                        Console.WriteLine($"{pieceName} by {currCmd[2]} in {currCmd[3]} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{pieceName} is already in the collection!");
                    }
                }
                else if (currCmd[0] == "Remove")
                {
                    string pieceName = currCmd[1];
                    if (pieces.ContainsKey(pieceName))
                    {
                        pieces.Remove(pieceName);
                        Console.WriteLine($"Successfully removed {pieceName}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {pieceName} does not exist in the collection.");
                    }
                }
                else if (currCmd[0] == "ChangeKey")
                {
                    string pieceName = currCmd[1];
                    if (pieces.ContainsKey(pieceName))
                    {
                        pieces[pieceName].note= currCmd[2];
                        Console.WriteLine($"Changed the key of {pieceName} to {currCmd[2]}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {pieceName} does not exist in the collection.");
                    }
                }    
                
                commands = Console.ReadLine();
            }
            pieces = pieces.OrderBy(x => x.Key).ThenBy(x => x.Value.compositor).ToDictionary(k => k.Key, v => v.Value);

            foreach (var item in pieces)
            {
                Console.WriteLine($"{item.Key} -> Composer: {item.Value.compositor}, Key: {item.Value.note}");
            }
        }
    }
}
