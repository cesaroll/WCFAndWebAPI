﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyClientConsole.MySrvRefOnIIS {
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
        
        private int IdField;
        
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
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ReturnMsg", Namespace="http://schemas.datacontract.org/2004/07/ModelLib.Util")]
    [System.SerializableAttribute()]
    public partial class ReturnMsg : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ExceptionMsgField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool SuccessField;
        
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
        public string ExceptionMsg {
            get {
                return this.ExceptionMsgField;
            }
            set {
                if ((object.ReferenceEquals(this.ExceptionMsgField, value) != true)) {
                    this.ExceptionMsgField = value;
                    this.RaisePropertyChanged("ExceptionMsg");
                }
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
        public bool Success {
            get {
                return this.SuccessField;
            }
            set {
                if ((this.SuccessField.Equals(value) != true)) {
                    this.SuccessField = value;
                    this.RaisePropertyChanged("Success");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DivFault", Namespace="http://schemas.datacontract.org/2004/07/ModelLib.Util")]
    [System.SerializableAttribute()]
    public partial class DivFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OperationMessageField;
        
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
        public string OperationMessage {
            get {
                return this.OperationMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.OperationMessageField, value) != true)) {
                    this.OperationMessageField = value;
                    this.RaisePropertyChanged("OperationMessage");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MySrvRefOnIIS.IMyService")]
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
        string GetResult(MyClientConsole.MySrvRefOnIIS.Student Student);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/GetResult", ReplyAction="http://tempuri.org/IMyService/GetResultResponse")]
        System.Threading.Tasks.Task<string> GetResultAsync(MyClientConsole.MySrvRefOnIIS.Student Student);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/GetTopper", ReplyAction="http://tempuri.org/IMyService/GetTopperResponse")]
        MyClientConsole.MySrvRefOnIIS.Student GetTopper(System.Collections.Generic.List<MyClientConsole.MySrvRefOnIIS.Student> Students);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/GetTopper", ReplyAction="http://tempuri.org/IMyService/GetTopperResponse")]
        System.Threading.Tasks.Task<MyClientConsole.MySrvRefOnIIS.Student> GetTopperAsync(System.Collections.Generic.List<MyClientConsole.MySrvRefOnIIS.Student> Students);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/GetMax", ReplyAction="http://tempuri.org/IMyService/GetMaxResponse")]
        int GetMax(System.Collections.Generic.List<int> ar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/GetMax", ReplyAction="http://tempuri.org/IMyService/GetMaxResponse")]
        System.Threading.Tasks.Task<int> GetMaxAsync(System.Collections.Generic.List<int> ar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/GetSorted", ReplyAction="http://tempuri.org/IMyService/GetSortedResponse")]
        System.Collections.Generic.List<int> GetSorted(System.Collections.Generic.List<int> ar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/GetSorted", ReplyAction="http://tempuri.org/IMyService/GetSortedResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<int>> GetSortedAsync(System.Collections.Generic.List<int> ar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/CountriesGetAll", ReplyAction="http://tempuri.org/IMyService/CountriesGetAllResponse")]
        System.Collections.Generic.List<MyClientConsole.MySrvRefOnIIS.Country> CountriesGetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/CountriesGetAll", ReplyAction="http://tempuri.org/IMyService/CountriesGetAllResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<MyClientConsole.MySrvRefOnIIS.Country>> CountriesGetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/CountrySave", ReplyAction="http://tempuri.org/IMyService/CountrySaveResponse")]
        MyClientConsole.MySrvRefOnIIS.ReturnMsg CountrySave(MyClientConsole.MySrvRefOnIIS.Country Country);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/CountrySave", ReplyAction="http://tempuri.org/IMyService/CountrySaveResponse")]
        System.Threading.Tasks.Task<MyClientConsole.MySrvRefOnIIS.ReturnMsg> CountrySaveAsync(MyClientConsole.MySrvRefOnIIS.Country Country);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/MultiplyInt", ReplyAction="http://tempuri.org/IMyService/MultiplyIntResponse")]
        int MultiplyInt(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/MultiplyInt", ReplyAction="http://tempuri.org/IMyService/MultiplyIntResponse")]
        System.Threading.Tasks.Task<int> MultiplyIntAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/MultiplyDouble", ReplyAction="http://tempuri.org/IMyService/MultiplyDoubleResponse")]
        double MultiplyDouble(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/MultiplyDouble", ReplyAction="http://tempuri.org/IMyService/MultiplyDoubleResponse")]
        System.Threading.Tasks.Task<double> MultiplyDoubleAsync(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/DivInt", ReplyAction="http://tempuri.org/IMyService/DivIntResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(MyClientConsole.MySrvRefOnIIS.DivFault), Action="http://tempuri.org/IMyService/DivIntDivFaultFault", Name="DivFault", Namespace="http://schemas.datacontract.org/2004/07/ModelLib.Util")]
        int DivInt(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/DivInt", ReplyAction="http://tempuri.org/IMyService/DivIntResponse")]
        System.Threading.Tasks.Task<int> DivIntAsync(int a, int b);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMyServiceChannel : MyClientConsole.MySrvRefOnIIS.IMyService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MyServiceClient : System.ServiceModel.ClientBase<MyClientConsole.MySrvRefOnIIS.IMyService>, MyClientConsole.MySrvRefOnIIS.IMyService {
        
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
        
        public string GetResult(MyClientConsole.MySrvRefOnIIS.Student Student) {
            return base.Channel.GetResult(Student);
        }
        
        public System.Threading.Tasks.Task<string> GetResultAsync(MyClientConsole.MySrvRefOnIIS.Student Student) {
            return base.Channel.GetResultAsync(Student);
        }
        
        public MyClientConsole.MySrvRefOnIIS.Student GetTopper(System.Collections.Generic.List<MyClientConsole.MySrvRefOnIIS.Student> Students) {
            return base.Channel.GetTopper(Students);
        }
        
        public System.Threading.Tasks.Task<MyClientConsole.MySrvRefOnIIS.Student> GetTopperAsync(System.Collections.Generic.List<MyClientConsole.MySrvRefOnIIS.Student> Students) {
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
        
        public System.Collections.Generic.List<MyClientConsole.MySrvRefOnIIS.Country> CountriesGetAll() {
            return base.Channel.CountriesGetAll();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<MyClientConsole.MySrvRefOnIIS.Country>> CountriesGetAllAsync() {
            return base.Channel.CountriesGetAllAsync();
        }
        
        public MyClientConsole.MySrvRefOnIIS.ReturnMsg CountrySave(MyClientConsole.MySrvRefOnIIS.Country Country) {
            return base.Channel.CountrySave(Country);
        }
        
        public System.Threading.Tasks.Task<MyClientConsole.MySrvRefOnIIS.ReturnMsg> CountrySaveAsync(MyClientConsole.MySrvRefOnIIS.Country Country) {
            return base.Channel.CountrySaveAsync(Country);
        }
        
        public int MultiplyInt(int a, int b) {
            return base.Channel.MultiplyInt(a, b);
        }
        
        public System.Threading.Tasks.Task<int> MultiplyIntAsync(int a, int b) {
            return base.Channel.MultiplyIntAsync(a, b);
        }
        
        public double MultiplyDouble(double a, double b) {
            return base.Channel.MultiplyDouble(a, b);
        }
        
        public System.Threading.Tasks.Task<double> MultiplyDoubleAsync(double a, double b) {
            return base.Channel.MultiplyDoubleAsync(a, b);
        }
        
        public int DivInt(int a, int b) {
            return base.Channel.DivInt(a, b);
        }
        
        public System.Threading.Tasks.Task<int> DivIntAsync(int a, int b) {
            return base.Channel.DivIntAsync(a, b);
        }
    }
}
