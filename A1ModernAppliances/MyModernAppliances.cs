using ModernAppliances.Entities;
using ModernAppliances.Entities.Abstract;
using ModernAppliances.Helpers;
using System.Diagnostics;

namespace ModernAppliances
{
    /// <summary>
    /// Manager class for Modern Appliances
    /// </summary>
    /// <remarks>Author: </remarks>
    /// <remarks>Date: </remarks>
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
            long num;

            // Get user input as string and assign to variable.
            // Convert user input from string to long and store as item number variable.
            num = long.Parse(Console.ReadLine());

            // Create 'foundAppliance' variable to hold appliance with item number
            // Assign null to foundAppliance (foundAppliance may need to be set as nullable)
            Appliance? foundAppliance = null;

            // Loop through Appliances
            // Test appliance item number equals entered item number
            // Assign appliance in list to foundAppliance variable
            foreach (var appliance in Appliances)
            {
                if (appliance.ItemNumber == num)
                {
                    foundAppliance = appliance;
                    break;
                }
            }

            // Break out of loop (since we found what need to)

            // Test appliance was not found (foundAppliance is null)
            // Write "No appliances found with that item number."
            if (foundAppliance == null)
            {
                Console.WriteLine("No appliances found with that item number.");
                return;
            }

            // Otherwise (appliance was found)
            // Test found appliance is available
            // Checkout found appliance
            if (foundAppliance.IsAvailable)
            {
                foundAppliance.Checkout();
                Console.WriteLine("Appliance has been checked out.");
            }
            // Write "Appliance has been checked out."
            // Otherwise (appliance isn't available)
            // Write "The appliance is not available to be checked out."
            else
            {
                Console.WriteLine("The appliance is not available to be checked out.");
            }

        }

        /// <summary>
        /// Option 2: Finds appliances
        /// </summary>
        public override void Find()
        {
            // Write "Enter brand to search for:"
            Console.WriteLine("Enter brand to search for: ");

            // Create string variable to hold entered brand
            // Get user input as string and assign to variable.
            var input = Console.ReadLine();

            // Create list to hold found Appliance objects
            var found = new List<Appliance>();

            // Iterate through loaded appliances
            // Test current appliance brand matches what user entered
            // Add current appliance in list to found list
            foreach (Appliance appliance in Appliances)
            {
                if (appliance.Brand == input)
                {
                    found.Add(appliance);
                }
            }

            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays Refridgerators
        /// </summary>
        public override void DisplayRefrigerators()
        {
            // Write "Possible options:"

            // Write "0 - Any"
            // Write "2 - Double doors"
            // Write "3 - Three doors"
            // Write "4 - Four doors"
            Console.WriteLine("Possible Options\n0 - Any\n2 - Double doors\n3 - Three doors\n4 - Four doors");

            // Write "Enter number of doors: "
            // Create variable to hold entered number of doors
            // Get user input as string and assign to variable
            // Convert user input from string to int and store as number of doors variable.
            Console.WriteLine("Enter number of doors: ");
            int doors = int.Parse(Console.ReadLine());

            // Create list to hold found Appliance objects
            var list = new List<Appliance>();

            // Iterate/loop through Appliances
            // Test that current appliance is a refrigerator
            // Down cast Appliance to Refrigerator
            // Refrigerator refrigerator = (Refrigerator) appliance;
            foreach (Appliance appliance in Appliances)
            {
                if (appliance is Refrigerator)
                {
                    Refrigerator refrigerator = (Refrigerator)appliance;
                    if (refrigerator.Doors == doors || doors == 0)
                    {
                        list.Add(refrigerator);
                    }
                }
            }

            // Test user entered 0 or refrigerator doors equals what user entered.
            // Add current appliance in list to found list

            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
            DisplayAppliancesFromList(list, 0);
        }

        /// <summary>
        /// Displays Vacuums
        /// </summary>
        /// <param name="grade">Grade of vacuum to find (or null for any grade)</param>
        /// <param name="voltage">Vacuum voltage (or 0 for any voltage)</param>
        public override void DisplayVacuums()
        {
            // Write "Possible options:"


            // Write "0 - Any"
            // Write "1 - Residential"
            // Write "2 - Commercial"
            Console.WriteLine("Possible options:\n0 - Any\n1 - Resedential\n2 - Commercial");

            // Write "Enter grade:"
            Console.WriteLine(" Enter Grade :");
            // Get user input as string and assign to variable
            string grade;
            // Create grade variable to hold grade to find (Any, Residential, or Commercial)
            grade = Console.ReadLine();
            // Test input is "0"
            // Assign "Any" to grade
            // Test input is "1"
            // Assign "Residential" to grade
            // Test input is "2"
            // Assign "Commercial" to grade
            // Otherwise (input is something else)
            // Write "Invalid option."
            // Return to calling (previous) method
            // return;
            switch (grade)
            {
                case "0":
                    grade = "Any";
                    break;
                case "1":
                    grade = "Residential";
                    break;
                case "2":
                    grade = "Commercial";
                    break;
                default:
                    Console.WriteLine("Invalid option. ");
                    return;
            }

            // Write "Possible options:"
            // Write "0 - Any"
            // Write "1 - 18 Volt"
            // Write "2 - 24 Volt"
            Console.WriteLine("Possible options:\n0 - Any\n1 - 18 Volt\n2 - 24 Volt");
            // Write "Enter voltage:"
            Console.WriteLine("Enter Voltage");
            // Get user input as string
            int volt;

            // Create variable to hold voltage
            volt = int.Parse(Console.ReadLine());
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
            switch (volt)
            {
                case 0:
                    volt = 0;
                    break;
                case 1:
                    volt = 18;
                    break;
                case 2:
                    volt = 24;
                    break;
                default:
                    Console.WriteLine("Invalid option. ");
                    return;
            }

            // Create found variable to hold list of found appliances.

            var foundlist = new List<Appliance>();

            // Loop through Appliances
            foreach (Appliance appliance in Appliances)
            {
                if(appliance is Vacuum)
                {
                    Vacuum vacuum = (Vacuum)appliance;
                    if (grade == "any" && volt == 0)
                    {
                        foundlist.Add(vacuum);
                        continue;
                    }
                    if (grade == vacuum.Grade && volt == vacuum.BatteryVoltage)
                    {
                        foundlist.Add(vacuum);
                        continue;
                    }
                }
            }
            // Check if current appliance is vacuum
            // Down cast current Appliance to Vacuum object
            // Vacuum vacuum = (Vacuum)appliance;

            // Test grade is "Any" or grade is equal to current vacuum grade and voltage is 0 or voltage is equal to current vacuum voltage
            // Add current appliance in list to found list

            // Display found appliances
            DisplayAppliancesFromList(foundlist, 0);

        }

        /// <summary>
        /// Displays microwaves
        /// </summary>
        public override void DisplayMicrowaves()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options :\n0 - Any\n1 - Kitchen\n2 - Work site");

            // Write "0 - Any"
            // Write "1 - Kitchen"
            // Write "2 - Work site"

            // Write "Enter room type:"
            Console.WriteLine("Enter room type:");
            // Get user input as string and assign to variable
            string room;
            // Create character variable that holds room type
            room = Console.ReadLine();
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
            switch (room)
            {
                case "0":
                    room = "A";
                    break;
                case "1":
                    room = "K";
                    break;
                case "2":
                    room = "W";
                    break;
                default:
                    Console.WriteLine("Invalid option. ");
                    return;
            }

            // Create variable that holds list of 'found' appliances
            var found = new List<Appliance>();
            // Loop through Appliances
            foreach (Appliance appliance in Appliances)
            {
                if (appliance is Microwave)
                {
                    Microwave microwave = (Microwave) appliance;
                    if (room == "A")
                    {
                        found.Add(microwave);
                        continue;
                    }
                    if (room.ToCharArray()[0] == microwave.RoomType) //The string is already just one character
                    {
                        found.Add(microwave);
                        continue;
                    }
                }


            }
            // Test current appliance is Microwave
            // Down cast Appliance to Microwave

            // Test room type equals 'A' or microwave room type
            // Add current appliance in list to found list

            // Display found appliances
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays dishwashers
        /// </summary>
        public override void DisplayDishwashers()
        {
            Console.WriteLine("Possible options:");
            Console.WriteLine("0 - Any");
            Console.WriteLine("1 - Quietest");
            Console.WriteLine("2 - Quieter");
            Console.WriteLine("3 - Quiet");
            Console.WriteLine("4 - Moderate");
            Console.WriteLine("Enter sound rating:");

            string userInput = Console.ReadLine();
            string soundRating = " ";
            switch (userInput)
            {
                case "0":
                    soundRating = "Any";
                    break;
                case "1":
                    soundRating = "Qt";
                    break;
                case "2":
                    soundRating = "Qr";
                    break;
                case "3":
                    soundRating = "Qu";
                    break;
                case "4":
                    soundRating = "M";
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    return;
            }

            List<Appliance> foundAppliances = new List<Appliance>();


            foreach (Appliance appliance in Appliances)
            {
                if (appliance is Dishwasher)
                {
                    Dishwasher dishwasher = (Dishwasher)appliance;

                    if (soundRating == "Any" || soundRating == dishwasher.SoundRating)
                    {
                        foundAppliances.Add(appliance);
                    }
                }
            }

            DisplayAppliancesFromList(foundAppliances, 0);
        }

        /// <summary>
        /// Generates random list of appliances
        /// </summary>
        public override void RandomList()
        {
            Console.WriteLine("Appliance Types:");
            Console.WriteLine("0 - Any");
            Console.WriteLine("1 – Refrigerators");
            Console.WriteLine("2 – Vacuums");
            Console.WriteLine("3 – Microwaves");
            Console.WriteLine("4 – Dishwashers");
            Console.WriteLine("Enter type of appliance:");

            string applianceTypeInput = Console.ReadLine();
            Console.WriteLine("Enter number of appliances:");

            string numInput = Console.ReadLine();
            int num;
            if (!int.TryParse(numInput, out num))
            {
                Console.WriteLine("Invalid number.");
                return;
            }

            List<Appliance> foundAppliances = new List<Appliance>();
            foreach (Appliance appliance in Appliances)
            {
                switch (applianceTypeInput)
                {
                    case "0":
                        foundAppliances.Add(appliance);
                        break;
                    case "1":
                        if (appliance is Refrigerator)
                            foundAppliances.Add(appliance);
                        break;
                    case "2":
                        if (appliance is Vacuum)
                            foundAppliances.Add(appliance);
                        break;
                    case "3":
                        if (appliance is Microwave)
                            foundAppliances.Add(appliance);
                        break;
                    case "4":
                        if (appliance is Dishwasher)
                            foundAppliances.Add(appliance);
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        return;
                }
            }

            foundAppliances.Sort(new RandomComparer());

            DisplayAppliancesFromList(foundAppliances, num);
        }
    }
}
