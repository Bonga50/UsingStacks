namespace UsingStacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string words = "today is tuesday";
            string results="";

            for (int i = words.Length-1; i >= 0; i--)
            {
                results += words[i];
            }
            Console.WriteLine(results);

            ReveseString(words);
            Console.Read(  );
        }

        public static void ReveseString(string normalWord) {

            Stack<char> mystack = new Stack<char>();

            for (int i = 0; i<normalWord.Length; i++)
            {
                mystack.Push(normalWord[i]);
            }
            foreach (char c in mystack) {
                Console.Write(c);
            }
        }
    }
}