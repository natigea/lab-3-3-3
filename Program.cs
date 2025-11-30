#region task 1
/*for (int i = 0; i < 21; i++)
{
    Console.WriteLine(i);
}*/
#endregion

#region task 2
/*Console.WriteLine("ede daxil edin: ");
int n=int.Parse(Console.ReadLine());
if (n % 2 == 0)
    Console.WriteLine("cut");
else 
    Console.WriteLine("tek");*/
#endregion

#region task 4 elememisem
#endregion

#region task 3
/*Console.WriteLine("gun daxil edin: ");
int n=int.Parse(Console.ReadLine());
if (n == 1)
    Console.WriteLine("1-ci gun");
else if (n == 2)
    Console.WriteLine("2-ci gun");
else if (n == 3)
    Console.WriteLine("3-ci gun");
else if (n == 4)
    Console.WriteLine("4-ci gun");
else if (n == 5)
    Console.WriteLine("5-ci gun");
else if (n == 6)
    Console.WriteLine("6-ci gun");
else if (n == 7)
    Console.WriteLine("7-ci gun");
else
    Console.WriteLine("error");*/
#endregion

#region task 5
/*int[] numbers = {5,8 ,3,12,6};
int max=numbers[0];
for (int i=0; i<numbers.Length; i++)
{
    if (numbers[i] > max)
    { max = numbers[i]; }
}
Console.Write(max);*/
#endregion

#region task 6
/*Console.Write("Enter a word: ");
string word = Console.ReadLine().ToLower();
int count = 0;
string vowels = "aeiou";
foreach (char c in word)
{
    if (vowels.Contains(c))
        count++;
}

Console.WriteLine($"Vowel count: {count}");
*/
#endregion

#region task 7
/*string text = Console.ReadLine();
string reverse = "";

    for (int i = text.Length - 1; i >= 0; i--)
    {
            reverse += text[i];
    }
Console.WriteLine(reverse);*/
#endregion

#region task 8
/*int i;
int j;
for (i = 1; i <= 1; i++)
{
    for (j = 1; j <= 10; j++)
    {
        Console.Write((j * i).ToString().PadLeft(5));
    }
    Console.WriteLine();
}

// tam basdusmedim iki cur yazdim

int i;
int j;
for (i = 1; i <= 9; i++)
{
    for (j = 1; j <= 9; j++)
    {
        Console.Write((j * i).ToString().PadLeft(5));
    }
    Console.WriteLine();
}*/
#endregion

#region task 9
/*List<string> name = new List<string>()
{
    "ali",
    "akif",
    "murad",
    "amin",
    "emil"
};

string namee = Console.ReadLine();

if (name.Contains(namee))
{
    Console.WriteLine("found");
}
else
{
    Console.WriteLine("not found");
}
*/

#endregion

#region task 10
/*int[] numbers = { 1, 2, 2, 3, 3, 4, 4, 5 };
int number;

for (int i = 0; i < numbers.Length - 1; i++)
{
    if (numbers[i] == numbers[i + 1])
        continue;
    number = numbers[i];
    Console.Write(number);
}
*/
#endregion

#region task 11
/*Console.Write("ededin sayin daxil edin: ");
int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write("eded: ");
    arr[i]=int.Parse(Console.ReadLine());
}
int sum = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0)
        sum += arr[i];
}
Console.Write($"cut ededlerin sumu: " + sum);*/
#endregion

#region task 12
/*int result = 0;

do
{
    Console.WriteLine(" MENU ");
    Console.WriteLine("1. add ");
    Console.WriteLine("2. subtract ");
    Console.WriteLine("3. multiply ");
    Console.WriteLine("4. exit ");

    Console.Write("operation: ");
    int c = int.Parse(Console.ReadLine());
    if (c == 4)
    {
        Console.WriteLine("Exiting program...");
        break; 
    }
    Console.Write("num1: ");
    int num1 = int.Parse(Console.ReadLine());

    Console.Write("num2: ");
    int num2 = int.Parse(Console.ReadLine());

    switch (c)
    {
        case 1:
            result = num1 + num2;
            break;

        case 2:
            result = num1 - num2;
            break;

        case 3:
            result = num1 * num2;
            break;

        default:
            Console.WriteLine("Error");
            continue;
    }

    Console.WriteLine($"Result: {result}");

} while (true);
*/
#endregion

#region task 13
/*Console.Write("ededin sayin daxil edin: ");
int num = int.Parse(Console.ReadLine());
int[] arr = new int[num];
for (int i = 0; i < num; i++)
{
    Console.Write("eded: ");
    arr[i] = int.Parse(Console.ReadLine());
}

int positiveCount = 0;
int negativeCount = 0;
int zeroCount = 0;
for (int i = 0; i <= arr.Length - 1; i++)
{
    if (arr[i] > 0)
        positiveCount++;
    else if (arr[i] < 0)
        negativeCount++;
    else if (arr[i] == 0)
        zeroCount++;
}

Console.WriteLine($"Positive numbers: {positiveCount}");
Console.WriteLine($"Negative numbers: {negativeCount}");
Console.WriteLine($"Zeros: {zeroCount}");
*/
#endregion

#region task 15
/*int[] numbers = { 1, 2, 3, 5, 7, 9 };
bool s = true;
for (int i = 0; i < numbers.Length - 1; i++)
{
    if (numbers[i] > numbers[i + 1])
    {
        s = false;
        break;
    }
}
Console.WriteLine(s ? "Sorted" : "Not sorted");
*/
#endregion

#region task 16
/*for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
*/
#endregion

#region task 17
/*Random rand = new Random();
int randNumber = rand.Next(1, 21);
int number = 0;
while (number != randNumber)
{
    Console.Write("Number: ");
    number = int.Parse(Console.ReadLine());
    if (number < randNumber)
    {
        Console.WriteLine("azdi");
    }
    else if (number > randNumber)
    {
        Console.WriteLine("coxdu");
    }
}
Console.WriteLine("tapdin!");
*/
#endregion

#region task 18
/*{
    List<string> words = new List<string> 
    { "hello", "privet", "salam" };
    for (int i = 0; i < words.Count; i++)
    {
        words[i] = words[i].ToUpper();
    }
    Console.WriteLine("Caps Lock:");
    foreach (string word in words)
    {
        Console.WriteLine(word);
    }
}
*/
#endregion

#region task 19
/*{
    int[] numbers = { 1, 3, 3, 5, 3, 1 };
    int count = 0;
    foreach (int n in numbers)
    {
        if (n == 3)
            count++;
    }
    Console.WriteLine(count);
}
*/
#endregion
