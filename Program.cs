string? readResult; //initialize a nullable string to collect user input
string stringEntd = ""; //initialze a string variable to store the user input 
int stringtoNum = 0; //initialze an integer variable to hold the converted string
bool validEntry = false; //a boolean to validate each iteration
Console.WriteLine("Please enter a value between 5 and 10");

do
{
    readResult = Console.ReadLine(); //waits and collects user input
    if (readResult != null)  //as long as the user input is no longer void continue
     {stringEntd = readResult;} //store the user input in the string variable

    validEntry = int.TryParse(stringEntd, out stringtoNum);  //A method that coverts the string stored in stringEntd to numbers and stores it in stringtoNum

if (validEntry == true) //if the conversion succeeds
  {
    if (stringtoNum < 5 || stringtoNum > 10) //conditional to make sure its between 5 and 10
    {
        validEntry = false;
    Console.WriteLine($"You entered {stringtoNum} Please enter a value between 5 and 10");
    }
  }
    else
     {
        Console.WriteLine("You entered a wrong input");
        }

} while(validEntry == false);

 Console.WriteLine($"You entered {stringtoNum}, so your input is accepted");

