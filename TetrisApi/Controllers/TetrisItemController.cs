using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TetrisApi.Models;
using TetrisApi.Dtos;
using AutoMapper;

namespace TetrisApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class TetrisItemsController : ControllerBase
    {
        private readonly TetrisContext _context;
        private readonly IMapper _mapper;

        public TetrisItemsController (TetrisContext context,IMapper mapper )
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TetrisItem>>> GetTetrisItems()
        {
           return await _context.Tetris.ToListAsync();
        }
        [HttpGet("id")]
        public async Task<ActionResult<TetrisItem>> GetTetrisItem(int id)
        {
            var tetrisItem =await _context.Tetris.FindAsync(id);
            if(tetrisItem == null)
            {
                return NotFound();
            }
             return tetrisItem;
        }
       [HttpPost]
       public ActionResult<TetrisItemCreatedDto> CreateScore(TetrisDtos tetrisDtos)
       {
           var subscription = _context.Tetris.FirstOrDefault(s=>s.UserName == tetrisDtos.UserName && s.Score == tetrisDtos.Score);
                if(subscription == null){
                    subscription =_mapper.Map<TetrisItem>(tetrisDtos);
                try
                {
                    _context.Tetris.Add(subscription);
                    _context.SaveChanges();
                }
                catch(Exception ex)
                {
                    return BadRequest(ex.Message);
                }

                }
            return Ok();       
       }
     
    }
}
