﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Facturacion_Web_Api_Proyecto_Final.Contabilidad {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ws.contabilidad.com/", ConfigurationName="Contabilidad.Contabilidad")]
    public interface Contabilidad {
        
        // CODEGEN: Parameter 'auxiliar' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.contabilidad.com/Contabilidad/obtenerAuxiliaresRequest", ReplyAction="http://ws.contabilidad.com/Contabilidad/obtenerAuxiliaresResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="auxiliar")]
        Facturacion_Web_Api_Proyecto_Final.Contabilidad.obtenerAuxiliaresResponse obtenerAuxiliares(Facturacion_Web_Api_Proyecto_Final.Contabilidad.obtenerAuxiliaresRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.contabilidad.com/Contabilidad/obtenerAuxiliaresRequest", ReplyAction="http://ws.contabilidad.com/Contabilidad/obtenerAuxiliaresResponse")]
        System.Threading.Tasks.Task<Facturacion_Web_Api_Proyecto_Final.Contabilidad.obtenerAuxiliaresResponse> obtenerAuxiliaresAsync(Facturacion_Web_Api_Proyecto_Final.Contabilidad.obtenerAuxiliaresRequest request);
        
        // CODEGEN: Parameter 'detalleEntradaContable' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.contabilidad.com/Contabilidad/obtenerTransaccionesRequest", ReplyAction="http://ws.contabilidad.com/Contabilidad/obtenerTransaccionesResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="detalleEntradaContable")]
        Facturacion_Web_Api_Proyecto_Final.Contabilidad.obtenerTransaccionesResponse obtenerTransacciones(Facturacion_Web_Api_Proyecto_Final.Contabilidad.obtenerTransaccionesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.contabilidad.com/Contabilidad/obtenerTransaccionesRequest", ReplyAction="http://ws.contabilidad.com/Contabilidad/obtenerTransaccionesResponse")]
        System.Threading.Tasks.Task<Facturacion_Web_Api_Proyecto_Final.Contabilidad.obtenerTransaccionesResponse> obtenerTransaccionesAsync(Facturacion_Web_Api_Proyecto_Final.Contabilidad.obtenerTransaccionesRequest request);
        
        // CODEGEN: Parameter 'codigoError' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.contabilidad.com/Contabilidad/obtenerCodigosErrorRequest", ReplyAction="http://ws.contabilidad.com/Contabilidad/obtenerCodigosErrorResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="codigoError")]
        Facturacion_Web_Api_Proyecto_Final.Contabilidad.obtenerCodigosErrorResponse obtenerCodigosError(Facturacion_Web_Api_Proyecto_Final.Contabilidad.obtenerCodigosErrorRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.contabilidad.com/Contabilidad/obtenerCodigosErrorRequest", ReplyAction="http://ws.contabilidad.com/Contabilidad/obtenerCodigosErrorResponse")]
        System.Threading.Tasks.Task<Facturacion_Web_Api_Proyecto_Final.Contabilidad.obtenerCodigosErrorResponse> obtenerCodigosErrorAsync(Facturacion_Web_Api_Proyecto_Final.Contabilidad.obtenerCodigosErrorRequest request);
        
        // CODEGEN: Parameter 'asientoResponse' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.contabilidad.com/Contabilidad/crearAsientoRequest", ReplyAction="http://ws.contabilidad.com/Contabilidad/crearAsientoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="asientoResponse")]
        Facturacion_Web_Api_Proyecto_Final.Contabilidad.crearAsientoResponse crearAsiento(Facturacion_Web_Api_Proyecto_Final.Contabilidad.crearAsientoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.contabilidad.com/Contabilidad/crearAsientoRequest", ReplyAction="http://ws.contabilidad.com/Contabilidad/crearAsientoResponse")]
        System.Threading.Tasks.Task<Facturacion_Web_Api_Proyecto_Final.Contabilidad.crearAsientoResponse> crearAsientoAsync(Facturacion_Web_Api_Proyecto_Final.Contabilidad.crearAsientoRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ws.contabilidad.com/")]
    public partial class AuxiliarCatalogo : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string idField;
        
        private string descripcionField;
        
        private string estadoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("id");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string descripcion {
            get {
                return this.descripcionField;
            }
            set {
                this.descripcionField = value;
                this.RaisePropertyChanged("descripcion");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string estado {
            get {
                return this.estadoField;
            }
            set {
                this.estadoField = value;
                this.RaisePropertyChanged("estado");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ws.contabilidad.com/")]
    public partial class responseAsiento : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string descripcionField;
        
        private int idAsientoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string descripcion {
            get {
                return this.descripcionField;
            }
            set {
                this.descripcionField = value;
                this.RaisePropertyChanged("descripcion");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int idAsiento {
            get {
                return this.idAsientoField;
            }
            set {
                this.idAsientoField = value;
                this.RaisePropertyChanged("idAsiento");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ws.contabilidad.com/")]
    public partial class entradaContableDet : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string cuentaContableField;
        
        private string tipoMovimientoField;
        
        private float montoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string cuentaContable {
            get {
                return this.cuentaContableField;
            }
            set {
                this.cuentaContableField = value;
                this.RaisePropertyChanged("cuentaContable");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string tipoMovimiento {
            get {
                return this.tipoMovimientoField;
            }
            set {
                this.tipoMovimientoField = value;
                this.RaisePropertyChanged("tipoMovimiento");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public float monto {
            get {
                return this.montoField;
            }
            set {
                this.montoField = value;
                this.RaisePropertyChanged("monto");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ws.contabilidad.com/")]
    public partial class entradaContable : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string auxiliarField;
        
        private string descripcionField;
        
        private entradaContableDet[] entradasContablesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string auxiliar {
            get {
                return this.auxiliarField;
            }
            set {
                this.auxiliarField = value;
                this.RaisePropertyChanged("auxiliar");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string descripcion {
            get {
                return this.descripcionField;
            }
            set {
                this.descripcionField = value;
                this.RaisePropertyChanged("descripcion");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("entradaContable", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public entradaContableDet[] entradasContables {
            get {
                return this.entradasContablesField;
            }
            set {
                this.entradasContablesField = value;
                this.RaisePropertyChanged("entradasContables");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ws.contabilidad.com/")]
    public partial class codigoDeError : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int idField;
        
        private string descripcionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("id");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string descripcion {
            get {
                return this.descripcionField;
            }
            set {
                this.descripcionField = value;
                this.RaisePropertyChanged("descripcion");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ws.contabilidad.com/")]
    public partial class asientoDetalle : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string auxiliarField;
        
        private string codigoErrorField;
        
        private string cuentaContableField;
        
        private string descripcionAsiendoField;
        
        private string estadoField;
        
        private System.DateTime fechaAsientoField;
        
        private bool fechaAsientoFieldSpecified;
        
        private int idAsientoField;
        
        private float montoField;
        
        private string tipoMovimientoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string auxiliar {
            get {
                return this.auxiliarField;
            }
            set {
                this.auxiliarField = value;
                this.RaisePropertyChanged("auxiliar");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string codigoError {
            get {
                return this.codigoErrorField;
            }
            set {
                this.codigoErrorField = value;
                this.RaisePropertyChanged("codigoError");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string cuentaContable {
            get {
                return this.cuentaContableField;
            }
            set {
                this.cuentaContableField = value;
                this.RaisePropertyChanged("cuentaContable");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string descripcionAsiendo {
            get {
                return this.descripcionAsiendoField;
            }
            set {
                this.descripcionAsiendoField = value;
                this.RaisePropertyChanged("descripcionAsiendo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string estado {
            get {
                return this.estadoField;
            }
            set {
                this.estadoField = value;
                this.RaisePropertyChanged("estado");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public System.DateTime fechaAsiento {
            get {
                return this.fechaAsientoField;
            }
            set {
                this.fechaAsientoField = value;
                this.RaisePropertyChanged("fechaAsiento");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fechaAsientoSpecified {
            get {
                return this.fechaAsientoFieldSpecified;
            }
            set {
                this.fechaAsientoFieldSpecified = value;
                this.RaisePropertyChanged("fechaAsientoSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public int idAsiento {
            get {
                return this.idAsientoField;
            }
            set {
                this.idAsientoField = value;
                this.RaisePropertyChanged("idAsiento");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public float monto {
            get {
                return this.montoField;
            }
            set {
                this.montoField = value;
                this.RaisePropertyChanged("monto");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public string tipoMovimiento {
            get {
                return this.tipoMovimientoField;
            }
            set {
                this.tipoMovimientoField = value;
                this.RaisePropertyChanged("tipoMovimiento");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="obtenerAuxiliares", WrapperNamespace="http://ws.contabilidad.com/", IsWrapped=true)]
    public partial class obtenerAuxiliaresRequest {
        
        public obtenerAuxiliaresRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="obtenerAuxiliaresResponse", WrapperNamespace="http://ws.contabilidad.com/", IsWrapped=true)]
    public partial class obtenerAuxiliaresResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.contabilidad.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("auxiliar", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Facturacion_Web_Api_Proyecto_Final.Contabilidad.AuxiliarCatalogo[] auxiliar;
        
        public obtenerAuxiliaresResponse() {
        }
        
        public obtenerAuxiliaresResponse(Facturacion_Web_Api_Proyecto_Final.Contabilidad.AuxiliarCatalogo[] auxiliar) {
            this.auxiliar = auxiliar;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="obtenerTransacciones", WrapperNamespace="http://ws.contabilidad.com/", IsWrapped=true)]
    public partial class obtenerTransaccionesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.contabilidad.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string idAuxiliar;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.contabilidad.com/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string idAsiento;
        
        public obtenerTransaccionesRequest() {
        }
        
        public obtenerTransaccionesRequest(string idAuxiliar, string idAsiento) {
            this.idAuxiliar = idAuxiliar;
            this.idAsiento = idAsiento;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="obtenerTransaccionesResponse", WrapperNamespace="http://ws.contabilidad.com/", IsWrapped=true)]
    public partial class obtenerTransaccionesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.contabilidad.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("detalleEntradaContable", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Facturacion_Web_Api_Proyecto_Final.Contabilidad.asientoDetalle[] detalleEntradaContable;
        
        public obtenerTransaccionesResponse() {
        }
        
        public obtenerTransaccionesResponse(Facturacion_Web_Api_Proyecto_Final.Contabilidad.asientoDetalle[] detalleEntradaContable) {
            this.detalleEntradaContable = detalleEntradaContable;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="obtenerCodigosError", WrapperNamespace="http://ws.contabilidad.com/", IsWrapped=true)]
    public partial class obtenerCodigosErrorRequest {
        
        public obtenerCodigosErrorRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="obtenerCodigosErrorResponse", WrapperNamespace="http://ws.contabilidad.com/", IsWrapped=true)]
    public partial class obtenerCodigosErrorResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.contabilidad.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("codigoError", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Facturacion_Web_Api_Proyecto_Final.Contabilidad.codigoDeError[] codigoError;
        
        public obtenerCodigosErrorResponse() {
        }
        
        public obtenerCodigosErrorResponse(Facturacion_Web_Api_Proyecto_Final.Contabilidad.codigoDeError[] codigoError) {
            this.codigoError = codigoError;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="crearAsiento", WrapperNamespace="http://ws.contabilidad.com/", IsWrapped=true)]
    public partial class crearAsientoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.contabilidad.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Facturacion_Web_Api_Proyecto_Final.Contabilidad.entradaContable asiento;
        
        public crearAsientoRequest() {
        }
        
        public crearAsientoRequest(Facturacion_Web_Api_Proyecto_Final.Contabilidad.entradaContable asiento) {
            this.asiento = asiento;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="crearAsientoResponse", WrapperNamespace="http://ws.contabilidad.com/", IsWrapped=true)]
    public partial class crearAsientoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.contabilidad.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Facturacion_Web_Api_Proyecto_Final.Contabilidad.responseAsiento asientoResponse;
        
        public crearAsientoResponse() {
        }
        
        public crearAsientoResponse(Facturacion_Web_Api_Proyecto_Final.Contabilidad.responseAsiento asientoResponse) {
            this.asientoResponse = asientoResponse;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ContabilidadChannel : Facturacion_Web_Api_Proyecto_Final.Contabilidad.Contabilidad, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ContabilidadClient : System.ServiceModel.ClientBase<Facturacion_Web_Api_Proyecto_Final.Contabilidad.Contabilidad>, Facturacion_Web_Api_Proyecto_Final.Contabilidad.Contabilidad {
        
        public ContabilidadClient() {
        }
        
        public ContabilidadClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ContabilidadClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ContabilidadClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ContabilidadClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Facturacion_Web_Api_Proyecto_Final.Contabilidad.obtenerAuxiliaresResponse Facturacion_Web_Api_Proyecto_Final.Contabilidad.Contabilidad.obtenerAuxiliares(Facturacion_Web_Api_Proyecto_Final.Contabilidad.obtenerAuxiliaresRequest request) {
            return base.Channel.obtenerAuxiliares(request);
        }
        
        public Facturacion_Web_Api_Proyecto_Final.Contabilidad.AuxiliarCatalogo[] obtenerAuxiliares() {
            Facturacion_Web_Api_Proyecto_Final.Contabilidad.obtenerAuxiliaresRequest inValue = new Facturacion_Web_Api_Proyecto_Final.Contabilidad.obtenerAuxiliaresRequest();
            Facturacion_Web_Api_Proyecto_Final.Contabilidad.obtenerAuxiliaresResponse retVal = ((Facturacion_Web_Api_Proyecto_Final.Contabilidad.Contabilidad)(this)).obtenerAuxiliares(inValue);
            return retVal.auxiliar;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Facturacion_Web_Api_Proyecto_Final.Contabilidad.obtenerAuxiliaresResponse> Facturacion_Web_Api_Proyecto_Final.Contabilidad.Contabilidad.obtenerAuxiliaresAsync(Facturacion_Web_Api_Proyecto_Final.Contabilidad.obtenerAuxiliaresRequest request) {
            return base.Channel.obtenerAuxiliaresAsync(request);
        }
        
        public System.Threading.Tasks.Task<Facturacion_Web_Api_Proyecto_Final.Contabilidad.obtenerAuxiliaresResponse> obtenerAuxiliaresAsync() {
            Facturacion_Web_Api_Proyecto_Final.Contabilidad.obtenerAuxiliaresRequest inValue = new Facturacion_Web_Api_Proyecto_Final.Contabilidad.obtenerAuxiliaresRequest();
            return ((Facturacion_Web_Api_Proyecto_Final.Contabilidad.Contabilidad)(this)).obtenerAuxiliaresAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Facturacion_Web_Api_Proyecto_Final.Contabilidad.obtenerTransaccionesResponse Facturacion_Web_Api_Proyecto_Final.Contabilidad.Contabilidad.obtenerTransacciones(Facturacion_Web_Api_Proyecto_Final.Contabilidad.obtenerTransaccionesRequest request) {
            return base.Channel.obtenerTransacciones(request);
        }
        
        public Facturacion_Web_Api_Proyecto_Final.Contabilidad.asientoDetalle[] obtenerTransacciones(string idAuxiliar, string idAsiento) {
            Facturacion_Web_Api_Proyecto_Final.Contabilidad.obtenerTransaccionesRequest inValue = new Facturacion_Web_Api_Proyecto_Final.Contabilidad.obtenerTransaccionesRequest();
            inValue.idAuxiliar = idAuxiliar;
            inValue.idAsiento = idAsiento;
            Facturacion_Web_Api_Proyecto_Final.Contabilidad.obtenerTransaccionesResponse retVal = ((Facturacion_Web_Api_Proyecto_Final.Contabilidad.Contabilidad)(this)).obtenerTransacciones(inValue);
            return retVal.detalleEntradaContable;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Facturacion_Web_Api_Proyecto_Final.Contabilidad.obtenerTransaccionesResponse> Facturacion_Web_Api_Proyecto_Final.Contabilidad.Contabilidad.obtenerTransaccionesAsync(Facturacion_Web_Api_Proyecto_Final.Contabilidad.obtenerTransaccionesRequest request) {
            return base.Channel.obtenerTransaccionesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Facturacion_Web_Api_Proyecto_Final.Contabilidad.obtenerTransaccionesResponse> obtenerTransaccionesAsync(string idAuxiliar, string idAsiento) {
            Facturacion_Web_Api_Proyecto_Final.Contabilidad.obtenerTransaccionesRequest inValue = new Facturacion_Web_Api_Proyecto_Final.Contabilidad.obtenerTransaccionesRequest();
            inValue.idAuxiliar = idAuxiliar;
            inValue.idAsiento = idAsiento;
            return ((Facturacion_Web_Api_Proyecto_Final.Contabilidad.Contabilidad)(this)).obtenerTransaccionesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Facturacion_Web_Api_Proyecto_Final.Contabilidad.obtenerCodigosErrorResponse Facturacion_Web_Api_Proyecto_Final.Contabilidad.Contabilidad.obtenerCodigosError(Facturacion_Web_Api_Proyecto_Final.Contabilidad.obtenerCodigosErrorRequest request) {
            return base.Channel.obtenerCodigosError(request);
        }
        
        public Facturacion_Web_Api_Proyecto_Final.Contabilidad.codigoDeError[] obtenerCodigosError() {
            Facturacion_Web_Api_Proyecto_Final.Contabilidad.obtenerCodigosErrorRequest inValue = new Facturacion_Web_Api_Proyecto_Final.Contabilidad.obtenerCodigosErrorRequest();
            Facturacion_Web_Api_Proyecto_Final.Contabilidad.obtenerCodigosErrorResponse retVal = ((Facturacion_Web_Api_Proyecto_Final.Contabilidad.Contabilidad)(this)).obtenerCodigosError(inValue);
            return retVal.codigoError;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Facturacion_Web_Api_Proyecto_Final.Contabilidad.obtenerCodigosErrorResponse> Facturacion_Web_Api_Proyecto_Final.Contabilidad.Contabilidad.obtenerCodigosErrorAsync(Facturacion_Web_Api_Proyecto_Final.Contabilidad.obtenerCodigosErrorRequest request) {
            return base.Channel.obtenerCodigosErrorAsync(request);
        }
        
        public System.Threading.Tasks.Task<Facturacion_Web_Api_Proyecto_Final.Contabilidad.obtenerCodigosErrorResponse> obtenerCodigosErrorAsync() {
            Facturacion_Web_Api_Proyecto_Final.Contabilidad.obtenerCodigosErrorRequest inValue = new Facturacion_Web_Api_Proyecto_Final.Contabilidad.obtenerCodigosErrorRequest();
            return ((Facturacion_Web_Api_Proyecto_Final.Contabilidad.Contabilidad)(this)).obtenerCodigosErrorAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Facturacion_Web_Api_Proyecto_Final.Contabilidad.crearAsientoResponse Facturacion_Web_Api_Proyecto_Final.Contabilidad.Contabilidad.crearAsiento(Facturacion_Web_Api_Proyecto_Final.Contabilidad.crearAsientoRequest request) {
            return base.Channel.crearAsiento(request);
        }
        
        public Facturacion_Web_Api_Proyecto_Final.Contabilidad.responseAsiento crearAsiento(Facturacion_Web_Api_Proyecto_Final.Contabilidad.entradaContable asiento) {
            Facturacion_Web_Api_Proyecto_Final.Contabilidad.crearAsientoRequest inValue = new Facturacion_Web_Api_Proyecto_Final.Contabilidad.crearAsientoRequest();
            inValue.asiento = asiento;
            Facturacion_Web_Api_Proyecto_Final.Contabilidad.crearAsientoResponse retVal = ((Facturacion_Web_Api_Proyecto_Final.Contabilidad.Contabilidad)(this)).crearAsiento(inValue);
            return retVal.asientoResponse;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Facturacion_Web_Api_Proyecto_Final.Contabilidad.crearAsientoResponse> Facturacion_Web_Api_Proyecto_Final.Contabilidad.Contabilidad.crearAsientoAsync(Facturacion_Web_Api_Proyecto_Final.Contabilidad.crearAsientoRequest request) {
            return base.Channel.crearAsientoAsync(request);
        }
        
        public System.Threading.Tasks.Task<Facturacion_Web_Api_Proyecto_Final.Contabilidad.crearAsientoResponse> crearAsientoAsync(Facturacion_Web_Api_Proyecto_Final.Contabilidad.entradaContable asiento) {
            Facturacion_Web_Api_Proyecto_Final.Contabilidad.crearAsientoRequest inValue = new Facturacion_Web_Api_Proyecto_Final.Contabilidad.crearAsientoRequest();
            inValue.asiento = asiento;
            return ((Facturacion_Web_Api_Proyecto_Final.Contabilidad.Contabilidad)(this)).crearAsientoAsync(inValue);
        }
    }
}