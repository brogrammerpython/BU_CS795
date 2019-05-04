using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI_grid.Models
{
    public class Cell
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Question> Questions { get; set; }
    }
}
