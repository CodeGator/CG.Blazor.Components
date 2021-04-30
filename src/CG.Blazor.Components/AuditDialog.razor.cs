﻿using CG.Business.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using MudBlazor;

namespace CG.Blazor.Components
{
    /// <summary>
    /// This class is the code-behind for the <see cref="AuditDialog{T}"/> razor view.
    /// </summary>
    public partial class AuditDialog<T> where T : AuditedModelBase
    {
        // *******************************************************************
        // Properties.
        // *******************************************************************

        #region Properties

        /// <summary>
        /// This property contains a reference to the dialog.
        /// </summary>
        [CascadingParameter]
        MudDialogInstance MudDialog { get; set; }

        /// <summary>
        /// This property contains a reference to the model.
        /// </summary>
        [Parameter]
        public T Model { get; set; }

        #endregion

        // *******************************************************************
        // Private methods.
        // *******************************************************************

        #region Private methods

        /// <summary>
        /// This method is called whenever the user cancels the dialog.
        /// </summary>
        private void Cancel()
        {
            MudDialog.Cancel();
        }

        /// <summary>
        /// This method is called whenever the user submits the dialog.
        /// </summary>
        /// <param name="context">The edit context to use for the operation.</param>
        private void OnValidSubmit(EditContext context)
        {
            MudDialog.Close(DialogResult.Ok(Model));
        }

        #endregion
    }
}
