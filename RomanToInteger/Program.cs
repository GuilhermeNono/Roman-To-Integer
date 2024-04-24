// See https://aka.ms/new-console-template for more information

using RomanToInteger;

bool isInLoop = true;

while (isInLoop)
{
    Console.Write("- ");
    var teste = Console.ReadLine();
    if (teste.Equals("Exit", StringComparison.CurrentCultureIgnoreCase))
    {
        isInLoop = false;
        continue;
    }
    Console.WriteLine("> {0}", new Solution().RomanToInt(teste));
}