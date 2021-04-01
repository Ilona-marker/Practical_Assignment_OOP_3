using System;
using System.Collections;
using System.Collections.Generic;
 
namespace Practical_Assignment_OOP_3
{
  //Create a new class with the main method in it.
  class Program
  {
      static void Main(string[] args)
      {
       //a. Create seven Officers as the objects, two Districts as the objects and three Lawyers as the objects.  
       Officer officer1 = new Officer();
       Officer officer2 = new Officer("John", "Doe", 3347, 12);
       Officer officer3 = new Officer("Anna", "Black", 3348, 25);
       Officer officer4 = new Officer("Stive", "Roze", 3349, 33);
       Officer officer5 = new Officer("Antuan", "Zeben",3350, 44);
       Officer officer6 = new Officer("Bete", "Deniro", 3351, 10);
       Officer officer7 = new Officer("Alex", "Stone", 3352, 8);
       District district1 = new District();
       District district2 = new District("East", "Riga", 1006, new Officer[0]);
       Lawyer lawyer1 = new Lawyer();
       Lawyer lawyer2 = new Lawyer("Aivar", "Arajs", 225, 10);
       Lawyer lawyer3 = new Lawyer("Andris", "Dzerve", 226, 20);
       //b. Add three Officers in the first District and others in the second District.
       district1.AddNewOfficer(officer1);
       district1.AddNewOfficer(officer2);
       district1.AddNewOfficer(officer3);
       district2.AddNewOfficer(officer4);
       district2.AddNewOfficer(officer5);
       district2.AddNewOfficer(officer6);
       district2.AddNewOfficer(officer7);
       
       //c. Print out all information about each District. 
       Console.WriteLine(district1);
       Console.WriteLine(district2);
      
       //d. Print out information about all Lawyers.
       Console.WriteLine(lawyer1);
       Console.WriteLine(lawyer2);
       Console.WriteLine(lawyer3);
       
       //e. Create an ArrayList for Lawyers storing. Put all Lawyers in it.
       //Add using System.Collections;
       //ArrayList lawyers = new ArrayList();
       List<Lawyer> lawyers = new List<Lawyer>();
       lawyers.Add(lawyer1);
       lawyers.Add(lawyer2);
       lawyers.Add(lawyer3);

       //f. Find out the total number of the crimes in which solving the Lawyers were involved. 
        int countHelpedSolvingCrimes = 0;
        foreach (Lawyer lawyer in lawyers)
        {
          countHelpedSolvingCrimes += lawyer.GetHelpedinCrimesSolving();
        }
        Console.WriteLine($"Lawers have helped to solve {countHelpedSolvingCrimes}");

        //g. Find out which Lawyer has helped the most to solve crimes
        Lawyer mostHelpful = lawyers[0];
        //for this we have to change ArrayList to List<Lawyer> and add using System.Collections.Generic;
        for (int i = 1; i < lawyers.Count; i++)
        {
          Lawyer current = lawyers[i];
          if (mostHelpful.GetHelpedinCrimesSolving() < current.GetHelpedinCrimesSolving())
          {
            mostHelpful = current;
          }
        }
        Console.WriteLine($"The most helpful lawyer is {mostHelpful}.");
      }
  }
}