using System.Collections.Generic;
using SelecBo.Models;

namespace SelecBo.Servies
{
    public interface IScriptService
    {
        List<PatchItem> Patches { get; set; }
        void Load();
        void Run();
    }
}
