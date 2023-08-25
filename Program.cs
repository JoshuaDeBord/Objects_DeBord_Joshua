namespace Objects_DeBord_Joshua
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // creates a new Computer object. brand is apple. the type is all-in-one, and it is true
            Computer myComputer = new("Apple", "All-in-One", true);
            //Create an IBootUp object that is assigned the computer class
            IBootUp myBootUp = myComputer;
            Console.WriteLine(myComputer.Equals(myBootUp));

            // creates a new OtherComputer object. brand is apple. the type is all-in-one, and it is true
            Computer myOtherComputer = new("Apple", "All-in-One", true);
            Console.WriteLine(myComputer.Equals(myOtherComputer));

            string myString = myComputer.ToString(); //makes a string called myString. equals the same as MyComputer
            string myOtherString = myString;

            myString = "hi"; //updates the myString to "hi"

            Console.WriteLine(myString);//writes myString to the console
            Console.WriteLine(myOtherString); //writes myOtherString to the console

            Console.WriteLine(myString == myComputer.ToString()); //writes myString is equivalant to myComputer to the console
            Console.WriteLine(myString == myOtherComputer.ToString()); //writes myString is eqivalant to myOtherComputer to the console

            Console.WriteLine(myComputer.GetType());//Writes to the console the type of myComputer
            Console.WriteLine(myBootUp.GetType());//Writes to the console the type of myOtherComputer

            myOtherComputer.PowerOnOff();//turns off myothercomputer

            Console.WriteLine(myString == myOtherComputer.ToString());
            Console.WriteLine(myString);//writes to the console myString
            Console.WriteLine(myOtherComputer.ToString());//Writes to the console myOtherComputer

            Console.WriteLine(myString.Contains('i'));

            Console.WriteLine(myString.ToUpper());//makes myString all caps permantelly and prints the results

        }
    }
}