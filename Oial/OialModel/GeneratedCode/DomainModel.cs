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
namespace ORMSolutions.ORMArchitect.ORMAbstraction
{
	/// <summary>
	/// DomainModel AbstractionDomainModel
	/// Intermediate Attribute-centric View of ORM Model
	/// </summary>
	[DslModeling::ExtendsDomainModel("3EAE649F-E654-4D04-8289-C25D2C0322D8"/*ORMSolutions.ORMArchitect.Core.ObjectModel.ORMCoreDomainModel*/)]
	[ORMSolutions.ORMArchitect.Core.Load.NORMAExtensionLoadKey("BHrWfIvZuqiu8p3DyWS4SXbXII/btuG+AZKDfkrckD+6rUOs8IG28aZBGkIWynP3Vq2VBj6cf/Lf7rXzrgGctg==")]
	[DslDesign::DisplayNameResource("ORMSolutions.ORMArchitect.ORMAbstraction.AbstractionDomainModel.DisplayName", typeof(global::ORMSolutions.ORMArchitect.ORMAbstraction.AbstractionDomainModel), "ORMSolutions.ORMArchitect.ORMAbstraction.GeneratedCode.AbstractionDomainModelResx")]
	[DslDesign::DescriptionResource("ORMSolutions.ORMArchitect.ORMAbstraction.AbstractionDomainModel.Description", typeof(global::ORMSolutions.ORMArchitect.ORMAbstraction.AbstractionDomainModel), "ORMSolutions.ORMArchitect.ORMAbstraction.GeneratedCode.AbstractionDomainModelResx")]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainObjectId("f7bc82f4-83d1-408c-ba42-607e90b23bea")]
	public partial class AbstractionDomainModel : DslModeling::DomainModel
	{
		#region Constructor, domain model Id
	
		/// <summary>
		/// AbstractionDomainModel domain model Id.
		/// </summary>
		public static readonly global::System.Guid DomainModelId = new global::System.Guid(0xf7bc82f4, 0x83d1, 0x408c, 0xba, 0x42, 0x60, 0x7e, 0x90, 0xb2, 0x3b, 0xea);
	
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="store">Store containing the domain model.</param>
		public AbstractionDomainModel(DslModeling::Store store)
			: base(store, DomainModelId)
		{
		}
		
		#endregion
		#region Domain model reflection
			
		/// <summary>
		/// Gets the list of generated domain model types (classes, rules, relationships).
		/// </summary>
		/// <returns>List of types.</returns>
		protected sealed override global::System.Type[] GetGeneratedDomainModelTypes()
		{
			return new global::System.Type[]
			{
				typeof(AbstractionModel),
				typeof(ConceptType),
				typeof(InformationTypeFormat),
				typeof(Uniqueness),
				typeof(AbstractionModelHasConceptType),
				typeof(AbstractionModelHasInformationTypeFormat),
				typeof(ConceptTypeHasUniqueness),
				typeof(ConceptTypeChild),
				typeof(ConceptTypeHasChildAsPartOfAssociation),
				typeof(InformationType),
				typeof(ConceptTypeReferencesConceptType),
				typeof(ConceptTypeRelatesToConceptType),
				typeof(ConceptTypeAssimilatesConceptType),
				typeof(UniquenessIncludesConceptTypeChild),
			};
		}
		/// <summary>
		/// Gets the list of generated domain properties.
		/// </summary>
		/// <returns>List of property data.</returns>
		protected sealed override DomainMemberInfo[] GetGeneratedDomainProperties()
		{
			return new DomainMemberInfo[]
			{
				new DomainMemberInfo(typeof(AbstractionModel), "Name", AbstractionModel.NameDomainPropertyId, typeof(AbstractionModel.NamePropertyHandler)),
				new DomainMemberInfo(typeof(ConceptType), "Name", ConceptType.NameDomainPropertyId, typeof(ConceptType.NamePropertyHandler)),
				new DomainMemberInfo(typeof(InformationTypeFormat), "Name", InformationTypeFormat.NameDomainPropertyId, typeof(InformationTypeFormat.NamePropertyHandler)),
				new DomainMemberInfo(typeof(Uniqueness), "Name", Uniqueness.NameDomainPropertyId, typeof(Uniqueness.NamePropertyHandler)),
				new DomainMemberInfo(typeof(Uniqueness), "IsPreferred", Uniqueness.IsPreferredDomainPropertyId, typeof(Uniqueness.IsPreferredPropertyHandler)),
				new DomainMemberInfo(typeof(ConceptTypeChild), "IsMandatory", ConceptTypeChild.IsMandatoryDomainPropertyId, typeof(ConceptTypeChild.IsMandatoryPropertyHandler)),
				new DomainMemberInfo(typeof(ConceptTypeChild), "Name", ConceptTypeChild.NameDomainPropertyId, typeof(ConceptTypeChild.NamePropertyHandler)),
				new DomainMemberInfo(typeof(ConceptTypeReferencesConceptType), "OppositeName", ConceptTypeReferencesConceptType.OppositeNameDomainPropertyId, typeof(ConceptTypeReferencesConceptType.OppositeNamePropertyHandler)),
				new DomainMemberInfo(typeof(ConceptTypeAssimilatesConceptType), "RefersToSubtype", ConceptTypeAssimilatesConceptType.RefersToSubtypeDomainPropertyId, typeof(ConceptTypeAssimilatesConceptType.RefersToSubtypePropertyHandler)),
				new DomainMemberInfo(typeof(ConceptTypeAssimilatesConceptType), "IsPreferredForTarget", ConceptTypeAssimilatesConceptType.IsPreferredForTargetDomainPropertyId, typeof(ConceptTypeAssimilatesConceptType.IsPreferredForTargetPropertyHandler)),
				new DomainMemberInfo(typeof(ConceptTypeAssimilatesConceptType), "IsPreferredForParent", ConceptTypeAssimilatesConceptType.IsPreferredForParentDomainPropertyId, typeof(ConceptTypeAssimilatesConceptType.IsPreferredForParentPropertyHandler)),
			};
		}
		/// <summary>
		/// Gets the list of generated domain roles.
		/// </summary>
		/// <returns>List of role data.</returns>
		protected sealed override DomainRolePlayerInfo[] GetGeneratedDomainRoles()
		{
			return new DomainRolePlayerInfo[]
			{
				new DomainRolePlayerInfo(typeof(AbstractionModelHasConceptType), "Model", AbstractionModelHasConceptType.ModelDomainRoleId),
				new DomainRolePlayerInfo(typeof(AbstractionModelHasConceptType), "ConceptType", AbstractionModelHasConceptType.ConceptTypeDomainRoleId),
				new DomainRolePlayerInfo(typeof(AbstractionModelHasInformationTypeFormat), "Model", AbstractionModelHasInformationTypeFormat.ModelDomainRoleId),
				new DomainRolePlayerInfo(typeof(AbstractionModelHasInformationTypeFormat), "InformationTypeFormat", AbstractionModelHasInformationTypeFormat.InformationTypeFormatDomainRoleId),
				new DomainRolePlayerInfo(typeof(ConceptTypeHasUniqueness), "ConceptType", ConceptTypeHasUniqueness.ConceptTypeDomainRoleId),
				new DomainRolePlayerInfo(typeof(ConceptTypeHasUniqueness), "Uniqueness", ConceptTypeHasUniqueness.UniquenessDomainRoleId),
				new DomainRolePlayerInfo(typeof(ConceptTypeChild), "Parent", ConceptTypeChild.ParentDomainRoleId),
				new DomainRolePlayerInfo(typeof(ConceptTypeChild), "Target", ConceptTypeChild.TargetDomainRoleId),
				new DomainRolePlayerInfo(typeof(ConceptTypeHasChildAsPartOfAssociation), "Parent", ConceptTypeHasChildAsPartOfAssociation.ParentDomainRoleId),
				new DomainRolePlayerInfo(typeof(ConceptTypeHasChildAsPartOfAssociation), "Target", ConceptTypeHasChildAsPartOfAssociation.TargetDomainRoleId),
				new DomainRolePlayerInfo(typeof(InformationType), "ConceptType", InformationType.ConceptTypeDomainRoleId),
				new DomainRolePlayerInfo(typeof(InformationType), "InformationTypeFormat", InformationType.InformationTypeFormatDomainRoleId),
				new DomainRolePlayerInfo(typeof(ConceptTypeReferencesConceptType), "ReferencingConceptType", ConceptTypeReferencesConceptType.ReferencingConceptTypeDomainRoleId),
				new DomainRolePlayerInfo(typeof(ConceptTypeReferencesConceptType), "ReferencedConceptType", ConceptTypeReferencesConceptType.ReferencedConceptTypeDomainRoleId),
				new DomainRolePlayerInfo(typeof(ConceptTypeRelatesToConceptType), "RelatingConceptType", ConceptTypeRelatesToConceptType.RelatingConceptTypeDomainRoleId),
				new DomainRolePlayerInfo(typeof(ConceptTypeRelatesToConceptType), "RelatedConceptType", ConceptTypeRelatesToConceptType.RelatedConceptTypeDomainRoleId),
				new DomainRolePlayerInfo(typeof(ConceptTypeAssimilatesConceptType), "AssimilatorConceptType", ConceptTypeAssimilatesConceptType.AssimilatorConceptTypeDomainRoleId),
				new DomainRolePlayerInfo(typeof(ConceptTypeAssimilatesConceptType), "AssimilatedConceptType", ConceptTypeAssimilatesConceptType.AssimilatedConceptTypeDomainRoleId),
				new DomainRolePlayerInfo(typeof(UniquenessIncludesConceptTypeChild), "Uniqueness", UniquenessIncludesConceptTypeChild.UniquenessDomainRoleId),
				new DomainRolePlayerInfo(typeof(UniquenessIncludesConceptTypeChild), "ConceptTypeChild", UniquenessIncludesConceptTypeChild.ConceptTypeChildDomainRoleId),
			};
		}
		#endregion
		#region Factory methods
		private static global::System.Collections.Generic.Dictionary<global::System.Type, int> createElementMap;
	
		/// <summary>
		/// Creates an element of specified type.
		/// </summary>
		/// <param name="partition">Partition where element is to be created.</param>
		/// <param name="elementType">Element type which belongs to this domain model.</param>
		/// <param name="propertyAssignments">New element property assignments.</param>
		/// <returns>Created element.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
		public sealed override DslModeling::ModelElement CreateElement(DslModeling::Partition partition, global::System.Type elementType, DslModeling::PropertyAssignment[] propertyAssignments)
		{
			if (elementType == null) throw new global::System.ArgumentNullException("elementType");
	
			if (createElementMap == null)
			{
				createElementMap = new global::System.Collections.Generic.Dictionary<global::System.Type, int>(4);
				createElementMap.Add(typeof(AbstractionModel), 0);
				createElementMap.Add(typeof(ConceptType), 1);
				createElementMap.Add(typeof(InformationTypeFormat), 2);
				createElementMap.Add(typeof(Uniqueness), 3);
			}
			int index;
			if (!createElementMap.TryGetValue(elementType, out index))
			{
				throw new global::System.ArgumentException("elementType is not recognized as a type of domain class which belongs to this domain model.");
			}
			switch (index)
			{
				case 0: return new AbstractionModel(partition, propertyAssignments);
				case 1: return new ConceptType(partition, propertyAssignments);
				case 2: return new InformationTypeFormat(partition, propertyAssignments);
				case 3: return new Uniqueness(partition, propertyAssignments);
				default: return null;
			}
		}
	
		private static global::System.Collections.Generic.Dictionary<global::System.Type, int> createElementLinkMap;
	
		/// <summary>
		/// Creates an element link of specified type.
		/// </summary>
		/// <param name="partition">Partition where element is to be created.</param>
		/// <param name="elementLinkType">Element link type which belongs to this domain model.</param>
		/// <param name="roleAssignments">List of relationship role assignments for the new link.</param>
		/// <param name="propertyAssignments">New element property assignments.</param>
		/// <returns>Created element link.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
		public sealed override DslModeling::ElementLink CreateElementLink(DslModeling::Partition partition, global::System.Type elementLinkType, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
		{
			if (elementLinkType == null) throw new global::System.ArgumentNullException("elementType");
			if (roleAssignments == null) throw new global::System.ArgumentNullException("roleAssignments");
	
			if (createElementLinkMap == null)
			{
				createElementLinkMap = new global::System.Collections.Generic.Dictionary<global::System.Type, int>(10);
				createElementLinkMap.Add(typeof(AbstractionModelHasConceptType), 0);
				createElementLinkMap.Add(typeof(AbstractionModelHasInformationTypeFormat), 1);
				createElementLinkMap.Add(typeof(ConceptTypeHasUniqueness), 2);
				createElementLinkMap.Add(typeof(ConceptTypeHasChildAsPartOfAssociation), 3);
				createElementLinkMap.Add(typeof(InformationType), 4);
				createElementLinkMap.Add(typeof(ConceptTypeRelatesToConceptType), 5);
				createElementLinkMap.Add(typeof(ConceptTypeAssimilatesConceptType), 6);
				createElementLinkMap.Add(typeof(UniquenessIncludesConceptTypeChild), 7);
			}
			int index;
			if (!createElementLinkMap.TryGetValue(elementLinkType, out index))
			{
				throw new global::System.ArgumentException("elementLinkType is not recognized as a type of domain relationship which belongs to this domain model.");
			}
			switch (index)
			{
				case 0: return new AbstractionModelHasConceptType(partition, roleAssignments, propertyAssignments);
				case 1: return new AbstractionModelHasInformationTypeFormat(partition, roleAssignments, propertyAssignments);
				case 2: return new ConceptTypeHasUniqueness(partition, roleAssignments, propertyAssignments);
				case 3: return new ConceptTypeHasChildAsPartOfAssociation(partition, roleAssignments, propertyAssignments);
				case 4: return new InformationType(partition, roleAssignments, propertyAssignments);
				case 5: return new ConceptTypeRelatesToConceptType(partition, roleAssignments, propertyAssignments);
				case 6: return new ConceptTypeAssimilatesConceptType(partition, roleAssignments, propertyAssignments);
				case 7: return new UniquenessIncludesConceptTypeChild(partition, roleAssignments, propertyAssignments);
				default: return null;
			}
		}
		#endregion
		#region Resource manager
		
		private static global::System.Resources.ResourceManager resourceManager;
		
		/// <summary>
		/// The base name of this model's resources.
		/// </summary>
		public const string ResourceBaseName = "ORMSolutions.ORMArchitect.ORMAbstraction.GeneratedCode.AbstractionDomainModelResx";
		
		/// <summary>
		/// Gets the DomainModel's ResourceManager. If the ResourceManager does not already exist, then it is created.
		/// </summary>
		public override global::System.Resources.ResourceManager ResourceManager
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return AbstractionDomainModel.SingletonResourceManager;
			}
		}
	
		/// <summary>
		/// Gets the Singleton ResourceManager for this domain model.
		/// </summary>
		public static global::System.Resources.ResourceManager SingletonResourceManager
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				if (AbstractionDomainModel.resourceManager == null)
				{
					AbstractionDomainModel.resourceManager = new global::System.Resources.ResourceManager(ResourceBaseName, typeof(AbstractionDomainModel).Assembly);
				}
				return AbstractionDomainModel.resourceManager;
			}
		}
		#endregion
		#region Copy/Remove closures
		/// <summary>
		/// CopyClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter copyClosure;
		/// <summary>
		/// DeleteClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter removeClosure;
		/// <summary>
		/// Returns an IElementVisitorFilter that corresponds to the ClosureType.
		/// </summary>
		/// <param name="type">closure type</param>
		/// <param name="rootElements">collection of root elements</param>
		/// <returns>IElementVisitorFilter or null</returns>
		public override DslModeling::IElementVisitorFilter GetClosureFilter(DslModeling::ClosureType type, global::System.Collections.Generic.ICollection<DslModeling::ModelElement> rootElements)
		{
			switch (type)
			{
				case DslModeling::ClosureType.CopyClosure:
					return AbstractionDomainModel.CopyClosure;
				case DslModeling::ClosureType.DeleteClosure:
					return AbstractionDomainModel.DeleteClosure;
			}
			return base.GetClosureFilter(type, rootElements);
		}
		/// <summary>
		/// CopyClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter CopyClosure
		{
			get
			{
				// Incorporate all of the closures from the models we extend
				if (AbstractionDomainModel.copyClosure == null)
				{
					DslModeling::ChainingElementVisitorFilter copyFilter = new DslModeling::ChainingElementVisitorFilter();
					copyFilter.AddFilter(new AbstractionCopyClosure());
					
					AbstractionDomainModel.copyClosure = copyFilter;
				}
				return AbstractionDomainModel.copyClosure;
			}
		}
		/// <summary>
		/// DeleteClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter DeleteClosure
		{
			get
			{
				// Incorporate all of the closures from the models we extend
				if (AbstractionDomainModel.removeClosure == null)
				{
					DslModeling::ChainingElementVisitorFilter removeFilter = new DslModeling::ChainingElementVisitorFilter();
					removeFilter.AddFilter(new AbstractionDeleteClosure());
		
					AbstractionDomainModel.removeClosure = removeFilter;
				}
				return AbstractionDomainModel.removeClosure;
			}
		}
		#endregion
	}
		
	#region Copy/Remove closure classes
	/// <summary>
	/// Remove closure visitor filter
	/// </summary>
	[global::System.CLSCompliant(true)]
	public partial class AbstractionDeleteClosure : AbstractionDeleteClosureBase, DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public AbstractionDeleteClosure() : base()
		{
		}
	}
	
	/// <summary>
	/// Base class for remove closure visitor filter
	/// </summary>
	public partial class AbstractionDeleteClosureBase : DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// DomainRoles
		/// </summary>
		private global::System.Collections.Generic.Dictionary<global::System.Guid, bool> domainRoles;
		/// <summary>
		/// Constructor
		/// </summary>
		public AbstractionDeleteClosureBase()
		{
			#region Initialize DomainData Table
			DomainRoles.Add(global::ORMSolutions.ORMArchitect.ORMAbstraction.AbstractionModelHasConceptType.ConceptTypeDomainRoleId, true);
			DomainRoles.Add(global::ORMSolutions.ORMArchitect.ORMAbstraction.AbstractionModelHasInformationTypeFormat.InformationTypeFormatDomainRoleId, true);
			DomainRoles.Add(global::ORMSolutions.ORMArchitect.ORMAbstraction.ConceptTypeHasUniqueness.UniquenessDomainRoleId, true);
			DomainRoles.Add(global::ORMSolutions.ORMArchitect.ORMAbstraction.ConceptTypeHasChildAsPartOfAssociation.ParentDomainRoleId, true);
			DomainRoles.Add(global::ORMSolutions.ORMArchitect.ORMAbstraction.InformationType.InformationTypeFormatDomainRoleId, true);
			#endregion
		}
		/// <summary>
		/// Called to ask the filter if a particular relationship from a source element should be included in the traversal
		/// </summary>
		/// <param name="walker">ElementWalker that is traversing the model</param>
		/// <param name="sourceElement">Model Element playing the source role</param>
		/// <param name="sourceRoleInfo">DomainRoleInfo of the role that the source element is playing in the relationship</param>
		/// <param name="domainRelationshipInfo">DomainRelationshipInfo for the ElementLink in question</param>
		/// <param name="targetRelationship">Relationship in question</param>
		/// <returns>Yes if the relationship should be traversed</returns>
		public virtual DslModeling::VisitorFilterResult ShouldVisitRelationship(DslModeling::ElementWalker walker, DslModeling::ModelElement sourceElement, DslModeling::DomainRoleInfo sourceRoleInfo, DslModeling::DomainRelationshipInfo domainRelationshipInfo, DslModeling::ElementLink targetRelationship)
		{
			return DslModeling::VisitorFilterResult.Yes;
		}
		/// <summary>
		/// Called to ask the filter if a particular role player should be Visited during traversal
		/// </summary>
		/// <param name="walker">ElementWalker that is traversing the model</param>
		/// <param name="sourceElement">Model Element playing the source role</param>
		/// <param name="elementLink">Element Link that forms the relationship to the role player in question</param>
		/// <param name="targetDomainRole">DomainRoleInfo of the target role</param>
		/// <param name="targetRolePlayer">Model Element that plays the target role in the relationship</param>
		/// <returns></returns>
		public virtual DslModeling::VisitorFilterResult ShouldVisitRolePlayer(DslModeling::ElementWalker walker, DslModeling::ModelElement sourceElement, DslModeling::ElementLink elementLink, DslModeling::DomainRoleInfo targetDomainRole, DslModeling::ModelElement targetRolePlayer)
		{
			return this.DomainRoles.ContainsKey(targetDomainRole.Id) ? DslModeling::VisitorFilterResult.Yes : DslModeling::VisitorFilterResult.DoNotCare;
		}
		/// <summary>
		/// DomainRoles
		/// </summary>
		private global::System.Collections.Generic.Dictionary<global::System.Guid, bool> DomainRoles
		{
			get
			{
				if (this.domainRoles == null)
				{
					this.domainRoles = new global::System.Collections.Generic.Dictionary<global::System.Guid, bool>();
				}
				return this.domainRoles;
			}
		}
	
	}
	/// <summary>
	/// Copy closure visitor filter
	/// </summary>
	[global::System.CLSCompliant(true)]
	public partial class AbstractionCopyClosure : AbstractionCopyClosureBase, DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public AbstractionCopyClosure() : base()
		{
		}
	}
	/// <summary>
	/// Base class for copy closure visitor filter
	/// </summary>
	public partial class AbstractionCopyClosureBase : DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// DomainRoles
		/// </summary>
		private global::System.Collections.Generic.Dictionary<global::System.Guid, bool> domainRoles;
		/// <summary>
		/// Constructor
		/// </summary>
		public AbstractionCopyClosureBase()
		{
			#region Initialize DomainData Table
			#endregion
		}
		/// <summary>
		/// Called to ask the filter if a particular relationship from a source element should be included in the traversal
		/// </summary>
		/// <param name="walker">ElementWalker traversing the model</param>
		/// <param name="sourceElement">Model Element playing the source role</param>
		/// <param name="sourceRoleInfo">DomainRoleInfo of the role that the source element is playing in the relationship</param>
		/// <param name="domainRelationshipInfo">DomainRelationshipInfo for the ElementLink in question</param>
		/// <param name="targetRelationship">Relationship in question</param>
		/// <returns>Yes if the relationship should be traversed</returns>
		public virtual DslModeling::VisitorFilterResult ShouldVisitRelationship(DslModeling::ElementWalker walker, DslModeling::ModelElement sourceElement, DslModeling::DomainRoleInfo sourceRoleInfo, DslModeling::DomainRelationshipInfo domainRelationshipInfo, DslModeling::ElementLink targetRelationship)
		{
			return this.DomainRoles.ContainsKey(sourceRoleInfo.Id) ? DslModeling::VisitorFilterResult.Yes : DslModeling::VisitorFilterResult.DoNotCare;
		}
		/// <summary>
		/// Called to ask the filter if a particular role player should be Visited during traversal
		/// </summary>
		/// <param name="walker">ElementWalker traversing the model</param>
		/// <param name="sourceElement">Model Element playing the source role</param>
		/// <param name="elementLink">Element Link that forms the relationship to the role player in question</param>
		/// <param name="targetDomainRole">DomainRoleInfo of the target role</param>
		/// <param name="targetRolePlayer">Model Element that plays the target role in the relationship</param>
		/// <returns></returns>
		public virtual DslModeling::VisitorFilterResult ShouldVisitRolePlayer(DslModeling::ElementWalker walker, DslModeling::ModelElement sourceElement, DslModeling::ElementLink elementLink, DslModeling::DomainRoleInfo targetDomainRole, DslModeling::ModelElement targetRolePlayer)
		{
			return this.DomainRoles.ContainsKey(targetDomainRole.Id) ? DslModeling::VisitorFilterResult.Yes : DslModeling::VisitorFilterResult.DoNotCare;
		}
		/// <summary>
		/// DomainRoles
		/// </summary>
		private global::System.Collections.Generic.Dictionary<global::System.Guid, bool> DomainRoles
		{
			get
			{
				if (this.domainRoles == null)
				{
					this.domainRoles = new global::System.Collections.Generic.Dictionary<global::System.Guid, bool>();
				}
				return this.domainRoles;
			}
		}
	
	}
	#endregion
		
}

