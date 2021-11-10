using System;
using System.Collections.Generic;
using Domain;
using Infrastructure.SqlServer.Repositories.User;
using Microsoft.AspNetCore.Mvc;
using Services.UseCases.History;
using Services.UseCases.History.dtos;
using Services.UseCases.User;
using Services.UseCases.User.Dtos;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        private readonly UseCaseCreateHistoryItem _useCaseCreateHistoryItem;
        private readonly UseCaseGenerateVideoGameReport _useCaseGenerateVideoGameReport;
        private readonly UseCaseCreateUser _useCaseCreateUser;
        private readonly IUserRepository _userRepository;

        public UserController(
            UseCaseCreateHistoryItem useCaseCreateHistoryItem,
            UseCaseGenerateVideoGameReport useCaseGenerateVideoGameReport,
            UseCaseCreateUser useCaseCreateUser,
            IUserRepository userRepository)
        {
            _useCaseCreateHistoryItem = useCaseCreateHistoryItem;
            _useCaseGenerateVideoGameReport = useCaseGenerateVideoGameReport;
            _useCaseCreateUser = useCaseCreateUser;
            _userRepository = userRepository;
        }

        // TODO: write an endpoint for fetching all users
        [HttpGet]
        [Route("api/users")]
        public ActionResult<List<User>> GetAll()
        {
            return _userRepository.GetAll();
        }

        // TODO: add appropriate ProducesResponseType
        [HttpGet]
        [Route("{id:int}/history")]
        public ActionResult<OutputDtoVideoGameReport> GetHistory(int id)
        {
            // TODO: may throw an exception if user does not exist
            try
            {
                return _useCaseGenerateVideoGameReport.Execute(new InputDtoGenerateVideoGameReport
                {
                    UserId = id
                });
            }
            catch (KeyNotFoundException e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        // TODO: add appropriate ProducesResponseType
        [HttpPost]
        [Route("{id:int}/history")]
        public ActionResult<OutputDtoCreateHistoryItem> CreateHistoryItem(int id,
            [FromBody] InputDtoCreateHistoryItem dto)
        {
            // TODO: may throw an exception if user does not exist
            // TODO: may throw an exception if played time is equal or below 0
            dto.UserId = id;
            return _useCaseCreateHistoryItem.Execute(dto);
        }

        // TODO: write an endpoint for creating an user
        [HttpPost]
        [ProducesResponseType(201)]
        public ActionResult<OutputDtoUser> Create(InputDtoUser dto)
        {
            return StatusCode(201, _useCaseCreateUser.Execute(dto));
        }
    }
}