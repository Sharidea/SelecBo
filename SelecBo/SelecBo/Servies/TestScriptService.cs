using SelecBo.Models;

namespace SelecBo.Servies
{
    public class TestScriptService : ScriptService
    {
        public override void Load()
        {
            Patches.Add(new PatchItem
            {
                Title = "Test Item",
                Info = "This is a test item",
                Selected = true
            });
        }
    }
}
