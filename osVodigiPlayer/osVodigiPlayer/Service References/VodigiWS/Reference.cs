﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace osVodigiPlayer.VodigiWS {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.vodigi.com/", ConfigurationName="VodigiWS.VodigiWSSoap")]
    public interface VodigiWSSoap {
        
        // CODEGEN: Generating message contract since element name PlayerRegistrationCode from namespace http://www.vodigi.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.vodigi.com/PlayerRegistered", ReplyAction="*")]
        osVodigiPlayer.VodigiWS.PlayerRegisteredResponse PlayerRegistered(osVodigiPlayer.VodigiWS.PlayerRegisteredRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.vodigi.com/PlayerRegistered", ReplyAction="*")]
        System.Threading.Tasks.Task<osVodigiPlayer.VodigiWS.PlayerRegisteredResponse> PlayerRegisteredAsync(osVodigiPlayer.VodigiWS.PlayerRegisteredRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PlayerRegisteredRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PlayerRegistered", Namespace="http://www.vodigi.com/", Order=0)]
        public osVodigiPlayer.VodigiWS.PlayerRegisteredRequestBody Body;
        
        public PlayerRegisteredRequest() {
        }
        
        public PlayerRegisteredRequest(osVodigiPlayer.VodigiWS.PlayerRegisteredRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.vodigi.com/")]
    public partial class PlayerRegisteredRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string PlayerRegistrationCode;
        
        public PlayerRegisteredRequestBody() {
        }
        
        public PlayerRegisteredRequestBody(string PlayerRegistrationCode) {
            this.PlayerRegistrationCode = PlayerRegistrationCode;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PlayerRegisteredResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PlayerRegisteredResponse", Namespace="http://www.vodigi.com/", Order=0)]
        public osVodigiPlayer.VodigiWS.PlayerRegisteredResponseBody Body;
        
        public PlayerRegisteredResponse() {
        }
        
        public PlayerRegisteredResponse(osVodigiPlayer.VodigiWS.PlayerRegisteredResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class PlayerRegisteredResponseBody {
        
        public PlayerRegisteredResponseBody() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface VodigiWSSoapChannel : osVodigiPlayer.VodigiWS.VodigiWSSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class VodigiWSSoapClient : System.ServiceModel.ClientBase<osVodigiPlayer.VodigiWS.VodigiWSSoap>, osVodigiPlayer.VodigiWS.VodigiWSSoap {
        
        public VodigiWSSoapClient() {
        }
        
        public VodigiWSSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public VodigiWSSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VodigiWSSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VodigiWSSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        osVodigiPlayer.VodigiWS.PlayerRegisteredResponse osVodigiPlayer.VodigiWS.VodigiWSSoap.PlayerRegistered(osVodigiPlayer.VodigiWS.PlayerRegisteredRequest request) {
            return base.Channel.PlayerRegistered(request);
        }
        
        public void PlayerRegistered(string PlayerRegistrationCode) {
            osVodigiPlayer.VodigiWS.PlayerRegisteredRequest inValue = new osVodigiPlayer.VodigiWS.PlayerRegisteredRequest();
            inValue.Body = new osVodigiPlayer.VodigiWS.PlayerRegisteredRequestBody();
            inValue.Body.PlayerRegistrationCode = PlayerRegistrationCode;
            osVodigiPlayer.VodigiWS.PlayerRegisteredResponse retVal = ((osVodigiPlayer.VodigiWS.VodigiWSSoap)(this)).PlayerRegistered(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<osVodigiPlayer.VodigiWS.PlayerRegisteredResponse> osVodigiPlayer.VodigiWS.VodigiWSSoap.PlayerRegisteredAsync(osVodigiPlayer.VodigiWS.PlayerRegisteredRequest request) {
            return base.Channel.PlayerRegisteredAsync(request);
        }
        
        public System.Threading.Tasks.Task<osVodigiPlayer.VodigiWS.PlayerRegisteredResponse> PlayerRegisteredAsync(string PlayerRegistrationCode) {
            osVodigiPlayer.VodigiWS.PlayerRegisteredRequest inValue = new osVodigiPlayer.VodigiWS.PlayerRegisteredRequest();
            inValue.Body = new osVodigiPlayer.VodigiWS.PlayerRegisteredRequestBody();
            inValue.Body.PlayerRegistrationCode = PlayerRegistrationCode;
            return ((osVodigiPlayer.VodigiWS.VodigiWSSoap)(this)).PlayerRegisteredAsync(inValue);
        }
    }
}
