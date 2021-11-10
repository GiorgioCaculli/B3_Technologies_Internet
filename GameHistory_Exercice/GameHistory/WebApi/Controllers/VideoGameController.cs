using Infrastructure.SqlServer.Repositories.VideoGame;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.UseCases.VideoGame;
using Services.UseCases.VideoGame.Dtos;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/videogames")]
    public class VideoGameController : ControllerBase
    {
        private readonly UseCaseCreateVideoGame _useCaseCreateVideoGame;

        public VideoGameController(UseCaseCreateVideoGame useCaseCreateVideoGame)
        {
            _useCaseCreateVideoGame = useCaseCreateVideoGame;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult<OutputDtoVideoGame> Create(InputDtoVideoGame dto)
        {
            return StatusCode(201, _useCaseCreateVideoGame.Execute(dto));
        }
    }
}