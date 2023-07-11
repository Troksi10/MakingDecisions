
using System;
using System.Diagnostics;

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

bool isAdmin = false;
bool isRegistered = true;
string userName = "";
Console.Write("Please enter the username : ");
userName = Console.ReadLine();

if (isRegistered && userName !="" && userName.Equals("admin"))
{
    Console.WriteLine("Hi there,registered user");
    Console.WriteLine("Hi there," + userName);
    Console.WriteLine("Hi there,admin");
}

if(isAdmin || isRegistered)
{
    Console.WriteLine("You are logged in");
}

// Challenge If statement 1
// Create a user Login System, where the user can first register and then Login in. The Program should check if the user has entered the correct username and password, wenn login in (so the same ones that he used when registering).

string username;
string password;

Register();
Login();

// Switch statement

int myAge = 33;

switch (myAge)
{
    case 15:
        Console.WriteLine("Too young to party in the club");
        break;
    case 25: Console.WriteLine("Good to go");
        break;
    default: Console.WriteLine("How old are you then?");
        break;
}

// Reproduce that with the IF statement

if (myAge == 15)
{
    Console.WriteLine("Too young to party in the club");
}
else if (myAge == 25)
{
    Console.WriteLine("Let'go and party never stops");
}else
{
    Console.WriteLine("How old are you then?");
}

string myUserName = "Ilija";

switch (myUserName)
{
    case "Ilija":
        Console.WriteLine("Username is Ilija");
        break;
    case "root":
        Console.WriteLine("username is root");
        break;
    default:
        Console.WriteLine("username is unknown");
        break;
}

// Challenge - If Statements 2
// Create an application with a score, highscore and a highscorePlayer.
// Create a method which has two parameters, one for the score and one for the playerName.
// When ever that method is called, it should be checked if the score of the player is higher than the highscore, if so, "New highscore is + " score" and in another line "New highscore holder is " + playerName - should be written onto the console, if not "The old highscore of " + highscore + " could not be broken and is still held by " + highscorePlayer.

int highscore = 300;
string highscorePlayer = "Zlatko";

CheckHighScore(250, "Angela");
CheckHighScore(325,"Bojan");
CheckHighScore(350,"ilija");

// Ternary operator

int todaytemperature = -5;
string stateOfMetter;

if(todaytemperature < 0)
{
    stateOfMetter = "solid";
}else
{
    stateOfMetter = "liquid";
}

Console.WriteLine($"State of metter is {stateOfMetter}");

Console.ReadLine();

void Register()
{
    Console.WriteLine("Please enter your username");
    username = Console.ReadLine();
    Console.WriteLine("Please enter your password");
    password = Console.ReadLine();
    Console.WriteLine("Registration completed");
    Console.WriteLine("---------------------------------");
}

void Login()
{
    Console.WriteLine("Please enter your username");
    if(username == Console.ReadLine())
    {
        Console.WriteLine("Please enter your password");
        if(password == Console.ReadLine())
        {
            Console.WriteLine("Loggin succesful");
        }else
        {
            Console.WriteLine("Loggin Failed,wrong password.Restart Program");
        }
    } else
    {
        Console.WriteLine("Loggin Failed,wrong username.Restart Program");
    }
}

void CheckHighScore(int score,string playerName)
{
    if(score > highscore)
    {
        highscore = score;
        highscorePlayer = playerName;
        Console.WriteLine("New high score is " + score);
        Console.WriteLine("It is now held by " + playerName);
    }else
    {
        Console.WriteLine("The old highscore could not be broken.It is still " + highscore + "and held by " + highscorePlayer);
    }
}