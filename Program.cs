class TestClass
{
    static void Main(string[] args)
    {
        double amount, total_amount, tax;
        Console.WriteLine("Enter the minutes used:");
        string? input = Console.ReadLine();

        int units = Convert.ToInt32(input);

        switch (units <= 200)
        {
            case true:
                amount = units * 0.25;
                break;
            case false:
            // units between 201 - 500
                switch (units <= 500)
                {
                    case true:
                        amount = 50 + (units - 200) * 0.45;
                        break;
                    case false:
                    // units > 500
                        amount = 50 + 135;
                        break;
                }
                break;
        }
        tax = amount * 0.13;
        total_amount = amount + tax;
        // cout << "Your total bill is $" << total_amount;
        Console.WriteLine("Total tax: {0}", tax);
        Console.WriteLine("Total charge: {0}", total_amount);
    }
}