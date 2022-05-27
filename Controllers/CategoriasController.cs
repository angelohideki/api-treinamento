using ApiTreinamento.Domain;
using ApiTreinamento.DTOs;
using ApiTreinamento.Repository;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace ApiTreinamento.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private readonly IUnitOfWork _uof;
        private readonly IMapper _mapper;

        public CategoriasController(IUnitOfWork contexto, IMapper mapper)
        {
            _uof = contexto;
            _mapper = mapper;
        }

        [HttpGet("produtos")]
        public ActionResult<IEnumerable<CategoriaDTO>> GetCategoriasProdutos()
        {
            var categorias = _uof.CategoriaRepository.GetCategoriasProdutos().ToList();
            return _mapper.Map<List<CategoriaDTO>>(categorias);
   
        }
        [HttpGet]
        public ActionResult<IEnumerable<CategoriaDTO>> Get()
        {     
            var categorias = _uof.CategoriaRepository.Get().ToList();
            return _mapper.Map<List<CategoriaDTO>>(categorias);
            
        }

        [HttpGet("{id}", Name = "ObterCategoria")]
        public ActionResult<CategoriaDTO> Get(int id)
        {
            var categoria = _uof.CategoriaRepository.GetById(c => c.CategoriaId == id);

            if (categoria == null)
            {
                return NotFound("Categoria não encontrada...");
            }
            var categoriaDTO = _mapper.Map<CategoriaDTO>(categoria);
            return Ok(categoriaDTO);

        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, Categoria categoria)
        {

            var categoriaBanco = _uof.CategoriaRepository.GetById(c => c.CategoriaId == id);

            if (categoriaBanco == null)
            {
                return NotFound("Categoria não encontrada...");
            }
            
            if (id != categoria.CategoriaId)
            {
                return BadRequest();
            }

            _uof.CategoriaRepository.Update(categoria);
            _uof.Commit();
            
            return Ok(categoria);
        }

        [HttpPost]
        public ActionResult<Categoria> Post(Categoria categoria)
        {
            _uof.CategoriaRepository.Add(categoria);
            _uof.Commit();

            return new CreatedAtRouteResult("ObterCategoria",
                new { id = categoria.CategoriaId }, categoria);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var categoria = _uof.CategoriaRepository.GetById(c => c.CategoriaId == id);
            if (categoria == null)
            {
                return NotFound("Categoria não encontrada...");
            }
            _uof.CategoriaRepository.Delete(categoria);
            _uof.Commit();

            return Ok(categoria);
        }
    }
}
