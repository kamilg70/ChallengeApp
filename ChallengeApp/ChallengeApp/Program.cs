 
string name = "Ewa";
var age = 30;
Gender gender = Gender.Female;

if (gender == Gender.Female && age < 30)
{
Console.WriteLine("Kobieta poniżej 30lat");
}
else if (name == "Ewa" && age == 30)
{
Console.WriteLine("Ewa, lat 30");
}
else if (gender == Gender.Male && age < 18)
{
Console.WriteLine("Niepełnoletni mężczyzna");
}

enum Gender
{
    Male,
    Female
}