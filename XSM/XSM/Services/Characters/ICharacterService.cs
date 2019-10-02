using System;
using System.Collections.Generic;
using XSM.Models;

namespace XSM.Services.Characters
{
    public interface ICharacterService
    {
        List<CharacterEntity> GetCharacters(int projectId);
    }
}
