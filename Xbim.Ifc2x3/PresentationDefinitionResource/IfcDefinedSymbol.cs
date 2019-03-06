// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometryResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.PresentationDefinitionResource;
//## Custom using statements
//##


namespace Xbim.Ifc2x3.PresentationDefinitionResource
{
	[ExpressType("IfcDefinedSymbol", 461)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcDefinedSymbol : IfcGeometricRepresentationItem, IInstantiableEntity, IContainsEntityReferences, IEquatable<@IfcDefinedSymbol>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcDefinedSymbol(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcDefinedSymbolSelect _definition;
		private IfcCartesianTransformationOperator2D _target;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 3)]
		public IfcDefinedSymbolSelect @Definition 
		{ 
			get 
			{
				if(_activated) return _definition;
				Activate();
				return _definition;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _definition = v, _definition, value,  "Definition", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 4)]
		public IfcCartesianTransformationOperator2D @Target 
		{ 
			get 
			{
				if(_activated) return _target;
				Activate();
				return _target;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _target = v, _target, value,  "Target", 2);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_definition = (IfcDefinedSymbolSelect)(value.EntityVal);
					return;
				case 1: 
					_target = (IfcCartesianTransformationOperator2D)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcDefinedSymbol other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Definition != null)
					yield return @Definition;
				if (@Target != null)
					yield return @Target;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}