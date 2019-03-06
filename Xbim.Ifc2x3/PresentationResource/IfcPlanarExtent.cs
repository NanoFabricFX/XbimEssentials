// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometryResource;
using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.PresentationResource;
//## Custom using statements
//##


namespace Xbim.Ifc2x3.PresentationResource
{
	[ExpressType("IfcPlanarExtent", 469)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPlanarExtent : IfcGeometricRepresentationItem, IInstantiableEntity, IEquatable<@IfcPlanarExtent>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPlanarExtent(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcLengthMeasure _sizeInX;
		private IfcLengthMeasure _sizeInY;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 3)]
		public IfcLengthMeasure @SizeInX 
		{ 
			get 
			{
				if(_activated) return _sizeInX;
				Activate();
				return _sizeInX;
			} 
			set
			{
				SetValue( v =>  _sizeInX = v, _sizeInX, value,  "SizeInX", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 4)]
		public IfcLengthMeasure @SizeInY 
		{ 
			get 
			{
				if(_activated) return _sizeInY;
				Activate();
				return _sizeInY;
			} 
			set
			{
				SetValue( v =>  _sizeInY = v, _sizeInY, value,  "SizeInY", 2);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_sizeInX = value.RealVal;
					return;
				case 1: 
					_sizeInY = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcPlanarExtent other)
	    {
	        return this == other;
	    }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}