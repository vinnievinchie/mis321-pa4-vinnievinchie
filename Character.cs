namespace mis321_pa4_vinnievinchie
{
    //Abstract character class
    public abstract class Character
    {
            public string PlayerName {get; set;}

            public int MaxPower {get; set;}

            public int Health {get; set;}

            public int AttackStrength {get; set;}

            public int DefensivePower {get; set;}

            public abstract void Attack(Character opponent);

            public abstract void Defend(int incomingDamage);

        //print out the stats of the players
        public void PrintStats() 
        {
            Console.WriteLine("{0} ({1} HP)", PlayerName, Health);
            Console.WriteLine("Max Power: {0}", MaxPower);
            Console.WriteLine("Attack Strength: {0}", AttackStrength);
            Console.WriteLine("Defensive Power: {0}", DefensivePower);
        }

        //define the constructor for the character class
        public Character(string name) 
        {
            PlayerName = name;
            MaxPower = new Random().Next(1, 101);
            Health = 100;
            AttackStrength = new Random().Next(1, MaxPower + 1);
            DefensivePower = new Random().Next(1, MaxPower + 1);
        }
    }
}
