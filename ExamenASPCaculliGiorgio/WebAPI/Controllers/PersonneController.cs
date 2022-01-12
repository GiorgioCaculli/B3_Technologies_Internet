using System;
using System.Collections.Generic;
using Application.UseCases.Personnes;
using Application.UseCases.Personnes.Dto;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/personnes")]
    public class PersonneController: ControllerBase
    {
        private readonly UseCaseCreatePersonne _useCaseCreatePersonne;
        private readonly UseCaseGetAllPersonnes _useCaseGetAllPersonnes;
        private readonly UseCaseGetByIdPersonne _useCaseGetByIdPersonne;

        public PersonneController(UseCaseCreatePersonne useCaseCreatePersonne, UseCaseGetAllPersonnes useCaseGetAllPersonnes, UseCaseGetByIdPersonne useCaseGetByIdPersonne)
        {
            _useCaseCreatePersonne = useCaseCreatePersonne;
            _useCaseGetAllPersonnes = useCaseGetAllPersonnes;
            _useCaseGetByIdPersonne = useCaseGetByIdPersonne;
        }

        [HttpPost]
        [ProducesResponseType(201)]
        public ActionResult<OutputDtoPersonne> Create(InputDtoPersonne dto)
        {
            return StatusCode(201, _useCaseCreatePersonne.Execute(dto));
        }

        [HttpGet]
        [ProducesResponseType(201)]
        public ActionResult<List<Domain.Personne>> GetAll()
        {
            return StatusCode(201, _useCaseGetAllPersonnes.Execute());
        }

        [HttpGet]
        [Route("{identifiant:int}")]
        [ProducesResponseType(201)]
        [ProducesResponseType(404)]
        public ActionResult<OutputDtoPersonne> GetById(int id)
        {
            try
            {
                return _useCaseGetByIdPersonne.Execute(id);
            }
            catch (KeyNotFoundException e)
            {
                return NotFound(e.Message);
            }
        }
    }
}
