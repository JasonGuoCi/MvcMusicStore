﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsClient.WebServiceSample {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WebServiceSample.SampleServiceSoap")]
    public interface SampleServiceSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        WindowsFormsClient.WebServiceSample.HelloWorldResponse HelloWorld(WindowsFormsClient.WebServiceSample.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<WindowsFormsClient.WebServiceSample.HelloWorldResponse> HelloWorldAsync(WindowsFormsClient.WebServiceSample.HelloWorldRequest request);
        
        // CODEGEN: Generating message contract since element name str from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ReverseString", ReplyAction="*")]
        WindowsFormsClient.WebServiceSample.ReverseStringResponse ReverseString(WindowsFormsClient.WebServiceSample.ReverseStringRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ReverseString", ReplyAction="*")]
        System.Threading.Tasks.Task<WindowsFormsClient.WebServiceSample.ReverseStringResponse> ReverseStringAsync(WindowsFormsClient.WebServiceSample.ReverseStringRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsClient.WebServiceSample.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(WindowsFormsClient.WebServiceSample.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsClient.WebServiceSample.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(WindowsFormsClient.WebServiceSample.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReverseStringRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReverseString", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsClient.WebServiceSample.ReverseStringRequestBody Body;
        
        public ReverseStringRequest() {
        }
        
        public ReverseStringRequest(WindowsFormsClient.WebServiceSample.ReverseStringRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ReverseStringRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string str;
        
        public ReverseStringRequestBody() {
        }
        
        public ReverseStringRequestBody(string str) {
            this.str = str;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReverseStringResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReverseStringResponse", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsClient.WebServiceSample.ReverseStringResponseBody Body;
        
        public ReverseStringResponse() {
        }
        
        public ReverseStringResponse(WindowsFormsClient.WebServiceSample.ReverseStringResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ReverseStringResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ReverseStringResult;
        
        public ReverseStringResponseBody() {
        }
        
        public ReverseStringResponseBody(string ReverseStringResult) {
            this.ReverseStringResult = ReverseStringResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SampleServiceSoapChannel : WindowsFormsClient.WebServiceSample.SampleServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SampleServiceSoapClient : System.ServiceModel.ClientBase<WindowsFormsClient.WebServiceSample.SampleServiceSoap>, WindowsFormsClient.WebServiceSample.SampleServiceSoap {
        
        public SampleServiceSoapClient() {
        }
        
        public SampleServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SampleServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SampleServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SampleServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsClient.WebServiceSample.HelloWorldResponse WindowsFormsClient.WebServiceSample.SampleServiceSoap.HelloWorld(WindowsFormsClient.WebServiceSample.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            WindowsFormsClient.WebServiceSample.HelloWorldRequest inValue = new WindowsFormsClient.WebServiceSample.HelloWorldRequest();
            inValue.Body = new WindowsFormsClient.WebServiceSample.HelloWorldRequestBody();
            WindowsFormsClient.WebServiceSample.HelloWorldResponse retVal = ((WindowsFormsClient.WebServiceSample.SampleServiceSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WindowsFormsClient.WebServiceSample.HelloWorldResponse> WindowsFormsClient.WebServiceSample.SampleServiceSoap.HelloWorldAsync(WindowsFormsClient.WebServiceSample.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsClient.WebServiceSample.HelloWorldResponse> HelloWorldAsync() {
            WindowsFormsClient.WebServiceSample.HelloWorldRequest inValue = new WindowsFormsClient.WebServiceSample.HelloWorldRequest();
            inValue.Body = new WindowsFormsClient.WebServiceSample.HelloWorldRequestBody();
            return ((WindowsFormsClient.WebServiceSample.SampleServiceSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsClient.WebServiceSample.ReverseStringResponse WindowsFormsClient.WebServiceSample.SampleServiceSoap.ReverseString(WindowsFormsClient.WebServiceSample.ReverseStringRequest request) {
            return base.Channel.ReverseString(request);
        }
        
        public string ReverseString(string str) {
            WindowsFormsClient.WebServiceSample.ReverseStringRequest inValue = new WindowsFormsClient.WebServiceSample.ReverseStringRequest();
            inValue.Body = new WindowsFormsClient.WebServiceSample.ReverseStringRequestBody();
            inValue.Body.str = str;
            WindowsFormsClient.WebServiceSample.ReverseStringResponse retVal = ((WindowsFormsClient.WebServiceSample.SampleServiceSoap)(this)).ReverseString(inValue);
            return retVal.Body.ReverseStringResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WindowsFormsClient.WebServiceSample.ReverseStringResponse> WindowsFormsClient.WebServiceSample.SampleServiceSoap.ReverseStringAsync(WindowsFormsClient.WebServiceSample.ReverseStringRequest request) {
            return base.Channel.ReverseStringAsync(request);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsClient.WebServiceSample.ReverseStringResponse> ReverseStringAsync(string str) {
            WindowsFormsClient.WebServiceSample.ReverseStringRequest inValue = new WindowsFormsClient.WebServiceSample.ReverseStringRequest();
            inValue.Body = new WindowsFormsClient.WebServiceSample.ReverseStringRequestBody();
            inValue.Body.str = str;
            return ((WindowsFormsClient.WebServiceSample.SampleServiceSoap)(this)).ReverseStringAsync(inValue);
        }
    }
}