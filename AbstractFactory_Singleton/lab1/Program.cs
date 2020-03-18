using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public interface ICar
    {
        ICarcass CreateCarcass();
        IPower CreatePower();
        IFuel CreateFuel();
        IPlace ShowPlace();
    }

    public interface IPlace
    {
        void WritePlace();
    }

    public interface ICarcass
    {
        void WriteCarcassType();
    }

    public interface IPower
    {
        void WriteAmountHP(double hp);
    }
    
    public interface IFuel
    {
        void WriteNumberFuelConsumprion(double fuelConsumption);
    }
    public class PlaceSaintPetersburg : IPlace
    {
        public void WritePlace()
        {
            Console.WriteLine("Город-производитель: Санкт-Петербург");
        }
    }

    public class PlaceMoscow : IPlace
    {
        public void WritePlace()
        {
            Console.WriteLine("Город-производитель: Москва");
        }
    }

    public class PlacePerm : IPlace
    {
        public void WritePlace()
        {
            Console.WriteLine("Город-производитель: Пермь");
        }
    }

    public class CarcassUniversal : ICarcass
    {
        public void WriteCarcassType()
        {
            Console.WriteLine("Тип кузова: Универсал");
        }
    }

    public class CarcassSedan : ICarcass
    {
        public void WriteCarcassType()
        {
            Console.WriteLine("Тип кузова: Седан");
        }
    }

    public class CarcassCoupe : ICarcass
    {
        public void WriteCarcassType()
        {
            Console.WriteLine("Тип кузова: Купе");
        }
    }

    public class Power : IPower
    {
        public void WriteAmountHP(double hp)
        {
            Console.WriteLine("Мощность двигателя: " + hp.ToString() + " л.с.");
        }
    }

    public class Fuel : IFuel
    {
        public void WriteNumberFuelConsumprion(double fuelConsumption)
        {
            Console.WriteLine("Расход топлива: " + fuelConsumption.ToString() + "\n");
        }
    }

    public class PlantSaintPetersburg : ICar
    {
        public IPlace ShowPlace()
        {
            return new PlaceSaintPetersburg();
        }

        public ICarcass CreateCarcass()
        {
            return new CarcassCoupe();
        }

        public IPower CreatePower()
        {
            return new Power();
        }

        public IFuel CreateFuel()
        {
            return new Fuel();
        }
    }

    public class PlantMoscow : ICar
    {
        public IPlace ShowPlace()
        {
            return new PlaceMoscow();
        }

        public ICarcass CreateCarcass()
        {
            return new CarcassSedan();
        }

        public IPower CreatePower()
        {
            return new Power();
        }

        public IFuel CreateFuel()
        {
            return new Fuel();
        }
    }

    public class PlantPerm : ICar
    {
        public IPlace ShowPlace()
        {
            return new PlacePerm();
        }

        public ICarcass CreateCarcass()
        {
            return new CarcassUniversal();
        }

        public IPower CreatePower()
        {
            return new Power();
        }

        public IFuel CreateFuel()
        {
            return new Fuel();
        }
    }

    public class Client
    {
        private IPlace place;
        private ICarcass carcass;
        private IPower power;
        private IFuel fuel;
        public Client(ICar factory)
        {
            place = factory.ShowPlace();
            carcass = factory.CreateCarcass();
            power = factory.CreatePower();
            fuel = factory.CreateFuel();
        }

        public void WriteCarcassType()
        {
            carcass.WriteCarcassType();
        }

        public void WriteAmountHP(double hp)
        {
            power.WriteAmountHP(hp);
        }

        public void WriteNumberFuelConsumprion(double fuelConsumption)
        {
            fuel.WriteNumberFuelConsumprion(fuelConsumption);
        }
        public void WritePlace()
        {
            place.WritePlace();
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client(new PlantSaintPetersburg());
            client1.WritePlace();
            client1.WriteCarcassType();
            client1.WriteAmountHP(600);
            client1.WriteNumberFuelConsumprion(22);

            Client client2 = new Client(new PlantMoscow());
            client2.WritePlace();
            client2.WriteCarcassType();
            client2.WriteAmountHP(200);
            client2.WriteNumberFuelConsumprion(15);

            Client client3 = new Client(new PlantPerm());
            client3.WritePlace();
            client3.WriteCarcassType();
            client3.WriteAmountHP(101);
            client3.WriteNumberFuelConsumprion(8.5);
        }
    }
}
