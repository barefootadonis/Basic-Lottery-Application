lottery Monday = new lottery();
Random rng = new Random();
Monday.number1 = rng.Next(1, 51);
Monday.number2 = rng.Next(1, 51);
Monday.number3 = rng.Next(1, 51);
Monday.number4 = rng.Next(1, 51);

lottery Tuesday = new lottery();
Tuesday.number1 = rng.Next(1, 51);
Tuesday.number2 = rng.Next(1, 51);
Tuesday.number3 = rng.Next(1, 51);
Tuesday.number4 = rng.Next(1, 51);

lottery Wednesday = new lottery();
Wednesday.number1 = rng.Next(1, 51);
Wednesday.number2 = rng.Next(1, 51);
Wednesday.number3 = rng.Next(1, 51);
Wednesday.number4 = rng.Next(1, 51);

lottery Thursday = new lottery();
Thursday.number1 = rng.Next(1, 51);
Thursday.number2 = rng.Next(1, 51);
Thursday.number3 = rng.Next(1, 51);
Thursday.number4 = rng.Next(1, 51);

lottery Friday = new lottery();
Friday.number1 = rng.Next(1, 51);
Friday.number2 = rng.Next(1, 51);
Friday.number3 = rng.Next(1, 51);
Friday.number4 = rng.Next(1, 51);

lottery Saturday = new lottery();
Saturday.number1 = rng.Next(1, 51);
Saturday.number2 = rng.Next(1, 51);
Saturday.number3 = rng.Next(1, 51);
Saturday.number4 = rng.Next(1, 51);

lottery Sunday = new lottery();
Sunday.number1 = rng.Next(1, 51);
Sunday.number2 = rng.Next(1, 51);
Sunday.number3 = rng.Next(1, 51);
Sunday.number4 = rng.Next(1, 51);


string day = DayofWeek();
string choice = GameVersion();
int[] guesses = GuessedNumbers(day);
GenerateLotteryNumbers();
CheckPrize(guesses[0], guesses[1], guesses[2], guesses[3]);




string DayofWeek()
{
    // Get day of the week from user
    string day;
    Console.Write("What day of the week is it: ");
    while (true)
    {
        day = Console.ReadLine().ToLower();

        if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday" || day == "saturday" || day == "sunday")
        {
            return day;
            break;
        }
        else
        {
            Console.Write("Invalid day.\nPlease enter an actual day of the week: ");
        }

    }
}


string GameVersion()
{
    // Get game version choice from user
    string choice;
    Console.Write("Would you like to play the easy version or hard version for more money? ");
    while (true)
    {
        choice = Console.ReadLine().ToLower();

        if (choice == "easy" || choice == "hard")
        {

            // Explain rules based on user's choice
            if (choice == "easy")
            {
                Console.WriteLine("\nIn the easy version, you win money for guessing the correct numbers, in any order. \nYou can win up to £250.");
            }
            else if (choice == "hard")
            {
                Console.WriteLine("\nIn the hard version, you win money for guessing the correct numbers in the correct order. \nYou can win up to £1,000,000.");
            }

            return choice;
            break;
        }
        else
        {
            Console.Write("Invalid choice.\nPlease enter 'easy' or 'hard': ");
        }

    }

}


int[] GuessedNumbers(string day)
{
    // Get user's lottery number guesses
    Console.WriteLine("\nGuess " + day + "'s lottery numbers. \nInput numbers between and including 1 and 50.");
    int guess1 = GetGuess("First number: ");
    int guess2 = GetGuess("Second number: ");
    int guess3 = GetGuess("Third number: ");
    int guess4 = GetGuess("Fourth number: ");
    return [guess1, guess2, guess3, guess4];
}

int GetGuess(string message)
{
    while (true)
    {
        Console.Write(message);
        int guess = Convert.ToInt32(Console.ReadLine());
        if (guess > 50 || guess < 1)
        {
            Console.WriteLine("Please enter a number between and including 1 and 50.");
        }
        else
        {
            return guess;
        }
    }
}

