﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace clienteWPF.wsReniecWPF {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="wsReniecWPF.wsReniecSoap")]
    public interface wsReniecSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BuscarDNI", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet BuscarDNI(string dni);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BuscarDNI", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> BuscarDNIAsync(string dni);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ListarDNI", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet ListarDNI();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ListarDNI", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> ListarDNIAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarDNI", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet AgregarDNI(string Coddni, string Nombres, string ApellidoPaterno, string ApellidoMaterno, string Sexo, int año, int mes, int dia, string Nacionalidad, string Dirección);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarDNI", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> AgregarDNIAsync(string Coddni, string Nombres, string ApellidoPaterno, string ApellidoMaterno, string Sexo, int año, int mes, int dia, string Nacionalidad, string Dirección);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ActualizarDNI", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet ActualizarDNI(string Coddni, string Nombres, string ApellidoPaterno, string ApellidoMaterno, string Sexo, int año, int mes, int dia, string Nacionalidad, string Dirección);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ActualizarDNI", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> ActualizarDNIAsync(string Coddni, string Nombres, string ApellidoPaterno, string ApellidoMaterno, string Sexo, int año, int mes, int dia, string Nacionalidad, string Dirección);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EliminarDNI", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet EliminarDNI(string dni);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EliminarDNI", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> EliminarDNIAsync(string dni);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface wsReniecSoapChannel : clienteWPF.wsReniecWPF.wsReniecSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class wsReniecSoapClient : System.ServiceModel.ClientBase<clienteWPF.wsReniecWPF.wsReniecSoap>, clienteWPF.wsReniecWPF.wsReniecSoap {
        
        public wsReniecSoapClient() {
        }
        
        public wsReniecSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public wsReniecSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsReniecSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsReniecSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet BuscarDNI(string dni) {
            return base.Channel.BuscarDNI(dni);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> BuscarDNIAsync(string dni) {
            return base.Channel.BuscarDNIAsync(dni);
        }
        
        public System.Data.DataSet ListarDNI() {
            return base.Channel.ListarDNI();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ListarDNIAsync() {
            return base.Channel.ListarDNIAsync();
        }
        
        public System.Data.DataSet AgregarDNI(string Coddni, string Nombres, string ApellidoPaterno, string ApellidoMaterno, string Sexo, int año, int mes, int dia, string Nacionalidad, string Dirección) {
            return base.Channel.AgregarDNI(Coddni, Nombres, ApellidoPaterno, ApellidoMaterno, Sexo, año, mes, dia, Nacionalidad, Dirección);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> AgregarDNIAsync(string Coddni, string Nombres, string ApellidoPaterno, string ApellidoMaterno, string Sexo, int año, int mes, int dia, string Nacionalidad, string Dirección) {
            return base.Channel.AgregarDNIAsync(Coddni, Nombres, ApellidoPaterno, ApellidoMaterno, Sexo, año, mes, dia, Nacionalidad, Dirección);
        }
        
        public System.Data.DataSet ActualizarDNI(string Coddni, string Nombres, string ApellidoPaterno, string ApellidoMaterno, string Sexo, int año, int mes, int dia, string Nacionalidad, string Dirección) {
            return base.Channel.ActualizarDNI(Coddni, Nombres, ApellidoPaterno, ApellidoMaterno, Sexo, año, mes, dia, Nacionalidad, Dirección);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ActualizarDNIAsync(string Coddni, string Nombres, string ApellidoPaterno, string ApellidoMaterno, string Sexo, int año, int mes, int dia, string Nacionalidad, string Dirección) {
            return base.Channel.ActualizarDNIAsync(Coddni, Nombres, ApellidoPaterno, ApellidoMaterno, Sexo, año, mes, dia, Nacionalidad, Dirección);
        }
        
        public System.Data.DataSet EliminarDNI(string dni) {
            return base.Channel.EliminarDNI(dni);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> EliminarDNIAsync(string dni) {
            return base.Channel.EliminarDNIAsync(dni);
        }
    }
}
