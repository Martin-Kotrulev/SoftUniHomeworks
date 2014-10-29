using System;
// ITERARIVE VARIANT

class FiveSpecialLetters
{
    static int start = int.Parse(Console.ReadLine());
    static int end = int.Parse(Console.ReadLine());
    static int loops = 5;
    static char[] seq = { 'a', 'a', 'a', 'a', 'a' };
    static int seqCtr = 0;

    static int GetCharWeight(char c)
    {
        switch (c)
        {
            case 'a': return 5;
            case 'b': return -12;
            case 'c': return 47;
            case 'd': return 7;
            case 'e': return -32;
            default: return 0;
        }
    }

    static int BuildSeq(char[] seq)
    {
        bool[] used = new bool[(int)'e' + 1];//(int)'e'= 101
        int weight = 0;
        int index = 1;

        for (int i = 0; i < seq.Length; i++)
        {
            char c = seq[i];

            if (!used[c])
            {
                weight += index * GetCharWeight(c);
                index++;
                used[c] = true;
            }
        }

        return weight;
    }

    static void PrintSeq(char[] seq)
    {
        if (seqCtr > 0) Console.Write(" ");

        foreach (var c in seq) Console.Write(c);

        seqCtr++;
    }

    static void Main()
    {
        int currentPosition;

        while (true)
        {
            int seqWeight = BuildSeq(seq);

            if (seqWeight >= start && seqWeight <= end) PrintSeq(seq);
            currentPosition = loops - 1;
            seq[currentPosition]++; // until is > 'e'

            while (seq[currentPosition] > 'e')
            {
                seq[currentPosition] = 'a';// restart current position
                currentPosition--;// changing position if current is > 'e'

                if (currentPosition < 0)// end of iterations
                {
                    if (seqCtr == 0) Console.Write("No");
                    return;
                }

                seq[currentPosition]++; // iterating previous position
            }
        }
    }
}