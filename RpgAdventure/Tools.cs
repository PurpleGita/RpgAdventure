

namespace RpgAdventure
{
    internal class Tools
    {
        internal static List<Classes> CreateClasses()
        {
            Classes Nun = new ();
            Nun.NameOfClass = "Nun";
            Nun.Name = "Lasibeth";
            Nun.Backround = "" +
                "Your name is Lasibeth and your where born on the mainland, with loving parents. You whern't the smartest kid, \n but you where born with a kind heart and helped out at the local church allot. \n" +
                "You mostly helped the church to hang out with a young Nun about your age named Ariel. \n When you where just 9 your parents where killed by unkown circumstances and soon after the church took you in, \n and so you became a nun, and worshipper of the true god. \n" +
                "At the church you worked harder then ever before and hardly had free time, and diffently no time to socialsie. \n "+
                "About a year ago, when you turned 20, the church sought out someone willing to go take care of a church, \nthat was build on a small island. The last Nuns working there had gone missing.\n" +
                "When you saw Airel volentir, you decided to go as well. Seeing it as an orpetuinty to get closer to her";
            Nun.Talents = new();
            Nun.Talents.Add("Innocent Face");
            Nun.StartAttacks = new();
            Nun.StartAttacks.Add("Cry");
            Nun.StartAttacks.Add("Punch");
            Nun.StartAttacks.Add("Prayer");
            Nun.Strength = -2;
            Nun.Magic = 3;
            Nun.MaxHP = 20;
            Nun.MaxMp = 10;
            Nun.Charisma = -2;
            Nun.Faith = 4;
            Nun.Perception = 0;
            Nun.Luck = 3;
            Nun.Intellegence = 0;

            Classes Warrior = new();
            Warrior.NameOfClass = "Warrior";
            Warrior.Name = "Karo";
            Warrior.Backround = "";
            Warrior.Talents = new();
            Warrior.Talents.Add("Warrios Might");
            Warrior.Talents.Add("Flaming Hit");
            Warrior.StartAttacks = new();
            Warrior.StartAttacks.Add("Swing Weapon");
            Warrior.StartAttacks.Add("Headbut");
            Warrior.Strength = 3;
            Warrior.Magic = 1;
            Warrior.MaxHP = 23;
            Warrior.MaxMp = 5;
            Warrior.Charisma = 0;
            Warrior.Faith = 2;
            Warrior.Perception = 1;
            Warrior.Luck = 0;
            Warrior.Intellegence = 2;

            List<Classes> classList = new();

            classList.Add(Nun);
            classList.Add(Warrior);

            return(classList);
        }


        internal static Classes ChoseClass(List<Classes> classList)
        {
            //intilisere værdier
            int classAmount;
            string? input = null;
            bool choiceMade = false;
            int classChosen = 0;
            List<string> inputLookingFor = new();

            do
            {
                //starter menuen og ser hvor mange classes der er i spilelt.
                classAmount = 1;
                foreach (var item in classList)
                {
                    inputLookingFor.Add(classAmount.ToString());
                    classAmount++;

                }

                //udskiver menuen
                Console.WriteLine("Welcome to and RPG Adventure, you will take on the role a class/charckter and play trough a series of events. \n " +
                    "Along the way you will make choices and fight monsters!. \n please selecet a class, the class will also determine what type of adventure you go on. \n" +
                    "chose a class that best suits you by pressing the corrorspoding number:");

                //udskriver clases bærseret på hvor mange af dem der er der
                for (int i = 0; i < classAmount - 1; i++)
                {
                    Console.WriteLine(i + 1 + "  " + classList[i].NameOfClass);
                }

                //tager input
                input = TakeInput(inputLookingFor);

                Console.Clear();
                ShowInfo(classList[Int16.Parse(input) - 1]);
                classChosen = Int16.Parse(input) - 1;
                Console.WriteLine("Continue with this class? \n 1: Continue     2: Back to menu");
                input = TakeInput(inputLookingFor);
                Console.Clear();
                if (Int16.Parse(input) == 1)
                {
                    choiceMade = true;
                }
            } while(choiceMade == false);
            return (classList[classChosen]);
        }

        internal static string TakeInput(List<string> inputLookingFor)
        {
            //intilisere værdier
            string? input = null;
            int i;
            bool inputGotten = false;

            //et do while loop som køre indtill brugeren har tastet de ønsket tegn
            do
            {
                input = Console.ReadKey().KeyChar.ToString();
                i = 0;
                foreach (var item in inputLookingFor)
                {
                    if (input == inputLookingFor[i])
                    { inputGotten = true; }
                    i++;
                }

                if (!inputGotten) { Console.WriteLine("Wrong input try again"); }

            } while (inputGotten == false);

            return input;
        }

