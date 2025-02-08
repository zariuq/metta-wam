// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="David Srbecký" email="dsrbecky@gmail.com"/>
//     <version>$Revision$</version>
// </file>

// This file is automatically generated - any changes will be lost

#pragma warning disable 1591

namespace Debugger.Wrappers.CorSym
{
	using System;
	
	
	public partial class ISymUnmanagedDocument
	{
		
		private Debugger.Interop.CorSym.ISymUnmanagedDocument wrappedObject;
		
		internal Debugger.Interop.CorSym.ISymUnmanagedDocument WrappedObject
		{
			get
			{
				return this.wrappedObject;
			}
		}
		
		public ISymUnmanagedDocument(Debugger.Interop.CorSym.ISymUnmanagedDocument wrappedObject)
		{
			this.wrappedObject = wrappedObject;
			ResourceManager.TrackCOMObject(wrappedObject, typeof(ISymUnmanagedDocument));
		}
		
		public static ISymUnmanagedDocument Wrap(Debugger.Interop.CorSym.ISymUnmanagedDocument objectToWrap)
		{
			if ((objectToWrap != null))
			{
				return new ISymUnmanagedDocument(objectToWrap);
			} else
			{
				return null;
			}
		}
		
		~ISymUnmanagedDocument()
		{
			object o = wrappedObject;
			wrappedObject = null;
			ResourceManager.ReleaseCOMObject(o, typeof(ISymUnmanagedDocument));
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
		
		public static bool operator ==(ISymUnmanagedDocument o1, ISymUnmanagedDocument o2)
		{
			return ((object)o1 == null && (object)o2 == null) ||
			       ((object)o1 != null && (object)o2 != null && o1.WrappedObject == o2.WrappedObject);
		}
		
		public static bool operator !=(ISymUnmanagedDocument o1, ISymUnmanagedDocument o2)
		{
			return !(o1 == o2);
		}
		
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
		
		public override bool Equals(object o)
		{
			ISymUnmanagedDocument casted = o as ISymUnmanagedDocument;
			return (casted != null) && (casted.WrappedObject == wrappedObject);
		}
		
		
		public void GetURL(uint cchUrl, out uint pcchUrl, System.IntPtr szUrl)
		{
			this.WrappedObject.GetURL(cchUrl, out pcchUrl, szUrl);
		}
		
		public System.Guid DocumentType
		{
			get
			{
				return this.WrappedObject.GetDocumentType();
			}
		}
		
		public System.Guid Language
		{
			get
			{
				return this.WrappedObject.GetLanguage();
			}
		}
		
		public System.Guid LanguageVendor
		{
			get
			{
				return this.WrappedObject.GetLanguageVendor();
			}
		}
		
		public System.Guid CheckSumAlgorithmId
		{
			get
			{
				return this.WrappedObject.GetCheckSumAlgorithmId();
			}
		}
		
		public void GetCheckSum(uint cData, out uint pcData, System.IntPtr data)
		{
			this.WrappedObject.GetCheckSum(cData, out pcData, data);
		}
		
		public uint FindClosestLine(uint line)
		{
			return this.WrappedObject.FindClosestLine(line);
		}
		
		public int HasEmbeddedSource()
		{
			return this.WrappedObject.HasEmbeddedSource();
		}
		
		public uint SourceLength
		{
			get
			{
				return this.WrappedObject.GetSourceLength();
			}
		}
		
		public void GetSourceRange(uint startLine, uint startColumn, uint endLine, uint endColumn, uint cSourceBytes, out uint pcSourceBytes, System.IntPtr source)
		{
			this.WrappedObject.GetSourceRange(startLine, startColumn, endLine, endColumn, cSourceBytes, out pcSourceBytes, source);
		}
	}
}

#pragma warning restore 1591
