using Vypocty;
double a = Double.Parse(Console.ReadLine());
double b = Double.Parse(Console.ReadLine());
double c = Double.Parse(Console.ReadLine());
Kvádr jmenoObjektu = new Kvádr(a, b, c);

Console.WriteLine(jmenoObjektu.VypocetObjemu());
Console.WriteLine(jmenoObjektu.VypocetPovrchu());
Console.WriteLine(jmenoObjektu.VypocetTelesUhlo());
Console.WriteLine(jmenoObjektu.VypocetStenUhlo());