using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NeuWillow.Anatomy.Brain.Neurons.Axons;

public class Axon(decimal length, bool isMylenated)
{

    /// <summary>
    /// Length is expressed in millimeters.
    /// </summary>
    public decimal Length => length;
    
    public bool IsMylenated => isMylenated;
}