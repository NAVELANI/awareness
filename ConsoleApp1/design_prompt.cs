namespace ConsoleApp1
{
    public class design_prompt
    {
        // variable decleration (Global)
        private string user_name = string.Empty;
        private string user_asking = string.Empty;

        // constructor
        public design_prompt()
        {
            // now welcome the user and prompt the name
            //change the color
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("_-----------------------------------------------------_");
            //chanege the color again for the message
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine("|  Welocome to Cybersecurity Awareness Assistant  |");
            // then change the color to blue to repeat
            Console.ForegroundColor=ConsoleColor.Blue;
            Console.WriteLine("_------------------------------------------------------_");

            // now chatbot ask for the username
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("ChatBot:->");
            //then set the color for the question
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Please enter your name");

            //Now this where the user gets to enter their name
            //before the do while loop
            //change the color for the users
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("You:->");
            //then reset the color to white so the user can see what
            //they enter in white
            Console.ForegroundColor = ConsoleColor.White;
            //then ask the name
            user_name = Console.ReadLine();
                // you then now re-create the interface
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("ChatBot:->");
                //then for the question setup a gray color
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(" Hey " + user_name + ", how can i assist you today? ");



            //now we have the username collected from the user
            //Lets do the do while
            do
            {
              
                
                //then change the color for the username to yellow
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(user_name + ":->");
                //change back to white
                Console.ForegroundColor = ConsoleColor.White;
                //then prompt the question
                user_asking = Console.ReadLine();

                answer(user_asking);


            } while (user_asking !="exit");// end while loop







        } // end of constructor

        // answering method
        private void answer(string asked) 
        {
            if (asked != "exit") {

                //make sure it searches by the array
                //the answers show be retrieved
                //avoid doing conditions for each
                //Let the system search as given the filter
                Console.Write("Chatbot:->");
                //then change answer color
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Password security - are practices for establishing and verifying identity and restricting access to devices, files, and accounts");


                Console.ForegroundColor = ConsoleColor.White;// reset
                Console.Write("Chatbot:->");
                // Then change color for an answer
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("We hope the response was helpful");


                //then reset color 
                Console.ForegroundColor = ConsoleColor.White;

                //Another question


                //make sure it searches by the array
                //the answers show be retrieved
                //avoid doing conditions for each
                //Let the system search as given the filter
                Console.Write("Chatbot:-");
                //then change answer color
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Phishing - is the practice of sending fraudulent communications that appear to come from a legitimate and reputable source, usually through email and text messaging");


                Console.ForegroundColor = ConsoleColor.White;// reset
                Console.Write("Chatbot:->");
                // Then change color for an answer
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("We hope the response was helpful");


                //then reset color 
                Console.ForegroundColor = ConsoleColor.White;


            }
            else
            {
                //then exit app if exit
                Console.WriteLine("Thank you using Chatbot, Goodbye");
                System.Environment.Exit(0);

            }//end of else
        
        } // end of method answer

    }
}