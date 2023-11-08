/*
--------------Descrição--------------
O Dynamics 365 é uma poderosa ferramenta de gerenciamento de relacionamento com o cliente usada por empresas para rastrear, 
armazenar e interagir com contatos, como clientes, leads e parceiros de negócios. 
Sua tarefa é criar um programa que permita a um usuário adicionar informações de contato ao Dynamics 365 e classificar esses contatos em categorias específicas

--------------Entrada------------
A entrada deverá ser realizada através do Console.ReadLine(), recebendo as seguintes informações:
Nome do contato (uma string).
Endereço de e-mail do contato (uma string).
Número de telefone do contato (uma string).

--------------Saída-------------
A saída deverá retornar um texto informando:
A Confirmação de que o contato foi adicionado com sucesso.
Exibição das informações do contato, incluindo nome, endereço de e-mail e número de telefone.
*/

public class GerenciamentoContatos{
    public static void Gerenciar()
    {
        string nome = Console.ReadLine();
        string email = Console.ReadLine();
        string telefone = Console.ReadLine();

        Console.WriteLine($"Contato adicionado! \nNome: {nome} \nE-mail: {email} \nTel: {telefone}");
    }
}
