string name = "Ewa";
string sex = "female";
int age = 33;

if (name == "Ewa" && sex == "female" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (sex == "female" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (sex == "male" && age < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}