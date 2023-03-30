using ConsoleApp3;


Console.Write("Deseja criar uma conta? (s/n/l)");
var resp = Console.ReadLine();
if (resp.Trim() == "n")
{
    return;
}
else if (resp.Trim() == "s")
{
    //Criando o objeto
    var account = new Account();

    Console.Write("Digite seu nome: ");
    account.Name = Console.ReadLine();

    Console.Write("Digite sua idade: ");
    account.Age = Convert.ToInt32(Console.ReadLine());

    Console.Write("Digite seu extrato bancario: ");
    account.Saldo = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("--------------------------------");
    Console.WriteLine("Suas informações: ");
    Console.WriteLine("Nome: " + account.Name);
    Console.WriteLine("Idade: " + account.Age);
    Console.WriteLine("Extrato: " + account.Saldo);
    Console.WriteLine("--------------------------------");

    //Adiciondo no banco
    var id = PostgreSQL.InsertObj(account);
    account.Id = id;

    Console.Write("Deseja fazer algo? (s/n)");

    var respsla = Console.ReadLine().Trim() == "s" ? true : false;
    while (respsla)
    {
        Console.Write("Oque vc quer fazer? (d/e)");
        var respAction = Console.ReadLine();
        if (respAction.Trim() == "e")
        {
            Console.Write("Digite um valor: ");
            var price = Convert.ToDouble(Console.ReadLine());
            if (account.Saldo > price)
            {
                account.Pay(price);
            }
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Suas informações: ");
            Console.WriteLine("Nome: " + account.Name);
            Console.WriteLine("Idade: " + account.Age);
            Console.WriteLine("Extrato: " + account.Saldo);
            Console.WriteLine("--------------------------------");
            PostgreSQL.UpdateObj(account);

        }
        else
        {
            Console.Write("Digite um valor: ");
            var price = Convert.ToDouble(Console.ReadLine());
            account.Receber(price);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Suas informações: ");
            Console.WriteLine("Nome: " + account.Name);
            Console.WriteLine("Idade: " + account.Age);
            Console.WriteLine("Extrato: " + account.Saldo);
            Console.WriteLine("--------------------------------");
            PostgreSQL.UpdateObj(account);
        }
        Console.Write("Deseja fazer alguma coisa denovo? (s/n)");

        respsla = Console.ReadLine().Trim() == "s" ? true : false;
    }
    Console.ReadLine();
}
else
{

    var list = PostgreSQL.ListAccounts();
    Console.WriteLine("Listagem de contas: ");
    foreach (var item in list)
    {
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Id: " + item.Id);
        Console.WriteLine("Nome: " + item.Name);
        Console.WriteLine("Idade: " + item.Age);
        Console.WriteLine("Extrato: " + item.Saldo);
        Console.WriteLine("--------------------------------");
    }
}
