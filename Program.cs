int smallCarnivore;
int mediumCarnivore;
int largeCarnivore;

int smallHerbivore;
int mediumHerbivore;
int largeHerbivore;

const int large = 5;
const int medium = 3;
const int small = 1;


const int wagonPoint = 10;
int wagonTotal; //
int wagonPoint;
int pointsTotal;
int pointsRemaining;
int pointsMaxDanger;

bool successfulCompletion = false;
bool processed;

try
{
    Console.WriteLine("Enter the number of small carnivores that is being transported: ");
    smallCarnivore = Convert.ToInt32(Console.Read());
    Console.WriteLine("Enter the number of medium carnivores that is being transported: ");
    mediumCarnivore = Convert.ToInt32(Console.Read());
    Console.WriteLine("Enter the number of large carnivores that is being transported: ");
    largeCarnivore = Convert.ToInt32(Console.Read());


    Console.WriteLine("Enter the number of small herbivores that is being transported: ");
    smallCarnivore = Convert.ToInt32(Console.Read());
    Console.WriteLine("Enter the number of medium herbivores that is being transported: ");
    smallCarnivore = Convert.ToInt32(Console.Read());
    Console.WriteLine("Enter the number of large herbivores that is being transported: ");
    smallCarnivore = Convert.ToInt32(Console.Read());

    //larger = 5 points
    //medium = 3 points 
    //small = 1 point
    //max points per wagon = 10 points

    //carnivore is never bigger than herbivore in the same wagon

    pointsTotal = large * (largeCarnivore + largeHerbivore) + medium * (mediumCarnivore + mediumHerbivore) + small * (smallCarnivore + smallHerbivore);
    wagonPoint = 0;
    wagonTotal = 0;
    pointsMaxDanger = 0;

    while (pointsTotal == pointsRemaining && !processed)
    {
        processed = false;

        if (largeCarnivore > 0 && wagonPoint <= 5 && pointsMaxDanger < 5)
        {
            wagonPoint += 5;
            pointsMaxDanger = 5;
            processed = true;
        }
    }



    successfulCompletion = true;
}

catch (System.FormatException)
{
    Console.WriteLine("Please enter a number.");
}

// errors to catch from user input:
//negative numbers
//decimal numbers - will cause program to stop