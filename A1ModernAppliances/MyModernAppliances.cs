using ModernAppliances.Entities.Abstract;

public virtual void DisplayDishwashers()
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

public virtual void RandomList()
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


public class RandomComparer : IComparer<Appliance>
{
    private static readonly Random random = new Random();

    public int Compare(Appliance x, Appliance y)
    {
        return random.Next(-1, 2);
    }
}
