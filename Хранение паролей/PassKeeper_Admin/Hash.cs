using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PassKeeper_Admin
{
    #region Описание класса "Методы контрольной суммы"
    /*
     * Данный класс необходим для реализации получения МКС от паролей
     * 
     * Вызывать методы путем передачи в качестве параметра строки с исходным паролем
     * На выходе МКС от текущей строки в типе строки
     * */
    #endregion

    public static class Hash
    {
        public static String GetSHA256(String Password)
        {
            UTF8Encoding Encoder = new UTF8Encoding();
            SHA256Managed SHA256 = new SHA256Managed();
            byte[] Hash = SHA256.ComputeHash(Encoder.GetBytes(Password));

            SystemArgs.PrintLog($"Хеш-последовательность успешно получена");

            return Convert.ToBase64String(Hash);
        }
    }
}
