using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassKeeper_Admin
{
    #region Описание класса "Шифрование"
    /*
     * Данный класс необходим для реализации функционала шифрования
     * 
     * Здесь собраны все методы, отвечающие за данную процедуру
     * 
     */
    #endregion

    public static class Encryption
    {
        private static readonly String Alphabet = "QqWwEeRrTtYyUuIiOoPpAaSsDdFfGgHhJjKkLlZzXxCcVvBbNnMm#1234567890!@#$%^&*-+";
        private static String Salt = "hwvNQ9&%";
        private static String Vector = "a8doSuDitOz1hZe#";
        private static readonly Int32 PasswordIter = 2;
        private static readonly Int32 KeySize = 256;

        public static String EncryptRSA(String InputPassword, String Password)
        {
            if (String.IsNullOrEmpty(InputPassword))
            {
                MessageOneButton_F Dialog = new MessageOneButton_F();

                Dialog.Message_L.Text = "Входная строка имела пустое значение";

                if (Dialog.ShowDialog() == DialogResult.OK)
                {

                }

                SystemArgs.PrintLog($"Получено пустое значение пароля");

                return null;
            }

            byte[] VectorB = Encoding.ASCII.GetBytes(Vector);
            byte[] SaltB = Encoding.ASCII.GetBytes(Salt);
            byte[] InputPasswordB = Encoding.UTF8.GetBytes(InputPassword);

            PasswordDeriveBytes DerivePassword = new PasswordDeriveBytes(Password, SaltB, "SHA1", PasswordIter);
            byte[] KeyBytes = DerivePassword.GetBytes(KeySize / 8);

            RijndaelManaged SymmKey = new RijndaelManaged();
            SymmKey.Mode = CipherMode.CBC;

            byte[] EncryptrTextBytes = null;

            using (ICryptoTransform Encryptor = SymmKey.CreateEncryptor(KeyBytes, VectorB))
            {
                using (MemoryStream MemoryStream = new MemoryStream())
                {
                    using (CryptoStream CryptoStream = new CryptoStream(MemoryStream, Encryptor, CryptoStreamMode.Write))
                    {
                        CryptoStream.Write(InputPasswordB, 0, InputPasswordB.Length);
                        CryptoStream.FlushFinalBlock();
                        EncryptrTextBytes = MemoryStream.ToArray();
                        MemoryStream.Close();
                        CryptoStream.Close();
                    }
                }
            }

            SymmKey.Clear();

            SystemArgs.PrintLog($"Шифрование пароля завершено успешно");

            return Convert.ToBase64String(EncryptrTextBytes);
        }

        public static String DecryptRSA(String OutputPassword, String Password)
        {
            if (String.IsNullOrEmpty(OutputPassword))
            {
                MessageOneButton_F Dialog = new MessageOneButton_F();

                Dialog.Message_L.Text = "Входная строка имела пустое значение";

                if (Dialog.ShowDialog() == DialogResult.OK)
                {

                }

                SystemArgs.PrintLog($"Получено пустое значение пароля");

                return null;
            };

            byte[] VectorB = Encoding.ASCII.GetBytes(Vector);
            byte[] SaltB = Encoding.ASCII.GetBytes(Salt);
            byte[] OutputPasswordB = Convert.FromBase64String(OutputPassword);

            PasswordDeriveBytes DerivePassword = new PasswordDeriveBytes(Password, SaltB, "SHA1", PasswordIter);
            byte[] KeyBytes = DerivePassword.GetBytes(KeySize / 8);

            RijndaelManaged SymmKey = new RijndaelManaged();
            SymmKey.Mode = CipherMode.CBC;

            byte[] InitialTextBytes = new byte[OutputPasswordB.Length];

            Int32 ByteCount = 0;

            using (ICryptoTransform Decryptor = SymmKey.CreateDecryptor(KeyBytes, VectorB))
            {
                using (MemoryStream MemoryStream = new MemoryStream(OutputPasswordB))
                {
                    using (CryptoStream CryptoStream = new CryptoStream(MemoryStream, Decryptor, CryptoStreamMode.Read))
                    {
                        ByteCount = CryptoStream.Read(InitialTextBytes, 0, InitialTextBytes.Length);
                        MemoryStream.Close();
                        CryptoStream.Close();
                    }
                }
            }

            SymmKey.Clear();

            SystemArgs.PrintLog($"Дешифрование пароля завершено успешно");

            return Encoding.UTF8.GetString(InitialTextBytes, 0, ByteCount);
        }

        public static String GetKeyEncryption()
        {
            Random Random = new Random();

            string Key = String.Empty;

            for(Int32 i = 0; i < 8; i++)
            {
                Int32 Temp = Random.Next(0, Alphabet.Length);

                Key += Alphabet[Temp];
            }

            SystemArgs.PrintLog($"Ключ успешно получен");

            return Key;
        }
    }
}
