using System.Collections.Generic;
using XSM.Models;

namespace XSM.Data
{
    class ProjectData
    {
        public List<CreativeProject> Projects = new List<CreativeProject>
        {
            new CreativeProject { Title = "Eragon", Genre = "Fantasy" },
            new CreativeProject { Title = "La sombra del viento", Genre = "Suspense" },
            new CreativeProject { Title = "Sesión nocturna", Genre = "Noire" },
            new CreativeProject { Title = "Ciudad de huesos", Genre = "Noire" }
        };
    }
}
