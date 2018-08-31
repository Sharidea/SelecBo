using System.Collections.Generic;
using SelecBo.Models;

namespace SelecBo.Servies
{
    public class ScriptService : IScriptService
    {
        public ScriptService()
        {
            Patches = new List<PatchItem>();
        }

        public List<PatchItem> Patches { get; set; }

        public void Load()
        {
        }

        public void Run()
        {
        }
    }
}
