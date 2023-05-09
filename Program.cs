using Cafeteira;

MaquinaCafe Monica = new MaquinaCafe();

bool concluido = false;
ConsoleKeyInfo tecla;
float acucar;

do
{
    Console.WriteLine(@$"
============================
|   Como deseja seu cafe   |
|                          |
| (1) Cafe com acucar      |  
| (2) Cafe sem acucar      |  
| (0) fechar programa      |  
|                          |
============================
");
    tecla = Console.ReadKey(true);

    switch (tecla.Key)
    {
        case ConsoleKey.D1:
            Console.WriteLine($"Quanto acucar voce deseja? (em gramas)");
            acucar = float.Parse(Console.ReadLine());
            if (acucar <= 0)
            {
                acucar = 10;
            }
            Monica.FazerCafe(acucar);
            break;

        case ConsoleKey.D2:
            Monica.FazerCafe();
            break;

        case ConsoleKey.D0:
            Console.WriteLine($"Desligando....");
            concluido = true;
            Console.Clear();
            break;

        default:
            break;
    }
} while (concluido = false);