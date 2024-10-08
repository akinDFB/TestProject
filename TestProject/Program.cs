
//datatypes
//string
//integer int
//decimal
//float
//double
//char
//byte
//booloan bool
//long
//datetime

//int number = 789324556; //field
//Console.WriteLine(number);

//string word = "chalk";
//Console.WriteLine(word);

//decimal decimalnumber = 6766667668089089799.5654m;
//Console.WriteLine(decimalnumber);

//char charnumber = 'r';
//byte bytenumber = 67;
//bool boolword = false;
//DateTime dateTime = DateTime.Now;

//var y = "duble";
//Console.WriteLine(dateTime);

//Console.Write("What is your Last name ?: ");
//string lastName = Console.ReadLine();
//Console.Write("What is your First name?: ");
//string firstName = Console.ReadLine();

//Console.WriteLine("Hello. Your last name is {0} while your first name is {1}", lastName, firstName);

//Console.WriteLine("\"hello\"");
//Console.WriteLine(@"one\two\three");
//Console.WriteLine("one\ntwo\nthree");

//int number = 10;
//int anotherNumber = 21;
//if (number == 10 || anotherNumber % number == 0)
//{
//    Console.WriteLine(true);
//}

//int number = 10;
//bool isNumber;

//if (number  == 10  )
//{
//    isNumber = true;
//}
//else
//{
//    isNumber = false;
//}

//ternary operator

//int number = 15;
//bool isNumber10 = number == 10 ? true : false;
//Console.WriteLine("Number == 10 is {0}", false);

//bool? isMajor = null;
//if (isMajor == true)
//
//    Console.WriteLine("User is Major");
//}
//else if(isMajor == false)
//{
//    Console.WriteLine("User is not Major");
//}
//else 
//{
//    Console.WriteLine("Oga you did not answer the question");
//}

//converting non nullable datatype to nullable data type

//int? TicketOnSale = null;
//int AvailableTicket;
//if (TicketOnSale == null)
//{
//    AvailableTicket = 0;
//}
//else
//{
//    AvailableTicket = (int)TicketOnSale;
//}
//Console.WriteLine("AvailableTicket = {0}", AvailableTicket);

//Null Coalescing Operator

//int? TicketonSale = 100;
//int AvailableTickets = TicketonSale ?? 0;
//Console.WriteLine("AvailableTicket = {0}", AvailableTickets);

//DataTypeConversion

//double f = 236636262617727.33D;
//long i = Convert.ToInt64(f);
//Console.WriteLine(i);

//string num = "100";
//int i = int.Parse(num);
//Console.WriteLine(i);


//converting string to text. use parse if you're sure the output value will be valid. else use tryparse.

//string num = "100";
//int Result = 0;
//bool isConversible = int.TryParse(num, out Result);
//if (isConversible)
//{
//    Console.WriteLine("Result");
//}
//else
//{
//    Console.WriteLine("Please enter a valid number");
//}

//Arrays

//int[] evenNumbers = new int[4];
//evenNumbers[0] = 0;
//evenNumbers[1] = 2;
//evenNumbers[2] = 4;
//evenNumbers[3] = 6;
//Console.WriteLine(evenNumbers[1]);

//if

//Console.Write("Oga enter your number: ");
//int number = int.Parse(Console.ReadLine());
//if (number % 2 == 0)
//{
//    Console.WriteLine("Your number is even");
//}
//else
//{
//    Console.WriteLine("Your number is odd");
//}

//Console.Write("Enter number: ");
//int num = int.Parse(Console.ReadLine());
//if (num == 10)
//{
//    Console.WriteLine("Your number is 10");
//}
//else if (num == 20)
//{
//    Console.WriteLine("Your number is 20");
//}
//else if(num == 30)
//{
//    Console.WriteLine("Your number is 20");
//}
//else
//{
//    Console.WriteLine("Your number is not 10, 20 or 30");
//}

//switch statement

//Console.Write("Enter number: ");
//int num = int.Parse(Console.ReadLine());

//switch(num)
//{
//    case 10:
//        Console.WriteLine("Your number is 10");
//        break;
//    case 20: Console.WriteLine("Your number is 20");
//        break;
//    case 30: Console.WriteLine("Your number is 30");
//        break;
//    default:
//        Console.WriteLine("Your number is not 10, 20 or 30");
//        break;
//}

//Console.Write("Enter number: ");
//int num = int.Parse(Console.ReadLine());

//switch (num)
//{
//    case 10:
//    case 20:
//    case 30:
//        Console.WriteLine("Your name is {0}", num);
//        break;
//    default:
//        Console.WriteLine("Your number is not 10, 20 or 30");
//        break;
//}

//int coffeeCost = 0;
//Start:
//Console.WriteLine("Coffee Menu: 1 - Small, 2 - Medium, 3 - Large. Please select one");
//int cost = int.Parse(Console.ReadLine());

//switch (cost)
//{
//    case 1:
//        coffeeCost += 1;
//        break;
//    case 2:
//        coffeeCost += 2;
//        break;
//    case 3:
//        coffeeCost += 3;
//        break;
//    default:
//        Console.WriteLine("Sorry. We only have options 1, 2 and 3. Your choice {0} is invalid", cost);
//        goto Start;

//}

//Decide:
//Console.WriteLine("Would you like to order again ? Please input yes or no: ");
//string userChoice = Console.ReadLine();

//switch (userChoice.ToUpper())
//{
//    case "YES":
//        goto Start;
//    case "NO":
//        break;
//    default:
//        Console.WriteLine("Please enter yes or no");
//        goto Decide;

//}

//Console.WriteLine("Bill Amount = ${0}", coffeeCost);
//Console.WriteLine("Thanks for shopping with us");


//while loop 


Console.WriteLine("Enter your target");
int userStart = int.Parse(Console.ReadLine());
int start = 0;
while (start <=userStart)
{
    Console.WriteLine(start);
    start += 2;
}
