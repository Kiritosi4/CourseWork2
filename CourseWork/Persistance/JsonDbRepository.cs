using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Text.Json;
using CourseWork.Persistance;
using System.Windows.Forms;
using System;


namespace CourseWork
{
    internal class JsonDbRepository : IDbRepository
    {
        public DbContext Db { get; set; }

        public bool TryLoadDb()
        {
            if (!string.IsNullOrEmpty(Config.ConfigDb.CurrentDbPath) && File.Exists(Config.ConfigDb.CurrentDbPath))
            {
                LoadDb(Config.ConfigDb.CurrentDbPath);
                return true;
            }
            else
            {
                Config.ConfigDb.CurrentDbPath = Config.DefaultDbPath;
                if (File.Exists(Config.DefaultDbPath))
                {
                    LoadDb(Config.DefaultDbPath);
                }
                else
                {
                    Db = new DbContext();
                }

                MessageBox.Show($"Файл с профилем не найден, изменения будут сохранятся в\n{Config.DefaultDbPath}");
                return false;
            }
        }

        void LoadDb(string path)
        {
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                {
                    Db = JsonSerializer.Deserialize<DbContext>(fs);
                }
            }
            catch (Exception e) 
            {
                MessageBox.Show($"Ошибка: некорректный формат базы данных.\n{e.Message}");
                Db = new DbContext();
            }
        }

        public async Task SaveChanges()
        {
            if (string.IsNullOrEmpty(Config.ConfigDb.CurrentDbPath) || !File.Exists(Config.ConfigDb.CurrentDbPath))
            {
                Config.ConfigDb.CurrentDbPath = Config.DefaultDbPath;
                MessageBox.Show($"База данных {Config.ConfigDb.CurrentDbPath} не найдена. Текущие изменения сохранятся в {Config.DefaultDbPath}");
            }

            try
            {
                string profilesDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
                if (!Directory.Exists(profilesDirectory))
                {
                    Directory.CreateDirectory(profilesDirectory);
                }

                using (FileStream fs = File.Create(Config.ConfigDb.CurrentDbPath))
                {
                    await JsonSerializer.SerializeAsync<DbContext>(fs, Db);
                }
            }catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public async Task AddToList<T>(List<T> list, T value)
        {
            list.Add(value);
            await SaveChanges();
        }

        public async Task RemoveFromList<T>(List<T> list, T value)
        {
            list.Remove(value);
            await SaveChanges();
        }

        public async Task RemoveFromListById<T>(List<T> list, int id)
        {
            list.RemoveAt(id);
            await SaveChanges();
        }

        public async Task AddToDict<T>(Dictionary<string, T> dict, string key, T value)
        {
            dict.Add(key, value);
            await SaveChanges();
        }

        public async Task RemoveFromDict<T>(Dictionary<string, T> dict, string key)
        {
            dict.Remove(key);
            await SaveChanges();
        }

    }
}
