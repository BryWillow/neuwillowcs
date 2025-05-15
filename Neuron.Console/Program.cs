using Neuron.DendriteLib;
using Neuron.AxonLib;
using Neuron.SomaLib;

Console.WriteLine("Hello, World!");

Random random = new Random();

// Dendrites typically have between 5-7 main branches
int numberOfMainBranches = 5;


int numberOfSecondaryBranches = 100;

int numberOfDendrites = random.Next();

Dendrite dendrite = new();


Axon axon = new();
Soma soma = new();