using System.Reflection;

namespace MaasBordroUygulama.Core.Services
{
    public record LogGiris(DateTime Tarih, string LogDerecesi, string Mesaj, string Kaynak);

    public sealed class LogService
    {
        private static readonly Lazy<LogService> instance = new Lazy<LogService>(() => new LogService());
        private readonly string logFilePath;

        private string hedefDizin = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"..\..\..\", "Data\\Log");
        private string dosyaYolu = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"..\..\..\", "Data\\Log", "Log.txt");

        public LogService()
        {
            logFilePath = dosyaYolu;
        }
        public static LogService Instance => instance.Value;

        public void Log(LogGiris logGiris)
        {
            if (!Directory.Exists(hedefDizin))
            {
                Directory.CreateDirectory(hedefDizin);
            }

            if (!File.Exists(dosyaYolu))
            {
                using (FileStream fs = File.Create(dosyaYolu))
                {

                }
            }
            string logMessage = $"{logGiris.Tarih:yyyy-MM-dd HH:mm:ss} " +
                                $"[{logGiris.LogDerecesi}] ({logGiris.Kaynak}): {logGiris.Mesaj}";

            lock (this)
            {
                using (StreamWriter writer = new StreamWriter(logFilePath, true))
                {
                    writer.WriteLine(logMessage);
                }
            }
        }
    }
}