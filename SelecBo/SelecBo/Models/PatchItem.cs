using System;
using System.Collections.Generic;

namespace SelecBo.Models
{
    public class PatchItem
    {
        public PatchItem()
        {
            CommandArgumets = new List<PatchArgument>();
        }

        /// <summary>
        /// The title of patch item.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The info of patch item, tell user what does this patch for.
        /// </summary>
        public string Info { get; set; }

        /// <summary>
        /// The callback command. If <see cref="Selected"/> is <see cref="True"/>, finally this command will be called.
        /// </summary>
        public Action Command { get; set; }

        /// <summary>
        /// The arguments of <see cref="Command"/>.
        /// </summary>
        public List<PatchArgument> CommandArgumets { get; set; }

        /// <summary>
        /// Selected flag.
        /// </summary>
        public bool Selected { get; set; }

        /// <summary>
        /// Disabled flag.
        /// </summary>
        public bool Disabled { get; set; }
    }
}
