﻿using System;
using System.Collections.Generic;

namespace PlayerManager3
{

    /// </summary>
    public class Program
    {
        /// <summary>
        /// The list of all players.
        /// </summary>
        private List<Player> playerList;
        /// <summary>
        /// Program begins here.
        /// </summary>
        private static void Main()
        {
            // Create a new instance of the player listing program
            Program prog = new Program();
            // Start the program instance
            prog.Start();
        }
        /// <summary>
        /// Creates a new instance of the player listing program.
        /// </summary>
        private Program()
        {
            // Initialize the player list with two players using collection
            // initialization syntax
            playerList = new List<Player>() {
                new Player("Best player ever", 100),
                new Player("An even better player", 500)
            };
        }
        /// <summary>
        /// Start the player listing program instance
        /// </summary>
        private void Start()
        {
            // We keep the user's option here
            string option;
            // Main program loop
            do
            {
                // Show menu and get user option
                ShowMenu();
                option = Console.ReadLine();
                // Determine the option specified by the user and act on it
                switch (option)
                {
                    case "1":
                        InsertPlayer();
                        break;
                    case "2":
                        ListPlayers(playerList);
                        break;
                    case "3":
                        ListPlayersWithScoreGreaterThan();
                        break;
                    case "4":
                        Console.WriteLine("Bye!");
                        break;
                    default:
                        Console.Error.WriteLine("\n>>> Unknown option! <<<\n");
                        break;
                }
                // Wait for user to press a key...
                Console.Write("\nPress any key to continue...");
                Console.ReadKey(true);
                Console.WriteLine("\n");
                // Loop keeps going until players choses to quit (option 4)
            } while (option != "4");
        }
        /// <summary>
        /// Shows the main menu.
        /// </summary>
        private void ShowMenu()
        {
            Console.WriteLine(
                "Welcome! \n1: Inserir jogador \n2: Listar jogadores "
                + "\n3: Jogadores com o maior Score \n4: Sair");
        }
        /// <summary>
        /// Inserts a new player in the player list.
        /// </summary>
        private void InsertPlayer()
        {
            string name;
            int score = 0;
            Console.Write("Insira o Nome: ");
            name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Insira o Score: ");
            score = int.Parse(Console.ReadLine());
            Console.WriteLine();
            try{
                playerList.Add(new Player(name, score));
                Console.WriteLine($"Added {name} with the score {score}");
            }   
            catch (Exception e) {
                Console.WriteLine(
                    $"ERRO: Não foi possível adicionar jogador: {e.Message}");
            }
        }
        /// <summary>
        /// Show all players in a list of players. This method can be static
        /// because it doesn't depend on anything associated with an instance
        /// of the program. Namely, the list of players is given as a parameter
        /// to this method.
        /// </summary>
        /// <param name="playersToList">
        /// An enumerable object of players to show.
        /// </param>
        private static void ListPlayers(IEnumerable<Player> playersToList)
        {
            List<Player> playerList = new List<Player>(playersToList);

            playerList.Sort(); 
            playerList.Reverse();
    
    
  
            foreach (Player player in playersToList)
            {
                Console.WriteLine($"{player.Name} {player.Score}");
            }
        }
        /// <summary>
        /// Show all players with a score higher than a user-specified value.
        /// </summary>
        private void ListPlayersWithScoreGreaterThan()
        {
            int minScore = 0;
            Console.Write("Insert minimum score: ");
            minScore = int.Parse(Console.ReadLine());
            foreach (Player player in GetPlayersWithScoreGreaterThan(minScore))
            {
                Console.WriteLine($"{player.Name} {player.Score}");
            }
        }
        /// <summary>
        /// Get players with a score higher than a given value.
        /// </summary>
        /// <param name="minScore">Minimum score players should have.</param>
        /// <returns>
        /// An enumerable of players with a score higher than the given value.
        /// </returns>
        private IEnumerable<Player> GetPlayersWithScoreGreaterThan(int minScore)
        {
            foreach (Player player in playerList) 
            {
                if (player.Score > minScore)
                {
                    yield return player;
                }
            }
        }
    }
}

