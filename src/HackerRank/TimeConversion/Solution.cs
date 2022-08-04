namespace TimeConversion
{
    public static class Solution
    {
        public static string Resolve(string s)
        {
            var validDate = DateTime.TryParse(s, out var date);

            if(!validDate)            
                PrintErrorMessage("Invalid date. Press any button to shut down...", 1);

            return date.ToString("HH:mm:ss");
        }

        private static void PrintErrorMessage(string message, int code)
        {
            Console.WriteLine(message);

            Console.ReadKey();

            Environment.Exit(code);
        }
    }
}
