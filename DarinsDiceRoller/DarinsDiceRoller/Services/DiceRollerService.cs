using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Essentials;
using SQLite;
using DarinsDiceRoller.Models;

namespace DarinsDiceRoller.Services
{
    public static class DiceRollerService
    {
        static SQLiteAsyncConnection db;
        static async Task Init()
        {
            
            if (db != null)
                return;

            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "D20CharacterDB");

            db = new SQLiteAsyncConnection(databasePath);

            await db.CreateTableAsync<D20Character>();
            await db.CreateTableAsync<Settings>();

        }

        public static async Task AddCharacter(String name, int str, int dex, int con, int intl, int wisd, int cha)
        {
            await Init();

            var character = new D20Character
            {
                Name = name,
                Strength = str,
                Dexterity = dex,
                Constitution = con,
                Intelligence = intl,
                Wisdom = wisd,
                Charisma = cha
            };

            var id = await db.InsertAsync(character);
        }

        public static async Task RemoveCharacter(int CharacterId)
        {
            await Init();

            await db.DeleteAsync<D20Character>(CharacterId);
        }

        public static async Task<IEnumerable<D20Character>> GetCharacter()
        {
            await Init();

            var characters = await db.Table<D20Character>().ToListAsync();

            return characters;
        }

    }
}