void GenerateLotteryNumbers()
{
    // Ensure all lottery numbers are unique for each day
    while (true)
    {
        if (Monday.number1 == Monday.number2 || Monday.number1 == Monday.number3 || Monday.number1 == Monday.number4)
        {
            Monday.number1 = rng.Next(1, 51);
        }
        else if (Monday.number2 == Monday.number3 || Monday.number2 == Monday.number4)
        {
            Monday.number2 = rng.Next(1, 51);
        }
        else if (Monday.number3 == Monday.number4)
        {
            Monday.number3 = rng.Next(1, 51);
        }
        else
        {
            break;
        }
    }

    while (true)
    {
        if (Tuesday.number1 == Tuesday.number2 || Tuesday.number1 == Tuesday.number3 || Tuesday.number1 == Tuesday.number4)
        {
            Tuesday.number1 = rng.Next(1, 51);
        }
        else if (Tuesday.number2 == Tuesday.number3 || Tuesday.number2 == Tuesday.number4)
        {
            Tuesday.number2 = rng.Next(1, 51);
        }
        else if (Tuesday.number3 == Tuesday.number4)
        {
            Tuesday.number3 = rng.Next(1, 51);
        }
        else
        {
            break;
        }
    }

    while (true)
    {
        if (Wednesday.number1 == Wednesday.number2 || Wednesday.number1 == Wednesday.number3 || Wednesday.number1 == Wednesday.number4)
        {
            Wednesday.number1 = rng.Next(1, 51);
        }
        else if (Wednesday.number2 == Wednesday.number3 || Wednesday.number2 == Wednesday.number4)
        {
            Wednesday.number2 = rng.Next(1, 51);
        }
        else if (Wednesday.number3 == Wednesday.number4)
        {
            Wednesday.number3 = rng.Next(1, 51);
        }
        else
        {
            break;
        }
    }

    while (true)
    {
        if (Thursday.number1 == Thursday.number2 || Thursday.number1 == Thursday.number3 || Thursday.number1 == Thursday.number4)
        {
            Thursday.number1 = rng.Next(1, 51);
        }
        else if (Thursday.number2 == Thursday.number3 || Thursday.number2 == Thursday.number4)
        {
            Thursday.number2 = rng.Next(1, 51);
        }
        else if (Thursday.number3 == Thursday.number4)
        {
            Thursday.number3 = rng.Next(1, 51);
        }
        else
        {
            break;
        }
    }

    while (true)
    {
        if (Friday.number1 == Friday.number2 || Friday.number1 == Friday.number3 || Friday.number1 == Friday.number4)
        {
            Friday.number1 = rng.Next(1, 51);
        }
        else if (Friday.number2 == Friday.number3 || Friday.number2 == Friday.number4)
        {
            Friday.number2 = rng.Next(1, 51);
        }
        else if (Friday.number3 == Friday.number4)
        {
            Friday.number3 = rng.Next(1, 51);
        }
        else
        {
            break;
        }
    }

    while (true)
    {
        if (Saturday.number1 == Saturday.number2 || Saturday.number1 == Saturday.number3 || Saturday.number1 == Saturday.number4)
        {
            Saturday.number1 = rng.Next(1, 51);
        }
        else if (Saturday.number2 == Saturday.number3 || Saturday.number2 == Saturday.number4)
        {
            Saturday.number2 = rng.Next(1, 51);
        }
        else if (Saturday.number3 == Saturday.number4)
        {
            Saturday.number3 = rng.Next(1, 51);
        }
        else
        {
            break;
        }
    }

    while (true)
    {
        if (Sunday.number1 == Sunday.number2 || Sunday.number1 == Sunday.number3 || Sunday.number1 == Sunday.number4)
        {
            Sunday.number1 = rng.Next(1, 51);
        }
        else if (Sunday.number2 == Sunday.number3 || Sunday.number2 == Sunday.number4)
        {
            Sunday.number2 = rng.Next(1, 51);
        }
        else if (Sunday.number3 == Sunday.number4)
        {
            Sunday.number3 = rng.Next(1, 51);
        }
        else
        {
            break;
        }
    }


    // Reveal lottery numbers for the chosen day
    while (true)
    {
        if (day == "monday")
        {
            Console.WriteLine( $"Monday's lottery numbers are: {Monday.number1}, {Monday.number2}, {Monday.number3}, {Monday.number4}");
            break;
        }
        else if (day == "tuesday")
        {
            Console.WriteLine($"Tuesday's lottery numbers are: {Tuesday.number1}, {Tuesday.number2}, {Tuesday.number3}, {Tuesday.number4}");
            break;
        }
        else if (day == "wednesday")
        {
            Console.WriteLine($"Wednesday's lottery numbers are: {Wednesday.number1}, {Wednesday.number2}, {Wednesday.number3}, {Wednesday.number4}");
            break;
        }
        else if (day == "thursday")
        {
            Console.WriteLine($"Thursday's lottery numbers are: {Thursday.number1}, {Thursday.number2}, {Thursday.number3}, {Thursday.number4}");
            break;
        }
        else if (day == "friday")
        {
            Console.WriteLine($"Friday's lottery numbers are: {Friday.number1}, {Friday.number2}, {Friday.number3}, {Friday.number4}");
            break;
        }
        else if (day == "saturday")
        {
            Console.WriteLine($"Saturday's lottery numbers are: {Saturday.number1}, {Saturday.number2}, {Saturday.number3}, {Saturday.number4}");
            break;
        }
        else if (day == "sunday")
        {
            Console.WriteLine($"Sunday's lottery numbers are: {Sunday.number1}, {Sunday.number2}, {Sunday.number3}, {Sunday.number4}");
            break;
        }
    }    
}


