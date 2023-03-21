using Exercise3.Models;

namespace Exercise3.Services
{
    public interface IFileDbService
    {
        public IEnumerable<Student> Students { get; set; }
        Task SaveChanges();
    }

    public class FileDbService : IFileDbService
    {
        private readonly string _pathToFileDatabase;
        public IEnumerable<Student> Students { get; set; } = new List<Student>();
        public FileDbService(IConfiguration configuration)
        {
            _pathToFileDatabase = configuration.GetConnectionString("Default") ?? throw new ArgumentNullException(nameof(configuration));
            Initialize();
        }

        private void Initialize()
        {
            if (!File.Exists(_pathToFileDatabase))
            {
                return;
            }
            var lines = File.ReadLines(_pathToFileDatabase);

            var students = new List<Student>();

            //Tutaj należy przeparsować dane ze zmiennej lines, tak jak w drugim zadaniu

            Students = students;
        }

        public async Task SaveChanges()
        {
            await File.WriteAllLinesAsync(
                _pathToFileDatabase, 
                null //tutaj należy zapewnić listę stringów zawierającą odpowiednio sformatowane dane studentów
                     // np. Jan,Kowalski,s1234,3/20/1991,Informatyka,Dzienne,kowalski@wp.pl,Jan,Anna
                );
        }

    }
}
