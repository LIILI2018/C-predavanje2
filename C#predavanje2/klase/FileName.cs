using System.Transactions;
using System.Xml;

namespace C_predavanje2.klase
{
	public class Dog
	{
		public Guid Id { get; }
		public string dog;
		public string Name { get; set; }
		public string Breed { get; set; }
		public DateTime DateOfBirth { get; } = DateTime.Now;
		public DateTime DateOfLastVAcation { get; private set; } = DateTime.Now;
		private int _hungerLevel;
		public Owner Owner;//private se naziva _pokemoni
		public int DogCounter = 1;
		public static int DogsCounter( int numberOfDogs)//Objekt ne nemora instancirat da se fja izvrši ili ne?
		{
			//DogCounter += numberOfDogs;
			return 2;
		}
        public Dog()//Koliko varijabla damo taj će se konstruktior koristiti
        {
			Id = Guid.NewGuid();
            Console.WriteLine("Ovo je prvi konstruktor");
        }/*
        public Dog(string Id,string name)
        {
			Id = Id;
			Name = name;
            Console.WriteLine("Drugi 'ctor tab tab'");
        }*/
		public bool Vaccinated()
		{
			return DateOfLastVAcation > DateTime.Now.AddYears(-1);
		}

		public bool Hungry()
		{
			return _hungerLevel >= 50;
		}

		public bool Feed(int amountOfFood)
		{
			if (Hungry() || amountOfFood > _hungerLevel) return false; 
			_hungerLevel -= amountOfFood;
			return true;
		}

		public bool Vaccinate()
		{
			if (Vaccinated()) return false;
			DateOfLastVAcation = DateTime.Now;
			return true;
		}

		public void Voice()
		{
			Console.WriteLine("Vau Vau");
		}
    }
}

/*
 ststična metoda ?
 */