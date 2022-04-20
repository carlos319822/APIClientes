using APIClientes.Data;

namespace APIClientes.Repositorio
{
    public class UserRepositorio : IUserRepositorio
    {
        private readonly ApplicationDbContext _db;

        public UserRepositorio(ApplicationDbContext db)
        {
            _db = db;
        }
        public Task<string> Login(string userName, string password)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Register(UserSecretsConfigurationExtensions user, string password)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UserExiste(string userName)
        {
            throw new NotImplementedException();
        }
    }
}
