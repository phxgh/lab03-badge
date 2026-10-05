/*
    * Name:        Phoenix Rojas
    * Course:      CSCI-1250, Section 002
    * Assignment:  Lab 03, The Badge Office
    * Date:        September 30, 2026
    * Description: Builds a student badge from a name, two random assignments,
    *              and the walking distance to a first class
*/

// Part 1: The Name
Console.Write("Full name: ");
string fullName = Console.ReadLine();
fullName = fullName.Trim();
int spacePosition = fullName.IndexOf(" ");
string firstName = fullName.Substring(0, spacePosition);
string lastName = fullName.Substring(spacePosition + 1);

string username = firstName.Substring(0, 1).ToLower() + lastName.ToLower();

Console.WriteLine("Name on badge: " + fullName.ToUpper());
Console.WriteLine("Username: " + username);
Console.WriteLine("Initials: " + firstName[0].ToString().ToUpper() + "." + lastName[0].ToString().ToUpper() + ".");
Console.WriteLine("Letters in last name: " + lastName.Length + "\n");

// Part 2: The Numbers
var rng = new Random();
var id = rng.Next(100000, 999999);
var lockerNumber = rng.Next(1, 500);

// Part 3: The Walk
Console.Write("Dorm x: ");
int dormX = Convert.ToInt32(Console.ReadLine());
Console.Write("Dorm y: ");
int dormY = Convert.ToInt32(Console.ReadLine());
Console.Write("Class x: ");
int classX = Convert.ToInt32(Console.ReadLine());
Console.Write("Class y: ");
int classY = Convert.ToInt32(Console.ReadLine());
Console.Write("Walking speed in feet per second: \n");
double speed = Convert.ToDouble(Console.ReadLine());

double dist = Math.Sqrt(Math.Pow(classX - dormX, 2) + Math.Pow(classY - dormY, 2));
double seconds = dist / speed;
int minutes = (int)seconds / 60;
int remainingSeconds = (int)seconds % 60;

Console.WriteLine("Distance: " + dist.ToString("F1") + " feet");
Console.WriteLine("Walk time: " + minutes + " minutes " + remainingSeconds + " seconds\n");

// Part 4: The Badge
Console.WriteLine("==================================");
Console.WriteLine("ETSU STUDENT BADGE");
Console.WriteLine("==================================");
Console.WriteLine("NAME " + fullName);
Console.WriteLine("USERNAME " + username);
int checkDigit = id % 9;
Console.WriteLine("ID " + id + "-" + checkDigit);
Console.WriteLine("LOCKER " + lockerNumber);
Console.WriteLine("WALK " + minutes + " min " + remainingSeconds + "sec");
Console.WriteLine("==================================");
