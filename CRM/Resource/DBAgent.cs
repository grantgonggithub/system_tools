﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.1
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Resource
{
    using System.Data;
    using DBAccess;


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName = "ETCP.Client.ClientInterface.DBAgent.DBAgentSoap")]
    public interface DBAgentSoap
    {

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ExecuteNonQuery", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        int ExecuteNonQuery(SqlParam sqlParam, int poolId);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ExecuteDataSet", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        System.Data.DataSet ExecuteDataSet(SqlParam sqlParam, int poolId);
    }

    ///// <remarks/>
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    //[System.SerializableAttribute()]
    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.ComponentModel.DesignerCategoryAttribute("code")]
    //[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://tempuri.org/")]
    //public partial class SqlParam : object, System.ComponentModel.INotifyPropertyChanged
    //{

    //    private string commondTextField;

    //    private CommandType cmdTypeField;

    //    private string dataBaseNameField;

    //    private string[] paramsListField;

    //    private object[] valuesField;

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
    //    public string CommondText
    //    {
    //        get
    //        {
    //            return this.commondTextField;
    //        }
    //        set
    //        {
    //            this.commondTextField = value;
    //            this.RaisePropertyChanged("CommondText");
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
    //    public CommandType CmdType
    //    {
    //        get
    //        {
    //            return this.cmdTypeField;
    //        }
    //        set
    //        {
    //            this.cmdTypeField = value;
    //            this.RaisePropertyChanged("CmdType");
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
    //    public string DataBaseName
    //    {
    //        get
    //        {
    //            return this.dataBaseNameField;
    //        }
    //        set
    //        {
    //            this.dataBaseNameField = value;
    //            this.RaisePropertyChanged("DataBaseName");
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlArrayAttribute(Order = 3)]
    //    public string[] ParamsList
    //    {
    //        get
    //        {
    //            return this.paramsListField;
    //        }
    //        set
    //        {
    //            this.paramsListField = value;
    //            this.RaisePropertyChanged("ParamsList");
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlArrayAttribute(Order = 4)]
    //    public object[] Values
    //    {
    //        get
    //        {
    //            return this.valuesField;
    //        }
    //        set
    //        {
    //            this.valuesField = value;
    //            this.RaisePropertyChanged("Values");
    //        }
    //    }

    //    public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

    //    protected void RaisePropertyChanged(string propertyName)
    //    {
    //        System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
    //        if ((propertyChanged != null))
    //        {
    //            propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
    //        }
    //    }
    //}

    ///// <remarks/>
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    //[System.SerializableAttribute()]
    //[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://tempuri.org/")]
    //public enum CommandType
    //{

    //    /// <remarks/>
    //    Text,

    //    /// <remarks/>
    //    StoredProcedure,

    //    /// <remarks/>
    //    TableDirect,
    //}

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface DBAgentSoapChannel : DBAgentSoap, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DBAgentSoapClient : System.ServiceModel.ClientBase<DBAgentSoap>,DBAgentSoap
    {

        public DBAgentSoapClient()
        {
        }

        public DBAgentSoapClient(string endpointConfigurationName) :
            base(endpointConfigurationName)
        {
        }

        public DBAgentSoapClient(string endpointConfigurationName, string remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public DBAgentSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public DBAgentSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
        {
        }

        public int ExecuteNonQuery(SqlParam sqlParam, int poolId)
        {
            return base.Channel.ExecuteNonQuery(sqlParam, poolId);
        }

        public System.Data.DataSet ExecuteDataSet(SqlParam sqlParam, int poolId)
        {
            return base.Channel.ExecuteDataSet(sqlParam, poolId);
        }
    }
}