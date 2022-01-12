using System.Collections.Generic;
using Application.UseCases.Parcours;
using Application.UseCases.Parcours.Dto;
using Application.UseCases.Personnes.Dto;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/parcours")]
    public class ParcoursController: ControllerBase
    {
        private readonly UseCaseCreateParcours _useCaseCreateParcours;
        private readonly UseCaseGetAllParcours _useCaseGetAllParcours;
        private readonly UseCaseGetByIdParcours _useCaseGetByIdParcours;

        public ParcoursController(UseCaseCreateParcours useCaseCreateParcours, UseCaseGetAllParcours useCaseGetAllParcours, UseCaseGetByIdParcours useCaseGetByIdParcours)
        {
            _useCaseCreateParcours = useCaseCreateParcours;
            _useCaseGetAllParcours = useCaseGetAllParcours;
            _useCaseGetByIdParcours = useCaseGetByIdParcours;
        }

        [HttpPost]
        [ProducesResponseType(201)]
        public ActionResult<OutputDtoParcours> Create(InputDtoParcours dto)
        {
            return StatusCode(201, _useCaseCreateParcours.Execute(dto));
        }

        [HttpGet]
        [ProducesResponseType(201)]
        public ActionResult<List<Domain.Parcours>> GetAll()
        {
            return StatusCode(201, _useCaseGetAllParcours.Execute());
        }

        [HttpGet]
        [Route("{identifiant:int}")]
        [ProducesResponseType(201)]
        [ProducesResponseType(404)]
        public ActionResult<OutputDtoParcours> GetById(int id)
        {
            try
            {
                return _useCaseGetByIdParcours.Execute(id);
            }
            catch (KeyNotFoundException e)
            {
                return NotFound(e.Message);
            }
        }
    }
}
