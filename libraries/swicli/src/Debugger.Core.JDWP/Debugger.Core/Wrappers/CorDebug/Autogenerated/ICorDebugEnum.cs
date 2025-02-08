// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="David Srbecký" email="dsrbecky@gmail.com"/>
//     <version>$Revision$</version>
// </file>

// This file is automatically generated - any changes will be lost

#pragma warning disable 1591

namespace Debugger.Wrappers.CorDebug
{
	using System;
	
	
	public partial class ICorDebugEnum
	{
		
		private Debugger.Interop.CorDebug.ICorDebugEnum wrappedObject;
		
		internal Debugger.Interop.CorDebug.ICorDebugEnum WrappedObject
		{
			get
			{
				return this.wrappedObject;
			}
		}
		
		public ICorDebugEnum(Debugger.Interop.CorDebug.ICorDebugEnum wrappedObject)
		{
			this.wrappedObject = wrappedObject;
			ResourceManager.TrackCOMObject(wrappedObject, typeof(ICorDebugEnum));
		}
		
		public static ICorDebugEnum Wrap(Debugger.Interop.CorDebug.ICorDebugEnum objectToWrap)
		{
			if ((objectToWrap != null))
			{
				return new ICorDebugEnum(objectToWrap);
			} else
			{
				return null;
			}
		}
		
		~ICorDebugEnum()
		{
			object o = wrappedObject;
			wrappedObject = null;
			ResourceManager.ReleaseCOMObject(o, typeof(ICorDebugEnum));
		}
		
		public bool Is<T>() where T: class
		{
			System.Reflection.ConstructorInfo ctor = typeof(T).GetConstructors()[0];
			System.Type paramType = ctor.GetParameters()[0].ParameterType;
			return paramType.IsInstanceOfType(this.WrappedObject);
		}
		
		public T As<T>() where T: class
		{
			try {
				return CastTo<T>();
			} catch {
				return null;
			}
		}
		
		public T CastTo<T>() where T: class
		{
			return (T)Activator.CreateInstance(typeof(T), this.WrappedObject);
		}
		
		public static bool operator ==(ICorDebugEnum o1, ICorDebugEnum o2)
		{
			return ((object)o1 == null && (object)o2 == null) ||
			       ((object)o1 != null && (object)o2 != null && o1.WrappedObject == o2.WrappedObject);
		}
		
		public static bool operator !=(ICorDebugEnum o1, ICorDebugEnum o2)
		{
			return !(o1 == o2);
		}
		
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
		
		public override bool Equals(object o)
		{
			ICorDebugEnum casted = o as ICorDebugEnum;
			return (casted != null) && (casted.WrappedObject == wrappedObject);
		}
		
		
		public void Skip(uint celt)
		{
			this.WrappedObject.Skip(celt);
		}
		
		public void Reset()
		{
			this.WrappedObject.Reset();
		}
		
		public ICorDebugEnum Clone()
		{
			ICorDebugEnum ppEnum;
			Debugger.Interop.CorDebug.ICorDebugEnum out_ppEnum;
			this.WrappedObject.Clone(out out_ppEnum);
			ppEnum = ICorDebugEnum.Wrap(out_ppEnum);
			return ppEnum;
		}
		
		public uint Count
		{
			get
			{
				uint pcelt;
				this.WrappedObject.GetCount(out pcelt);
				return pcelt;
			}
		}
	}
}

#pragma warning restore 1591
