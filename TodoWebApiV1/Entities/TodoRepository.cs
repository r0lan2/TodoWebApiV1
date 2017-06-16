using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TodoWebApiV1.Models;

namespace TodoWebApiV1.Entities
{
    public class TodoRepository : ITodoRepository
    {

        private TodoContext _context;
        public TodoRepository(TodoContext context)
        {
            _context = context;
        }

        public void DeletePointOfInterest(Todo todo)
        {
            _context.Todos.Remove(todo);
        }

        public Todo GetTodo(int todoId)
        {
            return _context.Todos.FirstOrDefault(t => t.Id == todoId);
        }

        public IEnumerable<Todo> GetTodos()
        {
            return _context.Todos.OrderBy(s => s.Title).ToList();
        }

        public Todo UpdateTodo(TodoDTO todo)
        {
            var todoEntityToUpdate = _context.Todos.FirstOrDefault(t => t.Id == todo.Id);
            todoEntityToUpdate.Complete = todo.Complete;
            todoEntityToUpdate.Title = todo.Title;
            return todoEntityToUpdate;
        }


        public void AddTodo(Todo newTodo)
        {
            _context.Todos.Add(newTodo);
        }

        public void DeleteTodo(int  todoId)
        {
            var todo = _context.Todos.FirstOrDefault(t => t.Id == todoId);
            _context.Todos.Remove(todo);
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }

        public bool TodoExists(int todoId)
        {
            return _context.Todos.Any(t => t.Id == todoId);
        }
    }


    public interface ITodoRepository
    {
        bool TodoExists(int todoId);
        IEnumerable<Todo> GetTodos();
        Todo GetTodo(int todoId);
        void AddTodo(Todo newTodo);
        void DeletePointOfInterest(Todo pointOfInterest);
        bool Save();
    }
}