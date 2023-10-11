
using PickRandomCards;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Скільки карт ти хочеш взяти?");
        string answer = Console.ReadLine();
        if (int .TryParse(answer, out int numberOfCards))
        {
            string[] result = new string[numberOfCards];
            result = CardPicker.PickSomeCard(numberOfCards);
            foreach (string card in result)
            {
                Console.WriteLine(card);
            }
        }
        else
        {
            Console.WriteLine("ТИ НЕ ВКАЗАВ ЧИСЛО!!!!");
        }
    }
}