using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoManager.DataLayer.Service;

namespace TodoManager.DataLayer.Context
{
    public class TodoManagerContext : IDisposable
    {
        TodoManager_dbEntities db = new TodoManager_dbEntities();
        private GenericTodoRepository<Todo> _todoRepository;

        public GenericTodoRepository<Todo> TodoRepository
        {
            get
            {
                if (_todoRepository == null)
                    _todoRepository = new GenericTodoRepository<Todo>(db);
                return _todoRepository;
            }
        }

        private GenericTodoRepository<User> _userRepository;

        public GenericTodoRepository<User> UserRepository
        {
            get
            {
                if (_userRepository == null)
                    _userRepository = new GenericTodoRepository<User>(db);

                return _userRepository;
            }
        }


        public void Dispose()
        {
            db.Dispose();
        }
        public void SaveChange()
        {
            db.SaveChanges();
        }
        
    }
}
