using System.Collections.Generic;
using XSM.Models;

namespace XSM.Data
{
    class ProjectData
    {
        public List<CreativeProject> Projects = new List<CreativeProject>
        {
            new CreativeProject
            {
                Id = 1,
                Title = "Eragon",
                Genre = "Fantasy"
            },
            new CreativeProject
            {
                Id = 2,
                Title = "La sombra del viento",
                Genre = "Suspense"
            },
            new CreativeProject
            {
                Id = 3,
                Title = "Sesión nocturna",
                Genre = "Noire"
            },
            new CreativeProject
            {
                Id = 4,
                Title = "Ciudad de huesos",
                Genre = "Noire"
            }
        };
    }
}
