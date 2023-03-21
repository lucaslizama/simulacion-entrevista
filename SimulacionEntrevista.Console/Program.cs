Challenge challenge = new Challenge();

Console.WriteLine("Pregunta 1");
Console.WriteLine();
string p0 = challenge.ListClientIds();
Console.WriteLine(p0);
Console.WriteLine();

Console.WriteLine("Pregunta 2");
Console.WriteLine();
string p1 = challenge.ListClientIdsSortByTaxNumber();
Console.WriteLine(p0);
Console.WriteLine();

Console.WriteLine("Pregunta 3");
Console.WriteLine();
string p2 = challenge.SortClientsTotalBalances();
Console.WriteLine(p0);
Console.WriteLine();

Console.WriteLine("Pregunta 4");
Console.WriteLine();
string p3 = challenge.BanksClientsRutNumbers();
Console.WriteLine(p0);
Console.WriteLine();

Console.WriteLine("Pregunta 5");
Console.WriteLine();
string p4 = challenge.RichClientsBalances();
Console.WriteLine(p0);
Console.WriteLine();

Console.WriteLine("Pregunta 6");
Console.WriteLine();
string p5 = challenge.BanksRankingByTotalBalance();
Console.WriteLine(p0);
Console.WriteLine();

Console.WriteLine("Pregunta 7");
Console.WriteLine();
string p6 = challenge.BanksFidelity();
Console.WriteLine(p0);
Console.WriteLine();

Console.WriteLine("Pregunta 8");
Console.WriteLine();
string p7 = challenge.BanksPoorClients();
Console.WriteLine(p0);
Console.WriteLine();

Console.WriteLine("Pregunta 9");
Console.WriteLine();
string p8 = challenge.NewClientRanking();
Console.WriteLine(p0);
Console.WriteLine();