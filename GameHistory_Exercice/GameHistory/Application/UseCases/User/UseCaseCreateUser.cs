using Infrastructure.SqlServer.Repositories.User;
using Services.UseCases.User.Dtos;
using Services.UseCases.Utils;

namespace Services.UseCases.User
{
    public class UseCaseCreateUser : IWriting<OutputDtoUser, InputDtoUser>
    {
        private readonly IUserRepository _userRepository;

        public UseCaseCreateUser(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        
        public OutputDtoUser Execute(InputDtoUser dto)
        {
            var userFromDto = Mapper.GetInstance().Map<Domain.User>(dto);
            var userFromDb = _userRepository.Create(userFromDto);
            return Mapper.GetInstance().Map<OutputDtoUser>(userFromDb);
        }
    }
}