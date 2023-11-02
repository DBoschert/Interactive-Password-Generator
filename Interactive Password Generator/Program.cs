using System.Linq;
using System.Text;

Console.WriteLine("Password Generator: ");
Console.WriteLine("'all' = All useable characters Password");
Console.WriteLine("'some' = Most of usable characters Password");
Console.WriteLine("'nul' = Number and Upper and Lower Case Letter Password");
Console.WriteLine("'ul' = Upper & Lower case letter Password");
Console.WriteLine("'il' = Just I's, L's, i's, l's");
Console.WriteLine("'stop' = Program Stops");
Console.WriteLine();

var stopper = true;

while(stopper == true)
{

Console.Write("Enter Choice: ");
var read = Console.ReadLine();

    if (read == "all" || read == "ALL")
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
    
    else if(read == "some" || read == "SOME")
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

    else if(read == "nul" || read == "NUL")
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

    else if(read == "ul" || read == "UL")
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

    else if (read == "il" || read == "IL")
    {
        // Just i's, l's, I's, L's
        char[] il = {'i','l','I', 'L'};

        var randChar = new Random();

        var rand = randChar.Next(8, 101);


        Console.Write("New Password: ");

        for (int i = 0; i <= rand; i++)
        {
            var rnd = randChar.Next(0, 4);
            Console.Write(il[rnd]);

        }
        Console.WriteLine();
    }

    //----------------------- 

   
    else if (read == "top secret" || read == "TOP SECRET")
    {
        // DREW drew DREW and checks if the word drew is spelled and prints YOU HAVE DONE IT if it is spelled in correct order
        char[] drew = { 'd', 'r', 'e', 'w' };

        var randChar = new Random();

        var rand = randChar.Next(8, 101);

        char[] secrets = new char[rand + 1];

        Console.Write("New Password: ");

        for (int i = 0; i <= rand; i++)
        {
            var rnd = randChar.Next(0, 4);
            Console.Write(drew[rnd]);

            secrets[i] = drew[rnd];



        }
        string concatDrew = "";
        foreach(char c in secrets)
        {
            concatDrew += c;
        }

        if(concatDrew.IndexOf("drew") > 1)
        {
            Console.WriteLine();
            Console.WriteLine("YOU HAVE DONE IT!!!!");
            Console.WriteLine("YOU HAVE FOUND A DREW!!!!!");
        }


        Console.WriteLine();
    }

    

    //---------------------

    else if(read == "stop" || read == "STOP")
    {
        Console.WriteLine("PASSWORD FOUND!");
        stopper = false;
    }

    else
    {
        Console.WriteLine("Invalid Input");
    }

}

