using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KillerApp.DAL.Interfaces;

namespace KillerApp.DAL.Repository
{
    public class CharacterRepository
    {
        private ICharacter characterContext;

        public CharacterRepository(ICharacter characterContext)
        {
            this.characterContext = characterContext;
        }
    }
}