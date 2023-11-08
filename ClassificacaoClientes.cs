/*
--------------Descrição-------------
Você está desenvolvendo uma ferramenta de classificação de clientes para o CRM da sua empresa. 
A ferramenta atribuirá uma categoria de "cliente" ou "lead" com base em critérios específicos.

--------------Funcionalidades-------
O programa solicitará ao usuário que insira informações sobre um contato.
Com base no valor total das compras desse contato, o programa decidirá se ele deve ser classificado como "cliente" ou "lead".
Instruções:

Solicite ao usuário que insira o nome do contato.
Solicite ao usuário que insira o valor total das compras do contato.
Use uma estrutura condicional if e else para classificar o contato como "cliente" 
se o valor total das compras for maior ou igual a $500. Caso contrário, classifique-o como "lead".
Exiba a categoria atribuída ao contato (cliente ou lead).

---------------Entrada--------------
A entrada será realizada através do Console.ReadLine(). O programa solicitará ao usuário que insira as seguintes informações:
Nome do contato.
Valor total das compras do contato.
Após cada entrada, o programa perguntará se o usuário deseja continuar registrando clientes (digitando "S" para sim ou "N" para não).

----------------Saída---------------
A saida deverá retornar um texto informando as seguintes informações:
O Nome do contato
A categoria atribuída ao contato (se é cliente ou lead) com base no valor total das compras.
*/
public class ClassificacaoClientes
{
    public static void Classificar()
    {
        string nome = Console.ReadLine();
        
        double valorTotalCompras = double.Parse(Console.ReadLine());

        // TODO: Faça a verificação se o contato é um cliente ou lead
        string categoria;
        if (valorTotalCompras >= 500)
        {
          categoria = "CLIENTE";
        }
        else
        {
            categoria = "LEAD";    
        }
        
        Console.WriteLine($"{nome} foi classificado(a) como {categoria}");
                       
    }
}