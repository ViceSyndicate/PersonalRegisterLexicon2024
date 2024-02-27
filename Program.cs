namespace PersonalRegisterLexicon2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                string[] wordList = line.Split(' ');
                if (wordList[0] == "Simon" && wordList[1] == "says")
                {
                    wordList[0] = "";
                    wordList[1] = "";

                    for (int i = 0; i < wordList.Length; i++)
                    {
                        Console.Write(wordList[i] + " ");
                    }
                }
            }
        }
    }
}
