using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer
{
    public class Repo
    {
        private readonly AppCorpDbContext _context;

        public Repo(AppCorpDbContext context)
        {
            _context = context;
        }

        public List<Profile> GetProfiles() => _context.Profiles.ToList();

        public async Task<List<Profile>> GetPagedProfiles(int pageNumber, int pageSize) => await _context.Profiles
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        public async Task<bool> LogMessages(List<Message> messagesSent)
        {
            await _context.MessagesLog.AddRangeAsync(messagesSent);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
