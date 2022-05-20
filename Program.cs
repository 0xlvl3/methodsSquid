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

do
{
    ButtonClick();
} while (buttonClick = false);


static void ButtonClick()
{
    Console.Write("Please enter 0 for false and 1 for true: ");
    int button = Convert.ToInt32(Console.ReadLine());
    bool buttonClick;
    if (button == 0)
    {
        buttonClick = false;
    }
    else if (button == 1)
    {
        buttonClick = true;
    }
}