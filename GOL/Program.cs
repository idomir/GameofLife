using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GOL.Library;
using System.Collections;
using System.Threading;
using GOL.Library.Interfaces;
 
namespace GOL.Main
{
    /// <summary>
    /// This is the class with entry point of the Game and controls the entire lifecycle of the application.
    /// </summary>
    class GOL
    {
        /// <summary>
        /// Start of the Game of Life Program
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {
                Grid grid = new Grid(); //Creating an empty grid

                PrintWelcomeMessage(); //printing welcome message

                PrintInstructions(); //Printing Game Instructions

                CreateGridAndCells(grid); //Creates a Grid with user provided inputs and also initializes the initial alive cells

                printGrid(grid); //This print displays the grid with user input cells that are true

                Console.WriteLine();

                GameofLifeManager gameofLifeManager;
                string evolveType = ConfigManager.GetStringLiterals("InPlaceOrSnapShot");
                if (evolveType == "0")
                    gameofLifeManager = new GameofLifeManager(grid,  EvolveType.InPlace);
                else if (evolveType == "1")
                    gameofLifeManager = new GameofLifeManager(grid,  EvolveType.SnapShot);
                else
                    gameofLifeManager = new GameofLifeManager(grid,  EvolveType.SnapShot);

                Console.WriteLine("Press Q to stop");
                Console.WriteLine();

                //Loop to continously print the Grid with evolved cells. 
                //The loop will sleep for 5 seconds before evolving ensuring display of new evolved cells on the console.
                do
                {
                    while (!Console.KeyAvailable)
                    {
                        gameofLifeManager.EmulateGOL();
                        printGrid(grid);
                        Console.WriteLine("\r\n");
                        Thread.Sleep(5000);
                    }
                } while (Console.ReadKey(true).Key != ConsoleKey.Q);
            }
            catch (ConfigurationException ex)
            {

                Console.WriteLine("Keys in configuration file are Incorrect..Application exiting..");
                    throw new ApplicationException("PLease try again later..");
            }
            catch(Exception ex)
            {
                throw new ApplicationException(ConfigManager.GetStringLiterals("ExceptionString"));
                
            }
        }

