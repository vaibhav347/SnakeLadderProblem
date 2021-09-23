using System;

namespace Game
{
    class SnakeLadderTwoPlayer
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

	// Step of Player B
        int stepB = 2;

	// Play started
        void ladderSnake()
        {
            while (stepA < 100 || stepB < 100)
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
			    ladder();
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

                Console.WriteLine("\n");
                Console.WriteLine("\n");


                // B Playing now

		// Player B rolling dice
                int diceB = rand.Next(1, 7);

                Console.WriteLine("Dice of B : " + diceB);
                if (stepB + diceB <= 100)
                {
                    stepB = stepB + diceB;
                    Console.WriteLine("Step of B: " + stepB);
                    if (stepB == 100)
                        break;
                    if (stepB == L1 || stepB == L2 || stepB == L3 || stepB == L4 || stepB == L5)
                    {
                        if (stepB + 10 <= 100)
                        {
                            stepB = stepB + 10;
                            Console.WriteLine("Step of B ( Ladder ) : " + stepB);
                            if (stepB == 100)
                                break;
			    ladder();
                        }
                    }
                    if (stepB == S1 || stepB == S2 || stepB == S3 || stepB == S4 || stepB == S5)
                    {
                        if (stepB - 5 < 1)
                            stepB = 1;
                        else
                            stepB = stepB - 5;
                        Console.WriteLine("Step of B( Snake ) : " + stepB);
                        if (stepB == 100)
                            break;
                    }
                }
            }

            Console.WriteLine("\n");
            Console.WriteLine("\n");

            if (stepA == 100)
                Console.WriteLine(" A Won");
            else
                Console.WriteLine(" B Won");
        }
        static void Main(string[] args)
        {
	    // Object Creation of class Play
            SnakeLadderTwoPlayer prog = new SnakeLadderTwoPlayer();

	    // Calling methon using object
            prog.ladderSnake();
        }
    }
}
