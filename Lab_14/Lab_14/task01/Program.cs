using System;
using MySql.Data.MySqlClient;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Замініть ці параметри на ваші дані доступу
            string server = "localhost";
            string user = "root";
            string password = "mnc5UbTRn_nZ+M:";

            // Підключення до сервера без вказання бази даних
            string connStr = $"server={server};user={user};password={password};";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    // Створення бази даних
                    string createDbQuery = "CREATE DATABASE IF NOT EXISTS TelephoneNetworkDB;";
                    MySqlCommand cmd = new MySqlCommand(createDbQuery, conn);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Базу даних створено або вона вже існує.");

                    // Підключення до бази даних
                    conn.ChangeDatabase("TelephoneNetworkDB");

                    // Створення таблиць
                    CreateTables(conn);

                    // Заповнення таблиць даними
                    InsertData(conn);

                    Console.WriteLine("Таблиці створено та заповнено даними.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }

            Console.WriteLine("Натисніть будь-яку клавішу для виходу...");
            Console.ReadKey();
        }

        static void CreateTables(MySqlConnection conn)
        {
            // Таблиця Telephone
            string createTelephoneTable = @"
                CREATE TABLE IF NOT EXISTS Telephone (
                    Number VARCHAR(15) PRIMARY KEY,
                    InstallationDate DATE NOT NULL,
                    HasBlocker BOOLEAN NOT NULL
                );";

            // Таблиця ATS
            string createATSTable = @"
                CREATE TABLE IF NOT EXISTS ATS (
                    Number VARCHAR(10) PRIMARY KEY,
                    District VARCHAR(50) NOT NULL,
                    TotalNumbers INT NOT NULL
                );";

            // Таблиця PaymentForServices
            string createPaymentTable = @"
                CREATE TABLE IF NOT EXISTS PaymentForServices (
                    ID INT AUTO_INCREMENT PRIMARY KEY,
                    TelephoneNumber VARCHAR(15),
                    ATSNumber VARCHAR(10),
                    Cost DECIMAL(10,2) NOT NULL,
                    IsPaid BOOLEAN NOT NULL,
                    FOREIGN KEY (TelephoneNumber) REFERENCES Telephone(Number),
                    FOREIGN KEY (ATSNumber) REFERENCES ATS(Number)
                );";

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = createTelephoneTable;
            cmd.ExecuteNonQuery();

            cmd.CommandText = createATSTable;
            cmd.ExecuteNonQuery();

            cmd.CommandText = createPaymentTable;
            cmd.ExecuteNonQuery();
        }

        static void InsertData(MySqlConnection conn)
        {
            // Дані для таблиці Telephone
            var telephoneData = new (string Number, DateTime InstallationDate, bool HasBlocker)[]
            {
                ("380501234567", new DateTime(2020, 1, 15), true),
                ("380671234568", new DateTime(2019, 5, 22), false),
                ("380671234569", new DateTime(2018, 7, 30), true),
                ("380631234560", new DateTime(2021, 3, 10), false),
                ("380931234561", new DateTime(2017, 11, 5), true),
                ("380931234562", new DateTime(2022, 2, 18), false),
                ("380501234563", new DateTime(2016, 9, 25), true),
                ("380501234564", new DateTime(2015, 12, 14), false),
                ("380501234565", new DateTime(2020, 8, 20), true),
                ("380501234566", new DateTime(2019, 4, 1), false),
                ("380501234577", new DateTime(2018, 6, 17), true),
                ("380501234578", new DateTime(2021, 9, 23), false),
                ("380501234579", new DateTime(2017, 10, 30), true),
                ("380501234580", new DateTime(2016, 1, 8), false),
                ("380501234581", new DateTime(2020, 5, 19), true),
                ("380501234582", new DateTime(2019, 7, 27), false),
                ("380501234583", new DateTime(2018, 11, 11), true),
                ("380501234584", new DateTime(2021, 2, 5), false),
                ("380501234585", new DateTime(2017, 3, 22), true),
                ("380501234586", new DateTime(2016, 8, 16), false)
            };

            // Дані для таблиці ATS
            var atsData = new (string Number, string District, int TotalNumbers)[]
            {
                ("ATS001", "Шевченківський", 10000),
                ("ATS002", "Печерський", 8000),
                ("ATS003", "Дарницький", 12000),
                ("ATS004", "Оболонський", 9000),
                ("ATS005", "Солом'янський", 11000),
                ("ATS006", "Голосіївський", 9500),
                ("ATS007", "Дніпровський", 10500),
                ("ATS008", "Святошинський", 9700),
                ("ATS009", "Подільський", 8800),
                ("ATS010", "Деснянський", 11500),
                ("ATS011", "Софіївський", 7000),
                ("ATS012", "Борщагівський", 8200),
                ("ATS013", "Лісовий", 9300),
                ("ATS014", "Нивки", 7600),
                ("ATS015", "Троєщина", 10800),
                ("ATS016", "Березняки", 8500),
                ("ATS017", "Виноградар", 9900),
                ("ATS018", "Осокорки", 9400),
                ("ATS019", "Позняки", 9800),
                ("ATS020", "Відрадний", 9200)
            };

            // Дані для таблиці PaymentForServices
            var paymentData = new (string TelephoneNumber, string ATSNumber, decimal Cost, bool IsPaid)[]
            {
                ("380501234567", "ATS001", 150.00m, true),
                ("380671234568", "ATS002", 200.00m, false),
                ("380671234569", "ATS003", 175.50m, true),
                ("380631234560", "ATS004", 160.75m, false),
                ("380931234561", "ATS005", 180.00m, true),
                ("380931234562", "ATS006", 190.25m, false),
                ("380501234563", "ATS007", 165.00m, true),
                ("380501234564", "ATS008", 155.50m, false),
                ("380501234565", "ATS009", 170.75m, true),
                ("380501234566", "ATS010", 185.00m, false),
                ("380501234577", "ATS011", 195.25m, true),
                ("380501234578", "ATS012", 160.00m, false),
                ("380501234579", "ATS013", 175.50m, true),
                ("380501234580", "ATS014", 150.75m, false),
                ("380501234581", "ATS015", 180.00m, true),
                ("380501234582", "ATS016", 190.25m, false),
                ("380501234583", "ATS017", 165.00m, true),
                ("380501234584", "ATS018", 155.50m, false),
                ("380501234585", "ATS019", 170.75m, true),
                ("380501234586", "ATS020", 185.00m, false)
            };

            // Вставка даних у таблицю Telephone
            string insertTelephoneQuery = @"
                INSERT INTO Telephone (Number, InstallationDate, HasBlocker)
                VALUES (@Number, @InstallationDate, @HasBlocker);";

            using (var cmd = new MySqlCommand(insertTelephoneQuery, conn))
            {
                cmd.Parameters.Add("@Number", MySqlDbType.VarChar);
                cmd.Parameters.Add("@InstallationDate", MySqlDbType.Date);
                cmd.Parameters.Add("@HasBlocker", MySqlDbType.Bit);

                foreach (var data in telephoneData)
                {
                    cmd.Parameters["@Number"].Value = data.Number;
                    cmd.Parameters["@InstallationDate"].Value = data.InstallationDate;
                    cmd.Parameters["@HasBlocker"].Value = data.HasBlocker;
                    cmd.ExecuteNonQuery();
                }
            }

            // Вставка даних у таблицю ATS
            string insertATSQuery = @"
                INSERT INTO ATS (Number, District, TotalNumbers)
                VALUES (@Number, @District, @TotalNumbers);";

            using (var cmd = new MySqlCommand(insertATSQuery, conn))
            {
                cmd.Parameters.Add("@Number", MySqlDbType.VarChar);
                cmd.Parameters.Add("@District", MySqlDbType.VarChar);
                cmd.Parameters.Add("@TotalNumbers", MySqlDbType.Int32);

                foreach (var data in atsData)
                {
                    cmd.Parameters["@Number"].Value = data.Number;
                    cmd.Parameters["@District"].Value = data.District;
                    cmd.Parameters["@TotalNumbers"].Value = data.TotalNumbers;
                    cmd.ExecuteNonQuery();
                }
            }

            // Вставка даних у таблицю PaymentForServices
            string insertPaymentQuery = @"
                INSERT INTO PaymentForServices (TelephoneNumber, ATSNumber, Cost, IsPaid)
                VALUES (@TelephoneNumber, @ATSNumber, @Cost, @IsPaid);";

            using (var cmd = new MySqlCommand(insertPaymentQuery, conn))
            {
                cmd.Parameters.Add("@TelephoneNumber", MySqlDbType.VarChar);
                cmd.Parameters.Add("@ATSNumber", MySqlDbType.VarChar);
                cmd.Parameters.Add("@Cost", MySqlDbType.Decimal);
                cmd.Parameters.Add("@IsPaid", MySqlDbType.Bit);

                foreach (var data in paymentData)
                {
                    cmd.Parameters["@TelephoneNumber"].Value = data.TelephoneNumber;
                    cmd.Parameters["@ATSNumber"].Value = data.ATSNumber;
                    cmd.Parameters["@Cost"].Value = data.Cost;
                    cmd.Parameters["@IsPaid"].Value = data.IsPaid;
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
