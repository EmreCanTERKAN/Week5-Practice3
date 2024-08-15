List<string> kahve = new List<string>();

kahve.Add("Mocha");
kahve.Add("Latte");
kahve.Add("Esperesso");
kahve.Add("Americano");


for (int i = 0; i < kahve.Count; i++)
{
    Console.WriteLine($"Kahve {i+1}: {kahve[i]} ");
}