using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using WcfCrudUsers.Entities;
using WcfCrudUsers.Infrastructure;

namespace WcfCrudUsers
{
    [ServiceContract(Name="UserService")]
    public interface IUser : IDisposable
    {
        [FaultContract(typeof(WcfExceptionFault))]
        [OperationContract]
        IEnumerable<User> GetAll();

        [FaultContract(typeof(WcfExceptionFault))]
        [OperationContract]
        User Get(int id);

        [FaultContract(typeof(WcfExceptionFault))]
        [OperationContract]
        void Create(User item);

        [FaultContract(typeof(WcfExceptionFault))]
        [OperationContract]
        void Update(User item);

        [FaultContract(typeof(WcfExceptionFault))]
        [OperationContract]
        void Delete(int id);
    }


}
