using System;
//Problem 3 – Sand Glass
//Once upon a time a powerful wizard was born. His name 
//was Gwenogfryn and soon he became a great sorcerer.
//Kind-hearted he was. He would only use his magic to 
//protect humans from the evil witches that would come 
//at night. Gwenogfryn, however was a pacifist and did 
//not want to fight or hurt the witches, so he came up 
//with another solution. He would catch the witches and
//throw them into a sand-glass (the only prison a witch
//cannot escape from). Unfortunately, he is running out
//of sand-glasses. Help Gwenogfryn catch all witches by
//making your own sand-glasses.

//Input
//•	The input data should be read from the console.
//•	You have an integer number N (always odd number) 
//showing the height of the sand clock.
//•	The input data will always be valid and in the 
//format described. There is no need to check it explicitly.

//Output
//•	The output should be printed on the console.
//•	You should print the hourglass on the console. 
//Each row can contain only the following characters:
//“.” (dot) and “*” (asterisk). As shown in the example:
//the middle row must contain only one ‘*’ and all other
//symbols must be “.”. Every next row (up or down from 
//the middle one) must contain the same number of ‘*’ as
//the previous one plus two. You should only use “.” to 
//fill-in the rows, where necessary.

//Constraints
//•	The number N will be a positive integer number between 3 and 101, inclusive.
//•	Allowed working time for your program: 0.25 seconds.
//•	Allowed memory: 16 MB.

class SandGlass
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int stars = n;
        int dots = 0;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(
                "{0}{1}{0}", new string('.', dots), new string('*', stars));

            if (i < n / 2)
            {
                stars -= 2;
                dots++;
            }
            else
            {
                stars += 2;
                dots--;
            }
        }
    }
}