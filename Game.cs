//Dhruv Patel  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project2Final
{
    class Game
    {
        private string secret;
        private int maxTrial;
        private int score;

        public Game()
        {
            // Assign a four letter English word to secret
            string text = "cashcastcellchatchipcityclubcoalcoatcodecoldcomecookcoolcopecopycostcrewcropdarkdatadatedawndaysdeaddealdeandeardebtdeepdenydeskdialdickdietdiscdiskdoesdonedoordosedowndrawdrewdropdrugdualdukedustdutyeachearneaseeasteasyedgeelseeveneverevilexitfacefactfailfairfallfarmfastfatefearfeedfeelfeetfellfeltfilefillfilmfindfinefirefirmfishfiveflatflowfoodfootfordformfortfourfreefromfuelfullfundgaingamegategavegeargenegiftgirlgivegladgoalgoesgoldGolfgonegoodgraygrewgreygrowgulfhairhalfhallhandhanghardharmhatehaveheadhearheatheldhellhelphereherohighhillhireholdholeholyhomehopehosthourhugehunghunthurtideainchintoironitemjackjanejeanjohnjoinjumpjuryjustkeenkeepkentkeptkickkillkindkingkneeknewknowlackladylaidlakelandlanelastlateleadleftlesslifeliftlikelinelinklistliveloadloanlocklogolonglooklordloselosslostloveluckmademailmainmakemalemanyMarkmassmattmealmeanmeatmeetmenumeremikemilemilkmillmindminemissmodemoodmoonmoremostmovemuchmustnamenavynearneckneednewsnextnicenickninenonenosenoteokayonceonlyontoopenoraloverpacepackpagepaidpainpairpalmparkpartpasspastpathpeakpickpinkpipeplanplayplotplugpluspollpoolpoorportpostpullpurepushracerailrainrankrareratereadrealrearrelyrentrestricerichrideringriseriskroadrockrolerollroofroomrootroserulerushruthsafesaidsakesalesaltsamesandsaveseatseedseekseemseenselfsellsendsentseptshipshopshotshowshutsicksidesignsitesizeskinslipslowsnowsoftsoilsoldsolesomesongsoonsortsoulspotstarstaystepstopsuchsuitsuretaketaletalktalltanktapetaskteamtechtelltendtermtesttextthanthatthemthentheythinthisthustilltimetinytoldtolltonetonytooktooltourtowntreetriptruetuneturntwintypeunituponuseduservaryvastveryviceviewvotewagewaitwakewalkwallwantwardwarmwashwavewaysweakwearweekwellwentwerewestwhatwhenwhomwidewifewildwillwindwinewingwirewisewishwithwoodwordworeworkyardyeahyearyourzerozone";
            Random rand = new Random();
            int index = rand.Next(0, text.Length / 4) * 4;
            secret = text.Substring(index, 4); ;

            // Initialize maxTrial and score
            maxTrial = 10;
            score = 0;
        }


        public void Play()
        {
            //variables
            string input;
            string letter;
            int freq = 0;
            
            bool success;
            char letterInput;
            
            Console.WriteLine("Game begin. Type 'terminate' to quit.");
            //Main do-while loop.
            do
            {
                Console.WriteLine("Enter a four letter word. Number of trials left: {0}", maxTrial);
                input = Console.ReadLine();
                //if statement for when input is incorrect and not "terminate".
                if (input != secret && input != "terminate")
                {
                    //do-while loop for the letter hints.
                    do
                    {
                        Console.WriteLine("Wrong guess. Give me a character and I will tell you how many times " +
                       "this character appears in the secret word");
                        letter = Console.ReadLine();
                        success = char.TryParse(letter, out letterInput);
                        char.ToLower(letterInput);
                        
                    } while (!success && letter != "terminate");
                    //if statement to end the loops and display the final message if letter = "terminate".
                    if (letter == "terminate")
                    {
                        
                        break;
                    }
                    //foreach loop to check how many times a letter appears in the secret word.
                    foreach (char c in secret)
                    {
                        if (c == letterInput)
                        {
                            freq++;
                        }
                        
                    }
                    Console.WriteLine("The letter {0} appears in the word {1} times", letterInput, freq);
                    freq = 0;

                }
                maxTrial--;
            } while (input != secret && maxTrial>0 && input!= "terminate");
            //if-else if statement for if the four letter word input is equal to secret or if it is "terminate".
            if (input == secret)
            {
                Console.WriteLine("You win!");
                Console.WriteLine("Your score is {0}", maxTrial);
            }
            else if (input == "terminate")
            {
                Console.WriteLine("You quit. You lose. The secret is {0}", secret);
                Console.WriteLine("Your score is 0");
            }
            else
            {
                Console.WriteLine("You lose. The word is {0}", secret);
                Console.WriteLine("Your score is 0.");
            }
               
            
        }

        public void textAppear()
        {
            string text = "cashcastcellchatchipcityclubcoalcoatcodecoldcomecookcoolcopecopycostcrewcropdarkdatadatedawndaysdeaddealdeandeardebtdeepdenydeskdialdickdietdiscdiskdoesdonedoordosedowndrawdrewdropdrugdualdukedustdutyeachearneaseeasteasyedgeelseeveneverevilexitfacefactfailfairfallfarmfastfatefearfeedfeelfeetfellfeltfilefillfilmfindfinefirefirmfishfiveflatflowfoodfootfordformfortfourfreefromfuelfullfundgaingamegategavegeargenegiftgirlgivegladgoalgoesgoldGolfgonegoodgraygrewgreygrowgulfhairhalfhallhandhanghardharmhatehaveheadhearheatheldhellhelphereherohighhillhireholdholeholyhomehopehosthourhugehunghunthurtideainchintoironitemjackjanejeanjohnjoinjumpjuryjustkeenkeepkentkeptkickkillkindkingkneeknewknowlackladylaidlakelandlanelastlateleadleftlesslifeliftlikelinelinklistliveloadloanlocklogolonglooklordloselosslostloveluckmademailmainmakemalemanyMarkmassmattmealmeanmeatmeetmenumeremikemilemilkmillmindminemissmodemoodmoonmoremostmovemuchmustnamenavynearneckneednewsnextnicenickninenonenosenoteokayonceonlyontoopenoraloverpacepackpagepaidpainpairpalmparkpartpasspastpathpeakpickpinkpipeplanplayplotplugpluspollpoolpoorportpostpullpurepushracerailrainrankrareratereadrealrearrelyrentrestricerichrideringriseriskroadrockrolerollroofroomrootroserulerushruthsafesaidsakesalesaltsamesandsaveseatseedseekseemseenselfsellsendsentseptshipshopshotshowshutsicksidesignsitesizeskinslipslowsnowsoftsoilsoldsolesomesongsoonsortsoulspotstarstaystepstopsuchsuitsuretaketaletalktalltanktapetaskteamtechtelltendtermtesttextthanthatthemthentheythinthisthustilltimetinytoldtolltonetonytooktooltourtowntreetriptruetuneturntwintypeunituponuseduservaryvastveryviceviewvotewagewaitwakewalkwallwantwardwarmwashwavewaysweakwearweekwellwentwerewestwhatwhenwhomwidewifewildwillwindwinewingwirewisewishwithwoodwordworeworkyardyeahyearyourzerozone";
            

            char[] containedCharacters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't',
                'u', 'v', 'w', 'x', 'y', 'z' };

            foreach (char letter in containedCharacters)
            {
                Console.WriteLine($"{letter} appear {text.Count(textLetter => textLetter == letter)} times");
            }
        }
    }
}
