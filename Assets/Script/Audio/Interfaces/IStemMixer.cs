using System;
using System.Collections.Generic;

namespace YARG {
	public interface IStemMixer : IDisposable {

		public int StemsLoaded { get; }
		
		public bool IsPlaying { get; }
		
		public IReadOnlyDictionary<SongStem, IStemChannel> Channels { get; }

		public IStemChannel LeadChannel { get; }
		
		public bool Create();

		public int Play(bool restart = false);

		public int Pause();

		public double GetPosition();
		
		public int AddChannel(IStemChannel channel);
		
		public bool RemoveChannel(IStemChannel channel);
		
		public IStemChannel GetChannel(SongStem stem);
		
	}
}