bool go = true;
char rent = ' ';
int curenttimes = 0;
int willCut = 0;
int svar = 0;
Console.WriteLine("Björns protein ?");
string protein = Console.ReadLine();
Console.WriteLine("K ?");
int cut = int.Parse(Console.ReadLine());
for(int i = 0; i < protein.Length; i++){
    int times = 0;
    foreach(char s in protein){
        if (s == protein[i]){
            go = true;
            continue;
        }
        else if (go){
            times++;
            go = false;
        }
    }
    if(times > curenttimes){
        rent = protein[i];
    }
}
int remove = 0;
int start= 0;
go = true;
while(go){
    int check = 0;
    foreach(char s in protein){
        if(s == rent){
            check++;
        }
    }
    if(check == protein.Length){
        go = false;
    }
    else if(protein[remove] == rent && protein[start] == rent){
        start++;
        remove++;
    }
    else if(protein[remove] != rent && willCut < cut){
        remove++;
        willCut++;
    }
    else if(protein[remove] == rent || willCut <= cut){
        string eyes = protein.Remove(protein[start], willCut);
        svar++;
    }
}
Console.WriteLine(svar);