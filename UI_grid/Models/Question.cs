using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI_grid.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int CellId { get; set; }
        public Cell Cell { get; set; }
        public ICollection<Answer> Answers { get; set; }
    }
}
