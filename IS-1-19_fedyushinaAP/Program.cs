using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_1_19_fedyushinaAP
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }
        public class ConnectDB
        {
            //тут поля(не рисовые) для значений
            public string conn;
            public string Host;
            public string Port;
            public string User;
            public string Database;
            public string Password;

            //инициализация
            public string Initialization()
            {
                //присвоение значений
                Host = "caseum.ru";
                Port = "33333";
                User = "test_user";
                Database = "db_test";
                Password = "test_pass";
                //поле, отвечающее за подключение
                string connecionString;
                //создание подключения
                connecionString = $"server={Host};port={Port};user={User};database={Database};password={Password};";

                conn = connecionString;
                //возвращеник подключения
                return conn;
            }
        }
    }
}
