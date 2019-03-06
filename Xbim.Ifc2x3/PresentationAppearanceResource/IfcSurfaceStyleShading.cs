// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.PresentationResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.PresentationAppearanceResource;
//## Custom using statements
//##


namespace Xbim.Ifc2x3.PresentationAppearanceResource
{
	[ExpressType("IfcSurfaceStyleShading", 316)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSurfaceStyleShading : PersistEntity, IInstantiableEntity, IfcSurfaceStyleElementSelect, IContainsEntityReferences, IEquatable<@IfcSurfaceStyleShading>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSurfaceStyleShading(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcColourRgb _surfaceColour;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 1)]
		public IfcColourRgb @SurfaceColour 
		{ 
			get 
			{
				if(_activated) return _surfaceColour;
				Activate();
				return _surfaceColour;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _surfaceColour = v, _surfaceColour, value,  "SurfaceColour", 1);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_surfaceColour = (IfcColourRgb)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcSurfaceStyleShading other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@SurfaceColour != null)
					yield return @SurfaceColour;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}