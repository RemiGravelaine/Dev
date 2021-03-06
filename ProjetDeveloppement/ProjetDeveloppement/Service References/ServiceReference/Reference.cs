﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetDeveloppement.ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AbonneEntity", Namespace="http://schemas.datacontract.org/2004/07/DTO")]
    [System.SerializableAttribute()]
    public partial class AbonneEntity : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PrenomField;
        
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
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nom {
            get {
                return this.NomField;
            }
            set {
                if ((object.ReferenceEquals(this.NomField, value) != true)) {
                    this.NomField = value;
                    this.RaisePropertyChanged("Nom");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Prenom {
            get {
                return this.PrenomField;
            }
            set {
                if ((object.ReferenceEquals(this.PrenomField, value) != true)) {
                    this.PrenomField = value;
                    this.RaisePropertyChanged("Prenom");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IAbonneServiceLibrary")]
    public interface IAbonneServiceLibrary {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAbonneServiceLibrary/GetInfoAbonne", ReplyAction="http://tempuri.org/IAbonneServiceLibrary/GetInfoAbonneResponse")]
        ProjetDeveloppement.ServiceReference.AbonneEntity GetInfoAbonne(string nom);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAbonneServiceLibrary/GetInfoAbonne", ReplyAction="http://tempuri.org/IAbonneServiceLibrary/GetInfoAbonneResponse")]
        System.Threading.Tasks.Task<ProjetDeveloppement.ServiceReference.AbonneEntity> GetInfoAbonneAsync(string nom);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAbonneServiceLibrary/AddAbonne", ReplyAction="http://tempuri.org/IAbonneServiceLibrary/AddAbonneResponse")]
        void AddAbonne(ProjetDeveloppement.ServiceReference.AbonneEntity abonne);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAbonneServiceLibrary/AddAbonne", ReplyAction="http://tempuri.org/IAbonneServiceLibrary/AddAbonneResponse")]
        System.Threading.Tasks.Task AddAbonneAsync(ProjetDeveloppement.ServiceReference.AbonneEntity abonne);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAbonneServiceLibraryChannel : ProjetDeveloppement.ServiceReference.IAbonneServiceLibrary, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AbonneServiceLibraryClient : System.ServiceModel.ClientBase<ProjetDeveloppement.ServiceReference.IAbonneServiceLibrary>, ProjetDeveloppement.ServiceReference.IAbonneServiceLibrary {
        
        public AbonneServiceLibraryClient() {
        }
        
        public AbonneServiceLibraryClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AbonneServiceLibraryClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AbonneServiceLibraryClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AbonneServiceLibraryClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ProjetDeveloppement.ServiceReference.AbonneEntity GetInfoAbonne(string nom) {
            return base.Channel.GetInfoAbonne(nom);
        }
        
        public System.Threading.Tasks.Task<ProjetDeveloppement.ServiceReference.AbonneEntity> GetInfoAbonneAsync(string nom) {
            return base.Channel.GetInfoAbonneAsync(nom);
        }
        
        public void AddAbonne(ProjetDeveloppement.ServiceReference.AbonneEntity abonne) {
            base.Channel.AddAbonne(abonne);
        }
        
        public System.Threading.Tasks.Task AddAbonneAsync(ProjetDeveloppement.ServiceReference.AbonneEntity abonne) {
            return base.Channel.AddAbonneAsync(abonne);
        }
    }
}
