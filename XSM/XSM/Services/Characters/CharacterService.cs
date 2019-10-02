using System;
using System.Collections.Generic;
using System.Linq;
using XSM.Data;
using XSM.Models;

namespace XSM.Services.Characters
{
    public class CharacterService : ICharacterService
    {
        public List<CharacterEntity> GetCharacters(int projectId)
        {
            return CharacterData.Characters()
                .Where(c => c.CreativeProjectId == projectId)
                .ToList();
        }
    }
}
