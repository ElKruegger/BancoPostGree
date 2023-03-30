using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // cria uma lista de objetos Pessoa
        List<Pessoa> pessoas = new List<Pessoa>() {
            new Pessoa() { Nome = "João", Idade = 25 },
            new Pessoa() { Nome = "Maria", Idade = 30 },
            new Pessoa() { Nome = "Pedro", Idade = 40 }
        };

        // consulta usando LINQ
        var resultado = from p in pessoas
                        where p.Idade > 25
                        select new { p.Idade, p.Nome };

       
                        
        

        // exibe o resultado da consulta
        foreach (var nome in resultado)
        {
            Console.WriteLine(nome);
        }
        Console.ReadKey();
    }

    
}

class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
}


