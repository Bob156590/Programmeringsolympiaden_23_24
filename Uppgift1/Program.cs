Console.WriteLine("Ordet ?");
string ord = Console.ReadLine();
Console.WriteLine("Antal Upprepningar ?");
int upprepningar = int.Parse(Console.ReadLine());

for(int i = 0; i < upprepningar; i++){
    Console.Write(ord);
}