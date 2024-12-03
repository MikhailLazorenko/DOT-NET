using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Task_2
{
    // Клас Telephone
    public class Telephone
    {
        public string Number { get; set; }
        public DateTime InstallationDate { get; set; }
        public bool HasBlocker { get; set; }
    }

    // Клас ATS
    public class ATS
    {
        public string Number { get; set; }
        public string District { get; set; }
        public int TotalNumbers { get; set; }
    }

    // Клас PaymentForServices
    public class PaymentForServices
    {
        public int ID { get; set; }
        public string TelephoneNumber { get; set; }
        public string ATSNumber { get; set; }
        public decimal Cost { get; set; }
        public bool IsPaid { get; set; }

        // Додаткові властивості для зручності
        public Telephone Telephone { get; set; }
        public ATS ATS { get; set; }
    }

    class Program
    {
        // Параметри підключення до бази даних
        static string server = "localhost";
        static string database = "TelephoneNetworkDB";
        static string user = "root";
        static string password = "mnc5UbTRn_nZ+M:";
        static string connStr = $"server={server};user={user};database={database};password={password};";

        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            try
            {
                // Отримуємо списки записів з бази даних
                List<Telephone> telephones = GetTelephones();
                List<ATS> atss = GetATSs();
                List<PaymentForServices> payments = GetPayments();

                // Виводимо дані в консоль
                Console.WriteLine("Таблиця 'Telephone':");
                PrintTelephones(telephones);

                Console.WriteLine("\nТаблиця 'ATS':");
                PrintATSs(atss);

                Console.WriteLine("\nТаблиця 'PaymentForServices':");
                PrintPayments(payments);

                // Демонстрація зв'язків між таблицями
                Console.WriteLine("\nДемонстрація зв'язків між таблицями:");
                DemonstrateRelationships();

                Console.WriteLine("\nПрограма завершила роботу. Натисніть будь-яку клавішу для виходу...");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }

        // Метод для отримання списку телефонів
        static List<Telephone> GetTelephones()
        {
            List<Telephone> telephones = new List<Telephone>();

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT * FROM Telephone;";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    telephones.Add(new Telephone
                    {
                        Number = reader.GetString("Number"),
                        InstallationDate = reader.GetDateTime("InstallationDate"),
                        HasBlocker = reader.GetBoolean("HasBlocker")
                    });
                }
            }

            return telephones;
        }

        // Метод для отримання списку АТС
        static List<ATS> GetATSs()
        {
            List<ATS> atss = new List<ATS>();

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT * FROM ATS;";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    atss.Add(new ATS
                    {
                        Number = reader.GetString("Number"),
                        District = reader.GetString("District"),
                        TotalNumbers = reader.GetInt32("TotalNumbers")
                    });
                }
            }

            return atss;
        }

        // Метод для отримання списку оплат
        static List<PaymentForServices> GetPayments()
        {
            List<PaymentForServices> payments = new List<PaymentForServices>();

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT * FROM PaymentForServices;";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    payments.Add(new PaymentForServices
                    {
                        ID = reader.GetInt32("ID"),
                        TelephoneNumber = reader.GetString("TelephoneNumber"),
                        ATSNumber = reader.GetString("ATSNumber"),
                        Cost = reader.GetDecimal("Cost"),
                        IsPaid = reader.GetBoolean("IsPaid")
                    });
                }
            }

            return payments;
        }

        // Метод для виведення телефонів
        static void PrintTelephones(List<Telephone> telephones)
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine("|    Number     | Installation Date | Has Blocker |");
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            foreach (var tel in telephones)
            {
                Console.WriteLine($"| {tel.Number,-13} | {tel.InstallationDate.ToShortDateString(),-16} | {tel.HasBlocker,-11} |");
            }
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
        }

        // Метод для виведення АТС
        static void PrintATSs(List<ATS> atss)
        {
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            Console.WriteLine("|  Number  |      District      | Total Numbers |");
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            foreach (var ats in atss)
            {
                Console.WriteLine($"| {ats.Number,-8} | {ats.District,-18} | {ats.TotalNumbers,-13} |");
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------");
        }

        // Метод для виведення оплат
        static void PrintPayments(List<PaymentForServices> payments)
        {
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("| ID | Telephone Number | ATS Number |   Cost   | Is Paid |");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
            foreach (var pay in payments)
            {
                Console.WriteLine($"| {pay.ID,-2} | {pay.TelephoneNumber,-16} | {pay.ATSNumber,-10} | {pay.Cost,7:C} | {pay.IsPaid,-7} |");
            }
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
        }

        // Метод для демонстрації зв'язків між таблицями
        static void DemonstrateRelationships()
        {
            // Наприклад, виберемо всі оплати для телефонів, встановлених після певної дати
            DateTime dateThreshold = new DateTime(2018, 1, 1);

            Console.WriteLine($"Оплати для телефонів, встановлених після {dateThreshold.ToShortDateString()}:");

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = @"
                    SELECT p.ID, p.TelephoneNumber, p.ATSNumber, p.Cost, p.IsPaid, t.InstallationDate
                    FROM PaymentForServices p
                    JOIN Telephone t ON p.TelephoneNumber = t.Number
                    WHERE t.InstallationDate > @DateThreshold;"
                ;

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DateThreshold", dateThreshold);

                MySqlDataReader reader = cmd.ExecuteReader();

                Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("| ID | Telephone Number | Installation Date | ATS Number |   Cost   | Is Paid |");
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");

                while (reader.Read())
                {
                    int id = reader.GetInt32("ID");
                    string telNumber = reader.GetString("TelephoneNumber");
                    DateTime installDate = reader.GetDateTime("InstallationDate");
                    string atsNumber = reader.GetString("ATSNumber");
                    decimal cost = reader.GetDecimal("Cost");
                    bool isPaid = reader.GetBoolean("IsPaid");

                    Console.WriteLine($"| {id,-2} | {telNumber,-16} | {installDate.ToShortDateString(),-16} | {atsNumber,-10} | {cost,7:C} | {isPaid,-7} |");
                }

                Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
            }
        }
    }
}