        internal static void ShowInfo(Classes Class) 
        {
            int i = 0;
            string? input;
            List<string> inputLookingFor = new();
            inputLookingFor.Add("1");
            inputLookingFor.Add("2");

            Console.WriteLine("Class:           " + Class.NameOfClass);
            Console.WriteLine("Name:            " + Class.Name);
            Console.WriteLine("Description:  \n " + Class.Backround);
            Console.Write("Talents:         ");
            foreach (var item in Class.Talents)
            {
                Console.Write(Class.Talents[i] + "      ");
                i++;
            }
            i = 0;

            Console.Write(" \nStart attacks:   ");
            foreach (var item in Class.StartAttacks)
            {
                Console.Write(Class.StartAttacks[i] + "      ");
                i++;
            }

            Console.WriteLine("\nMaxHp:           " + Class.MaxHP);
            Console.WriteLine("MaxMp:           " + Class.MaxMp);
            Console.WriteLine("Strength:        " + Class.Strength);
            Console.WriteLine("Magic:           " + Class.Magic);
            Console.WriteLine("Charisma:        " + Class.Charisma);
            Console.WriteLine("Faith:           " + Class.Faith);
            Console.WriteLine("Perception:      " + Class.Perception);
            Console.WriteLine("Intellengence:   " + Class.Intellegence);
            Console.WriteLine("Strength:        " + Class.Luck + "\n");


            return; 
        }

        internal static Charchter CreateCharcther(Classes Class) 
        {
            int rerollsLeft = 3;
            string? input = null;
            Random random = new Random();
            List<string> inputLookingFor = new();
            inputLookingFor.Add("1");
            inputLookingFor.Add("2");
            Charchter playerCharackter = new();

            do
            {
                playerCharackter.Talents = Class.Talents;
                playerCharackter.Attacks = Class.StartAttacks;
                playerCharackter.MaxHP = Class.MaxHP + random.Next(1, 7);
                playerCharackter.HP = playerCharackter.MaxHP;
                playerCharackter.MaxMP = Class.MaxMp + random.Next(1, 7);
                playerCharackter.MP = playerCharackter.MaxMP;
                playerCharackter.Strength = Class.Strength + random.Next(1, 7);
                playerCharackter.Magic = Class.Magic + random.Next(1, 7);
                playerCharackter.Charisma = Class.Charisma + random.Next(1, 7);
                playerCharackter.Faith = Class.Faith + random.Next(1, 7);
                playerCharackter.Perception = Class.Perception + random.Next(1, 7);
                playerCharackter.Luck = Class.Luck + random.Next(1, 7);
                playerCharackter.Intellegence = Class.Intellegence + random.Next(1, 7);

                Console.Clear();
                ShowInfoCharackter(playerCharackter, Class);
                if (rerollsLeft != 0)
                {
                    Console.WriteLine("do you wish to go with these stats or do you wish to reroll? \nRerolls left: " + rerollsLeft);
                    Console.WriteLine("1: Continue   2: Reroll");
                    input = TakeInput(inputLookingFor);
                }
                if (input == "1")
                {
                    rerollsLeft = 0;
                }
                else
                {
                    rerollsLeft--;
                }
            } while (rerollsLeft != -1);
            return (playerCharackter);
        }

        internal static void ShowInfoCharackter(Charchter playerCharackter , Classes Class) 
        {
            int i = 0;
            Console.WriteLine("Class:           " + Class.NameOfClass);
            Console.WriteLine("Name:            " + Class.Name);
            Console.Write("Talents:         ");
            foreach (var item in playerCharackter.Talents)
            {
                Console.Write(playerCharackter.Talents[i] + "      ");
                i++;
            }
            i = 0;

            Console.Write(" \n attacks:   ");
            foreach (var item in playerCharackter.Attacks)
            {
                Console.Write(playerCharackter.Attacks[i] + "      ");
                i++;
            }

            Console.WriteLine("\nMaxHp:           " + playerCharackter.MaxHP);
            Console.WriteLine("MaxMp:           " + playerCharackter.MaxMP);
            Console.WriteLine("Strength:        " + playerCharackter.Strength);
            Console.WriteLine("Magic:           " + playerCharackter.Magic);
            Console.WriteLine("Charisma:        " + playerCharackter.Charisma);
            Console.WriteLine("Faith:           " + playerCharackter.Faith);
            Console.WriteLine("Perception:      " + playerCharackter.Perception);
            Console.WriteLine("Intellengence:   " + playerCharackter.Intellegence);
            Console.WriteLine("Strength:        " + playerCharackter.Luck + "\n");
        }
    }
}
