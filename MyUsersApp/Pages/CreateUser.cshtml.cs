using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyUsersApp.DTOs;
using MyUsersApp.Entities;
using MyUsersApp.Persistence;
using System.Threading.Tasks;

namespace MyUsersApp.Pages
{
    public class CreateUserModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        [BindProperty]
        public UserDto UserDto { get; set; }
        public CreateUserModel(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public IActionResult OnGet()
        {
            return Page();
        }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            
            if (!ModelState.IsValid)
            {
                return Page();
            }
           var UserDb = _mapper.Map<User>(UserDto);
            _context.Users.Add(UserDb);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
