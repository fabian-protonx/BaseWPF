using System.ComponentModel.DataAnnotations.Schema;

namespace WPF_GUI_04.DataLayer
{
    [Table("Setting")]
    public class Setting
    {
        /// <summary>
        /// Unique identyfier of the Entity.
        /// IdentifierValue
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Technical Key only for coding reasons.
        /// Used internaly by the Application in order to 
        /// target and work with a specific Setting-Item.
        /// IdentifierValue
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// The settings Name which will be 
        /// presented in the frontend.
        /// PresenterValue
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// The BusinessValue
        /// BusinessValue
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Further description of the setting.
        /// e.g. UseCase or hints about the used unit
        /// BusinessValue
        /// </summary>
        public string Info { get; set; }

        /// <summary>
        /// The type of the Settings.
        /// Mainly used to decide which presenter-control to
        /// use in oreder to properly display the value.
        /// MetaValue
        /// </summary>
        public string Type { get; set; } // bin, txt, col
    }
}