//Program written by: Peggy Walsh/Jenna Lillie (Group)
//Program Date: 2/16/2021
//Program description: Case 1 (Group) - Chapter 4
//Encountered issues: None


using System;
using static System.Console;
class GreenvilleRevenue
{
    static void Main()
    {
        int thisYear;
        int lastYear;
        

        Write("Enter the number of contestants from last year: ");
        lastYear = Convert.ToInt16(ReadLine());

        Write("Enter the number of contestants from this year: ");

        thisYear = Convert.ToInt16(ReadLine());

        if (thisYear == 2 * lastYear)
            WriteLine("The competition is more than twice as big this year!");
        else if ((thisYear > lastYear) && (thisYear != 2 * lastYear))
            WriteLine("The competition is bigger than ever!");
        else
            WriteLine("A tighter race this year! Come out and cast your vote!");   
        
        
        
    }
}