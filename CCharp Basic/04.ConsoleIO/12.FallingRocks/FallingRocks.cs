using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

class FallingRocks
{

    const int WIDTH = 50;
    const int HEIGHT = 30;
    static string clear = "".PadLeft(WIDTH * HEIGHT, ' ');
    static int score = 0;

    public class Dwarf
    {
        public int x;
        public int y;
        public string body;
        public ConsoleColor playerColor;
    }

    public class Rock
    {
        public int x;
        public int y;
        public string body;
        public ConsoleColor color;
    }
    static bool DetectCollision(Dwarf player, List<Rock> rocks)
    {
        int playerX = player.x;
        int playerY = player.y;
        foreach (Rock rock in rocks)
        {
            if (rock.y == playerY)
            {
                if (rock.x >= playerX - (rock.body.Length - 1) && rock.x < playerX + player.body.Length)
                {
                    return true;
                }
            }
        }
        return false;
    }

    static void MoveRocks(List<Rock> rocks)
    {
        for (int i = 0, len = rocks.Count; i < len; i++)
        {
            Rock currentRock = rocks[i];
            currentRock.y++;

            if (currentRock.y == HEIGHT - 2)
            {
                rocks.Remove(currentRock);
                len--;
                score += 10;
            }
        }
    }

    static void PrintField(Dwarf player, List<Rock> rocks)
    {
        PrintUnit(player.body, player.x, player.y, player.playerColor);

        foreach (Rock rock in rocks)
        {
            PrintUnit(rock.body, rock.x, rock.y, rock.color);
        }

    }

    static void PrintUnit(string content, int x, int y, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.WriteLine(content);
    }

    static void ClearScreen()
    {
        Console.SetCursorPosition(0, 0);
        Console.WriteLine(clear);
    }

    static void Main(string[] args)
    {
    begin:
        // playfield size;
        Console.BufferHeight = Console.WindowHeight = HEIGHT;
        Console.BufferWidth = Console.WindowWidth = WIDTH;

        // game speed and info;
        int FPS = 200;
        byte playerLives = 3;
        string difficulty = "Walk in the park!";
        bool hitted = false;

        // random generator;
        Random rand = new Random();

        // player character;
        Dwarf player = new Dwarf();
        player.x = (WIDTH / 2) - 1;
        player.y = HEIGHT - 3;
        player.body = "(0)";
        player.playerColor = ConsoleColor.Green;

        // rocks;
        int rocksCounter = 0;
        List<Rock> rocks = new List<Rock>();
        char[] rockSymbols = { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';', '-' };
        ConsoleColor[] rocksColors = { ConsoleColor.Cyan, ConsoleColor.Blue, ConsoleColor.Cyan, ConsoleColor.Green,
                                             ConsoleColor.Blue, ConsoleColor.DarkMagenta, ConsoleColor.DarkGreen,
                                             ConsoleColor.DarkGreen, ConsoleColor.Yellow, ConsoleColor.Blue,
                                             ConsoleColor.Magenta, ConsoleColor.Red};

        // GAME LOOP;
        while (true)
        {
            rocksCounter++;

            switch (rocksCounter)
            {
                case 200:
                    FPS -= 50;
                    difficulty = "Check your umbrella!";
                    break;
                case 400:
                    FPS -= 50;
                    difficulty = "Run little dwarf, Run!";
                    break;
                case 600:
                    FPS -= 50;
                    difficulty = "NIGHTMARE!";
                    break;
            }

            // refreshing every next frame;

            int rocksCount = rand.Next(0, 2);

            for (int i = 0; i < rocksCount; i++)
            {
                Rock rock = new Rock();
                rock.x = rand.Next(0, WIDTH);
                rock.y = 0;
                int density = rand.Next(1, 4);
                int index = rand.Next(0, rockSymbols.Length);
                rock.body = "".PadLeft(density, rockSymbols[index]);
                rock.color = rocksColors[index];
                rocks.Add(rock);
            }

            MoveRocks(rocks);
            ClearScreen();

            // main character interaction;
            while (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (player.x - 1 >= 0)
                    {
                        player.x--;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (player.x + player.body.Length < WIDTH)
                    {
                        player.x++;
                    }
                }
            }

            PrintField(player, rocks);

            PrintUnit("Difficulty: " + difficulty, 0, 0, ConsoleColor.Yellow);
            PrintUnit("Lives: " + playerLives, WIDTH - 8, 0, ConsoleColor.Yellow);
            PrintUnit("Score: " + score, 0, HEIGHT - 2, ConsoleColor.Yellow);


            if (DetectCollision(player, rocks))
            {
                playerLives--;
                hitted = true;

                if (hitted)
                {
                    rocks.Clear();
                    PrintUnit("(X)", player.x, player.y, ConsoleColor.Red);
                }

                if (playerLives == 0)
                {
                    break;
                }
            }
            Thread.Sleep(FPS);
        }

        // in case your dwarf dies:

        PrintUnit("Final score: " + score, (WIDTH / 2) - 8, (HEIGHT / 2) - 1, ConsoleColor.Yellow);
        PrintUnit("Game OVER! To continue press \"Enter\"!", (WIDTH / 2) - 17, (HEIGHT / 2), ConsoleColor.Yellow);
        ConsoleKeyInfo decision = Console.ReadKey(true);

        switch (decision.Key)
        {
            case ConsoleKey.Enter:
                score = 0;
                goto begin;
            case ConsoleKey.N:
                return;
        }
    }
}