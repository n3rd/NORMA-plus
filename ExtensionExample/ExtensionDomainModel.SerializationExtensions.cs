﻿using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Microsoft.VisualStudio.Modeling;
using Microsoft.VisualStudio.Modeling.Diagrams;
using Neumont.Tools.ORM.Shell;
namespace ExtensionExample
{
	#region ExtensionDomainModel model serialization
	public partial class ExtensionDomainModel : IORMCustomSerializedMetaModel
	{
		/// <summary>
		/// Implements IORMCustomSerializedMetaModel.DefaultElementPrefix
		/// </summary>
		protected static string DefaultElementPrefix
		{
			get
			{
				return "ormExtension";
			}
		}
		string IORMCustomSerializedMetaModel.DefaultElementPrefix
		{
			get
			{
				return DefaultElementPrefix;
			}
		}
		/// <summary>
		/// Implements IORMCustomSerializedMetaModel.GetCustomElementNamespaces
		/// </summary>
		protected static string[,] GetCustomElementNamespaces()
		{
			string[,] ret = new string[1, 3];
			ret[0, 0] = "ormExtension";
			ret[0, 1] = "http://schemas.neumont.edu/ORM/ExtensionExample";
			ret[0, 2] = "ExtensionDomainModelTest.xsd";
			return ret;
		}
		string[,] IORMCustomSerializedMetaModel.GetCustomElementNamespaces()
		{
			return GetCustomElementNamespaces();
		}
		private static Dictionary<string, Guid> myClassNameMap;
		private static Collection<string> myValidNamespaces;
		/// <summary>
		/// Implements IORMCustomSerializedMetaModel.ShouldSerializeMetaClass
		/// </summary>
		protected bool ShouldSerializeMetaClass(Store store, MetaClassInfo classInfo)
		{
			return true;
		}
		bool IORMCustomSerializedMetaModel.ShouldSerializeMetaClass(Store store, MetaClassInfo classInfo)
		{
			return this.ShouldSerializeMetaClass(store, classInfo);
		}
		/// <summary>
		/// Implements IORMCustomSerializedMetaModel.GetRootElementClasses
		/// </summary>
		protected static Guid[] GetRootElementClasses()
		{
			return new Guid[0];
		}
		Guid[] IORMCustomSerializedMetaModel.GetRootElementClasses()
		{
			return GetRootElementClasses();
		}
		/// <summary>
		/// Implements IORMCustomSerializedMetaModel.MapRootElement
		/// </summary>
		protected static Guid MapRootElement(string xmlNamespace, string elementName)
		{
			return default(Guid);
		}
		Guid IORMCustomSerializedMetaModel.MapRootElement(string xmlNamespace, string elementName)
		{
			return MapRootElement(xmlNamespace, elementName);
		}
		/// <summary>
		/// Implements IORMCustomSerializedMetaModel.MapClassName
		/// </summary>
		protected static Guid MapClassName(string xmlNamespace, string elementName)
		{
			Collection<string> validNamespaces = ExtensionDomainModel.myValidNamespaces;
			Dictionary<string, Guid> classNameMap = ExtensionDomainModel.myClassNameMap;
			if (validNamespaces == null)
			{
				validNamespaces = new Collection<string>();
				validNamespaces.Add("http://schemas.neumont.edu/ORM/ExtensionExample");
				ExtensionDomainModel.myValidNamespaces = validNamespaces;
			}
			if (classNameMap == null)
			{
				classNameMap = new Dictionary<string, Guid>();
				classNameMap.Add("SampleElement", MyCustomExtensionElement.MetaClassGuid);
				ExtensionDomainModel.myClassNameMap = classNameMap;
			}
			if (validNamespaces.Contains(xmlNamespace) && classNameMap.ContainsKey(elementName))
			{
				return classNameMap[elementName];
			}
			return default(Guid);
		}
		Guid IORMCustomSerializedMetaModel.MapClassName(string xmlNamespace, string elementName)
		{
			return MapClassName(xmlNamespace, elementName);
		}
	}
	#endregion // ExtensionDomainModel model serialization
	#region MyCustomExtensionElement serialization
	public partial class MyCustomExtensionElement : IORMCustomSerializedElement
	{
		/// <summary>
		/// Implements IORMCustomSerializedElement.SupportedCustomSerializedOperations
		/// </summary>
		protected ORMCustomSerializedElementSupportedOperations SupportedCustomSerializedOperations
		{
			get
			{
				return ORMCustomSerializedElementSupportedOperations.ElementInfo;
			}
		}
		ORMCustomSerializedElementSupportedOperations IORMCustomSerializedElement.SupportedCustomSerializedOperations
		{
			get
			{
				return this.SupportedCustomSerializedOperations;
			}
		}
		/// <summary>
		/// Implements IORMCustomSerializedElement.GetCustomSerializedChildElementInfo
		/// </summary>
		protected ORMCustomSerializedChildElementInfo[] GetCustomSerializedChildElementInfo()
		{
			throw new NotSupportedException();
		}
		ORMCustomSerializedChildElementInfo[] IORMCustomSerializedElement.GetCustomSerializedChildElementInfo()
		{
			return this.GetCustomSerializedChildElementInfo();
		}
		/// <summary>
		/// Implements IORMCustomSerializedElement.CustomSerializedElementInfo
		/// </summary>
		protected ORMCustomSerializedElementInfo CustomSerializedElementInfo
		{
			get
			{
				return new ORMCustomSerializedElementInfo(null, "SampleElement", null, ORMCustomSerializedElementWriteStyle.Element, null);
			}
		}
		ORMCustomSerializedElementInfo IORMCustomSerializedElement.CustomSerializedElementInfo
		{
			get
			{
				return this.CustomSerializedElementInfo;
			}
		}
		/// <summary>
		/// Implements IORMCustomSerializedElement.GetCustomSerializedAttributeInfo
		/// </summary>
		protected ORMCustomSerializedAttributeInfo GetCustomSerializedAttributeInfo(MetaAttributeInfo attributeInfo, MetaRoleInfo rolePlayedInfo)
		{
			throw new NotSupportedException();
		}
		ORMCustomSerializedAttributeInfo IORMCustomSerializedElement.GetCustomSerializedAttributeInfo(MetaAttributeInfo attributeInfo, MetaRoleInfo rolePlayedInfo)
		{
			return this.GetCustomSerializedAttributeInfo(attributeInfo, rolePlayedInfo);
		}
		/// <summary>
		/// Implements IORMCustomSerializedElement.GetCustomSerializedLinkInfo
		/// </summary>
		protected ORMCustomSerializedElementInfo GetCustomSerializedLinkInfo(MetaRoleInfo rolePlayedInfo)
		{
			throw new NotSupportedException();
		}
		ORMCustomSerializedElementInfo IORMCustomSerializedElement.GetCustomSerializedLinkInfo(MetaRoleInfo rolePlayedInfo)
		{
			return this.GetCustomSerializedLinkInfo(rolePlayedInfo);
		}
		/// <summary>
		/// Implements IORMCustomSerializedElement.CustomSerializedChildRoleComparer
		/// </summary>
		[CLSCompliant(false)]
		protected IComparer<MetaRoleInfo> CustomSerializedChildRoleComparer
		{
			get
			{
				return null;
			}
		}
		IComparer<MetaRoleInfo> IORMCustomSerializedElement.CustomSerializedChildRoleComparer
		{
			get
			{
				return this.CustomSerializedChildRoleComparer;
			}
		}
		/// <summary>
		/// Implements IORMCustomSerializedElement.MapChildElement
		/// </summary>
		protected ORMCustomSerializedElementMatch MapChildElement(string elementNamespace, string elementName, string containerNamespace, string containerName)
		{
			return default(ORMCustomSerializedElementMatch);
		}
		ORMCustomSerializedElementMatch IORMCustomSerializedElement.MapChildElement(string elementNamespace, string elementName, string containerNamespace, string containerName)
		{
			return this.MapChildElement(elementNamespace, elementName, containerNamespace, containerName);
		}
		/// <summary>
		/// Implements IORMCustomSerializedElement.MapAttribute
		/// </summary>
		protected Guid MapAttribute(string xmlNamespace, string attributeName)
		{
			return default(Guid);
		}
		Guid IORMCustomSerializedElement.MapAttribute(string xmlNamespace, string attributeName)
		{
			return this.MapAttribute(xmlNamespace, attributeName);
		}
		/// <summary>
		/// Implements IORMCustomSerializedElement.ShouldSerialize
		/// </summary>
		protected bool ShouldSerialize()
		{
			return (TestEnumeration.None != this.CustomEnum) || ("Default value" != this.TestProperty);
		}
		bool IORMCustomSerializedElement.ShouldSerialize()
		{
			return this.ShouldSerialize();
		}
	}
	#endregion // MyCustomExtensionElement serialization
}
