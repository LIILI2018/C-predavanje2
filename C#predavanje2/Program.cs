using C_predavanje2.klase;
using System.Reflection.Metadata;
static int IntInput(String txt)
{
	int y;
	bool uspješnoUneseno = false;
	do
	{
		uspješnoUneseno = int.TryParse(Console.ReadLine(), out y);
	} while (!uspješnoUneseno);
	Console.Clear();
	return y;
}
static int OptionInput(String txt)
{
	Console.WriteLine(txt);	
	int y = 0;
	bool uspješnoUneseno = false;
	do
	{
		uspješnoUneseno = int.TryParse(Console.ReadLine(), out y);
	} while (!uspješnoUneseno || y > txt.Count());
	Console.Clear();
	return y;
}
static String StringInput(String txt)
{
	Console.WriteLine(txt);
	var y = Console.ReadLine();
	Console.Clear();
	return y;
}
static DateTime DateInput(String txt)
{
	Console.WriteLine(txt);
	DateTime y;
	bool uspješnoUneseno = false;
	do
	{
		uspješnoUneseno = DateTime.TryParse(Console.ReadLine(), out y);
	} while (!uspješnoUneseno);
	Console.Clear();

	return y;
}
static double DoubleInput(String txt)
{
	Console.WriteLine(txt);
	double y;
	bool uspješnoUneseno = false;
	do
	{
		uspješnoUneseno = double.TryParse(Console.ReadLine(), out y);
	} while (!uspješnoUneseno);
	Console.Clear();

	return y;
}
static void Wait(String txt)
{
    Console.WriteLine(txt);
	Console.ReadLine();
}
///////////////////////////////////////////////////////////////
//klasse se rade u novom fileu

var dog = new Dog()
{
	dog = "1",//private se ne može mijenjati izvan klase
	Name = "Šaponja",
	Breed = "1",
};
Console.WriteLine(dog.Id);
/*
var dog2 = new Dog("","bob")
{
	dog = "1",
	Breed = "1",
	DateOfBirth = new DateTime(2020,1,1),
	DateOfLastVAcation = new DateTime(2020, 1, 1),
	HungerLevel = 98,
	Owner = "Matko Matoć"
};
*/
/*
var newGuid = Guid.NewGuid();// Radi novi string koji se ne može ponoviti
Console.WriteLine(newGuid);*///Id

Console.WriteLine(dog.Vaccinate());
dog.Voice();