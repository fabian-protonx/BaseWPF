using System.ComponentModel.DataAnnotations.Schema;

namespace WPF_GUI_04.DataLayer
{
    [Table("Artefact")]
    public class Artefact
    {
        /// <summary>
        /// Unique identyfier of the Entity.
        /// IdentifierValue
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// The unique filename of the artefact
        /// in order to be enough flexible in the
        /// data folder structur.
        /// BusinessRecoureValue
        /// </summary>
        public string UniqueFileName { get; set; }

        /// <summary>
        /// The original filename.
        /// BusinessRecoureValue
        /// </summary>
        public string OriginalFileName { get; set; }

        /// <summary>
        /// Relative path underneath ProjecDataRootPath.
        /// BusinessRecoureValue
        /// </summary>
        public string RelativPath { get; set; }

        /// <summary>
        /// Type of the Artefact.
        /// e.g. picture voice pdf
        /// defined in ArtefactTypes
        /// MetaValue
        /// </summary>
        public string ArtefactType { get; set; }
    }
}