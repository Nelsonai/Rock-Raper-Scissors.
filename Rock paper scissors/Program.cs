namespace Name
{
    class program{
        public static void Main(string[] args)
        {
            // ? Class files Below
            getAppInfo();

            var playAgain = true;
            var userInput = "";
            

            while (playAgain)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Enter Rock, Paper or Scissors: ");
                userInput = Console.ReadLine();
                userInput.ToUpper();
                Console.ResetColor();

                if(userInput!="rock" && userInput!="paper" && userInput!="scissors"){
                    ColorMessage(ConsoleColor.Red, "Invalid Input!..");
                    
                    continue;
                }

                Console.WriteLine($"player: {userInput}");

                Random random = new Random();
                var computer = random.Next(1,4);
            
                if(computer==1){
                    Convert.ToString(computer);
                    Console.WriteLine("Computer: Rock");
                    
                }
                else if(computer==2){
                    Convert.ToString(computer);
                    Console.WriteLine("Computer: Paper");
                }
                else{
                    Convert.ToString(computer);
                    Console.WriteLine("Computer: Scissors");
                }

                if(userInput=="rock" && computer==1){
                    ColorMessage(ConsoleColor.Yellow, "It's a draw!..");
                }
                else if(userInput=="rock" && computer==2){
                    ColorMessage(ConsoleColor.Red, "You Loose!..");
                }
                else if(userInput=="rock" && computer==3){
                    ColorMessage(ConsoleColor.Green, "You Win!..");
                }
                else if(userInput=="paper" && computer==1){
                    ColorMessage(ConsoleColor.Green, "You Win!..");
                }
                else if(userInput=="paper" && computer==2){
                    ColorMessage(ConsoleColor.Yellow, "It's a draw!..");
                }
                else if(userInput=="paper" && computer==3){
                    ColorMessage(ConsoleColor.Red, "You Loose!..");
                }
                else if(userInput=="scissors" && computer==1){
                    ColorMessage(ConsoleColor.Red, "You Loose!..");
                }
                else if(userInput=="scissors" && computer==2){
                    ColorMessage(ConsoleColor.Green, "You Win!..");
                }
                else if(userInput=="scissors" && computer==3){
                    ColorMessage(ConsoleColor.Yellow, "It's a draw!..");
                }   

                Console.WriteLine("Want to play again [Y or N]: ");
                var answer = Console.ReadLine().ToUpper();

                if(answer == "Y" || answer == "Yes" || answer == "yes" || answer == "YES"){
                    continue;
                }
                else if(answer == "N" || answer == "NO" || answer == "no" || answer == "No"){
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input!..");
                    break;
                } 
            }
        }
            
            // ! Class files
            
            static void getAppInfo(){
            // Setting app details
            var appCreator = "Onyekachi Nelson Oriaku";
            var appVersion = "1.0.0";
            var appName = "Rock Paper Scissors";

            Console.ForegroundColor = ConsoleColor.DarkGreen;

            // Application information
            Console.WriteLine($"{appName} version: {appVersion} by {appCreator}");

            // Reseting text color
            Console.ResetColor();
        }

        static void ColorMessage(ConsoleColor color, string message){
            // Changing font Color
            Console.ForegroundColor = color;

            Console.WriteLine(message);

            // Reseting text color
            Console.ResetColor();
        }
    }
}