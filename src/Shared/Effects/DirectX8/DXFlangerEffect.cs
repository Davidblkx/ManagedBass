namespace ManagedBass.DirectX8
{
    public sealed class DXFlangerEffect : Effect<DXFlangerParameters>
    {
        /// <summary>
        /// Creates a new instance of <see cref="DXFlangerEffect"/>.
        /// </summary>
        /// <param name="Channel">The <paramref name="Channel"/> to apply the effect on.</param>
        /// <param name="Priority">Priority of the Effect... default = 0.</param>
        public DXFlangerEffect(int Channel, int Priority = 0) : base(Channel, Priority) { }

        /// <summary>
        /// Creates a new instance of <see cref="DXFlangerEffect"/> supporting <see cref="MediaPlayer"/>'s persistence.
        /// </summary>
        /// <param name="Player">The <see cref="MediaPlayer"/> to apply the effect on.</param>
        /// <param name="Priority">Priority of the Effect... default = 0.</param>
        public DXFlangerEffect(MediaPlayer Player, int Priority = 0) : base(Player, Priority) { }

        /// <summary>
        /// Ratio of wet (processed) signal to dry (unprocessed) signal. Must be in the range from 0 (default) through 100 (all wet).
        /// </summary>
        public double WetDryMix
        {
            get { return Parameters.fWetDryMix; }
            set
            {
                Parameters.fWetDryMix = (float)value;

                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Percentage by which the delay time is modulated by the low-frequency oscillator (LFO), in hundredths of a percentage point. Must be in the range from 0 through 100. The default value is 25.
        /// </summary>
        public double Depth
        {
            get { return Parameters.fDepth; }
            set
            {
                Parameters.fDepth = (float)value;

                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Percentage of output signal to feed back into the effect's input, in the range from -99 to 99. The default value is 0.
        /// </summary>
        public double Feedback
        {
            get { return Parameters.fFeedback; }
            set
            {
                Parameters.fFeedback = (float)value;

                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Frequency of the LFO, in the range from 0 to 10. The default value is 0.
        /// </summary>
        public double Frequency
        {
            get { return Parameters.fFrequency; }
            set
            {
                Parameters.fFrequency = (float)value;

                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Waveform of the LFO. Default = <see cref="DXWaveform.Sine"/>.
        /// </summary>
        public DXWaveform Waveform
        {
            get { return Parameters.lWaveform; }
            set
            {
                Parameters.lWaveform = value;

                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Number of milliseconds the input is delayed before it is played back, in the range from 0 to 4. The default value is 0 ms.
        /// </summary>
        public double Delay
        {
            get { return Parameters.fDelay; }
            set
            {
                Parameters.fDelay = (float)value;

                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Phase differential between left and right LFOs. Default = <see cref="DXPhase.Zero"/>.
        /// </summary>
        public DXPhase Phase
        {
            get { return Parameters.lPhase; }
            set
            {
                Parameters.lPhase = value;

                OnPropertyChanged();
            }
        }
    }
}