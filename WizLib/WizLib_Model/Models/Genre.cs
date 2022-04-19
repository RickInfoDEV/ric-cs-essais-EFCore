using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizLib_Model.Models
{
    public class Genre
    {
        public int GenreId { get; set; }  //REM. : par défaut, EF Core comprendra qu'un champ de model, finissant par "Id", sera PK et auto-increment !
        public string Name { get; set; }

    }
}
