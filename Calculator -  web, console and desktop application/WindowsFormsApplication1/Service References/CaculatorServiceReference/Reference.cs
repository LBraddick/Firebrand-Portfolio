﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CaculatorWindowsForms.CaculatorServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CaculatorServiceReference.CaculatorWebServiceSoap")]
    public interface CaculatorWebServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        int Add(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        System.Threading.Tasks.Task<int> AddAsync(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Sub", ReplyAction="*")]
        int Sub(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Sub", ReplyAction="*")]
        System.Threading.Tasks.Task<int> SubAsync(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Div", ReplyAction="*")]
        int Div(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Div", ReplyAction="*")]
        System.Threading.Tasks.Task<int> DivAsync(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Mul", ReplyAction="*")]
        int Mul(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Mul", ReplyAction="*")]
        System.Threading.Tasks.Task<int> MulAsync(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Mod", ReplyAction="*")]
        int Mod(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Mod", ReplyAction="*")]
        System.Threading.Tasks.Task<int> ModAsync(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Factorial", ReplyAction="*")]
        int Factorial(int X);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Factorial", ReplyAction="*")]
        System.Threading.Tasks.Task<int> FactorialAsync(int X);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CaculatorWebServiceSoapChannel : CaculatorWindowsForms.CaculatorServiceReference.CaculatorWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CaculatorWebServiceSoapClient : System.ServiceModel.ClientBase<CaculatorWindowsForms.CaculatorServiceReference.CaculatorWebServiceSoap>, CaculatorWindowsForms.CaculatorServiceReference.CaculatorWebServiceSoap {
        
        public CaculatorWebServiceSoapClient() {
        }
        
        public CaculatorWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CaculatorWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CaculatorWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CaculatorWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Add(int x, int y) {
            return base.Channel.Add(x, y);
        }
        
        public System.Threading.Tasks.Task<int> AddAsync(int x, int y) {
            return base.Channel.AddAsync(x, y);
        }
        
        public int Sub(int x, int y) {
            return base.Channel.Sub(x, y);
        }
        
        public System.Threading.Tasks.Task<int> SubAsync(int x, int y) {
            return base.Channel.SubAsync(x, y);
        }
        
        public int Div(int x, int y) {
            return base.Channel.Div(x, y);
        }
        
        public System.Threading.Tasks.Task<int> DivAsync(int x, int y) {
            return base.Channel.DivAsync(x, y);
        }
        
        public int Mul(int x, int y) {
            return base.Channel.Mul(x, y);
        }
        
        public System.Threading.Tasks.Task<int> MulAsync(int x, int y) {
            return base.Channel.MulAsync(x, y);
        }
        
        public int Mod(int x, int y) {
            return base.Channel.Mod(x, y);
        }
        
        public System.Threading.Tasks.Task<int> ModAsync(int x, int y) {
            return base.Channel.ModAsync(x, y);
        }
        
        public int Factorial(int X) {
            return base.Channel.Factorial(X);
        }
        
        public System.Threading.Tasks.Task<int> FactorialAsync(int X) {
            return base.Channel.FactorialAsync(X);
        }
    }
}
