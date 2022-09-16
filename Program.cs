//Calling my assignments in order
Console.WriteLine("Lukewarm projects");
thousRange();
Console.WriteLine("");
multByThree();
Console.WriteLine("");
Equal();
Console.WriteLine("");
EvenOrOdd();
Console.WriteLine("");
PosOrNeg();
Console.WriteLine("");
Vote();
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("Heating Up projects");
IntRange();
Console.WriteLine("");
MultiplicationTable();

//Lukewarm
//1. pringing out a range of 1000 --> -1000 - used a "for" loop
#region
static void thousRange()
{
    for (int i = 1000; i >= -1000; i--)
    {
        Console.WriteLine(i);
    }
}
#endregion

//2. printing out a range of 3 --> 999, by 3 each time - used a "for" loop
Console.WriteLine("");
#region
static void multByThree()
{
    for (int i = 3; i <= 999; i += 3) //whereas i += 3 == i = i + 3
    {
        Console.WriteLine(i);
    }
}
#endregion

//3. create a (method?) to check if two intigers are equal - used an "if-else" statement
Console.WriteLine("");
#region
static void Equal()
{
    Console.WriteLine("           Do me a favor. I am going to ask you twice and I would like you to give me one number each time.");
    int option1 = int.Parse(Console.ReadLine());
    var option2 = int.Parse(Console.ReadLine());

    if (option1 == option2)
    {
        Console.WriteLine("These numbers are equal.");
    }
    else
    {
        Console.WriteLine("These numbers are not equal.");
    }
}
#endregion

//4. create a (method?) to check if numbers are even or odd - used an "if-else" statement
Console.WriteLine("");
#region
static void EvenOrOdd()
{
    Console.WriteLine("          Once again, I need a random number please.");
    int evenOdd = int.Parse(Console.ReadLine());

    if (evenOdd % 2 == 0)
    {
        Console.WriteLine("This number is even!");
    }
    else
    {
        Console.WriteLine("This number is odd!");
    }
}
#endregion

//5. create a (method?) to check if a number is positive or negative - used an "if-else" statement
Console.WriteLine("");
#region
static void PosOrNeg()
{
    Console.WriteLine("          Guess what? I need you to give me - yet agin, another number.");
    int posNeg = int.Parse(Console.ReadLine());

    if (posNeg >= 0)
    {
        Console.WriteLine("This number is possitive!");
    }
    else
    {
        Console.WriteLine("This number is negative!");
    }
}
#endregion

//6. create a (method?) to determine if the input age is eligable to vote - used an "if-else" statement
Console.WriteLine("");
#region
static void Vote()
{
    Console.WriteLine("          I've got a question, can you tell me your age?");
    int age = int.Parse(Console.ReadLine());

    if (age < 18)
    {
        Console.WriteLine("You're too young to vote.");
    }
    else
    {
        Console.WriteLine("You are eligable to vote!");
    }
}
#endregion


//Heating Up
//1. create a (method?) to check if an integer is within the range 10 --> -10 - used a "if-else" statement
Console.WriteLine("");
#region
static void IntRange()
{
    Console.WriteLine("          Alright, I need you to give me another number.");
    int tenTen = int.Parse(Console.ReadLine());
    if (tenTen <= -10 && tenTen >= 10)
    {
        Console.WriteLine("Alright, you are within my allotted range");
    }
    else
    {
        Console.WriteLine("Sorry, you are not within my numerical range.");
    }
}
#endregion

//2. create a (method?) to display a multiplicatiuon table from 1-12 of a given integer - 
Console.WriteLine("");
#region
static void MultiplicationTable()
{
    var multiples = new List<int>() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
    Console.WriteLine("Go ahead and give me another number, now we are going to view the multiples");
    var userAnswer = int.Parse(Console.ReadLine());

    foreach (var digit in multiples)
    {
        Console.WriteLine($"{userAnswer} x {digit} = {userAnswer*digit}");
    }
}
#endregion