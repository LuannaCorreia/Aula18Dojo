using System;

namespace Aula18Dojo
{
    public class Jogador
    {
        public string Nome {get; set;}

        public int Idade { get; set; }

        public string Posicao { get; set; }

        public string Nacionalidade { get; set; }

        public float Altura  { get; set; }

        public float Peso { get; set; }
        
        public DateTime Nascimento { get; set; }
        
        public int CalcularIdade(){
            
            // 16/06/2020 15:39:50
            //  0  1  2
            // 2020 15:39:50
            //  0
            int AnoAtual      = Int32.Parse( DateTime.Now.ToString().Split("/")[2].Split(" ")[0] );            
            int AnoNascimento = Int32.Parse( Nascimento.ToString().Split("/")[2].Split(" ")[0] );

            Idade = AnoAtual  - AnoNascimento;
            return Idade; 
        }
            //defensor   41 anos
            //Meio Campo 37 anos
            //ataque     34 anos
            public string VerificarAposentadoria(){

                CalcularIdade();
                string Retorno = "";
                if(Idade >= 34 && Posicao == "Atacante"){
                    Retorno = "A atacante pode se aposentar";
                }else if(Idade >= 37 && Posicao == "Meio Campo"){
                    Retorno = "A meia campista pode se aposentar";
                }else if(Idade >= 41 && Posicao == "Defensor"){
                    Retorno = "A Defensora pode se aposentar";
                }else{
                    Retorno = "A jogadora não tem idade sulficiente para se aposentar";
                }
                return Retorno;
            }

        public void MostrarDados(){
            System.Console.WriteLine($"Nome: {Nome}, Posição: {Posicao}, Nascimento: {Nascimento}");
        }        
    }
}
