// 1. Name
Console.WriteLine("1.Name");
Console.WriteLine();
Console.WriteLine("Hello, please enter Your name!");

string userName = Console.ReadLine();

Console.WriteLine("Hello, " + userName + "!");


/////////////////////////////////////////////////////////////////
//2.Age
Console.WriteLine();
Console.WriteLine("==================================");
Console.WriteLine("2.Age");
Console.WriteLine();
Console.WriteLine("How old are You now?");
string userAgeString = Console.ReadLine();
int userAge = int.Parse(userAgeString);

//Age next year
int ageNextYear = userAge + 1;

Console.WriteLine();
Console.WriteLine("Next year You will be " + ageNextYear + " years old.");

bool ageCheck = userAge >= 18;
bool orAction = ageCheck;

Console.WriteLine();
Console.WriteLine("Are You an adult?");
Console.WriteLine(orAction);


/////////////////////////////////////////////////////////////////
//3.Max number
Console.WriteLine();
Console.WriteLine("==================================");
Console.WriteLine("3.Max number");
Console.WriteLine();
Console.Write("Please enter any number: ");

string num1MaxString = Console.ReadLine();
int num1Max = int.Parse(num1MaxString);

Console.Write("Please enter another number: ");

string num2MaxString = Console.ReadLine();
int num2Max = int.Parse(num2MaxString);

int maxNumber = Math.Max(num1Max, num2Max);
Console.WriteLine("Your max number is " + maxNumber + ".");


/////////////////////////////////////////////////////////////////
//4.Min number
Console.WriteLine();
Console.WriteLine("==================================");
Console.WriteLine("4. Min number");
Console.WriteLine();

Console.Write("Please enter any number: ");

string num1MinString = Console.ReadLine();
int num1Min = int.Parse(num1MinString);

Console.Write("Please enter one more number: ");

string num2MinString = Console.ReadLine();
int num2Min = int.Parse(num2MinString);

int minNumber = Math.Min(num1Min, num2Min);
Console.WriteLine("Your min number is " + minNumber + ".");


/////////////////////////////////////////////////////////////////
//5. %
Console.WriteLine();
Console.WriteLine("==================================");
Console.WriteLine("5. Division");
Console.WriteLine();


Console.Write("Please enter any number: ");

string num1DivString = Console.ReadLine();
int num1Div = int.Parse(num1DivString);

Console.Write("Please enter one more number: ");
string num2DivString = Console.ReadLine();
int num2Div = int.Parse(num2DivString);

int divisionLeft = num1Div % num2Div;

Console.WriteLine("Left division is " + divisionLeft + ".");


/////////////////////////////////////////////////////////////////
//6. Odd or even
Console.WriteLine();
Console.WriteLine("==================================");
Console.WriteLine("6. Odd or even");
Console.WriteLine();

Console.Write("Please enter any number: ");
int number6 = int.Parse(Console.ReadLine());
bool isEven = number6 % 2 == 0;
Console.WriteLine("Number is even: " + isEven);


/////////////////////////////////////////////////////////////////
//7. Rectangle's area
Console.WriteLine();
Console.WriteLine("==================================");
Console.WriteLine("7. Rectangle");
Console.WriteLine();

Console.Write("Please enter length of rectangle's longest side: ");
string side1String = Console.ReadLine();
double side1 = double.Parse(side1String);
double side1Rounded = Math.Round(side1, 2);

Console.Write("Please enter length of rectangle's shortest side: ");
string side2String = Console.ReadLine();
double side2 = double.Parse(side2String);
double side2Rounded = Math.Round(side2, 2);

double rArea = side1Rounded * side2Rounded;

Console.WriteLine("Rectangle's area is " + rArea + ".");


/////////////////////////////////////////////////////////////////
//8. Triangle
Console.WriteLine();
Console.WriteLine("==================================");
Console.WriteLine("8. Triangle");
Console.WriteLine();

Console.Write("Please enter triangle's side length: ");
int sideLength = int.Parse(Console.ReadLine());

int tArea = sideLength * sideLength / 2;

Console.WriteLine("Triangle's area is " + tArea + ".");

/////////////////////////////////////////////////////////////////
//9. Interpolation
Console.WriteLine();
Console.WriteLine("==================================");
Console.WriteLine("9. Interpolation");
Console.WriteLine();

Console.Write("What is Your name? ");
string nameInter = Console.ReadLine();

Console.Write("How old are You? ");
int ageInter = int.Parse(Console.ReadLine());

string formattedMessage = $"Hello {nameInter}, You are {ageInter} years old. "; 
Console.WriteLine(formattedMessage);

















