using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KillerApp.DAL.Interfaces;
using KillerApp.Models;

namespace KillerApp.DAL.MSSQL
{
    public class MssqlCharacterContext : ICharacter
    {
        //SQL querry's
        public List<Monster> GetAllMonsters()
        {
            throw new NotImplementedException();
        }

        public Monster GetMonster()
        {
            throw new NotImplementedException();
        }

        public List<Player> GetAllPlayers()
        {
            throw new NotImplementedException();
        }

        public List<Player> GetPlayerCharacters()
        {
            throw new NotImplementedException();
        }

        public Player GetPlayer()
        {
            throw new NotImplementedException();
        }

        public bool CreatePlayerCharacter()
        {
            throw new NotImplementedException();
        }

        public List<Character> GetAllCharacters()
        {
            throw new NotImplementedException();
        }

        public List<Character> GetAllNPC()
        {
            throw new NotImplementedException();
        }

        public Character GetCharacter()
        {
            throw new NotImplementedException();
        }
    }
}