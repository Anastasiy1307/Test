using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Ekz
{
   public class Program
    {
        static void Main(string[] args)
        {
               
            double thick_wall;
            thick_wall = Double.Parse(Console.ReadLine());
            double lengh = Double.Parse(Console.ReadLine());

            Console.WriteLine("Выбери тип трубы\n" +
                "1 pn10\n" +
                "2 pn16\n" +
                "3 pn20\n" +
                "4 pn25 ");
            int truba = int.Parse(Console.ReadLine());
            int outer_diametr=int.Parse(Console.ReadLine());

            Trubes trub = new Trubes();
            trub.Trub(lengh, truba, outer_diametr, thick_wall);
        

            TextWriterTraceListener[] listeners = new TextWriterTraceListener[] {
            new TextWriterTraceListener(@"D:\1.txt"),  // указать путь
            new TextWriterTraceListener(Console.Out)};
            Debug.Listeners.AddRange(listeners);
            Debug.WriteLine("Ошибка"); // то что пишет в файл и в консоль
            Debug.Flush();
            Console.Read();
        }      
    }
    public class Outer_diametr
    {
        public double[] min_proc = new double[] { 10, 13.5, 16.5 };
        public double[] max_proc = new double[] { 11, 14, 17 };
    }
    public class Trubes
    {
        public void Trub(double lengh, double trubes, double out_diam, double thi_wal)
        {
            double crav1;
            double crav2;
            Outer_diametr outer = new Outer_diametr();

            double min_lengh = 3960;
            double max_lengh = 4040;

            if (lengh >= min_lengh && max_lengh >= lengh)
            {
                switch (trubes)
                {

                    case 1:
                        Console.WriteLine("PN10");
                        if (out_diam == 20)
                        {
                            crav1 = out_diam / 100 * outer.min_proc[0];
                            crav2 = out_diam / 100 * outer.max_proc[0];
                            if (thi_wal >= crav1 && thi_wal <= crav2)
                            {
                                Console.WriteLine("ВСЁ КРУТА");
                            }
                            else
                            {
                                Console.WriteLine("не крута");
                            }
                        }
                        else if (out_diam == 25)
                        {

                            crav1 = out_diam / 100 * outer.min_proc[0];
                            crav2 = out_diam / 100 * outer.max_proc[0];
                            if (thi_wal >= crav1 && thi_wal <= crav2)
                            {
                                Console.WriteLine("ВСЁ КРУТА");
                            }
                            else
                            {
                                Console.WriteLine("не крута");
                            }
                        }
                        else if (out_diam == 32)
                        {

                            crav1 = out_diam / 100 * outer.min_proc[0];
                            crav2 = out_diam / 100 * outer.max_proc[0];
                            if (thi_wal >= crav1 && thi_wal <= crav2)
                            {
                                Console.WriteLine("ВСЁ КРУТА");
                            }
                            else
                            {
                                Console.WriteLine("не крута");
                            }
                        }
                        else if (out_diam == 40)
                        {

                            crav1 = out_diam / 100 * outer.min_proc[0];
                            crav2 = out_diam / 100 * outer.max_proc[0];
                            if (thi_wal >= crav1 && thi_wal <= crav2)
                            {
                                Console.WriteLine("ВСЁ КРУТА");
                            }
                            else
                            {
                                Console.WriteLine("не крута");
                            }
                        }
                        else if (out_diam == 50)
                        {

                            crav1 = out_diam / 100 * outer.min_proc[0];
                            crav2 = out_diam / 100 * outer.max_proc[0];
                            if (thi_wal >= crav1 && thi_wal <= crav2)
                            {
                                Console.WriteLine("ВСЁ КРУТА");
                            }
                            else
                            {
                                Console.WriteLine("не крута");
                            }
                        }
                        else if (out_diam == 63)
                        {

                            crav1 = out_diam / 100 * outer.min_proc[0];
                            crav2 = out_diam / 100 * outer.max_proc[0];
                            if (thi_wal >= crav1 && thi_wal <= crav2)
                            {
                                Console.WriteLine("ВСЁ КРУТА");
                            }
                            else
                            {
                                Console.WriteLine("не крута");
                            }
                        }
                        break;

                    case 2:

                        Console.WriteLine("PN16 (Аромированная) ");

                        break;

                    case 3:
                        Console.WriteLine("PN20");
                        break;

                    case 4:
                        Console.WriteLine("PN25");
                        break;

                }
            }
            else
            {
                Console.WriteLine("Длина не соответствует стандарту");
            }

        }
    }
}
