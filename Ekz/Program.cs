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
               
            double thicwall;// толщина стенки
            Console.WriteLine("Введите толщину стенки трубы");
            thicwall = Double.Parse(Console.ReadLine());
            double lengh = Double.Parse(Console.ReadLine());//длинна

            Console.WriteLine("Выберите тип трубы\n1.PN10\n2.PN16\n3.PN20\n4.PN25");
            int trubas = int.Parse(Console.ReadLine()); //выбор трубы
            int outerdiametr=int.Parse(Console.ReadLine());//Внешний диаметр

            Trubes trub = new Trubes();
            trub.Trub(lengh, trubas, outerdiametr, thicwall);
        

            
            Console.Read();
        }      
    }
    public class Outer_diametr
    {
        public double[] min_proc = new double[] { 10, 13.5, 16.5 };//массив минимальных % для расчета толщины трубы
        public double[] max_proc = new double[] { 11, 14, 17 };//массив Максимальных % для расчета толщины трубы
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
            double srav1;
            double srav2;
            Outer_diametr outer = new Outer_diametr();

            double minl = 3960;
            double maxl = 4040;

            TextWriterTraceListener[] listeners = new TextWriterTraceListener[] {
            new TextWriterTraceListener(@"D:\1.txt"),  //Путь файла
            new TextWriterTraceListener(Console.Out)};
           

            if (lengh >= minl && maxl >= lengh)
            {
                switch (trubes)
                {

                    case 1:
                        Console.WriteLine("PN10");
                        if (out_diam == 20)
                        {
                            srav1 = out_diam / 100 * outer.min_proc[0];
                            srav2 = out_diam / 100 * outer.max_proc[0];
                            if (thi_wal >= srav1 && thi_wal <= srav2)
                            {
                                
                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы PN10 на соответствие требованием пройдена успешно"); // Сообщение
                                Debug.Flush();
                            }
                            else
                            {
                                Console.WriteLine("Труба не соответствует критериям");
                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы PN10 на соответствие требованием провалена"); 
                                Debug.Flush();
                            }
                        }
                        else if (out_diam == 25)
                        {

                            srav1 = out_diam / 100 * outer.min_proc[0];// расчет толщины стенки с минимальным % от внешнего диаметра
                            srav2 = out_diam / 100 * outer.max_proc[0];//расчет толщины стенки с максимальным % от внешнего диаметра
                            if (thi_wal >= srav1 && thi_wal <= srav2)
                            {
                               
                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы PN10 на соответствие требованием пройдена успешно"); 
                                Debug.Flush();
                            }
                            else
                            {
                                
                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы PN10 на соответствие требованием провалена"); 
                                Debug.Flush();
                            }
                        }
                        else if (out_diam == 32)
                        {

                            srav1 = out_diam / 100 * outer.min_proc[0];
                            srav2 = out_diam / 100 * outer.max_proc[0];
                            if (thi_wal >= srav1 && thi_wal <= srav2)
                            {
                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы PN10 на соответствие требованием пройдена успешно"); 
                                Debug.Flush();
                            }
                            else
                            {
                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы PN10 на соответствие требованием провалена"); 
                                Debug.Flush();
                            }
                        }
                        else if (out_diam == 40)
                        {

                            srav1 = out_diam / 100 * outer.min_proc[0];
                            srav2 = out_diam / 100 * outer.max_proc[0];
                            if (thi_wal >= srav1 && thi_wal <= srav2)
                            {
                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы PN10 на соответствие требованием пройдена успешно"); 
                                Debug.Flush();
                            }
                            else
                            {
                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы PN10 на соответствие требованием провалена"); 
                                Debug.Flush();
                            }
                        }
                        else if (out_diam == 50)
                        {

                            srav1 = out_diam / 100 * outer.min_proc[0];
                            srav2 = out_diam / 100 * outer.max_proc[0];
                            if (thi_wal >= srav1 && thi_wal <= srav2)
                            {
                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы PN10 на соответствие требованием пройдена успешно"); 
                                Debug.Flush();
                            }
                            else
                            {
                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы PN10 на соответствие требованием провалена"); 
                                Debug.Flush();
                            }
                        }
                        else if (out_diam == 63)
                        {

                            srav1 = out_diam / 100 * outer.min_proc[0];
                            srav2 = out_diam / 100 * outer.max_proc[0];
                            if (thi_wal >= srav1 && thi_wal <= srav2)
                            {
                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы PN10 на соответствие требованием пройдена успешно"); 
                                Debug.Flush();
                            }
                            else
                            {
                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы PN10 на соответствие требованием провалена"); 
                                Debug.Flush();
                            }
                        }
                        break;

                    case 2:

                        Console.WriteLine("PN16 (Аромированная) ");
                        if (out_diam == 20)
                        {
                            srav1 = out_diam / 100 * outer.min_proc[1];
                            srav2 = out_diam / 100 * outer.max_proc[1];
                            if (thi_wal >= srav1 && thi_wal <= srav2)
                            {

                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы PN16 на соответствие требованием пройдена успешно"); 
                                Debug.Flush();
                            }
                            else
                            {
                                Console.WriteLine("Труба не соответствует критериям");
                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы PN16 на соответствие требованием провалена"); 
                                Debug.Flush();
                            }
                        }
                        else if (out_diam == 25)
                        {

                            srav1 = out_diam / 100 * outer.min_proc[1];
                            srav2 = out_diam / 100 * outer.max_proc[1];
                            if (thi_wal >= srav1 && thi_wal <= srav2)
                            {

                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы PN16 на соответствие требованием пройдена успешно"); 
                                Debug.Flush();
                            }
                            else
                            {

                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы PN16 на соответствие требованием провалена"); 
                                Debug.Flush();
                            }
                        }
                        else if (out_diam == 32)
                        {

                            srav1 = out_diam / 100 * outer.min_proc[1];
                            srav2 = out_diam / 100 * outer.max_proc[1];
                            if (thi_wal >= srav1 && thi_wal <= srav2)
                            {
                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы PN16 на соответствие требованием пройдена успешно"); 
                                Debug.Flush();
                            }
                            else
                            {
                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы PN16 на соответствие требованием провалена"); 
                                Debug.Flush();
                            }
                        }
                        else if (out_diam == 40)
                        {

                            srav1 = out_diam / 100 * outer.min_proc[1];
                            srav2 = out_diam / 100 * outer.max_proc[1];
                            if (thi_wal >= srav1 && thi_wal <= srav2)
                            {
                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы PN16 на соответствие требованием пройдена успешно"); 
                                Debug.Flush();
                            }
                            else
                            {
                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы PN16 на соответствие требованием провалена"); 
                                Debug.Flush();
                            }
                        }
                        else if (out_diam == 50)
                        {

                            srav1 = out_diam / 100 * outer.min_proc[1];
                            srav2 = out_diam / 100 * outer.max_proc[1];
                            if (thi_wal >= srav1 && thi_wal <= srav2)
                            {
                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы PN16 на соответствие требованием пройдена успешно"); 
                                Debug.Flush();
                            }
                            else
                            {
                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы PN16 на соответствие требованием провалена"); 
                                Debug.Flush();
                            }
                        }
                        else if (out_diam == 63)
                        {

                            srav1 = out_diam / 100 * outer.min_proc[1];
                            srav2 = out_diam / 100 * outer.max_proc[1];
                            if (thi_wal >= srav1 && thi_wal <= srav2)
                            {
                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы PN16 на соответствие требованием пройдена успешно"); 
                                Debug.Flush();
                            }
                            else
                            {
                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы PN16 на соответствие требованием провалена"); 
                                Debug.Flush();
                            }
                        }

                        break;

                    case 3:
                        Console.WriteLine("PN20");
                        if (out_diam == 20)
                        {
                            srav1 = out_diam / 100 * outer.min_proc[2];
                            srav2 = out_diam / 100 * outer.max_proc[2];
                            if (thi_wal >= srav1 && thi_wal <= srav2)
                            {

                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы PN20 на соответствие требованием пройдена успешно"); 
                                Debug.Flush();
                            }
                            else
                            {
                                Console.WriteLine("Труба не соответствует критериям");
                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы PN20 на соответствие требованием провалена"); 
                                Debug.Flush();
                            }
                        }
                        else if (out_diam == 25)
                        {

                            srav1 = out_diam / 100 * outer.min_proc[2];
                            srav2 = out_diam / 100 * outer.max_proc[2];
                            if (thi_wal >= srav1 && thi_wal <= srav2)
                            {

                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы PN20 на соответствие требованием пройдена успешно"); 
                                Debug.Flush();
                            }
                            else
                            {

                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы PN20 на соответствие требованием провалена"); 
                                Debug.Flush();
                            }
                        }
                        else if (out_diam == 32)
                        {

                            srav1 = out_diam / 100 * outer.min_proc[2];
                            srav2 = out_diam / 100 * outer.max_proc[2];
                            if (thi_wal >= srav1 && thi_wal <= srav2)
                            {
                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы PN20 на соответствие требованием пройдена успешно"); 
                                Debug.Flush();
                            }
                            else
                            {
                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы PN20 на соответствие требованием провалена"); 
                                Debug.Flush();
                            }
                        }
                        else if (out_diam == 40)
                        {

                            srav1 = out_diam / 100 * outer.min_proc[2];
                            srav2 = out_diam / 100 * outer.max_proc[2];
                            if (thi_wal >= srav1 && thi_wal <= srav2)
                            {
                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы PN20 на соответствие требованием пройдена успешно"); 
                                Debug.Flush();
                            }
                            else
                            {
                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы PN20 на соответствие требованием провалена"); 
                                Debug.Flush();
                            }
                        }
                        else if (out_diam == 50)
                        {

                            srav1 = out_diam / 100 * outer.min_proc[2];
                            srav2 = out_diam / 100 * outer.max_proc[2];
                            if (thi_wal >= srav1 && thi_wal <= srav2)
                            {
                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы PN20 на соответствие требованием пройдена успешно");
                                Debug.Flush();
                            }
                            else
                            {
                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы PN20 на соответствие требованием провалена"); 
                                Debug.Flush();
                            }
                        }
                        else if (out_diam == 63)
                        {

                            srav1 = out_diam / 100 * outer.min_proc[2];
                            srav2 = out_diam / 100 * outer.max_proc[2];
                            if (thi_wal >= srav1 && thi_wal <= srav2)
                            {
                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы PN20 на соответствие требованием пройдена успешно"); 
                                Debug.Flush();
                            }
                            else
                            {
                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы PN20 на соответствие требованием провалена"); 
                                Debug.Flush();
                            }
                        }
                        break;

                    case 4:
                        Console.WriteLine("PN25");
                        if (out_diam == 20)
                        {
                            srav1 = out_diam / 100 * outer.min_proc[2];
                            srav2 = out_diam / 100 * outer.max_proc[2];
                            if (thi_wal >= srav1 && thi_wal <= srav2)
                            {

                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы PN25 на соответствие требованием пройдена успешно"); 
                                Debug.Flush();
                            }
                            else
                            {
                                Console.WriteLine("Труба не соответствует критериям");
                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы PN25 на соответствие требованием провалена"); 
                                Debug.Flush();
                            }
                        }
                        else if (out_diam == 25)
                        {

                            srav1 = out_diam / 100 * outer.min_proc[2];
                            srav2 = out_diam / 100 * outer.max_proc[2];
                            if (thi_wal >= srav1 && thi_wal <= srav2)
                            {

                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы PN25 на соответствие требованием пройдена успешно"); 
                                Debug.Flush();
                            }
                            else
                            {

                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы PN25 на соответствие требованием провалена"); 
                                Debug.Flush();
                            }
                        }
                        else if (out_diam == 32)
                        {

                            srav1 = out_diam / 100 * outer.min_proc[2];
                            srav2 = out_diam / 100 * outer.max_proc[2];
                            if (thi_wal >= srav1 && thi_wal <= srav2)
                            {
                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы PN25 на соответствие требованием пройдена успешно"); 
                                Debug.Flush();
                            }
                            else
                            {
                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы PN25 на соответствие требованием провалена"); 
                                Debug.Flush();
                            }
                        }
                        else if (out_diam == 40)
                        {

                            srav1 = out_diam / 100 * outer.min_proc[2];
                            srav2 = out_diam / 100 * outer.max_proc[2];
                            if (thi_wal >= srav1 && thi_wal <= srav2)
                            {
                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы PN25 на соответствие требованием пройдена успешно"); 
                                Debug.Flush();
                            }
                            else
                            {
                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы PN25 на соответствие требованием провалена"); 
                                Debug.Flush();
                            }
                        }
                        else if (out_diam == 50)
                        {

                            srav1 = out_diam / 100 * outer.min_proc[2];
                            srav2 = out_diam / 100 * outer.max_proc[2];
                            if (thi_wal >= srav1 && thi_wal <= srav2)
                            {
                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы PN25 на соответствие требованием пройдена успешно"); 
                                Debug.Flush();
                            }
                            else
                            {
                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы PN25 на соответствие требованием провалена"); 
                                Debug.Flush();
                            }
                        }
                        else if (out_diam == 63)
                        {

                            srav1 = out_diam / 100 * outer.min_proc[2];
                            srav2 = out_diam / 100 * outer.max_proc[2];
                            if (thi_wal >= srav1 && thi_wal <= srav2)
                            {
                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы PN25 на соответствие требованием пройдена успешно"); 
                                Debug.Flush();
                            }
                            else
                            {
                                Debug.Listeners.AddRange(listeners);
                                Debug.WriteLine("Проверка трубы PN25 на соответствие требованием провалена"); 
                                Debug.Flush();
                            }
                        }
                        break;

                }
            }
            else
            {
                Console.WriteLine("Длина не соответствует требованиям");
            }

        }
    }
}
