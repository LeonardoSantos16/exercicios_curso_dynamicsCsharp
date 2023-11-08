/*
----------------Descrição--------------
Você está desenvolvendo uma ferramenta para criar uma lista de clientes no sistema CRM. 
A ferramenta permite ao usuário definir o tamanho da lista e, em seguida, inserir os nomes dos clientes.

---------------Funcionalidades---------
O programa solicitará ao usuário que defina o tamanho da lista de clientes.
Em seguida, o usuário será solicitado a inserir o nome de cada cliente na lista.
Depois de coletar os nomes, o programa usará um loop foreach para exibir todos os nomes dos clientes na lista.
Instruções:
Solicite ao usuário que insira o tamanho da lista de clientes.
Crie uma lista vazia para armazenar os nomes dos clientes.
Use um loop for para coletar os nomes dos clientes de acordo com o tamanho definido.
Use um loop foreach para exibir todos os nomes dos clientes na lista.

----------------Entrada-------------
A entrada será realizada através do Console.ReadLine(). O programa solicitará ao usuário que insira as seguintes informações:
O tamanho da lista de clientes.
Os nomes dos clientes, um por vez, conforme solicitado

----------------Saída---------------
A saída deverá retornar:
A lista de nomes dos clientes inseridos.
*/

public class ListaContatos
{
    public static void Listar()
    {
        int tamanhoLista = int.Parse(Console.ReadLine());

        List<string> listaClientes = new List<string>();

        for (int i = 1; i <= tamanhoLista; i++)
            {
                listaClientes.Add(Console.ReadLine());     
            }

        Console.WriteLine("\nLista de Contatos:");

        foreach (string cliente in listaClientes){
            var index = listaClientes.IndexOf(cliente );
            Console.WriteLine($"{index + 1}. {cliente}");
        }
    }
}
        
