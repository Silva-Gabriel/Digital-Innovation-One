using System; 

namespace DesafioCrescimentoPop
{
    class CrescimentoPopulacional{



        static void Main(string[] args) { 



            int t = Convert.ToInt32(Console.ReadLine());
            double[] arrayList = new double[4];
            int pa, pb;
            double cpa, cpb;
            int anos;
            
            for (int i = 0; i < t; i++)

            {
                anos = 0;
                string[] valores = Console.ReadLine().Split();

                pa = int.Parse(valores[0]);
                pb = int.Parse(valores[1]);

                cpa = double.Parse(valores[2]);
                cpb = double.Parse(valores[3]);
                
                while (pa <= pb)

                {
                    pa += Convert.ToInt32(Math.Truncate(pa * cpa / 100));
                    pb += Convert.ToInt32(Math.Truncate(pb * cpb / 100));
                    anos++;
                    
                    if (anos > 100)
                    {
                        Console.WriteLine("Mais de 1 seculo.");
                        break;
                    }
                }
                if (anos <= 100)
                Console.WriteLine("{0} anos.", anos);
            }
        }
    }
}
