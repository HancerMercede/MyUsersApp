using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyUsersApp.DTOs;
using MyUsersApp.Entities;
using MyUsersApp.Persistence;

namespace MyUsersApp.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public IList<UserDto> UsersDto { get; set; }
        public DetailsModel(ApplicationDbContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task OnGetAsync()
        {
           var usersDb = await _context.Users.ToListAsync();
           UsersDto = _mapper.Map<List<UserDto>>(usersDb);
        }
    }
}