void CheckPrize(int guess1, int guess2, int guess3, int guess4)
{
    // Determine prize based on number of correct guesses
    int correctGuesses = 0;
    int accurateGuesses = 0;




    //Easy version
   
    if (choice == "easy")
    {
        while (day == "monday")
        {
            if (guess1 == Monday.number1 || guess1 == Monday.number2 || guess1 == Monday.number3 || guess1 == Monday.number4)
            {
                correctGuesses++;
            }
            else if (guess2 == Monday.number1 || guess2 == Monday.number2 || guess2 == Monday.number3 || guess2 == Monday.number4)
            {
                correctGuesses++;
            }
            else if (guess3 == Monday.number1 || guess3 == Monday.number2 || guess3 == Monday.number3 || guess3 == Monday.number4)
            {
                correctGuesses++;
            }
            else if (guess4 == Monday.number1 || guess4 == Monday.number2 || guess4 == Monday.number3 || guess4 == Monday.number4)
            {
                correctGuesses++;
            }
            Console.WriteLine("You got " + correctGuesses + " correct!");
            break;
        }

        while (day == "tuesday")
        {
            if (guess1 == Tuesday.number1 || guess1 == Tuesday.number2 || guess1 == Tuesday.number3 || guess1 == Tuesday.number4)
            {
                correctGuesses++;
            }
            else if (guess2 == Tuesday.number1 || guess2 == Tuesday.number2 || guess2 == Tuesday.number3 || guess2 == Tuesday.number4)
            {
                correctGuesses++;
            }
            else if (guess3 == Tuesday.number1 || guess3 == Tuesday.number2 || guess3 == Tuesday.number3 || guess3 == Tuesday.number4)
            {
                correctGuesses++;
            }
            else if (guess4 == Tuesday.number1 || guess4 == Tuesday.number2 || guess4 == Tuesday.number3 || guess4 == Tuesday.number4)
            {
                correctGuesses++;
            }
            Console.WriteLine("You got " + correctGuesses + " correct!");
            break;
        }

        while (day == "wednesday")
        {
            if (guess1 == Wednesday.number1 || guess1 == Wednesday.number2 || guess1 == Wednesday.number3 || guess1 == Wednesday.number4)
            {
                correctGuesses++;
            }
            else if (guess2 == Wednesday.number1 || guess2 == Wednesday.number2 || guess2 == Wednesday.number3 || guess2 == Wednesday.number4)
            {
                correctGuesses++;
            }
            else if (guess3 == Wednesday.number1 || guess3 == Wednesday.number2 || guess3 == Wednesday.number3 || guess3 == Wednesday.number4)
            {
                correctGuesses++;
            }
            else if (guess4 == Wednesday.number1 || guess4 == Wednesday.number2 || guess4 == Wednesday.number3 || guess4 == Wednesday.number4)
            {
                correctGuesses++;
            }
            Console.WriteLine("You got " + correctGuesses + " correct!");
            break;
        }

        while (day == "thursday")
        {
            if (guess1 == Thursday.number1 || guess1 == Thursday.number2 || guess1 == Thursday.number3 || guess1 == Thursday.number4)
            {
                correctGuesses++;
            }
            else if (guess2 == Thursday.number1 || guess2 == Thursday.number2 || guess2 == Thursday.number3 || guess2 == Thursday.number4)
            {
                correctGuesses++;
            }
            else if (guess3 == Thursday.number1 || guess3 == Thursday.number2 || guess3 == Thursday.number3 || guess3 == Thursday.number4)
            {
                correctGuesses++;
            }
            else if (guess4 == Thursday.number1 || guess4 == Thursday.number2 || guess4 == Thursday.number3 || guess4 == Thursday.number4)
            {
                correctGuesses++;
            }
            Console.WriteLine("You got " + correctGuesses + " correct!");
            break;
        }

        while (day == "friday")
        {
            if (guess1 == Friday.number1 || guess1 == Friday.number2 || guess1 == Friday.number3 || guess1 == Friday.number4)
            {
                correctGuesses++;
            }
            else if (guess2 == Friday.number1 || guess2 == Friday.number2 || guess2 == Friday.number3 || guess2 == Friday.number4)
            {
                correctGuesses++;
            }
            else if (guess3 == Friday.number1 || guess3 == Friday.number2 || guess3 == Friday.number3 || guess3 == Friday.number4)
            {
                correctGuesses++;
            }
            else if (guess4 == Friday.number1 || guess4 == Friday.number2 || guess4 == Friday.number3 || guess4 == Friday.number4)
            {
                correctGuesses++;
            }
            Console.WriteLine("You got " + correctGuesses + " correct!");
            break;
        }

        while (day == "saturday")
        {
            if (guess1 == Saturday.number1 || guess1 == Saturday.number2 || guess1 == Saturday.number3 || guess1 == Saturday.number4)
            {
                correctGuesses++;
            }
            else if (guess2 == Saturday.number1 || guess2 == Saturday.number2 || guess2 == Saturday.number3 || guess2 == Saturday.number4)
            {
                correctGuesses++;
            }
            else if (guess3 == Saturday.number1 || guess3 == Saturday.number2 || guess3 == Saturday.number3 || guess3 == Saturday.number4)
            {
                correctGuesses++;
            }
            else if (guess4 == Saturday.number1 || guess4 == Saturday.number2 || guess4 == Saturday.number3 || guess4 == Saturday.number4)
            {
                correctGuesses++;
            }
            Console.WriteLine("You got " + correctGuesses + " correct!");
            break;
        }

        while (day == "sunday")
        {
            if (guess1 == Sunday.number1 || guess1 == Sunday.number2 || guess1 == Sunday.number3 || guess1 == Sunday.number4)
            {
                correctGuesses++;
            }
            else if (guess2 == Sunday.number1 || guess2 == Sunday.number2 || guess2 == Sunday.number3 || guess2 == Sunday.number4)
            {
                correctGuesses++;
            }
            else if (guess3 == Sunday.number1 || guess3 == Sunday.number2 || guess3 == Sunday.number3 || guess3 == Sunday.number4)
            {
                correctGuesses++;
            }
            else if (guess4 == Sunday.number1 || guess4 == Sunday.number2 || guess4 == Sunday.number3 || guess4 == Sunday.number4)
            {
                correctGuesses++;
            }
            Console.WriteLine("You got " + correctGuesses + " correct!");
            break;
        }
        if (correctGuesses == 0)
        {
            Console.WriteLine("Congratulations, you've won nothing.");
        }
        else if (correctGuesses == 1)
        {
            Console.WriteLine("Congratulations, you've won £1.");
        }
        else if (correctGuesses == 2)
        {
            Console.WriteLine("Congratulations, you've won £5.");
        }
        else if (correctGuesses == 3)
        {
            Console.WriteLine("Congratulations, you've won £50.");
        }
        else if (correctGuesses == 4)
        {
            Console.WriteLine("Congratulations, you've won £250");
        }
    }








    // Hard Version

    if (choice == "hard")
    {
        while (day == "monday")
        {
            if (guess1 == Monday.number1)
            {
                accurateGuesses++;
            }
            else if (guess2 == Monday.number2)
            {
                accurateGuesses++;
            }
            else if (guess3 == Monday.number3)
            {
                accurateGuesses++;
            }
            else if (guess4 == Monday.number4)
            {
                accurateGuesses++;
            }
            Console.WriteLine("You got " + accurateGuesses + " correct!");
            break;
        }

        while (day == "tuesday")
        {
            if (guess1 == Tuesday.number1)
            {
                accurateGuesses++;
            }
            else if (guess2 == Tuesday.number2)
            {
                accurateGuesses++;
            }
            else if (guess3 == Tuesday.number3)
            {
                accurateGuesses++;
            }
            else if (guess4 == Tuesday.number4)
            {
                accurateGuesses++;
            }
            Console.WriteLine("You got " + accurateGuesses + " correct!");
            break;
        }

        while (day == "wednesday")
        {
            if (guess1 == Wednesday.number1)
            {
                accurateGuesses++;
            }
            else if (guess2 == Wednesday.number2)
            {
                accurateGuesses++;
            }
            else if (guess3 == Wednesday.number3)
            {
                accurateGuesses++;
            }
            else if (guess4 == Wednesday.number4)
            {
                accurateGuesses++;
            }
            Console.WriteLine("You got " + accurateGuesses + " correct!");
            break;
        }

        while (day == "thursday")
        {
            if (guess1 == Thursday.number1)
            {
                accurateGuesses++;
            }
            else if (guess2 == Thursday.number2)
            {
                accurateGuesses++;
            }
            else if (guess3 == Thursday.number3)
            {
                accurateGuesses++;
            }
            else if (guess4 == Thursday.number4)
            {
                accurateGuesses++;
            }
            Console.WriteLine("You got " + accurateGuesses + " correct!");
            break;
        }

        while (day == "friday")
        {
            if (guess1 == Friday.number1)
            {
                accurateGuesses++;
            }
            else if (guess2 == Friday.number2)
            {
                accurateGuesses++;
            }
            else if (guess3 == Friday.number3)
            {
                accurateGuesses++;
            }
            else if (guess4 == Friday.number4)
            {
                accurateGuesses++;
            }
            Console.WriteLine("You got " + accurateGuesses + " correct!");
            break;
        }

        while (day == "saturday")
        {
            if (guess1 == Saturday.number1)
            {
                accurateGuesses++;
            }
            else if (guess2 == Saturday.number2)
            {
                accurateGuesses++;
            }
            else if (guess3 == Saturday.number3)
            {
                accurateGuesses++;
            }
            else if (guess4 == Saturday.number4)
            {
                accurateGuesses++;
            }
            Console.WriteLine("You got " + accurateGuesses + " correct!");
            break;
        }

        while (day == "sunday")
        {
            if (guess1 == Sunday.number1)
            {
                accurateGuesses++;
            }
            else if (guess2 == Sunday.number2)
            {
                accurateGuesses++;
            }
            else if (guess3 == Sunday.number3)
            {
                accurateGuesses++;
            }
            else if (guess4 == Sunday.number4)
            {
                accurateGuesses++;
            }
            Console.WriteLine("You got " + accurateGuesses + " correct!");
            break;
        }

        if (accurateGuesses == 0)
        {
            Console.WriteLine("Congratulations, you've won nothing.");
        }
        else if (accurateGuesses == 1)
        {
            Console.WriteLine("Congratulations, you've won £1000.");
        }
        else if (accurateGuesses == 2)
        {
            Console.WriteLine("Congratulations, you've won £25,000.");
        }
        else if (accurateGuesses == 3)
        {
            Console.WriteLine("Congratulations, you've won £500,000.");
        }
        else if (accurateGuesses == 4)
        {
            Console.WriteLine("Congratulations, you've won £1,000,000");
        }
    }
}




class lottery
{
    public int number1;
    public int number2;
    public int number3;
    public int number4;
}