using System.Threading.Tasks;
bool bomba = false;
int boia1, boia2 ,boaiCaixa;
bool valvula = false;

Console.WriteLine("Insira o estado da boia 1 (0 desligado ou 1 ligado)");
boia1 = int.Parse(Console.ReadLine());
Console.WriteLine("Insira o estado da boia 2 (0 desligado ou 1 ligado)");
boia2 = int.Parse(Console.ReadLine());
Console.WriteLine("Insira o estado da boia da caixa (0 desligado ou 1 ligado)");
boaiCaixa = int.Parse(Console.ReadLine());

if((boia1 == 0 && boia2 == 0) || (boia1 == 1 && boia2 == 0)){
    valvula = true;
    Console.WriteLine("Enchendo o reservatorio!");
}else if(boia1 == 1 && boia2 == 1){
    Console.WriteLine("Reservatorio cheio!");
}
else if(boia1 == 0 && boia2 == 1){
    Console.WriteLine("Existe um problema nas boias");
}

if((boia1 == 1 && boaiCaixa == 0)){
    bomba = true;
    Console.WriteLine("Enchendo a caixa!");
}else if(boaiCaixa == 1){
    Console.WriteLine("Caixa cheia!");
}else{
    Console.WriteLine("Caixa vazia");
}








