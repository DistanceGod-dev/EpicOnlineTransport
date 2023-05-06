// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Connect
{
	/// <summary>
	/// Structure containing information or the connect user login status change callback.
	/// </summary>
	public struct AddNotifyLoginStatusChangedOptions
	{
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct AddNotifyLoginStatusChangedOptionsInternal : ISettable<AddNotifyLoginStatusChangedOptions>, System.IDisposable
	{
		private int m_ApiVersion;

		public void Set(ref AddNotifyLoginStatusChangedOptions other)
		{
			m_ApiVersion = ConnectInterface.AddnotifyloginstatuschangedApiLatest;
		}

		public void Set(ref AddNotifyLoginStatusChangedOptions? other)
		{
			if (other.HasValue)
			{
				m_ApiVersion = ConnectInterface.AddnotifyloginstatuschangedApiLatest;
			}
		}

		public void Dispose()
		{
		}
	}
}