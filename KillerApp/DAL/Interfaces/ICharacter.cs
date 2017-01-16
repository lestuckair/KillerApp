using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KillerApp.Models;

namespace KillerApp.DAL.Interfaces
{
    public interface ICharacter
    {
        List<Monster> GetAllMonsters();
        Monster GetMonster();
        List<Player> GetAllPlayers();
        List<Player> GetPlayerCharacters();
        Player GetPlayer();
        bool CreatePlayerCharacter();
        List<Character> GetAllCharacters();
        List<Character> GetAllNPC();
        Character GetCharacter();

        //Alle soorten sql methods
    }
}
