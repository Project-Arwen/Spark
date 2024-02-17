namespace Ignite.Spark.Common.Primitives;

public interface IQuantumValue<out T>
{
	T Value { get; }
}