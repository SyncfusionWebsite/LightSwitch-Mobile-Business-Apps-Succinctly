﻿
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightSwitchApplication
{
    #region Data Workspace
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed class DataWorkspace : global::Microsoft.LightSwitch.Framework.Base.DataWorkspace<global::LightSwitchApplication.DataWorkspace, global::LightSwitchApplication.DataWorkspace.DetailsClass>
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new instance of a DataWorkspace.  Changes can be made to data sources in the new instance independent of changes made to data sources in the default DataWorkspace.
        /// </summary>
        public DataWorkspace() : base()
        {
        }
    
        #endregion
    
        #region Public Properties
    
        /// <summary>
        /// Gets the ApplicationData datasource.  This provides members to query and update data in the data source.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::LightSwitchApplication.ApplicationDataService ApplicationData
        {
            get
            {
                return global::LightSwitchApplication.DataWorkspace.DetailsClass.GetValue(this, global::LightSwitchApplication.DataWorkspace.DetailsClass.PropertySetProperties.ApplicationData);
            }
        }
        
        #endregion
    
        #region Details Class
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public sealed class DetailsClass : global::Microsoft.LightSwitch.Details.Framework.Base.DataWorkspaceDetails<global::LightSwitchApplication.DataWorkspace, global::LightSwitchApplication.DataWorkspace.DetailsClass, global::LightSwitchApplication.DataWorkspace.DetailsClass.PropertySet>
        {
    
            static DetailsClass()
            {
                var initializeEntry = global::LightSwitchApplication.DataWorkspace.DetailsClass.PropertySetProperties.ApplicationData;
            }
    
            public DetailsClass() : base()
            {
            }
    
            public new global::LightSwitchApplication.DataWorkspace.DetailsClass.PropertySet Properties
            {
                get
                {
                    return base.Properties;
                }
            }
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class PropertySet : global::Microsoft.LightSwitch.Details.Framework.Base.DataWorkspacePropertySet<global::LightSwitchApplication.DataWorkspace, global::LightSwitchApplication.DataWorkspace.DetailsClass>
            {
    
                public PropertySet() : base()
                {
                }
    
                public global::Microsoft.LightSwitch.Details.Framework.DataWorkspaceDataServiceProperty<global::LightSwitchApplication.DataWorkspace, global::LightSwitchApplication.DataWorkspace.DetailsClass, global::LightSwitchApplication.ApplicationDataService> ApplicationData
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.DataWorkspace.DetailsClass.PropertySetProperties.ApplicationData) as global::Microsoft.LightSwitch.Details.Framework.DataWorkspaceDataServiceProperty<global::LightSwitchApplication.DataWorkspace, global::LightSwitchApplication.DataWorkspace.DetailsClass, global::LightSwitchApplication.ApplicationDataService>;
                    }
                }
                
            }
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal class PropertySetProperties
            {
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.DataWorkspaceDataServiceProperty<global::LightSwitchApplication.DataWorkspace, global::LightSwitchApplication.DataWorkspace.DetailsClass, global::LightSwitchApplication.ApplicationDataService>.Entry
                    ApplicationData = new global::Microsoft.LightSwitch.Details.Framework.DataWorkspaceDataServiceProperty<global::LightSwitchApplication.DataWorkspace, global::LightSwitchApplication.DataWorkspace.DetailsClass, global::LightSwitchApplication.ApplicationDataService>.Entry(
                        "ApplicationData",
                        global::LightSwitchApplication.DataWorkspace.DetailsClass.PropertySetProperties._ApplicationData_Stub);
                private static void _ApplicationData_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.DataWorkspace.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.DataWorkspaceDataServiceProperty<global::LightSwitchApplication.DataWorkspace, global::LightSwitchApplication.DataWorkspace.DetailsClass, global::LightSwitchApplication.ApplicationDataService>.Data> c, global::LightSwitchApplication.DataWorkspace.DetailsClass d, object sf)
                {
                    c(d, ref d._ApplicationData, sf);
                }
                 
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.DataWorkspaceDataServiceProperty<global::LightSwitchApplication.DataWorkspace, global::LightSwitchApplication.DataWorkspace.DetailsClass, global::LightSwitchApplication.ApplicationDataService>.Data _ApplicationData;
            
        }
    
        #endregion
    }
    
    #endregion
    
    #region Data Services
    
    /// <summary>
    /// Provides members to query and update data in the ApplicationData datasource.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class ApplicationData : global::Microsoft.LightSwitch.Framework.Base.DataService<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass>
    {
        #region Constructors
    
        /// <summary>
        /// This constructor is used for the internal LightSwitch framework. Use DataWorkspace instead.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public ApplicationData() : base()
        {
        }
    
        #endregion
    
        #region Public Properties
    
        /// <summary>
        /// Gets the Customers entity set.  The entity set provides members to access entities of a specific type.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.Customer> Customers
        {
            get
            {
                return global::LightSwitchApplication.ApplicationData.DetailsClass.GetValue(this, global::LightSwitchApplication.ApplicationData.DetailsClass.PropertySetProperties.Customers);
            }
        }
        
        /// <summary>
        /// Gets the Orders entity set.  The entity set provides members to access entities of a specific type.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.Order> Orders
        {
            get
            {
                return global::LightSwitchApplication.ApplicationData.DetailsClass.GetValue(this, global::LightSwitchApplication.ApplicationData.DetailsClass.PropertySetProperties.Orders);
            }
        }
        
        #endregion
    
        #region Queries
    
        /// <summary>
        /// Returns the entity whose identity is specified by the parameter(s).
        /// </summary>
        /// <param name="Id">
        /// The value of the 'Id' key property of the entity to retrieve.
        /// </param>
        public global::LightSwitchApplication.Customer Customers_Single(global::System.Nullable<int> Id)
        {
            return this.Details.Methods.Customers_Single.CreateInvocation(Id).Execute();
        }
        
        /// <summary>
        /// Returns the entity whose identity is specified by the parameter(s) or null if no such entity exists.
        /// </summary>
        /// <param name="Id">
        /// The value of the 'Id' key property of the entity to retrieve.
        /// </param>
        public global::LightSwitchApplication.Customer Customers_SingleOrDefault(global::System.Nullable<int> Id)
        {
            return this.Details.Methods.Customers_SingleOrDefault.CreateInvocation(Id).Execute();
        }
        
        /// <summary>
        /// Returns the entity whose identity is specified by the parameter(s).
        /// </summary>
        /// <param name="Id">
        /// The value of the 'Id' key property of the entity to retrieve.
        /// </param>
        public global::LightSwitchApplication.Order Orders_Single(global::System.Nullable<int> Id)
        {
            return this.Details.Methods.Orders_Single.CreateInvocation(Id).Execute();
        }
        
        /// <summary>
        /// Returns the entity whose identity is specified by the parameter(s) or null if no such entity exists.
        /// </summary>
        /// <param name="Id">
        /// The value of the 'Id' key property of the entity to retrieve.
        /// </param>
        public global::LightSwitchApplication.Order Orders_SingleOrDefault(global::System.Nullable<int> Id)
        {
            return this.Details.Methods.Orders_SingleOrDefault.CreateInvocation(Id).Execute();
        }
        
        #endregion
    
        #region Details Class
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public sealed class DetailsClass : global::Microsoft.LightSwitch.Details.Framework.Base.DataServiceDetails<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass, global::LightSwitchApplication.ApplicationData.DetailsClass.PropertySet, global::LightSwitchApplication.ApplicationData.DetailsClass.MethodSet>
        {
    
            static DetailsClass()
            {
                var initializeMethodEntry = global::LightSwitchApplication.ApplicationData.DetailsClass.MethodSetProperties.Customers_Single;
                var initializePropertyEntry = global::LightSwitchApplication.ApplicationData.DetailsClass.PropertySetProperties.Customers;
            }
    
            public DetailsClass() : base()
            {
            }
    
            public new global::LightSwitchApplication.ApplicationData.DetailsClass.MethodSet Methods
            {
                get
                {
                    return base.Methods;
                }
            }
    
            public new global::LightSwitchApplication.ApplicationData.DetailsClass.PropertySet Properties
            {
                get
                {
                    return base.Properties;
                }
            }
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class MethodSet : global::Microsoft.LightSwitch.Details.Framework.Base.DataServiceMethodSet<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass>
            {
    
                public MethodSet() : base()
                {
                }
    
                public global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass, global::LightSwitchApplication.Customer> Customers_Single
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.ApplicationData.DetailsClass.MethodSetProperties.Customers_Single) as global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass, global::LightSwitchApplication.Customer>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass, global::LightSwitchApplication.Customer> Customers_SingleOrDefault
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.ApplicationData.DetailsClass.MethodSetProperties.Customers_SingleOrDefault) as global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass, global::LightSwitchApplication.Customer>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass, global::LightSwitchApplication.Order> Orders_Single
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.ApplicationData.DetailsClass.MethodSetProperties.Orders_Single) as global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass, global::LightSwitchApplication.Order>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass, global::LightSwitchApplication.Order> Orders_SingleOrDefault
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.ApplicationData.DetailsClass.MethodSetProperties.Orders_SingleOrDefault) as global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass, global::LightSwitchApplication.Order>;
                    }
                }
                
            }
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class PropertySet : global::Microsoft.LightSwitch.Details.Framework.Base.DataServicePropertySet<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass>
            {
    
                public PropertySet() : base()
                {
                }
    
                public global::Microsoft.LightSwitch.Details.Framework.DataServiceEntitySetProperty<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass, global::LightSwitchApplication.Customer> Customers
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.ApplicationData.DetailsClass.PropertySetProperties.Customers) as global::Microsoft.LightSwitch.Details.Framework.DataServiceEntitySetProperty<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass, global::LightSwitchApplication.Customer>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.DataServiceEntitySetProperty<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass, global::LightSwitchApplication.Order> Orders
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.ApplicationData.DetailsClass.PropertySetProperties.Orders) as global::Microsoft.LightSwitch.Details.Framework.DataServiceEntitySetProperty<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass, global::LightSwitchApplication.Order>;
                    }
                }
                
            }
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal class MethodSetProperties
            {
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass, global::LightSwitchApplication.Customer>.Entry
                    Customers_Single = new global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass, global::LightSwitchApplication.Customer>.Entry(
                        "Customers_Single",
                        global::LightSwitchApplication.ApplicationData.DetailsClass.MethodSetProperties._Customers_Single_Stub);
                private static void _Customers_Single_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.ApplicationData.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass, global::LightSwitchApplication.Customer>.Data> c, global::LightSwitchApplication.ApplicationData.DetailsClass d, object sf)
                {
                    c(d, ref d._Customers_Single, sf);
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass, global::LightSwitchApplication.Customer>.Entry
                    Customers_SingleOrDefault = new global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass, global::LightSwitchApplication.Customer>.Entry(
                        "Customers_SingleOrDefault",
                        global::LightSwitchApplication.ApplicationData.DetailsClass.MethodSetProperties._Customers_SingleOrDefault_Stub);
                private static void _Customers_SingleOrDefault_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.ApplicationData.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass, global::LightSwitchApplication.Customer>.Data> c, global::LightSwitchApplication.ApplicationData.DetailsClass d, object sf)
                {
                    c(d, ref d._Customers_SingleOrDefault, sf);
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass, global::LightSwitchApplication.Order>.Entry
                    Orders_Single = new global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass, global::LightSwitchApplication.Order>.Entry(
                        "Orders_Single",
                        global::LightSwitchApplication.ApplicationData.DetailsClass.MethodSetProperties._Orders_Single_Stub);
                private static void _Orders_Single_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.ApplicationData.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass, global::LightSwitchApplication.Order>.Data> c, global::LightSwitchApplication.ApplicationData.DetailsClass d, object sf)
                {
                    c(d, ref d._Orders_Single, sf);
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass, global::LightSwitchApplication.Order>.Entry
                    Orders_SingleOrDefault = new global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass, global::LightSwitchApplication.Order>.Entry(
                        "Orders_SingleOrDefault",
                        global::LightSwitchApplication.ApplicationData.DetailsClass.MethodSetProperties._Orders_SingleOrDefault_Stub);
                private static void _Orders_SingleOrDefault_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.ApplicationData.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass, global::LightSwitchApplication.Order>.Data> c, global::LightSwitchApplication.ApplicationData.DetailsClass d, object sf)
                {
                    c(d, ref d._Orders_SingleOrDefault, sf);
                }
    
            }
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal class PropertySetProperties
            {
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.DataServiceEntitySetProperty<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass, global::LightSwitchApplication.Customer>.Entry
                    Customers = new global::Microsoft.LightSwitch.Details.Framework.DataServiceEntitySetProperty<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass, global::LightSwitchApplication.Customer>.Entry(
                        "Customers",
                        global::LightSwitchApplication.ApplicationData.DetailsClass.PropertySetProperties._Customers_Stub);
                private static void _Customers_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.ApplicationData.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.DataServiceEntitySetProperty<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass, global::LightSwitchApplication.Customer>.Data> c, global::LightSwitchApplication.ApplicationData.DetailsClass d, object sf)
                {
                    c(d, ref d._Customers, sf);
                }
     
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.DataServiceEntitySetProperty<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass, global::LightSwitchApplication.Order>.Entry
                    Orders = new global::Microsoft.LightSwitch.Details.Framework.DataServiceEntitySetProperty<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass, global::LightSwitchApplication.Order>.Entry(
                        "Orders",
                        global::LightSwitchApplication.ApplicationData.DetailsClass.PropertySetProperties._Orders_Stub);
                private static void _Orders_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.ApplicationData.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.DataServiceEntitySetProperty<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass, global::LightSwitchApplication.Order>.Data> c, global::LightSwitchApplication.ApplicationData.DetailsClass d, object sf)
                {
                    c(d, ref d._Orders, sf);
                }
     
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.DataServiceEntitySetProperty<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass, global::LightSwitchApplication.Customer>.Data _Customers;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.DataServiceEntitySetProperty<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass, global::LightSwitchApplication.Order>.Data _Orders;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass, global::LightSwitchApplication.Customer>.Data _Customers_Single;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass, global::LightSwitchApplication.Customer>.Data _Customers_SingleOrDefault;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass, global::LightSwitchApplication.Order>.Data _Orders_Single;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.CreateScalarQueryMethod<global::LightSwitchApplication.ApplicationData, global::LightSwitchApplication.ApplicationData.DetailsClass, global::LightSwitchApplication.Order>.Data _Orders_SingleOrDefault;
            
        }
    
        #endregion
    }
    
    #endregion
    
}
