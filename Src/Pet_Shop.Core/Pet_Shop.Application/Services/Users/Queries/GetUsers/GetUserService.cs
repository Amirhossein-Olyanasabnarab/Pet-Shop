using Pet_Shop.Application.Interfaces.Contexts;
using Pet_Shop.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Shop.Application.Services.Users.Queries.GetUsers
{
    public class GetUserService : IGetUsersService
    {
        private readonly IDatabaseContext _context;
        public GetUserService(IDatabaseContext context)
        {
            _context = context;
        }

        public ResultGetUserDto Execute(RequestGetUserDto request)
        {
            var users = _context.Users.AsQueryable();
            if (!string.IsNullOrEmpty(request.SearchKey))
            {
                users = users.Where(p => p.FullName.Contains(request.SearchKey) && p.Email.Contains(request.SearchKey));
            }
            int rowsCount = 0;
            var usersList = users.ToPaged(request.Page, 20, out rowsCount).Select(p => new GetUsersDto
            {
                Id = p.Id,
                FullName = p.FullName,
                Email = p.Email,
            }).ToList();

            return new ResultGetUserDto
            {
                Rows = rowsCount,
                Users = usersList
            };
        }
    }
}
