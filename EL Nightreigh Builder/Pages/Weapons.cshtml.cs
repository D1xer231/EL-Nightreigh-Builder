using EL_Nightreigh_Builder.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EL_Nightreigh_Builder.Pages
{
    public class WeaponsModel : PageModel
    {
        private readonly AppDbContext _context;
        public List<Weapon> Weapons { get; set; } = new();

        public WeaponsModel(AppDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            Weapons = _context.Weapons.ToList();
        }
    }
}
