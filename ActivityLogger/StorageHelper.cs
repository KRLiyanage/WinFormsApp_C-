using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace ActivityLogger
{
    public static class StorageHelper
    {
        public static string GetFilePath()
        {
            string folderPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "ActivityLogger"
                );
            Directory.CreateDirectory( folderPath );

            return Path.Combine(folderPath, "log.json");
        }

        public static void SaveLog(List<WindowLogEntry> log)
        {
            string filePath = GetFilePath();
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(log, options);
            File.WriteAllText(filePath, json);
        }

        public static List<WindowLogEntry> LoadLog()
        {
            string filePath = GetFilePath();

            if (!File.Exists(filePath))
            {
                return new List<WindowLogEntry>();
            }

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<WindowLogEntry>>(json) ?? new List<WindowLogEntry>();
        }

        public static List<WindowLogEntry> GetLogs()
        {
            string filePath = GetFilePath() ;

            if(!File.Exists(filePath))
            {
                return new List<WindowLogEntry>() ;
            }

            string json = File.ReadAllText(filePath);

            return JsonSerializer.Deserialize<List<WindowLogEntry>>(json) ?? new List<WindowLogEntry>();
        }

    }
}
