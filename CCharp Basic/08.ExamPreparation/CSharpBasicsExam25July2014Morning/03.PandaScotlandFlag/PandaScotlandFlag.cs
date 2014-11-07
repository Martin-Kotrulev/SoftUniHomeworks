using System;
//A###################B
//~C#################D~
//~~E###############F~~
//~~~G#############H~~~
//~~~~I###########J~~~~
//~~~~~K#########L~~~~~
//~~~~~~M#######N~~~~~~
//~~~~~~~O#####P~~~~~~~
//~~~~~~~~Q###R~~~~~~~~
//~~~~~~~~~S#T~~~~~~~~~
//----------U----------
//~~~~~~~~~V#W~~~~~~~~~
//~~~~~~~~X###Y~~~~~~~~
//~~~~~~~Z#####A~~~~~~~
//~~~~~~B#######C~~~~~~
//~~~~~D#########E~~~~~
//~~~~F###########G~~~~
//~~~H#############I~~~
//~~J###############K~~
//~L#################M~
//N###################O

// SOLUTION TESTED - 100%

class PandaScotlandFlag
{
    static char GetNextLetter(ref char c)
    {
        if (c == 'Z') c = '@';

        return ++c;
    }

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int innerSharps = n - 2;
        int outerTilts = 0;
        char letter = '@'; // small hack

        for (int i = 0; i < n; i++)
        {
            if (letter == 'Z') letter = '@';
            if (i != n / 2) Console.WriteLine(
                 "{0}{1}{3}{2}{0}", new string('~', outerTilts),
                  GetNextLetter(ref letter), GetNextLetter(ref letter),
                  new string('#', innerSharps));
            else Console.WriteLine(
                "{0}{1}{0}", new string('-', outerTilts), GetNextLetter(ref letter));

            if (i < n / 2)
            {
                innerSharps -= innerSharps == 1 ? 1 : 2;
                outerTilts++;
            }
            else
            {
                innerSharps += innerSharps == 0 ? 1 : 2;
                outerTilts--;
            }
        }
    }
}