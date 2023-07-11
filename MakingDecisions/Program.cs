
Console.WriteLine("Enter the current temperature");
string temperature = Console.ReadLine();
int numTemp;
int number;
bool userEnteredNum = int.TryParse(temperature, out number);

if (userEnteredNum)
{
    numTemp = number;
} else
{
   numTemp = 0;
    Console.WriteLine("You entered the wrong value");
}

if (numTemp < 20)
{
    Console.WriteLine("Take the coat");
}else if( numTemp == 20)
{
    Console.WriteLine("It's 20 degrees");
}else
{
    Console.WriteLine("Cozy & warm");
}

// TryParse

string numberAsString = "128";
int parsedValue;

bool success = int.TryParse(numberAsString, out parsedValue);

if (success)
{
    Console.WriteLine("Parsing succesful - number is " + parsedValue);
}else
{
    Console.WriteLine("Parsing failed");
}

string age = "18.75";
float parsedFloatValue;

bool parsedDoubleValue = float.TryParse(age, out parsedFloatValue);

if (parsedDoubleValue)
{
    Console.WriteLine("Succesful");
} else
{
    Console.WriteLine("Failed");
}

// Nested if Statement 



Console.ReadLine();
