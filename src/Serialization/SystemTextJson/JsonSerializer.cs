// ***********************************************************************
// <copyright file="JsonSerializer.cs" company="">
//     Copyright ©  2015
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace XLabs.Serialization.SystemTextJson
{
    using System.Text.Json;

	/// <summary>
	/// Class JsonSerializer.
	/// </summary>
	public class JsonSerializer : IJsonSerializer
    {
		/// <summary>
		/// The deserializer
		/// </summary>
		private readonly JsonParser deserializer;
		/// <summary>
		/// The serializer
		/// </summary>
		private readonly IJsonSerializer serializer;

		/// <summary>
		/// Initializes a new instance of the <see cref="JsonSerializer"/> class.
		/// </summary>
		/// <param name="serializer">The serializer.</param>
		public JsonSerializer(IJsonSerializer serializer)
        {
            this.deserializer = new JsonParser();
            this.serializer = serializer;
        }

		/// <summary>
		/// Gets the format.
		/// </summary>
		/// <value>The format.</value>
		public SerializationFormat Format
        {
            get { return SerializationFormat.Json; }
        }

		/// <summary>
		/// Flushes this instance.
		/// </summary>
		public void Flush()
        {
            this.serializer.Flush();
        }

		/// <summary>
		/// Serializes to bytes.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="obj">The object.</param>
		/// <returns>System.Byte[].</returns>
		public byte[] SerializeToBytes<T>(T obj)
        {
            return this.serializer.SerializeToBytes(obj);
        }

		/// <summary>
		/// Deserializes the specified data.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="data">The data.</param>
		/// <returns>T.</returns>
		public T Deserialize<T>(byte[] data)
        {
            return this.DeserializeFromBytes<T>(data);
        }

		/// <summary>
		/// Deserializes the specified data.
		/// </summary>
		/// <param name="data">The data.</param>
		/// <param name="type">The type.</param>
		/// <returns>System.Object.</returns>
		public object Deserialize(byte[] data, System.Type type)
        {
            return this.DeserializeFromBytes(data, type);
        }

		/// <summary>
		/// Serializes the specified object.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="obj">The object.</param>
		/// <param name="stream">The stream.</param>
		public void Serialize<T>(T obj, System.IO.Stream stream)
        {
            this.serializer.Serialize(obj, stream);
        }

		/// <summary>
		/// Deserializes the specified stream.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="stream">The stream.</param>
		/// <returns>T.</returns>
		public T Deserialize<T>(System.IO.Stream stream)
        {
            return this.deserializer.Parse<T>(stream);
        }

		/// <summary>
		/// Deserializes the specified stream.
		/// </summary>
		/// <param name="stream">The stream.</param>
		/// <param name="type">The type.</param>
		/// <returns>System.Object.</returns>
		public object Deserialize(System.IO.Stream stream, System.Type type)
        {
            return this.deserializer.Parse(stream);
        }

		/// <summary>
		/// Serializes the specified object.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="obj">The object.</param>
		/// <returns>System.String.</returns>
		public string Serialize<T>(T obj)
        {
            return this.serializer.Serialize(obj);
        }

		/// <summary>
		/// Deserializes the specified data.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="data">The data.</param>
		/// <returns>T.</returns>
		public T Deserialize<T>(string data)
        {
            return this.deserializer.Parse<T>(data);
        }

		/// <summary>
		/// Deserializes the specified data.
		/// </summary>
		/// <param name="data">The data.</param>
		/// <param name="type">The type.</param>
		/// <returns>System.Object.</returns>
		public object Deserialize(string data, System.Type type)
        {
            return this.deserializer.Parse(data);
        }
    }
}