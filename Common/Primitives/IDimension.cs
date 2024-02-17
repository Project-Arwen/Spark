namespace Ignite.Spark.Common.Primitives;

public interface IDimension<TResolution>
{
	public IList<IQuantumValue<TResolution>> Values { get; }
	
	public Dictionary<string, IMetadata> Metadata { get; }
}