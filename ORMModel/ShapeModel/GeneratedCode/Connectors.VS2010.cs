﻿#region Common Public License Copyright Notice
/**************************************************************************\
* Natural Object-Role Modeling Architect for Visual Studio                 *
*                                                                          *
* Copyright © Neumont University and The ORM Foundation. All rights reserved.                     *
*                                                                          *
* The use and distribution terms for this software are covered by the      *
* Common Public License 1.0 (http://opensource.org/licenses/cpl) which     *
* can be found in the file CPL.txt at the root of this distribution.       *
* By using this software in any fashion, you are agreeing to be bound by   *
* the terms of this license.                                               *
*                                                                          *
* You must not remove this notice, or any other, from this software.       *
\**************************************************************************/
#endregion
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DslModeling = global::Microsoft.VisualStudio.Modeling;
using DslDesign = global::Microsoft.VisualStudio.Modeling.Design;
using DslDiagrams = global::Microsoft.VisualStudio.Modeling.Diagrams;

namespace ORMSolutions.ORMArchitect.Core.ShapeModel
{
	/// <summary>
	/// DomainClass ORMBaseBinaryLinkShape
	/// Description for ORMSolutions.ORMArchitect.Core.ShapeModel.ORMBaseBinaryLinkShape
	/// </summary>
	[global::System.ComponentModel.TypeDescriptionProvider(typeof(global::ORMSolutions.ORMArchitect.Framework.Diagrams.Design.PresentationElementTypeDescriptionProvider<ORMBaseBinaryLinkShape, DslModeling::ModelElement, Design.ORMBaseBinaryLinkShapeTypeDescriptor<ORMBaseBinaryLinkShape, DslModeling::ModelElement>>))]
	[DslDesign::DisplayNameResource("ORMSolutions.ORMArchitect.Core.ShapeModel.ORMBaseBinaryLinkShape.DisplayName", typeof(global::ORMSolutions.ORMArchitect.Core.ShapeModel.ORMShapeDomainModel), "ORMSolutions.ORMArchitect.Core.GeneratedCode.ShapeDomainModelResx")]
	[DslDesign::DescriptionResource("ORMSolutions.ORMArchitect.Core.ShapeModel.ORMBaseBinaryLinkShape.Description", typeof(global::ORMSolutions.ORMArchitect.Core.ShapeModel.ORMShapeDomainModel), "ORMSolutions.ORMArchitect.Core.GeneratedCode.ShapeDomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::ORMSolutions.ORMArchitect.Core.ShapeModel.ORMShapeDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainObjectId("ceff4339-48d0-4ffe-b052-2f9da167b1db")]
	public abstract partial class ORMBaseBinaryLinkShape : DslDiagrams::BinaryLinkShape
	{
		
		#region Connector styles
		#endregion
		
		#region Constructors, domain class Id
	
		/// <summary>
		/// ORMBaseBinaryLinkShape domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0xceff4339, 0x48d0, 0x4ffe, 0xb0, 0x52, 0x2f, 0x9d, 0xa1, 0x67, 0xb1, 0xdb);
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		protected ORMBaseBinaryLinkShape(DslModeling::Partition partition, DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
		#region UpdateCounter domain property code
		
		/// <summary>
		/// UpdateCounter domain property Id.
		/// </summary>
		public static readonly global::System.Guid UpdateCounterDomainPropertyId = new global::System.Guid(0xbfd06581, 0x3606, 0x4a9f, 0x9d, 0xd1, 0x8b, 0xa3, 0x01, 0x4b, 0xd5, 0xbc);
		
		/// <summary>
		/// Gets or sets the value of UpdateCounter domain property.
		/// Description for
		/// ORMSolutions.ORMArchitect.Core.ShapeModel.ORMBaseBinaryLinkShape.Update Counter
		/// </summary>
		[DslDesign::DisplayNameResource("ORMSolutions.ORMArchitect.Core.ShapeModel.ORMBaseBinaryLinkShape/UpdateCounter.DisplayName", typeof(global::ORMSolutions.ORMArchitect.Core.ShapeModel.ORMShapeDomainModel), "ORMSolutions.ORMArchitect.Core.GeneratedCode.ShapeDomainModelResx")]
		[DslDesign::DescriptionResource("ORMSolutions.ORMArchitect.Core.ShapeModel.ORMBaseBinaryLinkShape/UpdateCounter.Description", typeof(global::ORMSolutions.ORMArchitect.Core.ShapeModel.ORMShapeDomainModel), "ORMSolutions.ORMArchitect.Core.GeneratedCode.ShapeDomainModelResx")]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[DslModeling::DomainProperty(Kind = DslModeling::DomainPropertyKind.CustomStorage)]
		[DslModeling::DomainObjectId("bfd06581-3606-4a9f-9dd1-8ba3014bd5bc")]
		private global::System.Int64 UpdateCounter
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return UpdateCounterPropertyHandler.Instance.GetValue(this);
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				UpdateCounterPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ORMBaseBinaryLinkShape.UpdateCounter domain property.
		/// </summary>
		internal sealed partial class UpdateCounterPropertyHandler : DslModeling::DomainPropertyValueHandler<ORMBaseBinaryLinkShape, global::System.Int64>
		{
			private UpdateCounterPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ORMBaseBinaryLinkShape.UpdateCounter domain property value handler.
			/// </summary>
			public static readonly UpdateCounterPropertyHandler Instance = new UpdateCounterPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ORMBaseBinaryLinkShape.UpdateCounter domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return UpdateCounterDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.Int64 GetValue(ORMBaseBinaryLinkShape element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				// There is no storage for UpdateCounter because its Kind is
				// set to CustomStorage. Please provide the GetUpdateCounterValue()
				// method on the domain class.
				return element.GetUpdateCounterValue();
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ORMBaseBinaryLinkShape element, global::System.Int64 newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.Int64 oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					// There is no storage for UpdateCounter because its Kind is
					// set to CustomStorage. Please provide the SetUpdateCounterValue()
					// method on the domain class.
					element.SetUpdateCounterValue(newValue);
					//ValueChanged(element, oldValue, GetValue(element));
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
	}
}
namespace ORMSolutions.ORMArchitect.Core.ShapeModel
{
	/// <summary>
	/// DomainClass ORMDirectBinaryLinkShape
	/// Description for
	/// ORMSolutions.ORMArchitect.Core.ShapeModel.ORMDirectBinaryLinkShape
	/// </summary>
	[DslDesign::DisplayNameResource("ORMSolutions.ORMArchitect.Core.ShapeModel.ORMDirectBinaryLinkShape.DisplayName", typeof(global::ORMSolutions.ORMArchitect.Core.ShapeModel.ORMShapeDomainModel), "ORMSolutions.ORMArchitect.Core.GeneratedCode.ShapeDomainModelResx")]
	[DslDesign::DescriptionResource("ORMSolutions.ORMArchitect.Core.ShapeModel.ORMDirectBinaryLinkShape.Description", typeof(global::ORMSolutions.ORMArchitect.Core.ShapeModel.ORMShapeDomainModel), "ORMSolutions.ORMArchitect.Core.GeneratedCode.ShapeDomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::ORMSolutions.ORMArchitect.Core.ShapeModel.ORMShapeDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainObjectId("c9d051cc-a90b-468f-891d-62bde679922f")]
	public abstract partial class ORMDirectBinaryLinkShape : ORMBaseBinaryLinkShape
	{
		
		#region Connector styles
		#endregion
		
		#region Constructors, domain class Id
	
		/// <summary>
		/// ORMDirectBinaryLinkShape domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0xc9d051cc, 0xa90b, 0x468f, 0x89, 0x1d, 0x62, 0xbd, 0xe6, 0x79, 0x92, 0x2f);
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		protected ORMDirectBinaryLinkShape(DslModeling::Partition partition, DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
	}
}
namespace ORMSolutions.ORMArchitect.Core.ShapeModel
{
	/// <summary>
	/// DomainClass RolePlayerLink
	/// Description for ORMSolutions.ORMArchitect.Core.ShapeModel.RolePlayerLink
	/// </summary>
	[DslDesign::DisplayNameResource("ORMSolutions.ORMArchitect.Core.ShapeModel.RolePlayerLink.DisplayName", typeof(global::ORMSolutions.ORMArchitect.Core.ShapeModel.ORMShapeDomainModel), "ORMSolutions.ORMArchitect.Core.GeneratedCode.ShapeDomainModelResx")]
	[DslDesign::DescriptionResource("ORMSolutions.ORMArchitect.Core.ShapeModel.RolePlayerLink.Description", typeof(global::ORMSolutions.ORMArchitect.Core.ShapeModel.ORMShapeDomainModel), "ORMSolutions.ORMArchitect.Core.GeneratedCode.ShapeDomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::ORMSolutions.ORMArchitect.Core.ShapeModel.ORMShapeDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainObjectId("2b3f0aae-b1b1-4727-8862-5c34b494b499")]
	public partial class RolePlayerLink : ORMDirectBinaryLinkShape
	{
		#region DiagramElement boilerplate
		private static DslDiagrams::StyleSet classStyleSet;
		private static global::System.Collections.Generic.IList<DslDiagrams::ShapeField> shapeFields;
		private static global::System.Collections.Generic.IList<DslDiagrams::Decorator> decorators;
		
		/// <summary>
		/// Per-class style set for this shape.
		/// </summary>
		protected override DslDiagrams::StyleSet ClassStyleSet
		{
			get
			{
				if (classStyleSet == null)
				{
					classStyleSet = CreateClassStyleSet();
				}
				return classStyleSet;
			}
		}
		
		/// <summary>
		/// Per-class ShapeFields for this shape.
		/// </summary>
		public override global::System.Collections.Generic.IList<DslDiagrams::ShapeField> ShapeFields
		{
			get
			{
				if (shapeFields == null)
				{
					shapeFields = CreateShapeFields();
				}
				return shapeFields;
			}
		}
		
		/// <summary>
		/// Event fired when decorator initialization is complete for this shape type.
		/// </summary>
		public static event global::System.EventHandler DecoratorsInitialized;
		
		/// <summary>
		/// List containing decorators used by this type.
		/// </summary>
		public override global::System.Collections.Generic.IList<DslDiagrams::Decorator> Decorators
		{
			get 
			{
				if(decorators == null)
				{
					decorators = CreateDecorators();
					
					// fire this event to allow the diagram to initialize decorator mappings for this shape type.
					if(DecoratorsInitialized != null)
					{
						DecoratorsInitialized(this, global::System.EventArgs.Empty);
					}
				}
				
				return decorators; 
			}
		}
		
		/// <summary>
		/// Finds a decorator associated with RolePlayerLink.
		/// </summary>
		public static DslDiagrams::Decorator FindRolePlayerLinkDecorator(string decoratorName)
		{	
			if(decorators == null) return null;
			return DslDiagrams::ShapeElement.FindDecorator(decorators, decoratorName);
		}
		
		#endregion
		
		#region Connector styles
		#endregion
		
		#region Constructors, domain class Id
	
		/// <summary>
		/// RolePlayerLink domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0x2b3f0aae, 0xb1b1, 0x4727, 0x88, 0x62, 0x5c, 0x34, 0xb4, 0x94, 0xb4, 0x99);
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public RolePlayerLink(DslModeling::Store store, params DslModeling::PropertyAssignment[] propertyAssignments)
			: this(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public RolePlayerLink(DslModeling::Partition partition, params DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
	}
}
namespace ORMSolutions.ORMArchitect.Core.ShapeModel
{
	/// <summary>
	/// DomainClass RolePlayerProxyLink
	/// Description for ORMSolutions.ORMArchitect.Core.ShapeModel.RolePlayerProxyLink
	/// </summary>
	[DslDesign::DisplayNameResource("ORMSolutions.ORMArchitect.Core.ShapeModel.RolePlayerProxyLink.DisplayName", typeof(global::ORMSolutions.ORMArchitect.Core.ShapeModel.ORMShapeDomainModel), "ORMSolutions.ORMArchitect.Core.GeneratedCode.ShapeDomainModelResx")]
	[DslDesign::DescriptionResource("ORMSolutions.ORMArchitect.Core.ShapeModel.RolePlayerProxyLink.Description", typeof(global::ORMSolutions.ORMArchitect.Core.ShapeModel.ORMShapeDomainModel), "ORMSolutions.ORMArchitect.Core.GeneratedCode.ShapeDomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::ORMSolutions.ORMArchitect.Core.ShapeModel.ORMShapeDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainObjectId("27d3440f-6ca0-4135-9a1c-2d3259e4a7ff")]
	public partial class RolePlayerProxyLink : RolePlayerLink
	{
		#region DiagramElement boilerplate
		private static DslDiagrams::StyleSet classStyleSet;
		private static global::System.Collections.Generic.IList<DslDiagrams::ShapeField> shapeFields;
		private static global::System.Collections.Generic.IList<DslDiagrams::Decorator> decorators;
		
		/// <summary>
		/// Per-class style set for this shape.
		/// </summary>
		protected override DslDiagrams::StyleSet ClassStyleSet
		{
			get
			{
				if (classStyleSet == null)
				{
					classStyleSet = CreateClassStyleSet();
				}
				return classStyleSet;
			}
		}
		
		/// <summary>
		/// Per-class ShapeFields for this shape.
		/// </summary>
		public override global::System.Collections.Generic.IList<DslDiagrams::ShapeField> ShapeFields
		{
			get
			{
				if (shapeFields == null)
				{
					shapeFields = CreateShapeFields();
				}
				return shapeFields;
			}
		}
		
		/// <summary>
		/// Event fired when decorator initialization is complete for this shape type.
		/// </summary>
		public static new event global::System.EventHandler DecoratorsInitialized;
		
		/// <summary>
		/// List containing decorators used by this type.
		/// </summary>
		public override global::System.Collections.Generic.IList<DslDiagrams::Decorator> Decorators
		{
			get 
			{
				if(decorators == null)
				{
					decorators = CreateDecorators();
					
					// fire this event to allow the diagram to initialize decorator mappings for this shape type.
					if(DecoratorsInitialized != null)
					{
						DecoratorsInitialized(this, global::System.EventArgs.Empty);
					}
				}
				
				return decorators; 
			}
		}
		
		/// <summary>
		/// Finds a decorator associated with RolePlayerProxyLink.
		/// </summary>
		public static DslDiagrams::Decorator FindRolePlayerProxyLinkDecorator(string decoratorName)
		{	
			if(decorators == null) return null;
			return DslDiagrams::ShapeElement.FindDecorator(decorators, decoratorName);
		}
		
		#endregion
		
		#region Connector styles
		#endregion
		
		#region Constructors, domain class Id
	
		/// <summary>
		/// RolePlayerProxyLink domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0x27d3440f, 0x6ca0, 0x4135, 0x9a, 0x1c, 0x2d, 0x32, 0x59, 0xe4, 0xa7, 0xff);
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public RolePlayerProxyLink(DslModeling::Store store, params DslModeling::PropertyAssignment[] propertyAssignments)
			: this(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public RolePlayerProxyLink(DslModeling::Partition partition, params DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
	}
}
namespace ORMSolutions.ORMArchitect.Core.ShapeModel
{
	/// <summary>
	/// DomainClass ExternalConstraintLink
	/// Description for ORMSolutions.ORMArchitect.Core.ShapeModel.ExternalConstraintLink
	/// </summary>
	[DslDesign::DisplayNameResource("ORMSolutions.ORMArchitect.Core.ShapeModel.ExternalConstraintLink.DisplayName", typeof(global::ORMSolutions.ORMArchitect.Core.ShapeModel.ORMShapeDomainModel), "ORMSolutions.ORMArchitect.Core.GeneratedCode.ShapeDomainModelResx")]
	[DslDesign::DescriptionResource("ORMSolutions.ORMArchitect.Core.ShapeModel.ExternalConstraintLink.Description", typeof(global::ORMSolutions.ORMArchitect.Core.ShapeModel.ORMShapeDomainModel), "ORMSolutions.ORMArchitect.Core.GeneratedCode.ShapeDomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::ORMSolutions.ORMArchitect.Core.ShapeModel.ORMShapeDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainObjectId("8815e6d8-238b-422c-a4b3-29fdc8de9ea5")]
	public partial class ExternalConstraintLink : ORMDirectBinaryLinkShape
	{
		#region DiagramElement boilerplate
		private static DslDiagrams::StyleSet classStyleSet;
		private static global::System.Collections.Generic.IList<DslDiagrams::ShapeField> shapeFields;
		private static global::System.Collections.Generic.IList<DslDiagrams::Decorator> decorators;
		
		/// <summary>
		/// Per-class style set for this shape.
		/// </summary>
		protected override DslDiagrams::StyleSet ClassStyleSet
		{
			get
			{
				if (classStyleSet == null)
				{
					classStyleSet = CreateClassStyleSet();
				}
				return classStyleSet;
			}
		}
		
		/// <summary>
		/// Per-class ShapeFields for this shape.
		/// </summary>
		public override global::System.Collections.Generic.IList<DslDiagrams::ShapeField> ShapeFields
		{
			get
			{
				if (shapeFields == null)
				{
					shapeFields = CreateShapeFields();
				}
				return shapeFields;
			}
		}
		
		/// <summary>
		/// Event fired when decorator initialization is complete for this shape type.
		/// </summary>
		public static event global::System.EventHandler DecoratorsInitialized;
		
		/// <summary>
		/// List containing decorators used by this type.
		/// </summary>
		public override global::System.Collections.Generic.IList<DslDiagrams::Decorator> Decorators
		{
			get 
			{
				if(decorators == null)
				{
					decorators = CreateDecorators();
					
					// fire this event to allow the diagram to initialize decorator mappings for this shape type.
					if(DecoratorsInitialized != null)
					{
						DecoratorsInitialized(this, global::System.EventArgs.Empty);
					}
				}
				
				return decorators; 
			}
		}
		
		/// <summary>
		/// Finds a decorator associated with ExternalConstraintLink.
		/// </summary>
		public static DslDiagrams::Decorator FindExternalConstraintLinkDecorator(string decoratorName)
		{	
			if(decorators == null) return null;
			return DslDiagrams::ShapeElement.FindDecorator(decorators, decoratorName);
		}
		
		#endregion
		
		#region Connector styles
		#endregion
		
		#region Constructors, domain class Id
	
		/// <summary>
		/// ExternalConstraintLink domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0x8815e6d8, 0x238b, 0x422c, 0xa4, 0xb3, 0x29, 0xfd, 0xc8, 0xde, 0x9e, 0xa5);
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public ExternalConstraintLink(DslModeling::Store store, params DslModeling::PropertyAssignment[] propertyAssignments)
			: this(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public ExternalConstraintLink(DslModeling::Partition partition, params DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
	}
}
namespace ORMSolutions.ORMArchitect.Core.ShapeModel
{
	/// <summary>
	/// DomainClass ValueRangeLink
	/// Description for ORMSolutions.ORMArchitect.Core.ShapeModel.ValueRangeLink
	/// </summary>
	[DslDesign::DisplayNameResource("ORMSolutions.ORMArchitect.Core.ShapeModel.ValueRangeLink.DisplayName", typeof(global::ORMSolutions.ORMArchitect.Core.ShapeModel.ORMShapeDomainModel), "ORMSolutions.ORMArchitect.Core.GeneratedCode.ShapeDomainModelResx")]
	[DslDesign::DescriptionResource("ORMSolutions.ORMArchitect.Core.ShapeModel.ValueRangeLink.Description", typeof(global::ORMSolutions.ORMArchitect.Core.ShapeModel.ORMShapeDomainModel), "ORMSolutions.ORMArchitect.Core.GeneratedCode.ShapeDomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::ORMSolutions.ORMArchitect.Core.ShapeModel.ORMShapeDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainObjectId("374e43c3-c294-49c4-8a61-3c3ca5fc86e8")]
	public partial class ValueRangeLink : ORMDirectBinaryLinkShape
	{
		#region DiagramElement boilerplate
		private static DslDiagrams::StyleSet classStyleSet;
		private static global::System.Collections.Generic.IList<DslDiagrams::ShapeField> shapeFields;
		private static global::System.Collections.Generic.IList<DslDiagrams::Decorator> decorators;
		
		/// <summary>
		/// Per-class style set for this shape.
		/// </summary>
		protected override DslDiagrams::StyleSet ClassStyleSet
		{
			get
			{
				if (classStyleSet == null)
				{
					classStyleSet = CreateClassStyleSet();
				}
				return classStyleSet;
			}
		}
		
		/// <summary>
		/// Per-class ShapeFields for this shape.
		/// </summary>
		public override global::System.Collections.Generic.IList<DslDiagrams::ShapeField> ShapeFields
		{
			get
			{
				if (shapeFields == null)
				{
					shapeFields = CreateShapeFields();
				}
				return shapeFields;
			}
		}
		
		/// <summary>
		/// Event fired when decorator initialization is complete for this shape type.
		/// </summary>
		public static event global::System.EventHandler DecoratorsInitialized;
		
		/// <summary>
		/// List containing decorators used by this type.
		/// </summary>
		public override global::System.Collections.Generic.IList<DslDiagrams::Decorator> Decorators
		{
			get 
			{
				if(decorators == null)
				{
					decorators = CreateDecorators();
					
					// fire this event to allow the diagram to initialize decorator mappings for this shape type.
					if(DecoratorsInitialized != null)
					{
						DecoratorsInitialized(this, global::System.EventArgs.Empty);
					}
				}
				
				return decorators; 
			}
		}
		
		/// <summary>
		/// Finds a decorator associated with ValueRangeLink.
		/// </summary>
		public static DslDiagrams::Decorator FindValueRangeLinkDecorator(string decoratorName)
		{	
			if(decorators == null) return null;
			return DslDiagrams::ShapeElement.FindDecorator(decorators, decoratorName);
		}
		
		#endregion
		
		#region Connector styles
		#endregion
		
		#region Constructors, domain class Id
	
		/// <summary>
		/// ValueRangeLink domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0x374e43c3, 0xc294, 0x49c4, 0x8a, 0x61, 0x3c, 0x3c, 0xa5, 0xfc, 0x86, 0xe8);
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public ValueRangeLink(DslModeling::Store store, params DslModeling::PropertyAssignment[] propertyAssignments)
			: this(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public ValueRangeLink(DslModeling::Partition partition, params DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
	}
}
namespace ORMSolutions.ORMArchitect.Core.ShapeModel
{
	/// <summary>
	/// DomainClass ModelNoteLink
	/// Description for ORMSolutions.ORMArchitect.Core.ShapeModel.ModelNoteLink
	/// </summary>
	[DslDesign::DisplayNameResource("ORMSolutions.ORMArchitect.Core.ShapeModel.ModelNoteLink.DisplayName", typeof(global::ORMSolutions.ORMArchitect.Core.ShapeModel.ORMShapeDomainModel), "ORMSolutions.ORMArchitect.Core.GeneratedCode.ShapeDomainModelResx")]
	[DslDesign::DescriptionResource("ORMSolutions.ORMArchitect.Core.ShapeModel.ModelNoteLink.Description", typeof(global::ORMSolutions.ORMArchitect.Core.ShapeModel.ORMShapeDomainModel), "ORMSolutions.ORMArchitect.Core.GeneratedCode.ShapeDomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::ORMSolutions.ORMArchitect.Core.ShapeModel.ORMShapeDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainObjectId("21e7c585-bc80-446f-8517-bc4fd465971f")]
	public partial class ModelNoteLink : ORMDirectBinaryLinkShape
	{
		#region DiagramElement boilerplate
		private static DslDiagrams::StyleSet classStyleSet;
		private static global::System.Collections.Generic.IList<DslDiagrams::ShapeField> shapeFields;
		private static global::System.Collections.Generic.IList<DslDiagrams::Decorator> decorators;
		
		/// <summary>
		/// Per-class style set for this shape.
		/// </summary>
		protected override DslDiagrams::StyleSet ClassStyleSet
		{
			get
			{
				if (classStyleSet == null)
				{
					classStyleSet = CreateClassStyleSet();
				}
				return classStyleSet;
			}
		}
		
		/// <summary>
		/// Per-class ShapeFields for this shape.
		/// </summary>
		public override global::System.Collections.Generic.IList<DslDiagrams::ShapeField> ShapeFields
		{
			get
			{
				if (shapeFields == null)
				{
					shapeFields = CreateShapeFields();
				}
				return shapeFields;
			}
		}
		
		/// <summary>
		/// Event fired when decorator initialization is complete for this shape type.
		/// </summary>
		public static event global::System.EventHandler DecoratorsInitialized;
		
		/// <summary>
		/// List containing decorators used by this type.
		/// </summary>
		public override global::System.Collections.Generic.IList<DslDiagrams::Decorator> Decorators
		{
			get 
			{
				if(decorators == null)
				{
					decorators = CreateDecorators();
					
					// fire this event to allow the diagram to initialize decorator mappings for this shape type.
					if(DecoratorsInitialized != null)
					{
						DecoratorsInitialized(this, global::System.EventArgs.Empty);
					}
				}
				
				return decorators; 
			}
		}
		
		/// <summary>
		/// Finds a decorator associated with ModelNoteLink.
		/// </summary>
		public static DslDiagrams::Decorator FindModelNoteLinkDecorator(string decoratorName)
		{	
			if(decorators == null) return null;
			return DslDiagrams::ShapeElement.FindDecorator(decorators, decoratorName);
		}
		
		#endregion
		
		#region Connector styles
		#endregion
		
		#region Constructors, domain class Id
	
		/// <summary>
		/// ModelNoteLink domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0x21e7c585, 0xbc80, 0x446f, 0x85, 0x17, 0xbc, 0x4f, 0xd4, 0x65, 0x97, 0x1f);
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public ModelNoteLink(DslModeling::Store store, params DslModeling::PropertyAssignment[] propertyAssignments)
			: this(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public ModelNoteLink(DslModeling::Partition partition, params DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
	}
}
