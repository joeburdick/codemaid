#region CodeMaid is Copyright 2007-2015 Steve Cadwallader.

// CodeMaid is free software: you can redistribute it and/or modify it under the terms of the GNU
// Lesser General Public License version 3 as published by the Free Software Foundation.
//
// CodeMaid is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without
// even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
// Lesser General Public License for more details <http://www.gnu.org/licenses/>.

#endregion CodeMaid is Copyright 2007-2015 Steve Cadwallader.

using SteveCadwallader.CodeMaid.Properties;
using SteveCadwallader.CodeMaid.UI.Enumerations;

namespace SteveCadwallader.CodeMaid.UI.Dialogs.Options.Cleaning
{
    /// <summary>
    /// The view model for cleaning general options.
    /// </summary>
    public class CleaningGeneralViewModel : OptionsPageViewModel
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CleaningGeneralViewModel" /> class.
        /// </summary>
        /// <param name="package">The hosting package.</param>
        /// <param name="activeSettings">The active settings.</param>
        public CleaningGeneralViewModel(CodeMaidPackage package, Settings activeSettings)
            : base(package, activeSettings)
        {
            Mappings = new SettingsToOptionsList(ActiveSettings, this)
            {
                new SettingToOptionMapping<bool, bool>(x => ActiveSettings.Cleaning_AutoCleanupOnFileSave, x => AutoCleanupOnFileSave),
                new SettingToOptionMapping<bool, bool>(x => ActiveSettings.Cleaning_AutoSaveAndCloseIfOpenedByCleanup, x => AutoSaveAndCloseIfOpenedByCleanup),
                new SettingToOptionMapping<int, AskYesNo>(x => ActiveSettings.Cleaning_PerformPartialCleanupOnExternal, x => PerformPartialCleanupOnExternal)
            };
        }

        #endregion Constructors

        #region Overrides of OptionsPageViewModel

        /// <summary>
        /// Gets the header.
        /// </summary>
        public override string Header
        {
            get { return "General"; }
        }

        #endregion Overrides of OptionsPageViewModel

        #region Options

        /// <summary>
        /// Gets or sets the flag indicating if cleanup should run automatically on file save.
        /// </summary>
        public bool AutoCleanupOnFileSave
        {
            get { return GetPropertyValue<bool>(); }
            set { SetPropertyValue(value); }
        }

        /// <summary>
        /// Gets or sets the flag indicating if files should be automatically saved and closed if
        /// opened by cleanup.
        /// </summary>
        public bool AutoSaveAndCloseIfOpenedByCleanup
        {
            get { return GetPropertyValue<bool>(); }
            set { SetPropertyValue(value); }
        }

        /// <summary>
        /// Gets or sets the options for performing partial cleanup on external files.
        /// </summary>
        public AskYesNo PerformPartialCleanupOnExternal
        {
            get { return GetPropertyValue<AskYesNo>(); }
            set { SetPropertyValue(value); }
        }

        #endregion Options
    }
}