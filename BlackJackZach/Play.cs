using CardStuff;
using System.Numerics;

namespace BlackJackZach
{
    internal class Play
    {
        static void Main(string[] args)
        {
            Console.Title = "Blackjack Attack";
            Console.WriteLine("Welcome to Blackjack!\n");
            Random rand = new Random();

            bool gameExit = false;
            int playerWins = 0;
            do
            {
                bool roundExit = false;
                do
                {
                    Console.WriteLine($"Player wins: {playerWins}");
                    bool playerTurn = true;
                    bool dealerTurn = false;
                    Deck deck = new Deck();
                    deck.ShuffleDeck();


                    Player player = new Player(deck.GetCard(), deck.GetCard());
                    Dealer dealer = new Dealer(deck.GetCard(), deck.GetCard());
                    Console.WriteLine($"\nPlayer Hand:\n{player.Hand}");


                    Console.WriteLine($"Dealer Hand:\n{dealer.Hand.Card1} XXXXXXXXXX");
                    do
                    {
                        if (player.Hand.GetValue() == 21)
                        {
                            Console.WriteLine("Blackjack!");
                            roundExit = true;
                            playerTurn = false;
                            playerWins++;
                        }
                        else if (player.Hand.GetValue() > 21)
                        {
                            Console.WriteLine("Player Busts!");
                            playerTurn = false;
                            continue;
                        }
                        else if (player.Hand.GetValue() < 21)
                        {
                            Console.WriteLine($"\nPlayer hand value: {player.Hand.GetValue()}");
                            Console.WriteLine("What would you like to do?\n1) Hit\n2) Stand\nE) Quit");
                            switch (Console.ReadKey(true).Key)
                            {
                                case ConsoleKey.D1:
                                    Card newCard = deck.GetCard();
                                    player.Hand.Cards.Add(newCard);
                                    Console.WriteLine(newCard);
                                    break;

                                case ConsoleKey.D2:
                                    playerTurn = false;
                                    dealerTurn = true;
                                    break;

                                case ConsoleKey.E:
                                default:
                                    roundExit = true;
                                    playerTurn = false;
                                    break;

                            }
                        } 
                    } while (playerTurn);
                    if (dealer.Hand.GetValue() == 21)
                    {
                        Console.WriteLine("Dealer BlackJack!");
                            
                        roundExit = true;
                    }
                    if (!playerTurn && dealerTurn)
                    {
                        do
                        {
                            if (dealer.Hand.GetValue() < 17)
                            {
                                Console.WriteLine("Dealer hits...");
                                dealer.Hand.Cards.Add(deck.GetCard());
                            }
                            else if (dealer.Hand.GetValue() > 21)
                            {
                                Console.WriteLine("Dealer Busts");
                                playerWins++;
                                roundExit = true;
                                playerTurn = true;
                            }
                            else if (dealer.Hand.GetValue() >= 17)
                            {
                                Console.WriteLine("Dealer stands...");
                                playerTurn = true;
                            }
                        } while (!playerTurn);
                    }                         
                    if (player.Hand.GetValue() > dealer.Hand.GetValue())
                    {
                        Console.WriteLine($"Player hand wins with {player.Hand.GetValue()} against dealer hand of {dealer.Hand.GetValue()}");
                    }
                    else if (player.Hand.GetValue() < dealer.Hand.GetValue())
                    {
                        Console.WriteLine($"Player hand loses with {player.Hand.GetValue()} against dealer hand of {dealer.Hand.GetValue()}");
                    }
                    Console.WriteLine("Play again? Y/N");
                    switch (Console.ReadKey().Key)
                    {
                        case ConsoleKey.Y:
                            Console.Clear();
                            roundExit = true;
                            break;
                        case ConsoleKey.N:
                        default:
                            gameExit = true;
                            break;
                    }
                } while (!roundExit && !gameExit);
            } while (!gameExit);





        }


        //Player action
        static void PlayerMove()
        {
            //hit
            //stand
        }
        //Dealer action

        static void CheckHands(Hand player, Hand dealer)
        {
            if (player.GetValue() > 21 && (player.Card1.GetFace() != "A" && player.Card2.GetFace() != "A"))
            {
                //Bust
            }
            else if (player.Card1.GetFace() != "A" || player.Card2.GetFace() != "A")
            {
                //Ace = 10 or 1?
            }
            if (player.GetValue() == 21)
            {
                //Blackjack
            }
            if (player.GetValue() < dealer.GetValue() && dealer.GetValue() !> 21)
            {
                //dealer wins
            }
        }//end nothing

        public static void PlayRound(Player player, Dealer dealer)
        {
            Console.WriteLine($"Current hand value: {player.Hand.GetValue()}");
            Console.WriteLine("What would you like to do?\n1) Hit\n2) Stand\nE) Quit");

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    
                    break;

                case ConsoleKey.D2:
                    break;

                case ConsoleKey.E:
                default:
                    break;

            }


        }



//        public void BlackJackRound()
//        {
//            //dealer deals hands
//            //dealer reveals hand

//            if (player.Surrender == true)
//            {
//                playerSurrender//end round
//            }//if surrender

//            else if (player.HandValue() > 21)
//            {
//                Bust//end the round
//            }//end player bust

//            while (dealer.HandValue() <= 16)
//            {
//                Thread.Sleep(300);
//                dealer.ShowCards.Add(deck.GetCard());


//            }//end dealer hit logic

//            if (player.HandValue() > dealer.HandValue())
//            {
//                player.Wins;
//                if (player.hand == BlackJack //Some kind of BlackJack is true method, isBlackJack(player.Hand)?)
//                {
//                    BlackJack //end round
//                }//blackJack
//                else
//                {
//                    playerWin//end round
//                }//win

//            }//end player win if()

//            else if (dealer.HandValue() > 21)
//            {
//                player.Win;//end round
//            }//end dealer bust

//            else if (dealer.HandValue() > player.HandValue())
//            {
//                dealerWin//endround
//            }//end dealer win
//            else
//            {
//                push ?//draw end round
//            }//end draw

//            if (player.HandValue() > 21)
//            {
//                foreach (var card in player.Hand)
//                {
//                    if (card.Value == 11)
//                    {
//                        card.Value = 1;
//                    }
//                }
//            }//turn 11 ace into a 1 logic?

//        }//end BlackJackRound()
    }
}