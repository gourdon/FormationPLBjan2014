﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.18052
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplicationJanvier.ServiceReferenceContact {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Contact", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Contact : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private long idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PrenomField;
        
        private System.DateTime DateNaissanceField;
        
        private long PaysIdField;
        
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
        public long id {
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public System.DateTime DateNaissance {
            get {
                return this.DateNaissanceField;
            }
            set {
                if ((this.DateNaissanceField.Equals(value) != true)) {
                    this.DateNaissanceField = value;
                    this.RaisePropertyChanged("DateNaissance");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public long PaysId {
            get {
                return this.PaysIdField;
            }
            set {
                if ((this.PaysIdField.Equals(value) != true)) {
                    this.PaysIdField = value;
                    this.RaisePropertyChanged("PaysId");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceContact.WebServiceContactSoap")]
    public interface WebServiceContactSoap {
        
        // CODEGEN : La génération du contrat de message depuis le nom d'élément ListerContactResult de l'espace de noms http://tempuri.org/ n'est pas marqué nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ListerContact", ReplyAction="*")]
        WindowsFormsApplicationJanvier.ServiceReferenceContact.ListerContactResponse ListerContact(WindowsFormsApplicationJanvier.ServiceReferenceContact.ListerContactRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ListerContact", ReplyAction="*")]
        System.Threading.Tasks.Task<WindowsFormsApplicationJanvier.ServiceReferenceContact.ListerContactResponse> ListerContactAsync(WindowsFormsApplicationJanvier.ServiceReferenceContact.ListerContactRequest request);
        
        // CODEGEN : La génération du contrat de message depuis le nom d'élément co de l'espace de noms http://tempuri.org/ n'est pas marqué nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EnregistrerContact", ReplyAction="*")]
        WindowsFormsApplicationJanvier.ServiceReferenceContact.EnregistrerContactResponse EnregistrerContact(WindowsFormsApplicationJanvier.ServiceReferenceContact.EnregistrerContactRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EnregistrerContact", ReplyAction="*")]
        System.Threading.Tasks.Task<WindowsFormsApplicationJanvier.ServiceReferenceContact.EnregistrerContactResponse> EnregistrerContactAsync(WindowsFormsApplicationJanvier.ServiceReferenceContact.EnregistrerContactRequest request);
        
        // CODEGEN : La génération du contrat de message depuis le nom d'élément nom de l'espace de noms http://tempuri.org/ n'est pas marqué nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TestEnregistrerContact", ReplyAction="*")]
        WindowsFormsApplicationJanvier.ServiceReferenceContact.TestEnregistrerContactResponse TestEnregistrerContact(WindowsFormsApplicationJanvier.ServiceReferenceContact.TestEnregistrerContactRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TestEnregistrerContact", ReplyAction="*")]
        System.Threading.Tasks.Task<WindowsFormsApplicationJanvier.ServiceReferenceContact.TestEnregistrerContactResponse> TestEnregistrerContactAsync(WindowsFormsApplicationJanvier.ServiceReferenceContact.TestEnregistrerContactRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListerContactRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListerContact", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsApplicationJanvier.ServiceReferenceContact.ListerContactRequestBody Body;
        
        public ListerContactRequest() {
        }
        
        public ListerContactRequest(WindowsFormsApplicationJanvier.ServiceReferenceContact.ListerContactRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ListerContactRequestBody {
        
        public ListerContactRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListerContactResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListerContactResponse", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsApplicationJanvier.ServiceReferenceContact.ListerContactResponseBody Body;
        
        public ListerContactResponse() {
        }
        
        public ListerContactResponse(WindowsFormsApplicationJanvier.ServiceReferenceContact.ListerContactResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ListerContactResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Collections.Generic.List<WindowsFormsApplicationJanvier.ServiceReferenceContact.Contact> ListerContactResult;
        
        public ListerContactResponseBody() {
        }
        
        public ListerContactResponseBody(System.Collections.Generic.List<WindowsFormsApplicationJanvier.ServiceReferenceContact.Contact> ListerContactResult) {
            this.ListerContactResult = ListerContactResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EnregistrerContactRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="EnregistrerContact", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsApplicationJanvier.ServiceReferenceContact.EnregistrerContactRequestBody Body;
        
        public EnregistrerContactRequest() {
        }
        
        public EnregistrerContactRequest(WindowsFormsApplicationJanvier.ServiceReferenceContact.EnregistrerContactRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class EnregistrerContactRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WindowsFormsApplicationJanvier.ServiceReferenceContact.Contact co;
        
        public EnregistrerContactRequestBody() {
        }
        
        public EnregistrerContactRequestBody(WindowsFormsApplicationJanvier.ServiceReferenceContact.Contact co) {
            this.co = co;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EnregistrerContactResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="EnregistrerContactResponse", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsApplicationJanvier.ServiceReferenceContact.EnregistrerContactResponseBody Body;
        
        public EnregistrerContactResponse() {
        }
        
        public EnregistrerContactResponse(WindowsFormsApplicationJanvier.ServiceReferenceContact.EnregistrerContactResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class EnregistrerContactResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public long EnregistrerContactResult;
        
        public EnregistrerContactResponseBody() {
        }
        
        public EnregistrerContactResponseBody(long EnregistrerContactResult) {
            this.EnregistrerContactResult = EnregistrerContactResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TestEnregistrerContactRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="TestEnregistrerContact", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsApplicationJanvier.ServiceReferenceContact.TestEnregistrerContactRequestBody Body;
        
        public TestEnregistrerContactRequest() {
        }
        
        public TestEnregistrerContactRequest(WindowsFormsApplicationJanvier.ServiceReferenceContact.TestEnregistrerContactRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class TestEnregistrerContactRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string nom;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string prenom;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string date_naissance;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public long pays_id;
        
        public TestEnregistrerContactRequestBody() {
        }
        
        public TestEnregistrerContactRequestBody(string nom, string prenom, string date_naissance, long pays_id) {
            this.nom = nom;
            this.prenom = prenom;
            this.date_naissance = date_naissance;
            this.pays_id = pays_id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TestEnregistrerContactResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="TestEnregistrerContactResponse", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsApplicationJanvier.ServiceReferenceContact.TestEnregistrerContactResponseBody Body;
        
        public TestEnregistrerContactResponse() {
        }
        
        public TestEnregistrerContactResponse(WindowsFormsApplicationJanvier.ServiceReferenceContact.TestEnregistrerContactResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class TestEnregistrerContactResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public long TestEnregistrerContactResult;
        
        public TestEnregistrerContactResponseBody() {
        }
        
        public TestEnregistrerContactResponseBody(long TestEnregistrerContactResult) {
            this.TestEnregistrerContactResult = TestEnregistrerContactResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceContactSoapChannel : WindowsFormsApplicationJanvier.ServiceReferenceContact.WebServiceContactSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceContactSoapClient : System.ServiceModel.ClientBase<WindowsFormsApplicationJanvier.ServiceReferenceContact.WebServiceContactSoap>, WindowsFormsApplicationJanvier.ServiceReferenceContact.WebServiceContactSoap {
        
        public WebServiceContactSoapClient() {
        }
        
        public WebServiceContactSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceContactSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceContactSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceContactSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsApplicationJanvier.ServiceReferenceContact.ListerContactResponse WindowsFormsApplicationJanvier.ServiceReferenceContact.WebServiceContactSoap.ListerContact(WindowsFormsApplicationJanvier.ServiceReferenceContact.ListerContactRequest request) {
            return base.Channel.ListerContact(request);
        }
        
        public System.Collections.Generic.List<WindowsFormsApplicationJanvier.ServiceReferenceContact.Contact> ListerContact() {
            WindowsFormsApplicationJanvier.ServiceReferenceContact.ListerContactRequest inValue = new WindowsFormsApplicationJanvier.ServiceReferenceContact.ListerContactRequest();
            inValue.Body = new WindowsFormsApplicationJanvier.ServiceReferenceContact.ListerContactRequestBody();
            WindowsFormsApplicationJanvier.ServiceReferenceContact.ListerContactResponse retVal = ((WindowsFormsApplicationJanvier.ServiceReferenceContact.WebServiceContactSoap)(this)).ListerContact(inValue);
            return retVal.Body.ListerContactResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WindowsFormsApplicationJanvier.ServiceReferenceContact.ListerContactResponse> WindowsFormsApplicationJanvier.ServiceReferenceContact.WebServiceContactSoap.ListerContactAsync(WindowsFormsApplicationJanvier.ServiceReferenceContact.ListerContactRequest request) {
            return base.Channel.ListerContactAsync(request);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApplicationJanvier.ServiceReferenceContact.ListerContactResponse> ListerContactAsync() {
            WindowsFormsApplicationJanvier.ServiceReferenceContact.ListerContactRequest inValue = new WindowsFormsApplicationJanvier.ServiceReferenceContact.ListerContactRequest();
            inValue.Body = new WindowsFormsApplicationJanvier.ServiceReferenceContact.ListerContactRequestBody();
            return ((WindowsFormsApplicationJanvier.ServiceReferenceContact.WebServiceContactSoap)(this)).ListerContactAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsApplicationJanvier.ServiceReferenceContact.EnregistrerContactResponse WindowsFormsApplicationJanvier.ServiceReferenceContact.WebServiceContactSoap.EnregistrerContact(WindowsFormsApplicationJanvier.ServiceReferenceContact.EnregistrerContactRequest request) {
            return base.Channel.EnregistrerContact(request);
        }
        
        public long EnregistrerContact(WindowsFormsApplicationJanvier.ServiceReferenceContact.Contact co) {
            WindowsFormsApplicationJanvier.ServiceReferenceContact.EnregistrerContactRequest inValue = new WindowsFormsApplicationJanvier.ServiceReferenceContact.EnregistrerContactRequest();
            inValue.Body = new WindowsFormsApplicationJanvier.ServiceReferenceContact.EnregistrerContactRequestBody();
            inValue.Body.co = co;
            WindowsFormsApplicationJanvier.ServiceReferenceContact.EnregistrerContactResponse retVal = ((WindowsFormsApplicationJanvier.ServiceReferenceContact.WebServiceContactSoap)(this)).EnregistrerContact(inValue);
            return retVal.Body.EnregistrerContactResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WindowsFormsApplicationJanvier.ServiceReferenceContact.EnregistrerContactResponse> WindowsFormsApplicationJanvier.ServiceReferenceContact.WebServiceContactSoap.EnregistrerContactAsync(WindowsFormsApplicationJanvier.ServiceReferenceContact.EnregistrerContactRequest request) {
            return base.Channel.EnregistrerContactAsync(request);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApplicationJanvier.ServiceReferenceContact.EnregistrerContactResponse> EnregistrerContactAsync(WindowsFormsApplicationJanvier.ServiceReferenceContact.Contact co) {
            WindowsFormsApplicationJanvier.ServiceReferenceContact.EnregistrerContactRequest inValue = new WindowsFormsApplicationJanvier.ServiceReferenceContact.EnregistrerContactRequest();
            inValue.Body = new WindowsFormsApplicationJanvier.ServiceReferenceContact.EnregistrerContactRequestBody();
            inValue.Body.co = co;
            return ((WindowsFormsApplicationJanvier.ServiceReferenceContact.WebServiceContactSoap)(this)).EnregistrerContactAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsApplicationJanvier.ServiceReferenceContact.TestEnregistrerContactResponse WindowsFormsApplicationJanvier.ServiceReferenceContact.WebServiceContactSoap.TestEnregistrerContact(WindowsFormsApplicationJanvier.ServiceReferenceContact.TestEnregistrerContactRequest request) {
            return base.Channel.TestEnregistrerContact(request);
        }
        
        public long TestEnregistrerContact(string nom, string prenom, string date_naissance, long pays_id) {
            WindowsFormsApplicationJanvier.ServiceReferenceContact.TestEnregistrerContactRequest inValue = new WindowsFormsApplicationJanvier.ServiceReferenceContact.TestEnregistrerContactRequest();
            inValue.Body = new WindowsFormsApplicationJanvier.ServiceReferenceContact.TestEnregistrerContactRequestBody();
            inValue.Body.nom = nom;
            inValue.Body.prenom = prenom;
            inValue.Body.date_naissance = date_naissance;
            inValue.Body.pays_id = pays_id;
            WindowsFormsApplicationJanvier.ServiceReferenceContact.TestEnregistrerContactResponse retVal = ((WindowsFormsApplicationJanvier.ServiceReferenceContact.WebServiceContactSoap)(this)).TestEnregistrerContact(inValue);
            return retVal.Body.TestEnregistrerContactResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WindowsFormsApplicationJanvier.ServiceReferenceContact.TestEnregistrerContactResponse> WindowsFormsApplicationJanvier.ServiceReferenceContact.WebServiceContactSoap.TestEnregistrerContactAsync(WindowsFormsApplicationJanvier.ServiceReferenceContact.TestEnregistrerContactRequest request) {
            return base.Channel.TestEnregistrerContactAsync(request);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApplicationJanvier.ServiceReferenceContact.TestEnregistrerContactResponse> TestEnregistrerContactAsync(string nom, string prenom, string date_naissance, long pays_id) {
            WindowsFormsApplicationJanvier.ServiceReferenceContact.TestEnregistrerContactRequest inValue = new WindowsFormsApplicationJanvier.ServiceReferenceContact.TestEnregistrerContactRequest();
            inValue.Body = new WindowsFormsApplicationJanvier.ServiceReferenceContact.TestEnregistrerContactRequestBody();
            inValue.Body.nom = nom;
            inValue.Body.prenom = prenom;
            inValue.Body.date_naissance = date_naissance;
            inValue.Body.pays_id = pays_id;
            return ((WindowsFormsApplicationJanvier.ServiceReferenceContact.WebServiceContactSoap)(this)).TestEnregistrerContactAsync(inValue);
        }
    }
}
