namespace RoboTupiniquim
{
    internal class Program
    {
        
        
        static void Main(string[] args)
        {
            int x1 = 0, y1 = 0;

            Console.WriteLine("Informe o tamanho da matriz EX: ( X Y ): ");
            string tamanhoMatriz = Console.ReadLine();
            x1 = Convert.ToInt32(Convert.ToString(tamanhoMatriz[0]));
            y1 = Convert.ToInt32(Convert.ToString(tamanhoMatriz[2]));

            int[,] matriz = new int[x1, y1];

            //Robo 1

            Console.WriteLine("Informe a posição inicial do robo 01: ");
            String robo1 = Console.ReadLine();
            int robo1x = Convert.ToInt32(Convert.ToString(robo1[0]));
            int robo1y = Convert.ToInt32(Convert.ToString(robo1[2]));
            string direcRobo1 = Convert.ToString(robo1[4]);
            
            matriz[robo1x, robo1y] = 5;

            Console.WriteLine("De o comando para o robo: ");
            string comandoRobo1 = Console.ReadLine();

            Direcionamento(robo1x, robo1y, x1, y1, comandoRobo1, direcRobo1);
            
            //Robo 2

            Console.WriteLine("Informe a posição inicial do robo 01: ");
            String robo2 = Console.ReadLine();
            int robo2x = Convert.ToInt32(Convert.ToString(robo2[0]));
            int robo2y = Convert.ToInt32(Convert.ToString(robo2[2]));
            string direcRobo2 = Convert.ToString(robo2[4]);

            matriz[robo2x, robo2y] = 5;

            Console.WriteLine("De o comando para o robo: ");
            string comandoRobo2 = Console.ReadLine();
            
            Direcionamento(robo1x, robo1y, x1, y1, comandoRobo1, direcRobo1);
            Direcionamento(robo2x, robo2y, x1, y1, comandoRobo2, direcRobo2);


        }



        private static void Direcionamento(int x, int y, int MX, int MY, String comando, String direcao)
        {
            for (int i = 0; i < comando.Length; i++)
            {

                if (comando[i] == 'D')
                {
                    switch (direcao)
                    {
                        case "N": direcao = "L"; break;
                        case "L": direcao = "S"; break;
                        case "S": direcao = "O"; break;
                        case "O": direcao = "N"; break;

                    }
                }
                else if (comando[i] == 'E')
                {
                    switch (direcao)
                    {
                        case "N": direcao = "O"; break;
                        case "O": direcao = "S"; break;
                        case "S": direcao = "L"; break;
                        case "L": direcao = "N"; break;

                    }
                }
                
                if (comando[i] == 'M')
                {                                       
                        switch (direcao)
                        {
                            case "N": y++; break;
                            case "L": x++; break;
                            case "S": y--; break;
                            case "O": x--; break;
                        }
                    
                    
                }
                
            }
            Console.WriteLine($"{x} {y} {direcao}");
        }
        
    }
}