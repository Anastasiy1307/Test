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
               
            double thick_wall;// толщина стенки
            thick_wall = Double.Parse(Console.ReadLine());
            double lengh = Double.Parse(Console.ReadLine());//длинна

            Console.WriteLine("Выбери тип трубы\n" +
                "1 pn10\n" +
                "2 pn16\n" +
                "3 pn20\n" +
                "4 pn25 ");
            int truba = int.Parse(Console.ReadLine()); //выбор трубы
            int outer_diametr=int.Parse(Console.ReadLine());//Внешний диаметр

            Trubes trub = new Trubes();
            trub.Trub(lengh, truba, outer_diametr, thick_wall);
        

            
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
        /// <summary>
        /// Данный метод позволяет проверить трубу на соответствие требованиям.
        /// </summary>
        /// <param name="lengh">Берет длинну из главного метода</param>
        /// <param name="trubes">Виды трубы на выбор</param>
        /// <param name="out_diam">Берет внешний диаметр трубы из метода</param>
        /// <param name="thi_wal">Берет толщину трубы из главного метода</param>
        public void Trub(double lengh, double trubes, double out_diam, double thi_wal)
        {
            double crav1;
            double crav2;
            Outer_diametr outer = new Outer_diametr();

            double min_lengh = 3960;
            double max_lengh = 4040;

            TextWriterTraceListener[] listeners = new TextWriterTraceListener[] {
            new TextWriterTraceListener(@"D:\1.txt"),  //Путь файла
            new TextWriterTraceListener(Console.Out)};
           

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
                                
                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы на соответствие требованием пройдена успешно"); // Сообщение
                                Debug.Flush();
                            }
                            else
                            {
                                Console.WriteLine("Труба не соответствует критериям");
                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы на соответствие требованием провалена"); // Сообщение
                                Debug.Flush();
                            }
                        }
                        else if (out_diam == 25)
                        {

                            crav1 = out_diam / 100 * outer.min_proc[0];
                            crav2 = out_diam / 100 * outer.max_proc[0];
                            if (thi_wal >= crav1 && thi_wal <= crav2)
                            {
                               
                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы на соответствие требованием пройдена успешно"); // Сообщение
                                Debug.Flush();
                            }
                            else
                            {
                                
                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы на соответствие требованием провалена"); // Сообщение
                                Debug.Flush();
                            }
                        }
                        else if (out_diam == 32)
                        {

                            crav1 = out_diam / 100 * outer.min_proc[0];
                            crav2 = out_diam / 100 * outer.max_proc[0];
                            if (thi_wal >= crav1 && thi_wal <= crav2)
                            {
                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы на соответствие требованием пройдена успешно"); // Сообщение
                                Debug.Flush();
                            }
                            else
                            {
                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы на соответствие требованием провалена"); // Сообщение
                                Debug.Flush();
                            }
                        }
                        else if (out_diam == 40)
                        {

                            crav1 = out_diam / 100 * outer.min_proc[0];
                            crav2 = out_diam / 100 * outer.max_proc[0];
                            if (thi_wal >= crav1 && thi_wal <= crav2)
                            {
                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы на соответствие требованием пройдена успешно"); // Сообщение
                                Debug.Flush();
                            }
                            else
                            {
                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы на соответствие требованием провалена"); // Сообщение
                                Debug.Flush();
                            }
                        }
                        else if (out_diam == 50)
                        {

                            crav1 = out_diam / 100 * outer.min_proc[0];
                            crav2 = out_diam / 100 * outer.max_proc[0];
                            if (thi_wal >= crav1 && thi_wal <= crav2)
                            {
                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы на соответствие требованием пройдена успешно"); // Сообщение
                                Debug.Flush();
                            }
                            else
                            {
                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы на соответствие требованием провалена"); // Сообщение
                                Debug.Flush();
                            }
                        }
                        else if (out_diam == 63)
                        {

                            crav1 = out_diam / 100 * outer.min_proc[0];
                            crav2 = out_diam / 100 * outer.max_proc[0];
                            if (thi_wal >= crav1 && thi_wal <= crav2)
                            {
                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы на соответствие требованием пройдена успешно"); // Сообщение
                                Debug.Flush();
                            }
                            else
                            {
                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы на соответствие требованием провалена"); // Сообщение
                                Debug.Flush();
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
