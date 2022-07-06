
bool loop = true;
while (loop == true)
{
    Console.WriteLine("Enter a number");
    int input = int.Parse(Console.ReadLine());
    int total = 0;
    for (int i = 1; i <= input; i++)
    {
        total += i;
    }
    Console.WriteLine(total);
    //    for (int i = 0, q = 1, j = 1; j < input; q += i) 
    //    {
    //        j += 1;
    //        q = j + q;
    //        int sum = q;
    //        if (j == input)
    //        {
    //            Console.WriteLine(sum);
    //        }
    //    }
    Console.WriteLine("Would you like to continue? y/n");
    string input2 = Console.ReadLine();
    if (input2 == "y" || input2 == "Y")
    {
        loop = true;
    }
    else if (input2 == "n" || input2 == "N")
    {
        Console.WriteLine("Goodbye!");
        loop = false;
    }
    else
    {
        Console.WriteLine("You did not write y/n. Goodbye!");
        loop = false;
    }
}


