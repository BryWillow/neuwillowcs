namespace NeuWillow.Anatomy.Brain.Neurons.Dendrites;

public class Dendrite
{
    public int DendriteId { get; private set; }

    public IEnumerable<DendriticSpine> DendriticSpines { get; }

    /// <summary>
    /// A single dendrite can process different types of neurotransmitters simultaneously.
    /// A single dendrite can receive multiple neurotransmitters simultaneously
    /// </summary>
    /// <param name="neuroTransmitter"></param>
    //public void Process(INeurotransmitter neuroTransmitter)
    //{

    //}

    /// <summary>
    /// A single dendrite can process different types of neurotransmitters simultaneously.
    /// E.g., 
    /// </summary>
    /// <param name="neuroTransmitter"></param>
    //public void Process(IEnumerable<INeurotransmitter> neurotransmitters)
    //{

    //}
}