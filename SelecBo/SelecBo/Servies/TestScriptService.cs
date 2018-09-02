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
                Selected = true,
            });
            Patches.Add(new PatchItem
            {
                Title = "Test Item 2",
                Info = "This is another test item",
                Selected = false,
            });
            Patches[0].CommandArgumets.Add(new PatchArgument<string>
            {
                Name = "MieMie",
            });
        }
    }
}
