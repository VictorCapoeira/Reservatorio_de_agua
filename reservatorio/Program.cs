using System.Threading.Tasks;
bool bomba = false;
bool boia1 = false;
bool boai2 = false;
bool boaiCaixa = false;
bool valvula = false;
double reservatorio = 0;
double caixa = 0;
if(reservatorio <= 900){
    while(reservatorio <= 900){
        Console.Clear();
        Console.WriteLine($"Enchendo reservatorio de água!: {reservatorio} Litros");
        reservatorio += 10;
        await Task.Delay(100);
        boia1 = reservatorio > 200 ? true : false;
        boai2 = reservatorio > 900 ? true : false;
        bomba = boia1 == true ? true : false;
        if(bomba == true){
            Console.WriteLine("Ligando bomba!");
            Console.WriteLine($"Enchendo caixa de água!: {caixa} Litros");
            caixa += 5;
            reservatorio -= 5;
        }
        
    }
}
