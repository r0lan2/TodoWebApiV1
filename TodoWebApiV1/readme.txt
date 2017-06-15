1) create a new todo POST
http://localhost:60772/api/todo/createtodo
in the body of the request:
{
	"Title": "Taks 66",
	"Complete": false
}
options in postman: raw /json
2) get all todos 
http://localhost:60772/api/todo

3) get todo by id
http://localhost:60772/api/todo/1