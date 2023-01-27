using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics; 
namespace Text_Adventure_Final
{
    public partial class Form1 : Form
    {
        Random randomGen = new Random();
        int page = 1;
        double fruitChance = 0;
        Stopwatch decisonTimer = new Stopwatch();
        public Form1()
        {
            InitializeComponent();
            NarratorLabel.Text = $" You are walking throught the jungle with your friends when you relize you have gotten seperated and lost which way will you go?";
            Option1.Text = $" Go North";
            Option2.Text = $" Go South";
            decisonTimer.Start();
        }

        private void Option1_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                if (decisonTimer.ElapsedMilliseconds > 4000)
                {
                    page = 100;
                }
                else 
                {
                    page = 2;
                }
                decisonTimer.Reset();
                decisonTimer.Start();
            }
            else if (page == 2)
            {
                if (decisonTimer.ElapsedMilliseconds > 4000)
                {
                    page = 100;
                }
                else
                {
                    page = 4;
                }
                decisonTimer.Reset();
                decisonTimer.Start();
            }
            else if (page == 4)
            {
                if (decisonTimer.ElapsedMilliseconds > 7000)
                {
                    page = 100;
                }
                else
                {
                    page = 1;
                }
                decisonTimer.Reset();
                decisonTimer.Start();
            }
            else if (page == 3)
            {
                if (decisonTimer.ElapsedMilliseconds > 7000)
                {
                    page = 100;
                }
                else
                {
                    page = 1;
                }
                decisonTimer.Reset();
                decisonTimer.Start();
            }
            else if (page == 5)
            {
                if (decisonTimer.ElapsedMilliseconds > 7000)
                {
                    page = 100;
                }
                else
                {
                    page = 6;
                }
                decisonTimer.Reset();
                decisonTimer.Start();
            }
            else if (page == 6)
            {
                if (decisonTimer.ElapsedMilliseconds > 7000)
                {
                    page = 100;
                }
                else
                {
                    page = 1;
                }
                decisonTimer.Reset();
                decisonTimer.Start();
            }
            else if (page == 7)
            {
                if (decisonTimer.ElapsedMilliseconds > 7000)
                {
                    page = 100;
                }
                else
                {
                    page = 8;
                }
                decisonTimer.Reset();
                decisonTimer.Start();
            }
            else if (page == 9)
            {
                if (decisonTimer.ElapsedMilliseconds > 7000)
                {
                    page = 100;
                }
                else
                {
                    page = 1;
                }
                decisonTimer.Reset();
                decisonTimer.Start();
            }
            else if (page == 8)
            {
                if (decisonTimer.ElapsedMilliseconds > 7000)
                {
                    page = 100;
                }
                else
                {
                    page = 10;
                }
                decisonTimer.Reset();
                decisonTimer.Start(); ;
            }
            else if (page == 10)
            {
                if (decisonTimer.ElapsedMilliseconds > 7000)
                {
                    page = 100;
                }
                else
                {
                    page = 11;
                }
                decisonTimer.Reset();
                decisonTimer.Start();
            }
            else if (page == 12)
            {
                if (decisonTimer.ElapsedMilliseconds > 7000)
                {
                    page = 100;
                }
                else
                {
                    page = 1;
                }
                decisonTimer.Reset();
                decisonTimer.Start();
            }
            else if (page == 11)
            {
                if (decisonTimer.ElapsedMilliseconds > 7000)
                {
                    page = 100;
                }
                else
                {
                    page = 13;
                }
                decisonTimer.Reset();
                decisonTimer.Start();
            }
            else if (page == 13)
            {
                if (decisonTimer.ElapsedMilliseconds > 7000)
                {
                    page = 100;
                }
                else
                {
                    page = 1;
                }
                decisonTimer.Reset();
                decisonTimer.Start();
            }
            else if (page == 14)
            {
                if (decisonTimer.ElapsedMilliseconds > 7000)
                {
                    page = 100;
                }
                else
                {
                    page = 15;
                }
                decisonTimer.Reset();
                decisonTimer.Start();
            }
            else if (page == 16)
            {
                if (decisonTimer.ElapsedMilliseconds > 7000)
                {
                    page = 100;
                }
                else
                {
                    page = 1;
                }
                decisonTimer.Reset();
                decisonTimer.Start();
            }
            else if (page == 15)
            {

                if (decisonTimer.ElapsedMilliseconds > 7000)
                {
                    page = 100;
                }
                else
                {
                    fruitChance = randomGen.Next(1, 2);
                    if (fruitChance == 1)
                    {
                        page = 17;
                    }
                    else
                    {
                        page = 404;
                    }
                }
                decisonTimer.Reset();
                decisonTimer.Start();

                
            }
            else if (page == 17)
            {
                if (decisonTimer.ElapsedMilliseconds > 7000)
                {
                    page = 100;
                }
                else
                {
                    page = 1;
                }
                decisonTimer.Reset();
                decisonTimer.Start();
            }
            else if (page == 18)
            {
                if (decisonTimer.ElapsedMilliseconds > 7000)
                {
                    page = 100;
                }
                else
                {
                    page = 19;
                }
                decisonTimer.Reset();
                decisonTimer.Start();
            }
            else if (page == 19)
            {
                if (decisonTimer.ElapsedMilliseconds > 7000)
                {
                    page = 100;
                }
                else
                {
                    page = 1;
                }
                decisonTimer.Reset();
                decisonTimer.Start();
            }
            else if (page == 20)
            {
                if (decisonTimer.ElapsedMilliseconds > 7000)
                {
                    page = 100;
                }
                else
                {
                    page = 1;
                }
                decisonTimer.Reset();
                decisonTimer.Start();
            }
            else if (page == 21)
            {
                if (decisonTimer.ElapsedMilliseconds > 7000)
                {
                    page = 100;
                }
                else
                {
                    page = 1;
                }
                decisonTimer.Reset();
                decisonTimer.Start();
            }
            else if (page == 100)
            {
                if (decisonTimer.ElapsedMilliseconds > 7000)
                {
                    page = 100;
                }
                else
                {
                    page = 1;
                }
                decisonTimer.Reset();
                decisonTimer.Start();
            }
            

