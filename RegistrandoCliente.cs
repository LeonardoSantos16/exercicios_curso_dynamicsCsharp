/*
------------Descrição------------
Imagine que você está desenvolvendo uma aplicação de registro de novos clientes para uma empresa que utiliza o Dynamics 365 para gerenciar seus relacionamentos com os clientes. O objetivo é criar uma ferramenta simples que permita aos funcionários registrar informações dos clientes no sistema Dynamics 365 de forma eficaz.

------------Entrada-------------
A entrada será realizada através do Console.ReadLine(). O programa solicitará ao usuário que insira as seguintes informações do cliente, uma por vez:
Nome do cliente.
Endereço de e-mail do cliente.
Número de telefone do cliente.
Após cada entrada, o programa perguntará se o usuário deseja continuar registrando clientes (digitando "S" para sim ou "N" para não).

-----------Saída-----------
A saída deverá:
Exibir as informações do cliente registrado, incluindo nome, endereço de e-mail e número de telefone.
Se o usuário decidir parar de registrar clientes, o programa exibirá as informações de todos os clientes registrados até o momento. 
*/
public class RegistrandoCliente
{
    public static void Registrar()
    {
        List<string> clientes = new List<string>();
        string clienteInfo;
        while (true)
            {
                string nome = Console.ReadLine();
                string email = Console.ReadLine();
                string telefone = Console.ReadLine();

                // Registra o cliente (simulação)
                clienteInfo = $"{nome}, {email}, {telefone}";
                clientes.Add(clienteInfo);

                string continuar = Console.ReadLine();
                if(continuar == "S"){
                    continue;
                }else{
                    break;
                }
            }
            foreach (string var in clientes){
                    Console.WriteLine(var);
            }
    }
}
