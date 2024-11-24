namespace Lab12
{
    public class Message
    {
        public string Sender { get; set; }
        public string Theme { get; set; }
        public string Text { get; set; }

        // Конструктор для ініціалізації властивостей
        public Message(string sender, string theme, string text)
        {
            Sender = sender;
            Theme = theme;
            Text = text;
        }

        // Пустий конструктор для ініціалізації через об'єктні ініціалізатори
        public Message()
        {
            Sender = string.Empty;
            Theme = string.Empty;
            Text = string.Empty;
        }
    }
}