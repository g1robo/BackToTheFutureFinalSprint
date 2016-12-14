﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_To_The_Future_Game
{
    public static class ConsoleViewHelpers
    {
        /// <summary>
        /// Display a Yes or No prompt with a message
        /// </summary>
        /// <param name="promptMessage">prompt message</param>
        /// <returns>bool where true = yes</returns>
        public static bool? DisplayGetYesNoPrompt(string promptMessage)
        {
            bool? yesNoChoice = null;
            bool validResponse = false;
            string userResponse;

            while (!validResponse)
            {
                ConsoleUtil.DisplayReset();

                ConsoleUtil.DisplayPromptMessage(promptMessage + "(Yes/No)");
                userResponse = Console.ReadLine();

                if (userResponse.ToUpper() == "YES")
                {
                    validResponse = true;
                    yesNoChoice = true;
                }
                else if (userResponse.ToUpper() == "NO")
                {
                    validResponse = true;
                    yesNoChoice = false;
                    DisplayExitPrompt();
                    break;
                    
                    
                }
                else
                {
                    ConsoleUtil.DisplayMessage(
                        "It appears that you have entered an incorrect response." +
                        " Please enter either \"Yes\" or \"No\"."
                        );
                    DisplayContinuePrompt();
                }
            }

            return yesNoChoice;
        }

        /// <summary>
        /// Display an integer prompt with a message including the min/max values
        /// </summary>
        /// <param name="promptMessage">prompt message</param>
        /// <returns>user's choice of integer</returns>
        public static int DisplayGetIntegerPrompt(string promptMessage, int minNumber, int maxNumber)
        {
            //
            // dummy choice - refactor later to return a null
            //
            int intChoice = -9999;
            bool validResponse = false;
            string userResponse;

            while (!validResponse)
            {
                ConsoleUtil.DisplayReset();

                ConsoleUtil.DisplayPromptMessage($"{promptMessage} ({minNumber} - {maxNumber}");
                userResponse = Console.ReadLine();

                if (int.TryParse(userResponse, out intChoice))
                {
                    if (intChoice >= maxNumber && intChoice <= maxNumber)
                    {
                        validResponse = true;
                    }
                    else
                    {
                        ConsoleUtil.DisplayMessage(
                            "It appears that you have entered an integer out of range." +
                            $" Please enter an integer between {minNumber} and {maxNumber}."
                            );
                        DisplayContinuePrompt();
                    }
                }
                else
                {
                    ConsoleUtil.DisplayMessage(
                        "It appears that you have not entered an integer." +
                        $" Please enter an integer between {minNumber} and {maxNumber}."
                        );
                    DisplayContinuePrompt();
                }
            }

            return intChoice;
        }

        /// <summary>
        /// display the Continue prompt
        /// </summary>
        public static void DisplayContinuePrompt()
        {
            Console.CursorVisible = false;

            Console.WriteLine();

            ConsoleUtil.DisplayMessage("Press any key to continue.");
            ConsoleKeyInfo response = Console.ReadKey();

            Console.WriteLine();

            Console.CursorVisible = true;
        }

        public static void DisplayExitPrompt()
        {
      
            ConsoleUtil.HeaderText = "Exit";
            ConsoleUtil.DisplayReset();

            Console.CursorVisible = false;

            Console.WriteLine();
            ConsoleUtil.DisplayMessage(" Great Scott!");
            ConsoleUtil.DisplayMessage("");
            ConsoleUtil.DisplayMessage(" Are you sure you want to leave the Future?");
            Console.ReadKey();

            System.Environment.Exit(1);
        }
    }

}
