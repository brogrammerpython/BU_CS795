using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using UI_grid.Data;
using UI_grid.Models;

namespace UI_grid.Pages
{
    public class _55Model : PageModel
    {
        private readonly ApplicationDbContext _context;

        public _55Model(ApplicationDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public List<Answer> Answers { get; set; }
        public Question Question { get; set; }
        public List<string> Messages { get; set; }
        public void OnGet()
        {
            Question = _context.Question.FirstOrDefault(q => q.Id == 57);
            Answers = _context.Answer.Where(a => a.QuestionId == 57).AsNoTracking().ToList();
            Answers.ForEach(a => a.Correct = false);
        }
        public IActionResult OnPost()
        {
            Messages = new List<string>();
            Question = _context.Question.FirstOrDefault(q => q.Id == 57);

            if (!ModelState.IsValid)
            {
                return Page();
            }

            Answers = _context.Answer.Where(a => a.QuestionId == 57).AsNoTracking().ToList();

            for (int i = 0; i < Answers.Count; i++)
            {
                if (Answers[i].Correct == true)
                {
                    Messages.Add("Correct");
                }
                else
                {
                    Messages.Add("Incorrect");
                }
            }

            return Page();
        }
    }
}