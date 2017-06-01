using System;

namespace Euler4
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal testGetal = 997799; //het grootste getal dat met 2* 3 digits bereikt kan worden is (999 * 999 = ) 998.001 Het eerste palindroom nummer daaronder is 997799
            decimal eerstePalindroom = 999; // het grootste getal met 3 digits is 999. Ik deel het testgetal door 999 en trek daarvan 1 af als het antwoord van de deling (testnummer / eerstePalindroom) geen geheel getal oplevert
            decimal verminderingEen = 1100; // van een rij met tien getallen geven de eerste 9 telkens 1100 verschil met het vorige palindroom getal (vb: 997799 is het eerste getal, het eerst volgende palindroom getal is (997799-1100 = ) 996699 etc.
            decimal verminderingTientallen = 110; // van een rij met honderd getallen geeft elk tiende getal een verschil van 110 met het vorige palindroom getal
            decimal verminderingHonderttallen = 11; // van een rij met duizend getallen geeft elk honderdste getal een verschil van 11 met het vorige palindroom getal
            decimal controleGetal = 1; // dit is een controle getal om te bepalen welke van de voorgaande drie getallen van het palindroom getal afgetrokken moet worden
            decimal antwoord;

            for (testGetal= testGetal; eerstePalindroom > 99; eerstePalindroom = eerstePalindroom -1)
            {
                antwoord = testGetal / eerstePalindroom;

                if (antwoord > 1000 || eerstePalindroom <100)
                {
                    controleGetal = controleGetal + 1;
                    eerstePalindroom = 999;
                    if (controleGetal % 100 == 0)
                    {
                        testGetal = testGetal - verminderingHonderttallen;
                        continue;
                    }
                    else if (controleGetal% 10 == 0)
                    {
                        testGetal = testGetal - verminderingTientallen;
                        continue;
                    }
                    else
                    {
                        testGetal = testGetal - verminderingEen;
                        continue;
                    }
                }
                else if (antwoord % 1 == 0 && antwoord <1000 && antwoord >100)
                {
                    Console.WriteLine(testGetal);
                    Console.WriteLine(eerstePalindroom);
                    Console.WriteLine(testGetal / eerstePalindroom);
                    Console.ReadKey();
                    break;
                }
                else 
                {
                    continue;
                }
            }
            Console.ReadKey();
        }
    }
}
