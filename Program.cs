//arrays
//----------------
//arrays are very basic data structures
//programmers use arrays as containers to store multiple pieces of information
//that relate to each other in some way aka lists

string[] summerStrut;
summerStrut = new string[] {
        "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel",
        "Despacito", "Los Angeles"
      };

int[] ratings = new int[] { 1, 2, 3, 4, 5 };

string[] names = new string[] { "This", "Is", "A", "Test" };


for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine(names[i]);
}

Console.WriteLine("\n");
CountDown();
CountDown();
CountDown();

static void CountDown()
{
    int[] countdown = new int[] { 5, 4, 3, 2, 1 };

    for (int i = 0; i < countdown.Length; i++)
    {
        Console.WriteLine(countdown[i]);
    }

}

//putting the length of the names array into a variable named namesLength with the .Length method
int nameLength = names.Length;
Console.WriteLine($"testing the .length method on an array names {nameLength}");

//taking the first property of the array and placing it within a new variable using indexing
string firstName = names[0];
Console.WriteLine(firstName);

//creating a array with fixed number of items 
int[] testNum = new int[10];
//placing items within the array
testNum[0] = 1;
Console.WriteLine(testNum[0]);
testNum[1] = 2;
testNum[2] = 3;
Console.WriteLine($"{testNum[2]}");

Console.WriteLine("\n");
int[] randomlySorted = new int[] { 4, 9, 5, 3, 6, 9, 10 };
Array.Sort(randomlySorted);
for (int i = 0; i < randomlySorted.Length;i++)
{
    Console.WriteLine(randomlySorted[i]);
}

Console.WriteLine("\n");

//using teh Array.IndexOf method to find the index of "Test" in the names array
int indexName = Array.IndexOf(names, "Test");
Console.WriteLine(indexName);

Console.WriteLine("\n");

//
int emails = 20;
while (emails != 0)
{
    Console.WriteLine(emails);
    -- emails;
    if (emails == 0)
    {
        Console.WriteLine("Your inbox is now at 0 :-)");
    }
}

Console.WriteLine("\n");


bool buttonClick = true;
//do while loop, loop will continue when user inputs 0 for false, do while loop ends when user enters 1 for true
do
{
    Console.Write("Please enter 0 for alarm and 1 to turn it off: ");
    int button = Convert.ToInt32(Console.ReadLine());
    if (button == 0)
    {
        Console.WriteLine("BRRRRRRRRRRRRRRRRRR");
        buttonClick = false;
    }
    else if (button == 1)
    {
        Console.WriteLine("You have turned off the alarm");
        buttonClick = true;
    }
} while (buttonClick == false);


//static void ButtonClick()
//{
//    Console.Write("Please enter 0 for false and 1 for true: ");
//    int button = Convert.ToInt32(Console.ReadLine());
//    bool buttonClick;
//    if (button == 0)
//    {
//        buttonClick = false;
//    }
//    else if (button == 1)
//    {
//        buttonClick = true;
//    }
//}

Console.WriteLine("\n");


//using a foreach loop to loop through an array and print them to the console indivually
foreach (string i in names)
{
    Console.WriteLine(i);
}

Console.WriteLine("\n");

/*
loops and general usecases
-----------------------------

while loops are good when you know your stopping condition, 
but not when you know how many times you want a program to loop
or if you have a specific collection to loop through.

do...while loops are only necessary if you definitely want something to run once, 
but then stop if a condition is met.

for loops are best if you want something to run a specific number of times, 
rather than given a certain condition.


foreach loops are the best way to loop over an array, or any other collection.

 */


//challenge


char[] alphabet = new char[]
{
    'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l',
    'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
};

string userName = UserName();
Console.Write($"Welcome {userName} please enter a passcode: ");
string pass = Passcode();
Console.WriteLine($"your pass is {pass}");
char[] charPass = pass.ToCharArray();
char[] encryptedMessage = new char[charPass.Length];
//creating a new char array with the input from the user for their passcode
//create a method on plane
static string Encrypt()
{
    for (int i = 0; i < charPass.Length; i++)
    {
        char letter = pass[i];
        int letterPosition = Array.IndexOf(alphabet, letter);
        int newLetterPosition = (letterPosition + 3) % 26;
        char letterEncoded = alphabet[newLetterPosition];
        encryptedMessage[i] = letterEncoded;
    }

    string encodedString = String.Join("", encryptedMessage);
    Console.WriteLine($"Your encoded message is {encodedString}");
    return letterEncoded;
}

//char[] charPass = pass.ToCharArray();
//char[] encryptedMessage = new char[charPass.Length];
//for (int i = 0; i < charPass.Length; i++)
//{
//    char letter = pass[i];
//    int letterPosition = Array.IndexOf(alphabet, letter);
//    int newLetterPosition = (letterPosition + 3) % 26;
//    char letterEncoded = alphabet[newLetterPosition];
//    encryptedMessage[i] = letterEncoded;
//}

string encodedString = String.Join("", encryptedMessage);
Console.WriteLine($"Your encoded message is {encodedString}");
////checking to see if .ToCharArray() worked
//for (int i = 0; i < charPass.Length; i++)
//{
//    Console.WriteLine(charPass[i]);
//}


//method for the passcode for user
static string Passcode()
{
    string passcode = Console.ReadLine();
    return passcode.ToLower();
}

//method for to get username from user
static string UserName() 
{
    Console.Write("Please enter your name: ");
    string user = Console.ReadLine(); 
    return user;
}