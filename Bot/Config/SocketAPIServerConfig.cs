using System;

namespace SysBot.ACNHOrders
{
	[Serializable]
	public class SocketAPIServerConfig
	{
		/// <summary>
		/// Whether the socket API server should be enabled or not.
		/// </summary>
		public bool Enabled { get; set; } = false;

		/// <summary>
		/// Whether the server should also accept connections outside the local area network.
		/// </summary>
		public bool AllowRemoteClients { get; set; } = false;

		/// <summary>
		/// Whether logs relative to the socket API server should be written out to console.
		/// </summary>
		public bool LogsEnabled { get; set; } = true;

		/// <summary>
		/// The network port on which the socket server listens for incoming connections.
		/// </summary>
		public ushort Port { get; set; }
	}
}