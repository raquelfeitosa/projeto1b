﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1b
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Pessoa aluno;
            aluno = new Pessoa();
            Pessoa professor = new Pessoa();
            aluno.nome = "Huiguinho";
            professor.nome = "Prof.Pardal";
            Console.WriteLine("Aluno:" + aluno.nome);
            Console.WriteLine("Prof:" + professor.nome);
            Console.ReadKey();

        }
    }
}
