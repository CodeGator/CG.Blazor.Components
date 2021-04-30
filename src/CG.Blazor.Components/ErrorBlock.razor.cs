using Microsoft.AspNetCore.Components;
using System;

namespace CG.Blazor.Components
{
    /// <summary>
    /// This class is the code-behind for the <see cref="ErrorBlock"/> component.
    /// </summary>
    public partial class ErrorBlock
    {
        // *******************************************************************
        // Properties.
        // *******************************************************************

        #region Properties

        /// <summary>
        /// This property contains the content for the block.
        /// </summary>
        [Parameter]
        public string Content { get; set; }

        /// <summary>
        /// This property determines whether the block can be dismissed.
        /// </summary>
        [Parameter]
        public bool Dismissable { get; set; }

        #endregion
    }
}
