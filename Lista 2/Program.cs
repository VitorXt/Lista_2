using System;

class Perceptron
{
    private double[] weights;
    private double learningRate;

    public Perceptron(int inputSize, double learningRate = 0.1)
    {
        weights = new double[inputSize + 1];
        this.learningRate = learningRate;

        Random rand = new Random();
        for (int i = 0; i < weights.Length; i++)
        {
            weights[i] = rand.NextDouble() * 2 - 1;
        }
    }

    private int Activation(double sum)
    {
        return sum >= 0 ? 1 : 0;
    }

    public void Train(double[][] inputs, int[] labels, int epochs)
    {
        for (int epoch = 0; epoch < epochs; epoch++)
        {
            Console.WriteLine($"Epoch {epoch + 1}/{epochs}:");
            for (int i = 0; i < inputs.Length; i++)
            {
                int prediction = Predict(inputs[i]);
                int error = labels[i] - prediction;

                for (int j = 0; j < weights.Length - 1; j++)
                {
                    weights[j] += learningRate * error * inputs[i][j];
                }
                weights[^1] += learningRate * error;

                Console.WriteLine($"Pesos: [{string.Join(", ", weights)}]");
            }
        }
    }

    public int Predict(double[] input)
    {
        double sum = 0;
        for (int i = 0; i < input.Length; i++)
        {
            sum += weights[i] * input[i];
        }
        sum += weights[^1];

        return Activation(sum);
    }

    public void TestNewCases(double[][] newCases)
    {
        Console.WriteLine("\nTestando novos casos:");
        foreach (var input in newCases)
        {
            int output = Predict(input);
            Console.WriteLine($"Entrada: [{string.Join(", ", input)}] - Saída: {(output == 1 ? "Maçã" : "Laranja")}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        double[][] inputs = new double[][]
        {
            new double[] {2.0, 1.0}, // Laranja
            new double[] {1.0, 1.0}, // Laranja
            new double[] {2.0, 2.0}, // Maçã
            new double[] {1.5, 1.5}, // Maçã
            new double[] {1.0, 2.0}, // Maçã
            new double[] {1.0, 0.5}  // Laranja
        };

        int[] labels = new int[] { 0, 0, 1, 1, 1, 0 }; // 0 = Laranja, 1 = Maçã

        Perceptron perceptron = new Perceptron(inputSize: 2);
        perceptron.Train(inputs, labels, epochs: 10);

        double[][] newCases = new double[][]
        {
            new double[] {1.5, 1.0},
            new double[] {2.5, 1.5},
            new double[] {0.5, 1.0},
            new double[] {1.5, 2.0},
            new double[] {1.0, 1.0}
        };

        perceptron.TestNewCases(newCases);
    }
}