using ModernAppliances.Entities;
using ModernAppliances.Entities.Abstract;
using ModernAppliances.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ModernAppliances
{
    /// <summary>
    /// Manager class for Modern Appliances
    /// </summary>
    /// <remarks>Author: Sumandeep Kaur </remarks>
    /// <remarks>Date: 2023-02-10 </remarks>
    internal class MyModernAppliances : ModernAppliances
    {
        /// <summary>
        /// Option 1: Performs a checkout
        /// </summary>
        public override void Checkout()
        {
            // Write "Enter the item number of an appliance: "
            Console.WriteLine("Enter the item number of an appliance: ");

            // Create long variable to hold item number
            long itemNum;

            // Get user input as string and assign to variable.
            string itemNumString = Console.ReadLine();

            // Convert user input from string to long and store as item number variable.
            itemNum = long.Parse(itemNumString);

            // Create 'foundAppliance' variable to hold appliance with item number

            // Assign null to foundAppliance (foundAppliance may need to be set as nullable)
            Appliance foundAppliance = null;

            // Loop through Appliances
            // Test appliance item number equals entered item number
            // Assign appliance in list to foundAppliance variable

            foreach (Appliance appliance in Appliances)
            {
                if (itemNum == appliance.ItemNumber)
                {
                    foundAppliance = appliance;
                    Console.WriteLine("Appliance was found.");
                    if (appliance.IsAvailable == true)
                    {
                        appliance.Checkout();
                        Console.WriteLine("Appliance has been checked out. \n");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The appliance is not available to be checked out. \n");
                    }

                }
            }
            if (foundAppliance == null)
            {
                Console.WriteLine("No appliances found with that item number.");
            }

            // Break out of loop (since we found what need to)

            // Test appliance was not found (foundAppliance is null)
            // Write "No appliances found with that item number."

            // Otherwise (appliance was found)
            // Test found appliance is available
            // Checkout found appliance

            // Write "Appliance has been checked out."
            // Otherwise (appliance isn't available)
            // Write "The appliance is not available to be checked out."
        }

        /// <summary>
        /// Option 2: Finds appliances
        /// </summary>
        public override void Find()
        {
            // Write "Enter brand to search for:"
            Console.WriteLine("Enter brand to search for:");

            // Create string variable to hold entered brand
            string brandName;

            // Get user input as string and assign to variable.
            brandName = Console.ReadLine();

            // Create list to hold found Appliance objects
            List<Appliance> foundApplianceList = new List<Appliance>();

            // Iterate through loaded appliances
            // Test current appliance brand matches what user entered
            // Add current appliance in list to found list
            foreach (Appliance appliance in Appliances)
            {
                if (appliance.Brand == brandName)
                {
                    foundApplianceList.Add(appliance);
                }
            }

            // Display found appliances
            DisplayAppliancesFromList(foundApplianceList, 0);
        }

        /// <summary>
        /// Displays Refridgerators
        /// </summary>
        public override void DisplayRefrigerators()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options:");

            // Write "0 - Any"
            // Write "2 - Double doors"
            // Write "3 - Three doors"
            // Write "4 - Four doors"
            Console.WriteLine("0 - Any \n2 - Double doors \n3 - Three doors \n4 - Four doors");

            // Write "Enter number of doors: "
            Console.WriteLine("Enter number of doors: ");

            // Create variable to hold entered number of doors
            int doorsNum;

            // Get user input as string and assign to variable
            string doorsNumString = Console.ReadLine();

            // Convert user input from string to int and store as number of doors variable.
            doorsNum = int.Parse(doorsNumString);

            // Create list to hold found Appliance objects
            List<Appliance> foundApplianceList = new List<Appliance>();

            // Iterate/loop through Appliances
            // Test that current appliance is a refrigerator
            // Down cast Appliance to Refrigerator
            // Refrigerator refrigerator = (Refrigerator) appliance;

            foreach (Appliance appliance in Appliances)
            {
                if (appliance is Refrigerator)
                {
                    Refrigerator refrigerator = (Refrigerator)appliance;
                    if (doorsNum == 0 || doorsNum == refrigerator.Doors)
                    {
                        foundApplianceList.Add(appliance);
                    }
                }
            }

            // Test user entered 0 or refrigerator doors equals what user entered.
            // Add current appliance in list to found list

            // Display found appliances
            DisplayAppliancesFromList(foundApplianceList, 0);
        }

        /// <summary>
        /// Displays Vacuums
        /// </summary>
        /// <param name="grade">Grade of vacuum to find (or null for any grade)</param>
        /// <param name="voltage">Vacuum voltage (or 0 for any voltage)</param>
        public override void DisplayVacuums()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options: ");

            // Write "0 - Any"
            // Write "1 - Residential"
            // Write "2 - Commercial"
            Console.WriteLine("0 - Any \n1 - Residential \n2 - Commercial");

            // Write "Enter grade:"
            Console.WriteLine("Enter grade: ");

            // Get user input as string and assign to variable
            string grade = Console.ReadLine();
            // Create grade variable to hold grade to find (Any, Residential, or Commercial)

            // Test input is "0"
            // Assign "Any" to grade
            // Test input is "1"
            // Assign "Residential" to grade
            // Test input is "2"
            // Assign "Commercial" to grade
            // Otherwise (input is something else)
            // Write "Invalid option."

            if (grade == "0")
            {
                grade = "Any";
            }
            else if (grade == "1")
            {
                grade = "Residential";
            }
            else if (grade == "2")
            {
                grade = "Commercial";
            }
            else
            {
                Console.WriteLine("Invalid option.");
                return;
            }

            // Return to calling (previous) method
            // return;

            // Write "Possible options:"
            Console.WriteLine("Possible options: ");

            // Write "0 - Any"
            // Write "1 - 18 Volt"
            // Write "2 - 24 Volt"
            Console.WriteLine("0 - Any \n1 - 18 Volt \n2 - 24 Volt");

            // Write "Enter voltage:"
            Console.WriteLine("Enter voltage: ");

            // Get user input as string
            string voltage = Console.ReadLine();
            // Create variable to hold voltage
            int voltageInt;

            // Test input is "0"
            // Assign 0 to voltage
            // Test input is "1"
            // Assign 18 to voltage
            // Test input is "2"
            // Assign 24 to voltage
            // Otherwise
            // Write "Invalid option."
            // Return to calling (previous) method
            // return;

            if (voltage == "0")
            {
                voltageInt = 0;
            }
            else if (voltage == "1")
            {
                voltageInt = 18;
            }
            else if (voltage == "2")
            {
                voltageInt = 24;
            }
            else
            {
                Console.WriteLine("Invalid option.");
                return;
            }

            // Create found variable to hold list of found appliances.
            List<Appliance> foundApplianceList = new List<Appliance>();

            // Loop through Appliances
            // Check if current appliance is vacuum
            // Down cast current Appliance to Vacuum object
            // Vacuum vacuum = (Vacuum)appliance;

            foreach (Appliance appliance in Appliances)
            {
                if (appliance is Vacuum)
                {
                    Vacuum vacuum = (Vacuum)appliance;
                    if (grade == "Any" || grade == vacuum.Grade && voltageInt == 0 || voltageInt == vacuum.BatteryVoltage)
                    {
                        foundApplianceList.Add(appliance);
                    }
                }
            }

            // Test grade is "Any" or grade is equal to current vacuum grade and voltage is 0 or voltage is equal to current vacuum voltage
            // Add current appliance in list to found list

            // Display found appliances
            DisplayAppliancesFromList(foundApplianceList, 0);
        }

        /// <summary>
        /// Displays microwaves
        /// </summary>
        public override void DisplayMicrowaves()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options: ");

            // Write "0 - Any"
            // Write "1 - Kitchen"
            // Write "2 - Work site"
            Console.WriteLine("0 - Any \n1 - Kitchen \n2 - Work site");

            // Write "Enter room type:"
            Console.WriteLine("Enter room type: ");

            // Get user input as string and assign to variable
            string roomTypeString = Console.ReadLine();

            // Create character variable that holds room type
            char roomType;

            // Test input is "0"
            // Assign 'A' to room type variable
            // Test input is "1"
            // Assign 'K' to room type variable
            // Test input is "2"
            // Assign 'W' to room type variable
            // Otherwise (input is something else)
            // Write "Invalid option."
            // Return to calling method
            // return;
            if (roomTypeString == "0")
            {
                roomType = 'A';
            }
            else if (roomTypeString == "1")
            {
                roomType = 'K';
            }
            else if (roomTypeString == "2")
            {
                roomType = 'W';
            }
            else
            {
                Console.WriteLine("Invalid option.");
                return;
            }


            // Create variable that holds list of 'found' appliances
            List<Appliance> foundApplianceList = new List<Appliance>();

            // Loop through Appliances
            // Test current appliance is Microwave
            // Down cast Appliance to Microwave

            foreach (Appliance appliance in Appliances)
            {
                if (appliance is Microwave)
                {
                    Microwave microwave = (Microwave)appliance;
                    if (roomType == 'A' || roomType == microwave.RoomType)
                    {
                        foundApplianceList.Add(appliance);
                    }
                }
            }

            // Test room type equals 'A' or microwave room type
            // Add current appliance in list to found list

            // Display found appliances
            DisplayAppliancesFromList(foundApplianceList, 0);
        }

        /// <summary>
        /// Displays dishwashers
        /// </summary>
        public override void DisplayDishwashers()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options:");

            // Write "0 - Any"
            // Write "1 - Quietest"
            // Write "2 - Quieter"
            // Write "3 - Quiet"
            // Write "4 - Moderate"
            Console.WriteLine("0 - Any \n1 - Quietest \n2 - Quieter \n3 - Quiet \n4 - Moderate");

            // Write "Enter sound rating:"
            Console.WriteLine("Enter sound rating: ");

            // Get user input as string and assign to variable
            string soundRating = Console.ReadLine();

            // Create variable that holds sound rating

            // Test input is "0"
            // Assign "Any" to sound rating variable
            // Test input is "1"
            // Assign "Qt" to sound rating variable
            // Test input is "2"
            // Assign "Qr" to sound rating variable
            // Test input is "3"
            // Assign "Qu" to sound rating variable
            // Test input is "4"
            // Assign "M" to sound rating variable
            // Otherwise (input is something else)
            // Write "Invalid option."
            // Return to calling method

            if (soundRating == "0")
            {
                soundRating = "Any";
            }
            else if (soundRating == "1")
            {
                soundRating = "Qt";
            }
            else if (soundRating == "2")
            {
                soundRating = "Qr";
            }
            else if (soundRating == "3")
            {
                soundRating = "Qu";
            }
            else if (soundRating == "4")
            {
                soundRating = "M";
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }

            // Create variable that holds list of found appliances
            List<Appliance> foundApplianceList = new List<Appliance>();

            // Loop through Appliances
            // Test if current appliance is dishwasher
            // Down cast current Appliance to Dishwasher

            foreach (Appliance appliance in Appliances)
            {
                if (appliance is Dishwasher)
                {
                    Dishwasher dishwasher = (Dishwasher)appliance;
                    if (soundRating == "Any" || soundRating == dishwasher.SoundRating)
                    {
                        foundApplianceList.Add(appliance);
                    }
                }
            }

            // Test sound rating is "Any" or equals soundrating for current dishwasher
            // Add current appliance in list to found list

            // Display found appliances (up to max. number inputted)
            DisplayAppliancesFromList(foundApplianceList, 0);
        }

        /// <summary>
        /// Generates random list of appliances
        /// </summary>
        public override void RandomList()
        {
            // Write "Appliance Types"
            Console.WriteLine("Appliance Types");

            // Write "0 - Any"
            // Write "1 – Refrigerators"
            // Write "2 – Vacuums"
            // Write "3 – Microwaves"
            // Write "4 – Dishwashers"
            Console.WriteLine("0 - Any \n1 – Refrigerators \n2 – Vacuums \n3 – Microwaves \n4 – Dishwashers");

            // Write "Enter type of appliance:"
            Console.WriteLine("Enter type of appliance:");

            // Get user input as string and assign to appliance type variable
            string applianceType = Console.ReadLine();

            // Write "Enter number of appliances: "
            Console.WriteLine("Enter number of appliances: ");

            // Get user input as string and assign to variable
            string applianceNumString = Console.ReadLine();

            // Convert user input from string to int
            int applianceNum = int.Parse(applianceNumString);

            // Create variable to hold list of found appliances
            List<Appliance> foundApplianceList = new List<Appliance>();

            // Loop through appliances
            // Test inputted appliance type is "0"
            // Add current appliance in list to found list
            // Test inputted appliance type is "1"
            // Test current appliance type is Refrigerator
            // Add current appliance in list to found list
            // Test inputted appliance type is "2"
            // Test current appliance type is Vacuum
            // Add current appliance in list to found list
            // Test inputted appliance type is "3"
            // Test current appliance type is Microwave
            // Add current appliance in list to found list
            // Test inputted appliance type is "4"
            // Test current appliance type is Dishwasher
            // Add current appliance in list to found list

            foreach (Appliance appliance in Appliances)
            {
                if (applianceType == "0")
                {
                    foundApplianceList.Add(appliance);
                }
                else if (applianceType == "1")
                {
                    if (appliance is Refrigerator)
                    {
                        foundApplianceList.Add(appliance);
                    }
                }
                else if (applianceType == "2")
                {
                    if (appliance is Vacuum)
                    {
                        foundApplianceList.Add(appliance);
                    }
                }
                else if (applianceType == "3")
                {
                    if (appliance is Microwave)
                    {
                        foundApplianceList.Add(appliance);
                    }
                }
                else if (applianceType == "4")
                {
                    if (appliance is Dishwasher)
                    {
                        foundApplianceList.Add(appliance);
                    }
                }
            }

            // Randomize list of found appliances
            foundApplianceList.Sort(new RandomComparer());

            // Display found appliances (up to max. number inputted)
            DisplayAppliancesFromList(foundApplianceList, applianceNum);
        }
    }
}
