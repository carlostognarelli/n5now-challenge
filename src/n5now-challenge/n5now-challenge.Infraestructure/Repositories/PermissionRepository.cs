using Microsoft.EntityFrameworkCore;
using n5now_challenge.Domain.Entities;
using n5now_challenge.Domain.Interfaces;
using n5now_challenge.Infraestructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n5now_challenge.Infraestructure.Repositories
{
    public class PermissionRepository : IPermissionRepository
    {
        private readonly N5NowChallengeDbContext _context;

        public PermissionRepository(N5NowChallengeDbContext context)
        {
            _context = context;
        }

        public async Task<List<Permission>> GetPermissions()
        {
            return await _context.Permission.ToListAsync();
        }

        public async Task RequestPermision(Permission permission)
        {
            await _context.Permission.AddAsync(permission);
            await _context.SaveChangesAsync();
        }

        public async Task ModifyPermision(Permission permission)
        {
            _context.Update(permission);
            await _context.SaveChangesAsync();
        }
    }
}
