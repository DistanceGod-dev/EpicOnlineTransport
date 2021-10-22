// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Lobby
{
	/// <summary>
	/// Output parameters for the <see cref="LobbyInterface.AddNotifyLobbyMemberStatusReceived" /> function.
	/// </summary>
	public class LobbyMemberStatusReceivedCallbackInfo : ICallbackInfo, ISettable
	{
		/// <summary>
		/// Context that was passed into <see cref="LobbyInterface.AddNotifyLobbyMemberStatusReceived" />
		/// </summary>
		public object ClientData { get; private set; }

		/// <summary>
		/// The ID of the lobby
		/// </summary>
		public string LobbyId { get; private set; }

		/// <summary>
		/// The Product User ID of the lobby member
		/// </summary>
		public ProductUserId TargetUserId { get; private set; }

		/// <summary>
		/// Latest status of the user
		/// </summary>
		public LobbyMemberStatus CurrentStatus { get; private set; }

		public Result? GetResultCode()
		{
			return null;
		}

		internal void Set(LobbyMemberStatusReceivedCallbackInfoInternal? other)
		{
			if (other != null)
			{
				ClientData = other.Value.ClientData;
				LobbyId = other.Value.LobbyId;
				TargetUserId = other.Value.TargetUserId;
				CurrentStatus = other.Value.CurrentStatus;
			}
		}

		public void Set(object other)
		{
			Set(other as LobbyMemberStatusReceivedCallbackInfoInternal?);
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct LobbyMemberStatusReceivedCallbackInfoInternal : ICallbackInfoInternal
	{
		private System.IntPtr m_ClientData;
		private System.IntPtr m_LobbyId;
		private System.IntPtr m_TargetUserId;
		private LobbyMemberStatus m_CurrentStatus;

		public object ClientData
		{
			get
			{
				object value;
				Helper.TryMarshalGet(m_ClientData, out value);
				return value;
			}
		}

		public System.IntPtr ClientDataAddress
		{
			get
			{
				return m_ClientData;
			}
		}

		public string LobbyId
		{
			get
			{
				string value;
				Helper.TryMarshalGet(m_LobbyId, out value);
				return value;
			}
		}

		public ProductUserId TargetUserId
		{
			get
			{
				ProductUserId value;
				Helper.TryMarshalGet(m_TargetUserId, out value);
				return value;
			}
		}

		public LobbyMemberStatus CurrentStatus
		{
			get
			{
				return m_CurrentStatus;
			}
		}
	}
}