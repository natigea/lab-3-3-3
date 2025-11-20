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
/*Console.WriteLine("soz daxil ednin: ");
string a = Console.ReadLine().ToLower();
string vowels = "aeiou";
int count = 0;
foreach (char c in a) 
{
    if (vowels.Contains(c))
    {
        count++;
    }
}
Console.WriteLine(count);*/
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
for (i = 1; i <= 10; i++)
{
    for (j = 1; j <= 10; j++)
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
string input=Console.ReadLine();
if (name.Count > 0)
{
    Console.WriteLine("found");
}
else
    Console.WriteLine("not found");
*/
#endregion

#region task 10 sefdi
/*int[] numbers = { 1, 2, 2, 3, 3, 4, 4, 5 };
int number;
for (int i = 0; i < numbers.Length-1; i++)
{
    if (numbers[i] == numbers[i+1])
        continue;
    else 
        number =numbers[i];
    Console.WriteLine(numbers[i]);
}*/
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
do {
    Console.WriteLine("   MENU ");
    Console.WriteLine("1. add ");
    Console.WriteLine("2. subtract ");
    Console.WriteLine("3. multipl ");
    Console.WriteLine("4. exit ");
    Console.WriteLine("edeleri daxil edin ");
    Console.Write("num1: ");
    int num1 = int.Parse(Console.ReadLine());
    Console.Write("num2: ");
    int num2 = int.Parse(Console.ReadLine());
    Console.Write("operation: ");
    int c = int.Parse(Console.ReadLine());
    {
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
            case 4:
                result = num1 / num2;
                break;
            case >= 5:
            case <= 0:
                Console.WriteLine("error");
                break;
        }
        Console.WriteLine(result);
    }

} while (true);*/
#endregion

#region task 13
Console.Write("ededin sayin daxil edin: ");
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
for (int i = 0; i <= arr.Length-1; i++)
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
#endregion
