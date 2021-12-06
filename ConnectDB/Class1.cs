using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectDB
{
    public class ConnectDB1
    {
        //тут поля(не рисовые) для значений
        public string conn1;
        public string Host;
        public string Port;
        public string User;
        public string Database;
        public string Password;

        //инициализация
        public string Initialization1()
        {
            //присвоение значений
            Host = "caseum.ru";
            Port = "33333";
            User = "test_user";
            Database = "db_test";
            Password = "test_pass";
            //поле, отвечающее за подключение
            string connecionString1;
            //создание подключения
            connecionString1 = $"server={Host};port={Port};user={User};database={Database};password={Password};";

            conn1 = connecionString1;
            //возвращеник подключения
            return conn1;
        }
    }
}
