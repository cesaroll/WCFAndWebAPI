﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyClient.MyServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Student", Namespace="http://schemas.datacontract.org/2004/07/ModelLib.Query")]
    [System.SerializableAttribute()]
    public partial class Student : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<int> GradesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public System.Collections.Generic.List<int> Grades {
            get {
                return this.GradesField;
            }
            set {
                if ((object.ReferenceEquals(this.GradesField, value) != true)) {
                    this.GradesField = value;
                    this.RaisePropertyChanged("Grades");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Country", Namespace="http://schemas.datacontract.org/2004/07/ModelLib.Query")]
    [System.SerializableAttribute()]
    public partial class Country : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MyServiceReference.IMyService")]
    public interface IMyService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/GetData", ReplyAction="http://tempuri.org/IMyService/GetDataResponse")]
        string GetData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/GetData", ReplyAction="http://tempuri.org/IMyService/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/GetMessage", ReplyAction="http://tempuri.org/IMyService/GetMessageResponse")]
        string GetMessage(string Name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/GetMessage", ReplyAction="http://tempuri.org/IMyService/GetMessageResponse")]
        System.Threading.Tasks.Task<string> GetMessageAsync(string Name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/GetResult", ReplyAction="http://tempuri.org/IMyService/GetResultResponse")]
        string GetResult(MyClient.MyServiceReference.Student Student);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/GetResult", ReplyAction="http://tempuri.org/IMyService/GetResultResponse")]
        System.Threading.Tasks.Task<string> GetResultAsync(MyClient.MyServiceReference.Student Student);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/GetTopper", ReplyAction="http://tempuri.org/IMyService/GetTopperResponse")]
        MyClient.MyServiceReference.Student GetTopper(System.Collections.Generic.List<MyClient.MyServiceReference.Student> Students);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/GetTopper", ReplyAction="http://tempuri.org/IMyService/GetTopperResponse")]
        System.Threading.Tasks.Task<MyClient.MyServiceReference.Student> GetTopperAsync(System.Collections.Generic.List<MyClient.MyServiceReference.Student> Students);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/GetMax", ReplyAction="http://tempuri.org/IMyService/GetMaxResponse")]
        int GetMax(System.Collections.Generic.List<int> ar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/GetMax", ReplyAction="http://tempuri.org/IMyService/GetMaxResponse")]
        System.Threading.Tasks.Task<int> GetMaxAsync(System.Collections.Generic.List<int> ar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/GetSorted", ReplyAction="http://tempuri.org/IMyService/GetSortedResponse")]
        System.Collections.Generic.List<int> GetSorted(System.Collections.Generic.List<int> ar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/GetSorted", ReplyAction="http://tempuri.org/IMyService/GetSortedResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<int>> GetSortedAsync(System.Collections.Generic.List<int> ar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/CountriesGetAll", ReplyAction="http://tempuri.org/IMyService/CountriesGetAllResponse")]
        System.Collections.Generic.List<MyClient.MyServiceReference.Country> CountriesGetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/CountriesGetAll", ReplyAction="http://tempuri.org/IMyService/CountriesGetAllResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<MyClient.MyServiceReference.Country>> CountriesGetAllAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMyServiceChannel : MyClient.MyServiceReference.IMyService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MyServiceClient : System.ServiceModel.ClientBase<MyClient.MyServiceReference.IMyService>, MyClient.MyServiceReference.IMyService {
        
        public MyServiceClient() {
        }
        
        public MyServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MyServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData() {
            return base.Channel.GetData();
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync() {
            return base.Channel.GetDataAsync();
        }
        
        public string GetMessage(string Name) {
            return base.Channel.GetMessage(Name);
        }
        
        public System.Threading.Tasks.Task<string> GetMessageAsync(string Name) {
            return base.Channel.GetMessageAsync(Name);
        }
        
        public string GetResult(MyClient.MyServiceReference.Student Student) {
            return base.Channel.GetResult(Student);
        }
        
        public System.Threading.Tasks.Task<string> GetResultAsync(MyClient.MyServiceReference.Student Student) {
            return base.Channel.GetResultAsync(Student);
        }
        
        public MyClient.MyServiceReference.Student GetTopper(System.Collections.Generic.List<MyClient.MyServiceReference.Student> Students) {
            return base.Channel.GetTopper(Students);
        }
        
        public System.Threading.Tasks.Task<MyClient.MyServiceReference.Student> GetTopperAsync(System.Collections.Generic.List<MyClient.MyServiceReference.Student> Students) {
            return base.Channel.GetTopperAsync(Students);
        }
        
        public int GetMax(System.Collections.Generic.List<int> ar) {
            return base.Channel.GetMax(ar);
        }
        
        public System.Threading.Tasks.Task<int> GetMaxAsync(System.Collections.Generic.List<int> ar) {
            return base.Channel.GetMaxAsync(ar);
        }
        
        public System.Collections.Generic.List<int> GetSorted(System.Collections.Generic.List<int> ar) {
            return base.Channel.GetSorted(ar);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<int>> GetSortedAsync(System.Collections.Generic.List<int> ar) {
            return base.Channel.GetSortedAsync(ar);
        }
        
        public System.Collections.Generic.List<MyClient.MyServiceReference.Country> CountriesGetAll() {
            return base.Channel.CountriesGetAll();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<MyClient.MyServiceReference.Country>> CountriesGetAllAsync() {
            return base.Channel.CountriesGetAllAsync();
        }
    }
}
