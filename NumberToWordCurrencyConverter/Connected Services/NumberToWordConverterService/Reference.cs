﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NumberToWordCurrencyConverter.NumberToWordConverterService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="NumberToWordConverterService.INumberToWordConverterService")]
    public interface INumberToWordConverterService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INumberToWordConverterService/getNumber", ReplyAction="http://tempuri.org/INumberToWordConverterService/getNumberResponse")]
        string getNumber(string numAsString);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INumberToWordConverterService/getNumber", ReplyAction="http://tempuri.org/INumberToWordConverterService/getNumberResponse")]
        System.Threading.Tasks.Task<string> getNumberAsync(string numAsString);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface INumberToWordConverterServiceChannel : NumberToWordCurrencyConverter.NumberToWordConverterService.INumberToWordConverterService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NumberToWordConverterServiceClient : System.ServiceModel.ClientBase<NumberToWordCurrencyConverter.NumberToWordConverterService.INumberToWordConverterService>, NumberToWordCurrencyConverter.NumberToWordConverterService.INumberToWordConverterService {
        
        public NumberToWordConverterServiceClient() {
        }
        
        public NumberToWordConverterServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public NumberToWordConverterServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NumberToWordConverterServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NumberToWordConverterServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string getNumber(string numAsString) {
            return base.Channel.getNumber(numAsString);
        }
        
        public System.Threading.Tasks.Task<string> getNumberAsync(string numAsString) {
            return base.Channel.getNumberAsync(numAsString);
        }
    }
}