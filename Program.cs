using mis321_pa4_vinnievinchie;

class Program
    {
        static void Main(string[] args)
        {
            //Create player 1 and 2
            Character player1 = SelectCharacter("Player 1");
            Character player2 = SelectCharacter("Player 2");

            Console.WriteLine($"{player1.PlayerName} vs {player2.PlayerName}");

            bool player1Turn = true;

            //keep the game going until one of the player's health is at 0
            while (player1.Health > 0 && player2.Health > 0)
            {
                Character attacker, defender;
                
                //Alternate player 1 and 2
                if (player1Turn)
                {
                    attacker = player1;
                    defender = player2;
                }
                else
                {
                    attacker = player2;
                    defender = player1;
                }

                Console.WriteLine($"{attacker.PlayerName}'s turn");
                attacker.Attack(defender);
                Console.WriteLine();

                Console.WriteLine($"{defender.PlayerName}'s current stats:");
                defender.PrintStats();
                Console.WriteLine();

                player1Turn = !player1Turn;
            }

            //Determine the winner based on the health left
            Character winner = player1.Health > 0 ? player1 : player2;
            Console.WriteLine($"{winner.PlayerName} wins!");
            Console.ReadLine();
        }

        //User should select character until a valid choice is made
        static Character SelectCharacter(string playerName)
        {
            Console.WriteLine($"{playerName}, select a character:");
            Console.WriteLine("1. Davy Jones");
            Console.WriteLine("2. Jack Sparrow");
            Console.WriteLine("3. Will Turner");

            int choice;
            do
            {
                Console.Write("Enter your choice: ");
            } while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3);

            //Return the selected character
            switch (choice)
            {
                case 1:
                    return new DavyJones(playerName);
                case 2:
                    return new JackSparrow(playerName);
                case 3:
                    return new WillTurner(playerName);
                default:
                    return null;
            }
        }
    }