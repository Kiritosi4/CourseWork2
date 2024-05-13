using CourseWork.Persistance;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    internal static class Config
    {
        public const string ConfigPath = "config.json";
        public const string DefaultDbPath = "profiles/default.json";
        public const string CategoriesDbPath = "categories.json";

        public static ConfigDbContext ConfigDb;
        public static IDbRepository Db;


        public static void LoadCfg()
        {
            try
            {
                using (FileStream fs = new FileStream(ConfigPath, FileMode.OpenOrCreate))
                {
                    ConfigDb = JsonSerializer.Deserialize<ConfigDbContext>(fs);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Err to load cfg");
                ConfigDb = new ConfigDbContext();
                SaveCfg();
            }

        }

        public static async Task SaveCfg()
        {
            using (FileStream fs = File.Create(Config.ConfigPath))
            {
                await JsonSerializer.SerializeAsync<ConfigDbContext>(fs, ConfigDb);
            }
            MessageBox.Show(ConfigDb.CurrentDbPath);
        }

        public static void ChangeDefaultProfile(string path)
        {
            ConfigDb.CurrentDbPath = path;
            SaveCfg();
        }
    }
}
