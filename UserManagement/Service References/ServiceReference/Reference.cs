﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UserManagement.ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/WcfCrudUsers.Entities")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DOBField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool GenderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> VisitDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DOB {
            get {
                return this.DOBField;
            }
            set {
                if ((this.DOBField.Equals(value) != true)) {
                    this.DOBField = value;
                    this.RaisePropertyChanged("DOB");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Gender {
            get {
                return this.GenderField;
            }
            set {
                if ((this.GenderField.Equals(value) != true)) {
                    this.GenderField = value;
                    this.RaisePropertyChanged("Gender");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> VisitDate {
            get {
                return this.VisitDateField;
            }
            set {
                if ((this.VisitDateField.Equals(value) != true)) {
                    this.VisitDateField = value;
                    this.RaisePropertyChanged("VisitDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="WcfExceptionFault", Namespace="http://schemas.datacontract.org/2004/07/WcfCrudUsers.Infrastructure")]
    [System.SerializableAttribute()]
    public partial class WcfExceptionFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PropertyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool SucceedField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Property {
            get {
                return this.PropertyField;
            }
            set {
                if ((object.ReferenceEquals(this.PropertyField, value) != true)) {
                    this.PropertyField = value;
                    this.RaisePropertyChanged("Property");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Succeed {
            get {
                return this.SucceedField;
            }
            set {
                if ((this.SucceedField.Equals(value) != true)) {
                    this.SucceedField = value;
                    this.RaisePropertyChanged("Succeed");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.UserService")]
    public interface UserService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UserService/GetAll", ReplyAction="http://tempuri.org/UserService/GetAllResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserManagement.ServiceReference.WcfExceptionFault), Action="http://tempuri.org/UserService/GetAllWcfExceptionFaultFault", Name="WcfExceptionFault", Namespace="http://schemas.datacontract.org/2004/07/WcfCrudUsers.Infrastructure")]
        UserManagement.ServiceReference.User[] GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UserService/GetAll", ReplyAction="http://tempuri.org/UserService/GetAllResponse")]
        System.Threading.Tasks.Task<UserManagement.ServiceReference.User[]> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UserService/Get", ReplyAction="http://tempuri.org/UserService/GetResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserManagement.ServiceReference.WcfExceptionFault), Action="http://tempuri.org/UserService/GetWcfExceptionFaultFault", Name="WcfExceptionFault", Namespace="http://schemas.datacontract.org/2004/07/WcfCrudUsers.Infrastructure")]
        UserManagement.ServiceReference.User Get(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UserService/Get", ReplyAction="http://tempuri.org/UserService/GetResponse")]
        System.Threading.Tasks.Task<UserManagement.ServiceReference.User> GetAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UserService/Create", ReplyAction="http://tempuri.org/UserService/CreateResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserManagement.ServiceReference.WcfExceptionFault), Action="http://tempuri.org/UserService/CreateWcfExceptionFaultFault", Name="WcfExceptionFault", Namespace="http://schemas.datacontract.org/2004/07/WcfCrudUsers.Infrastructure")]
        void Create(UserManagement.ServiceReference.User item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UserService/Create", ReplyAction="http://tempuri.org/UserService/CreateResponse")]
        System.Threading.Tasks.Task CreateAsync(UserManagement.ServiceReference.User item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UserService/Update", ReplyAction="http://tempuri.org/UserService/UpdateResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserManagement.ServiceReference.WcfExceptionFault), Action="http://tempuri.org/UserService/UpdateWcfExceptionFaultFault", Name="WcfExceptionFault", Namespace="http://schemas.datacontract.org/2004/07/WcfCrudUsers.Infrastructure")]
        void Update(UserManagement.ServiceReference.User item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UserService/Update", ReplyAction="http://tempuri.org/UserService/UpdateResponse")]
        System.Threading.Tasks.Task UpdateAsync(UserManagement.ServiceReference.User item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UserService/Delete", ReplyAction="http://tempuri.org/UserService/DeleteResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(UserManagement.ServiceReference.WcfExceptionFault), Action="http://tempuri.org/UserService/DeleteWcfExceptionFaultFault", Name="WcfExceptionFault", Namespace="http://schemas.datacontract.org/2004/07/WcfCrudUsers.Infrastructure")]
        void Delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UserService/Delete", ReplyAction="http://tempuri.org/UserService/DeleteResponse")]
        System.Threading.Tasks.Task DeleteAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface UserServiceChannel : UserManagement.ServiceReference.UserService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserServiceClient : System.ServiceModel.ClientBase<UserManagement.ServiceReference.UserService>, UserManagement.ServiceReference.UserService {
        
        public UserServiceClient() {
        }
        
        public UserServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public UserManagement.ServiceReference.User[] GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<UserManagement.ServiceReference.User[]> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public UserManagement.ServiceReference.User Get(int id) {
            return base.Channel.Get(id);
        }
        
        public System.Threading.Tasks.Task<UserManagement.ServiceReference.User> GetAsync(int id) {
            return base.Channel.GetAsync(id);
        }
        
        public void Create(UserManagement.ServiceReference.User item) {
            base.Channel.Create(item);
        }
        
        public System.Threading.Tasks.Task CreateAsync(UserManagement.ServiceReference.User item) {
            return base.Channel.CreateAsync(item);
        }
        
        public void Update(UserManagement.ServiceReference.User item) {
            base.Channel.Update(item);
        }
        
        public System.Threading.Tasks.Task UpdateAsync(UserManagement.ServiceReference.User item) {
            return base.Channel.UpdateAsync(item);
        }
        
        public void Delete(int id) {
            base.Channel.Delete(id);
        }
        
        public System.Threading.Tasks.Task DeleteAsync(int id) {
            return base.Channel.DeleteAsync(id);
        }
    }
}
