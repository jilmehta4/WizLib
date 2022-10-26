using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizLib_Model.Models
{
    public class Genre
    {
        [Key]
        public int Genre_Id { get; set; }

        public string GenreName { get; set; }

        //public int DisplayOrder { get; set; }
    }
}
