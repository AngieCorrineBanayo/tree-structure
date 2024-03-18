using System;

class Program
{
    static void Main(string[] args)
    {
        string userChoice = "";
        bool exit = false;

    Home:
        if (!exit)
        {
            Console.WriteLine("Home");
            Console.WriteLine("a. Web Application Security");
            Console.WriteLine("b. Big Data Processing Frameworks");
            Console.WriteLine("c. Close");
            Console.Write("Enter your choice (a/b/c): ");
            userChoice = Console.ReadLine().ToLower();

            if (userChoice == "a")
            {
                goto WebApplicationSecurity;
            }
            else if (userChoice == "b")
            {
                goto BigDataProcessingFrameworks;
            }
            else if (userChoice == "c")
            {
                exit = true;
                goto End;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
                goto Home;
            }

            Console.WriteLine();
        }

    WebApplicationSecurity:
        Console.WriteLine("Web Application Security");
        Console.WriteLine("a. Authentication");
        Console.WriteLine("b. Authorization");
        Console.WriteLine("c. Back");
        Console.Write("Enter your choice (a/b/c): ");
        userChoice = Console.ReadLine().ToLower();

        if (userChoice == "a")
        {
            goto Authentication;
        }
        else if (userChoice == "b")
        {
            goto Authorization;
        }
        else if (userChoice == "c")
        {
            goto Home;
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
            goto WebApplicationSecurity;
        }

    Authentication:
        Console.WriteLine("Authentication");
        Console.WriteLine("a. Password-based");
        Console.WriteLine("b. Token-based (JWT)");
        Console.WriteLine("c. Back");
        Console.Write("Enter your choice (a/b/c): ");
        userChoice = Console.ReadLine().ToLower();

        if (userChoice == "a")
        {
            Console.WriteLine("Password-based");
        }
        else if (userChoice == "b")
        {
            Console.WriteLine("Token-based (JWT)");
        }
        else if (userChoice == "c")
        {
            goto WebApplicationSecurity;
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
            goto Authentication;
        }
        Console.WriteLine();
        goto Authentication;

    Authorization:
        Console.WriteLine("Authorization");
        Console.WriteLine("a. Role-based");
        Console.WriteLine("b. Attribute-based");
        Console.WriteLine("c. Back");
        Console.Write("Enter your choice (a/b/c): ");
        userChoice = Console.ReadLine().ToLower();

        if (userChoice == "a")
        {
            Console.WriteLine("Role-based");
        }
        else if (userChoice == "b")
        {
            Console.WriteLine("Attribute-based");
        }
        else if (userChoice == "c")
        {
            goto WebApplicationSecurity;
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
            goto Authorization;
        }
        Console.WriteLine();
        goto Authorization;

    BigDataProcessingFrameworks:
        Console.WriteLine("Big Data Processing Frameworks");
        Console.WriteLine("a. Batch Processing");
        Console.WriteLine("b. Stream Processing");
        Console.WriteLine("c. Back");
        Console.Write("Enter your choice (a/b/c): ");
        userChoice = Console.ReadLine().ToLower();

        if (userChoice == "a")
        {
            goto BatchProcessing;
        }
        else if (userChoice == "b")
        {
            goto StreamProcessing;
        }
        else if (userChoice == "c")
        {
            goto Home;
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
            goto BigDataProcessingFrameworks;
        }

    BatchProcessing:
        Console.WriteLine("Batch Processing");
        Console.WriteLine("a. Hadoop MapReduce");
        Console.WriteLine("b. Apache Spark");
        Console.WriteLine("c. Back");
        Console.Write("Enter your choice (a/b/c): ");
        userChoice = Console.ReadLine().ToLower();

        if (userChoice == "a")
        {
            Console.WriteLine("Hadoop MapReduce");
        }
        else if (userChoice == "b")
        {
            Console.WriteLine("Apache Spark");
        }
        else if (userChoice == "c")
        {
            goto BigDataProcessingFrameworks;
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
            goto BatchProcessing;
        }
        Console.WriteLine();
        goto BatchProcessing;

    StreamProcessing:
        Console.WriteLine("Stream Processing");
        Console.WriteLine("a. Apache Kafka");
        Console.WriteLine("b. Apache Flink");
        Console.WriteLine("c. Back");
        Console.Write("Enter your choice (a/b/c): ");
        userChoice = Console.ReadLine().ToLower();

        if (userChoice == "a")
        {
            Console.WriteLine("Apache Kafka");
        }
        else if (userChoice == "b")
        {
            Console.WriteLine("Apache Flink");
        }
        else if (userChoice == "c")
        {
            goto BigDataProcessingFrameworks;
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
            goto StreamProcessing;
        }
        Console.WriteLine();
        goto StreamProcessing;

    End:
        Console.WriteLine("Closing the program...");
    }
}

