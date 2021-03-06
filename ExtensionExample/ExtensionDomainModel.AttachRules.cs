﻿using System;
using System.Reflection;

// Common Public License Copyright Notice
// /**************************************************************************\
// * Natural Object-Role Modeling Architect for Visual Studio                 *
// *                                                                          *
// * Copyright © Neumont University. All rights reserved.                     *
// * Copyright © The ORM Foundation. All rights reserved.                     *
// *                                                                          *
// * The use and distribution terms for this software are covered by the      *
// * Common Public License 1.0 (http://opensource.org/licenses/cpl) which     *
// * can be found in the file CPL.txt at the root of this distribution.       *
// * By using this software in any fashion, you are agreeing to be bound by   *
// * the terms of this license.                                               *
// *                                                                          *
// * You must not remove this notice, or any other, from this software.       *
// \**************************************************************************/

namespace ORMSolutions.ORMArchitect.ExtensionExample
{
	#region Attach rules to ExtensionDomainModel model
	partial class ExtensionDomainModel : ORMSolutions.ORMArchitect.Framework.Shell.IDomainModelEnablesRulesAfterDeserialization
	{
		private static Type[] myCustomDomainModelTypes;
		private static Type[] CustomDomainModelTypes
		{
			get
			{
				Type[] retVal = ExtensionDomainModel.myCustomDomainModelTypes;
				if (retVal == null)
				{
					// No synchronization is needed here.
					// If accessed concurrently, the worst that will happen is the array of Types being created multiple times.
					// This would have a slightly negative impact on performance, but the result would still be correct.
					// Given the low likelihood of this ever happening, the extra overhead of synchronization would outweigh any possible gain from it.
					retVal = new Type[]{
						typeof(MyCustomExtensionElement).GetNestedType("RoleAddRuleClass", BindingFlags.Public | BindingFlags.NonPublic),
						typeof(ObjectTypeRequiresMeaningfulNameError).GetNestedType("ExtensionObjectTypeAddRuleClass", BindingFlags.Public | BindingFlags.NonPublic),
						typeof(ObjectTypeRequiresMeaningfulNameError).GetNestedType("ExtensionObjectTypeChangeRuleClass", BindingFlags.Public | BindingFlags.NonPublic)};
					ExtensionDomainModel.myCustomDomainModelTypes = retVal;
					System.Diagnostics.Debug.Assert(Array.IndexOf<Type>(retVal, null) < 0, "One or more rule types failed to resolve. The file and/or package will fail to load.");
				}
				return retVal;
			}
		}
		/// <summary>Generated code to attach <see cref="Microsoft.VisualStudio.Modeling.Rule"/>s to the <see cref="Microsoft.VisualStudio.Modeling.Store"/>.</summary>
		/// <seealso cref="Microsoft.VisualStudio.Modeling.DomainModel.GetCustomDomainModelTypes"/>
		protected override Type[] GetCustomDomainModelTypes()
		{
			if (ORMSolutions.ORMArchitect.Framework.FrameworkDomainModel.InitializingToolboxItems)
			{
				return Type.EmptyTypes;
			}
			Type[] retVal = base.GetCustomDomainModelTypes();
			int baseLength = retVal.Length;
			Type[] customDomainModelTypes = ExtensionDomainModel.CustomDomainModelTypes;
			if (baseLength <= 0)
			{
				return customDomainModelTypes;
			}
			else
			{
				Array.Resize<Type>(ref retVal, baseLength + customDomainModelTypes.Length);
				customDomainModelTypes.CopyTo(retVal, baseLength);
				return retVal;
			}
		}
		/// <summary>Implements IDomainModelEnablesRulesAfterDeserialization.EnableRulesAfterDeserialization</summary>
		protected void EnableRulesAfterDeserialization(Microsoft.VisualStudio.Modeling.Store store)
		{
			Microsoft.VisualStudio.Modeling.RuleManager ruleManager = store.RuleManager;
			Type[] disabledRuleTypes = ExtensionDomainModel.CustomDomainModelTypes;
			for (int i = 0; i < 3; ++i)
			{
				ruleManager.EnableRule(disabledRuleTypes[i]);
			}
		}
		void ORMSolutions.ORMArchitect.Framework.Shell.IDomainModelEnablesRulesAfterDeserialization.EnableRulesAfterDeserialization(Microsoft.VisualStudio.Modeling.Store store)
		{
			this.EnableRulesAfterDeserialization(store);
		}
	}
	#endregion // Attach rules to ExtensionDomainModel model
	#region Auto-rule classes
	#region Rule classes for MyCustomExtensionElement
	partial class MyCustomExtensionElement
	{
		[Microsoft.VisualStudio.Modeling.RuleOn(typeof(ORMSolutions.ORMArchitect.Core.ObjectModel.FactTypeHasRole), Priority=ORMSolutions.ORMArchitect.Framework.FrameworkDomainModel.InlineRulePriority)]
		private sealed class RoleAddRuleClass : Microsoft.VisualStudio.Modeling.AddRule
		{
			[System.Diagnostics.DebuggerStepThrough()]
			public RoleAddRuleClass()
			{
				base.IsEnabled = false;
			}
			/// <summary>
			/// Provide the following method in class: 
			/// ORMSolutions.ORMArchitect.ExtensionExample.MyCustomExtensionElement
			/// /// <summary>
			/// /// AddRule: typeof(ORMSolutions.ORMArchitect.Core.ObjectModel.FactTypeHasRole)
			/// /// </summary>
			/// private static void RoleAddRule(ElementAddedEventArgs e)
			/// {
			/// }
			/// </summary>
			[System.Diagnostics.DebuggerStepThrough()]
			public override void ElementAdded(Microsoft.VisualStudio.Modeling.ElementAddedEventArgs e)
			{
				ORMSolutions.ORMArchitect.Framework.Diagnostics.TraceUtility.TraceRuleStart(e.ModelElement.Store, "ORMSolutions.ORMArchitect.ExtensionExample.MyCustomExtensionElement.RoleAddRule");
				MyCustomExtensionElement.RoleAddRule(e);
				ORMSolutions.ORMArchitect.Framework.Diagnostics.TraceUtility.TraceRuleEnd(e.ModelElement.Store, "ORMSolutions.ORMArchitect.ExtensionExample.MyCustomExtensionElement.RoleAddRule");
			}
		}
	}
	#endregion // Rule classes for MyCustomExtensionElement
	#region Rule classes for ObjectTypeRequiresMeaningfulNameError
	partial class ObjectTypeRequiresMeaningfulNameError
	{
		[Microsoft.VisualStudio.Modeling.RuleOn(typeof(ORMSolutions.ORMArchitect.Core.ObjectModel.ModelHasObjectType), Priority=ORMSolutions.ORMArchitect.Framework.FrameworkDomainModel.InlineRulePriority)]
		private sealed class ExtensionObjectTypeAddRuleClass : Microsoft.VisualStudio.Modeling.AddRule
		{
			[System.Diagnostics.DebuggerStepThrough()]
			public ExtensionObjectTypeAddRuleClass()
			{
				base.IsEnabled = false;
			}
			/// <summary>
			/// Provide the following method in class: 
			/// ORMSolutions.ORMArchitect.ExtensionExample.ObjectTypeRequiresMeaningfulNameError
			/// /// <summary>
			/// /// AddRule: typeof(ORMSolutions.ORMArchitect.Core.ObjectModel.ModelHasObjectType)
			/// /// </summary>
			/// private static void ExtensionObjectTypeAddRule(ElementAddedEventArgs e)
			/// {
			/// }
			/// </summary>
			[System.Diagnostics.DebuggerStepThrough()]
			public override void ElementAdded(Microsoft.VisualStudio.Modeling.ElementAddedEventArgs e)
			{
				ORMSolutions.ORMArchitect.Framework.Diagnostics.TraceUtility.TraceRuleStart(e.ModelElement.Store, "ORMSolutions.ORMArchitect.ExtensionExample.ObjectTypeRequiresMeaningfulNameError.ExtensionObjectTypeAddRule");
				ObjectTypeRequiresMeaningfulNameError.ExtensionObjectTypeAddRule(e);
				ORMSolutions.ORMArchitect.Framework.Diagnostics.TraceUtility.TraceRuleEnd(e.ModelElement.Store, "ORMSolutions.ORMArchitect.ExtensionExample.ObjectTypeRequiresMeaningfulNameError.ExtensionObjectTypeAddRule");
			}
		}
		[Microsoft.VisualStudio.Modeling.RuleOn(typeof(ORMSolutions.ORMArchitect.Core.ObjectModel.ObjectType), Priority=ORMSolutions.ORMArchitect.Framework.FrameworkDomainModel.InlineRulePriority)]
		private sealed class ExtensionObjectTypeChangeRuleClass : Microsoft.VisualStudio.Modeling.ChangeRule
		{
			[System.Diagnostics.DebuggerStepThrough()]
			public ExtensionObjectTypeChangeRuleClass()
			{
				base.IsEnabled = false;
			}
			/// <summary>
			/// Provide the following method in class: 
			/// ORMSolutions.ORMArchitect.ExtensionExample.ObjectTypeRequiresMeaningfulNameError
			/// /// <summary>
			/// /// ChangeRule: typeof(ORMSolutions.ORMArchitect.Core.ObjectModel.ObjectType)
			/// /// </summary>
			/// private static void ExtensionObjectTypeChangeRule(ElementPropertyChangedEventArgs e)
			/// {
			/// }
			/// </summary>
			[System.Diagnostics.DebuggerStepThrough()]
			public override void ElementPropertyChanged(Microsoft.VisualStudio.Modeling.ElementPropertyChangedEventArgs e)
			{
				ORMSolutions.ORMArchitect.Framework.Diagnostics.TraceUtility.TraceRuleStart(e.ModelElement.Store, "ORMSolutions.ORMArchitect.ExtensionExample.ObjectTypeRequiresMeaningfulNameError.ExtensionObjectTypeChangeRule");
				ObjectTypeRequiresMeaningfulNameError.ExtensionObjectTypeChangeRule(e);
				ORMSolutions.ORMArchitect.Framework.Diagnostics.TraceUtility.TraceRuleEnd(e.ModelElement.Store, "ORMSolutions.ORMArchitect.ExtensionExample.ObjectTypeRequiresMeaningfulNameError.ExtensionObjectTypeChangeRule");
			}
		}
	}
	#endregion // Rule classes for ObjectTypeRequiresMeaningfulNameError
	#endregion // Auto-rule classes
}
