using XtraBlog.DAL;
using XtraBlog.Model;

namespace XtraBlog.Services
{
    public class LayoutService
    {
        private readonly ApplicationContext _context;
        public LayoutService(ApplicationContext applicationContext)
        {
            _context = applicationContext;
        }

        public Setting GetSetting()
        {
            return _context.Settings.FirstOrDefault();
        }
    }
}
