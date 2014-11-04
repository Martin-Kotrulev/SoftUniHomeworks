using System;
//Problem 4 – Chess Queens
//We are given a chess board of size N * N. The 
//only figures we have on the    
//chess board are two queens. The queen in chess
//can move in horizontal, vertical and diagonal 
//directions. We are also given a number D which 
//represents the distance between the two queens.
//The distance is measured by D squares away. All 
//positions on the chessboard are represented with 
//numbers and letters (a1, a2… a8, b1-b8, c1-c8, …, h1-h8). 
//Example: if N=16, the numbers on the board will 
//be represented with integers (1-16) and letters 
//(a-o). Your task is to find all couples of queens 
//where the queens stay either on the same vertical,
//horizontal or diagonal, at distance D. See the 
//diagram aside to understand your task better. 
//The green queens meet the condition of 2 blocks 
//away but the red queens aren’t.
//Input
//The input data should be read from the console. 
//It consists of 2 lines:
//•	The first line holds an integer number N 
//representing the width and height of the chess board.
//•	The second line holds an integer number D 
//representing the distance that we should be looking for.
//The input data will always be valid and in the 
//format described. There is no need to check it explicitly.
//Output
//The output should be printed on the console as
//a sequence of chess position in the format 
//[quеen1X, quеen1Y  - quеen2X, quеen2Y]. The order 
//of the output is not important. Each string should 
//stay on a separate line. In case they are no valid 
//positions print “No valid position”.
//Constraints
//•	The numbers N and D will be integers in the range [0…20].
//•	Allowed memory: 16 MB.

class ChessQueens
{
    static bool CheckDistance(char c1, int n1, char c2, int n2, int d)
    {
        if (c1 == c2 && n1 + d == n2) return true;
        else if (c1 == c2 && n1 - d == n2) return true;

        else if (n1 == n2 && c1 + d == c2) return true;
        else if (n1 == n2 && c1 - d == c2) return true;

        else if (c1 + d == c2 && n1 - d == n2) return true;
        else if (c1 - d == c2 && n1 + d == n2) return true;

        else if (c1 + d == c2 && n1 + d == n2) return true;
        else if (c1 - d == c2 && n1 - d == n2) return true;

        //if (c1 == c2 && Math.Abs(n1 - n2) == d) return true;
        //else if (n1 == n2 && Math.Abs(c1 - c2) == d) return true;
        //else if (Math.Abs(c1 - c2) == d && Math.Abs(n1 - n2) == d) return true;

        return false;
    }

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        d++;
        int ctr = 0;

        for (char c1 = 'a'; c1 < 'a' + n; c1++)
        {
            for (int n1 = 1; n1 <= n; n1++)
            {
                for (char c2 = 'a'; c2 < 'a' + n; c2++)
                {
                    for (int n2 = 1; n2 <= n; n2++)
                    {
                        if (CheckDistance(c1, n1, c2, n2, d))
                        {
                            Console.WriteLine("{0}{1} - {2}{3}", c1, n1, c2, n2);
                            ctr++;
                        }
                    }
                }
            }
        }
        if (ctr == 0) Console.WriteLine("No valid positions");
    }
}