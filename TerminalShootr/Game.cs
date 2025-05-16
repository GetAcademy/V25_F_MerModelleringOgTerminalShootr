using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerminalShootr
{
    internal class Game
    {
        public Player CurrentPlayer = null;
        public Weapon[] AvailableWeapons = 
        [
            new("AK-47", 30),
            new("M4A1-S", 20),
            new("USP-S", 12),
            new("UMP-45", 25),
            new("P90", 50),
            new("Glock-18", 20),
            new("AWP", 5),
            new("SSG-08", 10)
        ];
        public Game()
        {
            Run();
        }

        private void Run()
        {
            while (true)
            {
                Console.WriteLine("xXxCommandLineShootahxXx");
                Console.WriteLine("""
                                  1) Create a player
                                  2) Check current weapons
                                  3) Pick weapon
                                  4) Exit
                                  """);
                HandleInput();
            }
        }

        private void HandleInput()
        {
            var input = Console.ReadKey(true);

            switch (input.Key)
            {
                case ConsoleKey.D1:
                    CreatePlayer();
                    break;
                case ConsoleKey.D2:
                    CheckCurrentWeapons();
                    break;
                case ConsoleKey.D3:
                    PickWeapon();
                    break;
                case ConsoleKey.D4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Wrong input.");
                    break;
            }
        }

        private void PickWeapon()
        {
            Console.WriteLine("Pick a weapon:");
            ShowAvailableWeapons();
            Console.WriteLine("Select an index:");
            var input = Console.ReadLine();
            // CHALLENGE! 
            // Hvordan får jeg valgt våpen fra 
            // AvailableWeapons og lagt de inn i
            // CurrentPlayer sin "inventory"?
        }

        private void ShowAvailableWeapons()
        {
            Console.WriteLine("Available weapons:");
            var index = 0;
            foreach (var weapon in AvailableWeapons)
            {
                Console.WriteLine($"{index}: Name: {weapon.Name} - Ammo: {weapon.Ammo}");
                index++;
            }
        }

        private void CheckCurrentWeapons()
        {
            if (CurrentPlayer == null)
            {
                Console.WriteLine("You haven't created a player yet!");
            }
            else
            {
                foreach (var weapon in CurrentPlayer.Weapons)
                {
                    Console.WriteLine($"Name: {weapon.Name} - Ammo: {weapon.Ammo}");
                }
            }
        }

        private void CreatePlayer()
        {
            CurrentPlayer = new Player(100, 100);
        }
    }
}
