int[] partNumber = new int[4];
int[] partPrice = new int[4];
string[] partDesc = new string[4];

for (int i = 0; i < 4; i++)
{
    //partNumber Loading
    bool exit = false;
    do {
        Console.WriteLine("Input Part Number");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num < 1 || num > 100)
        {
            Console.WriteLine("Number out of range");
        }
        else {
            partNumber[i] = num;
            exit = true;
        }
    } while (exit == false);

    //partPrice Loading
    exit = false;
    do
    {
        Console.WriteLine("Input Part Price");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num < 10 || num > 500)
        {
            Console.WriteLine("Price out of range");
        }
        else
        {
            partPrice[i] = num;
            exit = true;
        }
    } while (exit == false);

    //partDesc Loading
    exit = false;
    do
    {
        Console.WriteLine("Input Part Description");
        partDesc[i] = Console.ReadLine();
        exit = true;

    } while (exit == false);
}

Console.Clear();
//User Interaction
int userResponse;
Console.WriteLine("--------Welcome----------");
Console.WriteLine("Enter Desired Part Number");
userResponse = Convert.ToInt32(Console.ReadLine());

    //Date Validation
string[] monthName = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
int[] maxMonthDay = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
int currentMonthIndex;
int currentDay;
int currentYear;

do
{
    Console.WriteLine("Current Month ##");
    currentMonthIndex = Convert.ToInt32(Console.ReadLine()) - 1;
} while (currentMonthIndex > monthName.Length - 1);

do
{
    Console.WriteLine("Current Day ##");
    currentDay = Convert.ToInt32(Console.ReadLine());
} while (currentDay > maxMonthDay[currentMonthIndex]);


Console.WriteLine("Current Year ##"); //assume 2000s
currentYear = Convert.ToInt32(Console.ReadLine());

//Output
for (int i = 0; i < 4; i++)
{
    if(userResponse == partNumber[i])
    {
        Console.WriteLine($"Part Number:      #{partNumber[i]}");
        Console.WriteLine($"Part Price:       ${partPrice[i]}.00");
        Console.WriteLine($"Part Description: {partDesc[i]}");
    }
}

Console.WriteLine($"Transaction Date: {monthName[currentMonthIndex]} {currentDay}, 20{currentYear}");

