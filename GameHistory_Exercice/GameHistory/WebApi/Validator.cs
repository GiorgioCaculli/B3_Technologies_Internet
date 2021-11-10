using Domain;
using Infrastructure.SqlServer.Repositories.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.UseCases.User.Dtos;
using Services.UseCases.VideoGame.Dtos;

namespace WebApi
{
    public class Validator
    {
        private IUserRepository _userRepository;
        public Validator(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public int CreateGame(InputDtoVideoGame dto)
        {
            if (dto == null)
            {
                return StatusCodes.Status404NotFound;
            }

            return StatusCodes.Status201Created;
        }
    }
}