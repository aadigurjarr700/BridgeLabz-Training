using System;
class SnakesLadderGame
{
    static int[] playerPositions = new int[4];
    static string[] playerNames = new string[4];
    static int playerCount;
    static Random random = new Random();
	//board 
    static int[] board = new int[101];
	
	 static void InitializeBoard()//method to initiliase the board for snake and ladder
    {
    
        board[3] = 22; // Ladder
        board[5] = 8;
        board[11] = 26;
        board[20] = 29;

        board[27] = 1;  // Snakes
        board[21] = 9;
        board[17] = 4;
        board[19] = 7;
    }
	
	
 static int RollDice(){//method to roll dice
        return random.Next(1, 7);
    }


 static void GetPlayers(){//mthdos to get thr no of player
        do{
            Console.Write("Enter number of players (2–4): ");
            playerCount = Convert.ToInt32(Console.ReadLine());
        }
        while(playerCount < 2 || playerCount > 4);

        for(int i = 0;i<playerCount;i++){
            Console.Write("Enter player name: ");
            playerNames[i] = Console.ReadLine();
            playerPositions[i] = 0;
        }
    }
	
	//method to check snakker or ladder
    static int ApplySnakeOrLadder(int position){
        if(board[position] != 0){
            string msg = board[position] > position ? "Ladder" : "Snake";
            Console.WriteLine(msg + " found!");
            return board[position];
        }

        return position;
    }

//method to check win or not
    static bool CheckWin(int position){
        switch (position)
        {
            case 100:
                return true;
            default:
                return false;
        }
    }

    static void Main(){
        Console.WriteLine("game of snake and ladder:");
        InitializeBoard();//calling board initilise method
        GetPlayers();//calling get playr metod

        bool gameFinished = false;
        while(!gameFinished){//loop until game is not finsihed
            for(int i = 0;i<playerCount;i++){
                Console.WriteLine("\nPlayer Turn: " + playerNames[i]);
                Console.Write("Press ENTER to roll dice");
                Console.ReadLine();
                int dice = RollDice();
                int oldPos = playerPositions[i];
                int newPos = oldPos + dice;

                Console.WriteLine("Dice: " + dice);

                if(newPos > 100){//chekcin if move is greater than 100 or not
                    Console.WriteLine("Move skipped beyond 100");
                    continue;
                }

                newPos = ApplySnakeOrLadder(newPos);
                playerPositions[i] = newPos;

                Console.WriteLine("Position: " + oldPos + " → " + newPos);

                if(CheckWin(newPos)){
                    Console.WriteLine(playerNames[i] + " wins the game!");
                    gameFinished = true;
                    break;
                }
            }
        }
        Console.WriteLine("\nGame Over");
    }
   
}