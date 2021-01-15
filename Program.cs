using System;

namespace Exercicio_Media_10Alunos
{
    class Program
    {
        //FN MEDIA INDIVIDUAL DO ALUNO
        static float medAluno(float[] notas){
            
            float soma = 0;
            for (var i = 0; i < notas.Length; i++)
                {
                    soma+=notas[i];
                }
            float resultado =  soma / notas.Length;
            return resultado;
        }
    
        static void Main(string[] args)
        {
            //10 nomes alunos --------- ok
            //4 notas para cada aluno-- ok
            //média do aluno ---------- ok
            //quantidade de aprovados - ok
            //quantidade de reprovados  ok   
            //media geral

            //QUANTIDADE DE NOMES DOS ALUNOS
            string[] nome = new string[10];
            float[] notas = new float[4];
            float[] mediaI= new float[10];
                    
            //CAPTURA DE NOMES E NOTAS UTILIZANDO 'FOR'
            //NOMES
            for (var i = 0; i < nome.Length; i++)
            {
                Console.Write("Escreva um nome: ");
                nome[i] = Console.ReadLine();

            //NOTAS
                for (var x = 0; x < notas.Length; x++)
                {
                    Console.Write("Registre a "+(x+1)+"º nota: ");
                    notas[x] = float.Parse(Console.ReadLine());
                }
                
                    mediaI[i] = medAluno(notas);//CHECAR 
                              
            }

            //Exibição da NOTA
            for (var i = 0; i < nome.Length; i++)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine($"Aluno(a) {nome[i]} está: ");
                if(mediaI[i] >= 7){
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Aprovado");
                    Console.ForegroundColor = ConsoleColor.White;
                }else{
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Reprovado\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            //EXIBIÇÃO DE APROVADOS E REPROVADOS
             for (var i = 0; i < nome.Length; i++)
            {
                int aprovados = 0;
                int reprovados = 0;

                if(mediaI[i] >= 7){
                
                aprovados++;

                }else{                   

                reprovados++;                        
                    
                }
                    Console.WriteLine(aprovados+" alunos foram aprovados");
                    Console.WriteLine(reprovados+" alunos foram reprovados");
            }

            float mediaG = (mediaI[0]+mediaI[1]+mediaI[2]+mediaI[3]+mediaI[4]+mediaI[5]+mediaI[6]+mediaI[7]+mediaI[8]+mediaI[9])/10;
            Console.Write("A Média Geral da classe é: "+mediaG);

                     
        }
        
    }
}
