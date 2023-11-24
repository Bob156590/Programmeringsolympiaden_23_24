bool go = true;
int tt = 0;
int time = 0;
Console.WriteLine("Antal byggnader ?");
int n = int.Parse(Console.ReadLine());
int[] buildingOwned = new int[n];
Console.WriteLine("Kostnad av Megapickeln ?");
int megapickeln = int.Parse(Console.ReadLine());
int[,] pc = new int[n,2];
int[,] realPC = new int[n,2];
int[] sorter = new int[n];
for (int i = 0; i < n; i++){
    Console.WriteLine($"Produktionshastighet och pris för byggnad {i + 1} ?");
    string pC = Console.ReadLine();
    int[] stuff = Array.ConvertAll(pC.Split(' '), int.Parse);
    sorter[i] = stuff[0]; 
    pc[i,0] = stuff[0];
    pc[i,1] = stuff[1];
}
buildingOwned[n-1]++;
Array.Sort(sorter);
Array.Reverse(sorter);
for (int i = 0; i < sorter.Length; i++)
{
    for (int j = 0; j < pc.GetLength(0); j++){
        if(sorter[i] == pc[j, 0]){
            realPC[i,0] = pc[j, 0];
            realPC[i,1] = pc[j, 1];
        }
    }
}

while(go){
    int p = 0;
    int pp = 0;
    for(int i = 0; i < n; i++){
        p =  buildingOwned[i] * realPC[i,0];
        pp += p;
    }
    tt += pp;
    for(int i = 0; i < realPC.GetLength(0); i++){
        if(tt + pp >= megapickeln){
            break;
        }
        else if (tt >= realPC[i,1]){
            while(tt>= realPC[i,1]){
                tt -= realPC[i,1];
                buildingOwned[i]++;
            }
        }
    }
    if(tt >= megapickeln){
        go = false;
    }
    time++;
}
Console.WriteLine("Svar: " + time);
//Worst code i've made lol