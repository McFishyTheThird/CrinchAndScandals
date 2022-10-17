Random all = new Random();
// System.Console.Clear(); när det blir för mycket text på skärmen
int rngEDamage = 0;
List<string> shopList = new List<string>();
List<string> Inventory = new List<string>();
Inventory.Add("Fists");
Inventory.Add("Big Bad Bonk");
Inventory.Add("Aimbot Water Gun");
Inventory.Add("Dildo Cane");
shopList.Add("Big Bad Bonk");
shopList.Add("Aimbot Water Gun");
shopList.Add("Homing Water Gun");
shopList.Add("Dildo Cane");
int rDamage = 0;
int rBlock = 0;
int retry = 0;
string Weapon = "a";
int healthP1 = 0;
int healthP2 = 0;
int rngEnemyRound = 0;
int rngEBlock = 0;
string yes = "yes";
int round = 1;
string fight = "e";
string Fighter = "e";
int eFighter = 0;
string eFighterName = "a";
string secretSplat = "a"; 
string Weakling = "awd";
while (yes =="yes")
{
    Console.WriteLine("Welcome to the totaly family friendly game. Crinch and Scandals");
    Console.WriteLine();
    Console.WriteLine("What gamemode you you want to play. A:Normal match B:Beginner (to get used to the game) C:Lore");    
    string mode = Console.ReadLine().ToLower();
    System.Console.Clear();
    if (mode == "b")
    {
        //name and health variables
        Console.WriteLine("What is your name soon to be dead person?");
        string name = Console.ReadLine();
        Console.WriteLine($"You really have poor imagination. {name} is a terrible name but ok.");
        Console.WriteLine($"Welcome {name} today you will be facing the strongest, handsomest, prettiest and above average Bobby McWeakling(ignore his name) in a grousome 1v1 battle.");
        healthP1 = 100;
        healthP2 = 200;
        while (healthP1 != 0 && healthP2 != 0)
        {
            Random rngEnemy = new Random();
            rngEnemyRound = rngEnemy.Next(1, 3);
            Random damage = new Random();
            Random Block = new Random();
            Random eDamage = new Random();
            Random eBlock = new Random();
            rngEBlock = eBlock.Next(1, 11);
            //Players choice
            Console.WriteLine($"What does {name} do?");
            Console.WriteLine("A:Attack B:Block");
            fight = Console.ReadLine().ToLower();
            //Player attakcs
            if (fight == "a")
            {
                //players damage
                Console.WriteLine($"{name} gets ready to attack.");
                rDamage = damage.Next(1, 21);
                Console.ReadLine();
                //Enemys turn
            }
            else if (fight == "b")
            {
                //player blocks
                Console.WriteLine($"{name} goes into coward mode and gets ready to block!");
                Console.ReadLine();
                rBlock = Block.Next(1, 11);
                //Enemys turn
            }
            else
            {
                //player didnt do anything
                Console.WriteLine($"For some reason {name} decides to be a f**ing idiot and does nothing.");
                Console.ReadLine();
                //Enemys turn
            }
            Console.WriteLine("What does Bobby McWeakling do?");
            Console.ReadLine();
            if (rngEnemyRound == 1)
            {
                Console.WriteLine("Bobby McWeakling is a giga chad and gets ready to attack.");
                rngEDamage = eDamage.Next(10, 31);
            }
            else if (rngEnemyRound == 2)
            {
                Console.WriteLine("Bobby McWeakling is a giga chad and gets ready to block.");
                rngEBlock = eBlock.Next(5, 21);
            }
            Console.WriteLine("They both charge!!");
            if (fight == "a")
            {
                if (rngEnemyRound == 1)
                {
                    Console.WriteLine($"Both {name} and Bobby McWeakling attack!!");
                    healthP1 -= rngEDamage;
                    healthP2 -= rDamage;
                    if (healthP1 < 0)
                    {
                        healthP1 = 0;
                    }
                    if (healthP2 < 0)
                    {
                        healthP2 = 0;
                    }
                    Console.ReadLine();
                    Console.WriteLine($"After a gruesome fight {name} took {rngEDamage} damage and has {healthP1} health left and Bobby McWeakling took {rDamage} damage and has {healthP2} health left.");
                }
                else if (rngEnemyRound == 2)
                {
                    Console.WriteLine($"{name} attacks and Bobby McWeakling blocks!!");
                    rDamage -= rngEBlock;
                    if (rDamage < 0)
                    {
                        rDamage = 0;
                    }
                    healthP2 -= rDamage;
                    if (healthP2 < 0)
                    {
                        healthP2 = 0;
                    }
                    Console.ReadLine();
                    Console.WriteLine($"{name} brutaly tries to murder Bobby McWeakling with but Bobby McWeakling blocks with {rngEBlock} using his super strength(science)and only takes {rDamage} damage and now has {healthP2} health left.");
                }
            }
            else if (fight == "b")
            {
                if (rngEnemyRound == 2)
                {
                    Console.WriteLine($"both {name} and Bobby McWeakling blocks so nothing happens.");
                }
                else if (rngEnemyRound == 1)
                {
                    Console.WriteLine($"{name} blocks and Bobby McWeakling attacks!!");
                    rngEDamage -= rBlock;
                    if (rngEDamage < 0)
                    {
                        rngEDamage = 0;
                    }
                    healthP1 -= rngEDamage;
                    if (healthP1 < 0)
                    {
                        healthP1 = 0;
                    }
                    Console.ReadLine();
                    Console.WriteLine($"{name} blocks like a coward with {rBlock} and Bobby McWeakling attacks like a giga chad and deals {rngEDamage} damage and {name} only has a puny amount of {healthP1} health left.");
                }
            }
            else
            {
                if (rngEnemyRound == 1)
                {
                    rngEDamage += 20;
                    healthP1 -= rngEDamage;
                    if (healthP1 < 0)
                    {
                        healthP1 = 0;
                    }
                    Console.WriteLine($"Since {name} decided to do nothing he takes more damage by Bobby McWeaklings attack which now dealt {rngEDamage} damage and he only has {healthP1} health left.");
                }
                else if (rngEnemyRound == 2)
                {
                    rngEDamage = eDamage.Next(10, 31);
                    rngEDamage -= 10;
                    if (rngEDamage < 0)
                    {
                        rngEDamage = 0;
                    }
                    healthP1 -= rngEDamage;
                    if (healthP1 < 0)
                    {
                        healthP1 = 0;
                    }
                    Console.WriteLine($"Bobby McWeakling blocked but since {name} was dumb and didn't do anything Bobby McWeakling charges but since it wasn't coordinated the attack only did {rngEDamage} damage and {name} now has {healthP1} health left.");
                }
            }
            Console.ReadLine();
            round ++;
            if (healthP1 > 0 && healthP2 > 0)
            {
                Console.WriteLine($"Round {round}!!!");
            }
            if (healthP1 == 0)
            {
                Console.WriteLine($"Our greatest hero Bobby McWeakling won in just {round} rounds!!!");
            }
            if (healthP2 == 0)
            {
                Console.WriteLine($"Unfortunatly our puny unimportant contestant {name} has won...congrats.");
            }
        }
    }
    // If mode Beginner
    else if (mode == "a")
    {
        //Game mode 2 where basically every row of code needs to be changed again somewhat
        Console.WriteLine($"Welcome strange man today you will be facing someone in a grousome and deadly and 100% family friendly 1v1 battle because family friendly is what we care about most and");
        Console.Write("there will be lots and lots and lots of blood. So much blood infact your puny, disgusting mortal brain won't be able to handle it.");
        Console.WriteLine();
        Console.WriteLine("Anyway, Choose your fighter!!!(you have no idea what they do) >:)");
        while (retry == 0)
        {
            Console.WriteLine("1:Leanarth 2:Williom 3:Axlel 4:Dhoni");
            Fighter = Console.ReadLine();
            if (Fighter == "1")
            {
                Fighter = "Leanarth";
                Console.WriteLine(Fighter);
                healthP1 = 1000;
                Console.WriteLine("Health: 1000");
                Console.WriteLine("Abilities: heals from dildo weapon attacks and immune to stupidity debuff. Better probability for good food but is distracted by dance attacks and the nakee armor. Debuff effects +50%.");
                retry = 1;
                Console.WriteLine("Do you have anything to say?");
                secretSplat = Console.ReadLine(); 
                if (secretSplat == "Ya weni marei mirekyarahire Juri yu mirekerason Kire hyari yoriherahe nyurahera Nunnyura unera yurawera nyimerani Chopperipo shurashurafe Nannyurunire nifaferahi Nannyuruni weranira shuraharahi Nyurunirehara fe fe fe Ya weni marei mirekyarahire Juri yu mirekerason Kire hyari yoriherahe nyurahera Nunnyura unera yurawera fimera Na nire jute mirekyaraherya Nire yu mirekerason Kire hyari nuriherahe nyurahera Nunnyura unera yurawera fimerani")
                {
                    Console.WriteLine("That heavenly melody!");
                    Console.WriteLine("You get Octobot king MK III armor, E-Litre 4K weapon and Killer Wail special weapon");
                }
                else
                {
                    Console.WriteLine("Oke, crinch");
                }
                
            }
            else if (Fighter == "2")
            {
                Fighter = "Williom";
                Console.WriteLine(Fighter);
                healthP1 = 1000;
                Console.WriteLine("Health: 1000");
                Console.WriteLine("Abilities: Immune to stupidity debuff and knowledge buff. Higher chance for water gun weapons and chicken launcher. -10% buffs from foods but -25% debuffs from foods. Will always get at least one Fists. Can either deal max crit or no damage with ranged weapons(No inbetween)");
                retry = 1;
            }
            else if (Fighter == "3")
            {
                Fighter = "Axlel";
                Console.WriteLine(Fighter);
                healthP1 = 2000;
                Console.WriteLine("Health: 2000");
                Console.WriteLine("Abilities: +25% damage buff with melee and automaticly starts with beeg forehed. +10% chance for melee. Bigger chance for bad food.");
                retry = 1;
            }
            else if (Fighter == "4")
            {
                Fighter = "Dhoni";
                Console.WriteLine(Fighter);
                healthP1 = 1000;
                Console.WriteLine("Health: 1000");
                Console.WriteLine("Abilities: +500% cringe damage. Immune to maidenless atack and debuff");
                retry = 1;
            }
            else
            {
                Console.WriteLine("You really are stupid. I'll let you try again but I don't excpect you to be any smarter.");
            }

        }
        System.Console.Clear();
        eFighter = all.Next(1, 11);
        Console.WriteLine("Enemys turn!!");
        string secretBoss = Console.ReadLine();
        // Secret Bosses
        if (secretBoss == "Dream unmasked")
        {
            eFighterName = "Dream unmasked";
            Console.WriteLine($"Secret boss - {eFighterName}");   
            Console.WriteLine("instakills everyone bicuz ugly");
        }
        else if (secretBoss == "Keyboard Smash")
        {
            eFighterName = "Kyvhyihkyiccyihfycihkyhkviyhyujchxrgystrysdtrysxfyudtgdutcd gujnfyi6fyuxyrfgxrfyxygh";
            Console.WriteLine($"Secret boss - {eFighterName}");
        }
        else if (secretBoss == "Walmart Avengers")
        {
            eFighterName = "I.D.I.O.T.S";
            Console.WriteLine($"Secret boss - {eFighterName}"); 
        }
        else if (secretBoss == "Leonardo Dicaprio")
        {
            eFighterName = "Leonardo Dicaprio the guy who painted Mona Lisa";
            Console.WriteLine($"Secret boss - {eFighterName}"); 
        }
        else if (secretBoss == "I am ugly")
        {
            eFighterName = "Super sexy Ryan Reynolds";
            Console.WriteLine($"Secret boss - {eFighterName}");
        }
        else if (secretBoss == "Something inside me. It's, it's coming out. I feel like killing you. Let loose the anger, held back too long. My blood runs cold. Through my anatomy, dwells another being. Rooted in my cortex, a servant to its bidding. Brutality now becomes my appetite. Violence is now a way of life. The sledge's my tool to torture as it pounds down on your forehead eyes bulging from their sockets with every swing of my mallet I smash your fucking head in, until brains seep in through the cracks, blood does leak. Distorted beauty, catastroph. eSteaming slop, splattered all over me. Lifeless body, slouching dead. Lecherous abscess, where you once had a head. Avoiding the prophecy of my new found lust. You will never live again, soon your life will end. I'll see you die at my feet, eternally I smash your face. Facial bones collapse as I crack your skull in half. Crushing... cranial... contents. Draining the snot, I rip out the eyes squeezing them in my hands nerves are incised. Peeling the flesh off the bottom of my weapon. Involuntarily pulpifying facial regions. Suffer, and then you die. Torture, pulverized. At one with my sixth sense, I feel free to kill as I please, no one can stop me. Created to kill, the carnage continues. Violently reshaping human facial tissue. Brutality becomes my appetite. Violence is now a way of life. The sledge's my tool to torture as it pounds down on your forehead")
        {
            eFighterName = "Cannibal Corpse";
            Console.WriteLine($"Secret boss - {eFighterName}");
        }
        else if (secretBoss == "大张伟 阳光彩虹小白马 作词：大张伟 作曲：大张伟 怎么能哭呢 一切会好哒 一切都去吧 你就得想着 既然没办法 还恨他干嘛 还管它干嘛 心里要记得 你是内内个 内内 内个内个 内内 内内个 内内 内个内个 内内 阳光彩虹小白马 滴滴哒滴滴哒 我是内内个 内内 内个内个 内内 内内个 内内 内个内个 内内 阳光彩虹小白马 滴滴哒滴滴哒 滴滴哒滴哒 滴滴哒滴哒 滴滴哒滴滴哒 滴滴哒滴哒 滴滴哒滴哒 滴滴哒滴滴哒 嘿！ 你是 内内个 内内 内个内个 内内 内内个 内内 内个内个 内个内 内内个 内内 内个内个 内内 内内个 内内 内个内个 内个内 内内个 内内 内个内个 内内 内内个 内内 内个内个 内个内 内内个 内内 内个内个 内内 阳光彩虹小白马 你是最强哒 最棒哒 最亮哒 最发光哒 拦不住你发芽 你是最好哒 最俏哒 最妙哒 最骄傲哒 尽情的盛开吧 你就是 最强哒 最棒哒 最亮哒 最发光哒 心需要你哄它 你是最好哒 最俏哒 最妙哒 最骄傲哒 阳光彩虹小白马 生活是笑话 别哭着听它 别在意梗垮 不乐是你傻 心要你哄它 一切会好哒 一切都来吧 天地随你耍 更多更详尽歌词 在 ※ Mojim.com　魔镜歌词网 你是内内个 内内 内个内个 内内 内内个 内内 内个内个 内内 阳光彩虹小白马 滴滴哒滴滴哒 我是内内个 内内 内个内个 内内 内内个 内内 内个内个 内内 阳光彩虹小白马 滴滴哒滴滴哒 滴滴哒滴哒 滴滴哒滴哒 滴滴哒滴滴哒 滴滴哒滴哒 滴滴哒滴哒 滴滴哒滴滴哒 嘿！ 你是 内内个 内内 内个内个 内内 内内个 内内 内个内个 内个内 内内个 内内 内个内个 内内 内内个 内内 内个内个 内个内 内内个 内内 内个内个 内内 内内个 内内 内个内个 内个内 内内个 内内 内个内个 内内 阳光彩虹小白马 你是最强哒 最棒哒 最亮哒 最发光哒 拦不住你发芽 你是最好哒 最俏哒 最妙哒 最骄傲哒 尽情的盛开吧 你就是 最强哒 最棒哒 最亮哒 最发光哒 心需要你哄它 你是最好哒 最俏哒 最妙哒 最骄傲哒 阳光彩虹小白马 你是最强哒 最棒哒 最亮哒 最发光哒 拦不住你发芽 你是最好哒 最俏哒 最妙哒 最骄傲哒 尽情的盛开吧 你就是 最强哒 最棒哒 最亮哒 最发光哒 心需要你哄它 你是最好哒 最俏哒 最妙哒 最骄傲哒 阳光彩虹小白马 " || secretBoss == "Nae nigga nae nae nigga nigga nae nae")
        {
            eFighterName = "Wowkie 'racist' Zhang";
        }
        else if ( secretBoss == "The legends are true")
        {
            eFighterName = "The man, the myth, the legend MICKE(the real version)";
            Console.WriteLine(eFighterName);
            
        }
        else
        {

            if (eFighter == 1)
            {
                eFighterName = "Micke";
                Console.WriteLine(eFighterName);
                healthP2 = 10000;
                Console.WriteLine("Health: 10000");
                Console.WriteLine("Abilities: -75% debuffs effects and +40% buff effects. All damage increases with 10%. heals 1000 hp every turn.");
                
            }
            else if (eFighter == 2)
            {
                eFighterName = "God";
                Console.WriteLine(eFighterName);
                healthP2 = 2147483647;
                Console.WriteLine("Health: infinity");
                Console.WriteLine("Abilities: inf damage, inf protection of everithing, inf lives");
            }
            else if (eFighter == 3)
            {
                eFighterName = "Micke v2.0";
                Console.WriteLine(eFighterName);
                healthP2 = 20000;
                Console.WriteLine("Health: 20000");
                Console.WriteLine("Abilities: -150% debuffs effects and +80% buff effects. All damage increases with 20%. heals 2000 hp every turn.");
            }
            else if (eFighter == 4)
            {
                eFighterName = "Dj Octavio";
                Console.WriteLine(eFighterName);
                healthP2 = 50000;
                Console.WriteLine("Health: 50000");
                Console.WriteLine("Abilities: Starts  with Octobot Punches dealing 500 damage(can crit) and Bomb Rush dealing 2000 damage. Can give you hypnoshade debuff making you deal less damage and takoyaki debuff that is like pioson but 20 times stronger.");
            }
            else if (eFighter == 5)
            {
                eFighterName = "Williom";
                Console.WriteLine(eFighterName);
                healthP2 = 1000;
                Console.WriteLine("Health: 1000");
                Console.WriteLine("Abilities: Immune to stupidity debuff and knowledge buff. Higher chance for water gun weapons and chicken launcher. -10% buffs from foods but -25% debuffs from foods. Will always get at least one Fists. Can either deal max crit or no damage with ranged weapons");
            }
            else if (eFighter == 6)
            {
                eFighterName = "Crinch water boy";
                Console.WriteLine(eFighterName);
                healthP2 = 500;
                Console.WriteLine("Health: 500");
                Console.WriteLine("Abilities: just has many waterguns but everything does cringe damage. +100% cringe damage");
            }
            else if (eFighter == 7)
            {
                Console.WriteLine("You but stronk");
                Console.WriteLine("Health: ???");
                Console.WriteLine("Abilities: ???");
                Console.ReadLine();
                if (Fighter == "1")
                {
                    eFighterName = "Buffed Leanarth";
                    Console.WriteLine(eFighterName);
                    healthP2 = 5000;
                    Console.WriteLine("Health: 5000");
                    Console.WriteLine("Abilities: heals from dildo weapon attacks and immune to stupidity debuff. Better probability for good food.");
                }
                else if (Fighter == "2")
                {
                    eFighterName = "Buffed Williom";
                    Console.WriteLine(eFighterName);
                    healthP2 = 5000;
                    Console.WriteLine("Health: 5000");
                    Console.WriteLine("Abilities: Immune to stupidity debuff and knowledge buff. Higher chance for water gun weapons and chicken launcher. -50% buffs from foods but -125% debuffs from foods. Will always get at least 1 Fists. Deals x5 max crit or lowerst damage x5 with ranged weapons");
                }
                else if (Fighter == "3")
                {
                    eFighterName = "Buffed Axlel";
                    Console.WriteLine(eFighterName);
                    healthP2 = 10000;
                    Console.WriteLine("Health: 10000");
                    Console.WriteLine("Abilities: +125% damage buff with melee and automaticly starts with buffed beeg forehed. +50% chance for melee.");
                }
                else if (Fighter == "4")
                {
                    eFighterName = "Buffed Dhoni";
                    Console.WriteLine(eFighterName);
                    healthP2 = 5000;
                    Console.WriteLine("Health: 5000");
                    Console.WriteLine("Abilities: +2500% cringe damage. Immune to maidenless atack and debuff");
                }
            }
            else if (eFighter == 8)
            {
                eFighterName = "Leanarth";
                Console.WriteLine(eFighterName);
                healthP2 = 1000;
                Console.WriteLine("Health: 1000");
                Console.WriteLine("Abilities: heals from dildo weapon attacks and immune to stupidity debuff. Better probability for good food but is distracted by dance attacks and the nakee armor. Debuff effects +50%.");
            }
            else if (eFighter == 9)
            {
                eFighterName = "Axlel";
                Console.WriteLine(eFighterName);
                healthP2 = 2000;
                Console.WriteLine("Health: 2000");
                Console.WriteLine("Abilities: +25% damage buff with melee and automaticaly starts with beeg forehed. +10% chance for melee. Bigger chance for bad food.");
            }
            else if (eFighter == 10)
            {
                eFighterName = "Dhoni";
                Console.WriteLine(eFighterName);
                healthP2 = 10000;
                Console.WriteLine("Health: 1000");
                Console.WriteLine("Abilities: +500% cringe damage. Immune to maidenless atack and debuff");
            }
        }
        Console.ReadLine();
        System.Console.Clear();
        while (healthP1 > 0 && healthP2 > 0)
        {
            Console.WriteLine($"{Fighter} vs {eFighterName}");
            Console.ReadLine();
            Console.WriteLine($"What will {Fighter} do");
            Console.WriteLine("A:Attack B:Block(like a little B***ch) C:Other");
            Weakling = Console.ReadLine().ToLower();
            if (Weakling == "a")
            {
                Console.WriteLine($"{Fighter} gets ready to attack");
                Console.WriteLine($"What weapon does {Fighter} use");
                if (Fighter == "Williom")
                {
                    Inventory.Add("Fists");
                    Inventory.Add("Fists");
                    Inventory.Add("Fists");
                    Inventory.Add("Fists");
                    Inventory.Add("Fists");
                    if (Inventory.Contains("Aimbot Water Gun"))
                    {
                        Inventory.Add("Aimbot Water Gun");
                        Inventory.Add("Aimbot Water Gun");
                        Inventory.Add("Aimbot Water Gun");
                        Inventory.Add("Aimbot Water Gun");
                        Inventory.Add("Aimbot Water Gun");
                    }
                    if (Inventory.Contains("Big Bad Bonk"))
                    {
                        Inventory.Add("Big Bad Bonk");
                        Inventory.Add("Big Bad Bonk");
                        Inventory.Add("Big Bad Bonk");
                        Inventory.Add("Big Bad Bonk");
                        Inventory.Add("Big Bad Bonk");
                    }
                    if (Inventory.Contains("Homing Water Gun"))
                    {
                        Inventory.Add("Homing Water Gun");
                        Inventory.Add("Homing Water Gun");
                        Inventory.Add("Homing Water Gun");
                        Inventory.Add("Homing Water Gun");
                        Inventory.Add("Homing Water Gun");
                    }

                }
                int inventoryWeapons = all.Next(Inventory.Count);
                Console.WriteLine($"1. {Inventory[inventoryWeapons]}");
                int inventoryWeapons2 = all.Next(Inventory.Count);
                Console.WriteLine($"2. {Inventory[inventoryWeapons2]}");
                int inventoryWeapons3 = all.Next(Inventory.Count);
                Console.WriteLine($"3. {Inventory[inventoryWeapons3]}");
                Weapon = Console.ReadLine().ToLower();
                if (Weapon == "1")
                {
                    Console.WriteLine($"{Fighter} uses {Inventory[inventoryWeapons]!}");
                }
                else if (Weapon == "2")
                {
                    Console.WriteLine($"{Fighter} uses {Inventory[inventoryWeapons2]!}");
                }
                else if (Weapon == "3")
                {
                    Console.WriteLine($"{Fighter} uses {Inventory[inventoryWeapons3]!}");
                }
                //kommer efter motståndarens runda
                if (Weapon == "1")
                {
                    if (Inventory[inventoryWeapons] != "Fists")
                    {
                        Console.WriteLine($"{Inventory[inventoryWeapons]} has been used.");
                        Inventory.RemoveAt(inventoryWeapons);
                    }
                }
                else if (Weapon == "2")
                {
                    if (Inventory[inventoryWeapons2] != "Fists")
                    {
                        Console.WriteLine($"{Inventory[inventoryWeapons2]} has been used.");
                        Inventory.RemoveAt(inventoryWeapons2);
                    }
                }
                else if (Weapon == "3")
                {
                    if (Inventory[inventoryWeapons3] != "Fists")
                    {
                        Console.WriteLine($"{Inventory[inventoryWeapons3]} has been used.");
                        Inventory.RemoveAt(inventoryWeapons3);
                    }
                }
            }
            else if (Weakling == "b")
            {

            }
            else if (Weakling == "c")
            {

            }
            else
            {

            }

        }
            
    }
    // If lore
    else if (mode == "c")
    {
        Console.WriteLine("You are a member of the crinch legion and a war has broken out between everyone so now you must kill each other for some reason.");
    }
    //someone won
    Console.WriteLine("Start over?(yes/no)");
    retry = 0;
    yes = Console.ReadLine().ToLower();
    System.Console.Clear();
}
//Leonard är crinch
//Williom är fett crinch och typ inte slakta(slay)
//Crinch gang!!!!
//Drunken Fella has big forehead and big pp