using System;

namespace Game
{
    class SnakeLadderOnePlayer
    {
	// L for ladder
        int L1 = 7;
        int L2 = 20;
        int L3 = 44;
        int L4 = 78;
        int L5 = 90;

	// S for snake
        int S1 = 3;
        int S2 = 35;
        int S3 = 56;
        int S4 = 80;
        int S5 = 97;
	
	// Step of Player A
        int stepA = 1;

	// Play started
        void ladderSnake()
        {
            while (stepA < 100)
            {
                Random rand = new Random();

                // A Playing now

		// Player A rolling dice
		int diceA = rand.Next(1, 7);

                Console.WriteLine("Dice of A : " + diceA);
                if (stepA + diceA <= 100)
                {
                    stepA = stepA + diceA;
                   Console.WriteLine("Step of A: " + stepA);
                   if (stepA == 100)
                        break;
                    if (stepA == L1 || stepA == L2 || stepA == L3 || stepA == L4 || stepA == L5)
                    {
                        if (stepA + 10 <= 100)
                        {
                            stepA = stepA + 10;
                            Console.WriteLine("Step of A ( Ladder ) : " + stepA);
                            if (stepA == 100)
                                break;
                        }
                    }
                    if (stepA == S1 || stepA == S2 || stepA == S3 || stepA == S4 || stepA == S5)
                    {
                        if (stepA - 5 < 1)
                            stepA = 1;
                        else
                            stepA = stepA - 5;
                        Console.WriteLine("Step of A( Snake ) : " + stepA);
                        if (stepA == 100)
                            break;
                    }
                }

               
	}

            Console.WriteLine("\n");
            Console.WriteLine("\n");
	    Console.WriteLine("A won : " + stepA);
        }
        static void Main(string[] args)
        {
	    // Object Creation of class Play
            SnakeLadderOnePlayer obj = new SnakeLadderOnePlayer();

	    // Calling methon using object
            obj.ladderSnake();
        }
    }
}
