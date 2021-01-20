﻿using Eplan.EplApi.DataModel;
using Eplan.EplApi.HEServices;

namespace DowntimeModule.EplanAPIHelper
{
    public static class EplanHelper
    {
        public static Project GetCurrentProject()
        {
            var selectionSet = new SelectionSet();
            selectionSet.LockSelectionByDefault = false;
            return selectionSet.GetCurrentProject(true);
        }
    }
}
