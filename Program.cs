Boolean exit = false;

for (exit = false; !exit;)
{
    Console.WriteLine("--------------------------------\n" +
                      "Expense Tracker" + "\n" +
                      "--------------------------------\n");

    Console.WriteLine("1. Add Expense\r\n" +
                      "2. View Expenses\r\n" +
                      "3. Edit Expense\r\n" +
                      "4. Delete Expense\r\n" +
                      "5. Exit");

    //Input
    string choice = Console.ReadLine();

    if(int.TryParse(choice, out int result))
    {
        if (result < 1 || result > 5)
        {
            Console.WriteLine("--------------------------------\n" +
                              "Invalid option. Please try again.\n" +
                              "--------------------------------");
        }
        else
        {
            switch (result)
            {
                case 1:
                    // Code to add expense
                    Console.WriteLine("--------------------------------\n" +
                                      "Expense has been added successfully.\n" +
                                      "--------------------------------\n");
                    break;

                case 2:
                    // Code to view expenses
                    Console.WriteLine("--------------------------------\n" +
                                      "Expense has been viewed successfully.\n" +
                                      "--------------------------------\n");
                    break;

                case 3:
                    // Code to edit expense
                    Console.WriteLine("--------------------------------\n" +
                                      "Expense has been edited successfully.\n" +
                                      "--------------------------------\n");
                    break;

                case 4:
                    // Code to delete expense
                    Console.WriteLine("--------------------------------\n" +
                                      "Expense has been deleted successfully.\n" +
                                      "--------------------------------\n");
                    break;

                case 5:
                    // Code to exit the program
                    Console.WriteLine("--------------------------------\n" +
                                      "Program has been exited successfully.\n" +
                                      "--------------------------------\n");
                    exit = true;
                    break;
            }
        }
    }
    else
    {
        Console.WriteLine("--------------------------------\n" +
                          "Invalid option. Please try again.\n" +
                          "--------------------------------");
    }
    
}