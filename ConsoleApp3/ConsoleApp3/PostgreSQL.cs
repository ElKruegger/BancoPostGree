using Dapper;
using Npgsql;

namespace ConsoleApp3
{
    /// <summary>
    /// Classe que provê acesso ao bando de dados relacional
    /// </summary>
    public static class PostgreSQL
    {
        public static NpgsqlConnection Connection()
        {
            return new NpgsqlConnection("User ID=postgres;Password=23303343;Host=localhost;Port=5432;Database=Bank;");
        }

        public static bool TestConnection()
        {
            try
            {
                Connection().Query("select version()");
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static int InsertObj(Account account)
        {
            var query = @"insert into account (name, saldo, age) values (@name, @saldo, @age) RETURNING  id";
            var result = Connection().Query<int>(query, new
            {
                name = account.Name,    
                saldo = account.Saldo,
                age = account.Age
            }).FirstOrDefault();
            return result;
        }
        public static bool UpdateObj(Account account)
        {
            var query = @"update account set name = @name, saldo = @saldo, age = @age where id = @id";
            var result = Connection().Execute(query, new
            {
                id = account.Id,    
                name = account.Name,
                saldo = account.Saldo,
                age = account.Age
            });
            return result > 0;
        }
        public static List<Account> ListAccounts()
        {
            var query = @"select * from account";
            var list = Connection().Query<Account>(query).ToList();
            return list;
        }
    }
}
