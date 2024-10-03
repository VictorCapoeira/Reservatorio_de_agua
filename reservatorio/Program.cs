using System.Threading.Tasks;
bool bomba = false;
bool boia1 = false;
bool boai2 = false;
bool boaiCaixa = false;
bool valvula = false;

string exibir, exibir2;
exibir = boai2 == false ? "Enchendo o reservatorio de água!" : "O reservatorio de água está cheio!";
Console.WriteLine(exibir);

exibir2 = boia1 && boaiCaixa == false ? "Enchendo a caixa de água" : "A caixa de água está cheia";
Console.WriteLine(exibir2);




