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
public class LM
{
    public char A;
    public char B;
    public double C;
}
public class LMB
{
    public List<LM> data = new List<LM>();
    public LMB(string question)
    {
        var r = new Random();
        var ca = question.ToCharArray();
        for (int i = 0; i < ca.Length-1; i++)
        {
            data.Add(new LM { A = ca[i], B = ca[i + 1], C = r.NextDouble() });
        }
    }
}