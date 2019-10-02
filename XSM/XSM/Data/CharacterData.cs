using System.Collections.Generic;
using XSM.Models;

namespace XSM.Data
{
    public static class CharacterData
    {
        public static List<CharacterEntity> Characters()
        {
            return new List<CharacterEntity>
            {
                new CharacterEntity
                {
                    Id = 1,
                    Name = "C1",
                    CreativeProjectId = 1
                },
                new CharacterEntity
                {
                    Id = 2,
                    Name = "C2",
                    CreativeProjectId = 1
                },
                new CharacterEntity
                {
                    Id = 3,
                    Name = "C3",
                    CreativeProjectId = 2
                }
            };
        }
    }
}