            switch (page)
            {
                

                case 1:
                    NarratorLabel.Text = "You are lost in the jungle which way will you go?";
                    Option1.Text = "North";
                    Option2.Text = "South";
                    decisonTimer.Start();

                    break;
                case 2:
                    NarratorLabel.Text = "You come to a fast moving water channel and you see something in the water. Do you check it out?";
                    Option1.Text = "Yes"; 
                    Option2.Text = "No";
                    break;
                case 3: NarratorLabel.Text = "You trip and die :( Wanna play again?";
                    Option1.Text = "Yes";
                        Option2.Text = "No"; 
                        break;
                case 4:
                    NarratorLabel.Text = "An alligator jumps out of the water and kills you. \r\nplay again?\r\n"; 
                        Option1.Text = "Yes";
                    Option2.Text = "No";
                        break;
                case 5:
                    NarratorLabel.Text = "its turning night do you keep heading along the river or do you climb a tree and sleep";
                    Option1.Text = "Climb the tree";
                      Option2.Text = "Keep on moving"; 
                        break;
                case 6:
                    NarratorLabel.Text = "You fall asleep and wake up to an andaconda constricting you and you die. Play Again?";
                    Option1.Text = "Yes";
                    Option2.Text = "No"; 
                        break;
                case 7:
                    NarratorLabel.Text = "You see some people in the distance do you approach?";
                    Option1.Text = "Yes";
                    Option2.Text = "No";
                       break;
                case 8:
                    NarratorLabel.Text = "They are friendly but don't speak english, they seem to be natives, they give u a machete and food and water";
                    Option1.Text = "Continue?";
                    Option2.Text = "Continue?"; 
                    break;
                case 9:
                    NarratorLabel.Text = "As you flee you trip and fall and die. Play again?";
                    Option1.Text = "Yes";
                    Option2.Text = "No"; 
                    break;
                case 10:
                    NarratorLabel.Text = "As you walk through the jungle you encounter a black bear do u run or try and intimidate it";
                    Option1.Text = "Intimidate The Bear";
                    Option2.Text = "RUN";
                    break;
                case 11:
                    NarratorLabel.Text = "The black bear runs away\r\ndo you want to chase it?";
                    Option1.Text = "Chase it";
                    Option2.Text = "Don't Chase it"; 
                        break;
                case 12:
                    NarratorLabel.Text = "The black bear sees you as prey and chases u down and mauls u to death. Play again?";
                    Option1.Text = "Yes";
                    Option2.Text = "No"; 
                        break;
                case 13:
                    NarratorLabel.Text = "You chase it to its cave where it kills you because its cubs are near by. PLay Again?";
                    Option1.Text = "Yes";
                    Option2.Text = "No"; 
                    break;
                case 14:
                    NarratorLabel.Text = "You run the other direction and on the way find some fruit to eat";
                    Option1.Text = "Eat the fruit";
                    Option2.Text = " Don't eat the fruit"; 
                  break;
                case 15:
                    NarratorLabel.Text = "Oh you survived that um... you continue to move through the jungle when you find a flare gun you see a boat do u fire your flare?";
                    Option1.Text = "Fire the flare";
                    Option2.Text = "Don't Fire the flare";
                    break;
                case 16:
                    NarratorLabel.Text = "You starve. Play again?";
                    Option1.Text = "Yes";
                    Option2.Text = "No"; 
                   break;
                case 17:
                    NarratorLabel.Text = "The boat comes and you live happy ever after:) Play Again? ";
                    Option1.Text = "Yes";
                    Option2.Text = "No"; 
                break;
                case 18:
                    NarratorLabel.Text = "You watch as the boat passes and sit there relizing you made the wrong decision. But you see another boat!!! Fire the flare again"; ;
                    Option1.Text = "Yes";
                    Option2.Text = "No"; 
                    break;
                case 19:
                    NarratorLabel.Text = "They choose to ignore it and while stomping away trip over an anaconda and fall into the crocs mouth. Play Again :)";
                    Option1.Text = "Yes";
                    Option2.Text = "No"; 
                       break;
                case 20:
                    NarratorLabel.Text = "They choose to ignore it and while stomping away trip over a root and fall into water and drown. Play again?";
                    Option1.Text = "Yes";
                    Option2.Text = "No";
                       break;
                case 21:
                    NarratorLabel.Text = "You live happy ever after with the natives:) Play again?";
                    Option1.Text = "Yes";
                    Option2.Text = "No"; 
                     break;
                case 404:
                    NarratorLabel.Text = "You died to the fruit:/ Play Again?";
                    Option1.Text = "Yes";
                    Option2.Text = "No";
                    break;

                case 99:
                    NarratorLabel.Text = "Thank you for playing!";
                    Option1.Text = "";
                    Option2.Text = "";
                    break;
                case 100:
                    NarratorLabel.Text = "You took too long and have died. Play again?";
                    Option1.Text = "Yes";
                    Option2.Text = "No";
                    break; 

                default:
                    break;
            }

        }

        private void Option2_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                if (decisonTimer.ElapsedMilliseconds > 7000)
                {
                    page = 100;
                }
                else
                {
                    page = 3;
                }
                decisonTimer.Reset();
                decisonTimer.Start();
            }
            else if (page == 4)
            {
                page = 99;
            } 

            else if (page == 3)
            {
                if (decisonTimer.ElapsedMilliseconds > 7000)
                {
                    page = 100;
                }
                else
                {
                    page = 99;
                }
                decisonTimer.Reset();
                decisonTimer.Start(); ;
            }
            else if (page == 2)
            {
                if (decisonTimer.ElapsedMilliseconds > 7000)
                {
                    page = 100;
                }
                else
                {
                    page = 5;
                }
                decisonTimer.Reset();
                decisonTimer.Start();
            }
            else if (page == 6)
            {
                if (decisonTimer.ElapsedMilliseconds > 7000)
                {
                    page = 100;
                }
                else
                {
                    page = 99;
                }
                decisonTimer.Reset();
                decisonTimer.Start();
            }
            else if (page == 5)
            {
                if (decisonTimer.ElapsedMilliseconds > 7000)
                {
                    page = 100;
                }
                else
                {
                    page = 7;
                }
                decisonTimer.Reset();
                decisonTimer.Start();
            }
            else if (page == 7)
            {
                if (decisonTimer.ElapsedMilliseconds > 7000)
                {
                    page = 100;
                }
                else
                {
                    page = 9;
                }
                decisonTimer.Reset();
                decisonTimer.Start();
            }
            else if (page == 9)
            {
                if (decisonTimer.ElapsedMilliseconds > 7000)
                {
                    page = 100;
                }
                else
                {
                    page = 99;
                }
                decisonTimer.Reset();
                decisonTimer.Start();
            }
            else if (page == 8)
            {
                if (decisonTimer.ElapsedMilliseconds > 7000)
                {
                    page = 100;
                }
                else
                {
                    page = 10;
                }
                decisonTimer.Reset();
                decisonTimer.Start();
            }
            else if (page == 10)
            {
                if (decisonTimer.ElapsedMilliseconds > 7000)
                {
                    page = 100;
                }
                else
                {
                    page = 12;
                }
                decisonTimer.Reset();
                decisonTimer.Start();
            }
            else if (page == 12)
            {
                if (decisonTimer.ElapsedMilliseconds > 7000)
                {
                    page = 100;
                }
                else
                {
                    page = 99;
                }
                decisonTimer.Reset();
                decisonTimer.Start();
            }
            else if (page == 11)
            {
                if (decisonTimer.ElapsedMilliseconds > 7000)
                {
                    page = 100;
                }
                else
                {
                    page = 14;
                }
                decisonTimer.Reset();
                decisonTimer.Start();
            }
            else if (page == 14)
            {
                if (decisonTimer.ElapsedMilliseconds > 7000)
                {
                    page = 100;
                }
                else
                {
                    page = 16;
                }
                decisonTimer.Reset();
                decisonTimer.Start();
            }
            else if (page == 15)
            {
                if (decisonTimer.ElapsedMilliseconds > 7000)
                {
                    page = 100;
                }
                else
                {
                    page = 18;
                }
                decisonTimer.Reset();
                decisonTimer.Start();
            }
            else if (page == 16)
            {
                if (decisonTimer.ElapsedMilliseconds > 7000)
                {
                    page = 100;
                }
                else
                {
                    page = 99;
                }
                decisonTimer.Reset();
                decisonTimer.Start();
            }
            else if (page == 17)
            {
                if (decisonTimer.ElapsedMilliseconds > 7000)
                {
                    page = 100;
                }
                else
                {
                    page = 19;
                }
                decisonTimer.Reset();
                decisonTimer.Start();
            }
            else if (page == 19)
            {
                if (decisonTimer.ElapsedMilliseconds > 7000)
                {
                    page = 100;
                }
                else
                {
                    page = 21;
                }
                decisonTimer.Reset();
                decisonTimer.Start();
            }
            else if (page == 18)
            {
                if (decisonTimer.ElapsedMilliseconds > 7000)
                {
                    page = 100;
                }
                else
                {
                    page = 21;
                }
                decisonTimer.Reset();
                decisonTimer.Start();
            }
            else if (page == 20)
            {
                if (decisonTimer.ElapsedMilliseconds > 7000)
                {
                    page = 100;
                }
                else
                {
                    page = 99;
                }
                decisonTimer.Reset();
                decisonTimer.Start();
            }
            else if (page == 21)
            {
                if (decisonTimer.ElapsedMilliseconds > 7000)
                {
                    page = 100;
                }
                else
                {
                    page = 99;
                }
                decisonTimer.Stop();
                decisonTimer.Reset();
            }
            else if (page == 100)
            {
                if (decisonTimer.ElapsedMilliseconds > 7000)
                {
                    page = 100;
                }
                else
                {
                    page = 1;
                }
                decisonTimer.Reset();
                decisonTimer.Start();

            }

            switch (page)
            {

                case 1:
                    NarratorLabel.Text = "You are lost in the jungle which way will you go?";
                    Option1.Text = "North";
                    Option2.Text = "South";
                    break;
                case 2:
                    NarratorLabel.Text = "You come to a fast moving water channel and you see something in the water. Do you check it out?";
                    Option1.Text = "Yes";
                    Option2.Text = "No";
                    break;
                case 3:
                    NarratorLabel.Text = "You trip and die :( Wanna play again?";
                    Option1.Text = "Yes";
                    Option2.Text = "No";
                    break;
                case 4:
                    NarratorLabel.Text = "An alligator jumps out of the water and kills you. \r\nplay again?\r\n";
                    Option1.Text = "Yes";
                    Option2.Text = "No";
                    break;
                case 5:
                    NarratorLabel.Text = "its turning night do you keep heading along the river or do you climb a tree and sleep";
                    Option1.Text = "Climb the tree";
                    Option2.Text = "Keep on moving";
                    break;
                case 6:
                    NarratorLabel.Text = "You fall asleep and wake up to an andaconda constricting you and you die. Play Again?";
                    Option1.Text = "Yes";
                    Option2.Text = "No";
                    break;
                case 7:
                    NarratorLabel.Text = "You see some people in the distance do you approach?";
                    Option1.Text = "Yes";
                    Option2.Text = "No";
                    break;
                case 8:
                    NarratorLabel.Text = "They are friendly but don't speak english, they seem to be natives, they give u a machete and food and water";
                    Option1.Text = "Continue?";
                    Option2.Text = "Continue?";
                    break;
                case 9:
                    NarratorLabel.Text = "As you flee you trip and fall and die. Play again?";
                    Option1.Text = "Yes";
                    Option2.Text = "No";
                    break;
                case 10:
                    NarratorLabel.Text = "As you walk through the jungle you encounter a black bear do u run or try and intimidate it";
                    Option1.Text = "Intimidate The Bear";
                    Option2.Text = "RUN";
                    break;
                case 11:
                    NarratorLabel.Text = "The black bear runs away\r\ndo you want to chase it?";
                    Option1.Text = "Chase it";
                    Option2.Text = "Don't Chase it";
                    break;
                case 12:
                    NarratorLabel.Text = "The black bear sees you as prey and chases u down and mauls u to death. Play again?";
                    Option1.Text = "Yes";
                    Option2.Text = "No";
                    break;
                case 13:
                    NarratorLabel.Text = "You chase it to its cave where it kills you because its cubs are near by. PLay Again?";
                    Option1.Text = "Yes";
                    Option2.Text = "No";
                    break;
                case 14:
                    NarratorLabel.Text = "You run the other direction and on the way find some fruit to eat";
                    Option1.Text = "Eat the fruit";
                    Option2.Text = " Don't eat the fruit";
                    break;
                case 15:
                    NarratorLabel.Text = "Oh you survived that um... you continue to move through the jungle when you find a flare gun you see a boat do u fire your flare?";
                    Option1.Text = "Fire the flare";
                    Option2.Text = "Don't Fire the flare";
                    break;
                case 16:
                    NarratorLabel.Text = "You starve. Play again?";
                    Option1.Text = "Yes";
                    Option2.Text = "No";
                    break;
                case 17:
                    NarratorLabel.Text = "The boat comes and you live happy ever after:) Play Again? ";
                    Option1.Text = "Yes";
                    Option2.Text = "No";
                    break;
                case 18:
                    NarratorLabel.Text = "You watch as the boat passes and sit there relizing you made the wrong decision. But you see another boat!!! Fire the flare again"; ;
                    Option1.Text = "Yes";
                    Option2.Text = "No";
                    break;
                case 19:
                    NarratorLabel.Text = "They choose to ignore it and while stomping away trip over an anaconda and fall into the crocs mouth. Play Again :)";
                    Option1.Text = "Yes";
                    Option2.Text = "No";
                    break;
                case 20:
                    NarratorLabel.Text = "They choose to ignore it and while stomping away trip over a root and fall into water and drown. Play again?";
                    Option1.Text = "Yes";
                    Option2.Text = "No";
                    break;
                case 21:
                    NarratorLabel.Text = "You live happy ever after with the natives:) Play again?";
                    Option1.Text = "Yes";
                    Option2.Text = "No";
                    break;
                case 404:
                    NarratorLabel.Text = "You died to the fruit:/ Play Again?";
                    Option1.Text = "Yes";
                    Option2.Text = "No";
                    break;

                case 99:
                    NarratorLabel.Text = "Thank you for playing!";
                    Option1.Text = "";
                    Option2.Text = "";
                    Thread.Sleep(1000);
                    Application.Exit();
                    break;

                case 100:
                    NarratorLabel.Text = "You took too long and have died. Play again?";
                    Option1.Text = "Yes";
                    Option2.Text = "No";
                    break;


                  
                   
                default:
                    break;
            }

        }

        private void timerLable_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerLable.Text = decisonTimer.Elapsed.ToString(@"s\:");
        }
    }
}
