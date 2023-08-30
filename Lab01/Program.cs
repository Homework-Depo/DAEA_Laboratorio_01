// See https://aka.ms/new-console-template for more information
using Lab01;

CajeroAutomatico cajeroAutomatico = new CajeroAutomatico();
cajeroAutomatico.Balance = 15000.50;
cajeroAutomatico.SecurityPIN = 12345;

bool toggle = true;

while (toggle)
{
    PrintMenu();
    string op = Console.ReadLine();

    switch (op)
    {
        case "1":
            Console.WriteLine($"Saldo: {cajeroAutomatico.ConsultarSaldo()} \n");
            continue;
        case "2":
            Console.Write("Ingrese el monto a depositar: S/. ");

            try
            {
                double ammount;
                ammount = Convert.ToDouble(Console.ReadLine());
                if (ammount < 1)
                {
                    Console.WriteLine("Monto ingresado inválido! \n");
                    break;
                }

                cajeroAutomatico.AddBalance(ammount);
            } catch (Exception ex)
            {
                Console.WriteLine("Monto ingresado inválido! \n");
                break;
            }
            break;
        case "3":
            Console.Write("Ingrese el monto a retirar: S/. ");
            try
            {
                double ammount;
                ammount = Convert.ToDouble(Console.ReadLine());
                if (ammount < 1 || ammount > cajeroAutomatico.Balance)
                {
                    Console.WriteLine("Monto ingresado inválido! \n");
                    break;
                }

                cajeroAutomatico.RemoveBalance(ammount);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Monto ingresado inválido! \n");
                break;
            }
            break;
        case "4":
            Console.Write("Ingresa tu PIN actual: ");
            try
            {
                int cpin = Convert.ToInt32(Console.ReadLine());

                if (cpin != cajeroAutomatico.SecurityPIN)
                {
                    Console.WriteLine("Error! PIN Inválido.");
                    break;
                }

                Console.Write("Ingresa un nuevo PIN: ");
                int npin = Convert.ToInt32(Console.ReadLine());

                cajeroAutomatico.ChangeSecurityPIN(npin);

                Console.WriteLine("PIN Cambiado!");
            } catch (Exception ex)
            {
                Console.WriteLine("Error! PIN Inválido.");
            }

            break;
        case "5":
            toggle = false;
            break;
        default:
            Console.WriteLine(" ");
            continue;
    }
}

void PrintMenu()
{
    Console.WriteLine("1. Consultar Saldo \n2. Depositar Fondos \n3. Retirar Efectivo \n4. Cambiar PIN");
    Console.Write("Ingrese una opción: ");
}