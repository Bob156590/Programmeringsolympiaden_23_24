bool go = true;
int startTriga = 1;
Console.WriteLine("N ?");
int tal = int.Parse(Console.ReadLine());
int svar = 0;
while(go){
    int triga = 0;
    triga += startTriga * (startTriga + 1) * (startTriga + 2);
    if(tal > triga){
        svar++;
    }
    else{
        go = false;
    }
    startTriga++;
}
Console.WriteLine($"Svar: {svar}");