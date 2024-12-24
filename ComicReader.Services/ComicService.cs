// ComicReader.Services/ComicService.cs
using Microsoft.EntityFrameworkCore;
using ComicReader.Models;

namespace ComicReader.Services
{
    public class ComicService : IComicService
    {
        private readonly ComicDbContext _context;

        public ComicService(ComicDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Comic>> GetAllComicsAsync()
        {
            return await _context.Comics
                .Include(c => c.Chapters)
                .ToListAsync();
        }

        public async Task<Comic> GetComicByIdAsync(int id)
        {
            return await _context.Comics
                .Include(c => c.Chapters)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<Chapter> GetChapterAsync(int comicId, int chapterId)
        {
            var comic = await GetComicByIdAsync(comicId);
            return comic?.Chapters?.FirstOrDefault(c => c.Id == chapterId);
        }

        public async Task SaveReadingProgressAsync(int comicId, int chapterId, int pageNumber)
        {
            // Implement reading progress saving logic
            await Task.CompletedTask;
        }
    }
}