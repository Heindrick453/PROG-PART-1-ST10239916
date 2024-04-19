using System;

internal class Program
{
    private static void Main(string[] args)
    {
       Recipe recipe = new Recipe();
        while (true)
        {
            Console.WriteLine("=========");
            Console.WriteLine("Enter 1 to enter recipe details");
            Console.WriteLine("Enter 2 to Display Recipe");
            Console.WriteLine("Enter 3 to Scale Recipe");
            Console.WriteLine("Enter 4 to Reset quantity");
            Console.WriteLine("Enter 5 to Clear recipe");
            Console.WriteLine("Enter 6 to Exit");
            Console.WriteLine("=========");
            string ans = Console.ReadLine();    
            switch(ans)
            {
                case "1":
                    recipe.EnterData();
                    break;
                case "2":
                    recipe.RecipeDisplay();
                    break;
                case "3":
                    Console.WriteLine("Enter a scale of 0.5, 2 or 3");
                    double scale1= Convert.ToDouble(Console.ReadLine());
                    recipe.RecipeScale(scale1);
                    break;
                case "4":
                    recipe.ResetRecipe();
                    break;
                case "5":
                    recipe.ClearRecipe();
                    break;
                case "6":
                    Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine(" wrong value. please try again");
                    break;
            }
        }
    }
}
class Recipe
{
    private String[] Ingredients;
    private double[] amount;
    private String[] units;
    private String[] steps;

    public Recipe()
    {
        Ingredients = new String[0];
        amount = new double[0];
        units = new String[0];
        steps = new String[0];
    }
    public void EnterData()


    {
        Console.WriteLine("Enter number of ingredients");
        int ingnum = Convert.ToInt32(Console.ReadLine());

        Ingredients= new String[ingnum];
        amount = new double[ingnum];
        units = new String[ingnum];

        for(int i = 0; i< ingnum; i++)
        {
            Console.WriteLine($"Enter ingredients details#{i+1}:");
            Console.Write("Name");
            Ingredients[i] = Console.ReadLine();
            Console.Write("Quantity");
            amount[i] = Convert.ToDouble(Console.ReadLine());
            Console.Write("units of measurements");
            units[i] = Console.ReadLine();
        }
        Console.WriteLine("Enter Number of steps:");
        int stpNum = Convert.ToInt32(Console.ReadLine());
        steps = new String[stpNum];

        for (int a = 0; a<stpNum; a++) 
        {
            Console.Write($"Steps#{a+1}:");
            steps[a] = Console.ReadLine();
        }

    }

    public void RecipeDisplay()
    {
        Console.WriteLine("Ingredients:");
        for (int i = 0; i < Ingredients.Length; i++)
        {
            Console.WriteLine($"- {amount[i]}{units[i]} of {Ingredients[i]}");
        }
        Console.WriteLine("steps:");
        for(int a = 0; a < Ingredients.Length; a++)
        {
            Console.WriteLine($"-{steps[a]}");

        }
    }

    public void RecipeScale(double scale)
    {
        for (int i=0; i < amount.Length; i++)
        {
            amount[i] *= scale;
        }
    }

    public void ResetRecipe()
    {
        for (int i = 0; i<amount. Length; i++)
            {
            amount[i] /= 2;
        }
    }

    public void ClearRecipe()
    {
        //
        Ingredients = new String[0];
        amount = new double[0];
        units = new String[0];
        steps = new String[0];
    }


}