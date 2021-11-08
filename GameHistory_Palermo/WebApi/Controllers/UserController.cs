using Microsoft.AspNetCore.Mvc;
using Services.UseCases.History;
using Services.UseCases.History.dtos;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        private readonly UseCaseCreateHistoryItem _useCaseCreateHistoryItem;
        private readonly UseCaseGenerateVideoGameReport _useCaseGenerateVideoGameReport;

        public UserController(
            UseCaseCreateHistoryItem useCaseCreateHistoryItem,
            UseCaseGenerateVideoGameReport useCaseGenerateVideoGameReport)
        {
            _useCaseCreateHistoryItem = useCaseCreateHistoryItem;
            _useCaseGenerateVideoGameReport = useCaseGenerateVideoGameReport;
        }

        // TODO: write an endpoint for fetching all users

        // TODO: add appropriate ProducesResponseType
        [HttpGet]
        [Route("{id:int}/history")]
        public ActionResult<OutputDtoVideoGameReport> GetHistory(int id)
        {
            // TODO: may throw an exception if user does not exist
            return _useCaseGenerateVideoGameReport.Execute(new InputDtoGenerateVideoGameReport
            {
                UserId = id
            });
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
    }
}