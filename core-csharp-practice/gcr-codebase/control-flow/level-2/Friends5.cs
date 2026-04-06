using System;

class Friends5
{
    static void Main()
    {
        int ageAmar,ageAkbar,ageAnthony;// intilaize the ages
        double heightAmar,heightAkbar,heightAnthony;//intilaioze the heigts

        //take nput Amar details
        Console.WriteLine("Enter Amar age:");
        ageAmar=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Amar height:");
        heightAmar=Convert.ToDouble(Console.ReadLine());

        //taek input Akbar details
        Console.WriteLine("Enter Akbar age:");
        ageAkbar=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Akbar height:");
        heightAkbar=Convert.ToDouble(Console.ReadLine());

        //takle input Anthony details
        Console.WriteLine("Enter Anthony age:");
        ageAnthony=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Anthony height:");
        heightAnthony=Convert.ToDouble(Console.ReadLine());

        //find yongst
        if(ageAmar<ageAkbar&&ageAmar<ageAnthony)
        {
            Console.WriteLine("Amar is youngest");
        }
        else if(ageAkbar<ageAnthony)
        {
            Console.WriteLine("Akbar is youngest");
        }
        else
        {
            Console.WriteLine("Anthony is youngest");
        }

        //find thr talest
        if(heightAmar>heightAkbar&&heightAmar>heightAnthony)
        {
            Console.WriteLine("Amar is tallest");
        }
        else if(heightAkbar>heightAnthony)
        {
            Console.WriteLine("Akbar is tallest");
        }
        else
        {
            Console.WriteLine("Anthony is tallest");
        }
    }
}