        /// <summary>
        /// This function prints the grid with current cell values
        /// </summary>
        /// <param name="grid"></param>
        private static void printGrid(Grid grid)
        {
            try
            {
                string aliveCellDisplay = ConfigManager.GetStringLiterals("AliveCellDisplay"); //Get the value from App.config
                string deadCellDisplay = ConfigManager.GetStringLiterals("DeadCellDisplay"); //Get the value from App.config
                int length = grid.Length;
                int breath = grid.Breath;
                for (int i = 0; i < length; i++)
                {
                    for (int j = 0; j < breath; j++)
                    {
                        if (grid[i, j].IsAlive == true)
                            Console.Write(aliveCellDisplay);
                        else
                            Console.Write(deadCellDisplay);
                    }
                    Console.WriteLine();
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                throw new ApplicationException(ConfigManager.GetStringLiterals("ExceptionString"));
            }
        }

        private static void CreateGridAndCells(Grid grid)
        {
                Console.WriteLine(Utilities.StringAlignment(ConfigManager.GetStringLiterals("AskforGridSize"), Alignment.Left, LineBreaks.Single)); //Get the value from App.config

                int length = 0;
                int breath = 0;

                //loop for getting valid Grid size from user
                while (true)
                {
                    string gridMatrix = Console.ReadLine(); //expected input e.g. 5,5
                    if (GetUserInputsGrid(gridMatrix, ref length, ref breath))
                        break;
                    Console.WriteLine(Utilities.StringAlignment(ConfigManager.GetStringLiterals("InvalidGridSize"), Alignment.Left, LineBreaks.Single)); //Get the value from App.config
                }

                // Create Grid with User inputs
                grid.Length = length;
                grid.Breath = breath;
                grid.CreateGrid();


                Console.WriteLine(Utilities.StringAlignment(ConfigManager.GetStringLiterals("AskforCells"), Alignment.Left, LineBreaks.Single));  //Get the value from App.config

                // Loop for getting Valid cell locations from user
                while (true)
                {
                    string cellMatrix = Console.ReadLine(); //expected input e.g. 2,2-2,3-4,5
                    if (ValidateAndSetInputCells(cellMatrix, grid))
                        break;
                    Console.WriteLine(Utilities.StringAlignment(ConfigManager.GetStringLiterals("InvalidCellInput"), Alignment.Left, LineBreaks.Single));  //Get the value from App.config
                }
            
            
        }

        /// <summary>
        /// Validates the input for alive cells and updates the Grid with them.
        /// </summary>
        /// <param name="inputString"></param>
        /// <param name="grid"></param>
        /// <returns></returns>
        private static bool ValidateAndSetInputCells(string inputString, Grid grid)
        {

            if (string.IsNullOrEmpty(inputString) || string.IsNullOrWhiteSpace(inputString))
                return false;

            string[] cellLocations = Utilities.GetStringArrayFromDelimitedString(inputString, new char[] { '-' });

            if (cellLocations.Length == 0)
            {
                return false;
            }
            else
            {
                foreach (string str in cellLocations)
                {
                    string[] inputValues = Utilities.GetStringArrayFromDelimitedString(str, new char[] { ',' });

                    if (inputValues.Length != 2)
                        return false;

                    for (int i = 0; i < inputValues.Length; i++)
                    {
                        if (!Utilities.isNumeric(inputValues[i]))
                            return false;
                        if (Convert.ToInt32(inputValues[i]) < 0)
                            return false;

                    }

                    int row = -1;
                    int col = -1;

                    if (Convert.ToInt32(inputValues[0]) > grid.Breath)
                        return false;
                    if (Convert.ToInt32(inputValues[0]) > grid.Length)
                        return false;

                    row = Convert.ToInt32(inputValues[0]);
                    col = Convert.ToInt32(inputValues[1]);
                    grid[row - 1, col - 1].IsAlive = true;
                }
            }
            return true;
        }

        /// <summary>
        /// Validates the user inputs for grid size
        /// </summary>
        /// <param name="inputString"></param>
        /// <param name="length"></param>
        /// <param name="breath"></param>
        /// <returns></returns>
        private static bool GetUserInputsGrid(string inputString, ref int length, ref int breath)
        {
            
            if (string.IsNullOrEmpty(inputString) || string.IsNullOrWhiteSpace(inputString))
                return false;
            
            string[] inputValues = Utilities.GetStringArrayFromDelimitedString(inputString, new char[] {','});

            if (inputValues.Length != 2)
            {
                return false;
            }
            
            for (int i = 0; i < inputValues.Length; i++)
            {
                if (!Utilities.isNumeric(inputValues[i]))
                    return false;
                if (Convert.ToInt32(inputValues[i]) < 0)
                    return false;
            }

            length = Convert.ToInt32(inputValues[0]);
            breath = Convert.ToInt32(inputValues[1]);
              


            return true;
        }

        /// <summary>
        /// This function prints the Welcome Message for the user and get all strings from app.config file.
        /// </summary>
        private static void PrintWelcomeMessage()
        {
            Console.WriteLine(Utilities.StringAlignment(ConfigManager.GetStringLiterals("WelcomeString"), Alignment.Center, LineBreaks.Double));
        }

        /// <summary>
        /// This function prints the instruction for the user and get all strings from app.config file.
        /// This could have been a resource or an XML file and that needs to be done further.
        /// </summary>
        private static void PrintInstructions()
        {
                Console.WriteLine(Utilities.StringAlignment(ConfigManager.GetStringLiterals("Instructions1"), Alignment.Left, LineBreaks.Single));
                Console.WriteLine(Utilities.StringAlignment(ConfigManager.GetStringLiterals("Instructions2"), Alignment.Left, LineBreaks.Single));
                Console.WriteLine(Utilities.StringAlignment(ConfigManager.GetStringLiterals("Instructions3"), Alignment.Left, LineBreaks.Single));
                Console.WriteLine(Utilities.StringAlignment(ConfigManager.GetStringLiterals("Instructions4"), Alignment.Left, LineBreaks.Double));
                Console.WriteLine(Utilities.StringAlignment(ConfigManager.GetStringLiterals("Instructions5"), Alignment.Left, LineBreaks.Single));
                Console.WriteLine(Utilities.StringAlignment(ConfigManager.GetStringLiterals("Instructions6"), Alignment.Left, LineBreaks.Double));
            
            
        }
    }
}
