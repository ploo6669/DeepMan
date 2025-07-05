// See https://aka.ms/new-console-template for more information

while (true)
{
    var input = Console.ReadLine();

    Console.WriteLine(Answer(input));
}
string Answer(string question)
{
    return "the answer is "+question;
}
