using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfCrudUsers.Entities;
using WcfCrudUsers.EF;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data;
using WcfCrudUsers.Infrastructure;
using NLog;

namespace WcfCrudUsers
{    
    public class UserRepository : IUser
    {
        private UserContext _context;

        private readonly Logger _logger;

        public UserRepository()
        {
            _context = new UserContext();
            _logger = LogManager.GetCurrentClassLogger();
        }


        public IEnumerable<User> GetAll()
        {
            try
            {
                return _context.Users;
                
            }
            catch (EntityException ex)
            {
                _logger.Error(ex.Message);
                _logger.Trace(ex.StackTrace);
                throw new FaultException<WcfExceptionFault>(new WcfExceptionFault("База данных не доступна", "", false));
            }
        }

        public User Get(int id)
        {
            try
            {
                return _context.Users.Find(id);
            }
            catch (EntityException ex)
            {
                _logger.Error(ex.Message);
                _logger.Trace(ex.StackTrace);
                throw new FaultException<WcfExceptionFault>(new WcfExceptionFault("База данных не доступна", "", false));
            }
        }

        public void Update(User user)
        {
            try
            {
                _context.Entry(user).State = System.Data.Entity.EntityState.Modified;
                _context.SaveChanges();
            }
            catch (EntityException ex)
            {
                _logger.Error(ex.Message);
                _logger.Trace(ex.StackTrace);
                throw new FaultException<WcfExceptionFault>(new WcfExceptionFault("База данных не доступна", "", false));
            }
        }

        public void Delete(int id)
        {
            try
            {
                User user = _context.Users.Find(id);
                if (user != null)
                {
                    _context.Users.Remove(user);
                    _context.SaveChanges();
                }
            }
            catch (EntityException ex)
            {
                _logger.Error(ex.Message);
                _logger.Trace(ex.StackTrace);
                throw new FaultException<WcfExceptionFault>(new WcfExceptionFault("База данных не доступна", "", false));
            }
        }

        public void Create(User user)
        {
            try
            {
                _context.Users.Add(user);
                _context.SaveChanges();
            }
            catch (EntityException ex)
            {
                _logger.Error(ex.Message);
                _logger.Trace(ex.StackTrace);
                throw new FaultException<WcfExceptionFault>(new WcfExceptionFault("База данных не доступна", "", false));
            }
            
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private bool _disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                this._disposed = true;
            }
        }      
    }
}
