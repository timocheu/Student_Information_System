using Student_Information_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Student_Information_System.Utilities
{
    public class SisContextLogger
    {
        private SisContext context;

        private int userId;
        private string level;

        public SisContextLogger(int userId, string level, SisContext context)
        {
            this.userId = userId;
            this.level = level;
            this.context = context;
        }

        public void Information(string action, string message, object obj = null)
        {
            if (obj is not null) 
            {
              string json = JsonSerializer.Serialize(obj);

              if (!message.EndsWith((char) Keys.Space))
              {
                message += " ";
              }

                message += json;
            }

            Logs log = new()
            {
                Timestamp = DateTime.Now.ToString(),
                UserId = userId,
                Level = level,
                Action = action,
                Message = $"[INFORMATION]: {message}",
            };

            context.Logs.Add(log);
            context.SaveChangesAsync();
        }

        public void Warning(string action, string message)
        {
            Logs log = new()
            {
                Timestamp = DateTime.Now.ToString(),
                UserId = userId,
                Level = level,
                Action = action,
                Message = $"[WARNING]: {message}",
            };

            context.Logs.Add(log);
            context.SaveChangesAsync();
        }

        public void Error(string action, string message, Exception ex)
        {
            Logs log = new()
            {
                Timestamp = DateTime.Now.ToString(),
                UserId = userId,
                Level = level,
                Action = action,
                Message = $"[ERROR]: {message}",
                Exception = $"{ex.GetType().Name}: {ex.Message}",
            };

            context.Logs.Add(log);
            context.SaveChangesAsync();
        }
    }
}
