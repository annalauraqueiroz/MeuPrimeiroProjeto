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
                Name = "Anna",
                Email = "anna@gmail.com",
                Yes = true
            });
            respostas.Add(new Resposta()
            {
                Name = "Laura",
                Email = "laura@gmail.com",
                Yes = true
            });
            respostas.Add(new Resposta()
            {
                Name = "Nancy",
                Email = "nancy@gmail.com",
                Yes = true
            });
            respostas.Add(new Resposta()
            {
                Name = "Will",
                Email = "will@gmail.com",
                Yes = false
            });
            respostas.Add(new Resposta()
            {
                Name = "Eleven",
                Email = "eleven@gmail.com",
                Yes = true
            });
            respostas.Add(new Resposta()
            {
                Name = "Mike",
                Email = "mike@gmail.com",
                Yes = false
            });
        }
    }
}
