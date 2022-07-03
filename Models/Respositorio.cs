using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuPrimeiroProjeto.Models
{
    public class Repositorio
    {
        private static List<Resposta> respostas = new List<Resposta>();
        public static IEnumerable<Resposta> Respostas { get { return respostas; } }
        public static void AdicionarResposta(Resposta resposta)
        {
            respostas.Add(resposta);
        }

        static Repositorio()
        {
            respostas.Add(new Resposta()
            {
                Nome = "Anna",
                Email = "anna@gmail.com",
                Sim = true
            });
            respostas.Add(new Resposta()
            {
                Nome = "Laura",
                Email = "laura@gmail.com",
                Sim = true
            });
            respostas.Add(new Resposta()
            {
                Nome = "Nancy",
                Email = "nancy@gmail.com",
                Sim = true
            });
            respostas.Add(new Resposta()
            {
                Nome = "Will",
                Email = "will@gmail.com",
                Sim = false
            });
            respostas.Add(new Resposta()
            {
                Nome = "Eleven",
                Email = "eleven@gmail.com",
                Sim = true
            });
            respostas.Add(new Resposta()
            {
                Nome = "Mike",
                Email = "mike@gmail.com",
                Sim = false
            });
        }
    }
}
