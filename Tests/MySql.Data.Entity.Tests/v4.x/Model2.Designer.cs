﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::System.Data.Objects.DataClasses.EdmSchemaAttribute()]
[assembly: global::System.Data.Objects.DataClasses.EdmRelationshipAttribute("juliotestsModel", "FK_ORDER_CUSTOMER", "customer", global::System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(MySql.Data.Entity.Tests.customer), "order", global::System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(MySql.Data.Entity.Tests.order))]

// Original file name:
// Generation date: 1/14/2013 3:17:09 PM
namespace MySql.Data.Entity.Tests
{
    
    /// <summary>
    /// There are no comments for model2Entities in the schema.
    /// </summary>
    public partial class model2Entities : global::System.Data.Objects.ObjectContext
    {
        /// <summary>
        /// Initializes a new model2Entities object using the connection string found in the 'model2Entities' section of the application configuration file.
        /// </summary>
        public model2Entities() : 
                base("name=model2Entities", "model2Entities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new model2Entities object.
        /// </summary>
        public model2Entities(string connectionString) : 
                base(connectionString, "model2Entities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new model2Entities object.
        /// </summary>
        public model2Entities(global::System.Data.EntityClient.EntityConnection connection) : 
                base(connection, "model2Entities")
        {
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// There are no comments for customer in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public global::System.Data.Objects.ObjectQuery<customer> customer
        {
            get
            {
                if ((this._customer == null))
                {
                    this._customer = base.CreateQuery<customer>("[customer]");
                }
                return this._customer;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private global::System.Data.Objects.ObjectQuery<customer> _customer;
        /// <summary>
        /// There are no comments for order in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public global::System.Data.Objects.ObjectQuery<order> order
        {
            get
            {
                if ((this._order == null))
                {
                    this._order = base.CreateQuery<order>("[order]");
                }
                return this._order;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private global::System.Data.Objects.ObjectQuery<order> _order;
        /// <summary>
        /// There are no comments for customer in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public void AddTocustomer(customer customer)
        {
            base.AddObject("customer", customer);
        }
        /// <summary>
        /// There are no comments for order in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public void AddToorder(order order)
        {
            base.AddObject("order", order);
        }
    }
    /// <summary>
    /// There are no comments for juliotestsModel.customer in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="juliotestsModel", Name="customer")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class customer : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// Create a new customer object.
        /// </summary>
        /// <param name="id">Initial value of Id.</param>
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public static customer Createcustomer(int id)
        {
            customer customer = new customer();
            customer.Id = id;
            return customer;
        }
        /// <summary>
        /// There are no comments for property Id in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this.ReportPropertyChanging("Id");
                this._Id = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("Id");
                this.OnIdChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private int _Id;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnIdChanging(int value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for property Name in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this.ReportPropertyChanging("Name");
                this._Name = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("Name");
                this.OnNameChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private string _Name;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnNameChanging(string value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for order in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("juliotestsModel", "FK_ORDER_CUSTOMER", "order")]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        [global::System.Xml.Serialization.XmlIgnoreAttribute()]
        [global::System.Xml.Serialization.SoapIgnoreAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Data.Objects.DataClasses.EntityCollection<order> order
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<order>("juliotestsModel.FK_ORDER_CUSTOMER", "order");
            }
            set
            {
                if ((value != null))
                {
                    ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedCollection<order>("juliotestsModel.FK_ORDER_CUSTOMER", "order", value);
                }
            }
        }
    }
    /// <summary>
    /// There are no comments for juliotestsModel.order in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="juliotestsModel", Name="order")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class order : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// Create a new order object.
        /// </summary>
        /// <param name="id">Initial value of Id.</param>
        /// <param name="order_Date">Initial value of Order_Date.</param>
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public static order Createorder(int id, global::System.DateTime order_Date)
        {
            order order = new order();
            order.Id = id;
            order.Order_Date = order_Date;
            return order;
        }
        /// <summary>
        /// There are no comments for property Id in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this.ReportPropertyChanging("Id");
                this._Id = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("Id");
                this.OnIdChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private int _Id;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnIdChanging(int value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for property Order_Date in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public global::System.DateTime Order_Date
        {
            get
            {
                return this._Order_Date;
            }
            set
            {
                this.OnOrder_DateChanging(value);
                this.ReportPropertyChanging("Order_Date");
                this._Order_Date = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("Order_Date");
                this.OnOrder_DateChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private global::System.DateTime _Order_Date;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnOrder_DateChanging(global::System.DateTime value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnOrder_DateChanged();
        /// <summary>
        /// There are no comments for customer in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("juliotestsModel", "FK_ORDER_CUSTOMER", "customer")]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        [global::System.Xml.Serialization.XmlIgnoreAttribute()]
        [global::System.Xml.Serialization.SoapIgnoreAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public customer customer
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<customer>("juliotestsModel.FK_ORDER_CUSTOMER", "customer").Value;
            }
            set
            {
                ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<customer>("juliotestsModel.FK_ORDER_CUSTOMER", "customer").Value = value;
            }
        }
        /// <summary>
        /// There are no comments for customer in the schema.
        /// </summary>
        [global::System.ComponentModel.BrowsableAttribute(false)]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Data.Objects.DataClasses.EntityReference<customer> customerReference
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<customer>("juliotestsModel.FK_ORDER_CUSTOMER", "customer");
            }
            set
            {
                if ((value != null))
                {
                    ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedReference<customer>("juliotestsModel.FK_ORDER_CUSTOMER", "customer", value);
                }
            }
        }
    }
}