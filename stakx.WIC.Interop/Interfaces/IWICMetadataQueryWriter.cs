﻿using System;
using System.Runtime.InteropServices;

namespace stakx.WIC.Interop
{
    [ComImport]
    [Guid(IID.IWICMetadataQueryWriter)]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWICMetadataQueryWriter : IWICMetadataQueryReader
    {
        #region Members inherited from `IWICMetadataQueryReader`

        new void GetContainerFormat(
            [Out] out Guid pguidContainerFormat);

        new void GetLocation(
            [In] int cchMaxLength,
            [In, Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U2, SizeParamIndex = 0)] char[] wzNamespace,
            [Out] out int pcchActualLength);

        new void GetMetadataByName(
            [In, MarshalAs(UnmanagedType.LPWStr)] string wzName,
            [In, Out, MarshalAs(UnmanagedType.Struct)] ref PROPVARIANT pvarValue);

        new void GetEnumerator(
            [Out] out IEnumString ppIEnumString);

        #endregion

        void SetMetadataByName(
           [In, MarshalAs(UnmanagedType.LPWStr)] string wzName,
           [In, MarshalAs(UnmanagedType.LPStruct)] PROPVARIANT pvarValue);

        void RemoveMetadataByName(
           [In, MarshalAs(UnmanagedType.LPWStr)] string wzName);
    }
}
