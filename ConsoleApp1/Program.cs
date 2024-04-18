
      int currentHour = 10;


      if (currentHour >= 11 || currentHour <= 14)
      {
            Console.WriteLine("Time for lunch!");
}


        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
}


//bonus

        int x = 5;

        while (x > 0)
        {
            Console.WriteLine(x);
            x--;
}


        string[] daysOfWeek = { "Sunday","Monday", "Tuesday", "Wednesday", "Thursday", "Friday","Saturday" };

       
        foreach (string day in daysOfWeek)
        {
            Console.WriteLine(day);
}

        int[] numbers = { 1, 2, 3, 4, 5 , 6,7};

        int sum = 0;

        
        foreach (int num in numbers)
        {
            sum += num;
        }

        
        Console.WriteLine("The sum of the numbers is: " + sum);


