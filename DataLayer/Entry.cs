using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WPF_GUI_04.DataLayer
{
    [Table("Entry")]
    public class Entry
    {
        /// <summary>
        /// Unique identyfier of the Entity.
        /// IdentifierValue
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// The Expression.
        /// BusinessValue
        /// </summary>
        public string Expression { get; set; }

        /// <summary>
        /// The translation of the expression.
        /// BusinessValue
        /// </summary>
        public string Translation { get; set; }

        /// <summary>
        /// Further information of the expression
        /// BusinessValue
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// A list of references to files attached to the artefact.
        /// ReferenceValue
        /// </summary>
        public List<Artefact> Artefacts { get; set; }
    }
}