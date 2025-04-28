using CombatPlanner.Shared.Auth;

namespace CombatPlanner.Client.Interfaces
{
    public interface IAuthService
    {
        public Task<AuthResponse?> Login(LoginRequest request);
        public Task<AuthResponse?> Register(RegisterRequest request);
    }
}
