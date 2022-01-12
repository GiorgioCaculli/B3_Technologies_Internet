using System.Collections.Generic;
using Application.UseCases.Personnes.Dto;
using Application.UseCases.Sessions;
using Application.UseCases.Sessions.Dto;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/sessions")]
    public class SessionController: ControllerBase
    {
        private readonly UseCaseCreateSession _useCaseCreateSession;
        private readonly UseCaseGetAllSessions _useCaseGetAllSessions;
        private readonly UseCaseGetByIdSession _useCaseGetByIdSession;

        public SessionController(UseCaseCreateSession useCaseCreateSession, UseCaseGetAllSessions useCaseGetAllSessions, UseCaseGetByIdSession useCaseGetByIdSession)
        {
            _useCaseCreateSession = useCaseCreateSession;
            _useCaseGetAllSessions = useCaseGetAllSessions;
            _useCaseGetByIdSession = useCaseGetByIdSession;
        }

        [HttpPost]
        [ProducesResponseType(201)]
        public ActionResult<OutputDtoSession> Create(InputDtoSession dto)
        {
            return StatusCode(201, _useCaseCreateSession.Execute(dto));
        }

        [HttpGet]
        [ProducesResponseType(201)]
        public ActionResult<List<Domain.Personne>> GetAll()
        {
            return StatusCode(201, _useCaseGetAllSessions.Execute());
        }

        [HttpGet]
        [Route("{identifiant:int}")]
        [ProducesResponseType(201)]
        [ProducesResponseType(404)]
        public ActionResult<OutputDtoSession> GetById(int id)
        {
            try
            {
                return _useCaseGetByIdSession.Execute(id);
            }
            catch (KeyNotFoundException e)
            {
                return NotFound(e.Message);
            }
        }
    }
}
