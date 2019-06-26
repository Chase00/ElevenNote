using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Data
{
    public class Note
    {
        [Key]
        [Display(Name = "NOTE4")]
        public int NoteId { get; set; }

        [Required]
        [Display(Name = "OWNER4")]
        public Guid OwnerId { get; set; }

        [Required]
        [Display(Name = "TITLE4")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "CONTENT4")]
        public string Content { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
