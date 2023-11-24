Console.WriteLine("n ?");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("m ?");
int m = int.Parse(Console.ReadLine());
int l = 0;
List<char> lvar = new List<char>();

for (int i = 0; i < n; i++){
    Console.WriteLine($"Rad {i+1} ?");
    string namn = Console.ReadLine();
    if(namn.Length == m){
        foreach (char j in namn){
            if (j != '.'){
                lvar.Add(j);
            }
            l++;
        }
    }
}
foreach(char i in lvar){
    Console.Write(i);
}