
Console.WriteLine("Password Generator: ");
Console.WriteLine("'all' = All useable characters Password");
Console.WriteLine("'some' = Most of usable characters Password");
Console.WriteLine("'nul' = Number and Upper and Lower Case Letter Password");
Console.WriteLine("'ul' = Upper & Lower case letter Password");
Console.WriteLine("'stop' = Program Stops");
Console.WriteLine();

var stopper = true;

while(stopper == true)
{

Console.Write("Enter Choice: ");
var read = Console.ReadLine();

    if (read == "all")
    {
        // All Useable Characters Password
        var randChar = new Random();

        var rnd = randChar.Next(8, 101);

        Console.Write("New Password: ");

        for (int i = 0; i <= rnd; i++)
        {

            var rndChar = randChar.Next(33, 127);
            char chars = (char)rndChar;
            Console.Write((char)chars);
        }
        Console.WriteLine();

    }
    
    else if(read == "some")
    {
        //Generates a New Random Password with Symbols excluding some
        var randChar = new Random();

        var rnd = randChar.Next(8, 101);

        Console.Write("New Password: ");

        for (int i  = 0; i <= rnd; i++)
        {
            var rndChar = randChar.Next(49, 123);
            char chars = (char)rndChar;
            Console.Write((char)chars);
        }
        Console.WriteLine();
    }

    else if(read == "nul")
    {
        // Number and Upper and Lower Case Letter Password
        var randChar = new Random();

        var rnd = randChar.Next(8, 101);

        Console.Write("New Password: ");

        for (int i = 0; i <= rnd; i++)
        {

            var rndChar = randChar.Next(49, 123);
            if ((rndChar > 90 && rndChar < 97) || (rndChar > 57 && rndChar < 65 ))
            {
                i--;
            }
            else
            {
                char chars = (char)rndChar;
                Console.Write((char)chars);
            }
        }
        Console.WriteLine();
    }

    else if(read == "ul")
    {
        // Just upper & lower case letter Password
        var randChar = new Random();

        var rnd = randChar.Next(8, 101);

        Console.Write("New Password: ");

        for (int i = 0; i <= rnd; i++)
        {

            var rndChar = randChar.Next(65, 123);
            if(rndChar > 90 && rndChar < 97) {
                i--;
            }
            else { 
                char chars = (char)rndChar;
                Console.Write((char)chars);
            }
        }
        Console.WriteLine();
    }

    else if(read == "stop")
    {
        Console.WriteLine("PASSWORD FOUND!");
        stopper = false;
    }

    else
    {
        Console.WriteLine("Invalid Input");
    }


}

