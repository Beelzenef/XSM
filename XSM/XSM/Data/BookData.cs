using System.Collections.Generic;
using XSM.Models;

namespace XSM.Data
{
    class ProjectData
    {
        public List<Project> Projects = new List<Project>
        {
            new Project { Title = "Eragon", Genre = "Fantasy" },
            new Project { Title = "La sombra del viento", Genre = "Suspense" },
            new Project { Title = "Sesión nocturna", Genre = "Noire" },
            new Project { Title = "Ciudad de huesos", Genre = "Noire" }
        };
    }
}
