using NeuWillow.Anatomy.Brain.NeuroTransmitters;

namespace NeuWillow.Anatomy.Brain.Neurons.Dendrites;

public class TimeBasedNeurotransmitterDispatcher : INeurotransmitterDispatcher
{
    public void Add(NeurotransmitterType neurotransmitter)
    {
        // TODO: For now we will rely on .NET DateTime.Nanoseconds.
        // This will obviously have different accuracy depending on hardware and O/S.
        // This can turn into a rabbit hole of research, one that can be investigated later.
    }
}   