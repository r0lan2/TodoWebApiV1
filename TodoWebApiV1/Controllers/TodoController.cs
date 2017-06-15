using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using AutoMapper;
using TodoWebApiV1.Entities;
using TodoWebApiV1.Models;

namespace TodoWebApiV1.Controllers
{
    public class TodoController: ApiController
    {

        private readonly TodoRepository _todoRepository= new TodoRepository(new TodoContext());

        public TodoController()
        {
         
        }


        [HttpGet()]
        public IHttpActionResult GetTodos()
        {
            var todos = _todoRepository.GetTodos();
            var results = Mapper.Map<IEnumerable<TodoDTO>>(todos);
            return Ok(results);
        }


        [HttpGet()]
        public IHttpActionResult GetTodo(int id)
        {
            var todo = _todoRepository.GetTodo(id);
            if (todo == null)
                return NotFound();
            var todoResult = Mapper.Map<TodoDTO>(todo);
            return Ok(todoResult);
        }

        [HttpPost()]
        public IHttpActionResult CreateTodo([FromBody] TodoDTO newTodo)
        {
            var todoEntity = Mapper.Map<Entities.Todo>(newTodo);
            _todoRepository.AddTodo(todoEntity);
            if (!_todoRepository.Save())
            {
                return BadRequest( "A problem happened while handling your request.");
            }
            var savedTodo = Mapper.Map<Models.TodoDTO>(todoEntity);

            return Ok(savedTodo);
        }
    }
}