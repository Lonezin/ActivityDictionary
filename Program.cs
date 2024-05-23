namespace MyNamespace;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> sla = new Dictionary<string, int>();

        System.Console.WriteLine("Enter file full path: ");
        string path = System.Console.ReadLine();
        try
        {
            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(",");
                    string name = line[0];
                    int votos = int.Parse(line[1]);
                    if (sla.ContainsKey(name))
                    {
                        sla[name] += votos;
                    }
                    else
                    {
                        sla[name] = votos;
                    }
                }
            }

            foreach (var vs in sla)
            {
                System.Console.WriteLine(vs.Key + " - " + vs.Value);
            }
        }
        catch (IOException e)
        {
            System.Console.WriteLine(e);
        }
    }
}
