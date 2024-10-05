string input = "29535123p4872348759764572364";
long sum = 0;

// Itererar genom varje tecken i strängen.
for (int i = 0; i < input.Length; i++)

{    // loopen som går i varje tecken som kommer efter (i) i strängen 

    for (int j = i + 1; j < input.Length; j++)
    { // kontrolera om i och j är siffror och om de är lika
      
        if (input[j] == input[i])
        {
            bool isRunning = true;

            // kontrollera om alla teckan mellan i och j också är siffror
            // 
            for (int k = i + 1; k < j; k++)
            {
                if (!char.IsDigit(input[k]) || input[k] == input[i])
                {
                    isRunning = false;
                    break;
                }
            }
            if (isRunning)
            {
                string number = input.Substring(i, j - i + 1);
                sum += long.Parse(number);
                // Print the input string with the valid number highlighted
                Console.ForegroundColor = ConsoleColor.Red;

                Console.Write(number);
                Console.ResetColor();
                Console.WriteLine(input.Replace(number, $"[{number}]"));





            }

        }
    }
}
Console.WriteLine("\nSumman " + sum);

