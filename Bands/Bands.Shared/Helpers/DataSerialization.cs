using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using Windows.Data.Json;

namespace SoundCloudeStreaming.Helper
{

    /// <summary>
    /// Serialization Helper Class Developed By Ahmed Mabrouck.
    /// </summary>
    public static class DataSerialization
    {
        /// <summary>
        /// Serializer data format (JSON or XML) enum.
        /// </summary>
        public enum Formatting { JSON, XML };

        /// <summary>
        /// Serializes object of type T and returns serialized data.
        /// </summary>
        /// <typeparam name="T">Serializable object type.</typeparam>
        /// <param name="serializableObject">An object to be serialized.</param>
        /// /// <param name="format">Serialized data formatting (JSON or XML).</param>
        /// <returns> 
        /// Serialized data as string.
        /// </returns> 
        public static string Serialize<T>(T serializableObject, Formatting format)
        {
            try
            {
                var serializer = GetSerializer(format, typeof(T));
                using (MemoryStream stream = new MemoryStream())
                {
                    serializer.WriteObject(stream, serializableObject);
                    stream.Position = 0;
                    StreamReader streamReader = new StreamReader(stream);
                    return streamReader.ReadToEnd();
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Deserializes JSON or XML string and returns deserialized object.
        /// </summary>
        /// <typeparam name="T">derserialized object type.</typeparam>
        /// <param name="serializableObject">Serialized String.</param>
        /// /// <param name="format">Serialized data formatting (JSON or XML).</param>
        /// <returns> 
        /// Deserialized data as string.
        /// </returns> 
        public static T Deserialize<T>(string serializedObject, Formatting format)
        {
            try
            {
                var serializer = GetSerializer(format, typeof(T));
                using (MemoryStream stream = new MemoryStream(Encoding.Unicode.GetBytes(serializedObject)))
                {
                    return (T)serializer.ReadObject(stream);
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Returns DataContractSerializer according to passed format and type.
        /// </summary>
        /// <param name="format">Serialized data formatting (JSON or XML).</param>
        /// <param name="type">.</param>
        /// <returns> 
        /// Deserialized data as string.
        /// </returns> 
        private static dynamic GetSerializer(Formatting format, Type type)
        {
            switch (format)
            {
                case Formatting.JSON:
                    return new DataContractJsonSerializer(type);

                case Formatting.XML:
                    return new DataContractSerializer(type);
            }
            return null;
        }
    }
}
