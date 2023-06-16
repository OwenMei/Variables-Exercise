namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string dogName = "Fido";
            int dogAge = 4;
            char firstNameOfDog = 'F';
            bool likesTreats = true;
            double dogWeight = 4.9;
            decimal dogMaxSpeed = 16.22m;

            Console.WriteLine($"My dog is called {dogName}, he is {dogAge}." + 
                $" The first letter of his name is {firstNameOfDog} and it is "+
                $"{likesTreats} that he likes treats. He has just hit {dogWeight}"+
                $" pounds today and ran at me at {dogMaxSpeed} mph today");


        }
    }
}
