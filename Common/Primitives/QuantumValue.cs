namespace Ignite.Spark.Common.Primitives;

public abstract class QuantumValue<T>(T value) : IQuantumValue<T>
{
	public T Value { get; } = value;
}