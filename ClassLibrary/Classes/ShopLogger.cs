using ClassLibrary.Interfaces;

namespace ClassLibrary.Classes
{
    public class ShopLogger: ILogger
    {
        private IDb db;

        public ShopLogger(IDb db)
        {
            this.db = db;
        }

        public void Info(string message)
        {
            string logMessage = $"INFO: {message}";
            db.AddLogRecord(logMessage);
        }

        public void Warn(string message)
        {
            string logMessage = $"WARN: {message}";
            db.AddLogRecord(logMessage);
        }
    }
}
