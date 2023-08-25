// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations.Schema;

islemler voting = new islemler();
string[] arr = new string[] {"(0)Horror", "(1)Adventure", "(2)Sci-Fi", "(3)Kids", "(4)Triller", "(5)Love"};
int[] votes = new int[] { 0, 0, 0, 0, 0, 0 };
List<string> ulist = new List<string>() { "Alp"};
while (true)
{
    Console.WriteLine("(1) Vote");
    Console.WriteLine("(2) See Results");
    int selection = int.Parse(Console.ReadLine());
    float top = 0;
    if (selection == 1)
    {
        bool b = voting.userchecker(ulist);
        if (b)
        {
            int v = voting.vote(arr);
            votes[v] += 1;
        }
        else
        {
            Console.WriteLine("User did not found.");
            Console.WriteLine("Please subscribe to vote");
            Console.WriteLine("New Username: ");
            string ss = Console.ReadLine();
            ulist.Add(ss);
        }
    }
    else if (selection == 2) 
    { 
        for (int i = 0; i < votes.Length; i++)
        {
            foreach(int d in votes)
            {
                top+=d;
            }
            Console.WriteLine(arr[i] + ":" + votes[i]+"(" + ((votes[i] * 100) / top)+"%)");
        }
        
    }  
}



class islemler
{
    public int vote(string[] arr)
    { 
            foreach (string str in arr)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("Please vote for one of the movie style: ");
            int i = int.Parse(Console.ReadLine());
            return i;         
    }
    public bool userchecker( List<string> ulist)
    {
        Console.WriteLine("Username: ");
        string s = Console.ReadLine();
        if (ulist.Contains(s))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}