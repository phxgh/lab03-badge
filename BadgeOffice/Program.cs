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
