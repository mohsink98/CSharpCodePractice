using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnalynsInfiltration
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(QuestLogic.CanFastAttack(true));
            Console.WriteLine(QuestLogic.CanFastAttack(false));


            Console.WriteLine(QuestLogic.CanSpy(false, false, false));
            Console.WriteLine(QuestLogic.CanSpy(true, false, false));
            Console.WriteLine(QuestLogic.CanSpy(false, true, false));
            Console.WriteLine(QuestLogic.CanSpy(false, false, true));
            Console.WriteLine(QuestLogic.CanSpy(false, true, true));
            Console.WriteLine(QuestLogic.CanSpy(true, false, true));
            Console.WriteLine(QuestLogic.CanSpy(true, true, false));
            Console.WriteLine(QuestLogic.CanSpy(true, true, true));


            Console.WriteLine(QuestLogic.CanSignalPrisoner(false, false));
            Console.WriteLine(QuestLogic.CanSignalPrisoner(false, true));
            Console.WriteLine(QuestLogic.CanSignalPrisoner(true, false));
            Console.WriteLine(QuestLogic.CanSignalPrisoner(true, true));


            Console.WriteLine(QuestLogic.CanFreePrisoner(false, false, false, false));
            Console.WriteLine(QuestLogic.CanFreePrisoner(false, false, false, true));
            Console.WriteLine(QuestLogic.CanFreePrisoner(false, false, true, false));
            Console.WriteLine(QuestLogic.CanFreePrisoner(false, false, true, true));
            Console.WriteLine(QuestLogic.CanFreePrisoner(false, true, false, false));
            Console.WriteLine(QuestLogic.CanFreePrisoner(false, true, false, true));
            Console.WriteLine(QuestLogic.CanFreePrisoner(false, true, true, false));
            Console.WriteLine(QuestLogic.CanFreePrisoner(false, true, true, true));
            Console.WriteLine(QuestLogic.CanFreePrisoner(true, false, false, false));
            Console.WriteLine(QuestLogic.CanFreePrisoner(true, false, false, true));
            Console.WriteLine(QuestLogic.CanFreePrisoner(true, false, true, false));
            Console.WriteLine(QuestLogic.CanFreePrisoner(true, false, true, true));
            Console.WriteLine(QuestLogic.CanFreePrisoner(true, true, false, false));
            Console.WriteLine(QuestLogic.CanFreePrisoner(true, true, false, true));
            Console.WriteLine(QuestLogic.CanFreePrisoner(true, true, true, false));
            Console.WriteLine(QuestLogic.CanFreePrisoner(true, true, true, true));

            Console.ReadLine();
        }
    }
}
